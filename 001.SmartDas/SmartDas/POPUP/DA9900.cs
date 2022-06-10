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
    public partial class DA9900 : Form
    {
        public string resultString;
        public string[] resultArray = new string[] {"", "" ,""};
        public string ForkliftCode;

        public DA9900()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        public string LabelTitle
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value;}
        }

        private void DA9900_Load(object sender, EventArgs e)
        {
            SetListBoxError();

        }

        private void SetListBoxError()
        {
            btnListBox_Stop.CountX = 3;
            btnListBox_Stop.CountY = 1;
            if (Common.gsPlantCode == "SK1") { btnListBox_Stop.SelectProcedureName = "USP_DA0800_S1"; } else { btnListBox_Stop.SelectProcedureName = "USP_DA0801_S1"; }
            btnListBox_Stop.SetStoreProc();
            btnListBox_Stop.ParameterList.Add(new SqlParameter("@pDASDivision", Common.gsDASDivision));
            btnListBox_Stop.DoFind();

            btnListBox_StopList.CountX = 5;
            btnListBox_StopList.CountY = 4;
            if (Common.gsPlantCode == "SK1") { btnListBox_StopList.SelectProcedureName = "USP_DA0800_S2"; } else { btnListBox_StopList.SelectProcedureName = "USP_DA0801_S2"; }
            btnListBox_StopList.SetStoreProc();
            btnListBox_StopList.ExTag = btnListBox_Stop.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_StopList.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_StopList.DoFind();
        }
  
        private void btnListBox_Stop_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            btnListBox_StopList.ExTag = btnListBox_Stop.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_StopList.CurrentPage = 0;

            btnListBox_StopList.RedrawButtons();
        }


        private void btnListBox_StopList_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            resultArray[1] = sender.Text;
            resultArray[0] = sender.Tag.ToString();
            resultArray[2] = sender.ExTag.ToString();
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
