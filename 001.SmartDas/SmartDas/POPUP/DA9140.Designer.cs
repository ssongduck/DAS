namespace SmartDas.POPUP
{
    partial class DA9140
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.labTitle = new SmartDas.Components.MESLabel();
            this.labHeader = new SmartDas.Components.MESLabel();
            this.buttonBox1 = new SmartDas.Components.ButtonBox();
            this.txtContent = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            this.labTitle.Size = new System.Drawing.Size(747, 53);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "시간 입력";
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
            this.labHeader.Location = new System.Drawing.Point(12, 63);
            this.labHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labHeader.MoveControl = null;
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(176, 53);
            this.labHeader.TabIndex = 2;
            this.labHeader.Text = "시간";
            this.labHeader.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labHeader.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // buttonBox1
            // 
            this.buttonBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.buttonBox1.CountX = 4;
            this.buttonBox1.CountY = 4;
            this.buttonBox1.CurrentPage = 0;
            this.buttonBox1.ExTag = "";
            this.buttonBox1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBox1.Location = new System.Drawing.Point(12, 125);
            this.buttonBox1.MarginIn = new System.Windows.Forms.Padding(3);
            this.buttonBox1.MarginOut = new System.Windows.Forms.Padding(3);
            this.buttonBox1.Name = "buttonBox1";
            this.buttonBox1.SelectCommand = null;
            this.buttonBox1.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.buttonBox1.SelectProcedureName = null;
            this.buttonBox1.Size = new System.Drawing.Size(747, 447);
            this.buttonBox1.TabIndex = 0;
            this.buttonBox1.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.buttonBox1_buttonClickEvent);
            // 
            // txtContent
            // 
            appearance2.FontData.Name = "휴먼모음T";
            appearance2.FontData.SizeInPoints = 24F;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.txtContent.Appearance = appearance2;
            this.txtContent.AutoSize = false;
            this.txtContent.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.txtContent.InputMask = "##:##:00";
            this.txtContent.Location = new System.Drawing.Point(430, 63);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(329, 52);
            this.txtContent.TabIndex = 31;
            this.txtContent.Text = "::";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(190, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(239, 52);
            this.dtpDate.TabIndex = 32;            
            // 
            // DA9140
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 584);
            this.ControlBox = false;
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.buttonBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9140";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9140_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox buttonBox1;
        private Components.MESLabel labHeader;
        private Components.MESLabel labTitle;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtContent;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}