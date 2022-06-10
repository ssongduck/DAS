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
using System.Management;

namespace SmartDas.POPUP
{
    /// <summary>
    /// DA9998 Regester check Terminal
    /// </summary>
    public partial class DA9998 : Form
    {
        #region Variables

        /// <summary>
        /// Site id
        /// </summary>
        private string _SiteId = string.Empty;

        /// <summary>
        /// Password
        /// </summary>
        private string _sUserId = string.Empty;

        /// <summary>
        /// User name
        /// </summary>
        private string _sUserName = string.Empty;

        #endregion

        #region Constructor

        /// <summary>
        /// DA9998 constructor
        /// </summary>
        public DA9998()
        {
            InitializeComponent();
            this.TopMost = true;
            cmbTonerState.Text = "충분";
        }

        /// <summary>
        /// DA9998 constructor
        /// </summary>
        /// <param name="sUserId"></param>
        /// <param name="sUserName"></param>
        public DA9998(string sUserId, string sUserName)
        {
            string sWorkCenterCode = string.Empty;
            string sWorkCenterName = string.Empty;

            DataTable dt = null;

            InitializeComponent();
            this.TopMost = true;

            _sUserId = sUserId;
            _sUserName = sUserName;
            _SiteId = Common.gsPlantCode == "SK1" ? "10" : "20";

            if (SystemInformation.ComputerName.Length > 8)
            {
                if (SystemInformation.ComputerName.Substring(6, 2) != "MD")
                {
                    if (Common.SelectedWorkCenter == null ||
                        string.IsNullOrEmpty(Common.SelectedWorkCenter.Code) ||
                        string.IsNullOrEmpty(Common.SelectedWorkCenter.Name))
                    {
                        MessageBox.Show("작업장을 선택해주십시오!!!");
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Close();
                        return;
                    }

                    sWorkCenterCode = Common.SelectedWorkCenter.Code;
                    sWorkCenterName = Common.SelectedWorkCenter.Name + (Common.gsPlantCode == "SK1" ? "[평택]" : "[서산]");
                }
                else
                {
                    sWorkCenterCode = "MD01";
                    sWorkCenterName = "금형보전";
                }
            }

            txtUserId.Text = sUserId;
            txtUserName.Text = sUserName;
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtTerminal.Text = SystemInformation.ComputerName;
            txtWorkCenterId.Text = sWorkCenterCode;
            txtWorkCenterName.Text = sWorkCenterName;
            txtIPAddress.Text = Common.gsIP;

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                txtWorkGroupName.Text = string.Format("{0}", managementObject["Domain"]);
            }

            dt = GetTerminalStateList(_SiteId, SystemInformation.ComputerName, DateTime.Now.ToString("yyyyMMdd"));

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbTerminalState.Text = dt.Rows[0]["TERMINAL_TYPE"].ToString() == "O" ? "구형" : "신형";
                cmbOPState.Text = dt.Rows[0]["OP_STATE"].ToString() == "Y" ? "정상" : "고장";
                cmbPrintState.Text = dt.Rows[0]["PRINT_STATE"].ToString() == "Y" ? "정상" : "고장";
                cmbTouchPanelState.Text = dt.Rows[0]["TOUCH_PANEL_STATE"].ToString() == "Y" ? "정상" : "고장";
                cmbInputState.Text = dt.Rows[0]["INPUT_STATE"].ToString() == "Y" ? "정상" : "고장";
                cmbTonerState.Text = dt.Rows[0]["TONER_STATE"].ToString() == "L" ? "부족" : dt.Rows[0]["TONER_STATE"].ToString() == "E" ? "없음" : "충분";
                txtComment.Text = dt.Rows[0]["DESCRIPTION"].ToString();
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// Confirm button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetTerminalStateInfo();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Terminal state value changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTerminalState_ValueChanged(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor = (Infragistics.Win.UltraWinEditors.UltraComboEditor)sender;

            if (ultraComboEditor.Text == "구형")
            {
                cmbPrintState.Text = "없음";
                cmbTonerState.Text = "없음";
            }
        }

        /// <summary>
        /// Print state combobox value changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPrintState_ValueChanged(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor = (Infragistics.Win.UltraWinEditors.UltraComboEditor)sender;

            if (ultraComboEditor.Text == "없음")
            {
                cmbTonerState.Text = "없음";
            }
        }

        #endregion

        #region Method

        /// <summary>
        /// Get terminal state list
        /// </summary>
        /// <param name="sPlantCode"></param>
        /// <param name="sTerminalId"></param>
        /// <param name="sCheckDate"></param>
        /// <returns></returns>
        private DataTable GetTerminalStateList(string sPlantCode, string sTerminalId, string sCheckDate)
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();


                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    sqlCommand.CommandText = "ERPSVR.SKA_FIN.dbo.SP_GET_TERMINAL_STATE";
                }
                else
                {
                    sqlCommand.CommandText = "ERPSVR.SKE_FIN.dbo.SP_GET_TERMINAL_STATE";
                }
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@SITE_ID", sPlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@TERMINAL_ID", sTerminalId));
                sqlCommand.Parameters.Add(new SqlParameter("@CHECK_DATE", sCheckDate));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Set terminal state info
        /// </summary>
        private void SetTerminalStateInfo()
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;


                if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
                {
                    sqlCommand.CommandText = "ERPSVR.SKA_FIN.dbo.SP_SAVE_TEMINAL_STATE";
                }
                else
                {
                    sqlCommand.CommandText = "ERPSVR.SKE_FIN.dbo.SP_SAVE_TEMINAL_STATE";
                }
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@TERMINAL_ID", txtTerminal.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@CHECK_DATETIME", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("@CHECK_DATE", DateTime.Now.ToString("yyyyMMdd")));
                sqlCommand.Parameters.Add(new SqlParameter("@WORKGROUP", txtWorkGroupName.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTER_ID", txtWorkCenterId.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@WORKCENTER_NAME", txtWorkCenterName.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@IP_ADDRESS", txtIPAddress.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@USER_ID", txtUserId.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@USER_NM", txtUserName.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@TERMINAL_TYPE", cmbTerminalState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@OP_STATE", cmbOPState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@PRINT_STATE", cmbPrintState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@TOUCH_PANEL_STATE", cmbTouchPanelState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@INPUT_STATE", cmbInputState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@TONER_STATE", cmbTonerState.SelectedItem.DataValue));
                sqlCommand.Parameters.Add(new SqlParameter("@SITE_ID", _SiteId));
                sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPTION", txtComment.Text));

                clsDB.gExecute(sqlConnection, sqlCommand);
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region Property

        /// <summary>
        /// UserId property
        /// </summary>
        public string UserId
        {
            get { return _sUserId; }
        }

        /// <summary>
        /// Username property
        /// </summary>
        public string UserName
        {
            get { return _sUserName; }
        }

        #endregion
    }
}