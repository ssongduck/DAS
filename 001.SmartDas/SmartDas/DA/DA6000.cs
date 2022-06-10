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
using System.Data.Common;
using Infragistics.Win.UltraWinGrid;
using System.IO.Ports;
using System.Linq;

namespace SmartDas
{
    public partial class DA6000 : BaseForm
    {
        #region 멤버변수
        bool bSet = false;

        private int iSelRow;

        private int iSecond = 0;
        private int iTarSecond = 5000;

        private DataTable dtItemlist = null;

        SerialPort _SerialPort;

        bool bFlag = false;

        public bool bSetWorkCenter
        { set { bSet = value; } }
        #endregion

        public DA6000()
        {
            InitializeComponent();

            try
            {
                if (null == _SerialPort)
                {
                    _SerialPort = new SerialPort();
                    _SerialPort.PortName = "COM3";
                    _SerialPort.BaudRate = Convert.ToInt32("115200");
                    _SerialPort.DataBits = (int)8;
                    _SerialPort.Parity = Parity.None;
                    _SerialPort.StopBits = StopBits.One;
                    _SerialPort.ReadTimeout = (int)500;
                    _SerialPort.WriteTimeout = (int)500;
                    _SerialPort.Open();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void DA6000_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            SetButtons();

            SetGrid();

            init();     //초기화

            //SetLblMessageClear();

            iSelRow = -1;

           EventTimerEnable = true;
           if (Common.gsPlantCode == "SK2")
           {
               btnLiquidTrans.Enabled = false;
           }
        }

        private void SetButtons()
        {
            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "요청";
            btnConfBox[0, 0].Tag = "Y";
            btnConfBox[0, 0].UseFlag = false;

            btnConfBox[0, 1].Text = "현황";
            btnConfBox[0, 1].Tag = "N";

            btnConfBox.RedrawButtons();

            bBox1.SetButtons();

            bBox1.SelectProcedureName = "USP_DA6000_MAIN";

            bBox1.SetStoreProc();

            // 조회
            bBox1.ParameterList.Add(new SqlParameter("IN_IP", Common.gsIP));
            bBox1.ParameterList.Add(new SqlParameter("IN_PLANTCODE", Common.gsPlantCode));
            bBox1.ParameterList.Add(new SqlParameter("WORKCENTERCODE",""));

            //bBox1.ExTag = btnSelect.GetSelectedButtons()[0].Text;
            bBox1.DoFind();

            bBox1.RedrawButtons();
        }

        private void SetGrid()
        {
            Grid1.CountRows = 2;

            Grid1.SelectProcedureName = "[USP_DA6000_MAIN_D]";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));

            Grid1.DoFind();

            Common.gListWorkCenter.Clear();

            if (Grid1.DataSource == null)
                return;


            Common.gListWorkCenter.Clear(); //  

            WorkCenter wc = new WorkCenter();

            wc.PlantCode = clsDB.nvlString(Grid1.DataSource.Rows[0]["PLANTCODE"]);
            wc.Code = clsDB.nvlString(Grid1.DataSource.Rows[0]["WORKCENTERCODE"]);
            wc.Name = clsDB.nvlString(Grid1.DataSource.Rows[0]["WORKCENTERNAME"]);
            txtLadleCode.Text = clsDB.nvlString(Grid1.DataSource.Rows[0]["LADLECODE"]);
            txtLadleName.Text = clsDB.nvlString(Grid1.DataSource.Rows[0]["LADLENAME"]);

            Common.gListWorkCenter.Add(wc);

            SetWorkerList(wc);

            wc.ClearHash();
            //}

            txtForkliftCode.Text = wc.Code;
            txtForkliftName.Text = wc.Name;
            
            
            Common.SelectedWorkCenter = wc;

            //bSet = true;
        }

        private void init()
        {

            if (Common.SelectedWorkCenter == null)
            {
                txtWorkCenterCode.Text = "";
                txtWorkCenterName.Text = "";

            }
            else
            {
                WorkCenter wc = Common.SelectedWorkCenter;
                txtForkliftCode.Text = wc.Code;
                txtForkliftName.Text = wc.Name;
            }
        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            //if (bSet && iSecond++ < iTarSecond)
            //{
            //    if (Common.SelectedWorkCenter != null)
            //        SetButtonStatus();
            //    return;
            //}

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

            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "USP_DA6000_MAIN";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("IN_IP", Common.gsIP));
            cmd.Parameters.Add(new SqlParameter("IN_PLANTCODE", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("WORKCENTERCODE", ""));
            

            DataTable dt = new DataTable();

            clsDB.gCreateRSet(conn, cmd, dt);

            int sRowno = dt.Rows.Count;

            for (int a = 0; a < sRowno; a++)
            {
                if (dt.Rows[a]["DISSSTATUS"].ToString() == "N")
                {
                    bBox1.GetButtonByTag(dt.Rows[a]["WORKCENTERCODE"].ToString()).bAlarm = true;
                }
                else if (dt.Rows[a]["DISSSTATUS"].ToString() == "H")
                {
                    bBox1.GetButtonByTag(dt.Rows[a]["WORKCENTERCODE"].ToString()).bAlarm = false;
                    bBox1.GetButtonByTag(dt.Rows[a]["WORKCENTERCODE"].ToString()).ButtonPressed = true;
                    
                }
                else
                {
                    bBox1.GetButtonByTag(dt.Rows[a]["WORKCENTERCODE"].ToString()).bAlarm = false;
                    bBox1.GetButtonByTag(dt.Rows[a]["WORKCENTERCODE"].ToString()).ButtonPressed = false;
                }
            }

            if (_SerialPort != null && _SerialPort.IsOpen)
            {
                int iCnt = 0;

                iCnt = dt.AsEnumerable().Where(t => t.Field<string>("DISSSTATUS") != string.Empty).Count();

                if (iCnt > 0)
                {
                    OnLightSound();
                }
                else
                {
                    OffSiren();
                }
            }

            bBox1.RedrawButtons();  
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

            WorkCenter wc = Common.GetWorkCenter(clsDB.nvlString(e._UltraGridRow.Cells["WorkcenterCode"].Value));

            Common.SelectedWorkCenter = wc;

            wc.ClearHash();

            init();

           
        }

        /// 버튼 상태 변경
      

        private void bBox1_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {

            txtWorkCenterCode.Text = sender.Tag.ToString();
            txtWorkCenterName.Text = sender.Text;

            txtRequestTime.Text = "";
            txtRemainRate.Text = "";
            txtRequest.Text = "";
            txtDISSStatus.Text = "";


            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA6000_MAIN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("IN_IP", Common.gsIP));
                cmd.Parameters.Add(new SqlParameter("IN_PLANTCODE", Common.gsPlantCode));
                cmd.Parameters.Add(new SqlParameter("WORKCENTERCODE", sender.Tag));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);

                if (dt.Rows.Count >= 1)
                {
                    txtRequestTime.Text = dt.Rows[0]["STARTDATE"].ToString();
                    txtRemainRate.Text = dt.Rows[0]["RESTQTY"].ToString();
                    txtRequest.Text = dt.Rows[0]["REQUESTSTARTDATE"].ToString();
                    txtDISSStatus.Text = dt.Rows[0]["DISSSTATUSNAME"].ToString();


                    if (dt.Rows[0]["DISSSTATUS"].ToString() == "N")
                    {
                        if (txtLadleCode.Text.Trim() == "")
                        {
                            MessageBoxShow("래더를 장착한 후에 보급을 진행하여 주십시오");
                            return;
                        }

                        btnConfBox[0, 0].UseFlag = false;
                        btnConfBox.RedrawButtons();

                        DA9700 da9700 = new DA9700();
                        da9700.dWorkcentercode = txtWorkCenterCode.Text;
                        da9700.dWorkcentername = txtWorkCenterName.Text;
                        da9700.dLadlecode = txtLadleCode.Text;
                        da9700.dLadlename = txtLadleName.Text;
                        da9700.ForkliftCode = txtForkliftCode.Text;
                        ShowDialogForm(da9700);
                    }

                    else
                    {
                        btnConfBox[0, 0].UseFlag = true;
                        btnConfBox.RedrawButtons();

                    }

                    if (dt.Rows[0]["DISSSTATUS"].ToString() == "H")
                    {
                        if (txtLadleCode.Text.Trim() == "")
                        {
                            MessageBoxShow("래더를 장착한 후에 보급을 진행하여 주십시오");
                            return;
                        }


                        DA9700 da9700 = new DA9700();
                        da9700.dWorkcentercode = txtWorkCenterCode.Text;
                        da9700.dWorkcentername = txtWorkCenterName.Text;
                        da9700.dLadlecode = txtLadleCode.Text;
                        da9700.dLadlename = txtLadleName.Text;
                        da9700.ForkliftCode = txtForkliftCode.Text;
                        ShowDialogForm(da9700);
                    }


                }



            }
            catch (SqlException e2)
            {
                SetMessage(e2.Message);
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

        private void DA6000_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            EventTimerEnable = false;
            Application.Exit();
        }


        private void txtLadleCode_Click(object sender, EventArgs e)
        {
           
            DA9800 d1 = new DA9800();
            d1.ForkliftCode = txtForkliftCode.Text;
            
            if (DialogResult.OK == ShowDialogForm(d1))
            {
                if (d1.resultArray != null)
                {
                    if (d1.resultArray.Length == 2)
                    {
                        txtLadleCode.Text = d1.resultArray[0];
                        txtLadleName.Text = d1.resultArray[1];
                        
                        DoFind();
                    }
                }
            }
          
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (sender.Tag.ToString() == "N")
            {
                DA6100 da6100 = new DA6100();
                ShowDialogForm(da6100);
                SetLblMessageClear();
            }
            else
            {
                try
                {
                    Database db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "USP_DA4100_I1";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text.Trim()));

                    cmd.Parameters.Add(new SqlParameter("@pStatus", "N"));
                    cmd.Parameters.Add(new SqlParameter("@pResqty", txtRemainRate.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pPlantno", ""));


                    if (clsDB.gExecute(conn, cmd) < 0)
                    {
                        // 오류 발생시
                        SetMessage(clsDB.ErrorDesc);
                        return;
                    }
                }
                catch
                {
                }
                finally
                {
                    btnConfBox[0, 0].UseFlag = false;
;
                    btnConfBox.RedrawButtons();
                }
            }
        }

        private void btnLiquidTrans_Click(object sender, EventArgs e)
        {
            ShowDialogForm(new DA6020());
        }

        /// <summary>
        /// On light sound 
        /// </summary>
        private void OnLightSound()
        {
            if (!bFlag)
            {
                lock (this)
                {
                    bFlag = true;
                }

                byte[] byteSendData = new byte[9];

                // 1. SOF
                byteSendData[0] = 0x02;

                // 2. TT_CMD: 0x51 은 ASCII로 0x35, 0x31
                byteSendData[1] = 0x35;     // '5'
                byteSendData[2] = 0x31;     // '1'

                // 3. EXT: 0x80 는 ASCII로 0x38, 0x30
                byteSendData[3] = 0x38;     // '8'
                byteSendData[4] = 0x30;     // '0'

                // 4. LS: 0x99 는 ASCII로 0x39, 0x39
                byteSendData[5] = 0x39;     // '8'
                byteSendData[6] = 0x42;     // 'A'

                // 5. EOF
                byteSendData[7] = 0x03;
                byteSendData[8] = 0x0A;

                _SerialPort.Write(byteSendData, 0, 9);
            }
        }

        /// <summary>
        /// Off light & sound siren
        /// </summary>
        private void OffSiren()
        {
            if (bFlag)
            {
                lock (this)
                {
                    bFlag = false;
                }

                byte[] byteSendData = new byte[9];

                // 1. SOF
                byteSendData[0] = 0x02;

                // 2. TT_CMD: 0x51 은 ASCII로 0x35, 0x31
                byteSendData[1] = 0x35;     // '5'
                byteSendData[2] = 0x31;     // '1'

                // 3. EXT: 0x80 는 ASCII로 0x38, 0x30
                byteSendData[3] = 0x38;     // '8'
                byteSendData[4] = 0x30;     // '0'

                // 4. LS: 0x88 는 ASCII로 0x38, 0x38
                byteSendData[5] = 0x38;     // '8'
                byteSendData[6] = 0x38;     // '8'

                // 5. EOF
                byteSendData[7] = 0x03;
                byteSendData[8] = 0x0A;

                _SerialPort.Write(byteSendData, 0, 9);
            }
        }
    }
}
