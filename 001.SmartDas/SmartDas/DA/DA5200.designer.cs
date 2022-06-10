namespace SmartDas
{
    partial class DA5200
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
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.txtWorkerName = new SmartDas.Components.MESLabel();
            this.txtWorkerCode = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.mesGrid3 = new SmartDas.Components.MESGrid();
            this.btnDown = new SmartDas.Components.MESButton();
            this.btnUp = new SmartDas.Components.MESButton();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.btnSearch = new SmartDas.Components.MESButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.pnlPlant = new System.Windows.Forms.Panel();
            this.mesButton3 = new SmartDas.Components.MESButton();
            this.btnKeyPad = new SmartDas.Components.ButtonBox();
            this.btnDelete = new SmartDas.Components.MESButton();
            this.btnNew = new SmartDas.Components.MESButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mesButton2 = new SmartDas.Components.MESButton();
            this.mesButton1 = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.pnlPlant.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork.BackColor = System.Drawing.Color.White;
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "보온로";
            // 
            // lblMes
            // 
            this.lblMes.BackColor = System.Drawing.Color.White;
            this.lblMes._Click += new System.EventHandler(this.lblMes_Click);
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
            this.GroupBody.Controls.Add(this.btnKeyPad);
            this.GroupBody.Controls.Add(this.pnlPlant);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.btnSearch);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.mesLabel10);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.txtWorkerName);
            this.GroupBody.Controls.Add(this.txtWorkerCode);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.panel1);
            this.GroupBody.Controls.Add(this.btnDelete);
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(211, 4);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(163, 50);
            this.txtWorkCenterName.TabIndex = 51;
            this.txtWorkCenterName.Text = "보온로";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnConfBox.Location = new System.Drawing.Point(746, 4);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(267, 104);
            this.btnConfBox.TabIndex = 53;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
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
            this.mesLabel1.Location = new System.Drawing.Point(3, 4);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 49;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(123, 4);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(87, 50);
            this.txtWorkCenterCode.TabIndex = 50;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel3.Location = new System.Drawing.Point(499, 112);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(514, 50);
            this.mesLabel3.TabIndex = 98;
            this.mesLabel3.Text = "래 들 정 보";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid2
            // 
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = "원인유형@H^250|원인코드@C^250|원인명@C^280";
            this.mesGrid2.Location = new System.Drawing.Point(499, 166);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(514, 230);
            this.mesGrid2.TabIndex = 99;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid2_GridClick);
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.BackColor = System.Drawing.Color.White;
            this.txtWorkerName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerName.ColorContent = System.Drawing.Color.White;
            this.txtWorkerName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerName.Location = new System.Drawing.Point(643, 4);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerName.MoveControl = null;
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(101, 50);
            this.txtWorkerName.TabIndex = 105;
            this.txtWorkerName.Text = "이명박";
            this.txtWorkerName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerName.Click += new System.EventHandler(this.txtWorkerCode_Click);
            // 
            // txtWorkerCode
            // 
            this.txtWorkerCode.BackColor = System.Drawing.Color.White;
            this.txtWorkerCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerCode.ColorContent = System.Drawing.Color.White;
            this.txtWorkerCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerCode.Location = new System.Drawing.Point(499, 4);
            this.txtWorkerCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCode.MoveControl = null;
            this.txtWorkerCode.Name = "txtWorkerCode";
            this.txtWorkerCode.Size = new System.Drawing.Size(143, 50);
            this.txtWorkerCode.TabIndex = 104;
            this.txtWorkerCode.Text = "1234567890";
            this.txtWorkerCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerCode.Click += new System.EventHandler(this.txtWorkerCode_Click);
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
            this.mesLabel6.Location = new System.Drawing.Point(377, 4);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 103;
            this.mesLabel6.Text = "작업자";
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
            this.mesLabel7.Location = new System.Drawing.Point(5, 6);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(50, 184);
            this.mesLabel7.TabIndex = 114;
            this.mesLabel7.Text = "납품업체";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid3
            // 
            this.mesGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid3.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid3.CountRows = 0;
            this.mesGrid3.FixedCols = 0;
            this.mesGrid3.FontSize = 20.25F;
            this.mesGrid3.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid3.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid3.HeadString = "원인유형@H^250|원인코드@C^250|원인명@C^280";
            this.mesGrid3.Location = new System.Drawing.Point(59, 6);
            this.mesGrid3.Name = "mesGrid3";
            this.mesGrid3.Row = null;
            this.mesGrid3.SelectCommand = null;
            this.mesGrid3.SelectProcedureName = null;
            this.mesGrid3.Size = new System.Drawing.Size(219, 184);
            this.mesGrid3.TabIndex = 117;
            this.mesGrid3.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid3_GridClick);
            // 
            // btnDown
            // 
            this.btnDown.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDown.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDown.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown.ButtonPressed = false;
            this.btnDown.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown.ExTag = null;
            this.btnDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown.FontSize = 20F;
            this.btnDown.LinkButtonBox = null;
            this.btnDown.LinkGrid = this.mesGrid3;
            this.btnDown.LinkMoveSize = 3;
            this.btnDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown.Location = new System.Drawing.Point(284, 130);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(50, 58);
            this.btnDown.TabIndex = 121;
            this.btnDown.Text = "▼";
            this.btnDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown.UseFlag = true;
            // 
            // btnUp
            // 
            this.btnUp.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnUp.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUp.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp.ButtonPressed = false;
            this.btnUp.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp.ExTag = null;
            this.btnUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp.FontSize = 20F;
            this.btnUp.LinkButtonBox = null;
            this.btnUp.LinkGrid = this.mesGrid3;
            this.btnUp.LinkMoveSize = 3;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(284, 6);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(50, 58);
            this.btnUp.TabIndex = 120;
            this.btnUp.Text = "▲";
            this.btnUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp.UseFlag = true;
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
            this.btnSelect.Location = new System.Drawing.Point(3, 58);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(246, 50);
            this.btnSelect.TabIndex = 123;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
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
            this.btnSearch.Location = new System.Drawing.Point(580, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ParentBox = null;
            this.btnSearch.Size = new System.Drawing.Size(164, 50);
            this.btnSearch.TabIndex = 129;
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
            this.dtpDate.Location = new System.Drawing.Point(375, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 44);
            this.dtpDate.TabIndex = 128;
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
            this.mesLabel10.Location = new System.Drawing.Point(252, 58);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(120, 50);
            this.mesLabel10.TabIndex = 127;
            this.mesLabel10.Text = "작업일자";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = "원인유형@H^250|원인코드@C^250|원인명@C^280";
            this.mesGrid1.Location = new System.Drawing.Point(3, 166);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(492, 433);
            this.mesGrid1.TabIndex = 131;
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
            this.mesLabel2.Location = new System.Drawing.Point(3, 112);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(492, 50);
            this.mesLabel2.TabIndex = 132;
            this.mesLabel2.Text = "운 송 정 보";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // pnlPlant
            // 
            this.pnlPlant.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlant.Controls.Add(this.mesButton3);
            this.pnlPlant.Controls.Add(this.mesLabel7);
            this.pnlPlant.Controls.Add(this.btnDown);
            this.pnlPlant.Controls.Add(this.btnUp);
            this.pnlPlant.Controls.Add(this.mesGrid3);
            this.pnlPlant.Location = new System.Drawing.Point(77, 360);
            this.pnlPlant.Name = "pnlPlant";
            this.pnlPlant.Size = new System.Drawing.Size(342, 199);
            this.pnlPlant.TabIndex = 133;
            this.pnlPlant.Visible = false;
            // 
            // mesButton3
            // 
            this.mesButton3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.mesButton3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mesButton3.BackColor = System.Drawing.Color.SkyBlue;
            this.mesButton3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.mesButton3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.mesButton3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.mesButton3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.mesButton3.ButtonPressed = false;
            this.mesButton3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.mesButton3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.mesButton3.ExTag = null;
            this.mesButton3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.mesButton3.FontSize = 20F;
            this.mesButton3.LinkButtonBox = null;
            this.mesButton3.LinkGrid = this.mesGrid3;
            this.mesButton3.LinkMoveSize = 3;
            this.mesButton3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.mesButton3.Location = new System.Drawing.Point(284, 68);
            this.mesButton3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mesButton3.Name = "mesButton3";
            this.mesButton3.ParentBox = null;
            this.mesButton3.Size = new System.Drawing.Size(50, 58);
            this.mesButton3.TabIndex = 122;
            this.mesButton3.Text = "X";
            this.mesButton3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesButton3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesButton3.UseFlag = true;
            this.mesButton3._Click += new System.EventHandler(this.mesButton3_Click);
            // 
            // btnKeyPad
            // 
            this.btnKeyPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnKeyPad.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnKeyPad.CountX = 1;
            this.btnKeyPad.CountY = 1;
            this.btnKeyPad.CurrentPage = 0;
            this.btnKeyPad.ExTag = "";
            this.btnKeyPad.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKeyPad.Location = new System.Drawing.Point(501, 454);
            this.btnKeyPad.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnKeyPad.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnKeyPad.Name = "btnKeyPad";
            this.btnKeyPad.SelectCommand = null;
            this.btnKeyPad.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnKeyPad.SelectProcedureName = null;
            this.btnKeyPad.Size = new System.Drawing.Size(508, 142);
            this.btnKeyPad.TabIndex = 134;
            this.btnKeyPad.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnKeyPad_buttonClickEvent);
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
            this.btnDelete.Enabled = false;
            this.btnDelete.ExTag = null;
            this.btnDelete.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnDelete.FontSize = 24F;
            this.btnDelete.LinkButtonBox = null;
            this.btnDelete.LinkGrid = null;
            this.btnDelete.LinkMoveSize = 0;
            this.btnDelete.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnDelete.Location = new System.Drawing.Point(872, 406);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ParentBox = null;
            this.btnDelete.Size = new System.Drawing.Size(136, 43);
            this.btnDelete.TabIndex = 136;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete.UseFlag = true;
            this.btnDelete.Visible = false;
            this.btnDelete._Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnNew.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNew.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnNew.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnNew.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnNew.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnNew.ButtonPressed = false;
            this.btnNew.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnNew.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnNew.ExTag = null;
            this.btnNew.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnNew.FontSize = 20F;
            this.btnNew.LinkButtonBox = null;
            this.btnNew.LinkGrid = null;
            this.btnNew.LinkMoveSize = 0;
            this.btnNew.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnNew.Location = new System.Drawing.Point(295, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.ParentBox = null;
            this.btnNew.Size = new System.Drawing.Size(213, 44);
            this.btnNew.TabIndex = 137;
            this.btnNew.Text = "신규";
            this.btnNew.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnNew.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnNew.UseFlag = true;
            this.btnNew._Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.mesButton2);
            this.panel1.Controls.Add(this.mesButton1);
            this.panel1.Location = new System.Drawing.Point(499, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 199);
            this.panel1.TabIndex = 138;
            // 
            // mesButton2
            // 
            this.mesButton2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.mesButton2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mesButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.mesButton2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.mesButton2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.mesButton2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.mesButton2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Change;
            this.mesButton2.ButtonPressed = false;
            this.mesButton2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.mesButton2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.mesButton2.Enabled = false;
            this.mesButton2.ExTag = null;
            this.mesButton2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.mesButton2.FontSize = 20F;
            this.mesButton2.LinkButtonBox = null;
            this.mesButton2.LinkGrid = null;
            this.mesButton2.LinkMoveSize = 0;
            this.mesButton2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.mesButton2.Location = new System.Drawing.Point(79, 5);
            this.mesButton2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mesButton2.Name = "mesButton2";
            this.mesButton2.ParentBox = null;
            this.mesButton2.Size = new System.Drawing.Size(213, 44);
            this.mesButton2.TabIndex = 139;
            this.mesButton2.Text = "수정";
            this.mesButton2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesButton2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesButton2.UseFlag = true;
            this.mesButton2._Click += new System.EventHandler(this.mesButton2_Click);
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
            this.mesButton1.Location = new System.Drawing.Point(5, 5);
            this.mesButton1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mesButton1.Name = "mesButton1";
            this.mesButton1.ParentBox = null;
            this.mesButton1.Size = new System.Drawing.Size(70, 44);
            this.mesButton1.TabIndex = 139;
            this.mesButton1.Text = "-";
            this.mesButton1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesButton1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesButton1.UseFlag = true;
            this.mesButton1._Click += new System.EventHandler(this.mesButton1_Click);
            // 
            // DA5200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA5200";
            this.Text = "설비 고장";
            this.Load += new System.EventHandler(this.DA5200_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.pnlPlant.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtWorkCenterName;
        private Components.ButtonBox btnConfBox;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel mesLabel3;
        private Components.MESGrid mesGrid2;
        private Components.MESLabel txtWorkerName;
        private Components.MESLabel txtWorkerCode;
        private Components.MESLabel mesLabel6;
        private Components.MESLabel mesLabel7;
        private Components.MESGrid mesGrid3;
        private Components.MESButton btnDown;
        private Components.MESButton btnUp;
        private Components.ButtonBox btnSelect;
        private Components.MESButton btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel mesLabel10;
        private Components.MESGrid mesGrid1;
        private System.Windows.Forms.Panel pnlPlant;
        private Components.MESLabel mesLabel2;
        private Components.ButtonBox btnKeyPad;
        private Components.MESButton btnNew;
        private Components.MESButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private Components.MESButton mesButton1;
        private Components.MESButton mesButton2;
        private Components.MESButton mesButton3;

    }
}
