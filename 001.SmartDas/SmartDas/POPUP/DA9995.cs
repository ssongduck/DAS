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
    public partial class DA9995 : Form
    {
        #region Variables

        /// <summary>
        /// WorkCenter code
        /// </summary>
        WorkCenter workCenter = Common.SelectedWorkCenter;


        string _WorkCenterCode = string.Empty;
        string _PlantCode      = string.Empty;
        string _Date           = string.Empty;


        #endregion

        #region Constructors

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        public DA9995()
        {
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();                        
        }

        public string GetDate(string _OrderNo)
        {
            if (string.IsNullOrEmpty(_OrderNo)) { return "";}
            
            string yy = _OrderNo.Substring(0, 2);
            string mm   = _OrderNo.Substring(2, 2);
            string dd   = _OrderNo.Substring(4, 2);

            return "20" + yy + "-" + mm + "-" + dd;
        }

        /// <summary>
        /// DA9997 constructor
        /// </summary>
        /// <param name="breakDownName"></param>
        /// <param name="breakDownCode"></param>
        public DA9995(string _sPlantCode, string _sWorkCenterCode, string _sOrderNo)
        {            
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();

            _PlantCode      = _sPlantCode;
            _WorkCenterCode = _sWorkCenterCode;                        
            _Date           =  GetDate(_sOrderNo);            
        }
         
        #endregion

        #region Events        
   


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

            btnFirst._Click  += new EventHandler(btnFirst_Click);
            btnMiddle._Click += new EventHandler(btnMiddle_Click);
            btnEnd._Click    += new EventHandler(btnEnd_Click);
        }

        void btnEnd_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = false;
            btnEnd.Enabled = false;

            if (SaveInsp("E") != -1) { this.Close(); }
        }

        void btnMiddle_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = false;
            btnEnd.Enabled = false;

            if (SaveInsp("M") != -1) { this.Close(); }
        }

        void btnFirst_Click(object sender, EventArgs e)
        {
            btnMiddle.Enabled = false;
            btnEnd.Enabled = false;

            if (SaveInsp("F") != -1) { this.Close(); }
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

        private DataTable CheckInsp(string _sInspStep)
        {
            try
            {
                string sRtn = string.Empty;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SP_DA9995_I1";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@AS_DATE", _Date));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", _WorkCenterCode));
                
                DataTable dt = new DataTable();

                clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        /// <summary>
        /// Save down time info
        /// </summary>
        /// <param name="sMode"></param>
        /// <param name="iSeqNo"></param>
        private int SaveInsp(string _sInspStep)
        {
            try
            {
                string sRtn = string.Empty;

                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "USP_DA9995_I1";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE", _PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", _WorkCenterCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_INSPSTEP", _sInspStep));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_DATE", _Date));                                
                                
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