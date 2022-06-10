using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

using SmartDas.Components;
using SmartDas.POPUP;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace SmartDas
{

    /// <summary>
    /// DA0060 class
    /// </summary>
    public partial class DA0060 : BaseForm
    {
        #region Variables

        /// <summary>
        /// Set boolean
        /// </summary>
        bool _bSet = false;

        /// <summary>
        /// Select row
        /// </summary>
        private int _iSelectRow;

        /// <summary>
        /// Second
        /// </summary>
        private int _iSecond = 0;

        /// <summary>
        /// Refresh second
        /// </summary>
        private int iRefreshSecond = 10;

        /// <summary>
        /// Data tbale
        /// </summary>
        private DataTable _Dt = null;

        /// <summary>
        /// Product qty
        /// </summary>
        private int _ProdQty = 0;

        #endregion

        #region Constructors

        /// <summary>D:\SVN_#1\02.SK_Sources\07.MES(삼미)\101_SmartDas\SmartDas\DA\DA0060.cs
        /// DA0060 constructor
        /// </summary>
        public DA0060()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        /// <summary>
        /// DA0060 load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0060_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            GetButtons();
            if (Common.gsPlantCode == "SK1")
            {
                GetGrid();
            }
            else
            {
                GetGrid("KR");                
            }
            
            Initialize();

            _iSelectRow = -1;

            EventTimerEnable = true;
            lblDayOrder_Click(null, null);
        }

        /// <summary>
        /// Event timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (_bSet && _iSecond++ < iRefreshSecond)
            {
                if (Common.SelectedWorkCenter != null)
                {
                    GetButtonStatus();
                }

                return;
            }

            _iSecond = 0;

            this.Cursor = Cursors.Default;

            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            try
            {
                string sWorkCenterCode = string.Empty;

                if (Common.SelectedWorkCenter != null)
                {
                    sWorkCenterCode = Common.SelectedWorkCenter.Code;
                }

                DoFind();

                if (Grid1.Visible)
                {
                    if (Grid1.Rows.Count == 0)
                    {
                        _iSelectRow = -1;
                        Common.SelectedWorkCenter = null;

                        Initialize();
                    }
                    else
                    {
                        if ((_iSelectRow >= Grid1.Rows.Count) || (_iSelectRow == -1))
                        {
                            _iSelectRow = 0;

                            Grid1.Rows[_iSelectRow].Selected = true;
                            Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[_iSelectRow].Cells[0]));
                        }
                        else
                        {
                            Grid1.Rows[_iSelectRow].Selected = true;
                            Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[_iSelectRow].Cells[0]));
                        }
                    }
                }
                else
                {
                    if (Grid2.Rows.Count == 0)
                    {
                        _iSelectRow = -1;
                        Common.SelectedWorkCenter = null;

                        Initialize();
                    }
                    else
                    {
                        if ((_iSelectRow >= Grid2.Rows.Count) || (_iSelectRow == -1))
                        {
                            _iSelectRow = 0;

                            Grid2.Rows[_iSelectRow].Selected = true;
                            Grid2_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid2.Rows[_iSelectRow].Cells[0]));
                        }
                        else
                        {
                            Grid2.Rows[_iSelectRow].Selected = true;
                            Grid2_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid2.Rows[_iSelectRow].Cells[0]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Grid1.DataSourceDS.Tables.Count == 1)
                {
                    SetMessage("작업장을 선택해주십시오!");
                }
                else
                {
                    SetMessage(ex.Message);
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Grid1 click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSelectRow = 0;

            WorkCenter workCenter = Common.GetWorkCenter(clsDB.nvlString(e._UltraGridRow.Cells["WorkcenterCode"].Value));

            Common.SelectedWorkCenter = workCenter;
            workCenter.ClearHash();
            Initialize();
            GetButtonStatus();
        }

        /// <summary>
        /// Grid2 click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSelectRow = 0;

            WorkCenter workCenter = Common.GetWorkCenter(clsDB.nvlString(e._UltraGridRow.Cells["WorkcenterCode"].Value));
            
            Common.SelectedWorkCenter = workCenter;
            workCenter.ClearHash();
            Initialize();
            GetButtonStatus();
        }

        /// <summary>
        /// Box button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBox1_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (!this._bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            if (Common.SelectedWorkCenter == null)
            {
                SetMessage("작업장을 선택하세요.");
                return;
            }

            try
            {
                MESButton mesButton = sender;
                WorkCenter workCenter = Common.SelectedWorkCenter;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = sqlConnection;

                switch (mesButton.Tag.ToString())
                {
                    case "Worker":
                        txtWorkerNames_Click(null, null);
                        break;

                    case "Order":
                        txtOrderNo_Click(null, null);
                        break;

                    case "Mold":
                        txtMoldName_Click(null, null);
                        break;

                    case "Run":
                        DA2200 da2200 = new DA2200();
                        ShowDialogForm(da2200);
                        break;

                    case "EndWork":
                        string sRemainQty = string.Empty;

                        DA9600 da9600 = new DA9600();
                        da9600.sRemainQty = database.ExecuteScalar(CommandType.Text, "SELECT A.PLCProdQty FROM TPP1700 A WITH(NOLOCK) WHERE 1 = 1 AND A.WorkCenterCode  ='" + workCenter.Code + "'").ToString();
                        if (DialogResult.OK == ShowDialogForm(da9600))
                        {
                            sRemainQty = da9600.sRemainQty;
                            if (sRemainQty == string.Empty)
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }

                        if (da9600.bLotcard && Convert.ToInt32(sRemainQty) > 0)
                        {
                            DA0500 da0500a = new DA0500();
                            da0500a.autoLot = da9600.sRemainQty;

                            if (DialogResult.OK == ShowDialogForm(da0500a))
                            {
                                sRemainQty = "0";
                            }
                            else
                            {
                                sRemainQty = database.ExecuteScalar(CommandType.Text, "SELECT A.PLCProdQty FROM TPP1700 A WITH(NOLOCK) WHERE 1 = 1 AND A.WorkCenterCode  ='" + workCenter.Code + "'").ToString();
                            }
                        }

                        sqlCommand.CommandText = "USP_DA0000_RunStop";
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.Add(new SqlParameter("@pPlantCode", workCenter.PlantCode));
                        sqlCommand.Parameters.Add(new SqlParameter("@pWorkCenterCode", workCenter.Code));
                        sqlCommand.Parameters.Add(new SqlParameter("@pStopCode", "0000"));
                        sqlCommand.Parameters.Add(new SqlParameter("@pStatus", "E"));
                        sqlCommand.Parameters.Add(new SqlParameter("@pRemainQty", sRemainQty));

                        if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }

                        txtPlanMoldName.Text = string.Empty;
                        txtMoldName.Text = string.Empty;

                        break;

                    case "Error":
                        DA0630 da0630 = new DA0630();
                        ShowDialogForm(da0630);
                        break;

                    case "State":
                        DA2100 da2100 = new DA2100();
                        ShowDialogForm(da2100);
                        break;

                    case "Lot":
                        DA0400 da0400 = new DA0400();
                        ShowDialogForm(da0400);
                        break;

                    case "InputProd":
                        DA0500 da0500 = new DA0500();
                        ShowDialogForm(da0500);
                        break;

                    case "MachErr":
                        if (ShowDialogForm(new MessageForm("설비 긴급 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                        {
                            return;
                        }

                        sqlCommand.CommandText = "SP_SEND_EQUIPMENT_MAINT_SMS";
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", workCenter.PlantCode));
                        sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", workCenter.Code));
                        sqlCommand.Parameters.Add(new SqlParameter("@NAME", workCenter.Name));

                        if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            ShowDialogForm(new MessageForm("정상적으로 문자가 발송되었습니다.", MessageBoxButtons.OK, "SMS 발송확인"));
                        }
                        break;

                    case "MoldRepair":
                        if (Common.gsPlantCode == "SK2")
                        {
                            if (ShowDialogForm(new MessageForm("금형 보전 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                            {
                                DA7010 da7010 = new DA7010();
                                ShowDialogForm(da7010);
                            }
                            else
                            {
                                sqlCommand.CommandText = "SP_SEND_MOLD_MAINT_SMS";
                                sqlCommand.Parameters.Clear();
                                sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", workCenter.PlantCode));
                                sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", workCenter.Code));
                                sqlCommand.Parameters.Add(new SqlParameter("@NAME", workCenter.Name));

                                if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                                {
                                    SetMessage(clsDB.ErrorDesc);
                                    return;
                                }
                                else
                                {
                                    ShowDialogForm(new MessageForm("정상적으로 문자가 발송되었습니다.", MessageBoxButtons.OK, "SMS 발송확인"));
                                    DA7010 da7010 = new DA7010();
                                    ShowDialogForm(da7010);
                                }
                            }
                        }
                        else
                        {
                            DA7010 da7010 = new DA7010();
                            ShowDialogForm(da7010);
                        }

                        break;

                    case "MachRepair":
                        DA1000 da1000 = new DA1000();
                        ShowDialogForm(da1000);
                        break;

                    case "Report":
                        DA1200 da1200 = new DA1200();
                        ShowDialogForm(da1200);
                        break;

                    case "CheckSelf":
                        DA4100 da4100 = new DA4100();
                        ShowDialogForm(da4100);
                        break;

                    case "Check":
                        DA1110 da1110 = new DA1110();
                        ShowDialogForm(da1110);
                        break;

                    case "4MCHANGE":
                        DA0130 da0130 = new DA0130();
                        ShowDialogForm(da0130);
                        break;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                _iSecond = iRefreshSecond;
                EventTimer_Tick(this, new EventArgs());
            }
        }

        /// <summary>
        /// Status button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatus_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Tag.ToString())
            {
                case "State":
                    DA2100 da2100 = new DA2100();
                    ShowDialogForm(da2100);
                    break;

                case "RunState":
                    DA2200 da2200 = new DA2200();
                    ShowDialogForm(da2200);
                    break;

                case "Cancel":
                    break;
            }

            btnStatus.Visible = false;
        }

        /// <summary>
        /// Mes click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMes_Click(object sender, EventArgs e)
        {
            DA9000 DA9000 = new DA9000();
            DA9000.Owner = this;
            ShowDialogForm(DA9000);

            _iSecond = iRefreshSecond;
            EventTimer_Tick(this, new EventArgs());
        }

        /// <summary>
        /// DA0060 form closed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0060_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        /// <summary>
        /// Network click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Mold name textbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMoldName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Common.SelectedWorkCenter.MoldCode))
            {
                DA0700 da0700 = new DA0700();
                da0700.sUseMoldyn = "Y";
                da0700.sUseMoldname = txtMoldName.Text.Trim();
                da0700.sUseMoldcode = txtMoldCode.Text.Trim();
                ShowDialogForm(da0700);
            }
            else
            {
                DA7000 da7000 = new DA7000();
                ShowDialogForm(da7000);
            }
        }

        /// <summary>
        /// Workername textbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWorkerNames_Click(object sender, EventArgs e)
        {
            DA0200 da0200 = new DA0200();
            ShowDialogForm(da0200);

            GetWorkerList(Common.SelectedWorkCenter);
        }

        /// <summary>
        /// Order no textbox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrderNo_Click(object sender, EventArgs e)
        {
            DA0120 da0120 = new DA0120();
            ShowDialogForm(da0120);

            GetWorkerList(Common.SelectedWorkCenter);
        }

        /// <summary>
        /// Mes label click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblDayOrder_Click(object sender, EventArgs e)
        {
            if (lblDayOrder.Text == "작지기준")
            {
                lblDayOrder.Text = "일자기준";
                Grid1.Visible = true;
                Grid2.Visible = false;
            }
            else
            {
                lblDayOrder.Text = "작지기준";
                Grid1.Visible = false;
                Grid2.Visible = true;
            }
            _bSet = false;
        }

        /// <summary>
        /// Autonomy inspection button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutonomyInsp_Click(object sender, EventArgs e)
        {

            if (Common.gsPlantCode == "SK1")
            {
                DA9997 dA9997 = new DA9997("금형고장", "BD03");
                ShowDialogForm(dA9997);
            }
            else
            {
                DA9993 da9993 = new DA9993();
                ShowDialogForm(da9993);

                if (da9993.DialogResult == DialogResult.Cancel)
                    return;

                string selang = da9993._Language;

                Common.GetLanguageList(selang);
                GetGrid(selang);
                SetLangugage();
            }
        }


        void SetLangugage()
        {
            lblTitle.Text    = Common.GetLanguage("T00026");
            lblMes.Text      = Common.GetLanguage("T00029");
            lblNetwork.Text  = Common.GetLanguage("T00030");

            lblWorkShop.Text = Common.GetLanguage("T00001");
            lblWorker.Text   = Common.GetLanguage("T00002");
            lblItem.Text     = Common.GetLanguage("T00003");
            lblOrderNo.Text  = Common.GetLanguage("T00004");
            lblTerminal.Text = Common.GetLanguage("T00005");
            lblOrderDie.Text = Common.GetLanguage("T00006");
            lblLoadDie.Text  = Common.GetLanguage("T00007");
            lblOrderQty.Text = Common.GetLanguage("T00008");
            lblDayOrder.Text = Common.GetLanguage("T00033");
            lblCavity.Text   = Common.GetLanguage("T00009");
            lblOverQty.Text  = Common.GetLanguage("T00010");
            lblWorkShopStatus.Text = Common.GetLanguage("T00024");
            
            bBox1[0, 0].Text = Common.GetLanguage("T00011");
            bBox1[0, 1].Text = Common.GetLanguage("T00012");
            bBox1[0, 2].Text = Common.GetLanguage("T00013");
            bBox1[0, 3].Text = Common.GetLanguage("T00014");
            bBox1[0, 4].Text = Common.GetLanguage("T00015");
            bBox1[0, 5].Text = Common.GetLanguage("T00016");
            bBox1[0, 6].Text = Common.GetLanguage("T00017");
            bBox1[1, 0].Text = Common.GetLanguage("T00018");
            bBox1[1, 1].Text = Common.GetLanguage("T00019");
            bBox1[1, 2].Text = Common.GetLanguage("T00020");
            bBox1[1, 3].Text = Common.GetLanguage("T00021");
            bBox1[1, 4].Text = "작업일보";
            if (Common.gsPlantCode == "SK2") { bBox1[1, 4].Text = Common.GetLanguage("T00022"); ; }
            bBox1[1, 5].Text = Common.GetLanguage("T00023");
            bBox1[1, 6].Text = Common.GetLanguage("T00024");

            btnAutonomyInsp.Text = Common.GetLanguage("T00027");
            btnWorkReport.Text   = Common.GetLanguage("T00028");
        }

        /// <summary>
        /// btn work report click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkReport_Click(object sender, EventArgs e)
        {            
            //패트롤검사
            //DA9994 dA9994 = new DA9994(Common.SelectedWorkCenter.PlantCode, Common.SelectedWorkCenter.Code, Common.SelectedWorkCenter.OrderNo);
            //ShowDialogForm(dA9994);             

            if (Common.SelectedWorkCenter.OrderNo == "")
            {
                SetMessage("작업지시를 선택하세요.");
                return;    
            }

            if (Common.gsPlantCode == "SK2")
            {
                //특이사항                
                string sDate = "20" + Common.SelectedWorkCenter.OrderNo.Substring(0, 2) + "-" + Common.SelectedWorkCenter.OrderNo.Substring(2, 2) + "-" + Common.SelectedWorkCenter.OrderNo.Substring(4, 2);
                DA9120 da9120 = new DA9120(Common.SelectedWorkCenter.PlantCode, Common.SelectedWorkCenter.Code, sDate, Common.gDayNight, txtOrderNo.Text);
                ShowDialogForm(da9120);
                SetMessage(da9120.ResultString);
            }
            else
            {                
                DA9994 dA9994 = new DA9994(Common.SelectedWorkCenter.PlantCode, Common.SelectedWorkCenter.Code, Common.SelectedWorkCenter.OrderNo);
                ShowDialogForm(dA9994);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get buttons
        /// </summary>
        private void GetButtons()
        {
            //btnAutonomyInsp.Visible = (Common.gsPlantCode == "SK1") ? true : false;

            if (Common.gsPlantCode == "SK1")
            {
                btnAutonomyInsp.Text = "비가동"+"\r\n"+"등록";
                btnWorkReport.Text = "검사"+"\r\n"+"등록";                
            }
            else
            {
                btnAutonomyInsp.Text = "언어"+"\r\n"+"선택";
                btnWorkReport.Text = "특이사항"+"\r\n"+"등록";
            }

            bBox1.CountX = 7;
            bBox1.CountY = 2;

            bBox1.SetButtons();

            bBox1[0, 0].Text = "작업자선택";
            bBox1[0, 0].Tag = "Worker";

            bBox1[0, 1].Text = "지시선택";
            bBox1[0, 1].Tag = "Order";

            bBox1[0, 2].Text = "금형";
            bBox1[0, 2].Tag = "Mold";
            bBox1[0, 2].UseFlag = true;

            bBox1[0, 3].Text = "금형보전";
            bBox1[0, 3].Tag = "MoldRepair";

            bBox1[0, 4].Text = "보급요청";
            bBox1[0, 4].Tag = "CheckSelf";
            bBox1[0, 4].UseFlag = true;

            bBox1[0, 5].Text = "변경점";
            bBox1[0, 5].Tag = "4MCHANGE";

            bBox1[0, 6].Text = "작업완료";
            bBox1[0, 6].Tag = "EndWork";

            bBox1[1, 0].Text = "실적등록";
            bBox1[1, 0].Tag = "InputProd";

            bBox1[1, 1].Text = "불량등록";
            bBox1[1, 1].Tag = "Error";

            bBox1[1, 2].Text = "설비고장";
            bBox1[1, 2].Tag = "MachErr";

            bBox1[1, 3].Text = "설비보전";
            bBox1[1, 3].Tag = "MachRepair";

            bBox1[1, 4].Text = "작업일보";
            if (Common.gsPlantCode == "SK2")
            {
                bBox1[1, 4].Text = "주조조건";
            }

            bBox1[1, 4].Tag = "Report";

            bBox1[1, 5].Text = "비가동";
            bBox1[1, 5].Tag = "Run";

            bBox1[1, 6].Text = "작업현황";
            bBox1[1, 6].Tag = "State";

            bBox1.RedrawButtons();

            btnStatus.Visible = false;
            btnStatus.CountX = 1;
            btnStatus.CountY = 3;

            btnStatus.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Buttons;
            btnStatus.SetButtons();

            btnStatus[0, 0].Tag = "State";
            btnStatus[0, 0].Text = "작업현황";

            btnStatus[1, 0].Tag = "RunState";
            btnStatus[1, 0].Text = "가동현황";

            btnStatus[2, 0].Tag = "Cancel";
            btnStatus[2, 0].Text = "취소";

            btnStatus.RedrawButtons();
        }

        /// <summary>
        /// Get grid
        /// </summary>
        /// 
        private void GetGrid()
        {
            Grid1.CountRows = 3;
            Grid1.SelectProcedureName = "USP_DA0060_S1";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));            

            Grid2.CountRows = 3;
            Grid2.SelectProcedureName = "USP_DA0060_S2";
            Grid2.GetStoreProcedure();
            Grid2.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));            
        }


        private void GetGrid(string Language)
        {
            Grid1.CountRows = 3;
            Grid1.SelectProcedureName = "USP_DA0060_S1";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
            Grid1.ParameterList.Add(new SqlParameter("@pLang", Language));

            Grid2.CountRows = 3;
            Grid2.SelectProcedureName = "USP_DA0060_S2";
            Grid2.GetStoreProcedure();
            Grid2.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
            Grid2.ParameterList.Add(new SqlParameter("@pLang", Language));
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void Initialize()
        {
            txtPCName.Text = SystemInformation.ComputerName;

            if (Common.SelectedWorkCenter == null)
            {
                txtWorkCenterCode.Text = string.Empty;
                txtWorkCenterName.Text = string.Empty;
                txtWorkerCnt.Text = "0";
                txtWorkerNames.Text = string.Empty;
                txtOrderNo.Text = string.Empty;
                txtItemCode.Text = string.Empty;
                txtItemName.Text = string.Empty;
                txtPlanMoldName.Text = string.Empty;
                txtMoldName.Text = string.Empty;
                txtPlanQty.Text = string.Empty;
                txtLineStatus.Text = string.Empty;
                txtLastLineDate.Text = string.Empty;
                txtCarryInQty.Text = string.Empty;
            }
            else
            {
                WorkCenter workCenter = Common.SelectedWorkCenter;
                string cartype = string.Empty;

                try
                {
                    Database database;
                    database = DatabaseFactory.CreateDatabase();
                    SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                    cartype = database.ExecuteScalar(CommandType.Text, "SELECT A.CARTYPE  FROM TBM0100 A WITH(NOLOCK) WHERE 1 = 1 AND A.ITEMCODE ='" + workCenter.ItemCode + "'").ToString();
                }
                catch { }

                txtWorkCenterCode.Text = workCenter.Code;
                //txtWorkCenterName.Text = workCenter.Name + (Common.sERPDB == "ERPSVR.SKA_SFG" ? "(서산)" : Common.sERPDB == "ERPSVR.SKA_MFG" ? "(평택)" : "(삼기EV)");
                txtWorkCenterName.Text = workCenter.Name;
                txtItemCode.Text = workCenter.ItemCode;
                txtItemName.Text = "[" + cartype + "]" + workCenter.ItemName;
                txtWorkerNames.Text = workCenter.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName;
                txtWorkerCnt.Text = workCenter.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount.ToString();
                txtOrderNo.Text = workCenter.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo;
                txtPlanMoldCode.Text = string.IsNullOrEmpty(txtOrderNo.Text) ? string.Empty : workCenter.PlanMoldCode;
                txtPlanMoldName.Text = string.IsNullOrEmpty(txtOrderNo.Text) ? string.Empty : workCenter.PlanMoldName;
                txtMoldCode.Text = string.IsNullOrEmpty(txtOrderNo.Text) ? string.Empty : workCenter.MoldCode;
                txtMoldName.Text = string.IsNullOrEmpty(txtOrderNo.Text) ? string.Empty : workCenter.MoldName;
                if (_ProdQty == (int)workCenter.PlanQty)
                {
                    txtPlanQty.Text = string.Format("{0:0,0}", workCenter.PlanQty);
                }
                else
                {
                    txtPlanQty.Text = string.Format("{0:0,0}\n계 {1:0,0}", workCenter.PlanQty, _ProdQty);
                }

                txtLineStatus.Text = workCenter.LineStatus == "R" ? "가동" : "비가동";
                txtLastLineDate.Text = workCenter.LastLineDate;
                txtCarryInQty.Text = workCenter.CarryInQty;
            }

            string sDownTimeState = GetDownTimeState();

            if (!string.IsNullOrEmpty(sDownTimeState))
            {
                DA9997 dA9997 = new DA9997("금형고장", "BD03");
                ShowDialogForm(dA9997);
            }
        }

        /// <summary>
        /// Get down time state
        /// </summary>
        /// <returns></returns>
        private string GetDownTimeState()
        {
            string sRtn = string.Empty;

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "SP_GET_DOWN_TIME_STATE";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@WK_CENTER", txtWorkCenterCode.Text));

            DataTable dt = new DataTable();

            clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                sRtn = dt.Rows[0]["DOWN_CD"].ToString();
            }

            return sRtn;
        }

        /// <summary>
        /// Do find
        /// </summary>
        private void DoFind()
        {            
            if (txtOrderNo.Text != string.Empty)
            {
                string wDate = string.Empty;
                if (DateTime.Now.Hour < 8)
                {
                    wDate = DateTime.Now.AddDays(-1).ToString("yyMMdd");
                }
                else
                {
                    wDate = DateTime.Now.ToString("yyMMdd");
                }

                if (txtOrderNo.Text.StartsWith(wDate) == false)
                {
                    if (txtOrderNo.Text.Trim() == string.Empty)
                    {
                        SetMessage("작업지시서를 선택해주십시오!");
                    }
                    else
                    {
                        SetMessage("작업완료 후 작업지시서를 변경해주십시오!");
                    }
                }
                else
                {
                    SetMessage(string.Empty);
                }
            }

            if (Grid1.Visible)
            {
                Grid1.DoFind();

                if (Grid1.DataSourceDS.Tables.Count >= 3)
                {
                    bBox1[1, 0].UseFlag = true;
                    bBox1[1, 1].UseFlag = true;

                    foreach (DataRow dr in Grid1.DataSourceDS.Tables[2].Rows)
                    {
                        if (dr["useflag"].ToString() == "N")
                        {
                            SetMessage(dr["orderno"].ToString() + "삭제된 작지입니다. 완료처리바람.");
                            bBox1[1, 0].UseFlag = false;
                            bBox1[1, 1].UseFlag = false;
                            break;
                        }
                    }
                }
                if (Grid2.Rows.Count > 1) { return; }
                if (Grid1.DataSourceDS.Tables.Count >= 4)
                {
                    if (Grid1.DataSourceDS.Tables[3].Rows.Count == 1)
                    {
                        iRefreshSecond = clsDB.nvlInt(Grid1.DataSourceDS.Tables[3].Rows[0]["RelCode1"]);

                        if (iRefreshSecond == 0)
                        {
                            iRefreshSecond = 30;
                        }
                    }
                }

                Common.gListWorkCenter.Clear();

                if (Grid1.DataSource != null)
                {
                    foreach (DataRow dr in Grid1.DataSource.Rows)
                    {
                        WorkCenter workCenter = new WorkCenter();

                        workCenter.PlantCode = clsDB.nvlString(dr["PlantCode"]);
                        workCenter.Code = clsDB.nvlString(dr["WorkCenterCode"]);
                        workCenter.Name = clsDB.nvlString(dr["WorkCenterName"]);
                        workCenter.OrderCnt = clsDB.nvlInt(dr["OrderCnt"]);
                        workCenter.WorkerCnt = clsDB.nvlInt(dr["WorkerCnt"]);
                        workCenter.OrderNo = clsDB.nvlString(dr["OrderNo"]);
                        workCenter.ItemCode = clsDB.nvlString(dr["ItemCode"]);
                        workCenter.ItemName = clsDB.nvlString(dr["ItemName"]);
                        workCenter.UnitCode = clsDB.nvlString(dr["UnitCode"]);
                        workCenter.PlanQty = clsDB.nvlDouble(dr["PlanQty"]);
                        workCenter.ProdQty = clsDB.nvlDouble(dr["ProdQty"]);
                        workCenter.ErrorQty = clsDB.nvlDouble(dr["ErrorQty"]);
                        workCenter.PLCProdQty = clsDB.nvlDouble(dr["PLCProdQty"]);
                        workCenter.PLCErrorQty = clsDB.nvlDouble(dr["PLCErrorQty"]);
                        workCenter.LineStatus = clsDB.nvlString(dr["LineStatus"]);
                        workCenter.LastLineDate = clsDB.nvlString(dr["LastLineDate"]);
                        workCenter.NextWork = clsDB.nvlString(dr["NextWork"]);
                        workCenter.MachErrorCnt = clsDB.nvlInt(dr["MachErrorCnt"]);
                        workCenter.MultiOrderNo = clsDB.nvlString(dr["MultiOrderNo"]);
                        workCenter.AutoGathering = clsDB.nvlString(dr["AutoGathering"]);
                        workCenter.PlanMoldCode = clsDB.nvlString(dr["PlanMoldCode"]);
                        workCenter.PlanMoldName = clsDB.nvlString(dr["PlanMoldName"]);
                        workCenter.MoldCode = clsDB.nvlString(dr["MoldCode"]);
                        workCenter.MoldName = clsDB.nvlString(dr["MoldName"]);
                        workCenter.NewOld = clsDB.nvlString(dr["NewOld"]);
                        workCenter.InvalidQty = clsDB.nvlDouble(dr["InvalidQty"]);
                        workCenter.CarryInQty = clsDB.nvlString(dr["CARRYINQTY"]);

                        _ProdQty = Convert.ToInt32(dr["D_PRODQTY"]);

                        mesLabel17.Text = dr["cavity"].ToString();

                        Common.gListWorkCenter.Add(workCenter);

                        GetWorkerList(workCenter);
                        GetOrderList(workCenter);

                        workCenter.ClearHash();
                    }

                    _bSet = true;
                }
            }
            else
            {
                Grid2.DoFind();

                if (Grid2.DataSourceDS.Tables.Count >= 3)
                {
                    _Dt = Grid2.DataSourceDS.Tables[2];
                }

                if (Grid2.DataSourceDS.Tables.Count >= 4)
                {
                    if (Grid2.DataSourceDS.Tables[3].Rows.Count == 1)
                    {
                        iRefreshSecond = clsDB.nvlInt(Grid2.DataSourceDS.Tables[3].Rows[0]["RelCode1"]);

                        if (iRefreshSecond == 0)
                        {
                            iRefreshSecond = 30;
                        }
                    }
                }

                Common.gListWorkCenter.Clear();

                if (Grid2.DataSource != null)
                {
                    foreach (DataRow dr in Grid2.DataSource.Rows)
                    {
                        WorkCenter workCenter = new WorkCenter();

                        workCenter.PlantCode = clsDB.nvlString(dr["PlantCode"]);
                        workCenter.Code = clsDB.nvlString(dr["WorkCenterCode"]);
                        workCenter.Name = clsDB.nvlString(dr["WorkCenterName"]);
                        workCenter.OrderCnt = clsDB.nvlInt(dr["OrderCnt"]);
                        workCenter.WorkerCnt = clsDB.nvlInt(dr["WorkerCnt"]);
                        workCenter.OrderNo = clsDB.nvlString(dr["OrderNo"]);
                        workCenter.ItemCode = clsDB.nvlString(dr["ItemCode"]);
                        workCenter.ItemName = clsDB.nvlString(dr["ItemName"]);
                        workCenter.UnitCode = clsDB.nvlString(dr["UnitCode"]);
                        workCenter.PlanQty = clsDB.nvlDouble(dr["PlanQty"]);
                        workCenter.ProdQty = clsDB.nvlDouble(dr["ProdQty"]);
                        workCenter.ErrorQty = clsDB.nvlDouble(dr["ErrorQty"]);
                        workCenter.PLCProdQty = clsDB.nvlDouble(dr["PLCProdQty"]);
                        workCenter.PLCErrorQty = clsDB.nvlDouble(dr["PLCErrorQty"]);
                        workCenter.LineStatus = clsDB.nvlString(dr["LineStatus"]);
                        workCenter.LastLineDate = clsDB.nvlString(dr["LastLineDate"]);
                        workCenter.NextWork = clsDB.nvlString(dr["NextWork"]);
                        workCenter.MachErrorCnt = clsDB.nvlInt(dr["MachErrorCnt"]);
                        workCenter.MultiOrderNo = clsDB.nvlString(dr["MultiOrderNo"]);
                        workCenter.AutoGathering = clsDB.nvlString(dr["AutoGathering"]);
                        workCenter.PlanMoldCode = clsDB.nvlString(dr["PlanMoldCode"]);
                        workCenter.PlanMoldName = clsDB.nvlString(dr["PlanMoldName"]);
                        workCenter.MoldCode = clsDB.nvlString(dr["MoldCode"]);
                        workCenter.MoldName = clsDB.nvlString(dr["MoldName"]);
                        workCenter.NewOld = clsDB.nvlString(dr["NewOld"]);
                        workCenter.InvalidQty = clsDB.nvlDouble(dr["InvalidQty"]);
                        workCenter.CarryInQty = clsDB.nvlString(dr["CARRYINQTY"]);

                        _ProdQty = Convert.ToInt32(dr["D_PRODQTY"]);

                        mesLabel17.Text = dr["cavity"].ToString();

                        Common.gListWorkCenter.Add(workCenter);

                        GetWorkerList(workCenter);
                        GetOrderList(workCenter);

                        workCenter.ClearHash();
                    }

                    _bSet = true;
                }
            }
        }
        
        /// <summary>
        /// Get worker list
        /// </summary>
        /// <param name="workCenter"></param>
        private void GetWorkerList(WorkCenter workCenter)
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "USP_DA0200_S3";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pPLANTCODE", workCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", workCenter.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                workCenter.GetWorkerList(Common.ListWorkerType.SELECT).Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    workCenter.GetWorkerList(Common.ListWorkerType.SELECT).AddWorker(dr["WORKERID"].ToString(), dr["WORKERNAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        /// <summary>
        /// Get order list
        /// </summary>
        /// <param name="workCenter"></param>
        private void GetOrderList(WorkCenter workCenter)
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "USP_DA0100_S3";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@pPLANTCODE", workCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", workCenter.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                workCenter.GetOrderList(Common.ListOrderType.SELECT).Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    workCenter.GetOrderList(Common.ListOrderType.SELECT).AddOrder(dr["OrderNo"].ToString(), dr["ItemCode"].ToString());
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        /// <summary>
        /// Get button status
        /// </summary>
        private void GetButtonStatus()
        {
            if (Common.SelectedWorkCenter == null)
            {
                return;
            }

            WorkCenter workCenter = Common.SelectedWorkCenter;

            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)database.CreateConnection();
                SqlCommand cmd = new SqlCommand();
                string dt= DateTime.Now.Hour<8 ? DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"):DateTime.Now.ToString("yyyy-MM-dd");

                if (database.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM TPP1600 A WITH(NOLOCK) WHERE 1 = 1 AND A.PLANTCODE ='" + Common.gsPlantCode +
                                                                                                                   "' AND WorkCenterCode ='" + workCenter.Code +
                                                                                                                   "' AND recdate ='" + dt +
                                                                                                                   "' AND Status='S' AND StopCode IS NULL").ToString() != "0")
                {
                    bBox1.GetButtonByTag("Run").bAlarm = true;
                }
                else
                {
                    bBox1.GetButtonByTag("Run").bAlarm = false;
                }

                if (string.IsNullOrEmpty(workCenter.MoldCode))
                {
                    if (Common.gsPlantCode == "SK1") 
                        bBox1.GetButtonByTag("Mold").Text = "금형상형";
                    else                        
                        bBox1.GetButtonByTag("Mold").Text = Common.GetLanguage("T00013");

                    bBox1.GetButtonByTag("Mold").bAlarm = true;
                }
                else
                {
                    if (Common.gsPlantCode == "SK1")
                        bBox1.GetButtonByTag("Mold").Text = "금형하형";
                    else
                        bBox1.GetButtonByTag("Mold").Text = Common.GetLanguage("T00025");
                    bBox1.GetButtonByTag("Mold").bAlarm = false;
                }

                if (database.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM TCM0200 A WITH(NOLOCK) WHERE 1 = 1 AND A.PLANTCODE ='" + Common.gsPlantCode + "' AND WORKCENTERCODE ='" + workCenter.Code + "'  AND MACHCODE IS NULL AND STARTDATE IS NOT NULL").ToString() != "0")
                {
                    bBox1.GetButtonByTag("MachRepair").bAlarm = true;
                }
                else
                {
                    bBox1.GetButtonByTag("MachRepair").bAlarm = false;
                }

                bBox1.RedrawButtons();
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Set workcenter
        /// </summary>
        public bool bSetWorkCenter
        { set { _bSet = value; } }

        #endregion



    }
}
