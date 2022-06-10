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

namespace SmartDas
{
    /// <summary>
    /// DA0050 class
    /// </summary>
    public partial class DA0050 : BaseForm
    {
        #region Variables

        /// <summary>
        /// Set boolean
        /// </summary>
        bool _bSet = false;

        /// <summary>
        /// Selet row
        /// </summary>
        private int _iSelectRow;

        /// <summary>
        /// Second
        /// </summary>
        private int _iSecond = 0;

        /// <summary>
        /// Refresh second
        /// </summary>
        private int _iRefreshSecond = 10;

        /// <summary>
        /// Data table
        /// </summary>
        private DataTable _Dt = null;

        /// <summary>
        /// Product qty
        /// </summary>
        private int _ProdQty = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// DA0050 constructor
        /// </summary>
        public DA0050()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// DA0050 load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0050_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            GetButtons();
            GetGrid();
            Initialize();

            _iSelectRow = -1;

            EventTimerEnable = true;
        }

        /// <summary>
        /// Event timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (_bSet && _iSecond++ < _iRefreshSecond)
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
            _iSelectRow = e._UltraGridRow.Index;

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

                switch (mesButton.Tag.ToString())
                {
                    case "InputProd":
                        if (workCenter.GetOrderList(Common.ListOrderType.SELECT).OrderCount == 0)
                        {
                            SetMessage("작지가 선택되어야 실적등록 처리를 할 수 있습니다.");
                            return;
                        }
                        break;
                }

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = sqlConnection;

                switch (mesButton.Tag.ToString())
                {
                    case "Worker": // 작업자선택
                        txtWorkerNames_Click(null, null);
                        break;

                    case "Order": // 지시선택
                        txtOrderNo_Click(null, null);
                        break;

                    case "MNonWork": // 설비비가동
                        DA2300 da23001 = new DA2300();
                        ShowDialogForm(da23001);
                        break;

                    case "Run": // 비가동
                        DA2200 da22000 = new DA2200();
                        ShowDialogForm(da22000);
                        break;

                    case "EndWork": // 작업완료
                        if (workCenter.OrderCnt == 1)
                        {
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
                            sqlCommand.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                            sqlCommand.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                            sqlCommand.Parameters.Add(new SqlParameter("@pStopCode", "0000"));
                            sqlCommand.Parameters.Add(new SqlParameter("@pStatus", "E"));
                            sqlCommand.Parameters.Add(new SqlParameter("@pRemainQty", sRemainQty));

                            if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        else
                        {
                            string sOrderNo = string.Empty;

                            DA9530 da9530 = new DA9530();

                            if (DialogResult.OK == ShowDialogForm(da9530))
                            {
                                sOrderNo = da9530.sOrderNo;
                            }
                            else
                            {
                                return;
                            }

                            sqlCommand.CommandText = "USP_DA0000_RunStop";
                            sqlCommand.Parameters.Clear();
                            sqlCommand.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                            sqlCommand.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                            sqlCommand.Parameters.Add(new SqlParameter("@pStopCode", "0000"));
                            sqlCommand.Parameters.Add(new SqlParameter("@pStatus", "E"));
                            sqlCommand.Parameters.Add(new SqlParameter("@pRemainQty", 0));
                            sqlCommand.Parameters.Add(new SqlParameter("@pOrderNo", sOrderNo));

                            if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        break;

                    case "Error": // 불량등록
                        DA0610 da0610 = new DA0610();
                        ShowDialogForm(da0610);
                        break;

                    case "State": // 작업현황
                        DA2100 da2100 = new DA2100();
                        ShowDialogForm(da2100);
                        break;

                    case "RunState": // 비가동
                        DA2200 da2200 = new DA2200();
                        ShowDialogForm(da2200);
                        break;

                    case "Lot": // LOT투입
                        DA0400 da0400 = new DA0400();
                        ShowDialogForm(da0400);
                        break;

                    case "InputProd": // 실적등록
                        DA0500 da0500 = new DA0500();
                        ShowDialogForm(da0500);
                        break;

                    case "MachErr": // 설비고장
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

                    case "MachRepair": // 설비보전
                        DA1000 da1000 = new DA1000();
                        ShowDialogForm(da1000);
                        break;

                    case "CheckSelf": // 보급요청
                        DA4200 da4200 = new DA4200();
                        ShowDialogForm(da4200);
                        break;

                    case "Check": // (일상점검등록)
                        DA1110 da1110 = new DA1110();
                        ShowDialogForm(da1110);
                        break;

                    case "HMove": // (함침이동LOT발행)
                        DA2500 da2500 = new DA2500();
                        ShowDialogForm(da2500);
                        break;

                    case "4MCHANGE": // 변경점등록
                        DA0130 da0130 = new DA0130();
                        ShowDialogForm(da0130);
                        break;

                    case "Popup":
                        btnStatus.Visible = true;
                        break;

                    case "Report": // 작업일보
                        DA1210 da1210 = new DA1210();
                        ShowDialogForm(da1210);
                        break;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                _iSecond = _iRefreshSecond;
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

            _iSecond = _iRefreshSecond;
            EventTimer_Tick(this, new EventArgs());
        }

        /// <summary>
        /// DA0050 form closed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DA0050_FormClosed(object sender, FormClosedEventArgs e)
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
        /// Worker names textbox click event
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
            DA0100 da0100 = new DA0100();
            ShowDialogForm(da0100);

            GetWorkerList(Common.SelectedWorkCenter);
        }

        /// <summary>
        /// Autonomy inspection button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutonomyInsp_Click(object sender, EventArgs e)
        {
            DA9997 dA9997 = new DA9997("툴고장", "BD06");
            ShowDialogForm(dA9997);
        }
        
        private void btnInspReg_Click(object sender, EventArgs e)
        {
            DA9994 dA9994 = new DA9994(Common.SelectedWorkCenter.PlantCode, Common.SelectedWorkCenter.Code, Common.SelectedWorkCenter.OrderNo);
            ShowDialogForm(dA9994);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get buttons
        /// </summary>
        private void GetButtons()
        {
            //btnAutonomyInsp.Visible = (Common.gsPlantCode == "SK1") ? true : false;

            bBox1.CountX = 7;
            bBox1.CountY = 2;

            bBox1.SetButtons();

            bBox1[0, 0].Text = "작업자선택";
            bBox1[0, 0].Tag = "Worker";

            bBox1[0, 1].Text = "지시선택";
            bBox1[0, 1].Tag = "Order";

            bBox1[0, 2].Text = "비가동";
            bBox1[0, 2].Tag = "Run";

            bBox1[0, 3].Text = "설비\n비가동";
            bBox1[0, 3].Tag = "MNonWork";

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
            bBox1[1, 4].Tag = "Report";

            bBox1[1, 5].Text = "함침이동";
            bBox1[1, 5].Tag = "HMove";

            if (Common.gsPlantCode == "SK2")
            {
                bBox1[1, 5].Text = "LOT 투입";
                bBox1[1, 5].Tag = "Lot";
            }

            bBox1[1, 6].Tag = "State";
            bBox1[1, 6].Text = "작업현황";

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

            buttonBox1.Visible = false;
            buttonBox1.CountX = 1;
            buttonBox1.CountY = 3;

            buttonBox1.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Buttons;
            buttonBox1.SetButtons();

            buttonBox1[0, 0].Tag = "WNonWork";
            buttonBox1[0, 0].Text = "작업장";

            buttonBox1[1, 0].Tag = "MNonWork";
            buttonBox1[1, 0].Text = "설비";

            buttonBox1[2, 0].Tag = "Cancel";
            buttonBox1[2, 0].Text = "취소";

            buttonBox1.RedrawButtons();
        }

        /// <summary>
        /// Get grid
        /// </summary>
        private void GetGrid()
        {
            Grid1.CountRows = 3;

            Grid1.SelectProcedureName = "[USP_DA0050_S1]";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
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
                txtOrderCnt.Text = "0";
                txtItemCode.Text = string.Empty;
                txtItemName.Text = string.Empty;
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
                    Database database = DatabaseFactory.CreateDatabase();
                    SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                    cartype = database.ExecuteScalar(CommandType.Text, "SELECT A.cartype FROM TBM0100 A WITH(NOLOCK) WHERE 1 = 1 AND A.itemcode  ='" + workCenter.ItemCode.Split(' ')[0] + "'").ToString();
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
                txtOrderCnt.Text = workCenter.GetOrderList(Common.ListOrderType.SELECT).OrderCount.ToString();
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

                string sDownTimeState = GetDownTimeState();

                if (!string.IsNullOrEmpty(sDownTimeState))
                {
                    DA9997 dA9997 = new DA9997("툴고장", "BD06");
                    ShowDialogForm(dA9997);
                }
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
                    if (txtOrderNo.Text.Trim() == "")
                    {
                        SetMessage("작업지시서를 선택해주십시오!");
                    }
                    else
                    {
                        SetMessage("작업완료 후 작업지시서를 변경해주십시오!");
                    }
                }
            }

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

            if (Grid1.DataSourceDS.Tables.Count >= 4)
            {
                if (Grid1.DataSourceDS.Tables[3].Rows.Count == 1)
                {
                    _iRefreshSecond = clsDB.nvlInt(Grid1.DataSourceDS.Tables[3].Rows[0]["RelCode1"]);

                    if (_iRefreshSecond == 0)
                    {
                        _iRefreshSecond = 30;
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
                    workCenter.CarryInQty = clsDB.nvlString(dr["CARRYINQTY"]);
                    _ProdQty = Convert.ToInt32(dr["D_PRODQTY"]);

                    Common.gListWorkCenter.Add(workCenter);

                    GetWorkerList(workCenter);
                    GetOrderList(workCenter);

                    workCenter.ClearHash();
                }

                _bSet = true;
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
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();
                string sDatetime = DateTime.Now.Hour < 8 ? DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");

                if (database.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM TPP1600 A WITH(NOLOCK) WHERE 1 = 1 AND A.PLANTCODE ='" + workCenter.PlantCode + "' AND A.WorkCenterCode ='" + workCenter.Code + "'  AND A.recdate ='" + sDatetime + "' AND A.Status='S' AND A.StopCode IS NULL").ToString() != "0")
                {
                    bBox1.GetButtonByTag("Run").bAlarm = true;
                }
                else
                {
                    bBox1.GetButtonByTag("Run").bAlarm = false;
                }

                sqlCommand = new SqlCommand();
                if (database.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM TPP1620 A WITH(NOLOCK) WHERE 1 = 1 AND A.PLANTCODE ='" + workCenter.PlantCode + "' and A.WorkCenterCode ='" + workCenter.Code + "'  and convert(varchar(10), A.StartDate,120) ='" + sDatetime + "'  and A.EndDate IS NULL").ToString() != "0")
                {
                    bBox1.GetButtonByTag("MNonWork").bAlarm = true;
                }
                else
                {
                    bBox1.GetButtonByTag("MNonWork").bAlarm = false;
                }

                if (database.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM TCM0200 A WITH(NOLOCK) WHERE 1 = 1 AND A.PLANTCODE ='" + Common.gsPlantCode + "' AND A.WORKCENTERCODE ='" + workCenter.Code + "'  AND A.MACHCODE IS NULL AND A.STARTDATE IS NOT NULL").ToString() != "0")
                {
                    bBox1.GetButtonByTag("MachRepair").bAlarm = true;
                }
                else
                {
                    bBox1.GetButtonByTag("MachRepair").bAlarm = false;
                }

                string[] strArr = { "Worker", "Order", "EndWork", "InputProd" };
                foreach (string str in strArr)
                {
                    if (str == workCenter.NextWork)
                    {
                        if (!bBox1.GetButtonByTag(str).bAlarm)
                        {
                            bBox1.GetButtonByTag(str).bAlarm = true;
                        }
                    }
                    else if (bBox1.GetButtonByTag(str).bAlarm)
                    {
                        bBox1.GetButtonByTag(str).bAlarm = false;
                    }
                }

                bBox1.RedrawButtons();
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
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