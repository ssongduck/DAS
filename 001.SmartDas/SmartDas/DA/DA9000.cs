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
using System.Configuration;

namespace SmartDas
{
    public partial class DA9000 : SmartDas.Components.BaseForm
    {
        List<PlantCodeNode> list;

        private Configuration appConfig;

        private struct PlantCodeNode
        {
            public string PlantCode;
            public string PlantName;
            public int INum;

            public PlantCodeNode(string plantcode, string plantName, int iNum)
            {
                PlantCode = plantcode;
                PlantName = plantName;
                INum = iNum;
            }
        }

        int listIndex;

        public DA9000()
        {
            InitializeComponent();

            appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            txtIP.Text = Common.gsIP;

            SetPlantCodeList();

            SetButtons();

            DoFind();
        }

        private void SetPlantCodeList()
        {
            list = new List<PlantCodeNode>();
            //string sSQL;

            //sSQL = "";
            //sSQL = "Select MinorCode, CodeName from TBM0000 "
            //    +"   where MajorCode = 'PLANTCODE' and MinorCode <> '$' ";

            string sQuery = @"select MinorCode, CodeName from tbm0000 where MajorCode = 'PLANTCODE' and MinorCode  <> '$'";

            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection dconn = (SqlConnection)db.CreateConnection();
            DataTable dt = new DataTable();

            //clsDB.gCreateRSet(dconn, sSQL, dt);
            clsDB.gCreateRSet(dconn, sQuery, dt);

            txtPlantCode.Tag = Common.gsPlantCode.ToString();

            for (int i = 0; i < dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                list.Add(new PlantCodeNode(dr["MinorCode"].ToString(), dr["CodeName"].ToString(), i));

                if (txtPlantCode.Tag == null)
                {
                    txtPlantCode.Tag = dr["MinorCode"].ToString();
                }

                if (dr["MinorCode"].ToString() == txtPlantCode.Tag.ToString())
                {
                    listIndex = i;
                    txtPlantCode.Text = dr["CodeName"].ToString();
                }
            }

        }
        string curwc = "";
        /// <summary>
        /// 버튼 생성
        /// </summary>
        /// 
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "확인";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "선택";
            btnSelect[0, 1].Text = "주조";
            btnSelect[0, 2].Text = "사상";
            btnSelect[0, 3].Text = "가공";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnBox.SelectProcedureName = "USP_DA9000_S1";

            btnBox.SetStoreProc();

            // 조회
            btnBox.ParameterList.Add(new SqlParameter("IN_IP", Common.gsIP));
            btnBox.ParameterList.Add(new SqlParameter("IN_PLANTCODE", txtPlantCode.Tag.ToString()));            

            btnBox.ExTag = btnSelect.GetSelectedButtons()[0].Text;
            btnBox.DoFind();

            txtCount.Text = btnBox.GetSelectedButtons().Count.ToString();

            if (txtCount.Text != "0")
                curwc=btnBox.GetSelectedButtons()[0].Tag.ToString();

            if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKE_MFG"))
            {
                btnPlantChg.Enabled = false;
            }
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();
            try
            {
                switch (sender.Text)
                {
                    case "확인":
                        // 확인시 처리 내역
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }
                        DoSave();

                        // 장비설정 변경 후 변경 사항 반영하기 위하여...
                        // 아래 플래그가 false면 타이머 작동시
                        // 설비 리스트를 다시 생성한다.
                        //((DA0000)(this.Owner)).bSetWorkCenter = false;
                        //if (this.Owner == null)
                        //{
                        //    DA0030 da0030 = new DA0030();
                        //    ShowDialogForm(da0030);
                        //}
                        //else if (this.Owner.Name == "DA0030") ((DA0030)(this.Owner)).bSetWorkCenter = false;

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
                CloseProgressForm();
            }
        }

        private void DoSave()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA9000_D1");

                cmd.Parameters.Add(new SqlParameter("@IN_IP", SqlDbType.VarChar));
                cmd.Parameters["@IN_IP"].Value = Common.gsIP;

                clsDB.gExecute(conn, cmd);
                
                foreach (ButtonData btn in btnBox.GetSelectedButtons())
                {
                    if (btn.ButtonPressed)
                    {
                        cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA9000_I1");

                        cmd.Parameters.Add(new SqlParameter("@IN_IP", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@IN_WORKCENTERCODE", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@IN_PLANTCODE", SqlDbType.VarChar));

                        cmd.Parameters["@IN_IP"].Value = Common.gsIP;
                        cmd.Parameters["@IN_WORKCENTERCODE"].Value = btn.Tag.ToString();
                        cmd.Parameters["@IN_PLANTCODE"].Value = txtPlantCode.Tag.ToString();

                        clsDB.gExecute(conn, cmd);
                    }
                    
                }

                clsDB.Commit();
                string div = Common.gsDASDivision;
                Common.GetDivision(Common.gsIP);

                if (div != Common.gsDASDivision) //curwc=="" || curwc.Substring(0, 1) != btnBox.GetSelectedButtons()[0].Tag.ToString().Substring(0, 1))
                {
                     System.Diagnostics.Process.Start("SmartDas.exe");
                     Application.Exit();
                }
              //  DoFind();
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        private void DoFind()
        {
            btnBox.SelectProcedureName = "USP_DA9000_S1";
            btnBox.ParameterList.Clear();

            if (btnSelect.GetSelectedButtons()[0].Text == "주조")
            {
                // 조회
                btnBox.ParameterList.Add(new SqlParameter("IN_IP", Common.gsIP));
                btnBox.ParameterList.Add(new SqlParameter("IN_PLANTCODE", txtPlantCode.Tag.ToString()));
                btnBox.ParameterList.Add(new SqlParameter("IN_FLAG", "1"));

                btnBox.ExTag = "";
                btnBox.DoFind();

                txtCount.Text = btnBox.GetSelectedButtons().Count.ToString();

                if (txtCount.Text != "0")
                    curwc = btnBox.GetSelectedButtons()[0].Tag.ToString();

            }
            else if (btnSelect.GetSelectedButtons()[0].Text == "사상")
            {
                // 조회
                btnBox.ParameterList.Add(new SqlParameter("IN_IP", Common.gsIP));
                btnBox.ParameterList.Add(new SqlParameter("IN_PLANTCODE", txtPlantCode.Tag.ToString()));
                btnBox.ParameterList.Add(new SqlParameter("IN_FLAG", "2"));

                btnBox.ExTag = "";
                btnBox.DoFind();

                txtCount.Text = btnBox.GetSelectedButtons().Count.ToString();

                if (txtCount.Text != "0")
                    curwc = btnBox.GetSelectedButtons()[0].Tag.ToString();
            }
            else if (btnSelect.GetSelectedButtons()[0].Text == "가공")
            {
                // 조회
                btnBox.ParameterList.Add(new SqlParameter("IN_IP", Common.gsIP));
                btnBox.ParameterList.Add(new SqlParameter("IN_PLANTCODE", txtPlantCode.Tag.ToString()));
                btnBox.ParameterList.Add(new SqlParameter("IN_FLAG", "3"));

                btnBox.ExTag = "";
                btnBox.DoFind();

                txtCount.Text = btnBox.GetSelectedButtons().Count.ToString();

                if (txtCount.Text != "0")
                    curwc = btnBox.GetSelectedButtons()[0].Tag.ToString();
            }
            else 
            {
                btnBox.ExTag = "선택";
            }
            
            btnBox.CurrentPage = 0;

            btnBox.RedrawButtons();
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }
            DoProgress();
            DoFind();
            CloseProgressForm();
        }

        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            foreach (ButtonData btn in btnBox.GetSelectedButtons())
            {
                if (sender.Name != btn.Name)
                {
                    btn.ButtonPressed = false;
                    btn.ExTag = "";
                }
            }

            btnBox[sender.Name].ExTag = sender.ButtonPressed ? "선택" : "";
            txtCount.Text = "1";
        }

        private void txtPlantCode_Click(object sender, EventArgs e)
        {
            return;
            DoProgress();   
            listIndex++;

            if (listIndex >= list.Count)
            {
                listIndex = 0;
            }

            foreach (PlantCodeNode p in list)
            {
                if (p.INum == listIndex)
                {
                    txtPlantCode.Text = p.PlantName;
                    txtPlantCode.Tag = p.PlantCode;
                    //listIndex = 0;

                    break;
                }
            }

            btnBox.ParameterList["IN_PLANTCODE"].Value = txtPlantCode.Tag.ToString();

            btnBox.ExTag = btnSelect.GetSelectedButtons()[0].Text;
            btnBox.DoFind();

            txtCount.Text = btnBox.GetSelectedButtons().Count.ToString();

            DoFind();
            CloseProgressForm();
        }

        private void btnBox_Load(object sender, EventArgs e)
        {

        }

        private void btnPlantChg_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Terminal management
            /// </summary>

            string sPassword = string.Empty;
            string sUserId   = string.Empty;
            string sUserName = string.Empty;

            DA9999 dA9999 = new DA9999();
            ShowDialogForm(dA9999);

            if (dA9999.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                sPassword = dA9999.Password;

                if (!string.IsNullOrEmpty(sPassword))
                {
                    Database database = DatabaseFactory.CreateDatabase();
                    SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                    SqlCommand sqlCommand = new SqlCommand();

                    //서버 Alias정보 변경 ERPSVR → ERPSMS                    
                    if (Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                    {
                        sqlCommand.CommandText = "ERPSVR.SKA_FIN.dbo.SP_GET_PASSWORD_LIST";
                    }
                    else if (Common.sERPDB.Equals("ERPSVR.SKE_SFG"))
                    {
                        sqlCommand.CommandText = "ERPSMS.SKA_FIN.dbo.SP_GET_PASSWORD_LIST";
                    }
                    else
                    {
                        SetMessage("사업장 변경 대상이 없습니다.");
                        return;
                    }
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@PASSWORD", sPassword));

                    DataTable dt = new DataTable();

                    clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (ShowDialogForm(new MessageForm("사업장을 변경하시겠습니까?" + "\r\n" + "※변경이 적용되면 프로그램이 종료됩니다. 프로그램을 재실행하세요!",
                            MessageBoxButtons.YesNo, "사업장 변경")) == System.Windows.Forms.DialogResult.Yes)
                        {

                            if (appConfig.AppSettings.Settings["ERP"].Value.Contains("SKA_SFG"))
                            {
                                appConfig.AppSettings.Settings["ERP"].Value = "ERPSVR.SKE_SFG"; // EV서산
                            }
                            else if (appConfig.AppSettings.Settings["ERP"].Value.Contains("SKE_SFG"))
                            {
                                appConfig.AppSettings.Settings["ERP"].Value = "ERPSVR.SKA_SFG"; //서산공장
                            }
                            if (appConfig.ConnectionStrings.ConnectionStrings[1].ConnectionString.Contains("10.165"))
                            {
                                appConfig.ConnectionStrings.ConnectionStrings[1].ConnectionString = "Data Source=192.168.10.166;Initial Catalog=SK_MESDB_V1;User ID=pcadmin;Password=didalscjf";
                            }
                            else if (appConfig.ConnectionStrings.ConnectionStrings[1].ConnectionString.Contains("10.166"))
                            {
                                appConfig.ConnectionStrings.ConnectionStrings[1].ConnectionString = "Data Source=192.168.10.165;Initial Catalog=SK_MESDB_V1;User ID=pcadmin;Password=didalscjf";
                            }

                            appConfig.Save(ConfigurationSaveMode.Modified);
                            ConfigurationManager.RefreshSection("configuration");
                            Application.Exit();
                        }
                        else
                        {
                            SetMessage("사업장 변경이 취소되었습니다.");
                        }
                    }
                    else
                    {
                        SetMessage("비밀번호를 다시 확인하세요.");
                    }
                }
                else
                {
                    SetMessage("비밀번호를 입력하세요.");
                }
            }        

        }
    }
}
