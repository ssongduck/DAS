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
    /// DA9999 Check Password popup form class
    /// </summary>
    public partial class DA9999 : Form
    {
        #region Variables

        /// <summary>
        /// Password
        /// </summary>
        private string _sPassword = string.Empty;

        #endregion

        #region Constructor

        /// <summary>
        /// DA9999 constructor
        /// </summary>
        public DA9999()
        {
            InitializeComponent();
            this.TopMost = true;
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
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            _sPassword = txtPassword.Text;
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

        #region Property

        /// <summary>
        /// Password property
        /// </summary>
        public string Password
        {
            get { return _sPassword; }
            set { _sPassword = value; }
        }

        #endregion
    }
}