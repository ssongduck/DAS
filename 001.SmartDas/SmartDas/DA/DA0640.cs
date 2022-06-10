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
using Infragistics.Win.UltraWinGrid;

namespace SmartDas
{
    public partial class DA0640 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        public int badqty;
        public string badname;
        public string bWorkcentercode;
        public string bWorkcentername;
        public string bOrderNo;
        public string bItemCode;
        public string bItemName;
        public string bErrorCode;
        

        public DA0640()
        {
            InitializeComponent();
        }

        private void DA0640_Load(object sender, EventArgs e)
        {
            SetButtons();

            //SetBtnBox();

              SetGrid();

            Init();

            SetInfo();

            DoFind();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            //txtErrorCode.Text = "";     //
            txtErrorCode.Text = bErrorCode;
            txtErrorName.Text = "";       //
            txtTotalQty.Text = "0";
                
            txtOrderNo.Text = "";
            txtItemCode.Text = "";
            txtItemName.Text = "";

            txtErrorQty.Text = "";
            txtPLCErrorQty.Text = "";
            txtInvalidQty.Text = wc.InvalidQty.ToString();
            txtPLCProdQty.Text = wc.PLCProdQty.ToString();
            txtWorkCenterCode.Text = bWorkcentercode;
            txtWorkCenterName.Text = bWorkcentername;
            txtOrderNo.Text = bOrderNo;
            txtItemCode.Text = bItemCode;
            txtItemName.Text = bItemName;


        

            //btnBox_Sub_buttonChangeEvent(btnBox_Sub.GetButtonList()[0].MappingButton, null);
        }

        private void SetInfo()
        {
            //if (!bUseNetwork)
            //{
            //    SetMessage("C:S00018");
            //    return;
            //}

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA0630_S4";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);


                txtErrorQty.Text = dt.Rows[0]["ErrorQty"].ToString();
                txtInvalidQty.Text = dt.Rows[0]["InvalidQty"].ToString();

                txtPLCProdQty.Text = dt.Rows[0]["PLCProdQty"].ToString();
                txtPLCErrorQty.Text = dt.Rows[0]["PLCErrorQty"].ToString();
                txtTotalQty.Text = badqty.ToString();
                txtErrorName.Text = badname;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //private void RefreshText()
        //{
        //    //txtErrorCode.Text = "0000";     //
        //    //txtErrorName.Text = "공타";       //

        //    txtErrorQty.Text = wc.ErrorQty.ToString();
        //    txtPLCErrorQty.Text = wc.PLCErrorQty.ToString();
        //    txtInvalidQty.Text = wc.InvalidQty.ToString();
        //    txtPLCProdQty.Text = wc.PLCProdQty.ToString();
        //    txtTotalQty.Text = "0";

        //    //btnBox.RedrawButtons();
        //    //btnBox_Sub.RedrawButtons();
        //}
        
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();

        }

        private void SetBtnBox()
        {
            //btnBox_Sub.CountX = 5;
            //btnBox_Sub.CountY = 1;
            //btnBox_Sub.SelectProcedureName = "USP_DA0630_S1";
            //btnBox_Sub.SetStoreProc();
            //btnBox_Sub.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.gsPlantCode));
            //btnBox_Sub.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            //btnBox_Sub.DoFind();

            //btnBox.CountX = 6;
            //btnBox.CountY = 3;
            //btnBox.SelectProcedureName = "USP_DA0630_S2";
            //btnBox.SetStoreProc();
            //btnBox.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.gsPlantCode));

            //btnBox.DoFind();
            
            //btnBox.ExTag = btnBox_Sub.GetSelectedButtons()[0].Tag.ToString();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 10;

            mesGrid1.SelectProcedureName = "USP_DA0640_S1";
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text.Trim()));
            mesGrid1.ParameterList.Add(new SqlParameter("@pbadqty", txtTotalQty.Text.Trim()));

            mesGrid1.DoFind();

            mesGrid1.Columns["order_no"].MergedCellContentArea = MergedCellContentArea.VisibleRect;
            mesGrid1.Columns["order_no"].MergedCellEvaluationType = MergedCellEvaluationType.MergeSameValue;
            mesGrid1.Columns["order_no"].MergedCellStyle = MergedCellStyle.Always;
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
                        if (string.IsNullOrEmpty(txtErrorCode.Text))
                        {
                            SetMessage("불량 항목을 선택하세요.");
                            //btnSelect_buttonChangeEvent(btnSelect.GetButtonList()[0].MappingButton, null);
                            return;
                        }
                        if (string.IsNullOrEmpty(txtTotalQty.Text) || txtTotalQty.Text == "0")
                        {
                            SetMessage("불량 수량을 입력하세요.");
                            //txtTotalQty_Click(null, null);
                            return;
                        }

                        if (mesGrid1.Rows.Count == 0)
                        {
                            SetMessage("BOM정보를 확인하여 주십시오");
                            //txtTotalQty_Click(null, null);
                            return;
                        }


                    //    DoSave();
                    //    SetInfo();


                        int scount = mesGrid1.Rows.Count;

                        try
                        {
                            Database db = DatabaseFactory.CreateDatabase();
                            SqlConnection conn = (SqlConnection)db.CreateConnection();

                            clsDB.BeginTran(conn);
                            bool bsv = false;
                            for (int a = 0; scount > a; a++)
                            {
                                string qty= mesGrid1.Rows[a].Cells["qty_per"].Value.ToString().Trim();
                                if (qty == "0" || qty == "")
                                    continue;

                                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0640_I1");

                                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                                cmd.Parameters.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@pItemCode", mesGrid1.Rows[a].Cells["resource_used"].Value));
                                cmd.Parameters.Add(new SqlParameter("@pqty", qty));

                                clsDB.gExecute(conn, cmd);
                                bsv = true;
                            }
                            clsDB.Commit();
                            if (bsv)
                            {
                                DoSave();
                                SetInfo();
                                SetMessage("정상적으로 등록되었습니다.");
                            }
                            else
                            {
                                SetMessage("등록된 소모자재가 없습니다.\n 최소 하나 이상 등록하여 주시기 바랍니다.");
                                return;
                            }


                        }
                        catch (SqlException oe)
                        {
                            SetMessage(oe.Message);
                            clsDB.Rollback();
                        }



                        mesGrid1.DataSource.Clear();
                        mesGrid1.DataBindings.Clear();


                        //RefreshText();
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
            try
            {
                double dTotalQty = clsDB.nvlDouble(txtTotalQty.Text);

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0630_I1");

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pErrorCode", txtErrorCode.Text));
                cmd.Parameters.Add(new SqlParameter("@pQty", dTotalQty));
                cmd.Parameters.Add(new SqlParameter("@pNewOld",wc.NewOld));

                clsDB.gExecute(conn, cmd);

                clsDB.Commit();

                SetMessage("정상적으로 등록되었습니다.");

                // 작업장 정보 임시 변경
                if (txtErrorCode.Text == "0000")
                {
                    wc.InvalidQty += dTotalQty;

                    if (wc.NewOld == "O")
                        wc.PLCProdQty -= dTotalQty; // 수정 필요
                    else
                        wc.InvalidQty += dTotalQty;
                }
                else
                {
                    wc.ErrorQty += dTotalQty;
                    wc.PLCProdQty -= dTotalQty;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

        private void btnBox_Sub_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
           
            txtErrorCode.Text = "";
            txtErrorName.Text = "";

            if (sender.Text == "공타")
            {
                txtErrorCode.Text = "0000";
                txtErrorName.Text = "공타";
            }
            else
            {
                txtErrorCode.Text = "";
                txtErrorName.Text = "";
            }
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "불량":
                    btnLeftPage.LinkGrid = null;
                    btnRightPage.LinkGrid = null;
                 

                    break;
                case "실적":
                   

                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                   
                    DoFind();
                    break;
            }
        }

        private void txtTotalQty_Click(object sender, EventArgs e)
        {
            DA9100 da9100 = new DA9100();
            da9100.LabelTitle = "불량수량 입력";
            da9100.LabelHeader = "불량수량";

            if (DialogResult.OK == ShowDialogForm(da9100))
            {
                txtTotalQty.Text = da9100.ResultString;
            }
        }

        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            txtErrorCode.Text = sender.Tag.ToString();
            txtErrorName.Text = sender.Text;
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridColumn.ToString() == "qty_per")
            {
                DA9100 da9100 = new DA9100();
                da9100.LabelTitle = "불량수량 입력";
                da9100.LabelHeader = "불량수량";

                if (DialogResult.OK == ShowDialogForm(da9100) )
                {
                    try
                    {
                        if (Convert.ToInt32(mesGrid1.Row.Cells["maxqty_per"].Value) < Convert.ToInt32(da9100.ResultString))
                        {
                            SetMessage(mesGrid1.Row.Cells["maxqty_per"].Value+ "보다 큰수는 등록할수 없습니다.");
                            return;
                        }
                     }
                    catch { }

                    mesGrid1.Row.Cells["qty_per"].Value = da9100.ResultString;
                }
            }
        }

     
    }
}

