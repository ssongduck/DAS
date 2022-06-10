using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SmartDas.Components;
using SmartDas.POPUP;
using Infragistics.Win.UltraWinGrid;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace SmartDas
{
    public partial class DA2100 : BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        string cur_lotno = "";
        private int lotPrnCnt = 2;

        public DA2100()
        {
            InitializeComponent();

            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();
            DataRow dr = db.ExecuteDataSet(CommandType.Text, "SELECT  LotPrnCnt  FROM TBM0600 	 WHERE WorkCenterCode  ='" + Common.SelectedWorkCenter.Code + "'").Tables[0].Rows[0];
            lotPrnCnt = Convert.ToInt32(dr["LotPrnCnt"]);
        }

        private void DA2100_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();

            DoFind();
        }

        // 버튼 생성
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            //btnConfBox[0, 1].Text = "보정"; 
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA2100_S2";
            mesGrid1.CountRows = 10;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtDayNight.Text = "전체";
            txtDayNight.Tag = "A";
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            txtLotQty.Text = "0";
            txtTotalProdQty.Text = "0";
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            string sDate = string.Format("{0:yyyy-MM-dd}", dtpDate.Value);

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDATE", sDate));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDiv", mesLabelDiv.Text == "List"?"L":"S"));
            
            mesGrid1.DoFind();

            int iTotalProd = 0;
            foreach (UltraGridRow row in mesGrid1.Rows)
                iTotalProd += clsDB.nvlInt(row.Cells["PRODQTY"].Value);

            txtLotQty.Text = mesGrid1.Rows.Count.ToString();
            txtTotalProdQty.Text =  string.Format("{0:0,0}", iTotalProd);
        }
            
        // 버튼 컨트롤
        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Text)
            {
                case "조회":
                    // 조회시 처리 내역
                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }
                    DoFind();
                    break;

                //case "보정":
                //    // 조회시 처리 내역
                //    if (!bUseNetwork)
                //    {
                //        SetMessage("C:S00018");
                //        return;
                //    }

                //    DA2110 da2110 = new DA2110();
                //    da2110.sItemCode = mesGrid1.Row.Cells["ItemCode"].Value.ToString();
                //    da2110.sOrderNo = mesGrid1.Row.Cells["OrderNo"].Value.ToString();
                //    da2110.sRecdate = mesGrid1.Row.Cells["RECDATE"].Value.ToString();

                //    ShowDialogForm(da2110);

                //    break;

                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        // 주간/야간 조회조건 변경
        private void txtDayNight_Click(object sender, EventArgs e)
        {
            // 전체(A) -> 주간(D) -> 야간(N) -> 전체(A)
            switch (txtDayNight.Tag.ToString())
            {
                case "A" :
                    txtDayNight.Text = "주간";
                    txtDayNight.Tag = "D";
                    break;
                case "D" :
                    txtDayNight.Text = "야간";
                    txtDayNight.Tag = "N";
                    break;
                case "N" :
                    txtDayNight.Text = "전체";
                    txtDayNight.Tag = "A";
                    break;
                default :
                    txtDayNight.Text = "전체";
                    txtDayNight.Tag = "A";
                    break;
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridCell.Text == "재발행")
            {
                cur_lotno = e._UltraGridRow.Cells[1].Value.ToString();//"LOT NO"
                DA0500 da0500 = new DA0500();
                if (Common.gsDASDivision == "C")     // 주조
                    da0500.ReDCLabelPrint(cur_lotno);
                else if (Common.gsDASDivision == "H")     // 함체
                    da0500.HamLabelPrint(cur_lotno,false,true);
              //  else if (Common.SelectedWorkCenter.Code.StartsWith("460") == true || Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306")//V/BODY 
                else if (Common.gsPlantCode == "SK1" && lotPrnCnt > 2) //(Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306")) 
                {
                   // da0500.VBLabelPrint(Common.SelectedWorkCenter.Code, (Common.SelectedWorkCenter.Code == "4603" ? 3 : 4), cur_lotno);
                    da0500.VBLabelPrint(Common.SelectedWorkCenter.Code, lotPrnCnt, cur_lotno);
                }
                else
                    da0500.RePSLabelPrint(cur_lotno);



            }
        }

        private void mesLabelDiv_Click(object sender, EventArgs e)
        {
            if (mesLabelDiv.Text == "List")
                mesLabelDiv.Text = "집계";
            else
                mesLabelDiv.Text = "List";

        }
    }
}
