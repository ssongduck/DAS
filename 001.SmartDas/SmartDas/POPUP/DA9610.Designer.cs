namespace SmartDas.POPUP
{
    partial class DA9610
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
            this.btnOK = new SmartDas.Components.MESButton();
            this.txtMessage = new SmartDas.Components.MESLabel();
            this.lblTitle = new SmartDas.Components.MESLabel();
            this.SuspendLayout();
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
            this.btnOK.Location = new System.Drawing.Point(603, 321);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.ParentBox = null;
            this.btnOK.Size = new System.Drawing.Size(169, 75);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "확인";
            this.btnOK.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnOK.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnOK.UseFlag = true;
            this.btnOK._Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor1 = System.Drawing.Color.White;
            this.txtMessage.BackColor2 = System.Drawing.Color.White;
            this.txtMessage.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMessage.ColorContent = System.Drawing.Color.White;
            this.txtMessage.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMessage.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMessage.Location = new System.Drawing.Point(0, 77);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMessage.MoveControl = null;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(777, 325);
            this.txtMessage.TabIndex = 98;
            this.txtMessage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMessage.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.BackColor2 = System.Drawing.Color.White;
            this.lblTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.lblTitle.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lblTitle.MoveControl = null;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(777, 77);
            this.lblTitle.TabIndex = 96;
            this.lblTitle.Text = "등록 완료";
            this.lblTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA9610
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 411);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DA9610";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DA9610";
            this.Load += new System.EventHandler(this.DA9610_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected Components.MESLabel lblTitle;
        private Components.MESLabel txtMessage;
        private Components.MESButton btnOK;
    }
}