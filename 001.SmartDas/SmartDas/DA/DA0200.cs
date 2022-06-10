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
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace SmartDas
{
    public partial class DA0200 : SmartDas.Components.BaseForm
    {
        public DA0200()
        {
            InitializeComponent();
        }

        private void DA0200_Load(object sender, EventArgs e)
        {
            SetButtons();  //확인/ 취소 버튼 초기화

            SetListBoxButtons();// 작업자 선택 List Box

            SetWorkerList();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtWorkerList.Text = Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName;
            txtWorkerCnt.Text = Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount.ToString();
        }

        /// <summary>
        /// 버튼 생성(확인/취소)
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "초기화";
            btnConfBox[0, 1].Text = "확인";
            btnConfBox[0, 2].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetListBoxButtons()
        {
            btnDeptCode.CountX = 5;
            btnDeptCode.CountY = 1;

            btnDeptCode.SelectionMode = ButtonBox.SelectionModeEnum.Single;

            btnDeptCode.SelectProcedureName = "USP_DA0200_S2";
            btnDeptCode.SetStoreProc();

            btnDeptCode.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            btnDeptCode.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnDeptCode.DoFind();

            btnListBox.CountX = 6;
            btnListBox.CountY = 5;

            btnListBox.SelectProcedureName = "USP_DA0200_S1";
            btnListBox.SetStoreProc();

            btnListBox.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            btnListBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            //ProcGListWorker();

            btnDeptCode[0, 0].ButtonPressed = true;
            btnDeptCode.RedrawButtons();

            btnListBox.ExTag = btnDeptCode.GetSelectedButtons()[0].Tag.ToString();

            btnListBox.DoFind();
        }

        //private void ProcGListWorker()
        //{
        //    try
        //    {
        //        Database db = DatabaseFactory.CreateDatabase();
        //        SqlConnection conn = (SqlConnection)db.CreateConnection();
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.CommandText = "USP_DA0200_S3";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
        //        cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));

        //        cmd.Parameters["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
        //        cmd.Parameters["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;

        //        DataTable dt = new DataTable();

        //        clsDB.gCreateRSet(conn, cmd, dt);

        //        // 선택된 작업자 리스트 조회
        //        Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).Clear();

        //        foreach (DataRow dr in dt.Rows)
        //            Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).AddWorker(dr["WORKERID"].ToString(), dr["WORKERNAME"].ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        SetMessage(ex.Message);
        //    }
        //}

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
 
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "초기화":
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).Clear();

                        foreach (ButtonData b in btnListBox.GetSelectedButtons())
                        {
                            b.ButtonPressed = false;
                        }

                        btnConfBox.RedrawButtons();
                        txtWorkerCnt.Text = "0";
                        txtWorkerList.Text = "";
                        break;
                    case "확인":
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        //if (Common.SelectedWorkCenter.LineStatus == "S")
                        //{
                        //    SetMessage("가동 상태일 때 작업자를 변경할 수 없습니다.");
                        //    return; 
                        //}

                        DoSave();

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (Exception e1)
            {
                SetMessage(e1.Message);
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        private void DoSave()
        {
            try
            {
                DoProgress();

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0200_D1");

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));

                cmd.Parameters["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
                cmd.Parameters["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;

                clsDB.gExecute(conn, cmd);

                foreach (Worker w in Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).List)
                {
                    cmd = ((SqlCommand)db.GetStoredProcCommand("USP_DA0200_I1"));

                    cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pWORKERID", SqlDbType.VarChar));

                    cmd.Parameters["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
                    cmd.Parameters["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;
                    cmd.Parameters["@pWORKERID"].Value = w.ID;

                    cmd.CommandType = CommandType.StoredProcedure;
                    clsDB.gExecute(conn, cmd);
                }

                clsDB.Commit();
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private void bntListBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            MESButton b = sender;

            if (b.ButtonPressed == true)    // 추가
                
                Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).AddWorker(b.Tag.ToString(), b.Text);
            else // 제거
                Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).RemoveWorker(b.Tag.ToString());

            SetWorkerList(); 
        }

        private void SetWorkerList()
        {
            txtWorkerList.Text = Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName;

            txtWorkerCnt.Text = Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount.ToString();
        }

        private void btnDeptCode_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();
            SetPressedBtnBox();
            CloseProgressForm();
        }

        private void SetPressedBtnBox()
        {
            btnListBox.ExTag = btnDeptCode.GetSelectedButtons()[0].Tag.ToString();
            btnListBox.CurrentPage = 0;

            btnListBox.RedrawButtons();
        }




    }
}
