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

namespace SmartDas.POPUP
{
    public partial class DA9140 : Form
    {
        private int iMul = 1;
        private double resultDouble  = 0;
        private string resultTime = "";
        private string resultYear = "";
        private string resultDate = "";

        public double ResultDouble
        {
            get { return resultDouble; }
        }
        public string ResultRegTime
        {
            get { return resultTime; }
        }
        public string ResultRegYear
        {
            get { return resultYear; }
        }
        public string ResultRegDate
        {
            get { return resultDate; }
        }

        [DllImport("user32.dll")]
        static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public DA9140()
        {
            InitializeComponent();
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

        private void DA9140_Load(object sender, EventArgs e)
        {
            SetButtonBox();

            this.TopMost = true;
        }

        private void SetButtonBox()
        {
            buttonBox1.CountX = 4;
            buttonBox1.CountY = 4;

            buttonBox1.Font = new System.Drawing.Font(buttonBox1.Font.FontFamily, 30);
            buttonBox1.SetButtons();

            buttonBox1[0, 0].Text = "7";
            buttonBox1[0, 1].Text = "8";
            buttonBox1[0, 2].Text = "9";
            buttonBox1[0, 3].Text = "◀";
            buttonBox1[1, 0].Text = "4";
            buttonBox1[1, 1].Text = "5";
            buttonBox1[1, 2].Text = "6";
            buttonBox1[1, 3].Text = "모두지움";
            buttonBox1[2, 0].Text = "1";
            buttonBox1[2, 1].Text = "2";
            buttonBox1[2, 2].Text = "3";
            buttonBox1[2, 3].Text = "확인"; 
            buttonBox1[3, 0].Text = "0";
            buttonBox1[3, 1].Text = ".";
            buttonBox1[3, 2].Text = "-";
            buttonBox1[3, 3].Text = "취소";

            buttonBox1[2, 3].MappingButton.BackColor = Color.Green;
            buttonBox1[2, 3].Font = new Font(buttonBox1.Font, FontStyle.Bold);
            buttonBox1[3, 3].MappingButton.BackColor = Color.DeepPink;
            buttonBox1[3, 3].Font = new Font(buttonBox1.Font, FontStyle.Bold);

            buttonBox1.RedrawButtons();
        }

        private void buttonBox1_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            txtContent.Focus();

            MESButton btn = (MESButton)sender;

            string s = btn.Text.ToUpper();

            if (s == "")
                return;

            byte b = (byte)s[0];
            //txtContent.Text += btn.Text.Trim();
            switch (s)
            {
                case ".":
                    //if (txtContent.Text.Trim() == "")
                    //{
                    //    txtContent.Text = "0.";
                    //    txtContent.Focus();
                    //    txtContent.Select(txtContent.Text.Length, 0);
                    //    break;
                    //}
                    //else
                    //{
                    //    if (txtContent.Text.IndexOf(".") >= 0)
                    //    {
                    //        break;
                    //    }
                    //}
                    //keybd_event((byte)Keys.OemPeriod, 0, 0, 0);
                    //keybd_event((byte)Keys.OemPeriod, 0, 0x02, 0);
                    break;
                case "-":
                    //if (txtContent.Text.Trim() != "")
                    //{
                    //    iMul = -1;
                    //    //txtContent.Text = "-" + txtContent.Text;
                    //    btn.Text = "+";
                    //    txtContent.Focus();
                    //    txtContent.Select(txtContent.Text.Length, 0);
                    //}
                    //else
                    //{
                    //    iMul = -1;
                    //    btn.Text = "+";
                    //}
                    break;
                case "+":
                    //if (txtContent.Text.Trim() != "")
                    //{
                    //    iMul = 1;
                    //    //txtContent.Text = txtContent.Text.Substring(1);
                    //    btn.Text = "-";
                    //    txtContent.Focus();
                    //    txtContent.Select(txtContent.Text.Length, 0);
                    //}
                    //else
                    //{
                    //    iMul = 1;
                    //    btn.Text = "-";
                    //}
                    break;
                case "모두지움":
                    txtContent.Text = "";
                    break;
                case "◀":
                    keybd_event((byte)Keys.Back, 0, 0, 0);
                    keybd_event((byte)Keys.Back, 0, 0x02, 0);
                    break;
                case "확인":
                    resultTime = txtContent.Text.Trim();
                    resultYear = dtpDate.Value.ToString("yyyy");;
                    resultDate = dtpDate.Value.ToString("MM-dd");;
                   // resultDouble = resultString == "" ? 0 : Convert.ToDouble(resultString.Replace(",",""));
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
                case "00":
                    keybd_event(b, 0, 0, 0);
                    keybd_event(b, 0, 0x02, 0);
                    keybd_event(b, 0, 0, 0);
                    keybd_event(b, 0, 0x02, 0);
                    break;
                default:
                    keybd_event(b, 0, 0, 0);
                    keybd_event(b, 0, 0x02, 0);
                    break;
            }

            //if (txtContent.Text.Trim().Length >= 1)
            //{
            //    if (iMul == 1 && txtContent.Text.Trim().StartsWith("-"))
            //    {
            //        txtContent.Text = txtContent.Text.Trim().Substring(1);
            //    }
            //    else if ( iMul == -1 && !txtContent.Text.Trim().StartsWith("-") )
            //    {
            //        txtContent.Text = "-" + txtContent.Text;
            //    }

            //    if (txtContent.Text.Trim() == "-")
            //    {
            //        txtContent.Text = "";
            //    }

            //    if ( txtContent.Text.Trim() == "-0")
            //    {
            //        txtContent.Text = "0";
            //    }
                
            //    if (txtContent.Text.Trim() == "00" || txtContent.Text.Trim() == "-00")
            //    {
            //        txtContent.Text = "0";
            //    }

            //    txtContent.Focus();
            //    txtContent.Select(txtContent.Text.Length, 0);
            //}

            txtContent.Focus();
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            txtContent.Focus();

            keybd_event((byte)Keys.End, 0, 0, 0);
            keybd_event((byte)Keys.End, 0, 0x02, 0);
        }

        private void DA9140_Activated(object sender, EventArgs e)
        {
            txtContent.Focus();
        }

    }
}
