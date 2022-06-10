using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

using SmartDas.Components;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SmartDas.POPUP;
using System.Data.SqlClient;
using System.Collections;
using Infragistics.Win.UltraWinGrid;

namespace SmartDas
{
    /// <summary>
    /// DA0650 class
    /// </summary>
    public partial class DA0650 : SmartDas.Components.BaseForm
    {
        #region Variables

        /// <summary>
        /// Workcenter
        /// </summary>
        WorkCenter _WorkCenter = Common.SelectedWorkCenter;

        /// <summary>
        /// Previous Select row
        /// </summary>
        int _iPrevRowIndex = -1;

        #endregion

        #region Constructors

        /// <summary>
        /// DA0650
        /// </summary>
        public DA0650()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// DA0650 load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0650_Load(object sender, EventArgs e)
        {
            GetButtons();
            GetBtnBox();
            GetBtnBox2();
            GetGrid();
            Initialize();
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
                        if (string.IsNullOrEmpty(mesLabel4.Text))
                        {
                            SetMessage("작업지시를 선택하세요.");
                            return;
                        }
                        if (string.IsNullOrEmpty(txtTotalQty.Text) || txtTotalQty.Text == "0")
                        {
                            SetMessage("불량 수량을 입력하세요.");
                            return;
                        }

                        if (string.IsNullOrEmpty(mesLabel5.Text))
                        {
                            SetMessage("불량 유형을 선택하세요.");
                            return;
                        }

                        if (mesGrid2.Rows.Count == 0)
                        {
                            SetMessage("BOM정보를 확인하여 주십시오");
                            return;
                        }

                        int iQty = mesGrid2.DataSource.AsEnumerable().Select(t => t.Field<int>("QTY_PER")).Sum();

                        if (iQty <= 0)
                        {
                            SetMessage("투입자재리스트 소요수량을 등록하여 주세요.");
                            return;
                        }

                        try
                        {
                            double dTotalQty = clsDB.nvlDouble(txtTotalQty.Text);

                            Database database = DatabaseFactory.CreateDatabase();
                            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                            clsDB.BeginTran(sqlConnection);

                            SqlCommand sqlCommand = (SqlCommand)database.GetStoredProcCommand("USP_DA0630_I1");

                            sqlCommand.Parameters.Add(new SqlParameter("@PPLANTCODE", _WorkCenter.PlantCode));
                            sqlCommand.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", _WorkCenter.Code));
                            sqlCommand.Parameters.Add(new SqlParameter("@PORDERNO", mesLabel4.Text));
                            sqlCommand.Parameters.Add(new SqlParameter("@PITEMCODE", mesLabel2.Text));
                            sqlCommand.Parameters.Add(new SqlParameter("@PERRORCODE", mesLabel5.Text));
                            sqlCommand.Parameters.Add(new SqlParameter("@PQTY", dTotalQty));
                            sqlCommand.Parameters.Add(new SqlParameter("@PNEWOLD", _WorkCenter.NewOld));

                            clsDB.gExecute(sqlConnection, sqlCommand);

                            clsDB.Commit();

                            if (mesLabel5.Text == "0000")
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

                            DoSave();
                        }
                        catch (SqlException ex)
                        {
                            SetMessage(ex.Message);
                            clsDB.Rollback();
                        }

                        mesGrid1.DataSource.Clear();
                        mesGrid1.DataBindings.Clear();

                        mesGrid2.DataSource.Clear();
                        mesGrid2.DataBindings.Clear();

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;

                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
        /// Mes grid1 grid click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            DataTable dt = mesGrid1.DataSource;

            if (_iPrevRowIndex != e._UltraGridRow.Index)
            {
                mesLabel2.Text = string.Empty;
                mesLabel4.Text = string.Empty;
                mesLabel5.Text = string.Empty;

                btnBox.ReSetSelectedButtons();
                btnBox2.ReSetSelectedButtons();
                DoFind1(string.Empty, string.Empty);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["BAD_CODE"] = string.Empty;
                        dr["BAD_NAME"] = string.Empty;
                    }
                }

                dt.AcceptChanges();
                mesLabel2.Text = mesGrid1.Row.Cells["ITEMCODE"].Value.ToString();
                mesLabel4.Text = mesGrid1.Row.Cells["ORDERNO"].Value.ToString();
            }

            _iPrevRowIndex = e._UltraGridRow.Index;
        }

        /// <summary>
        /// Box button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            btnBox2.ReSetSelectedButtons();
            
            if (string.IsNullOrEmpty(mesLabel2.Text))
            {
                return;
            }

            DataTable dt = mesGrid1.DataSource;

            if (dt != null && dt.Rows.Count > 0)
            {
                UltraGridRow ultraGridRow = mesGrid1.Row;

                if (ultraGridRow != null)
                {
                    ultraGridRow.Cells["BAD_CODE"].Value = sender.Tag.ToString();
                    ultraGridRow.Cells["BAD_NAME"].Value = sender.Text.ToString();
                    mesLabel5.Text = sender.Tag.ToString();

                    if (!string.IsNullOrEmpty(mesLabel4.Text) && !string.IsNullOrEmpty(txtTotalQty.Text))
                    {
                        DoFind1(mesLabel4.Text, txtTotalQty.Text);
                    }
                }
            }
        }

        /// <summary>
        /// Box2 button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBox2_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            btnBox.ReSetSelectedButtons();

            if (string.IsNullOrEmpty(mesLabel2.Text))
            {
                return;
            }

            DataTable dt = mesGrid1.DataSource;

            if (dt != null && dt.Rows.Count > 0)
            {
                UltraGridRow ultraGridRow = mesGrid1.Row;

                if (ultraGridRow != null)
                {
                    ultraGridRow.Cells["BAD_CODE"].Value = sender.Tag.ToString();
                    ultraGridRow.Cells["BAD_NAME"].Value = sender.Text.ToString();
                    mesLabel5.Text = sender.Tag.ToString();

                    if (!string.IsNullOrEmpty(mesLabel4.Text) && !string.IsNullOrEmpty(txtTotalQty.Text))
                    {
                        DoFind1(mesLabel4.Text, txtTotalQty.Text);
                    }
                }
            }
        }

        /// <summary>
        /// Total qty textbox click event
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

                if (!string.IsNullOrEmpty(mesLabel4.Text) && !string.IsNullOrEmpty(txtTotalQty.Text))
                {
                    DoFind1(mesLabel4.Text, txtTotalQty.Text);
                }
            }
        }

        /// <summary>
        /// Mes grid2 grid click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridColumn.ToString() == "QTY_PER")
            {
                DA9110 da9110 = new DA9110(this.Location.X + 30, this.Location.Y + 180);
                da9110.LabelTitle = "불량수량 입력";
                da9110.LabelHeader = "불량수량";

                if (DialogResult.OK == ShowDialogForm(da9110))
                {
                    try
                    {
                        string sValue = da9110.ResultString;

                        if (string.IsNullOrEmpty(sValue))
                        {
                            SetMessage("소요수량으로 0값 또는 값이 없는 상태로 등록 할 수 없습니다.");
                            return;
                        }

                        if (Convert.ToInt32(mesGrid2.Row.Cells["MAXQTY_PER"].Value) < Convert.ToInt32(da9110.ResultString))
                        {
                            SetMessage(mesGrid2.Row.Cells["MAXQTY_PER"].Value + "보다 큰수는 등록할수 없습니다.");
                            return;
                        }
                    }
                    catch { }

                    mesGrid2.Row.Cells["QTY_PER"].Value = da9110.ResultString;
                }
            }
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

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        /// <summary>
        /// Get btn box
        /// </summary>
        private void GetBtnBox()
        {
            btnBox.CountX = 6;
            btnBox.CountY = 4;
            btnBox.SelectProcedureName = "USP_DA0630_S6_C";
            btnBox.SetStoreProc();
            btnBox.ParameterList.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnBox.DoFind();
            btnBox.RedrawButtons();
        }

        /// <summary>
        /// Get btn box 2
        /// </summary>
        private void GetBtnBox2()
        {
            btnBox2.CountX = 6;
            btnBox2.CountY = 4;
            btnBox2.SelectProcedureName = "USP_DA0630_S6_M";
            btnBox2.SetStoreProc();
            btnBox2.ParameterList.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));

            btnBox2.DoFind();
            btnBox2.RedrawButtons();
        }

        /// <summary>
        /// Get grid
        /// </summary>
        private void GetGrid()
        {
            mesGrid1.FontSize = 12;
            mesGrid1.CountRows = 10;

            mesGrid1.SelectProcedureName = "USP_DA0610_S1";

            mesGrid2.FontSize  = 10;
            mesGrid2.CountRows = 10;

            mesGrid2.SelectProcedureName = "USP_DA0640_S1";
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            DoFind1(string.Empty, string.Empty);
            btnBox.RedrawButtons();
            btnBox2.RedrawButtons();
        }

        /// <summary>
        /// Do find
        /// </summary>
        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@PPLANTCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("@PWORKCENTERCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("@PPLANDATE", SqlDbType.VarChar));
            mesGrid1.ParameterList["@PPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
            mesGrid1.ParameterList["@PWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;
            mesGrid1.ParameterList["@PPLANDATE"].Value = System.DateTime.Now.ToString("yyyy-MM-dd");

            mesGrid1.DoFind();
        }

        /// <summary>
        /// Do find1
        /// </summary>
        /// <param name="orderNo"></param>
        /// <param name="totalQty"></param>
        private void DoFind1(string orderNo, string totalQty)
        {
            if (string.IsNullOrEmpty(txtTotalQty.Text) || txtTotalQty.Text == "0")
            {
                return;
            }

            mesGrid2.GetStoreProcedure();

            mesGrid2.ParameterList.Add(new SqlParameter("@PPLANTCODE", _WorkCenter.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@PWORKCENTERCODE", _WorkCenter.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@PORDERNO", orderNo));
            mesGrid2.ParameterList.Add(new SqlParameter("@PBADQTY", totalQty));

            mesGrid2.DoFind();

            DataTable dt = mesGrid2.DataSource;

            if (_WorkCenter.PlantCode == "SK1")
            {
                int qty = string.IsNullOrEmpty(txtTotalQty.Text) ? 0 : int.Parse(txtTotalQty.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["QTY_PER"] = int.Parse(dr["QTY"].ToString()) * qty;
                    }
                }
            }

            mesGrid2.Columns["ORDER_NO"].MergedCellContentArea = MergedCellContentArea.VisibleRect;
            mesGrid2.Columns["ORDER_NO"].MergedCellEvaluationType = MergedCellEvaluationType.MergeSameValue;
            mesGrid2.Columns["ORDER_NO"].MergedCellStyle = MergedCellStyle.Always;
        }

        /// <summary>
        /// Do save
        /// </summary>
        private void DoSave()
        {
            try
            {
                int iCnt = mesGrid2.Rows.Count;
                bool bFlag = false;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                clsDB.BeginTran(sqlConnection);

                for (int i = 0; iCnt > i; i++)
                {
                    string sQty = mesGrid2.Rows[i].Cells["QTY_PER"].Value.ToString().Trim();
                    if (sQty == "0" || sQty == "")
                    {
                        continue;
                    }

                    SqlCommand cmdsqlCommand = (SqlCommand)database.GetStoredProcCommand("USP_DA0640_I1");

                    cmdsqlCommand.Parameters.Add(new SqlParameter("@PPLANTCODE", _WorkCenter.PlantCode));
                    cmdsqlCommand.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", _WorkCenter.Code));
                    cmdsqlCommand.Parameters.Add(new SqlParameter("@PORDERNO", mesLabel4.Text));
                    cmdsqlCommand.Parameters.Add(new SqlParameter("@PITEMCODE", mesGrid2.Rows[i].Cells["RESOURCE_USED"].Value));
                    cmdsqlCommand.Parameters.Add(new SqlParameter("@PQTY", sQty));

                    clsDB.gExecute(sqlConnection, cmdsqlCommand);
                    bFlag = true;
                }

                clsDB.Commit();

                if (bFlag)
                {
                    SetMessage("정상적으로 등록되었습니다.");
                }
                else
                {
                    SetMessage("등록된 소모자재가 없습니다.\n 최소 하나 이상 등록하여 주시기 바랍니다.");
                    return;
                }
            }
            catch (SqlException ex)
            {
                SetMessage(ex.Message);
                clsDB.Rollback();
            }
        }

        #endregion
    }
}