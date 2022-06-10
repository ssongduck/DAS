namespace SmartDas.POPUP
{
    partial class DA9800
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
            this.labTitle = new SmartDas.Components.MESLabel();
            this.btnLeftPage = new SmartDas.Components.MESButton();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.btnRightPage = new SmartDas.Components.MESButton();
            this.btnCancel = new SmartDas.Components.MESButton();
            this.txtladlename = new SmartDas.Components.MESLabel();
            this.txtladlecode = new SmartDas.Components.MESLabel();
            this.mesLabel34 = new SmartDas.Components.MESLabel();
            this.btnOK = new SmartDas.Components.MESButton();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labTitle.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.labTitle.BackColor2 = System.Drawing.Color.White;
            this.labTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.labTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.labTitle.ColorReadOnly = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labTitle.Location = new System.Drawing.Point(76, 4);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(622, 64);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "래들 선택";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnLeftPage.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnLeftPage.FontSize = 24F;
            this.btnLeftPage.LinkButtonBox = null;
            this.btnLeftPage.LinkGrid = this.mesGrid1;
            this.btnLeftPage.LinkMoveSize = 7;
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
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(2, 128);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(770, 455);
            this.mesGrid1.TabIndex = 82;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
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
            this.btnRightPage.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnRightPage.FontSize = 24F;
            this.btnRightPage.LinkButtonBox = null;
            this.btnRightPage.LinkGrid = this.mesGrid1;
            this.btnRightPage.LinkMoveSize = 7;
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
            // btnCancel
            // 
            this.btnCancel.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnCancel.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnCancel.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnCancel.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnCancel.ButtonPressed = false;
            this.btnCancel.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnCancel.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnCancel.ExTag = null;
            this.btnCancel.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnCancel.FontSize = 20F;
            this.btnCancel.LinkButtonBox = null;
            this.btnCancel.LinkGrid = null;
            this.btnCancel.LinkMoveSize = 0;
            this.btnCancel.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnCancel.Location = new System.Drawing.Point(610, 74);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ParentBox = null;
            this.btnCancel.Size = new System.Drawing.Size(161, 50);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnCancel.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnCancel.UseFlag = true;
            this.btnCancel._Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtladlename
            // 
            this.txtladlename.BackColor = System.Drawing.Color.Moccasin;
            this.txtladlename.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtladlename.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtladlename.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtladlename.ColorContent = System.Drawing.Color.Moccasin;
            this.txtladlename.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtladlename.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtladlename.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtladlename.Location = new System.Drawing.Point(124, 74);
            this.txtladlename.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtladlename.MoveControl = null;
            this.txtladlename.Name = "txtladlename";
            this.txtladlename.Size = new System.Drawing.Size(313, 50);
            this.txtladlename.TabIndex = 119;
            this.txtladlename.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtladlename.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtladlecode
            // 
            this.txtladlecode.BackColor = System.Drawing.Color.Moccasin;
            this.txtladlecode.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtladlecode.BackColor2 = System.Drawing.Color.White;
            this.txtladlecode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtladlecode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtladlecode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtladlecode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtladlecode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtladlecode.Location = new System.Drawing.Point(439, 514);
            this.txtladlecode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtladlecode.MoveControl = null;
            this.txtladlecode.Name = "txtladlecode";
            this.txtladlecode.Size = new System.Drawing.Size(129, 50);
            this.txtladlecode.TabIndex = 118;
            this.txtladlecode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtladlecode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtladlecode.Visible = false;
            // 
            // mesLabel34
            // 
            this.mesLabel34.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel34.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel34.BackColor2 = System.Drawing.Color.White;
            this.mesLabel34.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel34.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel34.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel34.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel34.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel34.Location = new System.Drawing.Point(3, 74);
            this.mesLabel34.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel34.MoveControl = null;
            this.mesLabel34.Name = "mesLabel34";
            this.mesLabel34.Size = new System.Drawing.Size(120, 50);
            this.mesLabel34.TabIndex = 117;
            this.mesLabel34.Text = "장착 래들";
            this.mesLabel34.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel34.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnOK
            // 
            this.btnOK.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnOK.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnOK.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnOK.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnOK.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnOK.ButtonPressed = false;
            this.btnOK.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnOK.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnOK.ExTag = null;
            this.btnOK.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnOK.FontSize = 20F;
            this.btnOK.LinkButtonBox = null;
            this.btnOK.LinkGrid = null;
            this.btnOK.LinkMoveSize = 0;
            this.btnOK.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnOK.Location = new System.Drawing.Point(443, 74);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.ParentBox = null;
            this.btnOK.Size = new System.Drawing.Size(161, 50);
            this.btnOK.TabIndex = 120;
            this.btnOK.Text = "장착";
            this.btnOK.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnOK.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnOK.UseFlag = true;
            this.btnOK._Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DA9800
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 588);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtladlename);
            this.Controls.Add(this.txtladlecode);
            this.Controls.Add(this.mesLabel34);
            this.Controls.Add(this.mesGrid1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRightPage);
            this.Controls.Add(this.btnLeftPage);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9800";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9800_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel labTitle;
        protected Components.MESButton btnLeftPage;
        protected Components.MESButton btnRightPage;
        private Components.MESButton btnCancel;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtladlename;
        private Components.MESLabel txtladlecode;
        private Components.MESLabel mesLabel34;
        private Components.MESButton btnOK;
    }
}