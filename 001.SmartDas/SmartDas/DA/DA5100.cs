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

namespace SmartDas
{
    public partial class DA5100 : BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        string cur_lotno = "";

        public DA5100()
        {
            InitializeComponent();
        }

        private void DA5100_Load(object sender, EventArgs e)
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

            mesGrid1.SelectProcedureName = "USP_DA5100_S1";
            mesGrid1.CountRows = 10;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtDayNight.Text = "전체";
            txtDayNight.Tag = "A";
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            txtIngotQty.Text = "0";
            txtScrapQty.Text = "0";
            txtTotalQty.Text = "0";
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

            mesGrid1.DoFind();

            int iTemp = 0;
            int iIngotQty = 0;
            int iScrapQty = 0;
            int iTotalQty = 0;
            foreach (UltraGridRow row in mesGrid1.Rows)
            {
                iTemp = clsDB.nvlInt(row.Cells["PRODQTY"].Value);
                iTotalQty += iTemp;

                if (clsDB.nvlString(row.Cells["DIVISION"].Value) == "INGOT")
                    iIngotQty += iTemp;
                else iScrapQty += iTemp;
            }

            txtIngotQty.Text = string.Format("{0:#,##0}", iIngotQty);
            txtScrapQty.Text = string.Format("{0:#,##0}", iScrapQty);
            txtTotalQty.Text = string.Format("{0:#,##0}", iTotalQty);
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
    }
}
