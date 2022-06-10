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
    public partial class DA0520 : SmartDas.Components.BaseForm
    {
        public DA0520()
        {
            InitializeComponent();

            SetButtons();
            SetGrid();

            Init();
        }

        private void DA0520_Load(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;

            DoFind();
        }

        /// <summary>
        /// 버튼 생성
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "초기화";
            btnConfBox[0, 1].Text = "출력";
            btnConfBox[0, 2].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 6;

            // Grid - width = 1000, 헤더 Width 총합 997
             mesGrid1.SelectProcedureName = "USP_DA0520_S1";
        }
        
        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("IN_PLANTCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("IN_WORKCENTERCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("IN_RECDATE", SqlDbType.VarChar));

            mesGrid1.ParameterList["IN_PLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
            mesGrid1.ParameterList["IN_WORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;
            mesGrid1.ParameterList["IN_RECDATE"].Value = Common.gRecDate;

            mesGrid1.DoFind();
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Text)
            {
                case "초기화":
                    Init();

                    break;
                case "등록":
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }
    }
}
