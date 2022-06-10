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
    public partial class DA9620 : Form
    {
        public string sRemainQty;
        public bool bLotcard;

        public DA9620()
        {
            InitializeComponent();
        }

        private void DA9620_Load(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
              
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
           // this.Close();
        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //this.Close();
        }

     }
}
