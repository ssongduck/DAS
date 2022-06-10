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
    public partial class DA5000 : BaseForm
    {
        #region 멤버변수
        bool bSet = false;

        private int iSelRow;

        private int iSecond = 0;
        private int iTarSecond = 10;

        //private DataTable dtItemlist = null;

        public bool bSetWorkCenter
        { set { bSet = value; } }
        #endregion

        public DA5000()
        {
            InitializeComponent();
        }

        private void DA5000_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            SetButtons();

            SetGrid();

            init();     //초기화

            SetLblMessageClear();

            iSelRow = -1;

            EventTimerEnable = true;

            sptWeight.Open();   //
        }

        private void SetButtons()
        {
            bBox1.CountX = 6;
            bBox1.CountY = 1;

            bBox1.SetButtons();

            // 지시선택, 작업자, 가동, 불량등록, 작업현황, 가동현황, 투입LOT, 입고등록(부품식별표 발행)
            // , 설비고장, 자주검사, 일상점검, 종료
            bBox1[0, 0].Text = "작업자선택";
            bBox1[0, 0].Tag = "Worker";

            bBox1[0, 1].Text = "";
            bBox1[0, 1].Tag = "";
            bBox1[0, 1].UseFlag = false;

            bBox1[0, 2].Text = "";
            bBox1[0, 2].Tag = "";
            bBox1[0, 2].UseFlag = false;

            bBox1[0, 3].Text = "";
            bBox1[0, 3].Tag = "";
            bBox1[0, 3].UseFlag = false;

            bBox1[0, 4].Text = "";
            bBox1[0, 4].Tag = "";
            bBox1[0, 4].UseFlag = false;

            bBox1[0, 5].Text = "작업현황";
            bBox1[0, 5].Tag = "State";

            bBox1.RedrawButtons();
        }

        private void SetGrid()
        {
            Grid1.CountRows = 2;

            Grid1.SelectProcedureName = "[USP_DA5000_S1]";
            Grid1.GetStoreProcedure();
            Grid1.ParameterList.Add(new SqlParameter("@pIP", Common.gsIP));
        }

        private void init()
        {
            txtWorkCenterCode.Text = "";
            txtWorkCenterName.Text = "";
            txtWorkerCnt.Text = "0";
            txtWorkerNames.Text = "";
                
            txtFurnanceTemp.Text = "";

            txtIngotQty.Text = "0";
            txtScrapQty.Text = "0";
        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

        protected override void EventTimer_Tick(object sender, EventArgs e)
        {
            if (bSet && iSecond++ < iTarSecond)
                return;

            iSecond = 0;

            this.Cursor = Cursors.Default;

            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }
            
            try
            {
                //// sWorkCenterCode 임시저장
                //string sWorkCenterCode = string.Empty;
                //if (Common.SelectedWorkCenter != null)
                //    sWorkCenterCode = Common.SelectedWorkCenter.Code;

                DoFind();

                if (Grid1.Rows.Count == 0)  // 작업장이 설정되지 않았을 경우
                {
                    iSelRow = -1;
                    Common.SelectedWorkCenter = null;

                    init();
                }
                else
                {
                    if (iSelRow == -1)
                        iSelRow = 0;

                    Grid1.Rows[iSelRow].Selected = true;
                    Grid1_GridClick(Grid1, new MESGrid.GridClickEventArg(Grid1.Rows[iSelRow].Cells[0]));
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
            Grid1.DoFind();

            Common.gListWorkCenter.Clear();

            if (Grid1.DataSource == null)
                return;
            

            Common.gListWorkCenter.Clear(); 
            //foreach (DataRow dr in Grid1.DataSource.Rows)
            //{
                

                WorkCenter wc = new WorkCenter();

                wc.PlantCode = clsDB.nvlString(Grid1.DataSource.Rows[0]["PlantCode"]);
                wc.Code = clsDB.nvlString(Grid1.DataSource.Rows[0]["WorkCenterCode"]);
                wc.Name = clsDB.nvlString(Grid1.DataSource.Rows[0]["WorkCenterName"]);
                wc.FurnanceTemp = clsDB.nvlString(Grid1.DataSource.Rows[0]["FurnanceTemp"]);

                Common.gListWorkCenter.Add(wc);

                SetWorkerList(wc);

                wc.ClearHash();
            //}

            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtFurnanceTemp.Text = wc.FurnanceTemp;
            txtWorkerCnt.Text = wc.GetWorkerList(Common.ListWorkerType.SELECT).WorkerCount.ToString();
            txtWorkerNames.Text = wc.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName;

            Common.SelectedWorkCenter = wc;

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

        // 그리드 클릭 이벤트
        private void Grid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if ((e._UltraGridRow != null) && (e._UltraGridRow.Index >= 0))
                iSelRow = e._UltraGridRow.Index;

            Grid1.Row = Grid1.Rows[iSelRow];

            splitContainer2.Panel1.Enabled = Grid1.Row.Cells["DIVISION"].Value.ToString() == "INGOT";
            splitContainer2.Panel2.Enabled = !splitContainer2.Panel1.Enabled;

            if (Grid1.Row.Cells["DIVISION"].Value.ToString() == "INGOT")
                if (sptWeight.IsOpen) sptWeight.Close();
            else
                if (!sptWeight.IsOpen) sptWeight.Open();
        }

        private void bBox1_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (!this._bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            try
            {
                MESButton btn = sender;
                WorkCenter wc = Common.SelectedWorkCenter;
                
                switch (btn.Tag.ToString())
                {
                    case "Worker":  // 작업자
                        DA0200 da0200 = new DA0200();
                        ShowDialogForm(da0200);
                        SetLblMessageClear();

                        SetWorkerList(wc);    //
                        break;

                    case "State":
                        // 작업현황
                        DA5100 da5100 = new DA5100();
                        ShowDialogForm(da5100);
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

        #region 버튼 클릭 이벤트

        private void DA5000_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngotReset_Click(object sender, EventArgs e)
        {
            txtIngotQty.Text = "0";
        }

        private void btnScrapReset_Click(object sender, EventArgs e)
        {
            txtScrapQty.Text = "0";
        }

        private void btnIngotUp_Click(object sender, EventArgs e)
        {
            txtIngotQty.Text = (clsDB.nvlInt(txtIngotQty.Text) + 1).ToString();
        }

        private void btnIngotDown_Click(object sender, EventArgs e)
        {
            txtIngotQty.Text = txtIngotQty.Text == "0" ? "0" : (clsDB.nvlInt(txtIngotQty.Text) - 1).ToString();
        }

        private void txtIngotQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "팔레트 수량 입력";
            d.LabelHeader = "팔레트 수량";

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtIngotQty.Text = d.ResultString;
            }
        }

        private void txtScrapQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "스크랩 중량 입력";
            d.LabelHeader = "스크랩 중량";

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtScrapQty.Text = d.ResultString;
            }
        } 
        #endregion

        private void btnIngotInput_Click(object sender, EventArgs e)
        {
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            if (Grid1.Row == null)
            {
                SetMessage("작업지시를 선택하세요.");
                return;
            }
            if ((string.IsNullOrEmpty(txtIngotQty.Text)) || (txtIngotQty.Text == "0"))
            {
                SetMessage("팔레트 수량을 입력하세요.");
                return;
            }

            DoProgress();
            try
            {
                DataTable dt = new DataTable();

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA5000_I1");
                cmd.Connection = conn;

                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                cmd.Parameters.Add(new SqlParameter("@pOrderNo", Grid1.Row.Cells["PlanNo"].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", Grid1.Row.Cells["ItemCode"].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pQty", txtIngotQty.Text));
                cmd.Parameters.Add(new SqlParameter("@cInputFlag", 'I'));

                if (clsDB.gExecuteProcedure(conn, cmd))
                {
                    SetMessage("정상적으로 등록되었습니다.");
                    txtIngotQty.Text = "0";
                }
                else
                {
                    SetMessage(clsDB.ErrorDesc);
                    return;

                }
            }
            catch (Exception e1)
            {
                SetMessage(e1.Message);
            }
            finally
            {
                CloseProgressForm();

                iSecond = iTarSecond;
                EventTimer_Tick(this, new EventArgs());
            }
        }

        private void btnScrapInput_Click(object sender, EventArgs e)
        {
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                return;
            }

            if (Grid1.Row == null)
            {
                SetMessage("작업지시를 선택하세요.");
                return;
            }
            if ((string.IsNullOrEmpty(txtScrapQty.Text)) || (clsDB.nvlDouble(txtScrapQty.Text) <= 0))
            {
                SetMessage("스크랩 중량을 확인하세요.");
                return;
            }

            DoProgress();
            try
            {
                DataTable dt = new DataTable();

                Database db;
                db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA5100_I1");
                cmd.Connection = conn;

                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                cmd.Parameters.Add(new SqlParameter("@pOrderNo", Grid1.Row.Cells["PlanNo"].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pItemCode", Grid1.Row.Cells["ItemCode"].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pQty", txtScrapQty.Text));
                cmd.Parameters.Add(new SqlParameter("@cInputFlag", 'S'));

                if (clsDB.gExecuteProcedure(conn, cmd))
                {
                    SetMessage("정상적으로 등록되었습니다.");
                    //txtScrapQty.Text = "0";
                }
                else
                {
                    SetMessage(clsDB.ErrorDesc);
                    return;

                }
            }
            catch (Exception e1)
            {
                SetMessage(e1.Message);
            }
            finally
            {
                CloseProgressForm();

                iSecond = iTarSecond;
                EventTimer_Tick(this, new EventArgs());
            }
        }

        private void sptWeight_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string sWeight = string.Empty;
            int iIndex;

            try
            {
                if ((Grid1.Row == null) || (Grid1.Row.Cells["DIVISION"].Value.ToString() == "INGOT"))
                {
                    System.Threading.Thread.Sleep(100);
                    sptWeight.ReadExisting();
                    return;
                }

                System.Threading.Thread.Sleep(100);

                sWeight = sptWeight.ReadExisting();
                iIndex = sWeight.IndexOf('k');

                //if (sWeight[0] == 'S' || sWeight[0] == 'U' )
                    txtScrapQty.Text = sWeight.Substring(iIndex - 7, 7).Trim();
                //else
                //    txtScrapQty.Text = sWeight.Substring(iIndex - 8, 8).Trim();

                btnScrapInput_Click(null, null);
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(sWeight))
                    SetMessage(ex.ToString());
                else SetMessage(sWeight);
            }
        }
    }
}
