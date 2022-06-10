using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data.Common;

using System.Threading;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinEditors;
using System.Diagnostics;
using SmartDas.POPUP;
using System.Configuration;



namespace SmartDas.Components
{
    /// <summary>
    /// Base form class
    /// </summary>
    public partial class BaseForm : Form
    {
        #region Variables

        /// <summary>
        /// Thread
        /// </summary>
        private Thread _Thread;

        /// <summary>
        /// Sync timer
        /// </summary>
        private bool _bSyncTime;

        /// <summary>
        /// Datetime
        /// </summary>
        private DateTime _DateTime;

        /// <summary>
        /// Load flag
        /// </summary>
        private bool _bLoad = false;

        /// <summary>
        /// Set rec date
        /// </summary>
        private bool _bSetRecDate = false;

        /// <summary>
        /// Show dialog
        /// </summary>
        protected bool _IsShowDialog = false;

        /// <summary>
        /// Use network
        /// </summary>
        public bool _bUseNetwork;

        /// <summary>
        /// Max
        /// </summary>
        private int _iMax = 10;

        /// <summary>
        /// Count
        /// </summary>
        private int _iCount = 0;

        /// <summary>
        /// Image list
        /// </summary>
        private List<UltraPictureBox> _ImageList = new List<UltraPictureBox>();

        /// <summary>
        /// Message forcolor
        /// </summary>
        private Color _MessageForColor = Color.White;

        /// <summary>
        /// Auto reset
        /// </summary>
        protected AutoResetEvent _AutoReset = new AutoResetEvent(false);

        /// <summary>
        /// Progress form
        /// </summary>
        protected POPUP.BaseProgressForm _ProgressForm;

        /// <summary>
        /// Close program form call back
        /// </summary>
        delegate void ClosePrgFormCallBack();
        

        private string sCompany = string.Empty;

        #endregion

        #region Constructors & Destructor

        /// <summary>
        /// Baseform constructor
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();

            _bUseNetwork = false;
            SetRecDate();

            _ImageList.Clear();
            _ImageList.Add(imgSamkee);                                                               
            foreach (UltraPictureBox pBox in _ImageList)
            {
                pBox.Visible = false;

                //if (pBox.Tag.ToString() == Common.gsPlantCode)
                //{
                //    pBox.Visible = true;
                //}
                //else
                //{
                //    pBox.Visible = false;
                //}
            }
            /* 회사로고변경*/
            if (Common.sERPDB.Equals("ERPSVR.SKE_MFG"))
            {
                lblTitle.BackColor1 = Color.LightSteelBlue;                
                imgMotonic.Appearance.ImageBackground = global::SmartDas.Properties.Resources.삼기EV_Logo_2;
            }
            else
            {
                lblTitle.BackColor1 = Color.LightGreen;
                imgMotonic.Appearance.ImageBackground = global::SmartDas.Properties.Resources.삼기_Logo;
            }   

#if DEBUG
            lblTitle.MoveControl = this;
#endif

            _MessageForColor = lblMessage.ForeColor;

        }

        /// <summary>
        /// Base form destructor
        /// </summary>
        ~BaseForm()
        {
            if (_Thread != null)
            {
                _Thread.Abort();
                _Thread = null;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

            if (_DateTime.Hour != DateTime.Now.Hour)
            {
                _bSetRecDate = false;
            }

            if (!_bSetRecDate)
            {
                SetRecDate();
            }

            _DateTime = DateTime.Now;

            if (_iMax != 0)
            {
                if (_iMax <= _iCount)
                {
                    _iMax = 0;
                    _iCount = 0;
                    lblMessage.Text = "";
                }

                _iCount++;
            }
        }

        /// <summary>
        /// 이벤트 타이머가 발생시키는 이벤트
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        protected virtual void EventTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
        }

        /// <summary>
        /// Baseform activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_Activated(object sender, EventArgs e)
        {
            if (!_bLoad)
            {
                TimeTimer.Enabled = true;

                if (_Thread == null)
                {
                    _Thread = new Thread(new ThreadStart(NetworkTimerCheck));
                    _Thread.IsBackground = true;
                    _Thread.Start();
                }

                this.Text = lblTitle.Text;

                _bLoad = true;
            }
        }

        /// <summary>
        /// Base form formclosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Thread != null)
            {
                _Thread.Abort();
                _Thread = null;
            }
        }

        /// <summary>
        /// Process do work event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bgProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            _ProgressForm = new POPUP.BaseProgressForm(this.Location, this.Width, this.Height);
            _ProgressForm.Activated += new EventHandler(ProgressForm_Activated);
            _ProgressForm.indProgress.SetMessage(e.Argument.ToString());
            _ProgressForm.TopMost = true;
            _ProgressForm.ShowDialog();
        }

        /// <summary>
        /// Progress form activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ProgressForm_Activated(object sender, EventArgs e)
        {
            this._AutoReset.Set();
        }

        /// <summary>
        /// Date click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblDate_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /// <summary>
        /// Logo picture click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLogo_Click(object sender, EventArgs e)
        {
            TerminalManagement();
        }

        /// <summary>
        /// Message timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Msgtimer_Tick(object sender, EventArgs e)
        {
            if (_MessageForColor == lblMessage.ForeColor)
            {
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                lblMessage.ForeColor = _MessageForColor;
            }

            if (string.IsNullOrEmpty(lblMessage.Text))
            {
                Msgtimer.Enabled = false;
            }
        }

        /// <summary>
        /// Base form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Common.gsPlantCode == "SK2")
                //{
                //    imgMotonic.Visible = true;
                //    imgSamkee.Visible = false;                    
                //}
            }
            catch { }
        }

        /// <summary>
        /// Image samkee click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgSamkee_Click(object sender, EventArgs e)
        {
            TerminalManagement();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set now time
        /// </summary>
        private void GetNowTime()
        {
            try
            {
                Database database;
                database = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = database.GetSqlStringCommand("SELECT GETDATE()");
                DataSet dataSet = database.ExecuteDataSet(dbCommand);

                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    SetSystemTimeClass setSystemTimeClass = new SetSystemTimeClass(Convert.ToDateTime(dataSet.Tables[0].Rows[0][0]));
                    setSystemTimeClass.StandardTimeInterval = 9;
                    setSystemTimeClass.SetTime();
                    _bSyncTime = false;
                }
            }
            catch (SqlException sqlException)
            {
                switch (sqlException.Number)
                {
                    case 3135:
                        break;
                    case 12543:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        /// <summary>
        /// Check network
        /// </summary>
        /// <returns></returns>
        public int CheckNetwork()
        {
            try
            {
                DateTime startDateTime = DateTime.Now;

                if (startDateTime.Minute == 1 && startDateTime.Second < 9)
                {
                    this.Invoke(new MethodInvoker(delegate()
                    {
                        this.CenterToScreen();
                    }));
                }

                Database database;
                database = DatabaseFactory.CreateDatabase();
                DbConnection dbConnection = database.CreateConnection();
                dbConnection.Open();
                dbConnection.Close();

                DateTime endDateTime = DateTime.Now;

                if ((endDateTime - startDateTime).TotalSeconds > 0.2)
                {
                    return 2;
                }

                return 1;
            }
            catch (SqlException sqlException)
            {
                switch (sqlException.Number)
                {
                    case 3135:
                        break;
                    case 12543:
                        break;
                    default:
                        break;
                }

                return 0;
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Set rec date
        /// </summary>
        private void SetRecDate()
        {
            try
            {
                if (_bUseNetwork)
                {
                    string sDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    Database database;
                    database = DatabaseFactory.CreateDatabase();
                    DbCommand dbCommand = database.GetSqlStringCommand("SELECT dbo.fn_RecDate(convert(varchar, getdate(), 121)) as RECDATE, dbo.fn_DayNight('" + sDate + "') AS DayNight ");

                    DataSet dataSet = database.ExecuteDataSet(dbCommand);

                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Common.gRecDate = dataSet.Tables[0].Rows[0]["RECDATE"].ToString();
                        Common.gDayNight = dataSet.Tables[0].Rows[0]["DayNight"].ToString();

                        _bSetRecDate = true;
                    }

                    Common.GetMessageList();
                    Common.GetLanguageList();
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        /// <summary>
        /// Network timer check
        /// </summary>
        private void NetworkTimerCheck()
        {
            try
            {
                //string ss = string.Empty;
                //if (lblTime.InvokeRequired)
                //{
                //    ss = lblTime.Text.Substring(6, 2);
                //}    
                //do
                //{
                //    int iResult = CheckNetwork();
                //    if (iResult == 1)
                //    {
                //        lblNetwork.Text = "네트워크 상태\n정상";
                //        lblNetwork.SetColor(Color.DeepSkyBlue, Color.White);

                //        _bUseNetwork = true;
                //        clsDB.bUseNetwork = true;

                //        if (_bSyncTime)
                //        {
                //            GetNowTime();
                //        }
                //    }
                //    else if (iResult == 2)
                //    {
                //        lblNetwork.Text = "네트워크 상태\n불량";
                //        lblNetwork.SetColor(Color.YellowGreen, Color.YellowGreen);

                //        _bUseNetwork = true;
                //        clsDB.bUseNetwork = true;
                //        //Thread.Sleep(2000);

                //        continue;
                //    }
                //    else
                //    {
                //        _bUseNetwork = false;
                //        clsDB.bUseNetwork = false;

                //        lblNetwork.Text = "네트워크 상태\n연결 안됨";
                //        lblNetwork.SetColor(Color.Red, Color.Red);
                //    }
                //}
                //while (ss == "59");    


                while (true)
                {
                    int iResult = CheckNetwork();
                    if (iResult == 1)
                    {
                        //lblNetwork.Text = "네트워크 상태\n정상";

                        lblNetwork.Text = Common.GetLanguage("T00030");
                        lblNetwork.SetColor(Color.DeepSkyBlue, Color.White);

                        _bUseNetwork = true;
                        clsDB.bUseNetwork = true;

                        if (_bSyncTime)
                        {
                            GetNowTime();
                        }
                    }
                    else if (iResult == 2)
                    {
                        //lblNetwork.Text = "네트워크 상태\n불량";
                        lblNetwork.Text = Common.GetLanguage("T00031");
                        lblNetwork.SetColor(Color.YellowGreen, Color.YellowGreen);

                        _bUseNetwork = true;
                        clsDB.bUseNetwork = true;
                        Thread.Sleep(2000);

                        continue;
                    }
                    else
                    {
                        _bUseNetwork = false;
                        clsDB.bUseNetwork = false;

                        //lblNetwork.Text = "네트워크 상태\n연결 안됨";
                        lblNetwork.Text = Common.GetLanguage("T00032");
                        lblNetwork.SetColor(Color.Red, Color.Red);
                    }

                    Thread.Sleep(10000);
                }
                
            }
            catch (ThreadAbortException ex)
            {
                Debug.Write(ex.ToString());
                return;
            }
        }

        /// <summary>
        /// Show dialog form
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public DialogResult ShowDialogForm(Form form)
        {
            try
            {
                DialogResult dialogResult;
                bool bTopMost = false;
                TimeTimer.Enabled = false;
                DoProgress();
                bool bPreEventTimerEnable = EventTimerEnable;

                EventTimerEnable = false;

                if (_Thread != null)
                {
                    _Thread.Abort();
                    _Thread = null;
                }

                CloseProgressForm();

                bTopMost = this.TopMost;

#if Debug
                form.TopMost = true;
#endif

                form.Focus();


                if (!form.GetType().FullName.Contains("POPUP"))
                {
                    this.Visible = false;
                }
                dialogResult = form.ShowDialog();

                this.Visible = true;
                this.TopMost = bTopMost;
                TimeTimer.Enabled = true;

                if (_Thread == null)
                {
                    _Thread = new Thread(new ThreadStart(NetworkTimerCheck));
                    _Thread.IsBackground = true;
                    _Thread.Start();
                }

                EventTimerEnable = bPreEventTimerEnable;
                return dialogResult;
            }
            catch { }
            return System.Windows.Forms.DialogResult.Abort;
        }

        /// <summary>
        /// Show form
        /// </summary>
        /// <param name="form"></param>
        public void ShowForm(Form form)
        {
            form.Show();
        }

        /// <summary>
        /// Set message
        /// </summary>
        /// <param name="message"></param>
        public void SetMessage(string message)
        {
            SetMessage(message, 10);
        }

        /// <summary>
        /// Set message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="second"></param>
        public void SetMessage(string message, int second)
        {
            lblMessage.Text = Common.GetMessage(message);
            Msgtimer.Enabled = true;
            _iCount = 0;
            _iMax = second;
        }

        /// <summary>
        /// Get TBM0000 code
        /// </summary>
        /// <param name="MajorCode"></param>
        /// <param name="sArr"></param>
        /// <returns></returns>
        public DataTable GetTBM0000Code(string MajorCode, string[] sArr = null)
        {
            string methodName = new StackFrame().GetMethod().Name;
            StringBuilder stringBuilder = null;
            DataTable dt = new DataTable();

            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Remove(0, stringBuilder.Length);

                stringBuilder.AppendLine("SELECT MinorCode AS CODE_ID, ");
                stringBuilder.AppendLine("      '[' + MinorCode + '] '+  CodeName AS CODE_NAME, ");
                stringBuilder.AppendLine("       DisplayNo   AS DisplayNo ");
                stringBuilder.AppendLine(" FROM TBM0000 WITH(NOLOCK) ");
                stringBuilder.AppendLine("WHERE MajorCode = '" + MajorCode + "' ");
                stringBuilder.AppendLine("  AND MinorCode <> '$' ");

                if (sArr != null)
                {
                    for (int i = 0; i < sArr.Length; i += 2)
                    {
                        stringBuilder.AppendLine(" AND  " + sArr[i] + " = '" + sArr[i + 1] + "' ");
                    }
                }

                stringBuilder.AppendLine(" ORDER BY DisplayNo ");

                clsDB.gCreateRSet(clsDB.sqlConn, Convert.ToString(stringBuilder), dt);

                return dt != null ? dt : new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), methodName);
                return new DataTable();
            }
            finally
            {
                if (stringBuilder != null) { stringBuilder = null; }
            }
        }

        /// <summary>
        /// Do progress
        /// </summary>
        public virtual void DoProgress()
        {
            DoProgress(false);
        }

        /// <summary>
        /// Do progress
        /// </summary>
        /// <param name="bProcess"></param>
        public virtual void DoProgress(bool bProcess)
        {
            this.Cursor = Cursors.WaitCursor;

            UseWaitCursor = true;

            if (bProcess == false)
            {
                return;
            }

            if (this.bgProcess.IsBusy)
            {
                return;
            }

            this.bgProcess.RunWorkerAsync("처리 중...");
            this._AutoReset.WaitOne();
        }

        /// <summary>
        /// Close progress form
        /// </summary>
        protected void CloseProgressForm()
        {
            CloseProgressForm(false);
        }

        /// <summary>
        /// Close progress form
        /// </summary>
        /// <param name="bProcess"></param>
        protected void CloseProgressForm(bool bProcess)
        {
            this.Cursor = Cursors.Default;

            UseWaitCursor = false;

            if (bProcess == false)
            {
                return;
            }

            this._IsShowDialog = false;

            try
            {
                if (this._ProgressForm.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        Thread.Sleep(200);
                        this._ProgressForm.Close();
                    }));

                    return;
                }

                this._ProgressForm.Close();
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        /// <summary>
        /// Messagebox show
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="buttons"></param>
        /// <param name="lblTitle"></param>
        /// <returns></returns>
        public DialogResult MessageBoxShow(string Message, MessageBoxButtons buttons = MessageBoxButtons.OK, string lblTitle = "알   림")
        {
            string message = Common.GetMessage(Message);
            MessageForm mesForm = new MessageForm(message, buttons, lblTitle);

            return ShowDialogForm(mesForm);
        }

        /// <summary>
        /// Terminal management
        /// </summary>
        private void TerminalManagement()
        {
            string sPassword = string.Empty;
            string sUserId   = string.Empty;
            string sUserName = string.Empty;

            DA9999 dA9999 = new DA9999();
            ShowDialogForm(dA9999);

            if (dA9999.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                sPassword = dA9999.Password;

                if (!string.IsNullOrEmpty(sPassword))
                {
                    Database database = DatabaseFactory.CreateDatabase();
                    SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                    SqlCommand sqlCommand = new SqlCommand();


                    if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                    {
                        sqlCommand.CommandText = "ERPSVR.SKA_FIN.dbo.SP_GET_PASSWORD_LIST";
                    }
                    else
                    {
                        sqlCommand.CommandText = "ERPSVR.SKE_FIN.dbo.SP_GET_PASSWORD_LIST";
                    }

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@PASSWORD", sPassword));

                    DataTable dt = new DataTable();

                    clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        sUserId = dt.Rows[0]["USER_ID"].ToString();
                        sUserName = dt.Rows[0]["USER_NAME"].ToString();

                        if (!string.IsNullOrEmpty(sUserId))
                        {
                            DA9998 dA9998 = new DA9998(sUserId, sUserName);
                            ShowDialogForm(dA9998);
                        }
                    }
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sync time
        /// </summary>
        public bool SyncTime
        {
            get { return _bSyncTime; }
            set { _bSyncTime = value; }
        }

        /// <summary>
        /// Now datetime
        /// </summary>
        protected DateTime nowDateTime
        {
            get { return _DateTime; }
        }

        /// <summary>
        /// Event timer enable
        /// </summary>
        public bool EventTimerEnable
        {
            get { return EventTimer.Enabled; }
            set { EventTimer.Enabled = value; }
        }

        /// <summary>
        /// Event timer interval
        /// </summary>
        public int EventTimerInterval
        {
            get { return EventTimer.Interval; }
            set { EventTimer.Interval = value; }
        }

        #endregion
    }
}
