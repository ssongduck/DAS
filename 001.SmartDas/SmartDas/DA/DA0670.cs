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
    public partial class DA0670 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;

        int _iSEQ = 0;
        string _LotNo = string.Empty;
        string _sRecDate = string.Empty;

        public string sLotNo;

        public bool bisSasang = false;

        public string SelectedItem;

        public bool bIsOKBarcode;

        public DA0670()
        {
            InitializeComponent();
        }

        private void DA0670_Load(object sender, EventArgs e)
        {

            txtLotNo.Text = sLotNo;

            SetButtons();

            SetBtnBox();

            SetGrid();

            Init();

            SetInfo();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            txtTotalQty.Text = "0";
                
            txtItemCode.Text = "";
            txtItemName.Text = "";

            txtErrorCode.Text = "";
            txtErrorName.Text = "";

            txtGoodQty.Text = wc.InvalidQty.ToString();

            btnBox.RedrawButtons();
            //btnBox_Sub.RedrawButtons();
        }

        private void SetInfo()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA0670_S4";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
                if (SelectedItem == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@pItemCode", 'X'));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@pItemCode", SelectedItem));
                }

                if ( txtLotNo.Text.Trim() == "")
                {
                    cmd.Parameters.Add(new SqlParameter("@pLOTNO", "X"));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@pLOTNO", txtLotNo.Text));
                }

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);

                txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString();
                txtItemName.Text = dt.Rows[0]["ItemName"].ToString();

                txtLotQty.Text = dt.Rows[0]["ProdQty"].ToString();
                txtBadQty.Text = dt.Rows[0]["BadQty"].ToString();
                txtGoodQty.Text = Convert.ToString(Convert.ToInt16(txtLotQty.Text) - Convert.ToInt16(txtBadQty.Text));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "삭제";
            btnConfBox[0, 2].Text = "취소";

            btnConfBox.RedrawButtons();

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "불량";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        private void SetBtnBox()
        {
            //btnBox_Sub.CountX = 5;
            //btnBox_Sub.CountY = 1;
            //btnBox_Sub.SelectProcedureName = "USP_DA0670_S1";
            //btnBox_Sub.SetStoreProc();
            //btnBox_Sub.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.gsPlantCode));
            //btnBox_Sub.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            //btnBox_Sub.DoFind();

            //btnBox_Sub[0, 0].ButtonPressed = true;

            btnBox.CountX = 6;
            btnBox.CountY = 4;
           // btnBox.SelectProcedureName = "USP_DA0670_S2";
            btnBox.SelectProcedureName = "USP_DA0630_S6";
            btnBox.SetStoreProc();
            btnBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnBox.DoFind();

            try
            {
                btnBox.ExTag = btnBox_Sub.GetSelectedButtons()[0].Tag.ToString();
            }
            catch (Exception E)
            {
                E.ToString();
            }
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 9;

            mesGrid1.SelectProcedureName = "USP_DA0670_S3";
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            //PARAM으로 NULL이 들어가면 안들어온걸로 인식한다.
            mesGrid1.ParameterList.Add(new SqlParameter("@pItemCode", SelectedItem.Trim())); //wc.OrderNo));
            try
            {

                mesGrid1.DoFind();
            }
            catch (Exception E)
            {
                E.ToString();
            }
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            DoProgress();

            try
            {
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
                        DoSave();
                        SetInfo();
                        //RefreshText();
                        break;

                    case "삭제":
                        DoDelete();
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
            if (sLotNo == "")
            {
                SetMessage("LOT번호를 입력하세요.");
                return;
            }

            if (!bIsOKBarcode)
            {
                SetMessage("작업할수 없는 LOT입니다.");
                return;
            }


            //이미 lot작업완료가 된것인지 체크
            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            if (txtLotNo.Text.Length == 17)
            {
                //이미 작업이 완료된 건인지 - 사상(완료공정기준)
                DataTable tbDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 where PrevLOTNO = '" + txtLotNo.Text + "'").Tables[0];
                int DoneQty = Convert.ToInt16(tbDone.Rows[0]["QTY"].ToString());
                if (DoneQty != 0)
                {
                    SetMessage("이미 사상 작업완료가 수행된 LOT번호입니다.");
                    return;
                }
            }

            //불량항목이 선택됬는지 체크
            if (txtErrorCode.Text.Length == 0)
            {
                SetMessage("불량항목을 선택하세요.");
                return;
            }

            try
            {
                double dTotalQty = clsDB.nvlDouble(txtTotalQty.Text);

                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0670_I1");

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pLOTNO", sLotNo));
                cmd.Parameters.Add(new SqlParameter("@pErrorCode", txtErrorCode.Text));

                if (bisSasang == true)
                {
                    cmd.Parameters.Add(new SqlParameter("@pSasangError", "Y"));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@pSasangError", "N"));
                }

                cmd.Parameters.Add(new SqlParameter("@pQty", dTotalQty));
                cmd.Parameters.Add(new SqlParameter("@pMAKER", "MES_TM"));

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
            btnBox.GetSelectedButtons().Clear();

            btnBox.ExTag = sender.Tag.ToString();
            btnBox.CurrentPage = 0;

            btnBox.RedrawButtons();

            txtErrorCode.Text = "";
            txtErrorName.Text = "";
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "불량":
                    mesGrid1.Visible = false;

                    btnLeftPage.LinkGrid = null;
                    btnRightPage.LinkGrid = null;
                    mesLabel6.Visible = true;
                    btnLeftPage.LinkButtonBox = btnBox;
                    btnRightPage.LinkButtonBox = btnBox;
                    
                    btnLeftPage.LinkMoveSize = btnBox.CountY;
                    btnRightPage.LinkMoveSize = btnBox.CountY;

                    SetInfo();
                    btnConfBox[0, 1].Enable = false;

                    break;
                case "실적":
                    mesGrid1.Visible = true;
                    mesLabel6.Visible = false;

                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    DoFind();

                    btnConfBox[0, 1].Enable = true;
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

        private void btnSelect_Load(object sender, EventArgs e)
        {

        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSEQ = e._UltraGridRow.Cells["ROWSEQ"].Value.ToString() == "" ? 0 : Convert.ToInt32(e._UltraGridRow.Cells["ROWSEQ"].Value);
            _LotNo = e._UltraGridRow.Cells["LOTNO"].Value.ToString();
            _sRecDate = Convert.ToDateTime(e._UltraGridRow.Cells["INDATE"].Value).ToString("yyyy-MM-dd");
        }

        private void DoDelete()
        {
            if (_iSEQ.Equals(0)) { SetMessage("선택된 행이 없습니다."); return; }

            if (ShowDialogForm(new MessageForm("불량 등록한 내용을 취소하시겠습니까?", MessageBoxButtons.YesNo, "불량등록취소")) == System.Windows.Forms.DialogResult.No) { return; }

            try
            { 
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "USP_DA0630_D1";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@AS_SYSTEMID", "MES"));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_ORDERNO", _LotNo));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_RECDATE", _sRecDate));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_SEQ",     _iSEQ));
                sqlCommand.Parameters.Add("@AS_RETURN", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue;

                clsDB.gExecute(sqlConnection, sqlCommand);

                int ires = (int)sqlCommand.Parameters["@AS_RETURN"].Value;

                if (ires >= 1)
                {
                    SetMessage("선택한 불량 실적이 정상적으로 삭제되었습니다.");
                    clsDB.Commit();
                }
                else if (ires == 0)
                {
                    SetMessage("1시간이 경과된 불량실적은 삭제할 수 없습니다. 담당자에 문의하여 ERP에서 삭제바랍니다.");
                }
                else
                {
                    clsDB.Rollback();
                    SetMessage("오류가 발생하여 작업이 취소되었습니다.");
                }
            }
            catch (Exception ex)
            {
                clsDB.Rollback();
                SetMessage(ex.Message);
            }
            finally
            {
                _iSEQ = 0;
                DoFind();
            }
        }
    }
}
