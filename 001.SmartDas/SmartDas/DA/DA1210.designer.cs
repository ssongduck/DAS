namespace SmartDas
{
    partial class DA1210
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA1210));
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.btnSearch = new SmartDas.Components.MESButton();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.btnNew = new SmartDas.Components.MESButton();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnClose = new SmartDas.Components.MESButton();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.lblSelection = new SmartDas.Components.MESLabel();
            this.btnDown = new SmartDas.Components.MESButton();
            this.btnUp = new SmartDas.Components.MESButton();
            this.btnModify = new SmartDas.Components.MESButton();
            this.btnDelete = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "작업일보 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkMoveSize = 8;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkMoveSize = 8;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnDelete);
            this.GroupBody.Controls.Add(this.btnModify);
            this.GroupBody.Controls.Add(this.pnlSelection);
            this.GroupBody.Controls.Add(this.btnNew);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.btnSearch);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.mesGrid1);
            // 
            // imgSamkee
            // 
            this.imgSamkee.Location = new System.Drawing.Point(18, 15);
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.Edit;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.mesGrid1.Size = new System.Drawing.Size(1012, 486);
            this.mesGrid1.TabIndex = 23;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(134, 61);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 44);
            this.dtpDate.TabIndex = 46;
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
            this.mesLabel1.TabIndex = 74;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(212, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(476, 50);
            this.txtWorkCenterName.TabIndex = 77;
            this.txtWorkCenterName.Text = "000호기";
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(128, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(83, 50);
            this.txtWorkCenterCode.TabIndex = 76;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnConfBox.TabIndex = 78;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
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
            this.btnSearch.Location = new System.Drawing.Point(341, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ParentBox = null;
            this.btnSearch.Size = new System.Drawing.Size(85, 50);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "조회";
            this.btnSearch.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSearch.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSearch.UseFlag = true;
            this.btnSearch._Click += new System.EventHandler(this.btnSearch_Click);
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
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 114;
            this.mesLabel2.Text = "작업일자";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnNew.Location = new System.Drawing.Point(428, 60);
            this.btnNew.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.ParentBox = null;
            this.btnNew.Size = new System.Drawing.Size(85, 50);
            this.btnNew.TabIndex = 115;
            this.btnNew.Text = "신규";
            this.btnNew.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnNew.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnNew.UseFlag = true;
            this.btnNew._Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Controls.Add(this.btnClose);
            this.pnlSelection.Controls.Add(this.lblSelection);
            this.pnlSelection.Controls.Add(this.btnDown);
            this.pnlSelection.Controls.Add(this.btnUp);
            this.pnlSelection.Controls.Add(this.mesGrid2);
            this.pnlSelection.Location = new System.Drawing.Point(258, 224);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(514, 358);
            this.pnlSelection.TabIndex = 134;
            this.pnlSelection.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnClose.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnClose.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnClose.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnClose.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnClose.ButtonPressed = false;
            this.btnClose.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnClose.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnClose.ExTag = null;
            this.btnClose.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnClose.FontSize = 20F;
            this.btnClose.LinkButtonBox = null;
            this.btnClose.LinkGrid = this.mesGrid2;
            this.btnClose.LinkMoveSize = 3;
            this.btnClose.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnClose.Location = new System.Drawing.Point(367, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ParentBox = null;
            this.btnClose.Size = new System.Drawing.Size(85, 50);
            this.btnClose.TabIndex = 122;
            this.btnClose.Text = "닫기";
            this.btnClose.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnClose.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnClose.UseFlag = true;
            this.btnClose._Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mesGrid2
            // 
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = "";
            this.mesGrid2.Location = new System.Drawing.Point(0, 65);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(512, 291);
            this.mesGrid2.TabIndex = 117;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid2_GridClick);
            // 
            // lblSelection
            // 
            this.lblSelection.BackColor = System.Drawing.Color.LightGreen;
            this.lblSelection.BackColor1 = System.Drawing.Color.Moccasin;
            this.lblSelection.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSelection.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblSelection.ColorContent = System.Drawing.Color.Moccasin;
            this.lblSelection.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblSelection.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSelection.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblSelection.Location = new System.Drawing.Point(60, 6);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblSelection.MoveControl = null;
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(393, 50);
            this.lblSelection.TabIndex = 114;
            this.lblSelection.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblSelection.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnDown.LinkGrid = this.mesGrid2;
            this.btnDown.LinkMoveSize = 5;
            this.btnDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown.Location = new System.Drawing.Point(457, 6);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 121;
            this.btnDown.Text = "▶";
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
            this.btnUp.LinkGrid = this.mesGrid2;
            this.btnUp.LinkMoveSize = 5;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(5, 6);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 120;
            this.btnUp.Text = "◀";
            this.btnUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp.UseFlag = true;
            // 
            // btnModify
            // 
            this.btnModify.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnModify.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModify.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModify.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnModify.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnModify.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnModify.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnModify.ButtonPressed = false;
            this.btnModify.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnModify.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnModify.ExTag = null;
            this.btnModify.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnModify.FontSize = 20F;
            this.btnModify.LinkButtonBox = null;
            this.btnModify.LinkGrid = null;
            this.btnModify.LinkMoveSize = 0;
            this.btnModify.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnModify.Location = new System.Drawing.Point(515, 60);
            this.btnModify.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnModify.Name = "btnModify";
            this.btnModify.ParentBox = null;
            this.btnModify.Size = new System.Drawing.Size(85, 50);
            this.btnModify.TabIndex = 135;
            this.btnModify.Text = "수정";
            this.btnModify.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnModify.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnModify.UseFlag = true;
            this.btnModify._Click += new System.EventHandler(this.btnModify_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(602, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ParentBox = null;
            this.btnDelete.Size = new System.Drawing.Size(85, 50);
            this.btnDelete.TabIndex = 136;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete.UseFlag = true;
            this.btnDelete._Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DA1210
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA1210";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.DA1210_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.pnlSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESGrid mesGrid1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.ButtonBox btnConfBox;
        private Components.MESButton btnSearch;
        private Components.MESLabel mesLabel2;
        private Components.MESButton btnNew;
        private System.Windows.Forms.Panel pnlSelection;
        private Components.MESLabel lblSelection;
        private Components.MESButton btnDown;
        private Components.MESGrid mesGrid2;
        private Components.MESButton btnUp;
        private Components.MESButton btnClose;
        private Components.MESButton btnDelete;
        private Components.MESButton btnModify;
    }
}
