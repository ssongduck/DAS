namespace SmartDas.POPUP
{
    partial class DA9120
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
            this.txtContent = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDayNight = new SmartDas.Components.MESLabel();
            this.labHeader = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.btnSave = new SmartDas.Components.MESButton();
            this.btnCancel = new SmartDas.Components.MESButton();
            this.labTitle = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            appearance1.TextHAlignAsString = "Left";
            appearance1.TextVAlignAsString = "Middle";
            this.txtContent.Appearance = appearance1;
            this.txtContent.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContent.Location = new System.Drawing.Point(9, 119);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(561, 159);
            this.txtContent.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(98, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(239, 52);
            this.dtpDate.TabIndex = 125;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDayNight
            // 
            this.txtDayNight.BackColor = System.Drawing.SystemColors.Window;
            this.txtDayNight.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtDayNight.BackColor2 = System.Drawing.Color.White;
            this.txtDayNight.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDayNight.ColorContent = System.Drawing.SystemColors.Window;
            this.txtDayNight.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDayNight.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.txtDayNight.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDayNight.Location = new System.Drawing.Point(345, 62);
            this.txtDayNight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDayNight.MoveControl = null;
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(91, 52);
            this.txtDayNight.TabIndex = 126;
            this.txtDayNight.Tag = "D";
            this.txtDayNight.Text = "주간";
            this.txtDayNight.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDayNight.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDayNight._Click += new System.EventHandler(this.txtDayNight__Click);
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
            this.labHeader.Location = new System.Drawing.Point(9, 62);
            this.labHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labHeader.MoveControl = null;
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(86, 53);
            this.labHeader.TabIndex = 124;
            this.labHeader.Text = "일자";
            this.labHeader.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labHeader.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.FontSize = 10F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(9, 283);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(674, 272);
            this.mesGrid1.TabIndex = 123;
            // 
            // btnSave
            // 
            this.btnSave.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnSave.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnSave.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnSave.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnSave.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnSave.ButtonPressed = false;
            this.btnSave.ClickBackColor1 = System.Drawing.Color.Moccasin;
            this.btnSave.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnSave.ExTag = null;
            this.btnSave.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnSave.FontSize = 20F;
            this.btnSave.LinkButtonBox = null;
            this.btnSave.LinkGrid = null;
            this.btnSave.LinkMoveSize = 0;
            this.btnSave.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnSave.Location = new System.Drawing.Point(571, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.ParentBox = null;
            this.btnSave.Size = new System.Drawing.Size(112, 78);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "등록";
            this.btnSave.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSave.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSave.UseFlag = true;
            this.btnSave._Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(571, 200);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ParentBox = null;
            this.btnCancel.Size = new System.Drawing.Size(112, 78);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnCancel.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnCancel.UseFlag = true;
            this.btnCancel._Click += new System.EventHandler(this.btnCancel_Click);
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
            this.labTitle.Location = new System.Drawing.Point(9, 5);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labTitle.MoveControl = this;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(675, 53);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "특이사항 입력";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA9120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 563);
            this.ControlBox = false;
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.mesGrid1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9120";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9120_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MESLabel labTitle;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtContent;
        private Components.MESButton btnSave;
        private Components.MESButton btnCancel;
        private Components.MESGrid mesGrid1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel labHeader;
        private Components.MESLabel txtDayNight;
    }
}