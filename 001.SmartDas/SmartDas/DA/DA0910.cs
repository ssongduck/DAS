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
    public partial class DA0910 : SmartDas.Components.BaseForm
    {
        public string sMachCode;
        public string sMachName;
        public string sMoldCode;

        public WorkCenter wc = Common.SelectedWorkCenter;
        public string sSearchflag = string.Empty;

        public DA0910()
        {
           
            InitializeComponent();

            SetButtons();
            
           
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;

            txtMachErrCode.Text = "";
            txtMachErrName.Text = "";
            txtWorkerCode.Text = "";
            txtWorkerName.Text = "";


            SetProcWorker();
            SetGrid();

            DoFind();

            ShowBtnBox(false);
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "긴급등록";
            
            btnConfBox[0, 1].Text = "취소";

            mesLabel3.BackColor = Color.LightSkyBlue;
            btnConfBox.RedrawButtons();

            btnSelection.CountX = 5;
            btnSelection.CountY = 3;

            btnSelection.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Selection;
            btnSelection.SelectionMode = ButtonBox.SelectionModeEnum.None;

            btnSelection.SelectProcedureName = "USP_DA0910_S3";
            btnSelection.SetStoreProc();

            btnSelection.SetButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA0910_S2";
        }

        private void DoFind()
        {
            mesGrid1.CountRows = 6;
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();
        }

        private void DoFind_btn()
        {
            // 조회
            btnSelection.ParameterList.Clear();
            btnSelection.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            btnSelection.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            btnSelection.ParameterList.Add(new SqlParameter("@searchflag", sSearchflag));

            btnSelection.DoFind();

            btnConfBox.RedrawButtons();
        }



        private void SetProcWorker()
        {
            try
            {
                DoProgress();

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection dconn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0900_S2");

                cmd.Connection = dconn;

                DataSet ds = new DataSet();

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkDate", Common.gRecDate));
                cmd.Parameters.Add(new SqlParameter("@pDayNight", Common.gDayNight));
                cmd.Parameters.Add(new SqlParameter("@pType", "M"));

                WorkerList wl = Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.MACH);
                wl.Clear();

                if (clsDB.gCreateRSet(cmd, ds))
                {
                    DataTable dt = null;

                    if (ds.Tables.Count == 2)
                        dt = ds.Tables[1];
                    else if (ds.Tables.Count == 1)
                        dt = ds.Tables[0];

                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            //WorkerID, WorkerName, EmpTelNo, '' as Sel
                            wl.AddWorker(dr["WorkerID"].ToString(), dr["WorkerName"].ToString(), dr["EmpTelNo"].ToString());
                        }
                    }
                }

                CloseProgressForm();
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }
            finally
            {
                CloseProgressForm();
            }

        }

        private void DA0910_Load(object sender, EventArgs e)
        {
            

            txtMachName.Text = sMachName;
            txtMachName.Tag = sMachCode;
            txtMachCode.Text = sMachCode;

       
            
        }

        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {

            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "긴급등록":
                        if (string.IsNullOrEmpty(txtWorkerCode.Text))
                        {
                            SetMessage("작업자를 등록하여 주십시오.");
                            txtWorkerCode_Click(null, null);
                            return;
                        }

                        if (ShowDialogForm(new MessageForm("설비 긴급 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                            return;

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA0910_I1";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        cmd.Parameters.Add(new SqlParameter("@pMachCode", sMachCode));

                        cmd.Parameters.Add(new SqlParameter("@pDivisionCode", txtMachErrCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@pWorkerCode", txtWorkerCode.Text));
                    
                        if (clsDB.gExecute(conn, cmd) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc == "" ? "이미 등록된 고장정보입니다." : clsDB.ErrorDesc);
                            return;
                        }
                     
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;

                        break;

                    case "점검등록":
                        
                        if (ShowDialogForm(new MessageForm("설비 일상 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                            return;

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        Database db2 = DatabaseFactory.CreateDatabase();
                        SqlConnection conn2 = (SqlConnection)db2.CreateConnection();

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = conn2;

                        cmd2.CommandText = "USP_DA0910_I2";
                        cmd2.CommandType = CommandType.StoredProcedure;

                        cmd2.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                        cmd2.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        cmd2.Parameters.Add(new SqlParameter("@pMachCode", sMachCode));
                        cmd2.Parameters.Add(new SqlParameter("@pDESC", txtMAdesc.Text.Trim()));

                        if (clsDB.gExecute(conn2, cmd2) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc == "" ? "이미 등록된 점검정보입니다." : clsDB.ErrorDesc); return;
                        }

                     //   MessageBoxShow("설비 점검이 등록이 완료 되었습니다.");

                        DoFind();

                        break;

                    case "취소":
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
                txtMAdesc.Text = "";
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        private void mesLabel3_Click(object sender, EventArgs e)
        {
            if (btnConfBox[0, 0].Text != "긴급등록")
            {
                btnConfBox[0, 0].Text = "긴급등록";
                mesLabel3.BackColor = Color.LightSkyBlue;
                mesLabel6.BackColor = Color.LightGreen;
                btnConfBox.RedrawButtons();
            }
        }

        private void mesLabel6_Click(object sender, EventArgs e)
        {
            ShowBtnBox(false); 

            DoFind();

            if (btnConfBox[0, 0].Text != "점검등록")
            {
                
                btnConfBox[0, 0].Text = "점검등록";
                mesLabel3.BackColor = Color.LightGreen;
                mesLabel6.BackColor = Color.LightSkyBlue;
                btnConfBox.RedrawButtons();
            }

        }

        private void txtMAdesc_MouseClick(object sender, MouseEventArgs e)
        {
            ShowBtnBox(false); 
            
            if (btnConfBox[0, 0].Text != "점검등록")
            {

                btnConfBox[0, 0].Text = "점검등록";
                mesLabel3.BackColor = Color.LightGreen;
                mesLabel6.BackColor = Color.LightSkyBlue;
                btnConfBox.RedrawButtons();
            }
        }

        private void txtMachErrCode_Click(object sender, EventArgs e)
        {
            ShowBtnBox(true); 

            sSearchflag = "1";
            DoFind_btn();
        }

        private void txtWorkerCode_Click(object sender, EventArgs e)
        {
            ShowBtnBox(true); 

            sSearchflag = "2";
            DoFind_btn();
            mesLabel3_Click(null, null);
        }

        private void btnSelection_Leave(object sender, EventArgs e)
        {
            ShowBtnBox(false); 
        }

        private void btnSelection_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (sSearchflag == "1")
            {
                txtMachErrCode.Text = sender.Tag.ToString();
                txtMachErrName.Text = sender.Text;
            }
            else if (sSearchflag == "2")
            {
                txtWorkerCode.Text = sender.Tag.ToString();
                txtWorkerName.Text = sender.Text;
            }

            ShowBtnBox(false);
        }

        private void ShowBtnBox(bool bShow)
        {
            btnSelection.Visible = bShow;

            if (bShow)
            {
                btnLeftPage.LinkGrid = null;
                btnLeftPage.LinkButtonBox = btnSelection;

                btnRightPage.LinkGrid = null;
                btnRightPage.LinkButtonBox = btnSelection;
            }
            else
            {
                btnLeftPage.LinkGrid = mesGrid1;
                btnLeftPage.LinkButtonBox = null;

                btnRightPage.LinkGrid = mesGrid1;
                btnRightPage.LinkButtonBox = null;
            }
        }
    }
}
