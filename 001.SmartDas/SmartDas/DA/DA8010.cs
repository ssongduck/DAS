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
    public partial class DA8010 : SmartDas.Components.BaseForm
    {
        private char cStatus;     // I : 품목선택, M : 금형선택
        public bool btest = false;

        public DA8010()
        {
            InitializeComponent();
        }

        private void DA8010_Load(object sender, EventArgs e)
        {
            if (btest)
            {
                lblTitle.Text = "시사출작업지시생성";
            }
            SetButtons();

            SetGrid();

            SetStatus('I');

            //DoFind();

            Init();

            SetMessage("품목을 선택하세요.");
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

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;
            mesGrid1.SelectProcedureName = "USP_DA8010_S1";
            mesGrid1.CountRows = 6;

            mesGrid2.FontSize = 15;
            mesGrid2.SelectProcedureName = "USP_DA8010_S2";
            mesGrid2.CountRows = 6;
        }

        private void SetStatus(char chr)
        {
            cStatus = chr;
            if (chr == 'I')
            {
                //txtItemCode.Text = "";
                //txtItemName.Text = "";
                txtMoldCode.Text = "";
                txtMoldName.Text = "";

                mesGrid1.Visible = true;
                mesGrid2.Visible = false;

                btnLeftPage.LinkGrid = mesGrid1;
                btnRightPage.LinkGrid = mesGrid1;
            }
            else //if(chr == 'M')
            {
                //txtMoldCode.Text = "";
                //txtMoldName.Text = "";

                mesGrid1.Visible = false;
                mesGrid2.Visible = true;

                btnLeftPage.LinkGrid = mesGrid2;
                btnRightPage.LinkGrid = mesGrid2;
            }

            DoFind();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtPlanQty.Text = "";
            txtMoldCode.Text = "";
            txtMoldName.Text = "";
        }

        private void DoFind()
        {
            if (cStatus == 'I')
            {
                mesGrid1.GetStoreProcedure();

                // 조회
                mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                mesGrid1.ParameterList.Add(new SqlParameter("@sdiv", (btest ? "Y" : "N")));

                mesGrid1.DoFind();
            }
            else
            {
                mesGrid2.GetStoreProcedure();

                // 조회
                mesGrid2.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                //mesGrid2.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                mesGrid2.ParameterList.Add(new SqlParameter("@pITEMCODE", txtItemCode.Text));
                mesGrid1.ParameterList.Add(new SqlParameter("@sdiv", (btest ? "Y" : "N")));

                mesGrid2.DoFind();
            }
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();

            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            try
            {
                switch (sender.Text)
                {
                    case "등록":
                        if ( string.IsNullOrEmpty(txtItemCode.Text))
                        {
                            SetMessage("품목을 선택하세요.");
                            SetStatus('I');
                            return;
                        }
                        if (string.IsNullOrEmpty(txtMoldCode.Text))
                        {
                            SetMessage("금형을 선택하세요.");
                            SetStatus('M');
                            return;
                        }
                        if (string.IsNullOrEmpty(txtPlanQty.Text) || (txtPlanQty.Text == "0"))
                        {
                            SetMessage("지시수량을 입력하세요.");
                            //txtPlanQty_Click(null, null);
                            return;
                        }

                        Database dbSave = DatabaseFactory.CreateDatabase();
                        SqlConnection conSave = (SqlConnection)dbSave.CreateConnection();

                        SqlCommand cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA8000_I1");
                        cmd.Parameters.Add(new SqlParameter("@PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", Common.SelectedWorkCenter.Code));
                        cmd.Parameters.Add(new SqlParameter("@ItemCode", txtItemCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@MoldCode", txtMoldCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@OrderQty", clsDB.nvlDouble(txtPlanQty.Text)));
                        cmd.Parameters.Add(new SqlParameter("@pReworkFlag", btest ? 'T' : 'N'));
                    

                        if (!clsDB.gExecuteProcedure(conSave, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }

                        DoFind();

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

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if ((e._UltraGridColumn == null) || (e._UltraGridRow == null))
                return;

            DoProgress();

            txtItemCode.Text = e._UltraGridRow.Cells["ItemCode"].Value.ToString();
            txtItemName.Text = e._UltraGridRow.Cells["ItemName"].Value.ToString();

            string sValue = mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value.ToString();

            for (int i = 0; i < mesGrid1.Rows.Count; i++)
                mesGrid1.Rows[i].Cells["Sel"].Value = " ";


            mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value = sValue == " " ? "√" : " ";

            CloseProgressForm();
        }

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if ((e._UltraGridColumn == null) || (e._UltraGridRow == null))
                return;

            DoProgress();

            txtMoldCode.Text = e._UltraGridRow.Cells["MoldCode"].Value.ToString();
            txtMoldName.Text = e._UltraGridRow.Cells["MoldName"].Value.ToString();

            string sValue = mesGrid2.Rows[e._UltraGridRow.Index].Cells["Sel"].Value.ToString();

            for (int i = 0; i < mesGrid2.Rows.Count; i++)
                mesGrid2.Rows[i].Cells["Sel"].Value = " ";

            mesGrid2.Rows[e._UltraGridRow.Index].Cells["Sel"].Value = sValue == " " ? "√" : " ";

            CloseProgressForm();
        }

        private void txtPlanQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "지시수량 입력";
            d.LabelHeader = "지시수량";

            if (DialogResult.OK == ShowDialogForm(d))
                txtPlanQty.Text = d.ResultString;
        }

        private void txtItemCode_Click(object sender, EventArgs e)
        {
            SetStatus('I');
        }

        private void txtMoldCode_Click(object sender, EventArgs e)
        {
            SetStatus('M');
        }

    }
}
