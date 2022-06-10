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
    public partial class DA9996 : Form
    {
        #region Variables
        
        /// <summary>
        /// Remark
        /// </summary>
        private string _Remark = string.Empty;

        #endregion

        #region Constructor

        /// <summary>
        /// DA9996 constructor
        /// </summary>
        /// <param name="sRemark"></param>
        public DA9996(string sRemark)
        {
            InitializeComponent();
            this.TopMost = true;
            this.CenterToScreen();

            txtRemark.Text = sRemark;
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
            _Remark = txtRemark.Text;

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

        #endregion

        #region Method

        

        #endregion

        #region Property

        /// <summary>
        /// Remark
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        #endregion
    }
}