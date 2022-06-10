namespace SmartDas.POPUP
{
    partial class DA9900
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListBox_StopList = new SmartDas.Components.ButtonBox();
            this.btnListDown = new SmartDas.Components.MESButton();
            this.btnListBox_Stop = new SmartDas.Components.ButtonBox();
            this.btnListUp = new SmartDas.Components.MESButton();
            this.btnRightPage = new SmartDas.Components.MESButton();
            this.btnLeftPage = new SmartDas.Components.MESButton();
            this.labTitle = new SmartDas.Components.MESLabel();
            this.mesButton1 = new SmartDas.Components.MESButton();
            this.SuspendLayout();
            // 
            // btnListBox_StopList
            // 
            this.btnListBox_StopList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox_StopList.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox_StopList.CountX = 1;
            this.btnListBox_StopList.CountY = 1;
            this.btnListBox_StopList.CurrentPage = 0;
            this.btnListBox_StopList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListBox_StopList.ExTag = "";
            this.btnListBox_StopList.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox_StopList.Location = new System.Drawing.Point(0, 181);
            this.btnListBox_StopList.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox_StopList.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox_StopList.Name = "btnListBox_StopList";
            this.btnListBox_StopList.SelectCommand = null;
            this.btnListBox_StopList.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox_StopList.SelectProcedureName = null;
            this.btnListBox_StopList.Size = new System.Drawing.Size(777, 407);
            this.btnListBox_StopList.TabIndex = 122;
            this.btnListBox_StopList.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnListBox_StopList_buttonChangeEvent);
            // 
            // btnListDown
            // 
            this.btnListDown.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnListDown.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListDown.BackColor = System.Drawing.Color.Transparent;
            this.btnListDown.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnListDown.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnListDown.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnListDown.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnListDown.ButtonPressed = false;
            this.btnListDown.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnListDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnListDown.ExTag = null;
            this.btnListDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnListDown.FontSize = 20F;
            this.btnListDown.LinkButtonBox = this.btnListBox_Stop;
            this.btnListDown.LinkGrid = null;
            this.btnListDown.LinkMoveSize = 5;
            this.btnListDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnListDown.Location = new System.Drawing.Point(622, 125);
            this.btnListDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnListDown.Name = "btnListDown";
            this.btnListDown.ParentBox = null;
            this.btnListDown.Size = new System.Drawing.Size(64, 50);
            this.btnListDown.TabIndex = 121;
            this.btnListDown.Text = "▼";
            this.btnListDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnListDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnListDown.UseFlag = true;
            // 
            // btnListBox_Stop
            // 
            this.btnListBox_Stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox_Stop.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox_Stop.CountX = 1;
            this.btnListBox_Stop.CountY = 1;
            this.btnListBox_Stop.CurrentPage = 0;
            this.btnListBox_Stop.ExTag = "";
            this.btnListBox_Stop.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox_Stop.Location = new System.Drawing.Point(2, 75);
            this.btnListBox_Stop.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox_Stop.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox_Stop.Name = "btnListBox_Stop";
            this.btnListBox_Stop.SelectCommand = null;
            this.btnListBox_Stop.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox_Stop.SelectProcedureName = null;
            this.btnListBox_Stop.Size = new System.Drawing.Size(618, 100);
            this.btnListBox_Stop.TabIndex = 119;
            this.btnListBox_Stop.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnListBox_Stop_buttonChangeEvent);
            // 
            // btnListUp
            // 
            this.btnListUp.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnListUp.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListUp.BackColor = System.Drawing.Color.Transparent;
            this.btnListUp.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnListUp.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnListUp.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnListUp.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnListUp.ButtonPressed = false;
            this.btnListUp.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnListUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnListUp.ExTag = null;
            this.btnListUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnListUp.FontSize = 20F;
            this.btnListUp.LinkButtonBox = this.btnListBox_Stop;
            this.btnListUp.LinkGrid = null;
            this.btnListUp.LinkMoveSize = 5;
            this.btnListUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnListUp.Location = new System.Drawing.Point(622, 73);
            this.btnListUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnListUp.Name = "btnListUp";
            this.btnListUp.ParentBox = null;
            this.btnListUp.Size = new System.Drawing.Size(64, 50);
            this.btnListUp.TabIndex = 120;
            this.btnListUp.Text = "▲";
            this.btnListUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnListUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnListUp.UseFlag = true;
            // 
            // btnRightPage
            // 
            this.btnRightPage.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnRightPage.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRightPage.BackColor = System.Drawing.Color.Transparent;
            this.btnRightPage.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnRightPage.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnRightPage.BackGradientStyle = Infragistics.Win.GradientStyle.Circular;
            this.btnRightPage.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnRightPage.ButtonPressed = false;
            this.btnRightPage.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnRightPage.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnRightPage.ExTag = null;
            this.btnRightPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnRightPage.FontSize = 24F;
            this.btnRightPage.LinkButtonBox = this.btnListBox_StopList;
            this.btnRightPage.LinkGrid = null;
            this.btnRightPage.LinkMoveSize = 15;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnRightPage.Location = new System.Drawing.Point(708, 4);
            this.btnRightPage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnRightPage.Name = "btnRightPage";
            this.btnRightPage.ParentBox = null;
            this.btnRightPage.Size = new System.Drawing.Size(64, 64);
            this.btnRightPage.TabIndex = 30;
            this.btnRightPage.Text = "▶";
            this.btnRightPage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnRightPage.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnRightPage.UseFlag = true;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnLeftPage.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeftPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftPage.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnLeftPage.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnLeftPage.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnLeftPage.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnLeftPage.ButtonPressed = false;
            this.btnLeftPage.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnLeftPage.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnLeftPage.ExTag = null;
            this.btnLeftPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnLeftPage.FontSize = 24F;
            this.btnLeftPage.LinkButtonBox = this.btnListBox_StopList;
            this.btnLeftPage.LinkGrid = null;
            this.btnLeftPage.LinkMoveSize = 15;
            this.btnLeftPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnLeftPage.Location = new System.Drawing.Point(2, 4);
            this.btnLeftPage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLeftPage.Name = "btnLeftPage";
            this.btnLeftPage.ParentBox = null;
            this.btnLeftPage.Size = new System.Drawing.Size(64, 64);
            this.btnLeftPage.TabIndex = 29;
            this.btnLeftPage.Text = "◀";
            this.btnLeftPage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnLeftPage.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnLeftPage.UseFlag = true;
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labTitle.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.labTitle.BackColor2 = System.Drawing.Color.White;
            this.labTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.labTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.labTitle.ColorReadOnly = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labTitle.Location = new System.Drawing.Point(76, 4);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(622, 64);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "비가동 유형 선택";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesButton1
            // 
            this.mesButton1.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.mesButton1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mesButton1.BackColor = System.Drawing.Color.Transparent;
            this.mesButton1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.mesButton1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.mesButton1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.mesButton1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.mesButton1.ButtonPressed = false;
            this.mesButton1.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.mesButton1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.mesButton1.ExTag = null;
            this.mesButton1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.mesButton1.FontSize = 20F;
            this.mesButton1.LinkButtonBox = null;
            this.mesButton1.LinkGrid = null;
            this.mesButton1.LinkMoveSize = 0;
            this.mesButton1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.mesButton1.Location = new System.Drawing.Point(689, 73);
            this.mesButton1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mesButton1.Name = "mesButton1";
            this.mesButton1.ParentBox = null;
            this.mesButton1.Size = new System.Drawing.Size(83, 102);
            this.mesButton1.TabIndex = 123;
            this.mesButton1.Text = "취소";
            this.mesButton1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesButton1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesButton1.UseFlag = true;
            this.mesButton1._Click += new System.EventHandler(this.mesButton1_Click);
            // 
            // DA9900
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 588);
            this.ControlBox = false;
            this.Controls.Add(this.mesButton1);
            this.Controls.Add(this.btnListBox_StopList);
            this.Controls.Add(this.btnListDown);
            this.Controls.Add(this.btnListUp);
            this.Controls.Add(this.btnListBox_Stop);
            this.Controls.Add(this.btnRightPage);
            this.Controls.Add(this.btnLeftPage);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9900";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9900_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel labTitle;
        protected Components.MESButton btnLeftPage;
        protected Components.MESButton btnRightPage;
        private Components.MESButton btnListDown;
        private Components.ButtonBox btnListBox_Stop;
        private Components.MESButton btnListUp;
        private Components.ButtonBox btnListBox_StopList;
        private Components.MESButton mesButton1;
    }
}