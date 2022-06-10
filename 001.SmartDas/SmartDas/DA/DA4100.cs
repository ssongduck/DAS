using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace SmartDas
{
    public partial class DA4100 : SmartDas.Components.BaseForm
    {
        public DA4100()
        {
            InitializeComponent();

            SetButtons();
            SetGrid();

            DoFind();

            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
        }

        private void SetButtons()
        {
            btnMenu.CountX = 2;
            btnMenu.CountY = 1;

            btnMenu.SetButtons();

            btnMenu[0, 0].Text = "보급요청";
            btnMenu[0, 1].Text = "취소";

            btnMenu[0, 0].Tag = "N";
            btnMenu[0, 1].Tag = "C";

            //btnMenu[0, 0].MappingButton.Enabled = false;

            btnMenu.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;

            mesGrid1.SelectProcedureName = "USP_DA4100_S1";
        }

        private void DoFind()
        {
            mesGrid1.CountRows = 6;
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();

            if (mesGrid1.Rows.Count > 0)
            {
                btnMenu[0, 0].Text = "조회";
                btnMenu[0, 0].Tag = "S";

                btnMenu.RedrawButtons();
            }
            else
            {
                btnMenu[0, 0].Text = "보급요청";
                btnMenu[0, 0].Tag = "N";

                btnMenu.RedrawButtons();
            }

        }

        private void btnMenu_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {

            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Tag.ToString())
                { 
                    case "N":
                        
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA4100_I1";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        
                        cmd.Parameters.Add(new SqlParameter("@pStatus", sender.Tag.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@pResqty", txtrestqty.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@pPlantno", ""));


                        if (clsDB.gExecute(conn, cmd) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }

                        DoFind();

                        break;


                    case "S":
                        DoFind();

                        break;
                    //case "R":
                    //case "T":
                    //case "G":
                    //    if (!bUseNetwork)
                    //    {
                    //        SetMessage("C:S00018");
                    //        return;
                    //    }


                    //    if (sender.Tag.ToString() == "T")
                    //    {
                    //        DA1010 da1010 = new DA1010();
                         
                    //        da1010.sWorkcentercode = txtWorkCenterCode.Text;
                    //        da1010.sWorkcentername = txtWorkCenterName.Text;

                    //        if (DialogResult.OK == ShowDialogForm(da1010))
                    //        {
                    //            SetButtons();
                    //            DoFind();
                    //            SetGrid();
                                
                    //        }

                            

                    //        break;

                    //    }


                    //        //Database db = DatabaseFactory.CreateDatabase();
                    //        //SqlConnection conn = (SqlConnection)db.CreateConnection();

                    //        //SqlCommand cmd = new SqlCommand();
                    //        //cmd.Connection = conn;

                    //        //cmd.CommandText = "USP_DA4100_I1";
                    //        //cmd.CommandType = CommandType.StoredProcedure;

                    //        //cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                    //        //cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        
                    //        //cmd.Parameters.Add(new SqlParameter("@pStartDate", txtStartTime.Text));
                    //        //cmd.Parameters.Add(new SqlParameter("@pStatus", sender.Tag.ToString()));
                    //        //cmd.Parameters.Add(new SqlParameter("@pMAUser", ""));
                    //        //cmd.Parameters.Add(new SqlParameter("@pMACode",""));

                    //        //if (clsDB.gExecute(conn, cmd) < 0)
                    //        //{
                    //        //    // 오류 발생시
                    //        //    SetMessage(clsDB.ErrorDesc);
                    //        //    return;
                    //        //}

                    //        //DoFind();

                    //        //txtStartTime.Text = "";
                    //        //txtDelay.Text = "";

                    //        //btnMenu[0, 0].Text = "";
                    //        //btnMenu[0, 0].MappingButton.Enabled = btnMenu[0, 0].Text != "";

                    //        //btnMenu.RedrawButtons();
                    //        //break;
                        
                    case "C":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                sender.Enabled = true;
                    CloseProgressForm();
            }
        }

        private void mesGrid1_GridClick(object sender, Components.MESGrid.GridClickEventArg e)
        {

            txtStartTime.Text = e._UltraGridRow.Cells["StartDate"].Value.ToString();

            txtREQUESTSTARTDATE.Text = e._UltraGridRow.Cells["REQUESTSTARTDATE"].Value.ToString();
        
        }

        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (txtStartTime.Text.Trim() != "")
            {
                TimeSpan ts = (DateTime.Now - Convert.ToDateTime(txtStartTime.Text));
                string mes = "";

                mes = (ts.Days == 0 ? "" : ts.Days.ToString() + "일 ")
                    + (ts.Hours == 0 ? "" : ts.Hours.ToString() + "시간 ")
                    + (ts.Minutes == 0 ? "" : ts.Minutes.ToString() + "분 ")
                    + (ts.Seconds == 0 ? "" : ts.Seconds.ToString() + "초");

                txtREQUESTSTARTDATE.Text = mes;
            }
            else
            {
                txtREQUESTSTARTDATE.Text = "";
            }
        }
    }
}
