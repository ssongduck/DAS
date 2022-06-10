using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDas.Components;
using SmartDas.POPUP;
using Infragistics.Win.UltraWinGrid;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SmartDas
{
    public partial class DA0500 : SmartDas.Components.BaseForm
    {
        private int itmr_Count = 0;
        private int itmr_Target = 5;
        public string autoLot = "";
        private int[] aStQty = new int[3] { 0, 0, 0 };
        private string sSQItemcode = "";
        private bool bSuccess = false;
        private int lotPrnCnt = 2;

        WorkCenter wc = Common.SelectedWorkCenter;

        private Configuration appConfig;

        public DA0500()
        {
            InitializeComponent();
            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();
            DataRow dr = db.ExecuteDataSet(CommandType.Text, "SELECT LotPrnCnt   FROM TBM0600 	 WHERE WorkCenterCode  ='" + Common.SelectedWorkCenter.Code + "'").Tables[0].Rows[0];
            lotPrnCnt = Convert.ToInt32(dr["LotPrnCnt"]);
        }

        private void DA0500_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();

            DoFind();

            if (autoLot == "")
            {

                tmr_Refresh.Enabled = true;
                tmr_Refresh.Start();
                //if (clsDB.sqlConn.ConnectionString.IndexOf("50.2") != -1) //삼기
                //{
                //    if (Common.SelectedWorkCenter.Code.StartsWith("460")) //v-body
                //    {
                //        //  txtBoxCap.Text = "10";
                //    }
                //    else if (Common.SelectedWorkCenter.Code.StartsWith("4204")) // 세타연료펌프 브라킷 아답터
                //    {
                //       // txtBoxCap.Text = "20";
                //    }
                //    else if (Common.SelectedWorkCenter.Code.StartsWith("4306")) // 타우 타이밍 체인커버
                //    {
                //       // txtBoxCap.Text = "5";
                //    }
                //}
            }
            else  ///자동 lot 발행
            {
                txtTotalQty.Text = autoLot;
                if (clsDB.nvlInt(txtBoxCap.Text) > 0 && txtTotalQty.Text != "")
                {
                    txtBoxQty.Text = Math.Ceiling(Convert.ToDecimal(txtTotalQty.Text) / Convert.ToDecimal(txtBoxCap.Text)).ToString();
                }
                else if (txtBoxCap.Text == "" || txtBoxCap.Text == "0")
                {
                    //if ( clsDB.sqlConn.ConnectionString.IndexOf("50.2") != -1 && Common.SelectedWorkCenter.Code.StartsWith("460")) //v-body
                    //{
                    //    txtBoxCap.Text = "10";
                    //}
                    //else if (clsDB.sqlConn.ConnectionString.IndexOf("50.2") != -1 && Common.SelectedWorkCenter.Code.StartsWith("4204")) // 
                    //{
                    //     txtBoxCap.Text = "20";
                    //}
                    //else if (clsDB.sqlConn.ConnectionString.IndexOf("50.2") != -1 && Common.SelectedWorkCenter.Code.StartsWith("4306")) // 
                    //{
                    //     txtBoxCap.Text = "5";
                    //}
                    //else
                    {
                        txtBoxCap.Text = txtTotalQty.Text;
                        txtBoxQty.Text = "1";
                    }

                }
                int irt = CheckNetwork();
                _bUseNetwork = (irt == 1 || irt == 2 ? true : false);
                DoSave();
                if (bSuccess)
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;   //20130506
                else
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;   //20130506
                // ClosePrgForm();
            }
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;



            if (mesGrid1.Row == null)
            {
                txtOrderNo.Text = "";
                txtPlanQty.Text = "";
                txtItemCode.Text = "";
                txtItemName.Text = "";

                txtProdQty.Text = "";
                txtRemainQty.Text = "";
                txtPLCProdQty.Text = "";
                txtEnableQty.Text = "";

                txtTotalQty.Text = "";
                txtBoxCap.Text = "";
                txtBoxQty.Text = "";
            }
            else
            {


                int iPlanQty = clsDB.nvlInt(mesGrid1.Row.Cells["PlanQty"].Value);
                int iProdQty = clsDB.nvlInt(mesGrid1.Row.Cells["ProdQty"].Value);
                int iPLCAccuQty = clsDB.nvlInt(mesGrid1.Row.Cells["PLCAccuQty"].Value);
                int iPLCProdQty = clsDB.nvlInt(mesGrid1.Row.Cells["PLCProdQty"].Value);
                int iRemainQty = iPlanQty - iProdQty;

                txtItemCode.Text = clsDB.nvlString(mesGrid1.Row.Cells["ItemCode"].Value);
                if (sSQItemcode != txtItemCode.Text)
                    txtItemName.Text = clsDB.nvlString(mesGrid1.Row.Cells["ItemName"].Value);
                txtOrderNo.Text = clsDB.nvlString(mesGrid1.Row.Cells["OrderNo"].Value);
                txtPlanQty.Text = iPlanQty.ToString();
                txtProdQty.Text = iProdQty.ToString();
                txtPLCProdQty.Text = iPLCAccuQty.ToString();
                txtRemainQty.Text = iPLCProdQty.ToString();
                txtEnableQty.Text = clsDB.nvlString(iPLCProdQty < iRemainQty ? iPLCProdQty : iRemainQty);

                setStQty();

            }
        }
        /// <summary>
        ///    용기적입량 , txtBoxCap =0 이면 직접입력가능 ,  sqty2와 stqty3이 0 이면 stqty1로 고정 , 아니면 선택
        /// </summary>
        private void setStQty()
        {
            try
            {
                if (sSQItemcode != txtItemCode.Text)
                {
                    sSQItemcode = txtItemCode.Text;
                    Database db;
                    db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();
                    DataRow dr = db.ExecuteDataSet(CommandType.Text, "SELECT StQty1,StQty2,StQty3,cartype  FROM TBM0100 	 WHERE itemcode  ='" + txtItemCode.Text + "'").Tables[0].Rows[0];
                    aStQty[0] = Convert.ToInt32(dr["stqty1"]);
                    aStQty[1] = Convert.ToInt32(dr["stqty2"]);
                    aStQty[2] = Convert.ToInt32(dr["stqty3"]);
                    btnstqty1.Text = aStQty[0].ToString();
                    btnstqty2.Text = aStQty[1].ToString();
                    btnstqty3.Text = aStQty[2].ToString();
                    txtBoxCap.Text = aStQty[0].ToString();
                    txtItemName.Text = "[" + dr["cartype"] + "]" + txtItemName.Text;

                }
            }
            catch { }
        }
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            //btnConfBox[0, 0].Text = "재발행";
            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "지시";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 4;

            // Grid - width = 1000, 헤더 Width 총합 997
            if (Common.gsDASDivision == "C")     // 주조
                mesGrid1.SelectProcedureName = "USP_DA0510_S1";
            else
                mesGrid1.SelectProcedureName = "USP_DA0500_S1";

            mesGrid2.FontSize = 14;
            mesGrid2.CountRows = 7;

            //// Grid - width = 1000, 헤더 Width 총합 997
            //if (Common.gsDASDivision == "C")     // 주조
            //    mesGrid2.SelectProcedureName = "USP_DA0500_S2";
            //else
            //    mesGrid2.SelectProcedureName = "USP_DA0500_S2";

            mesGrid2.SelectProcedureName = "USP_DA0500_S2";
        }

        private void DoFind()
        {
            int iRowIndex = 0;
            if (mesGrid1.Rows.Count != 0 && mesGrid1.Row != null)
                iRowIndex = mesGrid1.Row.Index;

            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();

            if (mesGrid1.Rows.Count < 1)
            {
                return;
            }
            if (mesGrid1.Rows.Count == 1)
            {
                mesGrid1.Rows[0].Selected = true;
                mesGrid1.Row = mesGrid1.Rows[0];
                mesGrid1_GridClick(mesGrid1, new MESGrid.GridClickEventArg(mesGrid1.Rows[0].Cells[0]));
            }
            else if (iRowIndex < mesGrid1.Rows.Count)
            {
                mesGrid1.Rows[iRowIndex].Selected = true;
                mesGrid1.Row = mesGrid1.Rows[iRowIndex];
                mesGrid1_GridClick(mesGrid1, new MESGrid.GridClickEventArg(mesGrid1.Rows[iRowIndex].Cells[0]));
            }

            //Init();
        }
        bool bconti = false;

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "재발행":
                        DA0520 da0520 = new DA0520();
                        ShowDialogForm(da0520);
                        break;
                    case "등록":
                        //DoProgress();
                        if (bconti)
                            return;
                        bconti = true;

                        DoSave();
                        if (bSuccess)
                        {
                            DA9610 da9610 = new DA9610();
                            ShowDialogForm(da9610);
                            txtTotalQty.Text = "0";
                            if (mesGrid2.Visible)
                                mesGrid2.DoFind();
                            else
                                DoFind();
                        }
                        bconti = false;
                        //ClosePrgForm();
                        //this.DialogResult = System.Windows.Forms.DialogResult.Cancel;   //20130506
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
                sender.Enabled = true;
            }
        }

        private void DoSave()
        {
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            DoProgress();
            try
            {

                if (txtOrderNo.Text != "")
                {
                    int iValue = clsDB.nvlInt(txtBoxCap.Text);
                    int iCount = clsDB.nvlInt(txtBoxQty.Text);
                    int iTotal = clsDB.nvlInt(txtTotalQty.Text);

                    //int iMaxQty = iPlanQty + (int)(iPlanQty * Common.dOverRate / 100);

                    int iSum = iValue * iCount;

                    if (iTotal == 0 || iCount == 0 || iValue == 0)
                    {
                        SetMessage("C:R00120");
                        return;
                    }

                    DataTable dt = new DataTable();

                    Database db;
                    db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    //if (clsDB.sqlConn.ConnectionString.IndexOf("60.2") != -1)
                    //{
                    //    if (autoLot == "" && iTotal % iValue != 0)
                    //    {
                    //        SetMessage("생산수량은 용기적입량 배수여야합니다.");
                    //        return;

                    //    }
                    //}


                    //if (autoLot == "" &&  iTotal % iValue != 0 &&  Convert.ToInt32(db.ExecuteScalar(CommandType.Text, "SELECT count(*)  FROM TPP0100 WHERE orderno  ='" + txtOrderNo.Text + "'")) > 2)
                    //{
                    //    SetMessage("생산수량은 용기적입량 배수여야합니다.");
                    //    return;

                    //}



                    SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0500_I0");
                    cmd.Connection = conn;

                    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                    cmd.Parameters.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text));
                    cmd.Parameters.Add(new SqlParameter("@pQty", txtTotalQty.Text));

                    if (!clsDB.gExecuteProcedure(conn, cmd))
                    {
                        SetMessage(clsDB.ErrorDesc);
                        return;
                    }


                    if (Common.gsDASDivision == "C")     // 주조
                        cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0510_I1");
                    else
                        cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0500_I1");

                    //int shCnt = 4; //v_body용
                    //if (clsDB.sqlConn.ConnectionString.IndexOf("50.2") != -1 && Common.SelectedWorkCenter.Code == "4603") // v_body아웃
                    //    shCnt = 3;
                    //int iboxcap = Convert.ToInt32(txtBoxCap.Text);
                    //if (iboxcap > 100)
                    //{
                    //    shCnt = 1;
                    //}
                    int shCnt = lotPrnCnt; //v_body용
                    int iboxcap = Convert.ToInt32(txtBoxCap.Text);
                    if (iboxcap > 100 || shCnt < 3)
                    {
                        shCnt = 1;
                    }


                    int shCnt0 = 0;

                    cmd.Connection = conn;

                    for (int i = 0; i < iCount; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        cmd.Parameters.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text));
                        cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@pQty", (i < iCount - 1 ? iboxcap : iTotal)));
                        cmd.Parameters.Add(new SqlParameter("@AutoGathering", Common.SelectedWorkCenter.AutoGathering));

                        if (clsDB.gExecuteProcedure(conn, cmd))
                        {
                            SetMessage("정상적으로 등록되었습니다.");

                            // 정상 처리
                            // 추가 작업 필요시 아래에 기술

                            //sGroupKey = clsDB.nvlString(cmd.Parameters["@pGroupKey"].Value);

                            //주조 LOT 발행 - 차승영 
                            if (Common.SelectedWorkCenter.Code.Substring(0, 1).Equals("2"))
                            {
                                DCLabelPrint(i < iCount - 1 ? iboxcap : iTotal);
                            }
                            // else if (Common.SelectedWorkCenter.Code.StartsWith("460") == true || Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306")//V/BODY 
                            else if (Common.gsPlantCode == "SK1" && lotPrnCnt > 2) // (Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306"))
                            {
                                ++shCnt0;
                                if (shCnt0 == shCnt || i == iCount - 1)
                                {
                                    VBLabelPrint(Common.SelectedWorkCenter.Code, shCnt0, "");
                                    shCnt0 = 0;
                                }

                            }
                            //가공 LOT 발행 - 차승영
                            else if (Common.SelectedWorkCenter.Code.Substring(0, 1).Equals("4"))
                            {
                                PSLabelPrint(i < iCount - 1 ? iboxcap : iTotal);
                            }


                        }
                        else
                        {
                            SetMessage(clsDB.ErrorDesc);
                            // DoFind();
                            return;
                        }

                        iTotal -= iboxcap;
                    }

                    //int iRemind = iTotal - (iValue * iCount);

                    //if (iRemind > 0)
                    //{
                    //    cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0500_I1");
                    //    cmd.Connection = conn;

                    //    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                    //    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                    //    cmd.Parameters.Add(new SqlParameter("@pOrderNo", sOrderNo));
                    //    cmd.Parameters.Add(new SqlParameter("@pItemCode", txtSelItemCode.Text));
                    //    cmd.Parameters.Add(new SqlParameter("@pQty", iRemind.ToString()));

                    //    //cmd.Parameters.Add(new SqlParameter("@pWorkerNM", Common.SelectedWorkCenter.ListWorker(Common.ListWorkerType.SELECT).AllWorkerName));

                    //    //cmd.Parameters["@pGroupKey"].Direction = ParameterDirection.InputOutput;
                    //    //cmd.Parameters["@pGroupKey"].Value = sGroupKey;

                    //    if (clsDB.gExecuteProcedure(conn, cmd))
                    //    {
                    //        // 정상 처리
                    //        // 추가 작업 필요시 아래에 기술
                    //        //sGroupKey = clsDB.nvlString(cmd.Parameters["@pGroupKey"].Value);
                    //    }
                    //    else
                    //    {
                    //        SetMessage(clsDB.ErrorDesc);
                    //        DoFind();
                    //        return;
                    //    }
                    //}

                    txtTotalQty.Text = "0";// (iTotal - (iValue * iCount)).ToString();
                    txtBoxCap.Text = "";
                    txtBoxQty.Text = "0";
                    bSuccess = true;

                    SetMessage("C:R00124");

                    //  this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    SetMessage("작업지시를 선택하세요.");//C:R00125");
                }
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
                return;
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (btnSelect.GetSelectedButtons().Count != 0)
            {
                //DoProgress();
                switch (btnSelect.GetSelectedButtons()[0].Text)
                {
                    case "지시":
                        mesGrid1.Left = 0;//iLeft1;
                        mesGrid1.Width = 1014;// itWidth;

                        mesGrid1.Visible = true;
                        mesGrid2.Visible = false;

                        btnLeftPage.LinkGrid = mesGrid1;
                        btnRightPage.LinkGrid = mesGrid1;
                        btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                        btnRightPage.LinkMoveSize = mesGrid1.CountRows;
                        break;
                    case "실적":
                        mesGrid2.Left = 0;//iLeft1;
                        mesGrid2.Width = 1014;//itWidth;

                        mesGrid1.Visible = false;
                        mesGrid2.Visible = true;

                        btnLeftPage.LinkGrid = mesGrid2;
                        btnRightPage.LinkGrid = mesGrid2;
                        btnLeftPage.LinkMoveSize = mesGrid2.CountRows;
                        btnRightPage.LinkMoveSize = mesGrid2.CountRows;

                        mesGrid2.GetStoreProcedure();
                        // 조회
                        mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                        mesGrid2.ParameterList.Add(new SqlParameter("@pOrderNo", txtOrderNo.Text));

                        mesGrid2.DoFind();


                        break;
                }
                //ClosePrgForm();
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            Init();
            if (e._UltraGridColumn.ToString() == "ItemCode")
            {
                DA9520 da9520 = new DA9520();
                da9520.bOrderNo = e._UltraGridRow.Cells["OrderNo"].Value.ToString();
                ShowDialogForm(da9520);
            }
        }

        private void txtTotalQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "생산수량 입력";
            d.LabelHeader = "생산수량";

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtTotalQty.Text = d.ResultString;

                if (clsDB.nvlInt(txtBoxCap.Text) > 0 && txtTotalQty.Text != "")
                {
                    if (autoLot == "" && clsDB.nvlInt(txtBoxCap.Text) < clsDB.nvlInt(txtTotalQty.Text))
                    {
                        if (Common.gsPlantCode == "SK1" && Common.SelectedWorkCenter.Code.StartsWith("460") == false && Common.SelectedWorkCenter.Code != "4204" && Common.SelectedWorkCenter.Code != "4306")
                        {
                            txtTotalQty.Text = "";
                            SetMessage("적입량보다 큰 수량은 사용할수 없습니다.");
                        }
                        else
                            txtBoxQty.Text = Math.Ceiling(Convert.ToDecimal(txtTotalQty.Text) / Convert.ToDecimal(txtBoxCap.Text)).ToString();
                    }
                    else
                        txtBoxQty.Text = Math.Ceiling(Convert.ToDecimal(txtTotalQty.Text) / Convert.ToDecimal(txtBoxCap.Text)).ToString();
                }
                else if (txtBoxCap.Text == "" || txtBoxCap.Text == "0")
                {
                    txtBoxCap.Text = txtTotalQty.Text;
                    txtBoxQty.Text = "1";
                }
            }
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            // stqty1 만 0아니면 고정
            if (aStQty[0] != 0 && aStQty[1] == 0 && aStQty[2] == 0)
                return;

            if (txtBoxCap.Text == "0" || (aStQty[0] == 0 && aStQty[1] == 0 && aStQty[2] == 0))
            {
                DA9100 d = new DA9100();
                d.LabelTitle = "용기적입량 입력";
                d.LabelHeader = "용기적입량";

                if (DialogResult.OK == ShowDialogForm(d))
                {
                    txtBoxCap.Text = d.ResultString;

                    if (clsDB.nvlInt(txtBoxCap.Text) > 0 && txtTotalQty.Text != "")
                    {
                        txtBoxQty.Text = Math.Ceiling(Convert.ToDecimal(txtTotalQty.Text) / Convert.ToDecimal(txtBoxCap.Text)).ToString();
                        //txtTotalQty.Text = (clsDB.nvlInt(txtBoxQty.Text) * clsDB.nvlInt(txtBoxCap.Text)).ToString();
                    }
                }
            }
            else
            {
                pnl_Select.Visible = true;
            }
        }

        private void btnstqty_Click(object sender, EventArgs e)
        {
            pnl_Select.Visible = false;
            txtBoxCap.Text = ((Button)sender).Text;
            if (clsDB.nvlInt(txtBoxCap.Text) > 0 && txtTotalQty.Text != "")
            {
                txtBoxQty.Text = Math.Ceiling(Convert.ToDecimal(txtTotalQty.Text) / Convert.ToDecimal(txtBoxCap.Text)).ToString();
            }


        }

        private void tmr_Refresh_Tick(object sender, EventArgs e)
        {
            itmr_Count += 1;

            if (itmr_Count >= itmr_Target)
            {
                itmr_Count = 0;

                //  DoFind();
            }
        }

        private void DA0500_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr_Refresh.Stop();
            tmr_Refresh.Enabled = false;
            tmr_Refresh.Dispose();
        }

        #region [Lot 발행 - 주조]
        private void DCLabelPrint(int qty)
        {
            try
            {
                LabelPrint lp = new LabelPrint(false);

                string Worker = string.Empty;
                string LotNo = string.Empty;
                string MoldName = string.Empty;
                string CarType = string.Empty;
                string CarTypeName = string.Empty;
                string CenterName = string.Empty;
                string CostCenter2 = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;
                string SItemCode = string.Empty;
                string SItemName = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //현재 작업자명 로드
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
                                                                      + " FROM TBM2400 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
                //Lot No 로드
                DataTable tbLotNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 A.LotNo, isnull(B.MoldName,'')  MoldName"
                                                                    + " FROM TPP0100 A"
                                                                     + " LEFT OUTER JOIN TBM1600 B "
                                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                    + " WHERE A.WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'"
                                                                    + " Order by A.MakeDate DESC").Tables[0];
                //형번 txtOrderNo.Text
                //DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                //                                                    + " FROM TAP0100 A "
                //                                                    + " LEFT OUTER JOIN TBM1600 B "
                //                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                //                                                    + " WHERE PlanNO = '" + txtOrderNo.Text + "'").Tables[0];
                //차종 
                DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType,ItemName "
                                                                    + " FROM TBM0100 A "
                                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];


                DataTable tbCarTypeName = new DataTable();
                DataTable tbCostCenter2 = new DataTable();

                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];
                }
                else
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];
                }

                //현재 작업장명 로드
                DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                      + " FROM TBM0600 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];


                //사상 품번, 품명
                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ItemCode, ItemName "
                                                                    + " FROM TBM0100 A "
                                                                    + " WHERE ItemCode LIKE '" + txtItemCode.Text.Trim().Substring(0, (txtItemCode.Text.Trim().Length - 2)) + "3'" + " + '%'"
                                                                    + " AND ItemCode <> '" + txtItemCode.Text + "'").Tables[0];

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT LotSno from TPP0100 where LotNO = (SELECT max(LotNo) as LotNo from TPP0100 where WorkCenterCode ='" + Common.SelectedWorkCenter.Code + "' and orderNo='" + txtOrderNo.Text + "')").Tables[0];


                //LotCnt
                if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 20)
                {
                    Shift = "주간 ";
                    Shift2 = "A - ";
                    if (tbLot.Rows.Count > 0)
                        LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                   + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                   + " AND MakeDate BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 08:00:00" + "'"
                    //                                                   + " AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 20:00:00" + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{
                    //    //LotCnt = tbLotCnt.Rows[0][0].ToString();
                    //    LotCnt = "A - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                else
                {
                    Shift = "야간 ";
                    Shift2 = "B - ";
                    if (tbLot.Rows.Count > 0)
                        LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();

                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                  + " AND MakeDate BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 20:00:01" + "'"
                    //                                                  + " AND '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + " 07:59:59" + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{

                    //    LotCnt = "B - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                if (tbLotNo.Rows.Count > 0)
                {
                    LotNo = tbLotNo.Rows[0][0].ToString();
                    MoldName = tbLotNo.Rows[0][1].ToString();
                }

                //if (tbMoldNo.Rows.Count > 0)
                //{
                //    MoldName = tbMoldNo.Rows[0][0].ToString();
                //}
                string itemNm = "";

                if (tbCarType.Rows.Count > 0)
                {
                    CarType = tbCarType.Rows[0][0].ToString();
                    itemNm = tbCarType.Rows[0][1].ToString();
                }

                if (tbCarTypeName.Rows.Count > 0)
                {
                    CarTypeName = tbCarTypeName.Rows[0][0].ToString();
                }

                if (tbCostCenter2.Rows.Count > 0)
                {
                    CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
                }

                if (tbCenterName.Rows.Count > 0)
                {
                    CenterName = tbCenterName.Rows[0][0].ToString();
                }
                // 제품군 -> 작업장으로 변경 (2016.10.11)

                if (tbSItemCode.Rows.Count > 0)
                {
                    SItemCode = tbSItemCode.Rows[0][0].ToString();
                    SItemName = tbSItemCode.Rows[0][1].ToString();
                }
                else if (tbSItemCode.Rows.Count == 0)
                {
                    SItemCode = txtItemCode.Text;
                    SItemName = txtItemName.Text;
                }

                bar2Code.Text = LotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                //string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text, txtItemName.Text, "주조", txtBoxCap.Text + " EA", "", Shift + txtBoxCap.Text + " EA", "", Shift2 + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text };
                string[] vals = new string[] { LotNo, CarTypeName, MoldName, txtItemCode.Text.Trim(), itemNm, "주조", qty.ToString() + " EA", "", Shift + txtBoxCap.Text + " EA", "", CenterName, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, "사상", txtOrderNo.Text, SItemCode, SItemName, wc.PlantCode };

                //string[] vals = new string[] { "LotNo", "차종", "형번", txtItemCode.Text, txtItemName.Text, "완제품", txtBoxCap.Text, "B-#1", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "12345678901234567890asdfg" };
                lp.print("주조", vals, false);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #region [Lot 발행 - 가공]
        private void PSLabelPrint(int qty)
        {
            try
            {
                LabelPrint lp = new LabelPrint(false);

                string Worker = string.Empty;
                string LotNo = string.Empty;
                string MoldName = string.Empty;
                string ItemName = string.Empty;
                string CarType = string.Empty;
                string CarTypeName = string.Empty;
                string CostCenter2 = string.Empty;
                string CenterName = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //현재 작업자명 로드
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
                                                                      + " FROM TBM2400 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
                //Lot No 로드
                DataTable tbLotNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 LotNo "
                                                                    + " FROM TPP0100 "
                                                                    + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'"
                                                                    + " Order by MakeDate DESC").Tables[0];

                DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                                                                    + " FROM TBM0100 A "
                                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];

                //품명
                DataTable tbItemName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ITEMNAME "
                                                                    + " FROM TBM0100 "
                                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];


                DataTable tbCarTypeName = new DataTable();
                DataTable tbCostCenter2 = new DataTable();

                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {

                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];
                }
                else
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + txtItemCode.Text + "'").Tables[0];
                }

                //현재 작업장명 로드
                DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                      + " FROM TBM0600 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT LotSno from TPP0100 where LotNO = (SELECT max(LotNo) as LotNo from TPP0100 where WorkCenterCode ='" + Common.SelectedWorkCenter.Code + "' and orderNo='" + txtOrderNo.Text + "')").Tables[0];


                //LotCnt
                if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 20)
                {
                    Shift = "주간";
                    Shift2 = "A - ";
                    if (tbLot.Rows.Count > 0)
                        LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                   + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                   + " AND MakeDate BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 08:00:00" + "'"
                    //                                                   + " AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 20:00:00" + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{
                    //    //LotCnt = tbLotCnt.Rows[0][0].ToString();
                    //    LotCnt = "A - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                else
                {
                    Shift = "야간";
                    Shift2 = "B - ";
                    if (tbLot.Rows.Count > 0)
                        LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                  + " AND MakeDate BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 20:00:01" + "'"
                    //                                                  + " AND '" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd") + " 07:59:59" + "'").Tables[0];

                    //if (tbLotCnt.Rows.Count > 0)
                    //{

                    //    LotCnt = "B - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                if (tbLotNo.Rows.Count > 0)
                {
                    LotNo = tbLotNo.Rows[0][0].ToString();
                }

                if (tbCarType.Rows.Count > 0)
                {
                    CarType = tbCarType.Rows[0][0].ToString();
                }

                if (tbItemName.Rows.Count > 0)
                {
                    ItemName = tbItemName.Rows[0][0].ToString();
                }

                if (tbCarTypeName.Rows.Count > 0)
                {
                    CarTypeName = tbCarTypeName.Rows[0][0].ToString();
                }

                if (tbCostCenter2.Rows.Count > 0)
                {
                    CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
                }

                if (tbCenterName.Rows.Count > 0)
                {
                    CenterName = tbCenterName.Rows[0][0].ToString();
                }
                // 제품군 -> 작업장으로 변경 (2016.10.11)

                //string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text, txtItemName.Text, "주조", txtBoxCap.Text + " EA", "", Shift + txtBoxCap.Text + " EA", "", "A - " + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text };

                //string[] vals = new string[] { LotNo, CarType, "", txtItemCode.Text, txtItemName.Text, "완제품", qty.ToString() + " EA", LotCnt, Shift + txtBoxCap.Text + " EA", "", LotCnt + "-" + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtOrderNo.Text, wc.PlantCode, CarTypeName, CostCenter2, ItemName };
                //lp.print("가공", vals, false);//주조,사상

                bar2Code.Text = LotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;


                string[] vals = new string[] { LotNo, CarType, "", txtItemCode.Text, ItemName, "완제품", qty.ToString() + " EA", LotCnt, Shift + txtBoxCap.Text + " EA", "", LotCnt + "-" + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtOrderNo.Text, wc.PlantCode, CarTypeName, CenterName };
                lp.print("가공", vals, false);//주조,사상

                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #region [Lot 재발행 - 주조]
        private void ReDCLabelPrint()
        {
            ReDCLabelPrint("");
        }

        public void ReDCLabelPrint(string lotNo)
        {
            try
            {
                LabelPrint lp = new LabelPrint(false);

                string Worker = string.Empty;
                //string LotNo = string.Empty;
                string MoldName = string.Empty;
                string CarType = string.Empty;
                string CarTypeName = string.Empty;
                string CostCenter2 = string.Empty;
                string CenterName = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;
                string SItemCode = string.Empty;
                string SItemName = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + lotNo + "'").Tables[0];
                if (tbLot.Rows.Count == 0)
                    return;

                //현재 작업자명 로드 - 작업자가 바뀌었을 경우 현재 작업자가 찍힘
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT  dbo.FN_WorkerName('" + tbLot.Rows[0]["WorkerID"].ToString() + "')").Tables[0];
                //DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
                //                                                     + " FROM TBM2400 "
                //                                                     + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
                //형번 txtOrderNo.Text - 이전 금형일 경우 현재금형이 찍힘 수정필요.
                //DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                //                                                    + " FROM TAP0100 A "
                //                                                    + " LEFT OUTER JOIN TBM1600 B "
                //                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                //                                                    + " WHERE PlanNO = '" + tbLot.Rows[0]["OrderNo"].ToString() + "'").Tables[0];
                DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 MoldName "
                                                                     + " FROM TBM1600  "
                                                                     + " WHERE MoldCode = '" + tbLot.Rows[0]["MoldCode"].ToString() + "'").Tables[0];
                //DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                //                                                     + " FROM TAP0100 A "
                //                                                     + " LEFT OUTER JOIN TBM1600 B "
                //                                                     + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                //                                                     + " WHERE PlanNO = '" + txtOrderNo.Text + "'").Tables[0];
                //차종 
                //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                //                                                    + " FROM TBM0100 A "
                //                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];
                string itemcode = tbLot.Rows[0]["ItemCode"].ToString().Trim();
                DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType,ItemName "
                                                                     + " FROM TBM0100 A "
                                                                     + " WHERE ItemCode = '" + itemcode + "'").Tables[0];

                DataTable tbCarTypeName = new DataTable();
                DataTable tbCostCenter2 = new DataTable();

                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }
                else
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }

                //현재 작업장명 로드
                DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                      + " FROM TBM0600 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];

                //사상 품번, 품명
                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ItemCode, ItemName "
                                                                    + " FROM TBM0100 A "
                                                                    + " WHERE ItemCode LIKE '" + itemcode.Trim().Substring(0, (itemcode.Trim().Length - 2)) + "3'" + " + '%'"
                                                                    + " AND ItemCode <> '" + itemcode + "'").Tables[0];
                //string sql = "SELECT TOP 1 ItemCode, ItemName  FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";

                //DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];


                //LotCnt
                //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
                //if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 7 && mdt.Hour < 20)
                {
                    Shift = "주간   ";
                    Shift2 = "A - ";
                    LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();

                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                   + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                   + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 08:00:00" + "'"
                    //                                                   + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    ////+ " AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 20:00:00" + "'").Tables[0];

                    ////clsDB.nvlString(mesGrid1.Row.Cells["LotNo"].Value);
                    //if (tbLotCnt.Rows.Count > 0)
                    //{
                    //    //LotCnt = tbLotCnt.Rows[0][0].ToString();
                    //    LotCnt = "A - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                else
                {
                    Shift = "야간   ";
                    Shift2 = "B - ";
                    LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();

                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                  + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 20:00:01" + "'"
                    //                                                  + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{

                    //    LotCnt = "B - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }

                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                if (tbMoldNo.Rows.Count > 0)
                {
                    MoldName = tbMoldNo.Rows[0][0].ToString();
                }
                string itemNm = "";
                if (tbCarType.Rows.Count > 0)
                {
                    CarType = tbCarType.Rows[0]["CarType"].ToString();
                    itemNm = tbCarType.Rows[0]["ItemName"].ToString();
                }

                if (tbCarTypeName.Rows.Count > 0)
                {
                    CarTypeName = tbCarTypeName.Rows[0][0].ToString();
                }

                if (tbCostCenter2.Rows.Count > 0)
                {
                    CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
                }

                if (tbCenterName.Rows.Count > 0)
                {
                    CenterName = tbCenterName.Rows[0][0].ToString();
                }
                // 제품군 -> 작업장으로 변경 (2016.10.11)

                if (tbSItemCode.Rows.Count > 0)
                {
                    SItemCode = tbSItemCode.Rows[0][0].ToString();
                    SItemName = tbSItemCode.Rows[0][1].ToString();
                }
                else //if (tbSItemCode.Rows.Count == 0)
                {
                    SItemCode = ""; //txtItemCode.Text;
                    SItemName = "";// txtItemName.Text;
                }

                //LotNo = clsDB.nvlString(mesGrid2.Row.Cells["LotNo"].Value);
                // LotNo = lotNo;
                string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]) + " EA";



                bar2Code.Text = lotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                // string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text.Trim(), txtItemName.Text, "주조", clsDB.nvlString(mesGrid2.Row.Cells["ProdQty1"].Value) + " EA", "", Shift + clsDB.nvlString(mesGrid2.Row.Cells["ProdQty1"].Value) + " EA", "", Shift2 + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text, SItemCode, SItemName };
                string[] vals = new string[] { lotNo, CarTypeName, MoldName, itemcode, itemNm, "주조", qty, "", Shift + qty, "", CenterName, "", mdt.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, "사상", tbLot.Rows[0]["OrderNo"].ToString(), SItemCode, SItemName, wc.PlantCode };
                //string[] vals = new string[] { "LotNo", "차종", "형번", txtItemCode.Text, txtItemName.Text, "완제품", txtBoxCap.Text, "B-#1", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "12345678901234567890asdfg" };
                lp.print("주조", vals, true);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #region [Lot 발행 - 함침]
        public void HamLabelPrint(string lotNo)
        {
            HamLabelPrint(lotNo, false, false);
        }
        public void HamLabelPrint(string lotNo, bool bhm)
        {
            HamLabelPrint(lotNo, bhm, false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lotNo"></param>
        /// <param name="bhm">함침대기여부</param>
        public void HamLabelPrint(string lotNo, bool bhm, bool breprint)
        {
            if (lotNo == "")
                return;
            try
            {
                string Worker = string.Empty;
                string MoldName = string.Empty;
                string CarType = string.Empty;
                string CarTypeName = string.Empty;
                string CostCenter2 = string.Empty;
                string CenterName = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;
                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + lotNo + "'").Tables[0];
                if (tbLot.Rows.Count == 0)
                    return;
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT  dbo.FN_WorkerName('" + tbLot.Rows[0]["WorkerID"].ToString() + "')").Tables[0];
                string itemcode = tbLot.Rows[0]["ItemCode"].ToString().Trim();
                string sql = "SELECT TOP 1  ItemName,CarType  FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";
                DataTable tbItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];
                DataTable tbLot1 = db.ExecuteDataSet(CommandType.Text, "SELECT LotNO_In,ItemCode_In from TPP0800 where LotNO_OUT ='" + lotNo + "'").Tables[0];


                DataTable tbCarTypeName = new DataTable();
                DataTable tbCostCenter2 = new DataTable();

                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }
                else
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }

                //현재 작업장명 로드
                DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                      + " FROM TBM0600 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];

                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 7 && mdt.Hour < 20)
                {
                    Shift2 = "A - ";
                    LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                }
                else
                {
                    Shift2 = "B - ";
                    LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = Shift2 + tbWorkerName.Rows[0][0].ToString();
                }

                //if (tbLotNo.Rows.Count > 0)
                //{
                //    LotNo = tbLotNo.Rows[0][0].ToString();
                //}
                string ItemName = "";
                if (tbItemCode.Rows.Count > 0)
                {
                    ItemName = tbItemCode.Rows[0][0].ToString();
                    CarType = tbItemCode.Rows[0][1].ToString();
                }

                if (tbCarTypeName.Rows.Count > 0)
                {
                    CarTypeName = tbCarTypeName.Rows[0][0].ToString();
                }

                if (tbCostCenter2.Rows.Count > 0)
                {
                    CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
                }

                if (tbCenterName.Rows.Count > 0)
                {
                    CenterName = tbCenterName.Rows[0][0].ToString();
                }
                // 제품군 -> 작업장으로 변경 (2016.10.11)

                //string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text, txtItemName.Text, "주조", txtBoxCap.Text + " EA", "", Shift + txtBoxCap.Text + " EA", "", "A - " + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text };
                string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]) + " EA";
                string[] vals = null;
                if (bhm == false)
                {
                    vals = new string[] { lotNo, CarTypeName, itemcode, ItemName, "함침", qty, CenterName, mdt.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, tbLot1.Rows[0]["LotNO_In"].ToString(), tbLot1.Rows[0]["ItemCode_In"].ToString(), wc.PlantCode };
                }
                else
                {
                    vals = new string[] { lotNo, CarTypeName, itemcode, ItemName, "함침", qty, CenterName, mdt.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, "", "", wc.PlantCode };
                }

                LabelPrint lp = new LabelPrint(false);

                bar2Code.Text = lotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                lp.print("함침", vals, breprint);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        #endregion

        #region [Lot 재발행 - 가공]
        private void RePSLabelPrint()
        {
            RePSLabelPrint("");
        }
        public void RePSLabelPrint(string lotNo)
        {
            try
            {
                LabelPrint lp = new LabelPrint(false);

                string Worker = string.Empty;
                //  string LotNo = string.Empty;
                string CarTypeName = string.Empty;
                string CostCenter2 = string.Empty;
                string CenterName = string.Empty;
                string MoldName = string.Empty;
                string ItemName = string.Empty;
                string CarType = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + lotNo + "'").Tables[0];
                if (tbLot.Rows.Count == 0)
                    return;
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT  dbo.FN_WorkerName('" + tbLot.Rows[0]["WorkerID"].ToString() + "')").Tables[0];

                //현재 작업자명 로드
                //DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
                //                                                      + " FROM TBM2400 "
                //                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
                ////Lot No 로드
                //DataTable tbLotNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 LotNo "
                //                                                    + " FROM TPP0100 "
                //                                                    + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'"
                //                                                    + " Order by MakeDate DESC").Tables[0];
                //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                //                                                    + " FROM TBM0100 A "
                //                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];
                string itemcode = tbLot.Rows[0]["ItemCode"].ToString().Trim();
                //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                //                                                     + " FROM TBM0100 A "
                //                                                     + " WHERE ItemCode = '" + itemcode + "'").Tables[0];
                string sql = "SELECT TOP 1 ItemCode, ItemName ,CarType FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";
                // string sql1 = "SELECT TOP 1 AC3_NAME FROM" + Common.sERPDB + ".DBO.FIN_AC_COST_CENTER3 A JOIN" + Common.sERPDB +  

                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];

                //품명
                DataTable tbItemName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ITEMNAME "
                                                                    + " FROM TBM0100 "
                                                                    + " WHERE ItemCode = '" + itemcode + "'").Tables[0];


                DataTable tbCarTypeName = new DataTable();
                DataTable tbCostCenter2 = new DataTable();

                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }
                else
                {
                    //차종 이름
                    tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                    //제품군 이름
                    tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                        + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                        + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                        + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                        + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
                }

                //현재 작업장명 로드
                DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                      + " FROM TBM0600 "
                                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];

                //LotCnt
                //Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour
                // if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
                //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 7 && mdt.Hour < 20)
                {
                    Shift = "주간   ";
                    Shift2 = "A - ";
                    LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                   + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                   + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 08:00:00" + "'"
                    //                                                   + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{
                    //    //LotCnt = tbLotCnt.Rows[0][0].ToString();
                    //    LotCnt = "A - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                else
                {
                    Shift = "야간   ";
                    Shift2 = "B - ";
                    LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                  + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 20:00:01" + "'"
                    //                                                  + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{

                    //    LotCnt = "B - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                //if (tbLotNo.Rows.Count > 0)
                //{
                //    LotNo = tbLotNo.Rows[0][0].ToString();
                //}

                //if (tbCarType.Rows.Count > 0)
                //{
                //    CarType = tbCarType.Rows[0][0].ToString();
                //}

                string SItemName = "";
                if (tbSItemCode.Rows.Count > 0)
                {
                    SItemName = tbSItemCode.Rows[0]["ItemName"].ToString();
                    CarType = tbSItemCode.Rows[0]["CarType"].ToString();
                }

                if (tbItemName.Rows.Count > 0)
                {
                    ItemName = tbItemName.Rows[0][0].ToString();
                }

                if (tbCarTypeName.Rows.Count > 0)
                {
                    CarTypeName = tbCarTypeName.Rows[0][0].ToString();
                }

                if (tbCostCenter2.Rows.Count > 0)
                {
                    CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
                }

                if (tbCenterName.Rows.Count > 0)
                {
                    CenterName = tbCenterName.Rows[0][0].ToString();
                }
                // 제품군 -> 작업장으로 변경 (2016.10.11)

                //string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text, txtItemName.Text, "주조", txtBoxCap.Text + " EA", "", Shift + txtBoxCap.Text + " EA", "", "A - " + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text };
                string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]) + " EA";

                //string[] vals = new string[] { lotNo, CarType, "", itemcode, SItemName, "완제품", qty, LotCnt, Shift + qty, "", LotCnt + "-" + Worker, "", mdt.ToString("yyyy-MM-dd HH:mm:ss"), tbLot.Rows[0]["OrderNo"].ToString(), wc.PlantCode, CarTypeName, CostCenter2 };
                //lp.print("가공", vals, true);//주조,사상

                bar2Code.Text = lotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                string[] vals = new string[] { lotNo, CarType, "", itemcode, ItemName, "완제품", qty, LotCnt, Shift + qty, "", LotCnt + "-" + Worker, "", mdt.ToString("yyyy-MM-dd HH:mm:ss"), tbLot.Rows[0]["OrderNo"].ToString(), wc.PlantCode, CarTypeName, CenterName };
                lp.print("가공", vals, true);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        #endregion

        #region [Lot발행 -VBody ,4204,4306]
        public void VBLabelPrint(string WorkCenter, int shCnt, string lotNo)
        {
            try
            {
                bool bReprint = (lotNo == "" ? false : true);

                LabelPrint lp = new LabelPrint(true);
                string Worker = string.Empty;
                //  string LotNo = string.Empty;
                string MoldName = string.Empty;
                string CarType = string.Empty;
                string LotCnt = string.Empty;
                string Shift = string.Empty;
                string Shift2 = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                DataTable tbLot = null;
                if (bReprint)
                    tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT  TOP " + shCnt.ToString() + " * from TPP0100 where WorkCenterCode = '" + Common.SelectedWorkCenter.Code
                         + "' and LotNO >='" + lotNo + "'  order by lotNo ").Tables[0];
                else
                    tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT TOP " + shCnt.ToString() + " * "
                                                                    + " FROM TPP0100 "
                                                                    + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'"
                                                                    + " Order by MakeDate DESC").Tables[0];

                if (tbLot.Rows.Count == 0)
                    return;
                DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT  dbo.FN_WorkerName('" + tbLot.Rows[0]["WorkerID"].ToString() + "')").Tables[0];

                //현재 작업자명 로드
                //DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
                //                                                      + " FROM TBM2400 "
                //                                                      + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
                ////Lot No 로드
                //DataTable tbLotNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 LotNo "
                //                                                    + " FROM TPP0100 "
                //                                                    + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'"
                //                                                    + " Order by MakeDate DESC").Tables[0];
                //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                //                                                    + " FROM TBM0100 A "
                //                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];
                string itemcode = tbLot.Rows[0]["ItemCode"].ToString().Trim();
                //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                //                                                     + " FROM TBM0100 A "
                //                                                     + " WHERE ItemCode = '" + itemcode + "'").Tables[0];
                string sql = "SELECT TOP 1 ItemCode, ItemName ,CarType FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";

                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];

                //LotCnt
                //Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour
                // if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
                //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 7 && mdt.Hour < 20)
                {
                    Shift = "주간";
                    Shift2 = "A - ";
                    //  LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                   + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                   + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 08:00:00" + "'"
                    //                                                   + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{
                    //    //LotCnt = tbLotCnt.Rows[0][0].ToString();
                    //    LotCnt = "A - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                else
                {
                    Shift = "야간 ";
                    Shift2 = "B - ";
                    //LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                    //DataTable tbLotCnt = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT (*) FROM TPP0100 "
                    //                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "' "
                    //                                                  + " AND MakeDate BETWEEN '" + Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).ToString("yyyy-MM-dd") + " 20:00:01" + "'"
                    //                                                  + " AND '" + clsDB.nvlString(mesGrid2.Row.Cells["Indate"].Value) + "'").Tables[0];
                    //if (tbLotCnt.Rows.Count > 0)
                    //{

                    //    LotCnt = "B - #" + (Convert.ToInt32(tbLotCnt.Rows[0][0]) + 1).ToString();
                    //}
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                //if (tbLotNo.Rows.Count > 0)
                //{
                //    LotNo = tbLotNo.Rows[0][0].ToString();
                //}

                //if (tbCarType.Rows.Count > 0)
                //{
                //    CarType = tbCarType.Rows[0][0].ToString();
                //}

                string SItemName = "";
                if (tbSItemCode.Rows.Count > 0)
                {
                    SItemName = tbSItemCode.Rows[0]["ItemName"].ToString();
                    CarType = tbSItemCode.Rows[0]["CarType"].ToString();
                }

                string[] vals = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", Common.SelectedWorkCenter.Name, CarType, itemcode, SItemName, Shift, mdt.ToString("yyyy-MM-dd HH:mm:ss"), Worker, Shift2, bReprint.ToString(), wc.PlantCode };

                for (int i = 0; i < tbLot.Rows.Count; i++)
                {
                    vals[i] = tbLot.Rows[i]["LotNo"].ToString();
                    string qty = clsDB.nvlString(tbLot.Rows[i]["ProdQty"]) + " EA";
                    vals[i + 4] = qty;
                    vals[i + 8] = tbLot.Rows[i]["LotSno"].ToString();
                }


                bar2Code.Text = lotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                lp.print("VBODY", vals, bReprint ? true : false);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        //재발행
        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            //string LotNo = string.Empty;
            //string ProdQty = string.Empty;
            //string Shift = string.Empty;
            if (e._UltraGridCell.Value.ToString() == "재발행")
            {
                //MessageBox.Show("Test");
                //return;
                //주조 LOT 발행 - 차승영 
                if (Common.SelectedWorkCenter.Code.Substring(0, 1).Equals("2"))
                {
                    //LotNo =  e.row.Cells["LotNo"].Value.ToString();
                    //ProdQty = e.row.Cells["ProdQty"].Value.ToString();
                    //Shift = e.row.Cells["ProdQty"].Value.ToString();
                    ReDCLabelPrint(e._UltraGridRow.Cells["LotNo"].Value.ToString());
                }
                // else if (Common.SelectedWorkCenter.Code.StartsWith("460") == true || Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306")//V/BODY 
                else if (Common.gsPlantCode == "SK2" && lotPrnCnt > 2) //(Common.SelectedWorkCenter.Code == "4204" || Common.SelectedWorkCenter.Code == "4306"))  
                {
                    //  VBLabelPrint(Common.SelectedWorkCenter.Code, (Common.SelectedWorkCenter.Code == "4603" ? 3 : 4), e.row.Cells["LotNo"].Value.ToString());
                    VBLabelPrint(Common.SelectedWorkCenter.Code, lotPrnCnt, e._UltraGridRow.Cells["LotNo"].Value.ToString());

                }
                //가공 LOT 발행 - 차승영
                else if (Common.SelectedWorkCenter.Code.StartsWith("4"))
                {
                    RePSLabelPrint(e._UltraGridRow.Cells["LotNo"].Value.ToString());
                }
            }
            else if (e._UltraGridCell.Value.ToString() == "삭제")
            {
                DA9300 d1 = new DA9300();
                d1.ButtonCount = 2;
                d1.ButtonNames[0] = "삭제\r\n확인";
                d1.ButtonNames[1] = "취소";

                d1.StartPosition = FormStartPosition.Manual;
                d1.Location = new Point(Cursor.Position.X - 400, Cursor.Position.Y - d1.Size.Height - 10);

                ShowDialogForm(d1);


                if (d1.DialogResult == DialogResult.Cancel)
                {
                    return;
                }

                string lotno = e._UltraGridRow.Cells["LotNo"].Value.ToString();
                try
                {
                    //2018.11.22 MC.YANG 삭제시 인터페이스 오류방지를 위해 등록 후 5분뒤 삭제되게 수정
                    Database db;
                    db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    DateTime dtime = Convert.ToDateTime(db.ExecuteScalar(CommandType.Text, "SELECT MAX(MakeDate) FROM TPP0100 WITH(NOLOCK) WHERE LOTNO = '" + lotno + "'"));

                    if (dtime.AddMinutes(5) > DateTime.Now)
                    {
                        TimeSpan ts = dtime.AddMinutes(5).Subtract(DateTime.Now);

                        SetMessage((ts.Minutes > 0 ? "실적 인터페이스 중 입니다. " + ts.Minutes.ToString() + "분" : "") + ts.Seconds.ToString() + "초후 삭제 가능합니다.");
                        return;
                    }

                    SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0500_D1");
                    cmd.Parameters.Add(new SqlParameter("@lotno", lotno));
                    string rt = clsDB.gExecuteScalar(conn, cmd).ToString();
                    if (rt == "1")
                    {
                        SetMessage(lotno + " 삭제하였습니다.");
                        mesGrid2.DoFind();
                    }
                    else
                        SetMessage("삭제 할수 없는 LotNo입니다.");

                }
                catch (Exception ex)
                {
                    SetMessage(ex.Message);
                }
                finally
                {
                }
            }


        }
    }
}
