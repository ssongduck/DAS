using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDas.Components;

namespace SmartDas.POPUP
{
    public partial class DA9300 : Form
    {
        private int _ButtonCount;
        private int _MaxButtonCount;

        private int _returnValue;

        public string[] ButtonNames = { "확인", "취소", "", "" };

        public DA9300()
        {
            InitializeComponent();

            this.TopMost = true;

            _MaxButtonCount = 4;
        }

        public int ButtonCount
        {
            get { return _ButtonCount; }
            set
            {
                if (_MaxButtonCount < value)
                {
                    _ButtonCount = _MaxButtonCount;

                    MessageBox.Show(_MaxButtonCount + "개 이상 입력할 수 없습니다.");
                    return;
                }

                if (value < 0)
                {
                    _ButtonCount = 1;

                    MessageBox.Show("0 이하일 수 없습니다.");
                    return;
                }

                _ButtonCount = value;
            }
        }

        public int MaxButtonCount
        {
            get { return _MaxButtonCount; }
        }

        private void DA9300_Load(object sender, EventArgs e)
        {
            btnBox.CountX = ButtonCount;
            btnBox.Font = new Font(btnBox.Font.FontFamily, 34);

            if (_ButtonCount == 2)
            {
                this.Width = 400;
                btnBox.SetButtons();

                btnBox[0, 0].Text = ButtonNames[0];
                btnBox[0, 1].Text = ButtonNames[1];
            }

            if (_ButtonCount == 3)
            {
                this.Width = 530;
                btnBox.SetButtons(); 
                btnBox[0, 0].Text = ButtonNames[0];
                btnBox[0, 1].Text = ButtonNames[1];
                btnBox[0, 2].Text = ButtonNames[2];
            }

            if (_ButtonCount == 4)
            {
                this.Width = 670;
                btnBox.SetButtons();
                btnBox[0, 0].Text = ButtonNames[0];
                btnBox[0, 1].Text = ButtonNames[1];
                btnBox[0, 2].Text = ButtonNames[2];
                btnBox[0, 3].Text = ButtonNames[3];
            }

            btnBox.RedrawButtons();
        }

        private void btnBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            MESButton btn = (MESButton)sender;

            if (btn.Text == "취소")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else if ( btn.Text == "삭제")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else 
            {
                _returnValue = e._Y;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        public int ReturnValue
        {
            get { return _returnValue; }
        }
    }
}
