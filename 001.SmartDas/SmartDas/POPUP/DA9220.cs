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
    public partial class DA9220 : Form
    {
        public string resultString;

        [DllImport("user32.dll")]
        static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        [DllImport("imm32.dll", CharSet = CharSet.Auto)]
        public static extern int ImmGetContext(int hWnd);

        //[DllImport("imm32.dll", CharSet = CharSet.Auto)]
        //public static extern int ImmReleaseContext(int hWnd, int hImc);

        //[DllImport("imm32.dll", CharSet = CharSet.Auto)]
        //public static extern int ImmGetConversionStatus(int hImc, out int fdwConversion, out int fdwSentence);
        [DllImport("imm32.dll")]
        public static extern int ImmSetConversionStatus(int himc, int dw1, int dw2); 

        public DA9220()
        {
            InitializeComponent();

            this.TopMost = true;
            ImmSetConversionStatus((ImmGetContext((int)this.txtContent.Handle)), 0, 0);
 
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

        private void DA9220_Load(object sender, EventArgs e)
        {
            SetButtonBox();
            txtContent.Text = resultString.ToString();
        }

        private void SetButtonBox()
        {
            //bBox1.Font = new System.Drawing.Font(bBox1.Font.FontFamily, 28);
            
            //bBox1.SetButtons();

            //bBox1[0, 0].Text = "1";
            //bBox1[0, 1].Text = "2";
            //bBox1[0, 2].Text = "3";
            //bBox1[0, 3].Text = "4";
            //bBox1[0, 4].Text = "5";
            //bBox1[0, 5].Text = "6";
            //bBox1[0, 6].Text = "7";
            //bBox1[0, 7].Text = "8";
            //bBox1[0, 8].Text = "9";
            //bBox1[0, 9].Text = "0";

            //bBox1[1, 0].Text = "Q";
            //bBox1[1, 1].Text = "W";
            //bBox1[1, 2].Text = "E";
            //bBox1[1, 3].Text = "R";
            //bBox1[1, 4].Text = "T";
            //bBox1[1, 5].Text = "Y";
            //bBox1[1, 6].Text = "U";
            //bBox1[1, 7].Text = "I";
            //bBox1[1, 8].Text = "O";
            //bBox1[1, 9].Text = "P";

            //bBox1[2, 0].Text = "A";
            //bBox1[2, 1].Text = "S";
            //bBox1[2, 2].Text = "D";
            //bBox1[2, 3].Text = "F";
            //bBox1[2, 4].Text = "G";
            //bBox1[2, 5].Text = "H";
            //bBox1[2, 6].Text = "J";
            //bBox1[2, 7].Text = "K";
            //bBox1[2, 8].Text = "L";
            //bBox1[2, 9].Text = ".";

            //bBox1[3, 0].Text = "Z";
            //bBox1[3, 1].Text = "X";
            //bBox1[3, 2].Text = "C";
            //bBox1[3, 3].Text = "V";
            //bBox1[3, 4].Text = "B";
            //bBox1[3, 5].Text = "N";
            //bBox1[3, 6].Text = "M";
            //bBox1[3, 7].Text = "-";
            //bBox1[3, 8].Text = "_";
            //bBox1[3, 9].Text = "/";

            //bBox1.RedrawButtons();
        }
        private void btn_type(string s)
        {

            keybd_event((byte)Keys.End, 0, 0, 0);
            keybd_event((byte)Keys.End, 0, 0x02, 0);

            if (s == "")
                return;

            byte b = (byte)s[0];

            switch (s)
            {
                case ",":
                    keybd_event((byte)Keys.Oemcomma, 0, 0, 0);
                    keybd_event((byte)Keys.Oemcomma, 0, 0x02, 0);
                    break;
                case ".":
                    keybd_event((byte)Keys.OemPeriod, 0, 0, 0);
                    keybd_event((byte)Keys.OemPeriod, 0, 0x02, 0);
                    break;
                case "Ø":
                    txtContent.Text += "Ø";
                    //keybd_event((byte)Keys., 0, 0, 0);
                    //keybd_event((byte)Keys.OemPeriod, 0, 0x02, 0);
                    break;
                case "'":
                    txtContent.Text += "'";
                    //keybd_event((byte)Keys., 0, 0, 0);
                    //keybd_event((byte)Keys.OemPeriod, 0, 0x02, 0);
                    break;
                case "-":
                    keybd_event((byte)Keys.OemMinus, 0, 0, 0);
                    keybd_event((byte)Keys.OemMinus, 0, 0x02, 0);
                    break;
                case "_":
                    keybd_event((byte)Keys.LShiftKey, 0, 0, 0);
                    keybd_event((byte)Keys.OemMinus, 0, 0, 0);
                    keybd_event((byte)Keys.OemMinus, 0, 0x02, 0);
                    keybd_event((byte)Keys.LShiftKey, 0, 0x02, 0);
                    break;
                case "/":
                    keybd_event((byte)Keys.OemQuestion, 0, 0, 0);
                    keybd_event((byte)Keys.OemQuestion, 0, 0x02, 0);
                    break;
                default:
                    //if (btnChnage.Text == "대문자" && !((int)b >= (int)'0' && (int)b <= (int)'9') )
                    //{
                    //    keybd_event((byte)Keys.LShiftKey, 0, 0, 0);
                    //    keybd_event(b, 0, 0, 0);
                    //    keybd_event(b, 0, 0x02, 0);
                    //    keybd_event((byte)Keys.LShiftKey, 0, 0x02, 0);
                    //}
                    //else
                    //{
                    //    keybd_event(b, 0, 0, 0);
                    //    keybd_event(b, 0, 0x02, 0);
                    //}
                    break;
            }

            txtContent.Focus();

        }

        private void buttonBox1_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            //txtContent.Focus();

            //MESButton btn = (MESButton)sender;

            //string s = btn.Text.ToUpper();

            //if (s == "")
            //    return;

            //byte b = (byte)s[0];

            //switch (s)
            //{
            //    case ".":
            //        keybd_event((byte)Keys.OemPeriod, 0, 0, 0);
            //        keybd_event((byte)Keys.OemPeriod, 0, 0x02, 0);
            //        break;
            //    case "-":
            //        keybd_event((byte)Keys.OemMinus, 0, 0, 0);
            //        keybd_event((byte)Keys.OemMinus, 0, 0x02, 0);
            //        break;
            //    case "_":
            //        keybd_event((byte)Keys.LShiftKey, 0, 0, 0);
            //        keybd_event((byte)Keys.OemMinus, 0, 0, 0);
            //        keybd_event((byte)Keys.OemMinus, 0, 0x02, 0);
            //        keybd_event((byte)Keys.LShiftKey, 0, 0x02, 0);
            //        break;
            //    case "/":
            //        keybd_event((byte)Keys.OemQuestion, 0, 0, 0);
            //        keybd_event((byte)Keys.OemQuestion, 0, 0x02, 0);
            //        break;
            //    default:
            //        if (btnChnage.Text == "대문자" && (e.x > 0))
            //        {
            //            keybd_event((byte)Keys.LShiftKey, 0, 0, 0);
            //            keybd_event(b, 0, 0, 0);
            //            keybd_event(b, 0, 0x02, 0);
            //            keybd_event((byte)Keys.LShiftKey, 0, 0x02, 0);
            //        }
            //        else
            //        {
            //            keybd_event(b, 0, 0, 0);
            //            keybd_event(b, 0, 0x02, 0);
            //        }
            //        break;
            //}

            //txtContent.Focus();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //txtContent.Focus();
            
            MESButton btn = (MESButton)sender;

            switch (btn.Text)
            {
                case " ":
                    keybd_event((byte)Keys.Space, 0, 0, 0);
                    keybd_event((byte)Keys.Space, 0, 0x02, 0);
                    break;
                //case "대문자":
                //    foreach (ButtonData b in bBox1.GetButtonList())
                //    {
                //        b.Text = b.Text.ToLower();
                //    }
                //    btn.Text = "소문자";
                //    break;
                //case "소문자":
                //    foreach (ButtonData b in bBox1.GetButtonList())
                //    {
                //        b.Text = b.Text.ToUpper();
                //    }
                //    btn.Text = "대문자";
                //    break;
                case "모두지움":
                    txtContent.Text = "";
                    break;
                case "◀":
                    keybd_event((byte)Keys.Back, 0, 0, 0);
                    keybd_event((byte)Keys.Back, 0, 0x02, 0);
                    break;
                case "확인":
                    resultString = txtContent.Editor.CurrentEditText.ToString();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }

            txtContent.Focus();
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            txtContent.Focus();

            keybd_event((byte)Keys.End, 0, 0, 0);
            keybd_event((byte)Keys.End, 0, 0x02, 0);
        }

        private void DA9220_Activated(object sender, EventArgs e)
        {
            txtContent.Focus();
        }

        #region  [버튼 이벤트]
        private void but_Click(object sender, EventArgs e)
        {
           
            //keybd_event((byte)Keys.End, 0, 0, 0);
            //keybd_event((byte)Keys.End, 0, 0x02, 0);
            Infragistics.Win.Misc.UltraButton btn = (Infragistics.Win.Misc.UltraButton)sender;
           
            string s = btn.Text.ToUpper();
            
            btn_type(s);
           
        }

      
        #endregion
    }
}
