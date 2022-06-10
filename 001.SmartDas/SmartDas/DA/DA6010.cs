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
    public partial class DA6010 : BaseForm
    {
        #region 멤버변수
        bool bSet = false;

        private int iSelRow;

        private int iSecond = 0;
        private int iTarSecond = 0;

        private DataTable Dtchk = new DataTable();

        public bool bSetWorkCenter
        { set { bSet = value; } }
        #endregion

        public DA6010()
        {
            InitializeComponent();
        }

        private void DA6010_Load(object sender, EventArgs e)
        {
            this.SyncTime = true;

            SetButtons();

            init();     //초기화

            SetGrid();
 
            //SetLblMessageClear();

            iSelRow = -1;

            EventTimerEnable = true;
           
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            btnConfBox[0, 0].Tag = "";
            btnConfBox[0, 1].Text = "현황";
            btnConfBox[0, 2].Text = "없음";
            btnConfBox[0, 2].UseFlag = false;
            btnConfBox[0, 2].Tag = "D";

            btnConfBox.RedrawButtons();

        
        }

        private void SetGrid()
        {
            Grid1.FontSize = 16;
            Grid1.SelectProcedureName = "USP_DA6010_MAIN";
            
            mesGrid1.FontSize = 16;
            mesGrid1.SelectProcedureName = "USP_DA6010_MAIN";


        }

        

        private void init()
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

            txtForkliftCode.Text = wc.Code;
            txtForkliftName.Text = wc.Name;

            // txtLadleCode.Text = clsDB.nvlString(Grid1.DataSource.Rows[0]["LADLECODE"]);
            // txtLadleName.Text = clsDB.nvlString(Grid1.DataSource.Rows[0]["LADLENAME"]);

            Common.gListWorkCenter.Add(wc);

            SetWorkerList(wc);

            wc.ClearHash();
            //}




            Common.SelectedWorkCenter = wc;
        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

      
        /// 작업장 정보 조회
        private void DoFind()
        {
           
            WorkCenter wc = Common.SelectedWorkCenter;
            Grid1.GetStoreProcedure();

            Grid1.ParameterList.Add(new SqlParameter("@IN_PLANTCODE", wc.PlantCode));

            Grid1.DoFind();

            if (Grid1.DataSource.Rows.Count != Dtchk.Rows.Count)
            {
                mesGrid1.GetStoreProcedure();
                mesGrid1.ParameterList.Add(new SqlParameter("@IN_PLANTCODE", wc.PlantCode));
                mesGrid1.DoFind();

                if (mesGrid1.Rows.Count > 0)
                {
                    txtWorkCenterCode.Text = mesGrid1.Rows[0].Cells["WORKCENTERCODE"].Value.ToString();
                    txtWorkCenterName.Text = mesGrid1.Rows[0].Cells["WORKCENTERNAME"].Value.ToString();
                    txtRequestTime.Text = mesGrid1.Rows[0].Cells["STARTDATE"].Value.ToString();
                    txtmItemname.Text = mesGrid1.Rows[0].Cells["MITEMNMAME"].Value.ToString();
                    txtpitemname.Text = mesGrid1.Rows[0].Cells["ITEMNAME"].Value.ToString();
                    txtDISSStatus.Text = mesGrid1.Rows[0].Cells["DISSNAME"].Value.ToString();
                    txtDISSCODE.Text = mesGrid1.Rows[0].Cells["DISSSTATUS"].Value.ToString();
                    txtpitemcode.Text = mesGrid1.Rows[0].Cells["ITEMCODE"].Value.ToString();
                    txtmItemcode.Text = mesGrid1.Rows[0].Cells["MITEMCODE"].Value.ToString();
                    txtRequest.Text = mesGrid1.Rows[0].Cells["REQUESTSTARTDATE"].Value.ToString();


                }
                else
                {
                    txtWorkCenterCode.Text = "";
                    txtWorkCenterName.Text = "";
                    txtRequestTime.Text = "";
                    txtmItemname.Text = "";
                    txtpitemname.Text = "";
                    txtDISSStatus.Text = "";
                    txtDISSCODE.Text = "";
                    txtpitemcode.Text = "";
                    txtmItemcode.Text = "";
                    txtRequest.Text = "";
                }
            }
            else
            {
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (Dtchk.Rows[i]["DissStatus"].ToString() != Grid1.Rows[i].Cells["DissStatus"].Value.ToString())
                    {
                        mesGrid1.GetStoreProcedure();
                        mesGrid1.ParameterList.Add(new SqlParameter("@IN_PLANTCODE", wc.PlantCode));
                        mesGrid1.DoFind();

                        if (mesGrid1.Rows.Count > 0)
                        {
                            txtWorkCenterCode.Text = mesGrid1.Rows[0].Cells["WORKCENTERCODE"].Value.ToString();
                            txtWorkCenterName.Text = mesGrid1.Rows[0].Cells["WORKCENTERNAME"].Value.ToString();
                            txtRequestTime.Text = mesGrid1.Rows[0].Cells["STARTDATE"].Value.ToString();
                            txtmItemname.Text = mesGrid1.Rows[0].Cells["MITEMNMAME"].Value.ToString();
                            txtpitemname.Text = mesGrid1.Rows[0].Cells["ITEMNAME"].Value.ToString();
                            txtDISSStatus.Text = mesGrid1.Rows[0].Cells["DISSNAME"].Value.ToString();
                            txtDISSCODE.Text = mesGrid1.Rows[0].Cells["DISSSTATUS"].Value.ToString();
                            txtpitemcode.Text = mesGrid1.Rows[0].Cells["ITEMCODE"].Value.ToString();
                            txtmItemcode.Text = mesGrid1.Rows[0].Cells["MITEMCODE"].Value.ToString();
                            txtRequest.Text = mesGrid1.Rows[0].Cells["REQUESTSTARTDATE"].Value.ToString();
                        }

                    }
                }
            }


                Dtchk = Grid1.DataSource;

          if(txtDISSCODE.Text.Trim() == "N")
          {
            btnConfBox[0, 0].Text = "요청확인";
            btnConfBox[0, 0].Tag = "H";
            
            btnConfBox.RedrawButtons();
          }
          else if (txtDISSCODE.Text.Trim() == "H")
          {
              btnConfBox[0, 0].Text = "보급완료";
              btnConfBox[0, 0].Tag = "S";

             btnConfBox[0, 2].UseFlag = true;

              btnConfBox.RedrawButtons();
          }
          else
          {
              btnConfBox[0, 0].Text = "조회";
              btnConfBox[0, 0].Tag = " ";

              btnConfBox.RedrawButtons();
          }


            


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

      
        /// 버튼 상태 변경
        private void SetButtonStatus()
        {
            if (Common.SelectedWorkCenter == null)
                return;

            WorkCenter wc = Common.SelectedWorkCenter;

            try
            {
         

            

               
            }
            catch (Exception e)
            {
                SetMessage(e.Message);
            }

        }

        private void bBox1_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
       
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

        private void DA6010_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.ClearSendProcess();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            int count = e._UltraGridRow.Index;

            txtWorkCenterCode.Text =  mesGrid1.Rows[count].Cells["WORKCENTERCODE"].Value.ToString();
            txtWorkCenterName.Text =  mesGrid1.Rows[count].Cells["WORKCENTERNAME"].Value.ToString();
            txtRequestTime.Text = mesGrid1.Rows[count].Cells["STARTDATE"].Value.ToString();
            txtmItemname.Text = mesGrid1.Rows[count].Cells["MITEMNMAME"].Value.ToString();
            txtpitemname.Text = mesGrid1.Rows[count].Cells["ITEMNAME"].Value.ToString();
            txtDISSStatus.Text = mesGrid1.Rows[count].Cells["DISSNAME"].Value.ToString();
            txtDISSCODE.Text = mesGrid1.Rows[count].Cells["DISSSTATUS"].Value.ToString();
            txtRequest.Text = mesGrid1.Rows[count].Cells["REQUESTSTARTDATE"].Value.ToString();
            

            txtpitemcode.Text = mesGrid1.Rows[count].Cells["ITEMCODE"].Value.ToString();
            txtmItemcode.Text = mesGrid1.Rows[count].Cells["MITEMCODE"].Value.ToString();

            if (txtDISSCODE.Text.Trim() == "N")
            {
                btnConfBox[0, 0].Text = "요청확인";
                btnConfBox[0, 0].Tag = "H";

                btnConfBox.RedrawButtons();
            }
            else if (txtDISSCODE.Text.Trim() == "H")
            {
                btnConfBox[0, 0].Text = "보급 완료";
                btnConfBox[0, 0].Tag = "S";

                btnConfBox.RedrawButtons();
            }
            else
            {
                btnConfBox[0, 0].Text = "조회";
                btnConfBox[0, 0].Tag = " ";

                btnConfBox.RedrawButtons();
            }

        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {


            if (sender.Text == "현황")
            {
                DA6200 da6200 = new DA6200();
                ShowDialogForm(da6200);
                SetLblMessageClear();
            }
            else
            {
                try
                {
                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }

                    Database db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "USP_DA6010_I1";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pRequestTime", txtRequestTime.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@RequestWorkerID", txtForkliftCode.Text.Trim()));

                    cmd.Parameters.Add(new SqlParameter("@Stauts", sender.Tag));



                    if (clsDB.gExecute(conn, cmd) < 0)
                    {
                        // 오류 발생시
                        //SetMessage(clsDB.ErrorDesc);
                        return;
                    }
                    else
                    {
                        DoFind();
                        //if (btnOK.Tag.ToString() == "S")
                        //{
                        //   // BaseForm.("보급이 완료 되었습니다");
                        //    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        //}
                    }
                }
                catch (Exception oe)
                {
                    // SetMessage(oe.Message);
                    clsDB.Rollback();
                }
            }
        }
    }
}
