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
    public partial class DA0130 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;

        public DA0130()
        {
            InitializeComponent();
        }

        private void DA0130_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetBtnBox();

            SetGrid();

            Init();
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);
            SetInfo();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            txt4MChangeCode.Text = "";
            txt4MChangeName.Text = "";
            txt4MMessage.Text = "";

            btnBox.RedrawButtons();

            btnSelect2.Enabled = false;
            txtQCConfirm.Enabled = false;
            btnConfirm.Enabled = false;
            txtQCConfirm.Text = "";

            btnSelect2[0, 0].ButtonPressed = false;
            btnSelect2[0, 1].ButtonPressed = false;
        }

        private void SetInfo()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA0130_S3";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);

                txtCarType.Text = dt.Rows[0]["CarType"].ToString();
                txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString();
                txtItemName.Text = dt.Rows[0]["ItemName"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "유형";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));


            btnSelect2.CountX = 2;
            btnSelect2.CountY = 1;

            btnSelect2.SetButtons();

            btnSelect2[0, 0].Text = "이상";
            btnSelect2[0, 1].Text = "정상";

            btnSelect2.RedrawButtons();

            btnSelect2_buttonChangeEvent(btnSelect2[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));

        }

        private void SetBtnBox()
        {
            btnBox.CountX = 4;
            btnBox.CountY = 4;
            btnBox.SelectProcedureName = "USP_DA0130_S1";
            btnBox.SetStoreProc();
            btnBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnBox.DoFind();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 12;
            mesGrid1.CountRows = 9;
            mesGrid1.SelectProcedureName = "USP_DA0130_S2";

            mesGrid2.FontSize = 12;
            mesGrid2.CountRows = 3;
            mesGrid2.SelectProcedureName = "USP_DA0130_S4";
        }

        // sms전송 유형
        private void txtSMSSendType_Click_1(object sender, EventArgs e)
        {
            // SMS전체전송(A) -> SMS해당공정전송(D)
            switch (txtSMSSendType.Tag.ToString())
            {
                case "A":
                    txtSMSSendType.Text = "SMS해당공정전송";
                    txtSMSSendType.Tag = "D";
                    break;
                case "D":
                    txtSMSSendType.Text = "SMS QC전송";
                    txtSMSSendType.Tag = "Q";
                    break;
                case "Q":
                    txtSMSSendType.Text = "SMS전체전송";
                    txtSMSSendType.Tag = "A";
                    break;
            }
        }

        //윗 그리드 선택시 확인내역 조회
        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            mesGrid2.GetStoreProcedure();

            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@pItemCode", e._UltraGridRow.Cells[2].Value.ToString()));
            mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", e._UltraGridRow.Cells[3].Value.ToString()));
            mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", e._UltraGridRow.Cells[4].Value.ToString()));
            mesGrid2.ParameterList.Add(new SqlParameter("@pSEQ", e._UltraGridRow.Cells[5].Value.ToString()));

            mesGrid2.DoFind();
            if (Common.gsPlantCode == "SK1")
            {
                btnSelect2.Enabled = true;
                txtQCConfirm.Enabled = true;
                btnConfirm.Enabled = true;
            }
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToShortDateString()));

            mesGrid1.DoFind();
        }

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
                    case "등록":

                        if (string.IsNullOrEmpty(txt4MChangeCode.Text))
                        {
                            SetMessage("변경유형을 선택하세요.");
                            //btnSelect_buttonChangeEvent(btnSelect.GetButtonList()[0].MappingButton, null);
                            return;
                        }

                        DoSave();
                        SetInfo();

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

        private void DoSave()
        {
            if (txt4MChangeCode.Text.Length == 0)
            {
                SetMessage("변경유형을 선택하세요.");
            }

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0130_I1");

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text));
                cmd.Parameters.Add(new SqlParameter("@pCarType", txtCarType.Text));
                cmd.Parameters.Add(new SqlParameter("@pItemName", txtItemName.Text));
                cmd.Parameters.Add(new SqlParameter("@pChangeType", txt4MChangeCode.Text));
                cmd.Parameters.Add(new SqlParameter("@pMessage", txt4MMessage.Text));
                cmd.Parameters.Add(new SqlParameter("@pMessageSendType", txtSMSSendType.Tag));
                cmd.Parameters.Add(new SqlParameter("@pMaker", "SYSTEM"));
                cmd.Parameters.Add(new SqlParameter("@pSMS", "Y"));

                clsDB.gExecute(conn, cmd);

                //clsDB.Commit();

                SetMessage("정상적으로 등록되었습니다.");

                Init();
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

        private void btnBox_Sub_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            btnBox.GetSelectedButtons().Clear();

            btnBox.ExTag = sender.Tag.ToString();
            btnBox.CurrentPage = 0;

            btnBox.RedrawButtons();

            txt4MChangeCode.Text = "";
            txt4MChangeName.Text = "";
        }

        private void btnSelect2_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            //별거없음
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "유형":
                    panel1.Visible = false;
                    mesGrid1.Visible = false;

                    btnLeftPage.LinkGrid = null;
                    btnRightPage.LinkGrid = null;
                    btnLeftPage.LinkButtonBox = btnBox;
                    btnRightPage.LinkButtonBox = btnBox;
                    
                    btnLeftPage.LinkMoveSize = btnBox.CountY;
                    btnRightPage.LinkMoveSize = btnBox.CountY;

                    SetInfo();

                    dtpDate.Enabled = false;
                    btnSearch.Enabled = false;

                    break;
                case "실적":
                    panel1.Visible = true;

                    mesGrid1.Visible = true;

                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;

                    DoFind();

                    mesGrid2.Visible = true;

                    if (mesGrid1.Rows.Count > 0)
                    {
                        mesGrid2.GetStoreProcedure();
                        mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pItemCode", mesGrid1.Rows[0].Cells[2].Value.ToString()));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", mesGrid1.Rows[0].Cells[3].Value.ToString()));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", mesGrid1.Rows[0].Cells[4].Value.ToString()));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pSEQ", mesGrid1.Rows[0].Cells[5].Value.ToString()));

                        mesGrid2.DoFind();
                    }
                    else
                    {
                        mesGrid2.GetStoreProcedure();
                        mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pItemCode", "X"));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", "X"));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", "X"));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pSEQ", "1"));

                        mesGrid2.DoFind();
                    }

                    break;
            }
        }

        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            txt4MChangeCode.Text = sender.Tag.ToString();
            txt4MChangeName.Text = sender.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();

            btnSelect2.Enabled = false;
            txtQCConfirm.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DoSave2();

            if (mesGrid1.Rows.Count > 0)
            {
                mesGrid2.GetStoreProcedure();
                mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid2.ParameterList.Add(new SqlParameter("@pItemCode", mesGrid1.Rows[0].Cells[2].Value.ToString()));
                mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", mesGrid1.Rows[0].Cells[3].Value.ToString()));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", mesGrid1.Rows[0].Cells[4].Value.ToString()));
                mesGrid2.ParameterList.Add(new SqlParameter("@pSEQ", mesGrid1.Rows[0].Cells[5].Value.ToString()));

                mesGrid2.DoFind();
            }
        }

        private void DoSave2()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0130_I2");

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", mesGrid1.Row.Cells[2].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pRecDate", mesGrid1.Row.Cells[3].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pDayNight", mesGrid1.Row.Cells[4].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pSEQ", mesGrid1.Row.Cells[5].Value.ToString()));
                
                if (btnSelect2[0, 0].ButtonPressed == true)
                {
                    cmd.Parameters.Add(new SqlParameter("@pCheckType", "이상"));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@pCheckType", "정상"));
                }

                cmd.Parameters.Add(new SqlParameter("@pMessage", txtQCConfirm.Text));
                cmd.Parameters.Add(new SqlParameter("@pMaker", "SYSTEM"));

                clsDB.gExecute(conn, cmd);

                //clsDB.Commit();

                SetMessage("정상적으로 등록되었습니다.");

                Init();

                DoFind();
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

    }
}
