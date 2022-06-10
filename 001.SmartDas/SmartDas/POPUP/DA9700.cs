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
    public partial class DA9700 : Form
    {
        
        public string dWorkcentercode;
        public string dWorkcentername;
        public string dLadlecode;
        public string dLadlename;
        public string ForkliftCode;
        bool bResult = false;

        Hashtable hash = null;

        private Padding _MarginIn;
        private Padding _MarginOut;

        private int _CountX;
        private int _CountY;



        public DA9700()
        {
            InitializeComponent();

            _MarginIn.All = 3;
            _MarginOut.All = 3;

            _CountX = 5;
            _CountY = 5;

            

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        private void DA9700_Load(object sender, EventArgs e)
        {
            btnOK.Text = "요청확인";
            btnOK.Tag = "H";

            txtWorkCenterCode.Text = dWorkcentercode;
            txtWorkCenterName.Text = dWorkcentername;
            txtLadleCode.Text = dLadlecode;
            txtLadleName.Text = dLadlename;
            
            Dofind();

        }

        private void Dofind()
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USP_DA6000_MAIN";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("IN_IP", Common.gsIP));
                cmd.Parameters.Add(new SqlParameter("IN_PLANTCODE", Common.gsPlantCode));
                cmd.Parameters.Add(new SqlParameter("WORKCENTERCODE", txtWorkCenterCode.Text));

                DataTable dt = new DataTable();

                clsDB.gCreateRSet(conn, cmd, dt);

                if (dt.Rows.Count >= 1)
                {
                    txtRequestTime.Text = dt.Rows[0]["STARTDATE"].ToString();
                    txtRemainRate.Text = dt.Rows[0]["RESTQTY"].ToString();
                    txtRequest.Text = dt.Rows[0]["REQUESTSTARTDATE"].ToString();
                    txtDISSStatus.Text = dt.Rows[0]["DISSSTATUSNAME"].ToString();
                    txtFORKLIFTNAME.Text = dt.Rows[0]["RequestWorkerID"].ToString();

                    if (dt.Rows[0]["DISSSTATUS"].ToString() == "H")
                    {
                        btnOK.Text = "보급완료";
                        btnOK.Tag = "S";

                    }

                }

                if (btnOK.Tag.ToString() == "H")
                {
                    txtSuppyRate.Enabled = false;
                    btnDown.Enabled = false;
                    btnUp.Enabled = false;
                }
                else
                {
                    txtSuppyRate.Enabled = true;
                    btnDown.Enabled = true;
                    btnUp.Enabled = true;
                }


            }
            catch (SqlException e2)
            {

            }
        }


    

     

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtLadleCode.Text == "")
                {
                    return;
                }

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "USP_DA9700_I1";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pRequestTime", txtRequestTime.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@RequestWorkerID", ForkliftCode));
                cmd.Parameters.Add(new SqlParameter("@Ladlecode", txtLadleCode.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Stauts", btnOK.Tag));
                cmd.Parameters.Add(new SqlParameter("@DISSQTY", txtSuppyRate.Text.Trim()));



                if (clsDB.gExecute(conn, cmd) < 0)
                {
                    // 오류 발생시
                    //SetMessage(clsDB.ErrorDesc);
                    return;
                }
                else
                {
                    Dofind();
                    //if (btnOK.Tag.ToString() == "S")
                    //{
                    //   // BaseForm.("보급이 완료 되었습니다");
                    //    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    //}
                }
            }
            catch (Exception oe)
            {
                // SetMessage(oe.Message);
                clsDB.Rollback();
            }
            finally
            {
                if (txtDISSStatus.Text == "")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (txtSuppyRate.Text.Trim() == "100")
            {
                return;
            }
            else
            {
                txtSuppyRate.Text = Convert.ToString(Convert.ToInt16(txtSuppyRate.Text.Trim()) + 5);
            }
        
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (txtSuppyRate.Text.Trim() == "0")
            {
                return;
            }
            else
            {
                txtSuppyRate.Text = Convert.ToString(Convert.ToInt16(txtSuppyRate.Text.Trim()) - 5);
            }
        }

      


    }
}

