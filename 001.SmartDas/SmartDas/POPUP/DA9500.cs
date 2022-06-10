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
    public partial class DA9500 : Form
    {
        public string resultString;
        public string[] resultArray;

        public DA9500()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        private void DA9500_Load(object sender, EventArgs e)
        {
            SetGrid();

            DoFind();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 16;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA9500_S1";
            mesGrid1.CountRows = 7;
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            resultString = clsDB.nvlString(e._UltraGridRow.Cells["ItemCode"].Value);

            resultArray = new string[] { resultString, clsDB.nvlString(e._UltraGridRow.Cells["ItemName"].Value) };
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
