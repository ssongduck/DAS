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
    /// DA0610 calss
    /// </summary>
    public partial class DA0610 : SmartDas.Components.BaseForm
    {
        #region Variables

        /// <summary>
        /// Work center
        /// </summary>
        WorkCenter _WorkCenter = Common.SelectedWorkCenter;

        /// <summary>
        /// Error division
        /// </summary>
        string _ErrDiv = "[공정]";


        int _iSEQ = 0 ;
        string _sRecDate = string.Empty;


        #endregion

        #region Constructors

        /// <summary>
        /// DA0610 constructor
        /// </summary>
        public DA0610()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// DA0610 load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0610_Load(object sender, EventArgs e)
        {
            GetButtons();
            GetGrid();
            Initialize();
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);
            GetInfo();
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
                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                       
                    case "삭제":
                        DoDelete();
                        break;                        
                }
            }
            catch (SqlException ex)
            {
                SetMessage(ex.Message);
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        /// <summary>
        /// Box sub button change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox_Sub_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            txtErrorCode.Text = string.Empty;
            txtErrorName.Text = string.Empty;
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
                case "공정":
                    DA0650 da0650 = new DA0650();
                    ShowDialogForm(da0650);
                    DoFind();
                    btnConfBox[0, 1].Enable = false;
                    break;

                case "완성":
                    DA0660 da0660 = new DA0660();
                    ShowDialogForm(da0660);
                    DoFind();
                    btnConfBox[0, 1].Enable = false;
                    break;

                case "실적":
                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;
                    mesLabel11.Text = "불량합계";
                    mesGrid1.SelectProcedureName = "USP_DA0630_S3";
                    DoFind();
                    btnConfBox[0, 1].Enable = true;
                    break;

                case "집계":
                    btnLeftPage.LinkButtonBox = null;
                    btnRightPage.LinkButtonBox = null;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;
                    mesLabel11.Text = "불량합계";
                    mesGrid1.SelectProcedureName = "USP_DA0630_S7";
                    DoFind();
                    btnConfBox[0, 1].Enable = false;
                    break;

            }

            btnSelect.ReSetSelectedButtons();
        }

        /// <summary>
        /// Total qty textbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalQty_Click(object sender, EventArgs e)
        {
            if (mesGrid1.Visible)
            {
                return;
            }

            DA9100 da9100 = new DA9100();
            da9100.LabelTitle = "불량수량 입력";
            da9100.LabelHeader = "불량수량";

            if (DialogResult.OK == ShowDialogForm(da9100))
            {
                txtTotalQty.Text = da9100.ResultString;
            }
        }

        /// <summary>
        /// Box button change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            txtErrorCode.Text = sender.Tag.ToString();
            txtErrorName.Text = sender.Text;
        }

        /// <summary>
        /// Grid2 grid click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        //{
        //    if (mesGrid2.Rows.Count > 0)
        //    {
        //        try
        //        {
        //            txtOrderNo.Text = e.row.Cells["ORDERNO"].Value.ToString();

        //            Database database = DatabaseFactory.CreateDatabase();
        //            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
        //            SqlCommand sqlCommand = new SqlCommand();

        //            sqlCommand.CommandText = "USP_DA0630_S5";
        //            sqlCommand.CommandType = CommandType.StoredProcedure;

        //            sqlCommand.Parameters.Add(new SqlParameter("@pPLANTCODE", _WorkCenter.PlantCode));
        //            sqlCommand.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", _WorkCenter.Code));
        //            sqlCommand.Parameters.Add(new SqlParameter("@pOrderno", e.row.Cells["ORDERNO"].Value.ToString()));

        //            DataTable dt = new DataTable();

        //            clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

        //            txtOrderNo.Text = dt.Rows[0]["OrderNo"].ToString();
        //            txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString().Trim();
        //            txtItemName.Text = "[" + dt.Rows[0]["cartype"].ToString() + "]" + dt.Rows[0]["ItemName"].ToString();
        //            txtErrorQty.Text = dt.Rows[0]["ErrorQty"].ToString();
        //            txtInvalidQty.Text = dt.Rows[0]["InvalidQty"].ToString();

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

        /// <summary>
        /// Search button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get buttons
        /// </summary>
        private void GetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "취소";
            btnConfBox[0, 1].Text = "삭제";

            btnConfBox.RedrawButtons();

            btnSelect.CountX = 4;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "공정";
            btnSelect[0, 1].Text = "완성";
            btnSelect[0, 2].Text = "실적";
            btnSelect[0, 3].Text = "집계";

            btnSelect[0, 2].ButtonPressed = true;

            btnSelect.RedrawButtons();
        }

        /// <summary>
        /// Get grid
        /// </summary>
        private void GetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 10;
            mesGrid1.SelectProcedureName = "USP_DA0630_S3";
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            txtWorkCenterCode.Text = _WorkCenter.Code;
            txtWorkCenterName.Text = _WorkCenter.Name;
            txtErrorCode.Text = string.Empty;
            txtErrorName.Text = string.Empty;
            txtTotalQty.Text = "0";
            txtOrderNo.Text  = string.Empty;
            txtItemCode.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtErrorQty.Text = string.Empty;
            txtPLCErrorQty.Text = string.Empty;
            txtInvalidQty.Text  = _WorkCenter.InvalidQty.ToString();
            txtPLCProdQty.Text  = _WorkCenter.PLCProdQty.ToString();
        }

        /// <summary>
        /// Get info
        /// </summary>
        private void GetInfo()
        {
            string cartype = string.Empty;

            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                cartype = database.ExecuteScalar(CommandType.Text, "SELECT A.cartype FROM TBM0100 A WITH(NOLOCK) WHERE 1 = 1 AND A.itemcode  ='" + _WorkCenter.ItemCode + "'").ToString();
            }
            catch { }

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
                txtItemName.Text = "[" + cartype + "]" + dt.Rows[0]["ItemName"].ToString();
                txtErrorQty.Text = dt.Rows[0]["ErrorQty"].ToString();
                txtInvalidQty.Text = dt.Rows[0]["InvalidQty"].ToString();
                txtPLCProdQty.Text = dt.Rows[0]["PLCProdQty"].ToString();
                txtPLCErrorQty.Text = dt.Rows[0]["PLCErrorQty"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            int tqty = 0;

            foreach (DataRow dr in mesGrid1.DataSource.Rows)
            {
                try
                {
                    tqty += Convert.ToInt32(dr["ERRORQTY"]);
                }
                catch { }
            }
            txtTotalQty.Text = string.Format("{0:n0}", tqty);
        }

        #endregion

        private void txtOrderNo_Click(object sender, EventArgs e)
        {

        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSEQ     =  e._UltraGridRow.Cells["ROWSEQ"].Value.ToString() == "" ? 0 : Convert.ToInt32(e._UltraGridRow.Cells["ROWSEQ"].Value);
            _sRecDate = e._UltraGridRow.Cells["RECDATE"].Value.ToString();
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
                sqlCommand.Parameters.Add(new SqlParameter("@AS_ORDERNO", Common.SelectedWorkCenter.OrderNo));                
                sqlCommand.Parameters.Add(new SqlParameter("@AS_RECDATE", _sRecDate));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_SEQ", _iSEQ));
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
                    SetMessage("오류가 발생하여 작업이 취소되었습니다.");
                    clsDB.Rollback();                    
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
