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
    public partial class DA9800 : Form
    {
        public string resultString;
        public string[] resultArray;
        public string ForkliftCode;

        public DA9800()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        private void DA9800_Load(object sender, EventArgs e)
        {
            SetGrid();

            DoFind();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 16;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA9800_S1";
            mesGrid1.CountRows = 7;
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.gsPlantCode));
            //mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));

            mesGrid1.DoFind();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            //resultString = clsDB.nvlString(e.row.Cells["ladlecode"].Value);

            //resultArray = new string[] { resultString, clsDB.nvlString(e.row.Cells["ladlename"].Value) };
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;

            txtladlecode.Text = clsDB.nvlString(e._UltraGridRow.Cells["ladlecode"].Value);
            txtladlename.Text = clsDB.nvlString(e._UltraGridRow.Cells["ladlename"].Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "USP_DA9800_I1";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                cmd.Parameters.Add(new SqlParameter("@ForkLiftCode", ForkliftCode));
                cmd.Parameters.Add(new SqlParameter("@pNLadlecode", txtladlecode.Text.Trim()));
                
                
                if (clsDB.gExecute(conn, cmd) < 0)
                {
                    // 오류 발생시
                    //SetMessage(clsDB.ErrorDesc);
                    return;
                }
               
            }
            catch (Exception oe)
            {
                // SetMessage(oe.Message);
                clsDB.Rollback();
            }


            resultArray = new string[] { txtladlecode.Text.Trim(), txtladlename.Text.Trim() };
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
