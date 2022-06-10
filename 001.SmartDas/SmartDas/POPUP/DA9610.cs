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
    public partial class DA9610 : Form
    {
        public string sRemainQty;
        public bool bLotcard;

        public DA9610()
        {
            InitializeComponent();
        }

        private void DA9610_Load(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtMessage.Text += "실적을 등록하였습니다.  \r\n\r\n";
            txtMessage.Text += "LOT카드를 인쇄하였습니다. \r\n\r\n";
            txtMessage.Text += "(인쇄되지 않은경우 작업현황 화면에서 재발행하십시오)\r\n ";
             
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}
