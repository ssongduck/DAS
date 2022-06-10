namespace SmartDas
{
    partial class DA1120
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDayNight = new SmartDas.Components.ButtonBox();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtTotal = new SmartDas.Components.MESLabel();
            this.lblResult1 = new SmartDas.Components.MESLabel();
            this.lblResult2 = new SmartDas.Components.MESLabel();
            this.lblResult3 = new SmartDas.Components.MESLabel();
            this.txtWorker = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.btnItem = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "공정검사";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.mesGrid1;
            this.btnRightPage.LinkMoveSize = 7;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.mesGrid1;
            this.btnLeftPage.LinkMoveSize = 7;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnItem);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.txtWorker);
            this.GroupBody.Controls.Add(this.lblResult3);
            this.GroupBody.Controls.Add(this.lblResult2);
            this.GroupBody.Controls.Add(this.lblResult1);
            this.GroupBody.Controls.Add(this.txtTotal);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.btnDayNight);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.dtpStartDate);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtItemName);
            this.GroupBody.Controls.Add(this.txtItemCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            // 
            // btnConfBox
            // 
            this.btnConfBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnConfBox.CountX = 1;
            this.btnConfBox.CountY = 1;
            this.btnConfBox.CurrentPage = 0;
            this.btnConfBox.ExTag = "";
            this.btnConfBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfBox.Location = new System.Drawing.Point(718, 4);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(289, 106);
            this.btnConfBox.TabIndex = 22;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Moccasin;
            this.txtItemName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtItemName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtItemName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtItemName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtItemName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtItemName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtItemName.Location = new System.Drawing.Point(383, 4);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(332, 50);
            this.txtItemName.TabIndex = 19;
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtItemName._Click += new System.EventHandler(this.txtItemCode_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtItemCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtItemCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtItemCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtItemCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtItemCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtItemCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtItemCode.Location = new System.Drawing.Point(173, 4);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(207, 50);
            this.txtItemCode.TabIndex = 18;
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtItemCode._Click += new System.EventHandler(this.txtItemCode_Click);
            // 
            // mesLabel1
            // 
            this.mesLabel1.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel1.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel1.BackColor2 = System.Drawing.Color.White;
            this.mesLabel1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel1.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel1.Location = new System.Drawing.Point(6, 4);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(164, 50);
            this.mesLabel1.TabIndex = 17;
            this.mesLabel1.Text = "선택 품번";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(7, 171);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1000, 427);
            this.mesGrid1.TabIndex = 23;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // mesLabel2
            // 
            this.mesLabel2.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor2 = System.Drawing.Color.White;
            this.mesLabel2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel2.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel2.Location = new System.Drawing.Point(6, 60);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(164, 50);
            this.mesLabel2.TabIndex = 47;
            this.mesLabel2.Text = "검사 일자";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(173, 63);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(207, 44);
            this.dtpStartDate.TabIndex = 46;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // btnDayNight
            // 
            this.btnDayNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDayNight.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnDayNight.CountX = 1;
            this.btnDayNight.CountY = 1;
            this.btnDayNight.CurrentPage = 0;
            this.btnDayNight.ExTag = "";
            this.btnDayNight.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDayNight.Location = new System.Drawing.Point(383, 60);
            this.btnDayNight.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnDayNight.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnDayNight.Name = "btnDayNight";
            this.btnDayNight.SelectCommand = null;
            this.btnDayNight.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnDayNight.SelectProcedureName = null;
            this.btnDayNight.Size = new System.Drawing.Size(332, 50);
            this.btnDayNight.TabIndex = 48;
            this.btnDayNight.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnDayNight_buttonChangeEvent);
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(6, 117);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(164, 50);
            this.mesLabel3.TabIndex = 49;
            this.mesLabel3.Text = "항목";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Moccasin;
            this.txtTotal.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtTotal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotal.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtTotal.ColorContent = System.Drawing.Color.Moccasin;
            this.txtTotal.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtTotal.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotal.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtTotal.Location = new System.Drawing.Point(173, 117);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotal.MoveControl = null;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(207, 50);
            this.txtTotal.TabIndex = 50;
            this.txtTotal.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtTotal.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblResult1
            // 
            this.lblResult1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblResult1.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.lblResult1.BackColor2 = System.Drawing.Color.White;
            this.lblResult1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblResult1.ColorContent = System.Drawing.Color.Moccasin;
            this.lblResult1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblResult1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblResult1.Location = new System.Drawing.Point(718, 117);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblResult1.MoveControl = null;
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(95, 50);
            this.lblResult1.TabIndex = 54;
            this.lblResult1.Text = "합격";
            this.lblResult1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblResult1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblResult2.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.lblResult2.BackColor2 = System.Drawing.Color.White;
            this.lblResult2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblResult2.ColorContent = System.Drawing.Color.Moccasin;
            this.lblResult2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblResult2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblResult2.Location = new System.Drawing.Point(815, 117);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblResult2.MoveControl = null;
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(95, 50);
            this.lblResult2.TabIndex = 55;
            this.lblResult2.Text = "합격";
            this.lblResult2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblResult2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblResult3
            // 
            this.lblResult3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblResult3.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.lblResult3.BackColor2 = System.Drawing.Color.White;
            this.lblResult3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblResult3.ColorContent = System.Drawing.Color.Moccasin;
            this.lblResult3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblResult3.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblResult3.Location = new System.Drawing.Point(912, 117);
            this.lblResult3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblResult3.MoveControl = null;
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(95, 50);
            this.lblResult3.TabIndex = 56;
            this.lblResult3.Text = "합격";
            this.lblResult3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblResult3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorker
            // 
            this.txtWorker.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorker.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorker.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorker.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorker.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorker.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorker.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorker.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorker.Location = new System.Drawing.Point(549, 117);
            this.txtWorker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorker.MoveControl = null;
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(166, 50);
            this.txtWorker.TabIndex = 58;
            this.txtWorker.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorker.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorker._Click += new System.EventHandler(this.txtWorker_Click);
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel4.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel4.Location = new System.Drawing.Point(383, 117);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(164, 50);
            this.mesLabel4.TabIndex = 59;
            this.mesLabel4.Text = "선택 작업자";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnItem.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnItem.BackColor2 = System.Drawing.Color.White;
            this.btnItem.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.btnItem.ColorContent = System.Drawing.Color.Moccasin;
            this.btnItem.ColorReadOnly = System.Drawing.Color.Transparent;
            this.btnItem.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnItem.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.btnItem.Location = new System.Drawing.Point(658, 7);
            this.btnItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnItem.MoveControl = null;
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(49, 40);
            this.btnItem.TabIndex = 60;
            this.btnItem.Text = "▼";
            this.btnItem.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnItem.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnItem._Click += new System.EventHandler(this.txtItemCode_Click);
            // 
            // DA1120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA1120";
            this.Text = "자주검사 실적등록";
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtItemName;
        private Components.MESLabel txtItemCode;
        private Components.MESLabel mesLabel1;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel mesLabel2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private Components.ButtonBox btnDayNight;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel txtTotal;
        private Components.MESLabel lblResult3;
        private Components.MESLabel lblResult2;
        private Components.MESLabel lblResult1;
        private Components.MESLabel txtWorker;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel btnItem;
    }
}
