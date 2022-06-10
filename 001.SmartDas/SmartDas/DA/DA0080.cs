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
    public partial class DA0080 : BaseForm
    {
        #region 멤버변수
        bool bSet = false;

        private int iSelRow;

        private int iSecond = 10;
        private int iTarSecond = 10;

        private DataTable dtItemlist = null;

        public bool bSetWorkCenter
        { set { bSet = value; } }
        #endregion

        public DA0080()
        {
            InitializeComponent();
        }

        private void DA0080_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            SetButtons();

            SetGrid();

            init();     //초기화

            SetLblMessageClear();

            iSelRow = -1;

            EventTimerEnable = true;
        }

        private void SetButtons()
        {
            bBox1.CountX = 7;
            bBox1.CountY = 1;

            bBox1.SetButtons();

            // 지시선택, 작업자, 가동, 불량등록, 작업현황, 가동현황, 투입LOT, 입고등록(부품식별표 발행)
            // , 설비고장, 자주검사, 일상점검, 종료
            bBox1[0, 0].Text = "작업자선택";
            bBox1[0, 0].Tag = "Worker";

            bBox1[0, 1].Text = "가동";
            bBox1[0, 1].Tag = "Run";

            bBox1[0, 2].Text = "설비고장";
            bBox1[0, 2].Tag = "MachErr";
            //bBox1[1, 2].UseFlag = false;

            bBox1[0, 3].Text = "설비보전";
            bBox1[0, 3].Tag = "MachRepair";

            bBox1[0, 4].Text = "현황";
            bBox1[0, 4].Tag = "State";

            bBox1[0, 5].Text = "";
            bBox1[0, 5].Tag = "";
            bBox1[0, 5].UseFlag = false;
            bBox1[0, 6].Text = "";
            bBox1[0, 6].Tag = "";
            bBox1[0, 6].UseFlag = false;

            bBox1.RedrawButtons();


            buttonBox2.CountX = 2;
            buttonBox2.CountY = 1;

            buttonBox2.SetButtons();

            buttonBox2[0, 0].Text = "투입";
            buttonBox2[0, 0].Tag = "Input";

            buttonBox2[0, 1].Text = "작업\n완료";
            buttonBox2[0, 1].Tag = "EndWork";

            //buttonBox2[0, 2].Text = "Lot\n발행";
            //buttonBox2[0, 2].Tag = "prnLot";
            buttonBox2.RedrawButtons();


            //btnStatus.Visible = false;
            //btnStatus.CountX = 1;
            //btnStatus.CountY = 3;

            //btnStatus.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Buttons;
            //btnStatus.SetButtons();

            //btnStatus[0, 0].Tag = "State";
            //btnStatus[0, 0].Text = "작업현황";

            //btnStatus[1, 0].Tag = "RunState";
            //btnStatus[1, 0].Text = "가동현황";

            //btnStatus[2, 0].Tag = "Cancel";
            //btnStatus[2, 0].Text = "취소";

            //btnStatus.RedrawButtons();
        }

        private void SetGrid()
        {
            Grid1.CountRows =7;

            Grid1.SelectProcedureName = "[USP_DA0080_S1]";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
        }

        private void init()
        {
            txtPCName.Text = SystemInformation.ComputerName;

            if (Common.SelectedWorkCenter == null)
            {
                txtWorkCenterCode.Text = "";
                txtWorkCenterName.Text = "";
                txtWorkerCnt.Text = "0";
                txtWorkerNames.Text = "";
            }
            else
            {
                WorkCenter wc = Common.SelectedWorkCenter;

                txtWorkCenterCode.Text = wc.Code;
                txtWorkCenterName.Text = wc.Name;
                //txtItemCode.Text = wc.ItemCode;
                //txtItemName.Text = wc.ItemName;
                txtWorkerNames.Text = wc.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName;
                txtWorkerCnt.Text = wc.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount.ToString();
                //txtOrderNo.Text = wc.ListOrder(Common.ListOrderType.SELECT).AllOrderNo;
                ////txtOrderCnt.Text = wc.ListOrder(Common.ListOrderType.SELECT).OrderCount.ToString();
                
                //txtPlanMoldCode.Text = wc.PlanMoldCode;
                //txtPlanMoldName.Text = wc.PlanMoldName;
                //txtMoldCode.Text = wc.MoldCode;
                //txtMoldName.Text = wc.MoldName;

                //txtPlanQty.Text = string.Format("{0:0,0}", wc.PlanQty);
                //txtLineStatus.Text = wc.LineStatus == "R" ? "가동" : "비가동";
                //txtLastLineDate.Text = wc.LastLineDate;

                //txtCarryInQty.Text = wc.CarryInQty;
            }
        }

        private void SetLblMessageClear()
        {
           // SetMessage("원하는 작업을 선택 하세요.");
        }

        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (bSet && iSecond++ < iTarSecond)
            {
                if (Common.SelectedWorkCenter != null)
                    SetButtonStatus();
                return;
            }

            iSecond = 0;

            this.Cursor = Cursors.Default;

            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }
            
            try
            {
                // sWorkCenterCode 임시저장
                string sWorkCenterCode = string.Empty;
                if (Common.SelectedWorkCenter != null)
                    sWorkCenterCode = Common.SelectedWorkCenter.Code;

                DoFind();

                if (Grid1.Rows.Count == 0)  // 작업장이 설정되지 않았을 경우
                {
                    iSelRow = -1;
                   // Common.SelectedWorkCenter = null;

                    //init();
                }
                else
                {
                    iSelRow = -1;
                    //if ((iSelRow >= Grid1.Rows.Count) || (iSelRow == -1))
                    //{
                    //    iSelRow = 0;

                    //    Grid1.Rows[iSelRow].Selected = true;
                    //    Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                    //}
                    //else
                    //{
                    //    Grid1.Rows[iSelRow].Selected = true;
                    //    Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                    //}
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }

        /// 작업장 정보 조회
        private void DoFind()
        {
            //if (txtOrderNo.Text != "")
            //{
            //    string wDate = "";
            //    if (DateTime.Now.Hour < 8)
            //        wDate = DateTime.Now.AddDays(-1).ToString("yyMMdd");
            //    else
            //        wDate = DateTime.Now.ToString("yyMMdd");

            //    if (txtOrderNo.Text.StartsWith(wDate) == false)
            //    {
            //        SetMessage("작업완료 후 작업지시서를 변경해주십시오!!!");
            //    }
            //}

            Grid1.DoFind();

            if (Grid1.DataSourceDS.Tables.Count >= 3)
            {
                Common.gListWorkCenter.Clear();
                DataRow dr= Grid1.DataSourceDS.Tables[2].Rows[0];
                WorkCenter wc = new WorkCenter();

                wc.PlantCode = clsDB.nvlString(dr["PlantCode"]);
                wc.Code = clsDB.nvlString(dr["WorkCenterCode"]);
                wc.Name = clsDB.nvlString(dr["WorkCenterName"]);
                wc.WorkerCnt = clsDB.nvlInt(dr["WorkerCnt"]);
                wc.LineStatus = clsDB.nvlString(dr["LineStatus"]);
                Common.gListWorkCenter.Add(wc);
                Common.SelectedWorkCenter = wc;
                SetWorkerList(wc);
                wc.ClearHash();
                init();
            }
           // dtItemlist = Grid1.DataSourceDS.Tables[2];

            //if (Grid1.DataSourceDS.Tables.Count >= 4)
            //{
            //    if (Grid1.DataSourceDS.Tables[3].Rows.Count == 1)
            //    {
            //        iTarSecond = clsDB.nvlInt(Grid1.DataSourceDS.Tables[3].Rows[0]["RelCode1"]);

            //        if (iTarSecond == 0)
            //        {
            //            iTarSecond = 30;
            //        }
            //    }
            //}

 


            //if (Grid1.DataSource != null)
            //{
            //    foreach (DataRow dr in Grid1.DataSource.Rows)
            //    {
            //        WorkCenter wc = new WorkCenter();

            //        wc.PlantCode = clsDB.nvlString(dr["PlantCode"]);
            //        wc.Code = clsDB.nvlString(dr["WorkCenterCode"]);
            //        wc.Name = clsDB.nvlString(dr["WorkCenterName"]);

            //        //wc.OrderCnt = clsDB.nvlInt(dr["OrderCnt"]);
            //        wc.WorkerCnt = clsDB.nvlInt(dr["WorkerCnt"]);

            //        //wc.OrderNo = clsDB.nvlString(dr["OrderNo"]);
            //        //wc.ItemCode = clsDB.nvlString(dr["ItemCode"]);
            //        //wc.ItemName = clsDB.nvlString(dr["ItemName"]);
            //        //wc.UnitCode = clsDB.nvlString(dr["UnitCode"]);

            //        //wc.PlanQty = clsDB.nvlDouble(dr["PlanQty"]);
            //        //wc.ProdQty = clsDB.nvlDouble(dr["ProdQty"]);
            //        //wc.ErrorQty = clsDB.nvlDouble(dr["ErrorQty"]);
            //        //wc.PLCProdQty = clsDB.nvlDouble(dr["PLCProdQty"]);
            //        //wc.PLCErrorQty = clsDB.nvlDouble(dr["PLCErrorQty"]);

            //        //wc.LineStatus = clsDB.nvlString(dr["LineStatus"]);
            //        //wc.LastLineDate = clsDB.nvlString(dr["LastLineDate"]);
            //        //wc.NextWork = clsDB.nvlString(dr["NextWork"]);
            //        //wc.MachErrorCnt = clsDB.nvlInt(dr["MachErrorCnt"]);
            //        //wc.MultiOrderNo = clsDB.nvlString(dr["MultiOrderNo"]);
            //        //wc.AutoGathering = clsDB.nvlString(dr["AutoGathering"]);

            //        //wc.PlanMoldCode = clsDB.nvlString(dr["PlanMoldCode"]);
            //        //wc.PlanMoldName = clsDB.nvlString(dr["PlanMoldName"]);
            //        //wc.MoldCode = clsDB.nvlString(dr["MoldCode"]);
            //        //wc.MoldName = clsDB.nvlString(dr["MoldName"]);

            //        //wc.NewOld = clsDB.nvlString(dr["NewOld"]);
            //        //wc.InvalidQty = clsDB.nvlDouble(dr["InvalidQty"]);

            //        //wc.CarryInQty = clsDB.nvlString(dr["CARRYINQTY"]);

            //        Common.gListWorkCenter.Add(wc);

            //        SetWorkerList(wc);
            //      //  SetOrderList(wc);

            //        wc.ClearHash();
            //    }

         //   }
                 bSet = true;
       }

        /// 작업자 정보 조회
        private void SetWorkerList(WorkCenter wc)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA0200_S3";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);


                wc.GetWorkerList(Common.ListWorkerType.SELECT).Clear();

                foreach (DataRow dr in dt.Rows)
                    wc.GetWorkerList(Common.ListWorkerType.SELECT).AddWorker(dr["WORKERID"].ToString(), dr["WORKERNAME"].ToString());
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }
        }

        /// 작업지시 정보 조회
        //private void SetOrderList(WorkCenter wc)
        //{
        //    try
        //    {
        //        Database db = DatabaseFactory.CreateDatabase();
        //        SqlConnection conn = (SqlConnection)db.CreateConnection();
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.CommandText = "USP_DA0100_S3";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
        //        cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));

        //        DataTable dt = new DataTable();

        //        clsDB.gCreateRSet(conn, cmd, dt);

        //        wc.ListOrder(Common.ListOrderType.SELECT).Clear();

        //        foreach (DataRow dr in dt.Rows)
        //            wc.ListOrder(Common.ListOrderType.SELECT).AddOrder(dr["OrderNo"].ToString(), dr["ItemCode"].ToString());
        //    }
        //    catch (Exception e)
        //    {
        //        SetMessage(e.Message);
        //    }
        //}

        // 그리드 클릭 이벤트
        private void Grid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (iSelRow != -1)
                Grid1.Rows[iSelRow].Selected = false;
            iSelRow = e._UltraGridRow.Index;
            Grid1.Rows[iSelRow].Selected = true;
            //WorkCenter wc = Common.getWorkCenter(clsDB.nvlString(e.row.Cells["WorkcenterCode"].Value));

            //Common.SelectedWorkCenter = wc;

            //wc.ClearHash();

            //init();

            SetButtonStatus();
        }

        /// 버튼 상태 변경
        private void SetButtonStatus()
        {
            if (Common.SelectedWorkCenter == null)
                return;

            WorkCenter wc = Common.SelectedWorkCenter;

            try
            {
                #region 가동/비가동 버튼
                // 가동/비가동 버튼 정보 수정
                if (wc.LineStatus != "R")
                {
                    bBox1.GetButtonByTag("Run").Text = "가동";
                  //  bBox1.GetButtonByTag("EndWork").UseFlag = false;
                }
                else
                {
                    bBox1.GetButtonByTag("Run").Text = "비가동";
                   // bBox1.GetButtonByTag("EndWork").UseFlag = true;
                }
                #endregion

                //#region 금형상형/금형하형 버튼
                //// 가동/비가동 버튼 정보 수정
                //if (string.IsNullOrEmpty(wc.MoldCode))
                //{
                //    bBox1.GetButtonByTag("Mold").Text = "금형상형";
                //}
                //else
                //{
                //    bBox1.GetButtonByTag("Mold").Text = "금형하형";
                //}
                //#endregion

                #region 설비 보전
                bBox1.GetButtonByTag("MachRepair").bAlarm = (wc.MachErrorCnt == 0) ? false : true;
                #endregion

                //#region 다음 작업

                //string[] strArr = { "Worker", "Order", "Mold", "Run", "EndWork", "InputProd" };
                //foreach (string str in strArr)
                //{
                //    if (str == wc.NextWork)
                //    {
                //        if (!bBox1.GetButtonByTag(str).bAlarm)
                //            bBox1.GetButtonByTag(str).bAlarm = true;
                //    }
                //    else if (bBox1.GetButtonByTag(str).bAlarm)
                //        bBox1.GetButtonByTag(str).bAlarm = false;
                //}

                //#endregion

                bBox1.RedrawButtons();  
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }

        }

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
                //sStartTime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                MESButton btn = sender;
                WorkCenter wc = Common.SelectedWorkCenter;
                // 제약조건
                switch (btn.Tag.ToString())
                {
                    // 20130506 SJKIM
                    //case "Worker":
                    //    if (wc.LineStatus == "R")
                    //    {
                    //        SetMessage("가동 상태일 때 작업자를 변경할 수 없습니다.");
                    //        return;
                    //    }
                    //    break;
                    //case "Order":   // 지시선택
                    //    if (wc.LineStatus == "R")
                    //    {
                    //        SetMessage("가동 상태일 때 작업지시를 변경할 수 없습니다.");
                    //        return;
                    //    }
                    //    break;
                    //case "Mold":   // 지시선택
                    //    if (wc.LineStatus == "R")
                    //    {
                    //        SetMessage("가동 상태일 때 금형을 변경할 수 없습니다.");
                    //        return;
                    //    }
                    //    break;
                    case "Run": // 가동/비가동
                        if (wc.LineStatus == "S")  // 비가동에서 가동으로 처리될 경우
                        {
                            if (wc.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount == 0)
                            {
                                SetMessage("작업자를 선택하세요.");
                                return;
                            }
                            //if (wc.ListOrder(Common.ListOrderType.SELECT).OrderCount == 0)
                            //{
                            //    SetMessage("작업지시를 선택하세요.");
                            //    return;
                            //}
                            //if (string.IsNullOrEmpty(wc.MoldCode))
                            //{
                            //    SetMessage("금형을 상형하세요.");
                            //    return;
                            //}
                            ////if(wc.MoldCode != wc.PlanMoldCode)
                            //{
                            //    SetMessage("장착된 금형이 작업지시의 금형과 다릅니다..");
                            //    return;
                            //}
                        }
                        break;
                    //case "InputProd":
                    //    if (wc.LineStatus == "S")
                    //    {
                    //        SetMessage("비가동 상태일 때 실적을 등록할 수  없습니다.");
                    //        return;
                    //    }
                    //    break;
                    //case "Error":
                    //    if (wc.LineStatus == "S")
                    //    {
                    //        SetMessage("비가동 상태일 때 불량을 등록할 수 없습니다.");
                    //        return;
                    //    }
                    //    break;
                }

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection con = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                switch (btn.Tag.ToString())
                {
                    case "Worker":  // 작업자
                        DA0200 da0200 = new DA0200();
                        ShowDialogForm(da0200);
                        SetLblMessageClear();

                        SetWorkerList(wc);    //
                        break;

                    //case "Order":   // 지시선택
                    //    DA0120 da0120 = new DA0120();
                    //    ShowDialogForm(da0120);
                    //    SetLblMessageClear();

                    //    SetWorkerList(wc);    //
                    //    break;

                    //case "Mold": //금형상형/하형
                    //    if (string.IsNullOrEmpty(wc.MoldCode))
                    //    {
                    //        //if (string.IsNullOrEmpty(wc.PlanMoldCode))
                    //        {
                    //            DA0700 da0700 = new DA0700();
                    //            da0700.sUseMoldyn = "Y";
                    //            ShowDialogForm(da0700);
                    //            SetLblMessageClear();
                               
                    //            break;
                    //        }
                    //        //else
                    //        //{
                    //        //    cmd.CommandText = "USP_DA0700_I1";
                    //        //    cmd.Parameters.Clear();
                    //        //    cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                    //        //    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                    //        //    cmd.Parameters.Add(new SqlParameter("@pMoldCode", wc.PlanMoldCode));

                    //        //    if (!clsDB.gExecuteProcedure(con, cmd))
                    //        //    {
                    //        //        SetMessage(clsDB.ErrorDesc);
                    //        //        return;
                    //        //    }
                    //        //    break;
                    //        //}
                    //    }
                    //    else
                    //    {
                    //        {
                    //            DA0700 da0700 = new DA0700();
                    //            da0700.sUseMoldyn = "N";
                    //            //da0700.sUseMoldname = txtMoldName.Text.Trim();
                    //            //da0700.sUseMoldcode = txtMoldCode.Text.Trim();
                    //            ShowDialogForm(da0700);
                    //            SetLblMessageClear();
                              
                    //            break;
                    //        }
                    //        //cmd.CommandText = "USP_DA0700_D1";
                    //        //cmd.Parameters.Clear();
                    //        //cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                    //        //cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                    //        //cmd.Parameters.Add(new SqlParameter("@pMoldCode", wc.PlanMoldCode));

                    //        //if (!clsDB.gExecuteProcedure(con, cmd))
                    //        //{
                    //        //    SetMessage(clsDB.ErrorDesc);
                    //        //    return;
                    //        //}
                    //        //break;
                    //    }

                    case "Run": // 가동/비가동
                        string sStatus = wc.LineStatus == "S" ? "R" : "S";
                        string sStopCode = "";

                        if (sStatus == "S")
                        {
                            // 비가동일 경우
                            DA0800 da0800 = new DA0800();
                            if (DialogResult.OK != ShowDialogForm(da0800))
                                return;

                            sStopCode = da0800.sStopCode;
                        }

                        cmd.CommandText = "USP_DA0000_RunStop";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@pStopCode", sStopCode));
                        cmd.Parameters.Add(new SqlParameter("@pStatus", sStatus));

                        if (clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        break;

                    case "EndWork":
                       // 

                        //if (MessageBoxShow("C:Q00015", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                        //    return;

                        //string sRemainQty = string.Empty;

                        //DA9600 da9600 = new DA9600();
                        //da9600.sRemainQty = Common.SelectedWorkCenter.PLCProdQty.ToString();
                        //if (DialogResult.OK == ShowDialogForm(da9600))
                        //{
                        //    sRemainQty = da9600.sRemainQty;
                        //}
                        //else
                        //    return;
                        if (iSelRow == -1)
                        {
                            SetMessage("작업완료할  LotNo를 선택하십시오.");
                            return;
                        }
                        //if (Grid1.Rows[iSelRow].GetCellValue("LotNO_Out").ToString() != "")
                        //{
                        //    SetMessage("이미 등록된 LotNo입니다.");
                        //    return;
                        //}
                       // string lotno = Grid1.Rows[iSelRow].GetCellValue("LotNO_In").ToString();
                        string lotno = Grid1.Rows[iSelRow].GetCellValue("SeqID").ToString();
                        cmd.CommandText = "USP_DA0080_I3";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@SeqID", Convert.ToInt32(lotno)));
 

                        if (!clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            try
                            {
                                string sql = "SELECT  LotNO_Out  from TPP0800 (NOLOCK) WHERE SeqID ='" + lotno + "'";
                                lotno = db.ExecuteScalar(CommandType.Text, sql).ToString();
                                DA0500 da0500 = new DA0500();
                                da0500.HamLabelPrint(lotno);
                            }
                            catch { }
                            DoFind();
                            SetLblMessageClear();
                         }
                        break;

                    case "State":   //현황
                    DA2100 da2100 = new DA2100();
                    ShowDialogForm(da2100);
                    SetLblMessageClear();
                        break;

                    case "Input":     // 투입 

                        if (lbItemNm.Text == "" || txtLotNo.Text == "" || txtQty.Text == "" || txtQty.Text == "0")
                        {
                            SetMessage("등록할수 없는 정보입니다.");
                            return;
                        }


                        cmd.CommandText = "USP_DA0080_I1";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@LotNo", txtLotNo.Text));
                        cmd.Parameters.Add(new SqlParameter("@ProdQTY", txtQty.Text.Replace(",","")));

                        //[USP_DA8000_I1 작지생성
                        if (!clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            txtLotNo.Text = "";
                            lbItemNm.Text = "";
                            lbCarKind.Text = "";
                            txtQty.Text = "";
                            Grid1.DoFind(); 
                            SetLblMessageClear();
                        }
                       break;

                    case "MachErr": // 설비 고장
                        if (ShowDialogForm(new MessageForm("설비 긴급 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                            return;

                        cmd.CommandText = "SP_SEND_EQUIPMENT_MAINT_SMS";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@PLANTCODE", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@WORKCENTERCODE", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@NAME", wc.Name));

                        if (!clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            ShowDialogForm(new MessageForm("정상적으로 문자가 발송되었습니다.", MessageBoxButtons.OK, "SMS 발송확인"));
                            SetLblMessageClear();
                        }
                        break;

                    case "MachRepair":  // 설비 고장

                        DA1000 da1000 = new DA1000();
                        ShowDialogForm(da1000);
                        SetLblMessageClear();
                        break;

                    case "prnLot":
                        if (iSelRow == -1)
                            return;
                        string lotno1= Grid1.Rows[iSelRow].GetCellValue("LotNO_Out").ToString();
                        DA0500 da05001 = new DA0500();
                        da05001.HamLabelPrint(lotno1);
                         SetLblMessageClear();
                        break;

                    case "Check":
                        DA1110 da1110 = new DA1110();
                        ShowDialogForm(da1110);
                        SetLblMessageClear();
                        break;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                iSecond = iTarSecond;
                EventTimer_Tick(this, new EventArgs());
            }
        }
        private void prnLotCard()
        {

            }
        /// 팝업 버튼 이벤트 설정
        //private void btnStatus_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        //{
        //    switch (sender.Tag.ToString())
        //    {
        //        case "State":
        //            // 작업현황
        //            DA2100 da2100 = new DA2100();
        //            ShowDialogForm(da2100);
        //            SetLblMessageClear();
        //            break;
        //        case "RunState":
        //            // 가동현황
        //            DA2200 da2200 = new DA2200();
        //            ShowDialogForm(da2200);
        //            SetLblMessageClear();
        //            break;
        //        case "Cancel":
        //            //취소
        //            break;
        //    }

        //    //btnStatus.Visible = false;
        //}

        // 단말기 설정 메뉴에서 알림으로 임시 이동
        private void lblMes_Click(object sender, EventArgs e)
        {
            DA9000 DA9000 = new DA9000();
            DA9000.Owner = this;
            ShowDialogForm(DA9000);

            iSecond = iTarSecond;
            EventTimer_Tick(this, new EventArgs());

            SetLblMessageClear();
        }

        private void DA0080_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLotNo_Click(object sender, EventArgs e)
        {
            DA9200 d = new DA9200();
            d.ContentText = txtLotNo.Text.Trim();

            if (DialogResult.OK == ShowDialogForm(d))
            {
                textBox1.Text = d.resultString;
                txtLotNo.Text = d.resultString;

                textBox1_KeyPress(textBox1, new KeyPressEventArgs((char)Keys.Enter));
            }
 
        }

        private void DA0080_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
 
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (textBox1.Text.Length == 17)
            if (e.KeyChar == 13 || textBox1.Text.Length == 17)
            {
                if (textBox1.Text == "" || textBox1.Text.Length < 10 )
                    return;
                SetMessage("");
                txtLotNo.Text = textBox1.Text;
                if (txtLotNo.Text.Substring(6, 4) == "5101") 
                {
                    lbItemNm.Text = "";
                    lbCarKind.Text = "";
                    txtQty.Text = "";
                    textBox1.Text = "";
                    SetMessage("함침 완료 LotNo입니다.");
                    return;
                }
                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

               string  sSQL = "USP_DA0081_S1";
               SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand(sSQL);
                cmd.Connection = conn;

                cmd.CommandType = CommandType.StoredProcedure;//.Text;

                cmd.CommandText = sSQL;
                cmd.Parameters.Add(new SqlParameter("@pLotNo", txtLotNo.Text));

                string sql = "SELECT *,dbo.FN_ItemName(ItemCode,PlantCode) ItemNm ,(select TOP 1 CarType FROM TBM0100 a (NOLOCK) WHERE a.ItemCode = b.ItemCode) as CarType  from TPP0100 (NOLOCK) b where LotNO ='" + txtLotNo.Text + "'";
                //DataTable tbLot = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];
                DataTable tbLot = db.ExecuteDataSet(cmd).Tables[0];
                if (tbLot.Rows.Count == 1)
                {

                    string[] aitems = tbLot.Rows[0]["ItemCode"].ToString().Split('-');
                    string itdiv = aitems[aitems.Length - 1].Trim();
                   // if (itdiv == "81" || itdiv == "30" || itdiv == "31")
                    {
                        lbItemNm.Text = tbLot.Rows[0]["ItemNm"].ToString();
                        lbCarKind.Text = tbLot.Rows[0]["CarType"].ToString();
                        int qty=Convert.ToInt32(tbLot.Rows[0]["ProdQTY"]);


                        sql = "SELECT sum(InQty) OutQty from TPP0800 (NOLOCK) where LotNO_In ='" + txtLotNo.Text + "'";
                        tbLot = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];
                        qty -= Convert.ToInt32(tbLot.Rows[0]["OutQty"].GetType().Name == "DBNull" ? 0 : tbLot.Rows[0]["OutQty"]);
                        if (qty <= 0)
                       // if (tbLot.Rows[0]["OutQty"].ToString() != "0")
                        {
                            lbItemNm.Text = "";
                            lbCarKind.Text = "";
                            txtQty.Text = "";

                            SetMessage("이미 등록 완료된 LotNo입니다.");
                        }
                        else
                           txtQty.Text = string.Format("{0:N0}", qty);


                    }
                    //else
                    //{
                    //    lbItemNm.Text = "";
                    //    lbCarKind.Text = "";
                    //    txtQty.Text = "";
                    //    SetMessage("등록할수 없는 품목입니다.");
 
                    //}
                }
                textBox1.Text = "";

                
            }
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "생산수량 입력";
            d.LabelHeader = "생산수량";

            if (DialogResult.OK == ShowDialogForm(d))
            {
                if (clsDB.nvlInt(txtQty.Text) < clsDB.nvlInt(d.ResultString) )
                {
                    SetMessage(txtQty.Text+"를 초과할수 없습니다");
 
                }
                else  
                {
                    txtQty.Text=string.Format("{0:N0}", clsDB.nvlInt(d.ResultString));
                }
            }
        }

    }
}
