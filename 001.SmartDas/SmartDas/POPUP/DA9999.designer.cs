namespace SmartDas.POPUP
{
    partial class DA9999
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
            this.btnConfirm = new SmartDas.Components.MESButton();
            this.btnCancel = new SmartDas.Components.MESButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
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
            this.labTitle.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.labTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labTitle.Location = new System.Drawing.Point(0, 3);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(294, 65);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "비밀번호 확인";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnConfirm.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnConfirm.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnConfirm.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnConfirm.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnConfirm.ButtonPressed = false;
            this.btnConfirm.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirm.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnConfirm.ExTag = null;
            this.btnConfirm.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnConfirm.FontSize = 20F;
            this.btnConfirm.LinkButtonBox = null;
            this.btnConfirm.LinkGrid = null;
            this.btnConfirm.LinkMoveSize = 0;
            this.btnConfirm.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnConfirm.Location = new System.Drawing.Point(0, 120);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ParentBox = null;
            this.btnConfirm.Size = new System.Drawing.Size(145, 123);
            this.btnConfirm.TabIndex = 123;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnConfirm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnConfirm.UseFlag = true;
            this.btnConfirm._Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(149, 120);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ParentBox = null;
            this.btnCancel.Size = new System.Drawing.Size(145, 123);
            this.btnCancel.TabIndex = 124;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnCancel.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnCancel.UseFlag = true;
            this.btnCancel._Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(0, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(294, 44);
            this.txtPassword.TabIndex = 125;
            // 
            // DA9999
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 245);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9999";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MESLabel labTitle;
        private Components.MESButton btnConfirm;
        private Components.MESButton btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
    }
}