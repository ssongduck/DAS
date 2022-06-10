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
    public partial class DA7000 : SmartDas.Components.BaseForm
    {
        //public string sWorkcentercode = string.Empty;
        //public string sWorkcentername = string.Empty;
        //public string sfaultflag = string.Empty;
        //public string sMoldname = string.Empty;
        //public string sMoldCode = string.Empty;
        public string sSearchflag = string.Empty;

        private WorkCenter wc = Common.SelectedWorkCenter;

        public DA7000()
        {
            InitializeComponent();
        }

        private void DA7000_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtMoldCode.Text = wc.MoldCode;
            txtMoldName.Text = wc.MoldName;

            txtMoldErrCode.Text = string.Empty;
            txtMoldErrName.Text = string.Empty;
            txtMoldErrLocCode1.Text = string.Empty;
            txtMoldErrLocName1.Text = string.Empty;
            txtMoldErrLocCode2.Text = string.Empty;
            txtMoldErrLocName2.Text = string.Empty;
            txtMoldErrDivCode.Text = string.Empty;
            txtMoldErrDivName.Text = string.Empty;

            txtWorkerCode.Text = string.Empty;
            txtWorkerName.Text = string.Empty;
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";
            //btnConfBox[0, 2].Text = "취소";

            btnConfBox.RedrawButtons();

            btnListBox.CountX = 5;
            btnListBox.CountY = 2;

            btnListBox.SelectProcedureName = "[USP_DA7000_S2]";
            btnListBox.SetStoreProc();

            btnListBox.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            btnListBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));
            btnListBox.ParameterList.Add(new SqlParameter("@searchflag", SqlDbType.VarChar, 1));
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.SelectProcedureName = "USP_DA7000_S1";

            mesGrid2.FontSize = 14;
            mesGrid2.SelectProcedureName = "USP_DA7000_S0";

            mesGrid2.CountRows = 5;
            mesGrid2.GetStoreProcedure();

            mesGrid2.DoFind();

            mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
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
        }

         private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress(); 
                switch (sender.Text)
                {
                    case "등록":

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }
                        if (txtCause.Tag.ToString() == "N" && mesGrid2.Rows.Count == 0)
                        {
                            DataRow dr = mesGrid2.DataSourceDS.Tables[1].NewRow();

                            dr.SetField(0, "");
                            dr.SetField(1, "");
                            dr.SetField(2, "");
                            dr.SetField(3, "");
                            dr.SetField(4, "");
                            dr.SetField(5, "");
                            dr.SetField(6, "");
                            dr.SetField(7, "");
                            dr.SetField(8, "");
                            mesGrid2.DataSourceDS.Tables[1].Rows.Add(dr);
                        }

                        if (mesGrid2.Rows.Count == 0)
                        {
                            SetMessage("하나 이상의 고장내역을 등록하십시오.");
                            return;
                        }

                        WorkCenter wc = Common.SelectedWorkCenter;

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA7000_I1";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@pMoldCode", wc.MoldCode));
                        cmd.Parameters.Add(new SqlParameter("@RecDate", SqlDbType.VarChar, 10));
                        cmd.Parameters["@RecDate"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@Seq",SqlDbType.Int));
                        cmd.Parameters["@Seq"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@pEmergencyFlag", txtEmergency.Tag.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@pCauseFlag", txtCause.Tag.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@pErrorWorker", txtWorkerCode.Text.Trim()));

                        if (clsDB.gExecute(conn, cmd) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }

                        int iSeq = Convert.ToInt32(cmd.Parameters["@Seq"].Value);
                        string sRecDate = cmd.Parameters["@RecDate"].Value.ToString();

                        cmd.CommandText = "USP_DA7000_I2";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@pMoldCode", wc.MoldCode));
                        cmd.Parameters.Add(new SqlParameter("@RecDate", sRecDate));
                        cmd.Parameters.Add(new SqlParameter("@Seq", iSeq));

                        cmd.Parameters.Add(new SqlParameter("@UnitSeq", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@pMoldErrCode", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pMoldErrLocCode1", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pMoldErrLocCode2", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pMoldErrDivCode", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pRemark", SqlDbType.VarChar, 100));

                        int iTemp = 1;
                        foreach (DataRow dr in mesGrid2.DataSourceDS.Tables[1].Rows)
                        {
                            cmd.Parameters["@UnitSeq"].Value = iTemp++;
                            cmd.Parameters["@pMoldErrCode"].Value = dr["ErrCode"];
                            cmd.Parameters["@pMoldErrLocCode1"].Value = dr["ErrLocCode1"];
                            cmd.Parameters["@pMoldErrLocCode2"].Value = dr["ErrLocCode2"];
                            cmd.Parameters["@pMoldErrDivCode"].Value = dr["ErrDivCode"];
                            cmd.Parameters["@pRemark"].Value = dr["Remark"];

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                // 오류 발생시
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
            catch (Exception ex)
            {
                SetMessage(ex.ToString());
            }
            finally
            {
                CloseProgressForm();
                sender.Enabled = true;
             }
        }

        //private void DA7000_Load(object sender, EventArgs e)
        //{
        //    txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
        //    txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
        //    txtMoldCode.Text = sMachcode;
        //    txtMoldName.Text = sMachname;
        //}

        private void txtMoldErrCode_Click(object sender, EventArgs e)
        {
            sSearchflag = "1";
            lblList.Text = lblMoldErrCode.Text;

            DoFind();
        }

        private void txtMoldErrLocCode1_Click(object sender, EventArgs e)
        {
            sSearchflag = "2";
            lblList.Text = lblMoldErrLocCode1.Text;

            DoFind();
        }

        private void txtMoldErrLocCode2_Click(object sender, EventArgs e)
        {
            sSearchflag = "3";
            lblList.Text = lblMoldErrLocCode2.Text;

            DoFind();
        }

        private void txtMoldErrDivCode_Click(object sender, EventArgs e)
        {
            sSearchflag = "4";
            lblList.Text = lblMoldErrDivCode.Text;

            DoFind();
        }

        private void txtworker_Click(object sender, EventArgs e)
        {
            sSearchflag = "5";
            lblList.Text = lblWorker.Text;

            DoFind();
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (mesGrid1.Rows.Count > 0)
            {

                switch (sSearchflag)
                {
                    case "1" :

                        txtMoldErrCode.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultCode"].Value.ToString();
                        txtMoldErrName.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultName"].Value.ToString();
                        break;

                    case "2":

                        txtMoldErrLocCode1.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultCode"].Value.ToString();
                        txtMoldErrLocName1.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultName"].Value.ToString();

                        break;
                    case "3":

                        txtMoldErrLocCode2.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultCode"].Value.ToString();
                        txtMoldErrLocName2.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultName"].Value.ToString();
                        break;

                    case "4":

                        txtMoldErrDivCode.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultCode"].Value.ToString();
                        txtMoldErrDivName.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["FaultName"].Value.ToString();
                        break;

                    case "5":

                        txtWorkerCode.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["WORKERID"].Value.ToString();
                        txtWorkerName.Text = mesGrid1.Rows[e._UltraGridRow.Index].Cells["WORKERNAME"].Value.ToString();
                        break;

                }

            }

        }

        private void txtEmergency_Click(object sender, EventArgs e)
        {
            if (txtEmergency.Tag.ToString().Equals("N"))
            {
                txtEmergency.Text = "긴급등록";
                txtEmergency.ForeColor = Color.Red;
                txtEmergency.Tag = "E"; // Emergency
            }
            else
            {
                txtEmergency.Text = "일반등록";
                txtEmergency.ForeColor = Color.Black;
                txtEmergency.Tag = "N"; // Normal
            }
        }

        private void txtCause_Click(object sender, EventArgs e)
        {
            if (txtCause.Tag.ToString().Equals("N"))
            {
                txtCause.Text = "금형고장";
                txtCause.ForeColor = Color.Red;
                txtCause.Tag = "C"; // Emergency
            }
            else
            {
                txtCause.Text = "생산변경";
                txtCause.ForeColor = Color.Black;
                txtCause.Tag = "N"; // Normal
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //if (mesGrid2.DataSourceDS.Tables[1].Rows[0][0].ToString() == "")
            //{
            //    mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            //    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            //}

            //MessageBox.Show(mesGrid2.DataSourceDS.Tables[1].Rows[0][0].ToString());

            DataRow dr = mesGrid2.DataSourceDS.Tables[1].NewRow();

            dr.SetField(0, txtMoldErrCode.Text);
            dr.SetField(1, txtMoldErrName.Text);
            dr.SetField(2, txtMoldErrLocCode1.Text);
            dr.SetField(3, txtMoldErrLocName1.Text);
            dr.SetField(4, txtMoldErrLocCode2.Text);
            dr.SetField(5, txtMoldErrLocName2.Text);
            dr.SetField(6, txtMoldErrDivCode.Text);
            dr.SetField(7, txtMoldErrDivName.Text);
            dr.SetField(8, txtRemark.Text);
            //dr.SetField(8, "9");


            mesGrid2.DataSourceDS.Tables[1].Rows.Add(dr);

            mesGrid2.GetGrid();

            txtMoldErrCode.Text = string.Empty;
            txtMoldErrName.Text = string.Empty;
            txtMoldErrLocCode1.Text = string.Empty;
            txtMoldErrLocName1.Text = string.Empty;
            txtMoldErrLocCode2.Text = string.Empty;
            txtMoldErrLocName2.Text = string.Empty;
            txtMoldErrDivCode.Text = string.Empty;
            txtMoldErrDivName.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mesGrid2.Row != null && mesGrid2.Row.Index > -1)
            {
                mesGrid2.DataSourceDS.Tables[1].Rows[mesGrid2.Row.Index].Delete();
                mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            }
        }

        private void btnListBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sSearchflag)
            {
                case "1":

                    txtMoldErrCode.Text = sender.Tag.ToString();
                    txtMoldErrName.Text = sender.Text;
                    break;

                case "2":

                    txtMoldErrLocCode1.Text = sender.Tag.ToString();
                    txtMoldErrLocName1.Text = sender.Text;

                    break;
                case "3":

                    txtMoldErrLocCode2.Text = sender.Tag.ToString();
                    txtMoldErrLocName2.Text = sender.Text;
                    break;

                case "4":

                    txtMoldErrDivCode.Text = sender.Tag.ToString();
                    txtMoldErrDivName.Text = sender.Text;
                    break;

                case "5":

                    txtWorkerCode.Text = sender.Tag.ToString();
                    txtWorkerName.Text = sender.Text;
                    break;

            }
        }

        //private void txtMoldCode_Click(object sender, EventArgs e)
        //{
        //    string sOrderNo = string.Empty;

        //    DA9540 da9540 = new DA9540();

        //    if (DialogResult.OK == ShowDialogForm(da9540))
        //    {
        //        sOrderNo = da9540.sOrderNo;
        //    }
        //    else
        //        return;
        //}
    }
}
