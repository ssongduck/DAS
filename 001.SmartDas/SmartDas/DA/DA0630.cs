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
    /// <summary>
    /// DA0630 class
    /// </summary>
    public partial class DA0630 : SmartDas.Components.BaseForm
    {
        #region Variables

        /// <summary>
        /// Work center
        /// </summary>
        WorkCenter _WorkCenter = Common.SelectedWorkCenter;

        int _iSEQ = 0;
        string _sRecDate = string.Empty;

        #endregion

        #region Constructors

        /// <summary>
        /// DA0630 constructor
        /// </summary>
        public DA0630()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// DA0630 load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0630_Load(object sender, EventArgs e)
        {
            SetButtons();
            SetBtnBox();
            SetGrid();
            Initialize();
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);
            SetInfo();
        }

        /// <summary>
        /// Total qty click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Change button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            txtErrorCode.Text = sender.Tag.ToString();
            txtErrorName.Text = sender.Text;
        }

        /// <summary>
        /// Search button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }

        /// <summary>
        /// Confirm box button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if (_WorkCenter.GetOrderList(Common.ListOrderType.SELECT).OrderCount == 0)
                        {
                            SetMessage("작지가 선택되어야 불량을 등록할 수 있습니다.");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtErrorCode.Text))
                        {
                            SetMessage("불량 항목을 선택하세요.");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtTotalQty.Text) || txtTotalQty.Text == "0")
                        {
                            SetMessage("불량 수량을 입력하세요.");
                            return;
                        }

                        DoSave();
                        SetInfo();
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
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        /// <summary>
        /// Sub button change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox_Sub_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            btnBox.GetSelectedButtons().Clear();

            btnBox.ExTag = sender.Tag.ToString();
            btnBox.CurrentPage = 0;

            btnBox.RedrawButtons();

            txtErrorCode.Text = string.Empty;
            txtErrorName.Text = string.Empty;

            if (sender.Text == "공타")
            {
                txtErrorCode.Text = "0000";
                txtErrorName.Text = "공타";
            }
            else
            {
                txtErrorCode.Text = string.Empty;
                txtErrorName.Text = string.Empty;
            }
        }

        /// <summary>
        /// Select button change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "불량":
                    mesGrid1.Visible = false;
                    mesLabel6.Visible = true;

                    btnLeftPage.LinkGrid = null;
                    btnRightPage.LinkGrid = null;
                    btnLeftPage.LinkButtonBox = btnBox;
                    btnRightPage.LinkButtonBox = btnBox;

                    btnLeftPage.LinkMoveSize = btnBox.CountY;
                    btnRightPage.LinkMoveSize = btnBox.CountY;

                    SetInfo();

                    dtpDate.Enabled = false;
                    btnSearch.Enabled = false;
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

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;

                    mesGrid1.SelectProcedureName = "USP_DA0630_S3";
                    DoFind();
                    btnConfBox[0, 1].Enable = true;
                    break;

                case "집계":
                    mesGrid1.Visible = true;
                    mesLabel6.Visible = false;
                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;

                    mesGrid1.SelectProcedureName = "USP_DA0630_S7";
                    DoFind();
                    btnConfBox[0, 1].Enable = false;
                    break;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            txtWorkCenterCode.Text = _WorkCenter.Code;
            txtWorkCenterName.Text = _WorkCenter.Name;

            txtErrorCode.Text = "0000";
            txtErrorName.Text = "공타";
            txtTotalQty.Text = "0";

            txtOrderNo.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtErrorQty.Text = string.Empty;
            txtPLCErrorQty.Text = string.Empty;
            txtInvalidQty.Text = _WorkCenter.InvalidQty.ToString();
            txtPLCProdQty.Text = _WorkCenter.PLCProdQty.ToString();

            btnBox.RedrawButtons();
        }

        /// <summary>
        /// Set info
        /// </summary>
        private void SetInfo()
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "USP_DA0630_S4";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pPLANTCODE", _WorkCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", _WorkCenter.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                txtOrderNo.Text = dt.Rows[0]["OrderNo"].ToString();
                txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString();
                txtItemName.Text = "[" + dt.Rows[0]["cartype"].ToString() + "]" + dt.Rows[0]["ItemName"].ToString();
                txtErrorQty.Text = dt.Rows[0]["ErrorQty"].ToString();
                txtInvalidQty.Text = dt.Rows[0]["InvalidQty"].ToString();
                txtPLCProdQty.Text = dt.Rows[0]["PLCProdQty"].ToString();
                txtPLCErrorQty.Text = dt.Rows[0]["PLCErrorQty"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Set buttons
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "삭제";
            btnConfBox[0, 2].Text = "취소";

            btnConfBox.RedrawButtons();

            btnSelect.CountX = 3;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "불량";
            btnSelect[0, 1].Text = "실적";
            btnSelect[0, 2].Text = "집계";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        /// <summary>
        /// Set button box
        /// </summary>
        private void SetBtnBox()
        {
            btnBox.CountX = 6;
            btnBox.CountY = 4;
            btnBox.SelectProcedureName = "USP_DA0630_S6";
            btnBox.SetStoreProc();
            btnBox.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnBox.DoFind();
        }

        /// <summary>
        /// Set grid
        /// </summary>
        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 9;

            mesGrid1.SelectProcedureName = "USP_DA0630_S3";
        }

        /// <summary>
        /// Do find
        /// </summary>
        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", _WorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", _WorkCenter.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToShortDateString()));

            mesGrid1.DoFind();
        }

        /// <summary>
        /// Do save
        /// </summary>
        private void DoSave()
        {
            try
            {
                double dTotalQty = clsDB.nvlDouble(txtTotalQty.Text);

                txtTotalQty.Text = "0";

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                clsDB.BeginTran(sqlConnection);

                SqlCommand cmd = (SqlCommand)database.GetStoredProcCommand("USP_DA0630_I1");

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", _WorkCenter.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", _WorkCenter.Code));
                cmd.Parameters.Add(new SqlParameter("@pOrderNo", _WorkCenter.OrderNo));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", _WorkCenter.ItemCode));
                cmd.Parameters.Add(new SqlParameter("@pErrorCode", txtErrorCode.Text));
                cmd.Parameters.Add(new SqlParameter("@pQty", dTotalQty));
                cmd.Parameters.Add(new SqlParameter("@pNewOld", _WorkCenter.NewOld));

                clsDB.gExecute(sqlConnection, cmd);

                clsDB.Commit();

                SetMessage("정상적으로 등록되었습니다.");

                if (txtErrorCode.Text == "0000")
                {
                    _WorkCenter.InvalidQty += dTotalQty;

                    if (_WorkCenter.NewOld == "O")
                    {
                        _WorkCenter.PLCProdQty -= dTotalQty;
                    }
                    else
                    {
                        _WorkCenter.InvalidQty += dTotalQty;
                    }
                }
                else
                {
                    _WorkCenter.ErrorQty += dTotalQty;
                    _WorkCenter.PLCProdQty -= dTotalQty;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSEQ = e._UltraGridRow.Cells["ROWSEQ"].Value.ToString() == "" ? 0 : Convert.ToInt32(e._UltraGridRow.Cells["ROWSEQ"].Value);
            _sRecDate = e._UltraGridRow.Cells["RECDATE"].Value.ToString();
        }

        /// <summary>
        /// 불량실적 삭제 추가
        /// 수정자 : 정용석
        /// 수정일 : 2021-07-19
        /// </summary>
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
                sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE",      Common.SelectedWorkCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_ORDERNO",        Common.SelectedWorkCenter.OrderNo));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_RECDATE",        _sRecDate));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_SEQ",            _iSEQ));
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

        #endregion


    }
}
