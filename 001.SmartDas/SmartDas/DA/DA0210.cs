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
    public partial class DA0210 : SmartDas.Components.BaseForm
    {
        private bool bIs = false;
        public string WorkerID;
        public string WorkerName;

        public DA0210()
        {
            InitializeComponent();
        }

        public DA0210(string WorkerID, string WorkerName)
        {
            InitializeComponent();

            this.WorkerID = WorkerID;
            this.WorkerName = WorkerName;

            if (!bIs)
            {
                bIs = true;
                SetButtons();  //확인/ 취소 버튼 초기화
                SetListBoxButtons();// 작업자 선택 List Box

                txtWorkerID.Text = this.WorkerID;
                txtWorkerName.Text = this.WorkerName;
            }
        }

        /// <summary>
        /// 버튼 생성(확인/취소)
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

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

            btnDeptCode.DoFind();

            btnListBox.CountX = 4;
            btnListBox.CountY = 5;

            btnListBox.SelectProcedureName = "USP_DA0210_S1";
            btnListBox.SetStoreProc();

            btnListBox.ParameterList.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));

            //ProcGListWorker();

            //btnDeptCode[0, 0].ButtonPressed = true;

            btnListBox.ParameterList["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;

            btnListBox.ExTag = btnDeptCode.GetSelectedButtons()[0].Tag.ToString();

            btnListBox.DoFind();

            if (WorkerID != "")
            {
                btnListBox.GetButtonByTag(WorkerID).ButtonPressed = true;
            }

            btnListBox.RedrawButtons();
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();
            switch (sender.Text)
            {
                case "확인":
                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }

                    if (btnListBox.GetSelectedButtons().Count == 1)
                    {
                        WorkerID = btnListBox.GetSelectedButtons()[0].Tag.ToString();
                        WorkerName = btnListBox.GetSelectedButtons()[0].Text.ToString();
                    }
                    
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
            
            CloseProgressForm();
        }

        private void bntListBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();
            MESButton b = sender;

            txtWorkerID.Text = b.Tag.ToString();
            txtWorkerName.Text = b.Text.ToString();
            CloseProgressForm();
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
