namespace SmartDas
{
    partial class DA0120
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
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.txtOrderNo = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.txtPlanNo = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.btnMakeOrder = new SmartDas.Components.MESButton();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.mesButton1 = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "작업지시선택";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.mesGrid1;
            this.btnRightPage.LinkMoveSize = 6;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.mesGrid1;
            this.btnLeftPage.LinkMoveSize = 6;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.mesButton1);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.btnMakeOrder);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.dtpStartDate);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtOrderNo);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.txtPlanNo);
            // 
            // txtWorkCenterName
            // 
            this.txtWorkCenterName.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkCenterName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkCenterName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkCenterName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterName.Location = new System.Drawing.Point(214, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(468, 50);
            this.txtWorkCenterName.TabIndex = 6;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkCenterCode
            // 
            this.txtWorkCenterCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkCenterCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkCenterCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkCenterCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterCode.Location = new System.Drawing.Point(130, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(80, 50);
            this.txtWorkCenterCode.TabIndex = 5;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BackColor = System.Drawing.Color.Moccasin;
            this.txtOrderNo.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtOrderNo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtOrderNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtOrderNo.ColorContent = System.Drawing.Color.Moccasin;
            this.txtOrderNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtOrderNo.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtOrderNo.Location = new System.Drawing.Point(130, 60);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrderNo.MoveControl = null;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(552, 50);
            this.txtOrderNo.TabIndex = 8;
            this.txtOrderNo.Text = "1234567890123";
            this.txtOrderNo.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtOrderNo.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor2 = System.Drawing.Color.White;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel5.Location = new System.Drawing.Point(6, 60);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 7;
            this.mesLabel5.Text = "선택 품번";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnConfBox.Location = new System.Drawing.Point(690, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(320, 104);
            this.btnConfBox.TabIndex = 9;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 170);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 432);
            this.mesGrid1.TabIndex = 10;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.BackColor = System.Drawing.Color.Moccasin;
            this.txtPlanNo.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtPlanNo.BackColor2 = System.Drawing.Color.White;
            this.txtPlanNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPlanNo.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPlanNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPlanNo.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPlanNo.Location = new System.Drawing.Point(130, 60);
            this.txtPlanNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanNo.MoveControl = null;
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(486, 50);
            this.txtPlanNo.TabIndex = 12;
            this.txtPlanNo.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtPlanNo.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel3.Location = new System.Drawing.Point(6, 60);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 11;
            this.mesLabel3.Text = "지시번호";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(130, 117);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(214, 44);
            this.dtpStartDate.TabIndex = 44;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
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
            this.mesLabel2.Location = new System.Drawing.Point(6, 114);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 45;
            this.mesLabel2.Text = "지시일자";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnMakeOrder.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMakeOrder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMakeOrder.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnMakeOrder.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnMakeOrder.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnMakeOrder.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnMakeOrder.ButtonPressed = false;
            this.btnMakeOrder.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnMakeOrder.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnMakeOrder.ExTag = null;
            this.btnMakeOrder.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnMakeOrder.FontSize = 20F;
            this.btnMakeOrder.LinkButtonBox = null;
            this.btnMakeOrder.LinkGrid = null;
            this.btnMakeOrder.LinkMoveSize = 0;
            this.btnMakeOrder.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnMakeOrder.Location = new System.Drawing.Point(355, 114);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.ParentBox = null;
            this.btnMakeOrder.Size = new System.Drawing.Size(327, 50);
            this.btnMakeOrder.TabIndex = 46;
            this.btnMakeOrder.Text = "긴급 작업지시 생성";
            this.btnMakeOrder.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnMakeOrder.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnMakeOrder.UseFlag = true;
            this.btnMakeOrder._Click += new System.EventHandler(this.btnMakeOrder_Click);
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
            this.mesLabel1.Location = new System.Drawing.Point(6, 6);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 47;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesButton1
            // 
            this.mesButton1.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.mesButton1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mesButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.mesButton1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.mesButton1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.mesButton1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.mesButton1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.mesButton1.ButtonPressed = false;
            this.mesButton1.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.mesButton1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.mesButton1.ExTag = null;
            this.mesButton1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.mesButton1.FontSize = 20F;
            this.mesButton1.LinkButtonBox = null;
            this.mesButton1.LinkGrid = null;
            this.mesButton1.LinkMoveSize = 0;
            this.mesButton1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.mesButton1.Location = new System.Drawing.Point(690, 114);
            this.mesButton1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mesButton1.Name = "mesButton1";
            this.mesButton1.ParentBox = null;
            this.mesButton1.Size = new System.Drawing.Size(320, 50);
            this.mesButton1.TabIndex = 49;
            this.mesButton1.Text = "시사출 지시 생성";
            this.mesButton1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesButton1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesButton1.UseFlag = true;
            this.mesButton1._Click += new System.EventHandler(this.mesButton1_Click);
            // 
            // DA0120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0120";
            this.Text = "작업지시선택";
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtOrderNo;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtPlanNo;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel mesLabel2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private Components.MESButton btnMakeOrder;
        private Components.MESLabel mesLabel1;
        private Components.MESButton mesButton1;
    }
}
