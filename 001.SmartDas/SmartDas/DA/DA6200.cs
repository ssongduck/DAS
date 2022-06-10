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
using System.Data.SqlClient;

namespace SmartDas
{
    public partial class DA6200 : BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        string cur_lotno = "";

        public DA6200()
        {
            InitializeComponent();
        }

        private void DA6200_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();

            DoFind();
        }

        // 버튼 생성
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
        
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA6200_S1";
            mesGrid1.CountRows = 10;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
   
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            string sDate = string.Format("{0:yyyy-MM-dd}", dtpDate.Value);
            string sDateto = string.Format("{0:yyyy-MM-dd}", dtpDateTo.Value);

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDATE", sDate));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDATEto", sDateto));
          

            mesGrid1.DoFind();

           
        }
            
        // 버튼 컨트롤
        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Text)
            {
                case "조회":
                    // 조회시 처리 내역
                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }
                    DoFind();
                    break;

             

                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

      
  
    }
}
