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
    public partial class DA9400 : Form
    {
        private string[] sParamLIst;
        public string resultString;
        bool bResult = false;

        Hashtable hash = null;

        private Padding _MarginIn;
        private Padding _MarginOut;

        private int _CountX;
        private int _CountY;

        public DA9400(string[] sArr)
        {
            InitializeComponent();

            _MarginIn.All = 3;
            _MarginOut.All = 3;

            _CountX = 5;
            _CountY = 5;

            sParamLIst = sArr;

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        public string LabelHeader
        {
            get { return labHeader.Text; }
            set { labHeader.Text = value; }
        }

        public string ContentText
        {
            get { return txtContent.Text; }
            set { txtContent.Text = value; }
        }

        private void DA9400_Load(object sender, EventArgs e)
        {
            SetButtonBox();

            SetUltraButton();

            if (bResult)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }

        private void SetUltraButton()
        {
            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection dconn = (SqlConnection)db.CreateConnection();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = null; 
                if (sParamLIst.Length == 3)
                {
                    txtContent.Text = sParamLIst[2];

                    cmd = (SqlCommand)db.GetStoredProcCommand("USP_BM3652_S1");

                    cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pItemCode", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pInspCode", SqlDbType.VarChar));

                    cmd.Parameters["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
                    cmd.Parameters["@pItemCode"].Value = sParamLIst[0];
                    cmd.Parameters["@pInspCode"].Value = sParamLIst[1];
                }
                else if (sParamLIst.Length == 4)
                {
                    txtContent.Text = sParamLIst[3];

                    cmd = (SqlCommand)db.GetStoredProcCommand("USP_BM3662_S1");

                    cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pOPCode", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pMachCode", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@pInspCode", SqlDbType.VarChar));

                    cmd.Parameters["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
                    cmd.Parameters["@pOPCode"].Value = sParamLIst[0];
                    cmd.Parameters["@pMachCode"].Value = sParamLIst[1];
                    cmd.Parameters["@pInspCode"].Value = sParamLIst[2];
                }

                if (clsDB.gCreateRSet(dconn, cmd, ds) )
                {
                    for (int i = 0; i < ds.Tables.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                txtInspName.Text = clsDB.nvlString(ds.Tables[i].Rows[0]["InspName"]);
                                break;
                            case 1:
                                string[] iList = new string[25];

                                bResult = ds.Tables[i].Rows.Count <= 1;

                                foreach (DataRow dr in ds.Tables[i].Rows)
                                {
                                    int idx = clsDB.nvlInt(dr["Seq"]);
                                    string sValue = clsDB.nvlString(dr["VALUE"]);

                                    iList[idx] = sValue;
                                }

                                for (int j = 0; j < 25; j++)
                                {
                                    int iRow = j / 5;
                                    int iRem = j % 5;

                                    ((UltraButton)hash[iRow.ToString() + " " + iRem.ToString()]).Text = clsDB.nvlString(iList[j]);
                                }

                                break;
                        }
                    }                
                }
            }
            catch (Exception )
            {
            }
            finally
            {
                if (dconn.State != ConnectionState.Closed)
                {
                    dconn.Close();
                }
            }
        }

        private void SetButtonBox()
        {
            int thisWidth = panel1.Width;
            int thisHeight = panel1.Height;

            int pWidth;
            int pHeight;

            pWidth = (thisWidth - (_MarginOut.Left + _MarginOut.Right) - ((_CountX - 1) * (_MarginIn.Left + _MarginIn.Right))) / _CountX;
            pHeight = (thisHeight - (_MarginOut.Top + _MarginOut.Bottom) - ((_CountY - 1) * (_MarginIn.Top + _MarginIn.Bottom))) / _CountY;

            hash = new Hashtable();

            for (int i = 0; i < _CountY; i++)
            {
                for (int j = 0; j < _CountX; j++)
                {
                    int iLeft = _MarginOut.Left + (j * (_MarginIn.Left + _MarginIn.Right + pWidth));
                    int iTop = _MarginOut.Top + (i * (_MarginIn.Top + _MarginIn.Bottom + pHeight));

                    UltraButton t = new UltraButton();

                    t.Left = iLeft;
                    t.Top = iTop;
                    t.Width = pWidth;
                    t.Height = pHeight;

                    t.Name = "BtnBox " + i.ToString() + " " + j.ToString();
                    t.Tag = i.ToString() + " " + j.ToString();
                    t.Text = "";

                    t.Font = new System.Drawing.Font(t.Font.FontFamily, 20, FontStyle.Bold);

                    hash.Add(i.ToString() + " " + j.ToString(), t);

                    panel1.Controls.Add(t);

                    t.Click += new EventHandler(Button_Click);
                    t.MouseDoubleClick += new MouseEventHandler(Button_MouseDoubleClick);
                }
            }
        }

        void Button_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtContent.Text = ((UltraButton)sender).Text;
            resultString = txtContent.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        void Button_Click(object sender, EventArgs e)
        {
            string sText = ((UltraButton)sender).Text;

            if (sText == "직접 입력")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                txtContent.Text = sText;

                if (sText != "")
                {
                    resultString = txtContent.Text;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            resultString = txtContent.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
