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
    public partial class DA0070 : BaseForm
    {
        #region 멤버변수
        bool bSet = false;

        private int iSelRow;

        private int iSecond = 0;
        private int iTarSecond = 10;

        private DataTable dtItemlist = null;


        bool bIsOKBarcode;
        string sCode;

        WorkCenter wc = Common.SelectedWorkCenter;

        //밸브바디 사상장 (사상1(우남테크): 3101)인 경우 사상인지 쇼트(완료공정)인지 여부가 필요하다..
        //사상인지 여부
        bool bIsSasang = false;

        private string SelectedItem;

        bool blnScanRefresh = true;


        public bool bSetWorkCenter
        { set { bSet = value; } }
        #endregion

        public DA0070()
        {
            InitializeComponent();
        }

        private void DA0070_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            SetWorkCenter();
            SetButtons();

            SetGrid();

            init();     //초기화

            SetLblMessageClear();

            iSelRow = -1;

            EventTimerEnable = true;
        }

        private void SetButtons()
        {
            //공용사상장 작업장, 밸브바디 사상장의 작업장을 버튼으로 넣어준다. 

            WorkCenter wc = Common.SelectedWorkCenter;

            System.Collections.ObjectModel.Collection<WorkCenter> _workcenterlist = Common.gListWorkCenter;

            bBox_WC.CountX = 4;
            bBox_WC.CountY = 1;
            bBox_WC.SetButtons();

            int j = 0;

            foreach (WorkCenter w in _workcenterlist)
            {
                bBox_WC[0, j].Text = w.Name;
                bBox_WC[0, j].Tag = w.Code;
                j += 1;
            }

            for (int i = j; i < 4; i++)
            {
                bBox_WC[0, i].UseFlag = false;
            }

            // 처음 INIT시에는 작지관련 정보가 없다.
            // 지시선택, 작업자, 가동, 불량등록, 작업현황, 가동현황, 투입LOT, 입고등록(부품식별표 발행)
            // , 설비고장, 자주검사, 일상점검, 종료
            bBox_WC.RedrawButtons();

            bBox1.CountX = 4;
            bBox1.CountY = 1;

            bBox1.SetButtons();

            //// 실적등록, 불량등록, 설비고장, 설비보전, 등록, 현황
            //bBox1[0, 0].Text = "";
            //bBox1[0, 0].Tag = "InputProd";
            //bBox1[0, 0].UseFlag = false;

            //bBox1[0, 1].Text = "불량등록";
            //bBox1[0, 1].Tag = "Error";

            //bBox1[0, 2].Text = "설비고장";
            //bBox1[0, 2].Tag = "MachErr";

            //bBox1[0, 3].Text = "설비보전";
            //bBox1[0, 3].Tag = "MachRepair";

            //bBox1[0, 4].Text = "";
            //bBox1[0, 4].Tag = "Check";
            //bBox1[0, 4].UseFlag = false;

            //bBox1[0, 5].Text = "현황";
            //bBox1[0, 5].Tag = "State";

            // 불량등록, 설비고장, 설비보전, 현황
            bBox1[0, 0].Text = "불량등록";
            bBox1[0, 0].Tag = "Error";

            //bBox1[0, 1].Text = "설비고장";
            //bBox1[0, 1].Tag = "MachErr";

            bBox1[0, 2].Text = "설비보전";
            bBox1[0, 2].Tag = "MachRepair";

            bBox1[0, 3].Text = "현황";
            bBox1[0, 3].Tag = "State";

            bBox1.RedrawButtons();

            btnConfBox.CountX = 1;
            btnConfBox.CountY = 1;
            btnConfBox.SetButtons();
            btnConfBox[0, 0].Text = "LOT 작업완료";
            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            Grid1.CountRows = 5;

            string Sasang = "N";

            if (bIsSasang == true)
            {
                Sasang = "Y";
            }
            else
            {
                Sasang = "N";
            }

            Grid1.SelectProcedureName = "[USP_DA0070_S1]";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
            Grid1.ParameterList.Add(new SqlParameter("@pSasang", Sasang));
            if (Common.SelectedWorkCenter == null)
            {
                Grid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", ""));
            }
            else
            {
                Grid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
            }

        }

        private void init()
        {
            if (Common.SelectedWorkCenter == null)
            {
                txtLotNo.Text = "";
                DoClear();
            }
            else
            {
                WorkCenter wc = Common.SelectedWorkCenter;

                txtItemCode.Text = wc.ItemCode;
                txtItemName.Text = wc.ItemName;
                txtGoodQty.Text = wc.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo;
            }
        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (bSet && iSecond++ < iTarSecond)
            {
                //if (Common.SelectedWorkCenter != null)
                //    SetButtonStatus();
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
                    //Common.SelectedWorkCenter = null;

                    //init();
                }
                else
                {
                    if ((iSelRow >= Grid1.Rows.Count) || (iSelRow == -1))
                    {
                        iSelRow = 0;

                        Grid1.Rows[iSelRow].Selected = true;
                        Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                    }
                    else
                    {
                        Grid1.Rows[iSelRow].Selected = true;
                        Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                //SetMessage(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        /// 작업장 정보 조회
        private void DoFind()
        {
            Grid1.DoFind();

            if (Grid1.DataSourceDS.Tables.Count >= 3)
                dtItemlist = Grid1.DataSourceDS.Tables[2];

            if (Grid1.DataSourceDS.Tables.Count >= 4)
            {
                if (Grid1.DataSourceDS.Tables[3].Rows.Count == 1)
                {
                    iTarSecond = clsDB.nvlInt(Grid1.DataSourceDS.Tables[3].Rows[0]["RelCode1"]);

                    if (iTarSecond == 0)
                    {
                        iTarSecond = 30;
                    }
                }
            }

            if (Grid1.Rows.Count == 0)  // 작업장이 설정되지 않았을 경우
            {
                iSelRow = -1;
                //Common.SelectedWorkCenter = null;

                //init();
            }
            else
            {
                if ((iSelRow >= Grid1.Rows.Count) || (iSelRow == -1))
                {
                    iSelRow = 0;

                    Grid1.Rows[iSelRow].Selected = true;
                    Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                }
                else
                {
                    Grid1.Rows[iSelRow].Selected = true;
                    Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
                }
            }

            // 
            //Common.gListWorkCenter.Clear();

            bSet = true;
        }

        /// 작업지시 정보 조회
        private void SetOrderList(WorkCenter wc)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA0100_S3";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);

                wc.GetOrderList(Common.ListOrderType.SELECT).Clear();

                foreach (DataRow dr in dt.Rows)
                    wc.GetOrderList(Common.ListOrderType.SELECT).AddOrder(dr["OrderNo"].ToString(), dr["ItemCode"].ToString());
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }
        }

        // 그리드 클릭 이벤트
        private void Grid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            iSelRow = e._UltraGridRow.Index;

            SelectedItem = clsDB.nvlString(e._UltraGridRow.Cells["ITEMCODE"].Value);

            ////WorkCenter wc = Common.getWorkCenter(clsDB.nvlString(e.row.Cells["WorkcenterCode"].Value));

            //Common.SelectedWorkCenter = wc;

            //wc.ClearHash();

            //init();

            //SetButtonStatus();
        }

        /// 버튼 상태 변경
        private void SetButtonStatus()
        {
            if (Common.SelectedWorkCenter == null)
                return;

            WorkCenter wc = Common.SelectedWorkCenter;

            try
            {
                //#region 가동/비가동 버튼
                //// 가동/비가동 버튼 정보 수정
                //if (wc.LineStatus != "R")
                //{
                //    bBox1.GetButtonByTag("Run").Text = "가동";
                //    bBox1.GetButtonByTag("EndWork").UseFlag = false;
                //}
                //else
                //{
                //    bBox1.GetButtonByTag("Run").Text = "비가동";
                //    bBox1.GetButtonByTag("EndWork").UseFlag = true;
                //}
                //#endregion

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

                #region 다음 작업

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

                #endregion

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
                //WorkCenter wc = Common.SelectedWorkCenter;
                // 제약조건

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection con = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                switch (btn.Tag.ToString())
                {
                    case "Error":   //불량등록

                        //if (bIsOKBarcode == false)
                        //{
                        //    SetMessage("LOT번호를 입력하세요.");
                        //    break;
                        //}

                        DA0670 da0670 = new DA0670();

                        da0670.sLotNo = txtLotNo.Text.Trim();
                        da0670.bisSasang = bIsSasang;
                        if (txtItemCode.Text.Trim() == "")
                        {
                            da0670.SelectedItem = SelectedItem;
                        }
                        else
                        {
                            da0670.SelectedItem = txtItemCode.Text;
                        }

                        da0670.bIsOKBarcode = bIsOKBarcode;

                        ShowDialogForm(da0670);
                        SetLblMessageClear();
                        break;

                    case "Lot":     // 투입 LOT
                        DA0400 da0400 = new DA0400();
                        ShowDialogForm(da0400);
                        SetLblMessageClear();
                        break;

                    case "InputProd":   // 입고등록
                        DA0500 da0500 = new DA0500();
                        ShowDialogForm(da0500);
                        SetLblMessageClear();
                        break;

                    case "MachErr": // 설비 고장
                        //DA0910 da0910 = new DA0910();
                        //da0910.sMachCode = "";
                        //ShowDialogForm(da0910);
                        //SetLblMessageClear();

                        if (ShowDialogForm(new MessageForm("설비 긴급 점검을 요청하시겠습니까?", MessageBoxButtons.YesNo, "등록 확인")) != System.Windows.Forms.DialogResult.Yes)
                            return;

                        cmd.CommandText = "SP_SEND_EQUIPMENT_MAINT_SMS";
                        cmd.Parameters.Clear();

                        if (wc != null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@PLANTCODE", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@WORKCENTERCODE", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@NAME", wc.Name));
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                            cmd.Parameters.Add(new SqlParameter("@NAME", Common.SelectedWorkCenter.Name));
                        }

                        if (!clsDB.gExecuteProcedure(con, cmd))
                        {
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        else
                        {
                            ShowDialogForm(new MessageForm("정상적으로 문자가 발송되었습니다.", MessageBoxButtons.OK, "SMS 발송확인"));
                        }

                        break;

                    case "MachRepair":  // 설비 고장

                        DA1000 da1000 = new DA1000();
                        ShowDialogForm(da1000);
                        break;

                    case "CheckSelf":
                        DA1120 da1120 = new DA1120();
                        SetLblMessageClear();
                        ShowDialogForm(da1120);
                        break;

                    case "Check":
                        DA1110 da1110 = new DA1110();
                        ShowDialogForm(da1110);
                        SetLblMessageClear();
                        break;

                    case "State":  // 현황
                        DA2170 DA2170 = new DA2170();
                        if (bIsSasang == true)
                        {
                            DA2170.Sasang = "Y";
                            DA2170.bIsSasang = true;
                        }

                        ShowDialogForm(DA2170);
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
                //EventTimer_Tick(this, new EventArgs());

                BarcodeCheck(txtLotNo.Text);
            }
        }

        /// 팝업 버튼 이벤트 설정
        private void btnStatus_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Tag.ToString())
            {
                case "State":
                    // 작업현황
                    DA2100 da2100 = new DA2100();
                    ShowDialogForm(da2100);
                    SetLblMessageClear();
                    break;
                case "RunState":
                    // 가동현황
                    DA2200 da2200 = new DA2200();
                    ShowDialogForm(da2200);
                    SetLblMessageClear();
                    break;
                case "Cancel":
                    //취소
                    break;
            }
        }

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

        private void DA0070_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //workcenter 정보를 넣어준다.
        private void SetWorkCenter()
        {
            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();
            DataTable dt = new DataTable();

            string sSQL = "";

            sSQL = sSQL + "SELECT A.PlantCode, A.WorkCenterCode, A.WorkCenterName " + "\n";
            sSQL = sSQL + "FROM TBM0600 A" + "\n";
            sSQL = sSQL + "    ,TBM9000 B" + "\n";
            sSQL = sSQL + "WHERE 1 = 1" + "\n";
            sSQL = sSQL + "AND A.PlantCode = B.PLANTCODE" + "\n";
            sSQL = sSQL + "AND A.WorkCenterCode = B.WORKCENTERCODE" + "\n";
            sSQL = sSQL + "AND A.UseFlag = 'Y'" + "\n";
            sSQL = sSQL + "AND B.IPADDRESS = '" + Common.gsIP + "'\n";
            sSQL = sSQL + "ORDER BY 2";

            if (clsDB.gCreateRSet(conn, sSQL, dt))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    WorkCenter wc = new WorkCenter();

                    wc.PlantCode = clsDB.nvlString(dr["PlantCode"]);
                    wc.Code = clsDB.nvlString(dr["WorkCenterCode"]);
                    wc.Name = clsDB.nvlString(dr["WorkCenterName"]);

                    Common.gListWorkCenter.Add(wc);
                    //SetOrderList(wc);
                    wc.ClearHash();
                }
            }
        }

        //작업장 선택
        private void bBox_WC_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {

            MESButton btn = sender;
            DoProgress(true);
            WorkCenter wc = Common.GetWorkCenter(btn.Tag.ToString());

            Common.SelectedWorkCenter = wc;

            //wc.ClearHash();

            txtLotNo.Text = "";
            DoClear();

            //사상1(우남)의 경우 사상인지/쇼트(완료공정)인지 선택한다
            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            string sSQL = "SELECT isnull(ShotYN,'N')  ShotYN FROM TBM0600 WHERE WorkCenterCode='" + wc.Code + "'";
            string shotYn = db.ExecuteScalar(CommandType.Text, sSQL).ToString();
            if (shotYn == "Y") //btn.Tag.ToString() == "3101")
            {
                pnl_Select.Visible = true;
            }
            else
            {
                pnl_Select.Visible = false;
            }

            SetGrid();
            DoFind();
            CloseProgressForm(true);
        }

        //17자가 입력되면 관련 아이템 정보를 읽어온다. 
        private void txtLotNo_TextChanged(object sender, EventArgs e)
        {
            //if (e.KeyChar == 17) 
            if (txtLotNo.Text.Length == 17)
            {
                if (txtLotNo.Text.Trim().Length > 0)
                {
                    DoProgress();
                    BarcodeCheck(txtLotNo.Text);
                }
                else
                {
                    SetMessage("바코드를 확인하세요.");
                    CloseProgressForm();
                }
            }
            CloseProgressForm();
        }

        private void txtLotNo_DoubleClick(object sender, EventArgs e)
        {
            DA9200 d = new DA9200();
            d.ContentText = txtLotNo.Text.Trim();

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtLotNo.Text = d.resultString;

                txtLotNo_KeyPress(txtLotNo, new KeyPressEventArgs((char)Keys.Enter));
            }
        }

        private void txtLotNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoProgress();

            bIsOKBarcode = false;

            //if (txtLotNo.Text.Length == 17)
            //{
            //    if (txtLotNo.Text.Trim().Length > 0)
            //    {
            //        BarcodeCheck(txtLotNo.Text);
            //    }
            //    else
            //    {
            //        SetMessage("바코드를 확인하세요.");
            //        ClosePrgForm();
            //    }
            //}

            if (blnScanRefresh)
            {
                txtLotNo.Text = string.Empty;
                blnScanRefresh = false;
            }

            if (e.KeyChar == 13)
            //if (txtLotNo.Text.Length == 17)
            {
                txtLotNo.Text = txtLotNo.Text.Trim();
                BarcodeCheck(txtLotNo.Text);
                blnScanRefresh = true;
            }

            CloseProgressForm();
        }

        #region 삼기
        private void BarcodeCheck(string sArr)
        {
            
            if (txtLotNo.TextLength == 0)
            {
                return;
            }

            DoProgress();

            bIsOKBarcode = false;
            sCode = "";

            #region 네트워크 테스트
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                CloseProgressForm();
                return;
            }
            #endregion

            #region 바코드 검증 로직

            DataTable dt = new DataTable();

            string sSQL;

            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection dconn = (SqlConnection)db.CreateConnection();

            if (txtLotNo.Text.Length == 17)
            {

                // 5/1이전 - 자기사업장 선확인 후 타사업장 확인 , 5/1이후 - 작업장코드 부문 확인하여 찾도록 SP로 작성

                //sSQL = "";
                //sSQL += "SELECT A.ItemCode, B.ItemName,B.CARTYPE,isnull(B.SS_WorkCenterCode,'') SS_WorkCenterCode, A.ProdQty, SUBSTRING(B.ItemCode, LEN(B.ItemCode) - 1, LEN(B.ItemCode)) ITEMTYPE " + "\n";
                //sSQL += "FROM TPP0100 A " + "\n";
                //sSQL += "	,TBM0100 B " + "\n";
                //sSQL += "WHERE A.ItemCode = B.ItemCode " + "\n";
                //sSQL += "AND B.ITEMTYPE = 'S'" + "\n";
                //sSQL += "AND LotNO = '" + txtLotNo.Text + "'";
                sSQL = "USP_DA0071_S2";

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand(sSQL);
                cmd.Connection = dconn;

                cmd.CommandType = CommandType.StoredProcedure;//.Text;

                cmd.CommandText = sSQL;
                cmd.Parameters.Add(new SqlParameter("@pLotNo", txtLotNo.Text));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenter", Common.SelectedWorkCenter.Code));

                if (clsDB.gCreateRSet(cmd, dt))
                {
                    if (dt.Rows.Count > 0)
                    {
                        string ss_wc = dt.Rows[0]["SS_WorkCenterCode"].ToString();
                        //품목 table에 사상작업장 설정된경우 타사업장의 작업장은 어떻게 할것인가?  ,로구분하여 다중 등록
                        if (ss_wc != "" && ss_wc.IndexOf(Common.SelectedWorkCenter.Code) == -1)
                        // if (ss_wc != "" && ss_wc != Common.SelectedWorkCenter.Code)
                        {
                            SetMessage("작업할수 없는 품목입니다.(" + ss_wc + "용)");

                            return;
                        }

                        txtCarType.Text = dt.Rows[0]["CARTYPE"].ToString();
                        txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString();
                        txtItemName.Text = dt.Rows[0]["ItemName"].ToString();
                        txtLotQty.Text = dt.Rows[0]["ProdQty"].ToString();

                        ////사상 아이템이 투입된 경우
                        //if (dt.Rows[0]["ProdQty"].ToString() == "30" || dt.Rows[0]["ProdQty"].ToString() == "31")
                        //{
                        //    SetMessage("작업할수 없는 아이템입니다.");
                        //    ClosePrgForm();
                        //    return;
                        //}
                    }
                    else
                    {
                        SetMessage("작업할수 없는 LOT입니다.");
                        CloseProgressForm();
                        return;
                    }
                }
                else
                {
                    SetMessage(clsDB.ErrorDesc);
                    CloseProgressForm();
                    bIsOKBarcode = false;
                    return;
                }
            }
            else
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand(Common.sERPDB + ".DBO.USP_POP_SK164");
                cmd.Connection = dconn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@move_ticket", txtLotNo.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@gubun", "L"));
                DataTable tbLot = db.ExecuteDataSet(cmd).Tables[0];

                if (tbLot.Columns[0].ColumnName.ToLower() == "err_code" && tbLot.Rows[0]["err_code"].ToString().Equals("1"))
                {
                    SetMessage(tbLot.Rows[0]["msg"].ToString());
                    txtCarType.Text = "";
                    txtItemCode.Text = "";
                    txtItemName.Text = "";
                    txtLotQty.Text = "";

                    CloseProgressForm();
                    return;

                }
                else
                {
                    if (tbLot.Rows.Count == 0)
                    {
                        SetMessage("재고기록표에 문제가있습니다. 작업불가.");
                        CloseProgressForm();
                        bIsOKBarcode = false;
                        return;
                    }

                    txtItemName.Text = tbLot.Rows[0]["description"].ToString();
                    txtItemCode.Text = tbLot.Rows[0]["resource_no"].ToString();
                    txtLotQty.Text = string.Format("{0:#,##0}", Convert.ToInt32(tbLot.Rows[0]["qty_on_hand"]));

                    if (Convert.ToInt32(tbLot.Rows[0]["qty_on_hand"]) == 0)
                    {
                        SetMessage("Lot수량이 0입니다. 작업불가.");
                        CloseProgressForm();
                        bIsOKBarcode = false;
                        return;
                    }

                    sSQL = "";
                    sSQL += "SELECT CARTYPE,isnull(SS_WorkCenterCode,'') SS_WorkCenterCode FROM TBM0100 B WITH(NOLOCK)" + "\n";
                    sSQL += "WHERE ITEMCODE = '" + tbLot.Rows[0]["resource_no"].ToString() + "'";

                    SqlCommand cmd2 = (SqlCommand)db.GetStoredProcCommand(sSQL);
                    cmd2.Connection = dconn;

                    cmd2.CommandType = CommandType.Text;

                    cmd2.CommandText = sSQL;

                    DataTable dtCarType = new DataTable();

                    if (clsDB.gCreateRSet(cmd2, dtCarType))
                    {
                        if (dtCarType.Rows.Count > 0)
                        {
                            string ss_wc = dtCarType.Rows[0]["SS_WorkCenterCode"].ToString();
                            if (ss_wc != "" && ss_wc != Common.SelectedWorkCenter.Code)
                            {
                                SetMessage("작업할수 없는 품목입니다.(" + ss_wc + ")");
                                return;
                            }
                            txtCarType.Text = dtCarType.Rows[0]["CARTYPE"].ToString();
                        }
                    }
                    else
                    {
                        SetMessage("차종을 가져올수 없습니다.");
                        CloseProgressForm();
                        bIsOKBarcode = false;
                        return;
                    }
                }
            }

            if (bIsSasang == true)
            {
                //이미 작업이 완료된 건인지 - 밸브바디 사상장
                //밸브바디도 외주입고되는 경우 고려해야됨......
                DataTable tbValveDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0815 where LotNO = '" + txtLotNo.Text + "'").Tables[0];
                int ValveDoneQty = Convert.ToInt16(tbValveDone.Rows[0]["QTY"].ToString());
                if (ValveDoneQty != 0)
                {
                    SetMessage("이미 사상작업이 완료된 LOT번호입니다.");
                    CloseProgressForm();
                    return;
                }
            }

            // 20130705 한개의 투입로트를 여러번 등록할수 있도록 변경
            //if (txtLotNo.TextLength == 17)
            //{
            //    //이미 작업이 완료된 건인지 - 사상(완료공정기준)
            //    DataTable tbDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 where PrevLOTNO = '" + txtLotNo.Text + "'").Tables[0];
            //    int DoneQty = Convert.ToInt16(tbDone.Rows[0]["QTY"].ToString());

            //    if (bIsSasang != true && DoneQty != 0)
            //    {
            //        SetMessage("이미 사상 작업완료가 수행된 LOT번호입니다.");
            //        ClosePrgForm();
            //        return;
            //    }
            //}

            //혹시 완료(완료공정)된 lot를 읽는건 아닌지 - 사상(완료공정기준)
            DataTable tbNewLot = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 WITH(NOLOCK) where LOTNO = '" + txtLotNo.Text + "'").Tables[0];
            int NewLotQty = Convert.ToInt16(tbNewLot.Rows[0]["QTY"].ToString());

            if (NewLotQty != 0)
            {
                SetMessage("사상작업장에서 발행된 LOT번호입니다. 작업진행불가.");
                CloseProgressForm();
                return;
            }

            //사상품목코드가 등록되어있지 않은경우 에러
            DataTable tbSS_itemcode = db.ExecuteDataSet(CommandType.Text, "SELECT SS_itemcode from TBM0100 WITH(NOLOCK) where ItemCode = '" + txtItemCode.Text.Trim() + "'").Tables[0];

            if (tbSS_itemcode.Rows.Count == 0)
            {
                SetMessage("아이템코드에 문제가있습니다. 관리자문의.");
                CloseProgressForm();
                return;
            }
            else
            {
                if (tbSS_itemcode.Rows[0]["SS_itemcode"].ToString().Trim().Equals(string.Empty))
                {
                    SetMessage("사상아이템이 등록되어있지 않습니다. 관리자문의.");
                    CloseProgressForm();
                    return;
                }
            }

            //기초재고가 20이 아닌 30/31로 잘못 올라가있어서 투입하면 차공정을 못잡아와서 완제품 (-30, -31이 없는)으로 생성이 되는 경우 발생
            try
            {
                DateTime dtime = Convert.ToDateTime(db.ExecuteScalar(CommandType.Text, "SELECT max(makedate) FROM TPP0816 WITH(NOLOCK) WHERE PrevLOTNO = '" + txtLotNo.Text + "'"));

                if (dtime.AddMinutes(3) > DateTime.Now)
                {
                    TimeSpan ts = dtime.AddMinutes(3).Subtract(DateTime.Now);

                    SetMessage((ts.Minutes > 0 ? ts.Minutes.ToString() + "분" : "") + ts.Seconds.ToString() + "초후 등록할수 있습니다.");
                    return;

                }
            }
            catch (Exception ex) { }


            SetMessage("작업 가능한 바코드입니다.");
            sCode = "P";
            bIsOKBarcode = true;

            //불량수량 가져오기
            //사상불량수량
            DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(ERRORQTY), 0) ERRORQTY from TPP0810 WITH(NOLOCK) where NEWLOTNO IS NULL AND LotNO ='" + txtLotNo.Text + "'").Tables[0];
            string badqty = tbBad.Rows[0]["ERRORQTY"].ToString();
            txtBadQty.Text = badqty;

            //기 작업수량 가져오기
            //완료공정기준 등록 수량
            DataTable tbDone = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(GOODQTY), 0) DONEQTY from TPP0816 WITH(NOLOCK) where PrevLOTNO = '" + txtLotNo.Text + "'").Tables[0];
            string doneqty = tbDone.Rows[0]["DONEQTY"].ToString();
            txtDoneQty.Text = string.Format("{0:#,##0}", Convert.ToInt32(doneqty));



            string SS = "SELECT sum(ISNULL(qty_on_hand, 0)) qty_on_hand FROM " + Common.sERPDB + ".DBO.MULTILOC WITH(NOLOCK) WHERE lot_control_no = '" + txtLotNo.Text + "' OR MOVE_TICKET IN (SELECT MOVE_TICKET FROM " + Common.sERPDB + ".DBO.MOVE_TICKET_MISC WITH(NOLOCK) WHERE MT_RECEIVING in (SELECT  MOVE_TICKET FROM  " + Common.sERPDB + ".DBO.MULTILOC WITH(NOLOCK) WHERE  lot_control_no = '" + txtLotNo.Text + "'))";

            Decimal QtyOnHand = Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtDoneQty.Text);

            if (txtLotNo.TextLength != 17)
            {
                //외주입고품
                SS = "SELECT sum(ISNULL(qty_on_hand, 0)) qty_on_hand FROM " + Common.sERPDB + ".DBO.MULTILOC WITH(NOLOCK) WHERE MOVE_TICKET = " + txtLotNo.Text + " OR MOVE_TICKET IN (SELECT MOVE_TICKET FROM " + Common.sERPDB + ".DBO.MOVE_TICKET_MISC WITH(NOLOCK) WHERE MT_RECEIVING = " + txtLotNo.Text + ")";

            }
            //ERP상의 재고수량
            DataTable tbQtyOnHand = db.ExecuteDataSet(CommandType.Text, SS).Tables[0];
            if (tbQtyOnHand.Rows.Count == 0 || tbQtyOnHand.Rows[0]["qty_on_hand"].GetType().Name.ToUpper() == "DBNULL")
            {
                SetMessage("ERP에 재고정보가 없습니다.");
                //return;
            }
            else
            {
                QtyOnHand = Convert.ToDecimal(tbQtyOnHand.Rows[0]["qty_on_hand"].ToString());
            }

            // erp I/F 안한 수량
            SS = "SELECT ISNULL(SUM(ProdQty), 0) ProdQty_Not_IF " + "\n";
            SS += "FROM TPP0100 WITH(NOLOCK) " + "\n";
            SS += "WHERE LotNO IN (SELECT LOTNO FROM TPP0816 WHERE PrevLOTNO = '" + txtLotNo.Text + "') " + "\n";
            SS += "AND ISNULL(ERP_IF, 'X') <> 'S' ";

            DataTable tbProdQty_Not_IF = db.ExecuteDataSet(CommandType.Text, SS).Tables[0];
            Decimal ProdQty_Not_IF;
            ProdQty_Not_IF = Convert.ToDecimal(tbProdQty_Not_IF.Rows[0]["ProdQty_Not_IF"].ToString());

            QtyOnHand -= ProdQty_Not_IF;
            if (QtyOnHand < 0)
                QtyOnHand = 0;
            txtLotQty.Text = ((int)QtyOnHand).ToString();


            //양품수량 자동계산
            txtGoodQty.Text = Convert.ToInt32(Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtBadQty.Text)).ToString();
            // txtGoodQty.Text = Convert.ToInt32(Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtBadQty.Text) - Convert.ToDecimal(txtDoneQty.Text)).ToString();
            //if (txtGoodQty.Text == "0")
            //    SetMessage("이미 사상작업이 완료된 LOT번호입니다.");

            #endregion

            CloseProgressForm();
        }
        #endregion

        //밸브바디 - 사상 선택
        private void btnSelect_Click(object sender, EventArgs e)
        {
            bIsSasang = true;
            pnl_Select.Visible = false;
            SetGrid();
            DoFind();
        }

        //밸브바디 - 쇼트 선택
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bIsSasang = false;
            pnl_Select.Visible = false;
            SetGrid();
            DoFind();
        }

        //양품수량 수정
        private void txtGoodQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "양품수량 수정";
            d.LabelHeader = "양품수량";

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtGoodQty.Text = d.ResultString;
                if (((int)(Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtGoodQty.Text) - Convert.ToDecimal(txtBadQty.Text))) < 0)
                {
                    SetMessage("재고수량을 초과해서 등록할수 없습니다.");

                }
            }
        }

        //LOT작업완료 버튼
        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (txtLotNo.TextLength == 0)
                return;
            if (Common.SelectedWorkCenter == null)
            {
                SetMessage("작업장을 선택하세요.");
                return;
            }

            wc = Common.SelectedWorkCenter;

            if (bIsOKBarcode == false)
            {
                SetMessage("작업할수 없는 LOT입니다.");
                return;
            }

            //20130625 윤준호대리 - LOT수량을 초과해서 실적을 등록할수 없도록 변경
            //if (Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtGoodQty.Text) - Convert.ToDecimal(txtBadQty.Text) < 0)
            if (Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtGoodQty.Text) - Convert.ToDecimal(txtBadQty.Text) - Convert.ToDecimal(txtDoneQty.Text) < 0)
            {
                //      SetMessage("LOT수량을 초과해서 등록할수 없습니다.");
                //      return;
            }

            //밸브바디 사상장의 경우 LOT카드만 발행하고 종료
            if (bIsSasang == true)
            {

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //이미 작업이 완료된 건인지 - 밸브바디 사상장
                DataTable tbValveDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0815 where LotNO = '" + txtLotNo.Text + "'").Tables[0];
                int ValveDoneQty = Convert.ToInt16(tbValveDone.Rows[0]["QTY"].ToString());

                if (ValveDoneQty != 0)
                {
                    SetMessage("이미 사상 작업완료가 수행된 LOT번호입니다.");
                    return;
                }

                //밸브바디 사상장 작업완료 테이블 저장
                //DoSave_Valve();


                //if (Common.GetIPAddress() == "192.168.230.56")
                //{
                //    if (SelectedItem == "45231-23145-20" ||
                //        SelectedItem == "45231-P23000-20" ||
                //        SelectedItem == "43115-02710-20" ||
                //        SelectedItem == "43115-02700-20" ||
                //        SelectedItem == "43115-3D113-20" ||
                //        SelectedItem == "43115-3D141-20" ||
                //        SelectedItem == "43115-3D131-20" ||
                //        SelectedItem == "43111-3D110-20" ||
                //        SelectedItem == "43111-2D000-20" ||
                //        SelectedItem == "43111-2C001-20" ||
                //        SelectedItem == "43111-2B000-20" ||
                //        SelectedItem == "43111-2B001-20" ||
                //        SelectedItem == "43115-2D200-20" ||
                //        SelectedItem == "43115-2D110-20" ||
                //        SelectedItem == "43115-2D100-20" ||
                //        SelectedItem == "43115-2D000-20" ||
                //        SelectedItem == "43115-2D010-20" ||
                //        SelectedItem == "43115-2C001-20" ||
                //        SelectedItem == "43115-2C010-20" ||
                //        SelectedItem == "43115-2B000-20" ||
                //        SelectedItem == "43115-2B001-20")
                //    {
                //        LabelReport labelReport = new LabelReport();
                //        labelReport.Priting(txtLotNo.Text);
                //    }
                //    else
                //    {
                //        ReDCLabelPrint(txtLotNo.Text);
                //    }
                //}
                //else
                //{
                //주조 lot카드 수량만 변경해서 재발행
                ReDCLabelPrint(txtLotNo.Text);
                //}
            }
            else
            {
                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                string SS = "SELECT sum(ISNULL(qty_on_hand, 0)) qty_on_hand FROM " + Common.sERPDB + ".DBO.MULTILOC WHERE lot_control_no = '" + txtLotNo.Text + "' OR MOVE_TICKET IN (SELECT MOVE_TICKET FROM " + Common.sERPDB + ".DBO.MOVE_TICKET_MISC WHERE MT_RECEIVING in (SELECT  MOVE_TICKET FROM  " + Common.sERPDB + ".DBO.MULTILOC WHERE  lot_control_no = '" + txtLotNo.Text + "'))";

                Decimal QtyOnHand = Convert.ToDecimal(txtLotQty.Text) - Convert.ToDecimal(txtDoneQty.Text);

                if (txtLotNo.TextLength != 17)
                {
                    //외주입고품
                    SS = "SELECT sum(ISNULL(qty_on_hand, 0)) qty_on_hand FROM " + Common.sERPDB + ".DBO.MULTILOC WHERE MOVE_TICKET = " + txtLotNo.Text + " OR MOVE_TICKET IN (SELECT MOVE_TICKET FROM " + Common.sERPDB + ".DBO.MOVE_TICKET_MISC WHERE MT_RECEIVING = " + txtLotNo.Text + ")";

                }
                //ERP상의 재고수량
                DataTable tbQtyOnHand = db.ExecuteDataSet(CommandType.Text, SS).Tables[0];
                if (tbQtyOnHand.Rows.Count == 0 || tbQtyOnHand.Rows[0]["qty_on_hand"].GetType().Name.ToUpper() == "DBNULL")
                {
                    SetMessage("ERP에 재고정보가 없습니다.");
                    return;
                }
                else
                {
                    QtyOnHand = Convert.ToDecimal(tbQtyOnHand.Rows[0]["qty_on_hand"].ToString());
                }

                // erp I/F 안한 수량
                SS = "SELECT ISNULL(SUM(ProdQty), 0) ProdQty_Not_IF " + "\n";
                SS += "FROM TPP0100 WITH (NOLOCK) " + "\n";
                SS += "WHERE LotNO IN (SELECT LOTNO FROM TPP0816 WHERE PrevLOTNO = '" + txtLotNo.Text + "') " + "\n";
                SS += "AND ISNULL(ERP_IF, 'X') <> 'S' ";

                DataTable tbProdQty_Not_IF = db.ExecuteDataSet(CommandType.Text, SS).Tables[0];
                Decimal ProdQty_Not_IF;
                ProdQty_Not_IF = Convert.ToDecimal(tbProdQty_Not_IF.Rows[0]["ProdQty_Not_IF"].ToString());

                QtyOnHand -= ProdQty_Not_IF;

                if (((int)(QtyOnHand - Convert.ToDecimal(txtGoodQty.Text) - Convert.ToDecimal(txtBadQty.Text))) < 0)
                {
                    SetMessage("재고수량을 초과해서 등록할수 없습니다. 재고수량: " + ((int)QtyOnHand).ToString());
                    return;
                }

                //try
                //{
                //    DateTime dt = Convert.ToDateTime(db.ExecuteScalar( CommandType.Text ,"SELECT max(makedate) FROM TPP0816 WHERE PrevLOTNO = '" + txtLotNo.Text + "'"));

                //    if (dt.AddMinutes(3) > DateTime.Now)
                //    {
                //        TimeSpan ts = dt.AddMinutes(3).Subtract(DateTime.Now);

                //        SetMessage((ts.Minutes>0?ts.Minutes.ToString() :"")+"분" +ts.Seconds.ToString()+ "초후 등록할수 있습니다.");
                //        return;

                //    }
                //}
                //catch { }

                //완료공정기준 사상작업 완료
                DoSave();

                //완료공정기준 사상작업 lot카드 발행
                //새로운 lot번호로 찍음
                //ReDSLabelPrint(txtLotNo.Text);
                //return;
            }

            txtLotNo.Text = "";
            DoClear();
            DoFind();
        }

        #region [Lot 발행 - 완료공정기준 lot카드 발행]
        public void ReDSLabelPrint(string lotNo)
        {
            ReDSLabelPrint(lotNo, false);
        }
        public void ReDSLabelPrint(string lotNo, bool breprint)
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

                //신규 LOT의 기존 LOT번호
                int NewLotQty;
                string NewLot = string.Empty;
                string PrevLot = string.Empty;

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //구lot, 신lot 판단 필요. 메인창에서는 구로트, 현황창에서는 신로트
                DataTable tbNewLotQTY = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) NEWLOTQTY "
                                                        + " FROM TPP0816 A "
                                                        + " WHERE PrevLOTNO = '" + lotNo + "'").Tables[0];
                NewLotQty = Convert.ToInt16(tbNewLotQTY.Rows[0][0].ToString());

                if (NewLotQty != 0)
                {
                    //외주입고분의 경우 같은 LOT가 계속 들어오므로, 가장 마지막것을 가지고온다...
                    DataTable tbNewLot = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 LOTNO "
                                                            + " FROM TPP0816 A "
                                                            + " WHERE PrevLOTNO = '" + lotNo + "'"
                                                            + " ORDER BY MAKEDATE DESC ").Tables[0];

                    NewLot = tbNewLot.Rows[0][0].ToString();
                    PrevLot = lotNo;
                }
                else
                {
                    DataTable tbNewLot = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 PREVLOTNO "
                                        + " FROM TPP0816 A "
                                        + " WHERE LOTNO = '" + lotNo + "'"
                                        + " ORDER BY MAKEDATE DESC ").Tables[0];

                    PrevLot = tbNewLot.Rows[0][0].ToString();
                    NewLot = lotNo;
                }

                DataTable tbLot1 = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + PrevLot + "'").Tables[0];

                string PrevLotInfo = PrevLot;

                if (tbLot1.Rows.Count != 0)
                {
                    PrevLotInfo += " : " + tbLot1.Rows[0]["ItemCode"].ToString().Trim() + " : " + string.Format("{0:n0}", tbLot1.Rows[0]["ProdQty"]) + "EA";
                }

                DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + NewLot + "'").Tables[0];
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

                if (PrevLot.Length == 17)
                {
                    if (string.IsNullOrEmpty(MoldName))
                    {
                        DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                                            + " FROM TPP0100 A "
                                                                            + " LEFT OUTER JOIN TBM1600 B "
                                                                            + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                            + " WHERE LotNO = '" + PrevLot + "'").Tables[0];

                        if (tbMoldNo.Rows.Count > 0)
                        {
                            MoldName = tbMoldNo.Rows[0][0].ToString();
                        }
                    }

                    if (wc.PlantCode == "SK2")
                    {
                        if (string.IsNullOrEmpty(MoldName))
                        {
                            DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                                                + " FROM TPP1790 A "
                                                                                + " LEFT OUTER JOIN TBM1600 B "
                                                                                + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                                + " WHERE OrderNo = '" + PrevLot.Substring(0, 13) + "'").Tables[0];

                            if (tbMoldNo.Rows.Count > 0)
                            {
                                MoldName = tbMoldNo.Rows[0][0].ToString();
                            }
                        }

                        if (string.IsNullOrEmpty(MoldName))
                        {
                            DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                        + " FROM SKMES.SK_MESDB_V1.dbo.TPP0100 A "
                                                        + " LEFT OUTER JOIN SKMES.SK_MESDB_V1.dbo.TBM1600 B "
                                                        + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                        + " WHERE LotNO = '" + PrevLot + "'").Tables[0];

                            if (tbMoldNo.Rows.Count > 0)
                            {
                                MoldName = string.Format("{0} : {1}", "평택", tbMoldNo.Rows[0][0].ToString());
                            }
                        }
                    }
                }
                else
                {
                    MoldName = string.Empty;
                }

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
                DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
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
                //DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ItemCode, ItemName "
                //                                                    + " FROM TBM0100 A "
                //                                                    + " WHERE ItemCode LIKE '" + txtItemCode.Text.Trim().Substring(0, (txtItemCode.Text.Trim().Length - 2)) + "3'" + " + '%'"
                //                                                    + " AND ItemCode <> '" + txtItemCode.Text + "'").Tables[0];


                string sql = "SELECT TOP 1 ItemCode, ItemName  FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";

                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];


                //LotCnt
                //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
                // if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 8 && mdt.Hour < 20)
                {
                    Shift = "주간   ";
                    //Shift2 = "A - ";
                    Shift2 = "";
                    LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                }
                else
                {
                    Shift = "야간   ";
                    //Shift2 = "B - ";
                    Shift2 = "";
                    LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                }

                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                if (tbCarType.Rows.Count > 0)
                {
                    CarType = tbCarType.Rows[0][0].ToString();
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
                    SItemName = tbSItemCode.Rows[0][1].ToString();
                }
                else //if (tbSItemCode.Rows.Count == 0)
                {
                    SItemName = "";// txtItemName.Text;
                }

                string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]);

                //사상불량수량
                string badqty;
                if (bIsSasang == true)
                {
                    //사상단계에서는 사상불량만 표시
                    DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(ERRORQTY), 0) ERRORQTY from TPP0810 where SASANGERROR = 'Y' AND LotNO ='" + PrevLot + "'").Tables[0];
                    badqty = tbBad.Rows[0]["ERRORQTY"].ToString();
                }
                else
                {
                    DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(ERRORQTY), 0) ERRORQTY from TPP0810 where NEWLOTNO = '" + NewLot + "'" + " AND LotNO ='" + PrevLot + "'").Tables[0];
                    badqty = tbBad.Rows[0]["ERRORQTY"].ToString();
                }

                bar2Code.Text = NewLot;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                string[] vals = new string[] { NewLot, CarTypeName, MoldName, itemcode, SItemName, "사상", qty + " EA", badqty + " EA", Shift + qty + " EA", "", CenterName, "", mdt.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, "가공", tbLot.Rows[0]["OrderNo"].ToString(), itemcode, SItemName, PrevLotInfo, wc.PlantCode };
                lp.print("사상", vals, breprint);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion


        #region [Lot 발행 - 밸브바디사상장. 주조와 동일]
        public void ReDCLabelPrint(string lotNo)
        {
            ReDCLabelPrint(lotNo, false);
        }
        public void ReDCLabelPrint(string lotNo, bool breprint)
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
                DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                                    + " FROM TAP0100 A "
                                                                    + " LEFT OUTER JOIN TBM1600 B "
                                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                    + " WHERE PlanNO = '" + tbLot.Rows[0]["OrderNo"].ToString() + "'").Tables[0];
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



                DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
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
                //DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ItemCode, ItemName "
                //                                                    + " FROM TBM0100 A "
                //                                                    + " WHERE ItemCode LIKE '" + txtItemCode.Text.Trim().Substring(0, (txtItemCode.Text.Trim().Length - 2)) + "3'" + " + '%'"
                //                                                    + " AND ItemCode <> '" + txtItemCode.Text + "'").Tables[0];
                string sql = "SELECT TOP 1 ItemCode, ItemName  FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";

                DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];


                //LotCnt
                //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
                // if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
                DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
                if (mdt.Hour > 8 && mdt.Hour < 20)
                {
                    Shift = "주간   ";
                    Shift2 = "A - ";
                    LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
                }
                else
                {
                    Shift = "야간   ";
                    Shift2 = "B - ";
                    LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
                }
                if (tbWorkerName.Rows.Count > 0)
                {
                    Worker = tbWorkerName.Rows[0][0].ToString();
                }

                if (tbMoldNo.Rows.Count > 0)
                {
                    MoldName = tbMoldNo.Rows[0][0].ToString();
                }

                if (tbCarType.Rows.Count > 0)
                {
                    CarType = tbCarType.Rows[0][0].ToString();
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
                    SItemName = tbSItemCode.Rows[0][1].ToString();
                }
                else //if (tbSItemCode.Rows.Count == 0)
                {
                    SItemName = "";// txtItemName.Text;
                }

                string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]);

                ////사상불량수량
                //DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT SUM(ERRORQTY) ERRORQTY from TPP0810 where LotNO ='" + lotNo + "'").Tables[0];
                //string badqty = tbBad.Rows[0]["ERRORQTY"].ToString();


                //사상불량수량
                string badqty;
                if (bIsSasang == true)
                {
                    //사상단계에서는 사상불량만 표시
                    DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(ERRORQTY), 0) ERRORQTY from TPP0810 where SASANGERROR = 'Y' AND LotNO ='" + lotNo + "'").Tables[0];
                    badqty = tbBad.Rows[0]["ERRORQTY"].ToString();
                }
                else
                {
                    DataTable tbBad = db.ExecuteDataSet(CommandType.Text, "SELECT ISNULL(SUM(ERRORQTY), 0) ERRORQTY from TPP0810 where LotNO ='" + lotNo + "'").Tables[0];
                    badqty = tbBad.Rows[0]["ERRORQTY"].ToString();
                }

                bar2Code.Text = lotNo;
                Bitmap bmap = new Bitmap(bar2Code.Width, bar2Code.Height);
                bar2Code.DrawToBitmap(bmap, bar2Code.ClientRectangle);
                lp.barImg = bmap;

                // string[] vals = new string[] { LotNo, CarType, MoldName, txtItemCode.Text.Trim(), txtItemName.Text, "주조", clsDB.nvlString(mesGrid2.Row.Cells["ProdQty1"].Value) + " EA", "", Shift + clsDB.nvlString(mesGrid2.Row.Cells["ProdQty1"].Value) + " EA", "", Shift2 + Worker, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt, "사상", txtOrderNo.Text, SItemCode, SItemName };
                string[] vals = new string[] { lotNo, CarTypeName, MoldName, itemcode, SItemName, "사상", qty + "EA", badqty + "EA", Shift + qty + "EA", "", CenterName, "", mdt.ToString("yyyy-MM-dd HH:mm:ss"), LotCnt + "-" + Worker, "쇼트", tbLot.Rows[0]["OrderNo"].ToString(), itemcode, SItemName, "", wc.PlantCode };
                //string[] vals = new string[] { "LotNo", "차종", "형번", txtItemCode.Text, txtItemName.Text, "완제품", txtBoxCap.Text, "B-#1", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "12345678901234567890asdfg" };
                lp.print("사상", vals, breprint);//주조,사상
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        // 밸브바디 사상 작업완료. 그냥 중간 거쳐가는 단계임.
        private void DoSave_Valve()
        {
            //수량 체크.
            //양품이 없는지, 양품+불량>lot수량 인지. 등등을 체크해야한다..?
            if (Convert.ToDecimal(txtGoodQty.Text) < 1)
            {
                SetMessage("양품수량은 0보다 큰수만 가능합니다.");
                return;
            }
            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            //이미 작업이 완료된 건인지 - 밸브바디 사상장
            DataTable tbValveDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0815 where LotNO = '" + txtLotNo.Text + "'").Tables[0];
            int ValveDoneQty = Convert.ToInt16(tbValveDone.Rows[0]["QTY"].ToString());

            if (ValveDoneQty != 0)
            {
                SetMessage("이미 사상 작업완료가 수행된 LOT번호입니다.");
                return;
            }

            //이미 작업이 완료된 건인지 - 사상(완료공정기준)
            DataTable tbDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 where PrevLOTNO = '" + txtLotNo.Text + "'").Tables[0];
            int DoneQty = Convert.ToInt16(tbDone.Rows[0]["QTY"].ToString());

            if (DoneQty != 0)
            {
                SetMessage("이미 사상 작업완료가 수행된 LOT번호입니다.");
                return;
            }

            try
            {
                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0570_I2");

                WorkCenter wc = Common.SelectedWorkCenter;

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pLOTNO", txtLotNo.Text));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text));
                cmd.Parameters.Add(new SqlParameter("@pLotQty", txtLotQty.Text));
                cmd.Parameters.Add(new SqlParameter("@GoodQty", txtGoodQty.Text));
                cmd.Parameters.Add(new SqlParameter("@BadQty", txtBadQty.Text));

                clsDB.gExecute(conn, cmd);

                clsDB.Commit();

                SetMessage("정상적으로 등록되었습니다.");
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

        // 완료공정기준 사상 작업완료.
        private void DoSave()
        {
            //수량 체크.
            //양품이 없는지, 양품+불량>lot수량 인지. 등등을 체크해야한다..?
            if (Convert.ToDecimal(txtGoodQty.Text) < 1)
            {
                SetMessage("양품수량은 0보다 큰수만 가능합니다");
                return;
            }

            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            try
            {
                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0570_I1");

                WorkCenter wc = Common.SelectedWorkCenter;

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterName", wc.Name));
                cmd.Parameters.Add(new SqlParameter("@pLOTNO", txtLotNo.Text));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pQty", txtLotQty.Text.Replace(",", "")));
                cmd.Parameters.Add(new SqlParameter("@pGoodQty", txtGoodQty.Text.Replace(",", "")));
                cmd.Parameters.Add(new SqlParameter("@pBadQty", txtBadQty.Text.Replace(",", "")));

                int ireturn = clsDB.gExecute(conn, cmd);

                if (ireturn == -1)
                //if (!clsDB.gExecuteProcedure(conn, cmd))
                {
                    clsDB.Rollback();
                    SetMessage("작업중 오류가 발생했습니다.");
                }
                else
                {
                    // 외주가공의 경우, 같은 LOT가 계속들어오기 때문에 10초 이내에 등록된게 있는지만 체크..
                    DataTable tbDone2 = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 (nolock) where DATEDIFF(S, MakeDate, GETDATE()) < 10 AND PrevLOTNO = '" + txtLotNo.Text + "'").Tables[0];
                    int DoneQty2 = Convert.ToInt16(tbDone2.Rows[0]["QTY"].ToString());

                    // 외주입고의 경우 같은로트로 연속해서 출력하는 경우가 있다..스캔하고 작업완료, 스캔하고 작업완료...이런식으로.. (!= 1) 로 하면 2가 나오는 경우가..있음.
                    // 처음 한번 넘어갔다는것은 PROCESS에 문제가 없다는 뜻이므로..COUNT가 2여도 작업이 된다는 뜻..
                    if (DoneQty2 == 0)
                    {
                        clsDB.Rollback();
                        SetMessage("작업중 오류가 발생했습니다.");
                    }
                    else
                    {
                        clsDB.Commit();
                        SetMessage("정상적으로 등록되었습니다.");

                        //if (Common.GetIPAddress() == "192.168.230.56")
                        //{
                        //    if (SelectedItem == "45231-23145-20" ||
                        //        SelectedItem == "45231-P23000-20" ||
                        //        SelectedItem == "43115-02710-20" ||
                        //        SelectedItem == "43115-02700-20" ||
                        //        SelectedItem == "43115-3D113-20" ||
                        //        SelectedItem == "43115-3D141-20" ||
                        //        SelectedItem == "43115-3D131-20" ||
                        //        SelectedItem == "43111-3D110-20" ||
                        //        SelectedItem == "43111-2D000-20" ||
                        //        SelectedItem == "43111-2C001-20" ||
                        //        SelectedItem == "43111-2B000-20" ||
                        //        SelectedItem == "43111-2B001-20" ||
                        //        SelectedItem == "43115-2D200-20" ||
                        //        SelectedItem == "43115-2D110-20" ||
                        //        SelectedItem == "43115-2D100-20" ||
                        //        SelectedItem == "43115-2D000-20" ||
                        //        SelectedItem == "43115-2D010-20" ||
                        //        SelectedItem == "43115-2C001-20" ||
                        //        SelectedItem == "43115-2C010-20" ||
                        //        SelectedItem == "43115-2B000-20" ||
                        //        SelectedItem == "43115-2B001-20")
                        //    {
                        //        LabelReport labelReport = new LabelReport();
                        //        labelReport.Priting(txtLotNo.Text);
                        //    }
                        //    else
                        //    {
                        //        ReDSLabelPrint(txtLotNo.Text);
                        //    }
                        //}
                        //else
                        //{
                        ReDSLabelPrint(txtLotNo.Text);
                        //}

                        //ERP Lot 이동
                        //2018.03.07 자동 이동처리 되는 로직 주석처리(실적발생시 인출 후 같은 자재가 이동처리됨)
                        //try
                        //{
                        //    cmd = (SqlCommand)db.GetStoredProcCommand(Common.sERPDB+ ".DBO.USP_POP_SK163");
                        //    cmd.Connection = conn;
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.Add(new SqlParameter("@lot_control_no", txtLotNo.Text.Trim()));
                        //    cmd.Parameters.Add(new SqlParameter("@qty_move", Convert.ToInt32(txtGoodQty.Text) + Convert.ToInt32(txtBadQty.Text)));
                        //    cmd.Parameters.Add(new SqlParameter("@workcenter", wc.Code));
                        //    cmd.Parameters.Add(new SqlParameter("@user_id", "MES_TM"));
                        //    cmd.Parameters.Add(new SqlParameter("@err_code", 0));
                        //    cmd.Parameters.Add(new SqlParameter("@err_msg_out", ""));
                        //    cmd.Parameters[4].Direction = ParameterDirection.Output;
                        //    cmd.Parameters[5].Direction = ParameterDirection.Output;
                        //    db.ExecuteNonQuery(cmd);
                        //}
                        //catch { }

                    }
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
        }

        //Lot초기화
        private void DoClear()
        {
            txtGoodQty.Text = "0";
            txtBadQty.Text = "0";
            txtLotQty.Text = "0";
            txtDoneQty.Text = "0";
            txtCarType.Text = "";
            txtItemCode.Text = "";
            txtItemName.Text = "";
        }

        //LOT번호 클릭시 초기화
        private void txtLotNo_Click(object sender, EventArgs e)
        {
            txtLotNo.Text = "";
            DoClear();
        }

        private void bBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
