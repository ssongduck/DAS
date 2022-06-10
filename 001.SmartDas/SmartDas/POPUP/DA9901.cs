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
    public partial class DA9901 : Form
    {
        public string resultString;
        public string[] resultArray = new string[] {"", "" ,"", "", "", ""};
        public string ForkliftCode;

        public DA9901()
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
            //btnListBox_lcategory.RedrawButtons();
            //btnListBox_mCategory.RedrawButtons();
            //btnListBox_sCategory.RedrawButtons();
            SetListBoxError();
        }

        private void SetListBoxError()
        {
            // 대분류
            btnListBox_lcategory.CountX = 3;
            btnListBox_lcategory.CountY = 1;
            btnListBox_lcategory.SelectProcedureName = "USP_DA0802_S1";
            btnListBox_lcategory.SetStoreProc();
            btnListBox_lcategory.ParameterList.Add(new SqlParameter("@pDASDivision", Common.gsDASDivision));
            btnListBox_lcategory.DoFind();
            // 중분류
            btnListBox_mCategory.CountX = 5;
            btnListBox_mCategory.CountY = 4;
            btnListBox_mCategory.SelectProcedureName = "USP_DA0802_S2"; 
            btnListBox_mCategory.SetStoreProc();
            btnListBox_mCategory.ExTag = btnListBox_lcategory.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_mCategory.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_mCategory.DoFind();
            // 소분류
            btnListBox_sCategory.CountX = 6;
            btnListBox_sCategory.CountY = 2;
            btnListBox_sCategory.SelectProcedureName = "USP_DA0802_S3";
            btnListBox_sCategory.SetStoreProc();
            btnListBox_sCategory.ExTag = btnListBox_mCategory.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_sCategory.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_sCategory.DoFind();

            btnListBox_whoRepair.CountX = 1;
            btnListBox_whoRepair.CountY = 2;
            btnListBox_whoRepair.SelectProcedureName = "USP_DA0802_S4";
            btnListBox_whoRepair.SetStoreProc();
            btnListBox_whoRepair.ParameterList.Add(new SqlParameter("@AS_DIV", "1"));
            btnListBox_whoRepair.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_whoRepair.DoFind();

            btnListBox_MoldLocHeader.CountX = 2;
            btnListBox_MoldLocHeader.CountY = 1;
            btnListBox_MoldLocHeader.SelectProcedureName = "USP_DA0802_S4";
            btnListBox_MoldLocHeader.SetStoreProc();
            btnListBox_MoldLocHeader.ParameterList.Add(new SqlParameter("@AS_DIV", "2"));
            btnListBox_MoldLocHeader.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_MoldLocHeader.DoFind();

            btnListBox_MoldLocDetail.CountX = 1;
            btnListBox_MoldLocDetail.CountY = 6;
            btnListBox_MoldLocDetail.SelectProcedureName = "USP_DA0802_S4";
            btnListBox_MoldLocDetail.SetStoreProc();
            btnListBox_MoldLocDetail.ParameterList.Add(new SqlParameter("@AS_DIV", "3"));
            btnListBox_MoldLocDetail.SelectionMode = Components.ButtonBox.SelectionModeEnum.Single;
            btnListBox_MoldLocDetail.DoFind();
        }

        private void btnListBox_lCategory_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (btnListBox_lcategory.GetSelectedButtons()[0].Tag.ToString() == "A01")
            {
                lblAddSelector.Visible = true;
                btnListBox_whoRepair.Visible     = true;
                btnListBox_MoldLocHeader.Visible = false;
                btnListBox_MoldLocDetail.Visible = false;
            }
            else if (btnListBox_lcategory.GetSelectedButtons()[0].Tag.ToString() == "A02")
            {
                lblAddSelector.Visible = true;
                btnListBox_whoRepair.Visible = false;
                btnListBox_MoldLocHeader.Visible = true;
                btnListBox_MoldLocDetail.Visible = true;
            }
            else
            {
                lblAddSelector.Visible = false;
                btnListBox_whoRepair.Visible = false;
                btnListBox_MoldLocHeader.Visible = false;
                btnListBox_MoldLocDetail.Visible = false;
            }
            btnListBox_mCategory.ExTag = btnListBox_lcategory.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_mCategory.CurrentPage = 0;
            btnListBox_mCategory.RedrawButtons();

            btnListBox_whoRepair.ReSetSelectedButtons();
            btnListBox_MoldLocHeader.ReSetSelectedButtons();
            btnListBox_MoldLocDetail.ReSetSelectedButtons();

            resultArray[3] = string.Empty;
            resultArray[4] = string.Empty;
            resultArray[5] = string.Empty;
        }
        private void btnListBox_mCategory_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            btnListBox_sCategory.ExTag = btnListBox_mCategory.GetSelectedButtons()[0].Tag.ToString();
            btnListBox_sCategory.CurrentPage = 0;
            btnListBox_sCategory.RedrawButtons();
        }
        private void btnListBox_sCategory_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
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

        private void btnListBox_whoRepair_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            resultArray[3] = sender.Text;
            resultArray[4] = string.Empty;
            resultArray[5] = string.Empty;
        }

        private void btnListBox_MoldLocHeader_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            resultArray[3] = string.Empty;
            resultArray[4] = sender.Text;
        }

        private void btnListBox_MoldLocDetail_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            resultArray[3] = string.Empty;
            resultArray[5] = sender.Text;
        }
    }
}

