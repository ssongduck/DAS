namespace SmartDas.POPUP
{
    partial class DA9993
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLanguageList = new SmartDas.Components.ButtonBox();
            this.btnSelect = new SmartDas.Components.MESButton();
            this.btnClose = new SmartDas.Components.MESButton();
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
            this.labTitle.Size = new System.Drawing.Size(623, 68);
            this.labTitle.TabIndex = 132;
            this.labTitle.Text = "언어 선택";
            this.labTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.labTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.40468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.59532F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.labTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLanguageList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelect, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 235);
            this.tableLayoutPanel1.TabIndex = 136;
            // 
            // btnLanguageList
            // 
            this.btnLanguageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLanguageList.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.tableLayoutPanel1.SetColumnSpan(this.btnLanguageList, 2);
            this.btnLanguageList.CountX = 1;
            this.btnLanguageList.CountY = 1;
            this.btnLanguageList.CurrentPage = 0;
            this.btnLanguageList.ExTag = "";
            this.btnLanguageList.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLanguageList.Location = new System.Drawing.Point(3, 73);
            this.btnLanguageList.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnLanguageList.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnLanguageList.Name = "btnLanguageList";
            this.tableLayoutPanel1.SetRowSpan(this.btnLanguageList, 2);
            this.btnLanguageList.SelectCommand = null;
            this.btnLanguageList.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnLanguageList.SelectProcedureName = null;
            this.btnLanguageList.Size = new System.Drawing.Size(499, 159);
            this.btnLanguageList.TabIndex = 133;
            this.btnLanguageList.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnLanguageList_buttonChangeEvent);
            // 
            // btnSelect
            // 
            this.btnSelect.AlarmColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSelect.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btnSelect.BackColor2 = System.Drawing.Color.Transparent;
            this.btnSelect.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnSelect.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnSelect.ButtonPressed = false;
            this.btnSelect.ClickBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnSelect.ExTag = null;
            this.btnSelect.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnSelect.FontSize = 24F;
            this.btnSelect.LinkButtonBox = null;
            this.btnSelect.LinkGrid = null;
            this.btnSelect.LinkMoveSize = 0;
            this.btnSelect.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnSelect.Location = new System.Drawing.Point(508, 73);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ParentBox = null;
            this.btnSelect.Size = new System.Drawing.Size(114, 76);
            this.btnSelect.TabIndex = 134;
            this.btnSelect.Text = "선택";
            this.btnSelect.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSelect.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSelect.UseFlag = true;
            this.btnSelect._Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.AlarmColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackColor1 = System.Drawing.Color.Tomato;
            this.btnClose.BackColor2 = System.Drawing.Color.Transparent;
            this.btnClose.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnClose.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnClose.ButtonPressed = false;
            this.btnClose.ClickBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnClose.ExTag = null;
            this.btnClose.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnClose.FontSize = 24F;
            this.btnClose.LinkButtonBox = null;
            this.btnClose.LinkGrid = null;
            this.btnClose.LinkMoveSize = 0;
            this.btnClose.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnClose.Location = new System.Drawing.Point(508, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.ParentBox = null;
            this.btnClose.Size = new System.Drawing.Size(114, 77);
            this.btnClose.TabIndex = 135;
            this.btnClose.Text = "취소";
            this.btnClose.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnClose.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnClose.UseFlag = true;
            this.btnClose._Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DA9993
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 235);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DA9993";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DA9993_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel labTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.ButtonBox btnLanguageList;
        private Components.MESButton btnSelect;
        private Components.MESButton btnClose;

    }
}