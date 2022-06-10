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
    public partial class DA0900 : SmartDas.Components.BaseForm
    {
        public string chkWorkcentercode = string.Empty;

        public DA0900()
        {
            InitializeComponent();
            SetButtons();
         
            SetListBoxStop();

            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;

            txtMachCode.Text = "";
            txtMachName.Text = "";
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

        private void SetListBoxStop()
        {
            btnMachineList.CountX = 5;
            btnMachineList.CountY = 3;

            btnMachineList.SelectProcedureName = "USP_DA0900_S1";
            btnMachineList.SetStoreProc();

            btnMachineList.ParameterList.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
            btnMachineList.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));

            btnMachineList.ParameterList["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
            btnMachineList.ParameterList["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;

            btnMachineList.DoFind();
        }

        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Text)
            {
                case "등록":

                    if (string.IsNullOrEmpty(txtMachCode.Text))
                    {
                        SetMessage("C:I00019");
                        return;
                    }

                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }
                    try
                    {
                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA0910_I2";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@PPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                        cmd.Parameters.Add(new SqlParameter("@PMACHCODE", txtMachCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@PSTARTDATE", Common.startDatetime.ToString("yyyy-MM-dd HH:mm:ss")));

                        if (clsDB.gExecute(conn, cmd) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch { }
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void btnMachineList_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            txtMachName.Text = sender.Text.Replace("\r\n"," ");
            txtMachName.Tag = sender.Tag.ToString();
            txtMachCode.Text = sender.Tag.ToString();
        }
    }
}
