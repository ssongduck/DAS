using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDas.Components;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace SmartDas.POPUP
{
    public partial class DA9120 : Form
    {
        private string _PCode   = string.Empty;
        private string _WCode   = string.Empty;
        private string _Date    = string.Empty;
        private string _Shift   = string.Empty;
        private string _OrderNo = string.Empty;

        private string resultString = string.Empty;
        private System.Diagnostics.Process ps;

        int _iSEQ = 0;
        string _sDayNight = string.Empty;

        public string ResultString
        {
            get { return resultString; }
            set { resultString = value;}
        }

        //커밋 테스트

        public DA9120()
        {
            InitializeComponent();  
        }

        public DA9120(string plantcode, string workcentercode, string date, string daynight, string orderno)
        {
            InitializeComponent();


            _PCode = plantcode;
            _WCode = workcentercode;            
            _Shift = daynight;
            _OrderNo = orderno;

            if (daynight == "D")
            {
                txtDayNight.Text = "주간";
                txtDayNight.Tag = "D";
            }
            else if (daynight == "N")
            {
                txtDayNight.Text = "야간";
                txtDayNight.Tag = "N";
            }
            mesGrid1.FontSize  = 12;
            mesGrid1.CountRows = 16;
            mesGrid1.SelectProcedureName = "USP_DA9120_S2";
                        
            //ps = new System.Diagnostics.Process();
            //var path64 = System.IO.Path.Combine(Directory.GetDirectories(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            //var path32 = @"C:\windows\system32\osk.exe";
            //var path = (Environment.Is64BitOperatingSystem) ? path64 : path32;

            //if (File.Exists(path))
            //{
            //    //Process.Start(path);
            //    ps.StartInfo.FileName = path;
            //    ps.Start();
            //}

            this.ActiveControl = txtContent;
            txtContent.Focus();    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ps.Kill();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void DA9120_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 8)
            {
                dtpDate.Value = DateTime.Now.AddHours(-8);
            }
            else
            {
                dtpDate.Value = DateTime.Now;
            }
            _Date = dtpDate.Value.ToString("yyyy-MM-dd");                

            DoFind();
            //var path64 = System.IO.Path.Combine(Directory.GetDirectories(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            //var path32 = @"C:\windows\system32\osk.exe";
            //var path = (Environment.Is64BitOperatingSystem) ? path64 : path32;
            //if (File.Exists(path))
            //{
            //    Process.Start(path);
            //}
            //this.ActiveControl = txtContent;
            //txtContent.Focus();
        }
        private void DoFind()
        {
            try
            {                  
                mesGrid1.GetStoreProcedure();
                mesGrid1.ParameterList.Add(new SqlParameter("@AS_PLANTCODE",      _PCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@AS_WORKCENTERCODE", _WCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@AS_RECDATE",        _Date));                                
                mesGrid1.DoFind();

                //Database database = DatabaseFactory.CreateDatabase();
                //SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                //SqlCommand sqlCommand = new SqlCommand();

                //sqlCommand.CommandText = "USP_DA9120_S1";
                //sqlCommand.CommandType = CommandType.StoredProcedure;

                //sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE",      _PCode));
                //sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", _WCode));
                //sqlCommand.Parameters.Add(new SqlParameter("@AS_RECDATE",        _Date));

                //DataTable dt = new DataTable();

                //clsDB.gCreateRSet(sqlConnection, sqlCommand, dt);

                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        int icount = dt.Rows.IndexOf(dr);
                //        txtContent.Text += string.Format("{0}. {1}", icount, dr["Remarks"].ToString() + "\r\n");
                //    }
                //}                
            }
            catch
            {
            }

        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _Date = dtpDate.Value.ToString("yyyy-MM-dd");
                DoFind();
            }
            catch
            {
            }
        }           

        private string DoSave()
        {
            try
            {                
                //_Date = dtpDate.Value.ToString("yyyy-MM-dd");                

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd  = new SqlCommand();
                cmd.Connection  = conn;
                cmd.CommandText = "USP_DA9120_I2";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add(new SqlParameter("@AS_PLANTCODE",      _PCode));
                cmd.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", _WCode));
                cmd.Parameters.Add(new SqlParameter("@AS_RECDATE",        _Date));
                cmd.Parameters.Add(new SqlParameter("@AS_SHIFT",          txtDayNight.Tag));
                cmd.Parameters.Add(new SqlParameter("@AS_ORDERNO",        _OrderNo));
                cmd.Parameters.Add(new SqlParameter("@AS_REMARK",         txtContent.Text));

                if (clsDB.gExecute(conn, cmd) < 0)
                {                    
                    return clsDB.ErrorDesc;                  
                }
                return "정상적으로 등록되었습니다.";
            }
            catch (Exception ex)
            {
                return ex.Message;             
            }
            finally
            {
                //ps.Kill();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtContent.Text.Trim() == "")
            {                
                return;
            }

            txtContent.Text = txtContent.Editor.CurrentEditText.ToString();
            ResultString = DoSave();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDelete();
        }

        private void DoDelete()
        {

            //dtpDate.Text
            //    _sDayNight
            if (_iSEQ.Equals(0))
            {
                return; 
            }

            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "USP_DA9120_D1";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@AS_PLANTCODE", Common.SelectedWorkCenter.PlantCode));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_SEQ", _iSEQ));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", Common.SelectedWorkCenter.Code));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_RECDATE", dtpDate.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@AS_DayNight", _sDayNight));
                

                clsDB.gExecute(sqlConnection, sqlCommand);


            }
            catch (Exception ex)
            {
                clsDB.Rollback();
            }
            finally
            {
                _iSEQ = 0;
                DoFind();
            }
        }

        private void txtDayNight__Click(object sender, EventArgs e)
        {
            if (txtDayNight.Tag == "D")
            {
                txtDayNight.Text = "야간";
                txtDayNight.Tag = "N";
            }
            else
            {
                txtDayNight.Text = "주간";
                txtDayNight.Tag = "D";
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            _iSEQ = e._UltraGridRow.Cells["Seq"].Value.ToString() == "" ? 0 : Convert.ToInt32(e._UltraGridRow.Cells["Seq"].Value);
            _sDayNight = e._UltraGridRow.Cells["DayNight"].Value.ToString();
        }
 
    }
}
