using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDas.Components;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SmartDas.POPUP;
using System.Data.SqlClient;
using System.Collections;

namespace SmartDas
{
    public partial class DA0700 : SmartDas.Components.BaseForm
    {
        public string sUseMoldyn;
        public string sUseMoldcode;
        public string sUseMoldname;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         

        public DA0700()
        {
            InitializeComponent();

        }

        private void DA0700_Load(object sender, EventArgs e)
        {
            txtmoldnotype.Text = "";
            SetButtons();

            if (sUseMoldyn == "N")
            {
                lblTitle.Text = "금형하형";

                txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
                txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;

                txtMoldCode.Text = sUseMoldcode;
                txtMoldName.Text = sUseMoldname;
                //btnmoldno.Dock = DockStyle.Fill;
                SetListmoldno();

                mesGrid1.Visible = false;
                btnmoldno.Visible = true;
                
            }
            else
            {
                lblTitle.Text = "금형상형";
                txtMoldCode.Text = sUseMoldcode;
                txtMoldName.Text = sUseMoldname;
                SetGrid();
                DoFind();
                Init();
                //SetMessage("품목을 선택하세요.");

                mesGrid1.Visible = true;
                btnmoldno.Visible = false;
            }



        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 12;
            mesGrid1.SelectProcedureName = "USP_DA0700_S1";
            mesGrid1.CountRows = 6;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
          //  txtMoldCode.Text = "";
          //  txtMoldName.Text = "";
            //dtpStartDate.Value = Convert.ToDateTime(Common.gRecDate);
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();
        }
        
        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {

            try
            {
                sender.Enabled = false;
                DoProgress();

                if (!_bUseNetwork)
                {
                    SetMessage("C:S00018");
                    return;
                }
                switch (sender.Text)
                {
                    case "등록":
                        if (string.IsNullOrEmpty(txtMoldCode.Text))
                        {
                            SetMessage("금형을 선택하세요.");
                            return;
                        }

                        if (sUseMoldyn == "N")
                        {
                            if (string.IsNullOrEmpty(txtmoldnotype.Text))
                            {
                                SetMessage("타입을 선택하여 주십시오");
                                return;
                            }
                        }

                        if (sUseMoldyn=="N" || txtMoldCode.Text != sUseMoldcode)
                        {

                            WorkCenter wc = Common.SelectedWorkCenter;

                            Database dbSave = DatabaseFactory.CreateDatabase();
                            SqlConnection conSave = (SqlConnection)dbSave.CreateConnection();

                            SqlCommand cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0700_I2");
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@pMoldCode", txtMoldCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@UseMoldyn", sUseMoldyn));
                            cmd.Parameters.Add(new SqlParameter("@Moldouttype", txtmoldnotype.Text));

                            if (!clsDB.gExecuteProcedure(conSave, cmd))
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if ((e._UltraGridColumn == null) || (e._UltraGridRow == null))
                return;

            DoProgress();

            txtMoldCode.Text = e._UltraGridRow.Cells["MoldCode"].Value.ToString();
            txtMoldName.Text = e._UltraGridRow.Cells["MoldName"].Value.ToString();


            string sValue = mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value.ToString();

            for (int i = 0; i < mesGrid1.Rows.Count; i++)
                mesGrid1.Rows[i].Cells["Sel"].Value = " ";

            mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value = sValue == " " ? "√" : " ";

            CloseProgressForm();
        }

        private void SetListmoldno()
        {
            btnmoldno.CountX = 5;
            btnmoldno.CountY = 3;

            btnmoldno.SelectProcedureName = "USP_DA0700_MOLDOUT_S1";
            btnmoldno.SetStoreProc();

            btnmoldno.ParameterList.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
            

            btnmoldno.ParameterList["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;

            
            btnmoldno.DoFind();

        }

        private void btnMachineList_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {

            
            txtmoldnotype.Text = sender.Tag.ToString();
            
        }


    }
}
