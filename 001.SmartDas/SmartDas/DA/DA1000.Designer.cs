namespace SmartDas
{
    partial class DA1000
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
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.btnMenu = new SmartDas.Components.ButtonBox();
            this.txtMachName = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtMachCode = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txtStartTime = new SmartDas.Components.MESLabel();
            this.txtDelay = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtfaultflag = new SmartDas.Components.MESLabel();
            this.btnSearch = new SmartDas.Components.MESButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.btnDelete = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "설비 보전";
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
            this.GroupBody.Controls.Add(this.btnDelete);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.btnSearch);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.txtfaultflag);
            this.GroupBody.Controls.Add(this.txtMachName);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtMachCode);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.txtDelay);
            this.GroupBody.Controls.Add(this.txtStartTime);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.btnMenu);
            this.GroupBody.Controls.Add(this.mesGrid1);
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(214, 7);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(468, 50);
            this.txtWorkCenterName.TabIndex = 56;
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel1.Location = new System.Drawing.Point(6, 7);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 54;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(130, 7);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(80, 50);
            this.txtWorkCenterCode.TabIndex = 55;
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 173);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 429);
            this.mesGrid1.TabIndex = 58;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // btnMenu
            // 
            this.btnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMenu.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnMenu.CountX = 1;
            this.btnMenu.CountY = 1;
            this.btnMenu.CurrentPage = 0;
            this.btnMenu.ExTag = "";
            this.btnMenu.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu.Location = new System.Drawing.Point(690, 6);
            this.btnMenu.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnMenu.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.SelectCommand = null;
            this.btnMenu.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnMenu.SelectProcedureName = null;
            this.btnMenu.Size = new System.Drawing.Size(320, 158);
            this.btnMenu.TabIndex = 59;
            this.btnMenu.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnMenu_buttonClickEvent);
            // 
            // txtMachName
            // 
            this.txtMachName.BackColor = System.Drawing.Color.Moccasin;
            this.txtMachName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMachName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMachName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMachName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtMachName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMachName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMachName.Location = new System.Drawing.Point(214, 61);
            this.txtMachName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachName.MoveControl = null;
            this.txtMachName.Name = "txtMachName";
            this.txtMachName.Size = new System.Drawing.Size(468, 50);
            this.txtMachName.TabIndex = 62;
            this.txtMachName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMachName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel3.Location = new System.Drawing.Point(6, 61);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 60;
            this.mesLabel3.Text = "고장설비";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMachCode
            // 
            this.txtMachCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtMachCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMachCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMachCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMachCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtMachCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMachCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMachCode.Location = new System.Drawing.Point(130, 61);
            this.txtMachCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachCode.MoveControl = null;
            this.txtMachCode.Name = "txtMachCode";
            this.txtMachCode.Size = new System.Drawing.Size(80, 50);
            this.txtMachCode.TabIndex = 61;
            this.txtMachCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMachCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel2.Location = new System.Drawing.Point(6, 114);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 63;
            this.mesLabel2.Text = "고장시각";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.Moccasin;
            this.txtStartTime.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtStartTime.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtStartTime.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtStartTime.ColorContent = System.Drawing.Color.Moccasin;
            this.txtStartTime.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtStartTime.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartTime.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtStartTime.Location = new System.Drawing.Point(130, 114);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStartTime.MoveControl = null;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(230, 50);
            this.txtStartTime.TabIndex = 64;
            this.txtStartTime.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtStartTime.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtStartTime.Visible = false;
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.Color.Moccasin;
            this.txtDelay.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtDelay.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDelay.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDelay.ColorContent = System.Drawing.Color.Moccasin;
            this.txtDelay.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDelay.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDelay.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDelay.Location = new System.Drawing.Point(488, 114);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDelay.MoveControl = null;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(194, 50);
            this.txtDelay.TabIndex = 65;
            this.txtDelay.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtDelay.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDelay.Visible = false;
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
            this.mesLabel4.Location = new System.Drawing.Point(364, 114);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 66;
            this.mesLabel4.Text = "지연시간";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel4.Visible = false;
            // 
            // txtfaultflag
            // 
            this.txtfaultflag.BackColor = System.Drawing.Color.Moccasin;
            this.txtfaultflag.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtfaultflag.BackColor2 = System.Drawing.Color.White;
            this.txtfaultflag.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtfaultflag.ColorContent = System.Drawing.Color.Moccasin;
            this.txtfaultflag.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtfaultflag.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtfaultflag.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtfaultflag.Location = new System.Drawing.Point(77, 204);
            this.txtfaultflag.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtfaultflag.MoveControl = null;
            this.txtfaultflag.Name = "txtfaultflag";
            this.txtfaultflag.Size = new System.Drawing.Size(239, 50);
            this.txtfaultflag.TabIndex = 67;
            this.txtfaultflag.Text = "FAULTFLAG";
            this.txtfaultflag.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtfaultflag.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtfaultflag.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnSearch.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnSearch.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnSearch.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnSearch.ButtonPressed = false;
            this.btnSearch.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnSearch.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnSearch.ExTag = null;
            this.btnSearch.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnSearch.FontSize = 20F;
            this.btnSearch.LinkButtonBox = null;
            this.btnSearch.LinkGrid = null;
            this.btnSearch.LinkMoveSize = 0;
            this.btnSearch.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnSearch.Location = new System.Drawing.Point(541, 120);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ParentBox = null;
            this.btnSearch.Size = new System.Drawing.Size(69, 42);
            this.btnSearch.TabIndex = 111;
            this.btnSearch.Text = "조회";
            this.btnSearch.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSearch.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSearch.UseFlag = true;
            this.btnSearch._Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(337, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 44);
            this.dtpDate.TabIndex = 110;
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
            this.mesLabel5.Location = new System.Drawing.Point(252, 114);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(82, 50);
            this.mesLabel5.TabIndex = 109;
            this.mesLabel5.Text = "작업일자";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnSelect
            // 
            this.btnSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelect.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnSelect.CountX = 1;
            this.btnSelect.CountY = 1;
            this.btnSelect.CurrentPage = 0;
            this.btnSelect.ExTag = "";
            this.btnSelect.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(7, 115);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(240, 50);
            this.btnSelect.TabIndex = 108;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
            // 
            // mesGrid2
            // 
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = null;
            this.mesGrid2.Location = new System.Drawing.Point(-2, 174);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(1015, 427);
            this.mesGrid2.TabIndex = 112;
            this.mesGrid2.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDelete.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDelete.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDelete.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDelete.ButtonPressed = false;
            this.btnDelete.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDelete.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDelete.ExTag = null;
            this.btnDelete.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDelete.FontSize = 20F;
            this.btnDelete.LinkButtonBox = null;
            this.btnDelete.LinkGrid = null;
            this.btnDelete.LinkMoveSize = 0;
            this.btnDelete.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnDelete.Location = new System.Drawing.Point(613, 120);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ParentBox = null;
            this.btnDelete.Size = new System.Drawing.Size(69, 42);
            this.btnDelete.TabIndex = 113;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete.UseFlag = true;
            this.btnDelete._Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DA1000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA1000";
            this.Load += new System.EventHandler(this.DA1000_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESGrid mesGrid1;
        private Components.ButtonBox btnMenu;
        private Components.MESLabel txtMachName;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel txtMachCode;
        private Components.MESLabel txtDelay;
        private Components.MESLabel txtStartTime;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel txtfaultflag;
        private Components.MESButton btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel mesLabel5;
        private Components.ButtonBox btnSelect;
        private Components.MESGrid mesGrid2;
        private Components.MESButton btnDelete;

    }
}
