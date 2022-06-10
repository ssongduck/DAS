using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

using SmartDas.Components;
using SmartDas.POPUP;

namespace SmartDas
{
    public partial class DA1000 : SmartDas.Components.BaseForm
    {
        public DA1000()
        {
            InitializeComponent();

            SetButtons();
            SetGrid();


            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
        }

        private void SetButtons()
        {
            btnMenu.CountX = 2;
            btnMenu.CountY = 1;

            btnMenu.SetButtons();

            btnMenu[0, 0].Text = "보전등록";
            btnMenu[0, 1].Text = "취소";

            btnMenu[0, 0].Tag = "";
            btnMenu[0, 1].Tag = "C";

            btnMenu[0, 0].MappingButton.Enabled = false;

            btnMenu.RedrawButtons();

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "현황";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

           // btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;
            mesGrid1.CountRows = 8;
            mesGrid1.SelectProcedureName = "USP_DA1000_S1";

            mesGrid2.FontSize = 15;
            mesGrid2.CountRows = 8;
            mesGrid2.SelectProcedureName = "USP_DA1000_S2";

        }

        private void DoFind()
        {
            if (mesGrid1.Visible)
            {
                mesGrid1.GetStoreProcedure();

                mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                mesGrid1.DoFind();
            }
            else
            {
                mesGrid2.GetStoreProcedure();

                // 조회
                mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));

                mesGrid2.DoFind();
            }
        }

        /// <summary>
        /// Do delete
        /// </summary>
        private void DoDelete()
        {
            if (mesGrid1.Visible)
            {
                if (mesGrid1.Row != null)
                {
                    if (mesGrid1.Rows[mesGrid1.Row.Index].Cells["PStatus"].Value.ToString() == "R")
                    {
                        if (ShowDialogForm(new MessageForm("고장요청 정보를 삭제 하시겠습니까?", MessageBoxButtons.YesNo, "삭제 확인")) != System.Windows.Forms.DialogResult.Yes)
                            return;

                        Database database = DatabaseFactory.CreateDatabase();
                        SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                        SqlCommand sqlCommand = new SqlCommand();

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.CommandText = "USP_DA1000_D1";
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.Add(new SqlParameter("@PPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                        sqlCommand.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                        sqlCommand.Parameters.Add(new SqlParameter("@PSTARTDATE", mesGrid1.Rows[mesGrid1.Row.Index].Cells["StartDate"].Value.ToString()));

                        if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            DoFind();
                        }
                    }
                }
            }
        }

        private void btnMenu_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            if (mesGrid1.Visible == false && sender.Tag.ToString() != "C")
                return;
            DoProgress();

            try
            {
                if (sender.Tag.ToString() == "R")
                {
                    DA0900 da0900 = new DA0900();

                    Common.startDatetime = Convert.ToDateTime(txtStartTime.Text);
                    ShowDialogForm(da0900);

                    if (da0900.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }

                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }

                    Database db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "USP_DA1000_I1";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                    cmd.Parameters.Add(new SqlParameter("@pMachCode", txtMachCode.Text));
                    cmd.Parameters.Add(new SqlParameter("@pStartDate", txtStartTime.Text));
                    cmd.Parameters.Add(new SqlParameter("@pStatus", sender.Tag.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@pMAUser", ""));
                    cmd.Parameters.Add(new SqlParameter("@pMAUserNM", ""));
                    cmd.Parameters.Add(new SqlParameter("@pFAULT", ""));
                    cmd.Parameters.Add(new SqlParameter("@pMACHFAULT", ""));
                    cmd.Parameters.Add(new SqlParameter("@pREASON", ""));
                    cmd.Parameters.Add(new SqlParameter("@pMACode", ""));
                    cmd.Parameters.Add(new SqlParameter("@pMADESC", ""));
                    cmd.Parameters.Add(new SqlParameter("@pFaultflag", txtfaultflag.Text.Trim()));

                    if (clsDB.gExecute(conn, cmd) < 0)
                    {
                        // 오류 발생시
                        SetMessage(clsDB.ErrorDesc);
                        return;
                    }

                    DoFind();

                    btnMenu[0, 0].Text = "";
                    btnMenu[0, 0].MappingButton.Enabled = btnMenu[0, 0].Text != "";
                }
                else if (sender.Tag.ToString() == "C")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else
                {
                    DA1010 da1010 = new DA1010();
                    da1010.sMachcode = txtMachCode.Text;
                    da1010.sMachname = txtMachName.Text;
                    da1010.sWorkcentercode = txtWorkCenterCode.Text;
                    da1010.sWorkcentername = txtWorkCenterName.Text;
                    da1010.sfaultflag = txtfaultflag.Text;
                    da1010.sdate = txtStartTime.Text;
                    ShowDialogForm(da1010);
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                CloseProgressForm();
                SetButtons();
                SetGrid();
                DoFind();

                btnMenu[0, 0].UseFlag = false;
                btnMenu.RedrawButtons();
                this.EventTimerEnable = false;
            }
        }

        private void mesGrid1_GridClick(object sender, Components.MESGrid.GridClickEventArg e)
        {
            txtMachCode.Text = e._UltraGridRow.Cells["MachCode"].Value.ToString();
            txtMachName.Text = e._UltraGridRow.Cells["MachName"].Value.ToString();
            txtStartTime.Text = e._UltraGridRow.Cells["StartDate"].Value.ToString();
            txtfaultflag.Text = e._UltraGridRow.Cells["Faultflag"].Value.ToString();


            if (e._UltraGridRow.Cells["PStatus"].Value.ToString() == "R")
            {
                btnMenu[0, 0].Tag = e._UltraGridRow.Cells["PStatus"].Value.ToString();
                btnMenu[0, 0].Text = e._UltraGridRow.Cells["StatusName"].Value.ToString();
            }
            else
            {
                btnMenu[0, 0].Tag = e._UltraGridRow.Cells["PStatus"].Value.ToString();
                btnMenu[0, 0].Text = "보전등록";
                
            }

            btnMenu[0, 0].MappingButton.Enabled = btnMenu[0, 0].Text != "";

            //this.EventTimerEnable = true;
            //this.EventTimerInterval = 1000;

            //EventTimer_Tick(this, new EventArgs());
            btnMenu[0, 0].UseFlag = true;
            btnMenu.RedrawButtons();
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

                txtDelay.Text = mes;
            }
            else
            {
                txtDelay.Text = "";
            }
        }

        private void DA1000_Load(object sender, EventArgs e)
        {
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);


            mesGrid1.Visible = true;
            mesGrid2.Visible = false;
            btnLeftPage.LinkGrid = mesGrid1;
            btnRightPage.LinkGrid = mesGrid1;

            btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
            btnRightPage.LinkMoveSize = mesGrid1.CountRows;

            dtpDate.Enabled = false;
            btnSearch.Enabled = false;

            DoFind();

        }

        private void btnSelect_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "현황":
                    mesGrid1.Visible = true;
                    mesGrid2.Visible = false;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = false;
                    btnSearch.Enabled = false;
                    btnDelete.Enabled = true;
                    DoFind();

                    break;
                case "실적":
                    mesGrid2.Visible = true;
                    mesGrid1.Visible = false;
                    btnLeftPage.LinkGrid = mesGrid2;
                    btnRightPage.LinkGrid = mesGrid2;

                    btnLeftPage.LinkMoveSize = mesGrid2.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid2.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;
                    btnDelete.Enabled = false;
                    DoFind();

                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDelete();
        }
    }
}
