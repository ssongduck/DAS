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
    public partial class DA8000 : SmartDas.Components.BaseForm
    {
        public bool btest = false;
        public bool bHam  = false;
        public DA8000()
        {
            InitializeComponent();
        }

        private void DA8000_Load(object sender, EventArgs e)
        {
            if (btest)
            {
                lblTitle.Text = "시가공작업지시생성";
                btnRework.Enabled = false;
            }
            if (bHam)
            {
                lblTitle.Text = "함침재가공지시생성";
                btnRework.ButtonPressed = true;
            }
            //else
            //    btnRework.ButtonPressed = true;

            SetButtons();

            SetGrid();

            DoFind();

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
            mesGrid1.SelectProcedureName = "USP_DA8000_S1";
            mesGrid1.CountRows = 6;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtPlanQty.Text = "0";
            //dtpStartDate.Value = Convert.ToDateTime(Common.gRecDate);
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@sdiv", ( btest?"Y":"N")));

            mesGrid1.DoFind();
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
                            return;
                        }
                        if (string.IsNullOrEmpty(txtPlanQty.Text) || (txtPlanQty.Text == "0"))
                        {
                            SetMessage("지시수량을 입력하세요.");
                            txtPlanQty_Click(null, null);
                            return;
                        }

                        if (Common.gsPlantCode == "SK2")
                        {
                            btnRework.ButtonPressed = false;
                        } 
                      
                        Database dbSave = DatabaseFactory.CreateDatabase();
                        SqlConnection conSave = (SqlConnection)dbSave.CreateConnection();

                        SqlCommand cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA8000_I1");
                        cmd.Parameters.Add(new SqlParameter("@PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", Common.SelectedWorkCenter.Code));
                        cmd.Parameters.Add(new SqlParameter("@ItemCode", txtItemCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@OrderQty", clsDB.nvlDouble(txtPlanQty.Text)));
                        cmd.Parameters.Add(new SqlParameter("@pReworkFlag", btest ? 'T' : (btnRework.ButtonPressed ? 'R' : 'N')));
                      //  cmd.Parameters.Add(new SqlParameter("@pReworkFlag", btest ? 'T' : 'R' ));

                        if (!clsDB.gExecuteProcedure(conSave, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        
                        //DoFind();

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



        private void txtPlanQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "지시수량 입력";
            d.LabelHeader = "지시수량";

            if (DialogResult.OK == ShowDialogForm(d))
                txtPlanQty.Text = d.ResultString;
        }

        private void btnRework_Click(object sender, EventArgs e)
        {
            if (bHam)
            {
                btnRework.ButtonPressed = true;
            }
            if (Common.gsPlantCode == "SK2")
            {
                btnRework.Enabled = false;
                btnRework.ButtonPressed = false;
            }

        }







    }
}
