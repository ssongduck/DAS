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
    public partial class DA9600 : Form
    {
        public string sRemainQty;
        public bool bLotcard;

        public DA9600()
        {
            InitializeComponent();
        }

        private void DA9600_Load(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtMessage.Text += "작업 내역과 미처리잔량을 확인하여 주시기 바랍니다.  \r\n";
            txtMessage.Text += "작업을 종료하시겠습니까?";
            txtMessage.Text += "\r\n\r\n ※ 미처리잔량 : 생산수량 중, LOT 카드 미발행수량";
         
            //if (Common.gsDASDivision == "C")     // 주조
                txtMessage.Text += "\r\n\r\n ※ 잔량의 Lot카드가 발행됩니다.";

            txtRemainQty.Text = sRemainQty;

            SetButtons();
              
        }

        private void SetButtons()
        {
            btnBox.CountX = 2;
            btnBox.CountY = 1;

            btnBox.SetButtons();

            btnBox[0, 0].Tag = DialogResult.OK;
            btnBox[0, 0].Text = "확인";
            if (Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).OrderCount == 0)
                btnBox[0, 0].UseFlag = false;
            btnBox[0, 1].Tag = DialogResult.Cancel;
            btnBox[0, 1].Text = "취소";

            btnBox.RedrawButtons();
        }

        private void btnBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            bLotcard = this.radioButtonY.Checked;
           
            this.DialogResult = (DialogResult)(sender.Tag);
        }

        private void txtRemainQty_Click(object sender, EventArgs e)
        {
            DA9100 d = new DA9100();
            d.LabelTitle = "생산수량 입력";
            d.LabelHeader = "생산수량";

            if (DialogResult.OK == d.ShowDialog())
            {
                sRemainQty = d.ResultString;
                txtRemainQty.Text = sRemainQty;
            }
        }
    }
}
