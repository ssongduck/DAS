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
    public partial class DA2500 : BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        string cur_lotno = "";

        public DA2500()
        {
            InitializeComponent();
        }

        private void DA2500_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();

            DoFind();
        }

        // 버튼 생성
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            btnConfBox[0, 1].Text = "등록";
            btnConfBox[0, 2].Text = "취소";
            btnConfBox[0, 1].Enable = false;
            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            Grid1.FontSize = 15;

            Grid1.SelectProcedureName = "USP_DA2500_S1";
            Grid1.CountRows = 10;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            txtItemCode.Text = "";// wc.ItemCode;
            txtItemName.Text = "";// wc.ItemName;

            txtQty.Text = "";
          
        }

        private void DoFind()
        {
            Grid1.GetStoreProcedure();

            string sDate = string.Format("{0:yyyy-MM-dd}", dtpDate.Value);

            // 조회
            Grid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            Grid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            Grid1.ParameterList.Add(new SqlParameter("@pDATE", sDate));
       //     mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag));

            Grid1.DoFind();



            txtQty.Text = "";
        }
            
        // 버튼 컨트롤
        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                if (!_bUseNetwork)
                {
                    SetMessage("C:S00018");
                    return;
                }

                DoProgress();
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

                    case "등록":
                        if (txtItemCode.Text == "" || txtQty.Text == "" || Convert.ToInt32(txtQty.Text) == 0)
                        {
                            SetMessage("품번과 수량이 입력되어야 합니다.");
                            return;
                        }


                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection con = (SqlConnection)db.CreateConnection();
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.CommandText = "USP_DA2500_I1";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@ItemCode", txtItemCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@Qty", txtQty.Text));

                        //[USP_DA8000_I1 작지생성
                        if (!clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            string sql = " select top 1  LotNO from TPP0100 where PlantCode='" + wc.PlantCode + "' and WorkCenterCode = '" + wc.Code + "' and  substring(LotNO,11,1)='5' order by LotNO desc ";
                            cur_lotno = db.ExecuteScalar(CommandType.Text, sql).ToString();


                            DA0500 da0500 = new DA0500();
                            da0500.HamLabelPrint(cur_lotno, true);

                            txtItemCode.Text = "";
                            txtQty.Text = "";
                            Grid1.DoFind();
                            SetMessage("");
                        }
                        break;

                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        // 주간/야간 조회조건 변경
        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            cur_lotno = e._UltraGridRow.Cells["LOTNO"].Value.ToString();//"LOT NO"
            if (e._UltraGridCell.Text == "재발행")
            {
                DA0500 da0500 = new DA0500();
                da0500.HamLabelPrint(cur_lotno,true,true);
             }
            else if (e._UltraGridCell.Text == "삭제")
            {
                if (e._UltraGridRow.Cells["div"].Value.ToString() != "0")
                {
                    SetMessage("함침작업에 투입되어 삭제 할수 없습니다.");
                    return;
                }
  
                DA9300 d1 = new DA9300();
                d1.ButtonCount = 2;
                d1.ButtonNames[0] = "삭제\r\n확인";
                d1.ButtonNames[1] = "취소";

                d1.StartPosition = FormStartPosition.Manual;
                d1.Location = new Point(Cursor.Position.X - 350, Cursor.Position.Y - d1.Size.Height - 10);

                ShowDialogForm(d1);

    
                if (d1.DialogResult ==  DialogResult.Cancel)
                {
                  return;
                }



                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection con = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "USP_DA2500_D1";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@LotNo", cur_lotno));
 
                //[USP_DA8000_I1 작지생성
                if (!clsDB.gExecuteProcedure(con, cmd))
                {
                    SetMessage(clsDB.ErrorDesc);
                    return;
                }
                else
                {
                    Grid1.DoFind();
                }

                 
            }

        }

        private void txtItemCode_Click(object sender, EventArgs e)
        {
            DA9510 d = new DA9510();
          //  d. = txtQty.Text.Trim();

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtItemCode.Text = d.resultArray[0];
                 txtItemName.Text = d.resultArray[1];
            }


        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.ContentText = txtQty.Text.Trim();

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtQty.Text = d.ResultString;
             }

        }
    }
}
