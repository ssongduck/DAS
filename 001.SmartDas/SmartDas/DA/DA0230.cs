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
    public partial class DA0230 : SmartDas.Components.BaseForm
    {
        public string strWorkerCode = "";
        public string strWorkerName = "";

        public DA0230()
        {
            InitializeComponent();
        }

        private void DA0230_Load(object sender, EventArgs e)
        {
            SetButtons();  //확인/ 취소 버튼 초기화
            SetListBoxButtons();// 작업자 선택 List Box

            //SetWorkerList();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtWorkerName.Text = "";// Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).AllWorkerName;
            txtWorkerCode.Text = "";//Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).WorkerCount.ToString();
        }

        /// <summary>
        /// 버튼 생성(확인/취소)
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            //btnConfBox[0, 0].Text = "초기화";
            btnConfBox[0, 0].Text = "확인";
            btnConfBox[0, 1].Text = "취소";

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

            foreach (ButtonData b in btnListBox.GetSelectedButtons())
                b.ButtonPressed = false;
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();

            try
            {
                switch (sender.Text)
                {
                    //case "초기화":
                    //    if (!bUseNetwork)
                    //    {
                    //        SetMessage("C:S00018");
                    //        return;
                    //    }

                    //    Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).Clear();

                    //    foreach (ButtonData b in btnListBox.GetSelectedButtons())
                    //    {
                    //        b.ButtonPressed = false;
                    //    }

                    //    btnConfBox.RedrawButtons();
                    //    txtWorkerCode.Text = "0";
                    //    txtWorkerName.Text = "";
                    //    break;

                    case "확인":
                        //if (!bUseNetwork)
                        //{
                        //    SetMessage("C:S00018");
                        //    return;
                        //}

                        //if (Common.SelectedWorkCenter.LineStatus == "S")
                        //{
                        //    SetMessage("가동 상태일 때 작업자를 변경할 수 없습니다.");
                        //    return; 
                        //}

                        //DoSave();

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
                CloseProgressForm();
            }
        }
        
        //private void bntListBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        //{
        //    MESButton b = sender;

        //    if (b.ButtonPressed == true)    // 추가
                
        //        Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).AddWorker(b.Tag.ToString(), b.Text);
        //    else // 제거
        //        Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).RemoveWorker(b.Tag.ToString());

        //    SetWorkerList(); 
        //}

        //private void SetWorkerList()
        //{
        //    txtWorkerName.Text = Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).AllWorkerName;

        //    txtWorkerCode.Text = Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).WorkerCount.ToString();
        //}

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

        private void btnListBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            MESButton btn = sender;
            strWorkerCode = btn.Tag.ToString();
            strWorkerName = btn.Text;

            txtWorkerCode.Text = strWorkerCode;
            txtWorkerName.Text = strWorkerName;
        }
    }
}
