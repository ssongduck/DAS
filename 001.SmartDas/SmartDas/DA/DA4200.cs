using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinGrid;
using SmartDas.POPUP;

namespace SmartDas
{
    /// <summary>
    /// DA4200 class
    /// </summary>
    public partial class DA4200 : SmartDas.Components.BaseForm
    {
        #region Variables

        /// <summary>
        /// Datatable
        /// </summary>
        DataTable _Dt = null;

        /// <summary>
        /// Line
        /// </summary>
        int _iline = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// DA4200 constructor
        /// </summary>
        public DA4200()
        {
            InitializeComponent();

            GetButtons();
           
            Initialize();
            GetGrid();
            DoFind();

            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

            try
            {
                _Dt = database.ExecuteDataSet(CommandType.Text, "SELECT A.WORKCENTERLINECODE, A.WORKCENTERLINENAME FROM TBM5210 A WHERE 1 = 1" +
                                                                "A.PLANTCODE = '" + Common.gsPlantCode + "' AND A.WORKCENTERCODE = '" + txtWorkCenterCode.Text + "' ORDER BY A.WORKCENTERLINECODE").Tables[0];

                txtLine.Text = _Dt.Rows[_iline]["WORKCENTERLINENAME"].ToString();
            }
            catch { }
        }

        #endregion

        #region Events

        /// <summary>
        /// Menu button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Tag.ToString())
                {
                    case "N":
                    case "D":

                        string line = string.Empty;

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        if (txtItemCode.Text.Trim() == string.Empty)
                        {
                            SetMessage("요청하는 소재나 팔레트를 선택하여 주십시오");
                            return;
                        }

                        try
                        {
                            line = txtLine.Text;
                        }
                        catch { }

                        Database database = DatabaseFactory.CreateDatabase();
                        SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                        SqlCommand sqlCommand = new SqlCommand();

                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.CommandText = "USP_DA4200_I1";
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@PPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                        sqlCommand.Parameters.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));
                        sqlCommand.Parameters.Add(new SqlParameter("@ITEMCODE", txtItemCode.Text.Trim()));
                        sqlCommand.Parameters.Add(new SqlParameter("@PITEMCODE", txtpItemCode.Text.Trim()));
                        sqlCommand.Parameters.Add(new SqlParameter("@PSTATUS", sender.Tag.ToString()));
                        sqlCommand.Parameters.Add(new SqlParameter("@PPLANTNO", txtOrderNo.Text.Trim()));
                        sqlCommand.Parameters.Add(new SqlParameter("@PLINE", line));
                        sqlCommand.Parameters.Add(new SqlParameter("@REMARK", txtRemark.Text));

                        if (clsDB.gExecute(sqlConnection, sqlCommand) < 0)
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }

                        DoFind();

                        break;


                    case "S":
                        DoFind();

                        break;


                    case "C":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (SqlException sqlException)
            {
                SetMessage(sqlException.Message);
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        /// <summary>
        /// Mes grid1 click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mesGrid1_GridClick(object sender, Components.MESGrid.GridClickEventArg e)
        {
            string remark = e._UltraGridRow.Cells["REMARK"].Value.ToString();

            if (e._UltraGridColumn.Key.ToString() == "REMARK")
            {
                DA9996 dA9996 = new DA9996(remark);
                ShowDialogForm(dA9996);

                if (dA9996.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    remark = dA9996.Remark;
                    e._UltraGridRow.Cells["REMARK"].Value = remark;
                }

                txtRemark.Text = remark;
            }

            txtStartTime.Text = e._UltraGridRow.Cells["STARTDATE"].Value.ToString();
            txtREQUESTSTARTDATE.Text = e._UltraGridRow.Cells["REQUESTSTARTDATE"].Value.ToString();
            txtpItemCode.Text = e._UltraGridRow.Cells["RESOURCE_USED"].Value.ToString();
            txtpItemName.Text = e._UltraGridRow.Cells["NAME"].Value.ToString();

            if (string.IsNullOrEmpty(e._UltraGridRow.Cells["DISSSTATUS"].Value.ToString()))
            {
                btnMenu[0, 0].Text = "보급요청";
                btnMenu[0, 0].Tag = "N";
                btnMenu.RedrawButtons();
            }
            else if (e._UltraGridRow.Cells["DISSSTATUS"].Value.ToString().StartsWith("[D]"))
            {
                btnMenu[0, 0].Text = "보급요청";
                btnMenu[0, 0].Tag = "D";
                btnMenu.RedrawButtons();
            }
            else
            {
                btnMenu[0, 0].Text = "조회";
                btnMenu[0, 0].Tag = "S";
                btnMenu.RedrawButtons();
            }
        }

        /// <summary>
        /// Eventtimer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStartTime.Text.Trim()))
            {
                TimeSpan timeSpan = (DateTime.Now - Convert.ToDateTime(txtStartTime.Text));
                string reqStartDate = string.Empty;

                reqStartDate = (timeSpan.Days == 0 ? string.Empty : timeSpan.Days.ToString() + "일 ")
                             + (timeSpan.Hours == 0 ? string.Empty : timeSpan.Hours.ToString() + "시간 ")
                             + (timeSpan.Minutes == 0 ? string.Empty : timeSpan.Minutes.ToString() + "분 ")
                             + (timeSpan.Seconds == 0 ? string.Empty : timeSpan.Seconds.ToString() + "초");

                txtREQUESTSTARTDATE.Text = reqStartDate;
            }
            else
            {
                txtREQUESTSTARTDATE.Text = string.Empty;
            }
        }

        /// <summary>
        /// Line textbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLine_Click(object sender, EventArgs e)
        {
            if (_Dt != null && _Dt.Rows.Count > 1)
            {
                if (_iline == _Dt.Rows.Count - 1)
                {
                    _iline = 0;
                }
                else
                {
                    ++_iline;
                }

                txtLine.Text = _Dt.Rows[_iline]["WORKCENTERLINENAME"].ToString();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtItemCode.Text = Common.SelectedWorkCenter.ItemCode;
            txtItemName.Text = Common.SelectedWorkCenter.ItemName;
            txtOrderNo.Text = Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo;
            txtOrderCnt.Text = Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).OrderCount.ToString();
        }

        /// <summary>
        /// Get buttons
        /// </summary>
        private void GetButtons()
        {
            btnMenu.CountX = 2;
            btnMenu.CountY = 1;

            btnMenu.SetButtons();

            btnMenu[0, 0].Text = "조회";
            btnMenu[0, 1].Text = "취소";

            btnMenu[0, 0].Tag = "S";
            btnMenu[0, 1].Tag = "C";

            btnMenu.RedrawButtons();
        }

        /// <summary>
        /// Get grid
        /// </summary>
        private void GetGrid()
        {
            mesGrid1.FontSize = 16;

            mesGrid1.SelectProcedureName = "USP_DA4200_S1";
        }

        /// <summary>
        /// Do find
        /// </summary>
        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.ParameterList.Add(new SqlParameter("@PPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@PWORKCENTERCODE", Common.SelectedWorkCenter.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@PORDERNO", txtOrderNo.Text.Trim()));

            mesGrid1.DoFind();

            mesGrid1.Columns["ORDER_NO"].MergedCellContentArea = MergedCellContentArea.VisibleRect;
            mesGrid1.Columns["ORDER_NO"].MergedCellEvaluationType = MergedCellEvaluationType.MergeSameValue;
            mesGrid1.Columns["ORDER_NO"].MergedCellStyle = MergedCellStyle.Always;

            btnMenu[0, 0].Text = "조회";
            btnMenu[0, 0].Tag = "S";
            btnMenu.RedrawButtons();
        }

        #endregion
    }
}
