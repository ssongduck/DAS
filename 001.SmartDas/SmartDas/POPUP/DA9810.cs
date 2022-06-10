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
    public partial class DA9810 : Form
    {
        public string resultString;
        public string[] resultArray;
        public string ForkliftCode;

        public DA9810()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        private void DA9810_Load(object sender, EventArgs e)
        {
            SetGrid();

        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA9810_S1";
            mesGrid1.CountRows = 11;
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.gsPlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pMoldName", txtMoldNM.Text));
            mesGrid1.ParameterList.Add(new SqlParameter("@pCarType", txtCarType.Text));
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

            txtladlecode.Text = clsDB.nvlString(e._UltraGridRow.Cells["MoldCode"].Value);
            txtladlename.Text = clsDB.nvlString(e._UltraGridRow.Cells["Moldname"].Value) + ":" + clsDB.nvlString(e._UltraGridRow.Cells["CarType"].Value) + ":" + clsDB.nvlString(e._UltraGridRow.Cells["Itemname"].Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "USP_DA7000_I1";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", "MR01"));
                cmd.Parameters.Add(new SqlParameter("@pMoldCode", txtladlecode.Text));
                cmd.Parameters.Add(new SqlParameter("@RecDate", SqlDbType.VarChar, 10));
                cmd.Parameters["@RecDate"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@Seq", SqlDbType.Int));
                cmd.Parameters["@Seq"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@pEmergencyFlag", "N"));
                cmd.Parameters.Add(new SqlParameter("@pCauseFlag", "M"));
                cmd.Parameters.Add(new SqlParameter("@pErrorWorker", ""));

                if (clsDB.gExecute(conn, cmd) < 0)
                {
                    return;
                }

                 
            }
            catch (Exception oe)
            {
                // SetMessage(oe.Message);
                clsDB.Rollback();
            }


          //  resultArray = new string[] { txtladlecode.Text.Trim(), txtladlename.Text.Trim() };
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            DoFind();
         }
    }
}
