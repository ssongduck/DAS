namespace SmartDas.POPUP
{
    partial class DA9994
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
            this.btnInspReg = new SmartDas.Components.MESButton();
            this.btnClose = new SmartDas.Components.MESButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNight = new SmartDas.Components.MESLabel();
            this.lblDay = new SmartDas.Components.MESLabel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.SetColumnSpan(this.labTitle, 3);
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.Font = new System.Drawing.Font("휴먼모음T", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.labTitle.Location = new System.Drawing.Point(1, 1);
            this.labTitle.Margin = new System.Windows.Forms.Padding(1);
            this.labTitle.MoveControl = null;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(417, 43);
            this.labTitle.TabIndex = 132;
            this.labTitle.Text = "품질 검사확인";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnInspReg
            // 
            this.btnInspReg.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnInspReg.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInspReg.BackColor = System.Drawing.Color.Transparent;
            this.btnInspReg.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnInspReg.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnInspReg.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnInspReg.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnInspReg.ButtonPressed = false;
            this.btnInspReg.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnInspReg.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnInspReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInspReg.ExTag = null;
            this.btnInspReg.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnInspReg.FontSize = 20F;
            this.btnInspReg.LinkButtonBox = null;
            this.btnInspReg.LinkGrid = null;
            this.btnInspReg.LinkMoveSize = 0;
            this.btnInspReg.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnInspReg.Location = new System.Drawing.Point(66, 47);
            this.btnInspReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnInspReg.Name = "btnInspReg";
            this.btnInspReg.ParentBox = null;
            this.tableLayoutPanel1.SetRowSpan(this.btnInspReg, 2);
            this.btnInspReg.Size = new System.Drawing.Size(231, 104);
            this.btnInspReg.TabIndex = 133;
            this.btnInspReg.Text = "검사 등록";
            this.btnInspReg.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnInspReg.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnInspReg.UseFlag = true;
            // 
            // btnClose
            // 
            this.btnClose.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnClose.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnClose.BackColor2 = System.Drawing.Color.Silver;
            this.btnClose.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.btnClose.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnClose.ButtonPressed = false;
            this.btnClose.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnClose.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.ExTag = null;
            this.btnClose.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnClose.FontSize = 20F;
            this.btnClose.LinkButtonBox = null;
            this.btnClose.LinkGrid = null;
            this.btnClose.LinkMoveSize = 0;
            this.btnClose.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnClose.Location = new System.Drawing.Point(301, 47);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ParentBox = null;
            this.tableLayoutPanel1.SetRowSpan(this.btnClose, 2);
            this.btnClose.Size = new System.Drawing.Size(116, 104);
            this.btnClose.TabIndex = 135;
            this.btnClose.Text = "닫기";
            this.btnClose.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnClose.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnClose.UseFlag = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.40468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.59532F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.lblNight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInspReg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 153);
            this.tableLayoutPanel1.TabIndex = 136;
            // 
            // lblNight
            // 
            this.lblNight.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNight.BackColor2 = System.Drawing.Color.White;
            this.lblNight.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblNight.ColorContent = System.Drawing.Color.Moccasin;
            this.lblNight.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblNight.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNight.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblNight.Location = new System.Drawing.Point(5, 104);
            this.lblNight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblNight.MoveControl = null;
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(54, 41);
            this.lblNight.TabIndex = 137;
            this.lblNight.Text = "야간 미진행";
            this.lblNight.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblNight.TextVAlign = Infragistics.Win.VAlign.Bottom;
            // 
            // lblDay
            // 
            this.lblDay.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDay.BackColor2 = System.Drawing.Color.White;
            this.lblDay.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblDay.ColorContent = System.Drawing.Color.Moccasin;
            this.lblDay.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDay.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblDay.Location = new System.Drawing.Point(5, 51);
            this.lblDay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblDay.MoveControl = null;
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(54, 41);
            this.lblDay.TabIndex = 136;
            this.lblDay.Text = "주간 미진행";
            this.lblDay.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblDay.TextVAlign = Infragistics.Win.VAlign.Bottom;
            // 
            // DA9994
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 153);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9994";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel labTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.MESButton btnClose;
        private Components.MESButton btnInspReg;
        private Components.MESLabel lblDay;
        private Components.MESLabel lblNight;

    }
}