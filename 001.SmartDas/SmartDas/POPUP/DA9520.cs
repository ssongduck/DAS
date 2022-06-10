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
    public partial class DA9520 : Form
    {
        public string bOrderNo;
        

        public DA9520()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void DA9520_Load(object sender, EventArgs e)
        {
            SetGrid();

            DoFind();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 16;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA9520_S1";
            mesGrid1.CountRows = 7;
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pOrderNo", bOrderNo));

            mesGrid1.DoFind();
            try
            {
                txtItemCode.Text = mesGrid1.DataSourceDS.Tables[2].Rows[0]["itemcode"].ToString();
                txtItemName.Text = mesGrid1.DataSourceDS.Tables[2].Rows[0]["itemname"].ToString();
            }
            catch { }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

     
    }
}
