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
    /// <summary>
    /// DA9994 popup form class
    /// </summary>
    public partial class DA9993 : Form
    {
        #region Variables

        /// <summary>
        /// WorkCenter code
        /// </summary>        

        string _WorkCenterCode = string.Empty;
        string _PlantCode      = string.Empty;
        string _Date           = string.Empty;

        public string _Language = string.Empty;


        #endregion

        #region Constructors

        /// <summary>
        /// DA9993 constructor
        /// </summary>
        public DA9993()
        {
            InitializeComponent();
            this.TopMost = true;
            AttachEventHandlers();                        
        }


        private void SetButtons()
        {
            btnLanguageList.CountX = 4;
            btnLanguageList.CountY = 1;
            btnLanguageList.SetButtons();

            btnLanguageList[0, 0].Text = "한국어";
            btnLanguageList[0, 1].Text = "영어";
            btnLanguageList[0, 2].Text = "러시아어";
            btnLanguageList[0, 3].Text = "인도네시아어";

            btnLanguageList[0, 0].Tag = "KR";
            btnLanguageList[0, 1].Tag = "EN";
            btnLanguageList[0, 2].Tag = "RU";
            btnLanguageList[0, 3].Tag = "ID";

            btnLanguageList[0, 0].ButtonPressed = true;
            btnLanguageList.RedrawButtons();           
            //btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));            
        }


        #endregion


        #region Events     
      
        private void DA9993_Load(object sender, EventArgs e)
        {
            SetButtons();
        }


        /// <summary>
        /// Attach event handlers
        /// </summary>
        private void AttachEventHandlers()
        {
        }


        private void DettachEventHandlers()
        {
        }           
        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            _Language = string.Empty;                

            DettachEventHandlers();

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnLanguageList_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            //btnListBox_StopList.ExTag = btnListBox_Stop.GetSelectedButtons()[0].Tag.ToString();
            //btnListBox_StopList.CurrentPage = 0;
            //btnListBox_StopList.RedrawButtons();

            _Language = btnLanguageList.GetSelectedButtons()[0].Tag.ToString();
        }

        #region Methods

              
        
 

        #endregion





        #region Properties



        #endregion
    }
}