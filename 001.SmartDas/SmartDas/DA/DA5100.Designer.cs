﻿namespace SmartDas
{
    partial class DA5100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA5100));
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtDayNight = new SmartDas.Components.MESLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.txtIngotQty = new SmartDas.Components.MESLabel();
            this.txtTotalQty = new SmartDas.Components.MESLabel();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.txtScrapQty = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "작업현황";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.mesGrid1;
            this.btnRightPage.LinkMoveSize = 10;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.mesGrid1;
            this.btnLeftPage.LinkMoveSize = 10;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.txtScrapQty);
            this.GroupBody.Controls.Add(this.mesLabel8);
            this.GroupBody.Controls.Add(this.txtTotalQty);
            this.GroupBody.Controls.Add(this.mesLabel10);
            this.GroupBody.Controls.Add(this.txtIngotQty);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.txtDayNight);
            this.GroupBody.Controls.Add(this.label1);
            this.GroupBody.Controls.Add(this.dtpEndDate);
            this.GroupBody.Controls.Add(this.dtpStartDate);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.mesGrid1);
            // 
            // imgMotonic
            // 
            this.imgMotonic.Image = ((object)(resources.GetObject("imgMotonic.Image")));
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
            this.btnConfBox.TabIndex = 28;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor2 = System.Drawing.Color.White;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel5.Location = new System.Drawing.Point(6, 60);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 26;
            this.mesLabel5.Text = "작업일자";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Size = new System.Drawing.Size(475, 50);
            this.txtWorkCenterName.TabIndex = 25;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(127, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(87, 50);
            this.txtWorkCenterCode.TabIndex = 24;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel1.TabIndex = 23;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(127, 120);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 44);
            this.dtpStartDate.TabIndex = 30;
            this.dtpStartDate.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(359, 120);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 44);
            this.dtpEndDate.TabIndex = 31;
            this.dtpEndDate.Visible = false;
            // 
            // mesGrid1
            // 
            this.mesGrid1.AutoScroll = true;
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 116);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 429);
            this.mesGrid1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(329, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "~";
            this.label1.Visible = false;
            // 
            // mesLabel2
            // 
            this.mesLabel2.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor2 = System.Drawing.Color.White;
            this.mesLabel2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel2.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel2.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel2.Location = new System.Drawing.Point(6, 61);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 26;
            this.mesLabel2.Text = "작업일자";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel3.Location = new System.Drawing.Point(130, 6);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(80, 50);
            this.mesLabel3.TabIndex = 24;
            this.mesLabel3.Text = "9999";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel4.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel4.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel4.Location = new System.Drawing.Point(130, 6);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(80, 50);
            this.mesLabel4.TabIndex = 24;
            this.mesLabel4.Text = "9999";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtDayNight
            // 
            this.txtDayNight.BackColor = System.Drawing.SystemColors.Window;
            this.txtDayNight.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtDayNight.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDayNight.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDayNight.ColorContent = System.Drawing.SystemColors.Window;
            this.txtDayNight.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDayNight.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDayNight.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDayNight.Location = new System.Drawing.Point(459, 60);
            this.txtDayNight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDayNight.MoveControl = null;
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(230, 50);
            this.txtDayNight.TabIndex = 25;
            this.txtDayNight.Tag = "A";
            this.txtDayNight.Text = "전체";
            this.txtDayNight.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDayNight.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDayNight._Click += new System.EventHandler(this.txtDayNight_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(127, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 44);
            this.dtpDate.TabIndex = 35;
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(338, 60);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 36;
            this.mesLabel6.Text = "주간/야간";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(6, 548);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(220, 50);
            this.mesLabel7.TabIndex = 37;
            this.mesLabel7.Text = "인고트(괴) 투입수량(kg)";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtIngotQty
            // 
            this.txtIngotQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtIngotQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtIngotQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIngotQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtIngotQty.ColorContent = System.Drawing.SystemColors.Window;
            this.txtIngotQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtIngotQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtIngotQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtIngotQty.Location = new System.Drawing.Point(227, 548);
            this.txtIngotQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIngotQty.MoveControl = null;
            this.txtIngotQty.Name = "txtIngotQty";
            this.txtIngotQty.Size = new System.Drawing.Size(112, 50);
            this.txtIngotQty.TabIndex = 38;
            this.txtIngotQty.Tag = "A";
            this.txtIngotQty.Text = "99999";
            this.txtIngotQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtIngotQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtTotalQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotalQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtTotalQty.ColorContent = System.Drawing.SystemColors.Window;
            this.txtTotalQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtTotalQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotalQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtTotalQty.Location = new System.Drawing.Point(900, 548);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalQty.MoveControl = null;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(112, 50);
            this.txtTotalQty.TabIndex = 40;
            this.txtTotalQty.Tag = "A";
            this.txtTotalQty.Text = "99999";
            this.txtTotalQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtTotalQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel10
            // 
            this.mesLabel10.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel10.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel10.BackColor2 = System.Drawing.Color.White;
            this.mesLabel10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel10.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel10.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel10.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel10.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel10.Location = new System.Drawing.Point(678, 548);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(220, 50);
            this.mesLabel10.TabIndex = 39;
            this.mesLabel10.Text = "총투입수량(kg)";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel8
            // 
            this.mesLabel8.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel8.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel8.BackColor2 = System.Drawing.Color.White;
            this.mesLabel8.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel8.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel8.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel8.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel8.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel8.Location = new System.Drawing.Point(342, 548);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(220, 50);
            this.mesLabel8.TabIndex = 41;
            this.mesLabel8.Text = "스크랩 투입수량(kg)";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtScrapQty
            // 
            this.txtScrapQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtScrapQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtScrapQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtScrapQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtScrapQty.ColorContent = System.Drawing.SystemColors.Window;
            this.txtScrapQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtScrapQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScrapQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtScrapQty.Location = new System.Drawing.Point(563, 548);
            this.txtScrapQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtScrapQty.MoveControl = null;
            this.txtScrapQty.Name = "txtScrapQty";
            this.txtScrapQty.Size = new System.Drawing.Size(112, 50);
            this.txtScrapQty.TabIndex = 42;
            this.txtScrapQty.Tag = "A";
            this.txtScrapQty.Text = "99999";
            this.txtScrapQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtScrapQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA5100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA5100";
            this.Text = "생산 현황";
            this.Load += new System.EventHandler(this.DA5100_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.GroupBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel mesLabel1;
        private Components.MESGrid mesGrid1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
        //private Infragistics.Win.Misc.UltraLabel lblDate;
        //private Infragistics.Win.Misc.UltraLabel lblTime;
        //private Infragistics.Win.Misc.UltraGroupBox GroupBody;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel txtDayNight;
        private Components.MESLabel mesLabel6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel txtTotalQty;
        private Components.MESLabel mesLabel10;
        private Components.MESLabel txtIngotQty;
        private Components.MESLabel mesLabel7;
        private Components.MESLabel mesLabel8;
        private Components.MESLabel txtScrapQty;
    }
}
