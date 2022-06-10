namespace SmartDas.POPUP
{
    partial class DA9100
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.labTitle = new SmartDas.Components.MESLabel();
            this.labHeader = new SmartDas.Components.MESLabel();
            this.buttonBox1 = new SmartDas.Components.ButtonBox();
            this.txtContent = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
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
            this.labTitle.Text = "수량 입력";
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
            this.labHeader.Text = "수량";
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
            appearance1.TextHAlignAsString = "Right";
            appearance1.TextVAlignAsString = "Middle";
            this.txtContent.Appearance = appearance1;
            this.txtContent.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContent.Location = new System.Drawing.Point(191, 66);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(567, 47);
            this.txtContent.TabIndex = 12;
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // DA9100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 584);
            this.ControlBox = false;
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.buttonBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9100";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.DA9200_Activated);
            this.Load += new System.EventHandler(this.DA9100_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ButtonBox buttonBox1;
        private Components.MESLabel labHeader;
        private Components.MESLabel labTitle;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtContent;
    }
}