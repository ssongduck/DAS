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

namespace SmartDas
{
    public partial class DA1010 : SmartDas.Components.BaseForm
    {
        public string sWorkcentercode = string.Empty;
        public string sWorkcentername = string.Empty;
        public string sfaultflag = string.Empty;
        public string sMachcode = string.Empty;
        public string sMachname = string.Empty;
        public string sSearchflag = string.Empty;
        public string sdate = string.Empty;
    

        public DA1010()
        {
            InitializeComponent();
        }

        private void DA1010_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtMachCode.Text = sMachcode;
            txtMachName.Text = sMachname;
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();


            btnListBox.CountX = 10;
            btnListBox.CountY = 3;
            btnListBox.SelectProcedureName = "[USP_DA1010_S2]";
            btnListBox.SetStoreProc();

            btnListBox.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            btnListBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));
            btnListBox.ParameterList.Add(new SqlParameter("@searchflag",SqlDbType.VarChar, 1));

            //btnListBox.DoFind();
        }


        private void SetGrid()
        {
            mesGrid1.FontSize = 17;

            mesGrid1.SelectProcedureName = "USP_DA1010_S1";
        }

        private void DoFind()
        {
            mesGrid1.CountRows = 6;
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", txtWorkCenterCode.Text));
            
            mesGrid1.ParameterList.Add(new SqlParameter("@searchflag", sSearchflag));

            mesGrid1.DoFind();

            btnListBox.ParameterList["@searchflag"].Value = sSearchflag;
            btnListBox.DoFind();
            if (sSearchflag == "5")
            {//작업자
                btnListBox.SelectionMode = ButtonBox.SelectionModeEnum.Multiple;
              //  btnListBox.ButtonBoxType =  ButtonBox.ButtonBoxTypeEnum.Selection;
            }
            else
            {
                btnListBox.SelectionMode = ButtonBox.SelectionModeEnum.Single;
              //  btnListBox.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Buttons;
            }
   
        }

     
        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
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
                    case "등록":

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        if (txtmacherror.Text == "")
                        {
                            SetMessage("설비고장을 등록하여 주십시오.");
                            return;
                        }
                       if (txterrortype.Text == "")
                        {
                            SetMessage("고장유형을 등록하여 주십시오.");
                            return;
                        }
                       if (txterrorresson.Text == "")
                        {
                            SetMessage("고장원인을 등록하여 주십시오.");
                            return;
                        }
                       if (txtrepaircode.Text == "")
                       {
                           SetMessage("수리내역을 등록하여 주십시오.");
                           return;
                       }
                       if (txtworkerid.Text == "")
                       {
                           SetMessage("보전원을 등록하여 주십시오.");
                           return;
                       }
 
                            Database db = DatabaseFactory.CreateDatabase();
                            SqlConnection conn = (SqlConnection)db.CreateConnection();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;

                            cmd.CommandText = "USP_DA1000_I1";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@PPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                            cmd.Parameters.Add(new SqlParameter("@PMACHCODE", txtMachCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@PSTARTDATE", sdate));
                            cmd.Parameters.Add(new SqlParameter("@PSTATUS", "G"));
                            cmd.Parameters.Add(new SqlParameter("@PMAUSER", txtworkerid.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PMAUSERNM", txtworker.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PFAULT", txterrortype.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PMACHFAULT", txtmacherror.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PREASON", txterrorresson.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PMACODE", txtrepaircode.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PMADESC", txtMAdesc.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PFAULTFLAG", sfaultflag));
                            
                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                // 오류 발생시
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }

                            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                      
                     
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

        private void txtmacherror_Click(object sender, EventArgs e)
        {
            sSearchflag = "1";
            DoFind();
            mesLabel3.Text = Labelmacherror.Text;
        }

        private void txterrortype_Click(object sender, EventArgs e)
        {
            sSearchflag = "2";
            DoFind();
            mesLabel3.Text = Labelerrortype.Text;
        }

        private void txterrorresson_Click(object sender, EventArgs e)
        {
            sSearchflag = "3";
            DoFind();
            mesLabel3.Text = Labelerrorresson.Text;
        }

        private void txtrepaircode_Click(object sender, EventArgs e)
        {
            sSearchflag = "4";
            DoFind();
            mesLabel3.Text = Labelrepaircode.Text;
        }

        private void txtworker_Click(object sender, EventArgs e)
        {
            sSearchflag = "5";
            DoFind();
            mesLabel3.Text = Labelworker.Text;
            foreach (ButtonData btn in btnListBox.GetButtonList())
            {
                if (txtworkerid.Text.IndexOf(btn.Tag.ToString()) != -1)
                    btn.ButtonPressed = true;
            }

        }



        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (mesGrid1.Rows.Count > 0)
            {

                switch (sSearchflag)
                {
                    case "1":

                        txtmacherror.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells[0].Value.ToString();
                        txtmacherrorNm.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells[1].Value.ToString();
                        break;

                    case "2":

                        txterrortype.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["Faultcode"].Value.ToString();
                        txterrortypeNm.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["faultname"].Value.ToString();

                        break;
                    case "3":

                        txterrorresson.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["reasoncode"].Value.ToString();
                        txterrorressonNm.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["reasonname"].Value.ToString();
                        break;

                    case "4":

                        txtrepaircode.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["repairCode"].Value.ToString();
                        txtrepaircodeNm.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["repairName"].Value.ToString();
                        break;

                    case "5":

                         txtworkerid.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["WORKERID"].Value.ToString();
                         txtworker.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["WORKERNAME"].Value.ToString();


                        break;

                }

            }

        }

        private void btnListBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sSearchflag)
            {
                case "1":
                    txtmacherror.Text = sender.Tag.ToString();
                    txtmacherrorNm.Text = sender.Text;
                    break;

                case "2":
                    txterrortype.Text = sender.Tag.ToString();
                    txterrortypeNm.Text = sender.Text;
                    break;

                case "3":
                    txterrorresson.Text = sender.Tag.ToString();
                    txterrorressonNm.Text = sender.Text;
                    break;

                case "4":
                    txtrepaircode.Text = sender.Tag.ToString();
                    txtrepaircodeNm.Text = sender.Text;
                    break;

                case "5":
                   // txtworkerid.Text = sender.Tag.ToString();
                   // txtworker.Text = sender.Text;
                         txtworkerid.Text = "";// sender.Tag.ToString();
                        txtworker.Text = "";//sender.Text;
                        foreach (ButtonData btn in btnListBox.GetSelectedButtons())
                        {
                            txtworkerid.Text += btn.Tag.ToString() + ",";
                            txtworker.Text += btn.Text + ",";
                        }
                        if (txtworker.Text.Length > 1)
                        {
                            txtworkerid.Text = txtworkerid.Text.Substring(0, txtworkerid.Text.Length - 1);
                            txtworker.Text = txtworker.Text.Substring(0, txtworker.Text.Length - 1);
                        }
                   break;

            }
        }

        private void btnListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
