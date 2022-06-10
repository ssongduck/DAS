using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDas.Components;
using System.Runtime.InteropServices;
using Infragistics.Win.Misc;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace SmartDas.POPUP
{
    /// <summary>
    /// DA9997 popup form class
    /// </summary>
    public partial class DA9997 : Form
    {
        #region Variables

        /// <summary>
        /// WorkCenter code
        /// </summary>
        WorkCenter workCenter = Common.SelectedWorkCenter;

        /// <summary>
        /// WorkCenterCode
        /// </summary>
        string _WorkCenterCode = string.Empty;

        /// <summary>
        /// Order no
        /// </summary>
        string _OrderNo = string.Empty;

        /// <summary>
        /// Item code
        /// </summary>
        string _ItemCode = string.Empty;

        /// <summary>
        /// Down code
        /// </summary>
        string _DownCode = string.Empty;

        /// <summary>
        /// Down start date time
        /// </summary>
        string _DownStartDatetime;

        /// <summary>
        /// Break down name
        /// </summary>
        string _BreakDownName = string.Empty;

        /// <summary>
        /// Break down code
        /// </summary>
        string _BreakDownCode = string.Empty;

        #endregion

        #region Constructors

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        public DA9997()
        {
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();
            btnRelease.Enabled = false;

            InitializeButton();
        }

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        /// <param name="breakDownName"></param>
        /// <param name="breakDownCode"></param>
        public DA9997(string breakDownName, string breakDownCode)
        {
            _BreakDownName = breakDownName;
            _BreakDownCode = breakDownCode;

            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();
            btnRelease.Enabled = false;

            InitializeButton();
        }

        #endregion

        #region Events

        /// <summary>
        /// Plant stop button clieck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlanStop_Click(object sender, EventArgs e)
        {
            EnabledBtnCtrl(sender as SmartDas.Components.MESButton, "BD01", 0);
        }

        /// <summary>
        /// Equipment barke down click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqpBrakDown_Click(object sender, EventArgs e)
        {
            int iSeqNo = 0;
            string sPlantCode = string.Empty;
            string sWorkCenterCode = string.Empty;

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = sqlConnection;

            try
            {
                MessageForm messageForm = new MessageForm("설비 긴급 점검을 요청하시겠습니까?", true, MessageBoxButtons.YesNo, "등록 확인");

                if (messageForm.ShowDialog() != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }

                sqlCommand.CommandText = "SP_SEND_EQUIPMENT_MAINT_SMS";
                sqlCommand.Parameters.Clear();

                if (workCenter != null)
                {
                    sPlantCode = workCenter.PlantCode;
                    sWorkCenterCode = workCenter.Code;

                    sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", workCenter.PlantCode));
                    sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", workCenter.Code));
                    sqlCommand.Parameters.Add(new SqlParameter("@NAME", workCenter.Name));
                }
                else
                {
                    sPlantCode = Common.SelectedWorkCenter.PlantCode;
                    sWorkCenterCode = Common.SelectedWorkCenter.Code;

                    sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                    sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                    sqlCommand.Parameters.Add(new SqlParameter("@NAME", Common.SelectedWorkCenter.Name));
                }

                if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                {
                    return;
                }
                else
                {
                    iSeqNo = int.Parse(database.ExecuteScalar(CommandType.Text, "SELECT MAX(A.SEQID) AS SEQNO FROM TCM0200 A WHERE A.PLANTCODE = '" + sPlantCode + "' AND WORKCENTERCODE = '" + sWorkCenterCode + "'").ToString());

                    MessageBox.Show("정상적으로 문자가 발송되었습니다.", "SMS 발송확인", MessageBoxButtons.OK);
                }

                EnabledBtnCtrl(sender as SmartDas.Components.MESButton, "BD02", iSeqNo);

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Mold brake down click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoldBarkDown_Click(object sender, EventArgs e)
        {
            EnabledBtnCtrl(sender as SmartDas.Components.MESButton, _BreakDownCode, 0);
        }

        /// <summary>
        /// Moment stop click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMomentStop_Click(object sender, EventArgs e)
        {
            EnabledBtnCtrl(sender as SmartDas.Components.MESButton, "BD04", 0);
        }

        /// <summary>
        /// Quality shortage click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQualityShortage_Click(object sender, EventArgs e)
        {
            string sPlantCode = string.Empty;
            string sWorkCenterCode = string.Empty;

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = sqlConnection;

            try
            {
                MessageForm messageForm = new MessageForm("품질/결품 정보를 전송 하시겠습니까?", true, MessageBoxButtons.YesNo, "전송 확인");

                if (messageForm.ShowDialog() != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }

                sqlCommand.CommandText = "SP_SEND_QUALITY_SMS";
                sqlCommand.Parameters.Clear();

                if (workCenter != null)
                {
                    sPlantCode = workCenter.PlantCode;
                    sWorkCenterCode = workCenter.Code;

                    sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", workCenter.PlantCode));
                    sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", workCenter.Code));
                    sqlCommand.Parameters.Add(new SqlParameter("@NAME", workCenter.Name));
                }
                else
                {
                    sPlantCode = Common.SelectedWorkCenter.PlantCode;
                    sWorkCenterCode = Common.SelectedWorkCenter.Code;

                    sqlCommand.Parameters.Add(new SqlParameter("@PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                    sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                    sqlCommand.Parameters.Add(new SqlParameter("@NAME", Common.SelectedWorkCenter.Name));
                }

                if (!clsDB.gExecuteProcedure(sqlConnection, sqlCommand))
                {
                    return;
                }
                else
                {
                    MessageBox.Show("정상적으로 문자가 발송되었습니다.", "SMS 발송확인", MessageBoxButtons.OK);
                }

                EnabledBtnCtrl(sender as SmartDas.Components.MESButton, "BD05", 0);

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Release click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelease_Click(object sender, EventArgs e)
        {
            DisabledBtnCtrl(sender as SmartDas.Components.MESButton);
        }

        /// <summary>
        /// Close button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Attach event handlers
        /// </summary>
        private void AttachEventHandlers()
        {
            btnPlanStop._Click += new EventHandler(btnPlanStop_Click);
            btnEqpBrakDown._Click += new EventHandler(btnEqpBrakDown_Click);
            btnMoldBarkDown._Click += new EventHandler(btnMoldBarkDown_Click);
            btnMomentStop._Click += new EventHandler(btnMomentStop_Click);
            btnQualityShortage._Click += new EventHandler(btnQualityShortage_Click);
            btnRelease._Click += new EventHandler(btnRelease_Click);
            btnClose._Click += new EventHandler(btnClose_Click);
        }

        /// <summary>
        /// Initialize button
        /// </summary>
        private void InitializeButton()
        {
            btnMoldBarkDown.Text = _BreakDownName;

            string sDownTimeState = GetDownTimeState();

            if (!string.IsNullOrEmpty(sDownTimeState))
            {
                switch (sDownTimeState)
                {
                    case "BD01":
                        btnPlanStop.Enabled = true;
                        btnEqpBrakDown.Enabled = false;
                        btnMoldBarkDown.Enabled = false;
                        btnMomentStop.Enabled = false;
                        btnQualityShortage.Enabled = false;
                        btnRelease.Enabled = true;

                        btnPlanStop.BackColor = Color.Yellow;

                        break;

                    case "BD02":
                        btnPlanStop.Enabled = false;
                        btnEqpBrakDown.Enabled = true;
                        btnMoldBarkDown.Enabled = false;
                        btnMomentStop.Enabled = false;
                        btnQualityShortage.Enabled = false;
                        btnRelease.Enabled = true;

                        btnEqpBrakDown.BackColor = Color.Yellow;

                        break;

                    case "BD03":
                    case "BD06":
                        btnPlanStop.Enabled = false;
                        btnEqpBrakDown.Enabled = false;
                        btnMoldBarkDown.Enabled = true;
                        btnMomentStop.Enabled = false;
                        btnQualityShortage.Enabled = false;
                        btnRelease.Enabled = true;

                        btnMoldBarkDown.BackColor = Color.Yellow;

                        break;

                    case "BD04":
                        btnPlanStop.Enabled = false;
                        btnEqpBrakDown.Enabled = false;
                        btnMoldBarkDown.Enabled = false;
                        btnMomentStop.Enabled = true;
                        btnQualityShortage.Enabled = false;
                        btnRelease.Enabled = true;

                        btnMomentStop.BackColor = Color.Yellow;

                        break;

                    case "BD05":
                        btnPlanStop.Enabled = false;
                        btnEqpBrakDown.Enabled = false;
                        btnMoldBarkDown.Enabled = false;
                        btnMomentStop.Enabled = false;
                        btnQualityShortage.Enabled = true;

                        btnRelease.Enabled = true;

                        btnQualityShortage.BackColor = Color.Yellow;

                        break;
                }
            }
        }

        /// <summary>
        /// Enabled Button control
        /// </summary>
        /// <param name="mesButton"></param>
        /// <param name="sDownCode"></param>
        /// <param name="iSeqNo"></param>
        private void EnabledBtnCtrl(MESButton mesButton, string sDownCode, int iSeqNo)
        {
            if (mesButton.ButtonClickType == MESButton.ButtonClickTypeEnum.Click)
            {
                if (mesButton.BackColor == Color.Yellow)
                {
                    return;
                }

                _WorkCenterCode = workCenter.Code;
                _DownCode = sDownCode;
                _OrderNo = workCenter.OrderNo;
                _ItemCode = workCenter.ItemCode;
                _DownStartDatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                SaveDownTimeInfo("START", iSeqNo);

                btnPlanStop.Enabled = false;
                btnEqpBrakDown.Enabled = false;
                btnMoldBarkDown.Enabled = false;
                btnMomentStop.Enabled = false;
                btnQualityShortage.Enabled = false;
                btnClose.Enabled = true;
                mesButton.Enabled = true;
                btnRelease.Enabled = true;

                mesButton.BackColor = Color.Yellow;

                if (sDownCode == "BD02")
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Disabled Button control
        /// </summary>
        /// <param name="mesButton"></param>
        private void DisabledBtnCtrl(MESButton mesButton)
        {
            if (mesButton.ButtonClickType == MESButton.ButtonClickTypeEnum.Click)
            {
                SaveDownTimeInfo("END", 0);
                this.Close();
            }
        }

        /// <summary>
        /// Save down time info
        /// </summary>
        /// <param name="sMode"></param>
        /// <param name="iSeqNo"></param>
        private void SaveDownTimeInfo(string sMode, int iSeqNo)
        {
            try
            {
                string sRtn = string.Empty;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SP_SAVE_DOWN_TIME_STATE";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@WK_CENTER", _WorkCenterCode));
                sqlCommand.Parameters.Add(new SqlParameter("@WK_ORDER_NO", _OrderNo));
                sqlCommand.Parameters.Add(new SqlParameter("@ITEM_CD", _ItemCode));
                sqlCommand.Parameters.Add(new SqlParameter("@DOWN_CD", _DownCode));
                sqlCommand.Parameters.Add(new SqlParameter("@SEQ_NO", iSeqNo));
                sqlCommand.Parameters.Add(new SqlParameter("@DOWN_STR_DT", _DownStartDatetime));

                if (sMode == "START")
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@DOWN_END_DT", DBNull.Value));
                }
                else
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@DOWN_END_DT", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                }

                sqlCommand.Parameters.Add(new SqlParameter("@ATTR_1_CD", string.Empty));
                sqlCommand.Parameters.Add(new SqlParameter("@ATTR_2_CD", string.Empty));
                sqlCommand.Parameters.Add(new SqlParameter("@ATTR_3_CD", string.Empty));
                sqlCommand.Parameters.Add(new SqlParameter("@ATTR_4_CD", string.Empty));
                sqlCommand.Parameters.Add(new SqlParameter("@ATTR_5_CD", string.Empty));
                sqlCommand.Parameters.Add(new SqlParameter("@REG_DT", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("@REG_USER_ID", workCenter.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName));
                sqlCommand.Parameters.Add(new SqlParameter("@CHNG_DT", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("@CHNG_USER_ID", workCenter.GetWorkerList(Common.ListWorkerType.SELECT).AllWorkerName));
                sqlCommand.Parameters.Add(new SqlParameter("@RTN_MESSAGE", sRtn));

                int res = clsDB.gExecute(sqlConnection, sqlCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

            sqlCommand.Parameters.Add(new SqlParameter("@WK_CENTER", workCenter.Code));

            DataTable dt = new DataTable();

            clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                sRtn = dt.Rows[0]["DOWN_CD"].ToString();
                _WorkCenterCode = dt.Rows[0]["WK_CENTER"].ToString();
                _OrderNo = dt.Rows[0]["WK_ORDER_NO"].ToString();
                _ItemCode = dt.Rows[0]["ITEM_CD"].ToString();
                _DownCode = dt.Rows[0]["DOWN_CD"].ToString();
                _DownStartDatetime = dt.Rows[0]["DOWN_STR_DT"].ToString();
            }

            return sRtn;
        }

        #endregion

        #region Properties



        #endregion
    }
}