namespace SmartDas
{
    partial class DA1200
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA1200));
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtWorker = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.txtDayNight = new SmartDas.Components.MESLabel();
            this.btnSearch = new SmartDas.Components.MESButton();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.lblChasu = new SmartDas.Components.MESLabel();
            this.mesGrid3 = new SmartDas.Components.MESGrid();
            this.mesGrid4 = new SmartDas.Components.MESGrid();
            this.mesGrid5 = new SmartDas.Components.MESGrid();
            this.btnLoadPrevCond = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "주조조건 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkMoveSize = 10;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkMoveSize = 10;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnLoadPrevCond);
            this.GroupBody.Controls.Add(this.mesGrid5);
            this.GroupBody.Controls.Add(this.mesGrid4);
            this.GroupBody.Controls.Add(this.mesGrid3);
            this.GroupBody.Controls.Add(this.lblChasu);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.btnSearch);
            this.GroupBody.Controls.Add(this.txtDayNight);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.txtWorker);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.mesGrid1);
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 62);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(202, 540);
            this.mesGrid1.TabIndex = 23;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(338, 9);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 44);
            this.dtpDate.TabIndex = 46;
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
            this.mesLabel4.Location = new System.Drawing.Point(6, 118);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 63;
            this.mesLabel4.Text = "작업자";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel4.Visible = false;
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
            this.txtWorker.Location = new System.Drawing.Point(127, 118);
            this.txtWorker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorker.MoveControl = null;
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(85, 50);
            this.txtWorker.TabIndex = 62;
            this.txtWorker.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorker.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorker.Visible = false;
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
            this.mesLabel1.Location = new System.Drawing.Point(6, 65);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 74;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel1.Visible = false;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(213, 65);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(180, 50);
            this.txtWorkCenterName.TabIndex = 77;
            this.txtWorkCenterName.Text = "000호기";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkCenterName.Visible = false;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(127, 65);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(85, 50);
            this.txtWorkCenterCode.TabIndex = 76;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkCenterCode.Visible = false;
            // 
            // btnConfBox
            // 
            this.btnConfBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnConfBox.CountX = 1;
            this.btnConfBox.CountY = 1;
            this.btnConfBox.CurrentPage = 0;
            this.btnConfBox.ExTag = "";
            this.btnConfBox.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfBox.Location = new System.Drawing.Point(682, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(329, 50);
            this.btnConfBox.TabIndex = 78;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
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
            this.btnSelect.Location = new System.Drawing.Point(6, 6);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(204, 50);
            this.btnSelect.TabIndex = 84;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
            // 
            // txtDayNight
            // 
            this.txtDayNight.BackColor = System.Drawing.SystemColors.Window;
            this.txtDayNight.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtDayNight.BackColor2 = System.Drawing.Color.White;
            this.txtDayNight.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDayNight.ColorContent = System.Drawing.SystemColors.Window;
            this.txtDayNight.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDayNight.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDayNight.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDayNight.Location = new System.Drawing.Point(589, 6);
            this.txtDayNight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDayNight.MoveControl = null;
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(91, 50);
            this.txtDayNight.TabIndex = 111;
            this.txtDayNight.Tag = "D";
            this.txtDayNight.Text = "주간";
            this.txtDayNight.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDayNight.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDayNight._Click += new System.EventHandler(this.txtDayNight_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(213, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ParentBox = null;
            this.btnSearch.Size = new System.Drawing.Size(180, 50);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "조회";
            this.btnSearch.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSearch.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSearch.UseFlag = true;
            this.btnSearch.Visible = false;
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
            this.mesLabel2.Location = new System.Drawing.Point(214, 6);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 114;
            this.mesLabel2.Text = "작업일자";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid2
            // 
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = null;
            this.mesGrid2.Location = new System.Drawing.Point(203, 62);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(202, 540);
            this.mesGrid2.TabIndex = 115;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // lblChasu
            // 
            this.lblChasu.BackColor = System.Drawing.SystemColors.Window;
            this.lblChasu.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblChasu.BackColor2 = System.Drawing.Color.White;
            this.lblChasu.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblChasu.ColorContent = System.Drawing.SystemColors.Window;
            this.lblChasu.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblChasu.Enabled = false;
            this.lblChasu.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChasu.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.lblChasu.Location = new System.Drawing.Point(537, 6);
            this.lblChasu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblChasu.MoveControl = null;
            this.lblChasu.Name = "lblChasu";
            this.lblChasu.Size = new System.Drawing.Size(51, 50);
            this.lblChasu.TabIndex = 116;
            this.lblChasu.Tag = "1";
            this.lblChasu.Text = "1차";
            this.lblChasu.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblChasu.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.lblChasu._Click += new System.EventHandler(this.lblChasu_Click);
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
            this.mesGrid3.HeadString = null;
            this.mesGrid3.Location = new System.Drawing.Point(405, 62);
            this.mesGrid3.Name = "mesGrid3";
            this.mesGrid3.Row = null;
            this.mesGrid3.SelectCommand = null;
            this.mesGrid3.SelectProcedureName = null;
            this.mesGrid3.Size = new System.Drawing.Size(202, 540);
            this.mesGrid3.TabIndex = 117;
            this.mesGrid3.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // mesGrid4
            // 
            this.mesGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid4.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid4.CountRows = 0;
            this.mesGrid4.FixedCols = 0;
            this.mesGrid4.FontSize = 20.25F;
            this.mesGrid4.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid4.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid4.HeadString = null;
            this.mesGrid4.Location = new System.Drawing.Point(607, 62);
            this.mesGrid4.Name = "mesGrid4";
            this.mesGrid4.Row = null;
            this.mesGrid4.SelectCommand = null;
            this.mesGrid4.SelectProcedureName = null;
            this.mesGrid4.Size = new System.Drawing.Size(202, 540);
            this.mesGrid4.TabIndex = 118;
            this.mesGrid4.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // mesGrid5
            // 
            this.mesGrid5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid5.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid5.CountRows = 0;
            this.mesGrid5.FixedCols = 0;
            this.mesGrid5.FontSize = 20.25F;
            this.mesGrid5.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid5.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid5.HeadString = null;
            this.mesGrid5.Location = new System.Drawing.Point(809, 62);
            this.mesGrid5.Name = "mesGrid5";
            this.mesGrid5.Row = null;
            this.mesGrid5.SelectCommand = null;
            this.mesGrid5.SelectProcedureName = null;
            this.mesGrid5.Size = new System.Drawing.Size(202, 540);
            this.mesGrid5.TabIndex = 119;
            this.mesGrid5.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // btnLoadPrevCond
            // 
            this.btnLoadPrevCond.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnLoadPrevCond.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadPrevCond.BackColor = System.Drawing.SystemColors.Window;
            this.btnLoadPrevCond.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnLoadPrevCond.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnLoadPrevCond.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnLoadPrevCond.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnLoadPrevCond.ButtonPressed = false;
            this.btnLoadPrevCond.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnLoadPrevCond.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnLoadPrevCond.ExTag = null;
            this.btnLoadPrevCond.Font = new System.Drawing.Font("휴먼모음T", 26.25F);
            this.btnLoadPrevCond.FontSize = 26.25F;
            this.btnLoadPrevCond.LinkButtonBox = null;
            this.btnLoadPrevCond.LinkGrid = null;
            this.btnLoadPrevCond.LinkMoveSize = 0;
            this.btnLoadPrevCond.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnLoadPrevCond.Location = new System.Drawing.Point(811, 418);
            this.btnLoadPrevCond.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLoadPrevCond.Name = "btnLoadPrevCond";
            this.btnLoadPrevCond.ParentBox = null;
            this.btnLoadPrevCond.Size = new System.Drawing.Size(191, 175);
            this.btnLoadPrevCond.TabIndex = 126;
            this.btnLoadPrevCond.Text = "이전 조건 불러오기";
            this.btnLoadPrevCond.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnLoadPrevCond.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnLoadPrevCond.UseFlag = true;
            this.btnLoadPrevCond._Click += new System.EventHandler(this.btnLoadPrevCond__Click);
            // 
            // DA1200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA1200";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.DA1200_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESGrid mesGrid1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel txtWorker;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.ButtonBox btnConfBox;
        private Components.ButtonBox btnSelect;
        private Components.MESLabel txtDayNight;
        private Components.MESButton btnSearch;
        private Components.MESLabel mesLabel2;
        private Components.MESGrid mesGrid2;
        private Components.MESLabel lblChasu;
        private Components.MESGrid mesGrid4;
        private Components.MESGrid mesGrid3;
        private Components.MESGrid mesGrid5;
        private Components.MESButton btnLoadPrevCond;
    }
}
