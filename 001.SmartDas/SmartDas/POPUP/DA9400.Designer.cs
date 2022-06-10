namespace SmartDas.POPUP
{
    partial class DA9400
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
            this.btnCancel = new SmartDas.Components.MESButton();
            this.btnOK = new SmartDas.Components.MESButton();
            this.labTitle = new SmartDas.Components.MESLabel();
            this.labHeader = new SmartDas.Components.MESLabel();
            this.txtContent = new SmartDas.Components.MESLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInspName = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(802, 115);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ParentBox = null;
            this.btnCancel.Size = new System.Drawing.Size(169, 53);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnCancel.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnCancel.UseFlag = true;
            this.btnCancel._Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOK.Location = new System.Drawing.Point(630, 115);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.ParentBox = null;
            this.btnOK.Size = new System.Drawing.Size(169, 53);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "확인";
            this.btnOK.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnOK.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnOK.UseFlag = true;
            this.btnOK._Click += new System.EventHandler(this.btnOK_Click);
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
            this.labTitle.Location = new System.Drawing.Point(2, 2);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(969, 53);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "입력 키보드";
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
            this.labHeader.Location = new System.Drawing.Point(2, 116);
            this.labHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labHeader.MoveControl = null;
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(143, 53);
            this.labHeader.TabIndex = 13;
            this.labHeader.Text = "값";
            this.labHeader.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labHeader.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Moccasin;
            this.txtContent.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtContent.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtContent.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtContent.ColorContent = System.Drawing.Color.Moccasin;
            this.txtContent.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtContent.Font = new System.Drawing.Font("휴먼모음T", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContent.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtContent.Location = new System.Drawing.Point(148, 116);
            this.txtContent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtContent.MoveControl = null;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(479, 53);
            this.txtContent.TabIndex = 14;
            this.txtContent.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtContent.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(2, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 521);
            this.panel1.TabIndex = 23;
            // 
            // txtInspName
            // 
            this.txtInspName.BackColor = System.Drawing.Color.Moccasin;
            this.txtInspName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtInspName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtInspName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtInspName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtInspName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtInspName.Font = new System.Drawing.Font("휴먼모음T", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInspName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtInspName.Location = new System.Drawing.Point(148, 59);
            this.txtInspName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInspName.MoveControl = null;
            this.txtInspName.Name = "txtInspName";
            this.txtInspName.Size = new System.Drawing.Size(823, 53);
            this.txtInspName.TabIndex = 24;
            this.txtInspName.TextHAlign = Infragistics.Win.HAlign.Default;
            this.txtInspName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel2
            // 
            this.mesLabel2.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor2 = System.Drawing.Color.White;
            this.mesLabel2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel2.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel2.Location = new System.Drawing.Point(2, 59);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(143, 53);
            this.mesLabel2.TabIndex = 25;
            this.mesLabel2.Text = "검사항목";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA9400
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 702);
            this.ControlBox = false;
            this.Controls.Add(this.mesLabel2);
            this.Controls.Add(this.txtInspName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9400";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9400_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel labTitle;
        private Components.MESButton btnOK;
        private Components.MESButton btnCancel;
        private Components.MESLabel txtContent;
        private Components.MESLabel labHeader;
        private System.Windows.Forms.Panel panel1;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel txtInspName;
    }
}