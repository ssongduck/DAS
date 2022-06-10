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
    public partial class DA9530 : Form
    {
        public string sOrderNo;
        
        public DA9530()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void DA9530_Load(object sender, EventArgs e)
        {
            SetGrid();

            DoFind();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 16;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA9530_S1";
            mesGrid1.CountRows = 7;
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sOrderNo))
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridRow != null && e._UltraGridRow.Index >= 0)
            {
                sOrderNo = clsDB.nvlString(e._UltraGridRow.Cells["OrderNo"].Value);
                txtOrderNo.Text = sOrderNo;
            }
        }



     
    }
}
