namespace SmartDas.POPUP
{
    partial class DA9220
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
            this.txtContent = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnCancel = new SmartDas.Components.MESButton();
            this.btnOK = new SmartDas.Components.MESButton();
            this.btnClear = new SmartDas.Components.MESButton();
            this.labTitle = new SmartDas.Components.MESLabel();
            this.labHeader = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContent.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtContent.Location = new System.Drawing.Point(196, 59);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(823, 47);
            this.txtContent.TabIndex = 11;
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnCancel.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.BackColor = System.Drawing.Color.DeepPink;
            this.btnCancel.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnCancel.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnCancel.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnCancel.ButtonPressed = false;
            this.btnCancel.ClickBackColor1 = System.Drawing.Color.Moccasin;
            this.btnCancel.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnCancel.ExTag = null;
            this.btnCancel.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnCancel.FontSize = 20F;
            this.btnCancel.LinkButtonBox = null;
            this.btnCancel.LinkGrid = null;
            this.btnCancel.LinkMoveSize = 0;
            this.btnCancel.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnCancel.Location = new System.Drawing.Point(845, 118);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ParentBox = null;
            this.btnCancel.Size = new System.Drawing.Size(169, 72);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnCancel.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnCancel.UseFlag = true;
            this.btnCancel._Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOK
            // 
            this.btnOK.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnOK.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOK.BackColor = System.Drawing.Color.Green;
            this.btnOK.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnOK.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnOK.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnOK.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnOK.ButtonPressed = false;
            this.btnOK.ClickBackColor1 = System.Drawing.Color.Moccasin;
            this.btnOK.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnOK.ExTag = null;
            this.btnOK.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnOK.FontSize = 20F;
            this.btnOK.LinkButtonBox = null;
            this.btnOK.LinkGrid = null;
            this.btnOK.LinkMoveSize = 0;
            this.btnOK.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnOK.Location = new System.Drawing.Point(661, 118);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.ParentBox = null;
            this.btnOK.Size = new System.Drawing.Size(169, 72);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "확인";
            this.btnOK.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnOK.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnOK.UseFlag = true;
            this.btnOK._Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnClear.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnClear.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnClear.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnClear.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnClear.ButtonPressed = false;
            this.btnClear.ClickBackColor1 = System.Drawing.Color.Moccasin;
            this.btnClear.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnClear.ExTag = null;
            this.btnClear.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnClear.FontSize = 20F;
            this.btnClear.LinkButtonBox = null;
            this.btnClear.LinkGrid = null;
            this.btnClear.LinkMoveSize = 0;
            this.btnClear.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnClear.Location = new System.Drawing.Point(477, 118);
            this.btnClear.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.ParentBox = null;
            this.btnClear.Size = new System.Drawing.Size(169, 72);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "모두지움";
            this.btnClear.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnClear.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnClear.UseFlag = true;
            this.btnClear._Click += new System.EventHandler(this.btn_Click);
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.White;
            this.labTitle.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.labTitle.BackColor2 = System.Drawing.Color.White;
            this.labTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.labTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.labTitle.ColorReadOnly = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labTitle.Location = new System.Drawing.Point(12, 5);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(1007, 47);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "비가동 상세 입력";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // labHeader
            // 
            this.labHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labHeader.BackColor1 = System.Drawing.Color.LightGreen;
            this.labHeader.BackColor2 = System.Drawing.Color.White;
            this.labHeader.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.labHeader.ColorContent = System.Drawing.Color.Moccasin;
            this.labHeader.ColorReadOnly = System.Drawing.Color.Transparent;
            this.labHeader.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labHeader.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labHeader.Location = new System.Drawing.Point(12, 59);
            this.labHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labHeader.MoveControl = null;
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(176, 47);
            this.labHeader.TabIndex = 2;
            this.labHeader.Text = "문장";
            this.labHeader.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labHeader.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA9220
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 207);
            this.ControlBox = false;
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9220";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.DA9220_Activated);
            this.Load += new System.EventHandler(this.DA9220_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MESLabel labHeader;
        private Components.MESLabel labTitle;
        private Components.MESButton btnClear;
        private Components.MESButton btnOK;
        private Components.MESButton btnCancel;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtContent;
    }
}