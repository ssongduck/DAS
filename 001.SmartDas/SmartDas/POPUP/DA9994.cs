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
    /// DA9994 popup form class
    /// </summary>
    public partial class DA9994 : Form
    {
        #region Variables

        /// <summary>
        /// WorkCenter code
        /// </summary>        

        string _WorkCenterCode = string.Empty;
        string _PlantCode      = string.Empty;
        string _Date           = string.Empty;

        string _InspResult     = string.Empty;


        #endregion

        #region Constructors

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        public DA9994()
        {
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();                        
        }

        public string GetDate(string _OrderNo)
        {
            if (string.IsNullOrEmpty(_OrderNo)) { return "";}
            
            string yy   = _OrderNo.Substring(0, 2);
            string mm   = _OrderNo.Substring(2, 2);
            string dd   = _OrderNo.Substring(4, 2);

            return "20" + yy + "-" + mm + "-" + dd;
        }

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        /// <param name="breakDownName"></param>
        /// <param name="breakDownCode"></param>
        public DA9994(string _sPlantCode, string _sWorkCenterCode, string _sOrderNo)
        {            
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();
            
            _PlantCode      = _sPlantCode;
            _WorkCenterCode = _sWorkCenterCode;                        
            _Date           = GetDate(_sOrderNo);

            DoCheckInspection();
        }
         
        #endregion


        private void DoCheckInspection()
        {            
            string _sqlQuery = @"SELECT ISNULL(D_Insp,'X') + '^' + ISNULL(N_Insp,'X')
                                   FROM TQM4001 A WITH(NOLOCK) 
                                  WHERE 1 = 1 
                                    AND INSPDATE         ='" + _Date + "'"  + 
                                   "AND A.WORKCENTERCODE ='" + _WorkCenterCode + "'";            

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = _sqlQuery;
            sqlCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                _InspResult = dt.Rows[0][0].ToString();
            }
            else
            {
                _InspResult = "X^X";
            }

            if (!string.IsNullOrEmpty(_InspResult))
            {
                string[] arrRes = _InspResult.Split('^');

                lblDay.Text   = arrRes[0] == "X" ? "주간" + "\r\n" + "미진행" : "주간" + "\r\n" + "완료";
                lblNight.Text = arrRes[1] == "X" ? "야간" + "\r\n" + "미진행" : "야간" + "\r\n" + "완료";

                lblDay.BackColor1   = arrRes[0] == "X" ? Color.FromArgb(255, 0, 0) : Color.Lime;
                lblNight.BackColor1 = arrRes[1] == "X" ? Color.FromArgb(255, 0, 0) : Color.Lime;
            }                               
        }
        #region Events           
        #endregion

        #region Methods

        /// <summary>
        /// Attach event handlers
        /// </summary>
        private void AttachEventHandlers()
        {
            btnInspReg._Click += new EventHandler(btnInspReg_Click);
            btnClose._Click   += new EventHandler(btnClose_Click);
        }


        private void DettachEventHandlers()
        {
            btnInspReg._Click -= new EventHandler(btnInspReg_Click);
            btnClose._Click   -= new EventHandler(btnClose_Click);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DettachEventHandlers();
            this.Close();
        }

        /// <summary>
        /// 현재시간 기준으로 주/야 검사등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnInspReg_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(_Date)) { return; }

            int year  = int.Parse(System.DateTime.Now.ToString("yyyy"));
            int month = int.Parse(System.DateTime.Now.ToString("MM"));
            int day   = int.Parse(System.DateTime.Now.ToString("dd"));
            //int hour  = int.Parse(System.DateTime.Now.ToString("H"));
            //int min   = int.Parse(System.DateTime.Now.ToString("m"));
            //int sec   = int.Parse(System.DateTime.Now.ToString("s"));
            DateTime dayBegin = new DateTime(year, month, day, 8,  0, 0, 0);
            DateTime dayEnd   = new DateTime(year, month, day, 20, 0, 0, 0);

            string sDayNight = System.DateTime.Now > dayBegin && System.DateTime.Now < dayEnd ? "D" : "N";

            if (DoSaveInspection(sDayNight) == 1) { DoCheckInspection(); }
            else { MessageBox.Show("등록에 문제가 있습니다. 관리자에 문의하세요!"); }
        } 
                
        /// <summary>
        /// Disabled Button control
        /// </summary>
        /// <param name="mesButton"></param>
        private void DisabledBtnCtrl(MESButton mesButton)
        {
            if (mesButton.ButtonClickType == MESButton.ButtonClickTypeEnum.Click)
            {                
                this.Close();
            }
        }

        /// <summary>
        /// Save down time info
        /// </summary>
        /// <param name="sMode"></param>
        /// <param name="iSeqNo"></param>
        private int DoSaveInspection(string _sDayNight)
        {
            try
            {
                string sRtn = string.Empty;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "USP_DA9995_I2";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE",      _PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", _WorkCenterCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_INSPSTEP",       _sDayNight));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_DATE",           _Date));                                
                                
                return clsDB.gExecute(sqlConnection, sqlCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }  

        #endregion

        #region Properties



        #endregion
    }
}