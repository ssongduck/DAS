using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SmartDas.POPUP;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using SmartDas.Components;

namespace SmartDas
{
    public partial class DA0800 : SmartDas.Components.BaseForm
    {
        //Process webBrowser = null;
        public string sStopCode;

        public DA0800() 
        {
            InitializeComponent();

            SetButtons();

            SetListBoxError();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtStopName.Text = "";
            txtStopCode.Text = "";
            //SetProcWorker();
        }

        /// <summary>
        /// 버튼 생성
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetListBoxError()
        { 
            btnListBox_Stop.CountX = 5;
            btnListBox_Stop.CountY = 1;

            btnListBox_Stop.SelectProcedureName = "USP_DA0800_S1";

            btnListBox_Stop.SetStoreProc();

            btnListBox_Stop.ParameterList.Add(new SqlParameter("@pDASDivision", Common.gsDASDivision));

            btnListBox_Stop.DoFind();

            btnListBox_StopList.CountX = 5;
            btnListBox_StopList.CountY = 3;

            btnListBox_StopList.SelectProcedureName = "USP_DA0800_S2";
            btnListBox_StopList.SetStoreProc();

            btnListBox_StopList.ExTag = btnListBox_Stop.GetSelectedButtons()[0].Tag.ToString();

            btnListBox_StopList.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;

            btnListBox_StopList.DoFind();
        }
        
        private void btnListBox_Stop_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            btnListBox_StopList.ExTag = btnListBox_Stop.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_StopList.CurrentPage = 0;

            btnListBox_StopList.RedrawButtons();
        }

        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();

            try
            {
                switch (sender.Text)
                {
                    case "등록":

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtStopCode.Text))
                        {
                            SetMessage("비가동 내역을 선택하세요.");
                            return;
                        }

                        sStopCode = txtStopCode.Text;

                        //string sSendSMS = clsDB.nvlString(btn["StopSMS"]);    //20130302 김성재 : 사용하지 않음

                        // 비가동 등록 후, 정상 처리 되고 난 이 후 추가 처리 ( 있으면 추가 )
                        // 설비 고장일 경우 - 생산 담당자에게 SMS 전송
                        //if (sSendSMS == "Y")
                        //{
                        //    //SendSMS();
                        //}

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (SqlException oe)
            {
                //clsDB.Rollback();

                SetMessage(oe.Message);
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private int SendSMS()
        {
            int iCount = 0;

            foreach (Worker w in Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.PROD).List)
            {
                if (SendSMS(w))
                    iCount++;
            }

            return iCount;
        }   //20130302 김성재 : 사용하지 않음

        private bool SendSMS(Worker worker)
        {
            try
            {
                string sSender = "1234";
                string sMSG = "";
                string sAll = "";

                if (worker.Phone == "")
                {
                    return false;
                }

                sMSG = "[" + DateTime.Now.ToString("MM-dd") + "] [";
                sMSG += btnListBox_StopList.GetSelectedButtons()[0].Tag.ToString() + "] [";
                sMSG += Common.SelectedWorkCenter.Code + "] [";
                sMSG += Common.SelectedWorkCenter.Name + "] [";
                sMSG += btnListBox_StopList.GetSelectedButtons()[0].Text.ToString() + "] [";
                if (Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).List.Count > 0)
                    sMSG += Common.SelectedWorkCenter.GetWorkerList(Common.ListWorkerType.SELECT).List[0].Name + "]";
                else
                    sMSG += " ]";

                sAll = "http://sms.onsoft.kr/sms_run.php?ds=" + (char)28
                        + "&com_id=ds0173&user_id=motonic&passwd=motonic123&sender_name=motonic&sender_no="
                        + sSender.Replace("-", "") + "&receiver_no=" + worker.Phone.Replace("-", "") + "&msg=" + sMSG + "&rdate=&rtime=";

                //if (webBrowser != null)
                //{
                //    webBrowser.Kill();
                //}

                //ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ////Process.Start(startInfo);
                //startInfo.Arguments = sAll;
                //webBrowser = Process.Start(startInfo);


                //Common.SendSMS(sAll); 

                //sendsms.smsmsg = "[" + DateTime.Now.ToString("MM-dd") + "] [" 
                //    + xebr_brnbr.Text + "] [" + xebr_no.Text + "] [" + lbl_wc.Text + "] [" 
                //    + xebr_desc1.Text + xebr_desc2.Text + "] [" + xebr_req_man.Text + "]";

                //txt_send.text : 보내는 사람 전화번호
                //txt_recieve.text : 받는 사람 전화번호
                //txt_msg.text : [월-일][고장번호][설비번호][설비설치작업장][고장내용 + 고장시간][요청자]

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {

            }
        }   //20130302 김성재 : 사용하지 않음

        private void btnListBox_ErrorList_buttonChangeEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            txtStopName.Text = sender.Text;
            txtStopCode.Text = sender.Tag.ToString();
        }

        private void DA0800_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if ( webBrowser != null )
            //    webBrowser.Kill();

            //webBrowser = null;
        }   //20130302 김성재 : 사용하지 않음
    }
}
