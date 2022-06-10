namespace SmartDas
{
    partial class DA0130
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
            this.btnBox = new SmartDas.Components.ButtonBox();
            this.btnDown = new SmartDas.Components.MESButton();
            this.btnBox_Sub = new SmartDas.Components.ButtonBox();
            this.btnUp = new SmartDas.Components.MESButton();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txt4MChangeCode = new SmartDas.Components.MESLabel();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.mesLabel12 = new SmartDas.Components.MESLabel();
            this.txt4MChangeName = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.btnSearch = new SmartDas.Components.MESButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txt4MMessage = new System.Windows.Forms.TextBox();
            this.txtCarType = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.txtSMSSendType = new SmartDas.Components.MESLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.btnConfirm = new SmartDas.Components.MESButton();
            this.txtQCConfirm = new System.Windows.Forms.TextBox();
            this.btnSelect2 = new SmartDas.Components.ButtonBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork.BackColor = System.Drawing.Color.White;
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "변경점 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnBox;
            this.btnRightPage.LinkMoveSize = 4;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnBox;
            this.btnLeftPage.LinkMoveSize = 4;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.panel1);
            this.GroupBody.Controls.Add(this.txtSMSSendType);
            this.GroupBody.Controls.Add(this.txtCarType);
            this.GroupBody.Controls.Add(this.txtItemCode);
            this.GroupBody.Controls.Add(this.mesLabel10);
            this.GroupBody.Controls.Add(this.txtItemName);
            this.GroupBody.Controls.Add(this.txt4MMessage);
            this.GroupBody.Controls.Add(this.btnSearch);
            this.GroupBody.Controls.Add(this.dtpDate);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.txt4MChangeCode);
            this.GroupBody.Controls.Add(this.txt4MChangeName);
            this.GroupBody.Controls.Add(this.mesLabel12);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.btnDown);
            this.GroupBody.Controls.Add(this.btnUp);
            this.GroupBody.Controls.Add(this.btnBox_Sub);
            this.GroupBody.Controls.Add(this.btnBox);
            this.GroupBody.Controls.Add(this.btnConfBox);
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
            this.btnConfBox.Size = new System.Drawing.Size(320, 154);
            this.btnConfBox.TabIndex = 10;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // btnBox
            // 
            this.btnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnBox.CountX = 2;
            this.btnBox.CountY = 4;
            this.btnBox.CurrentPage = 0;
            this.btnBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBox.ExTag = "";
            this.btnBox.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBox.Location = new System.Drawing.Point(1, 215);
            this.btnBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox.Name = "btnBox";
            this.btnBox.SelectCommand = null;
            this.btnBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox.SelectProcedureName = null;
            this.btnBox.Size = new System.Drawing.Size(1012, 387);
            this.btnBox.TabIndex = 17;
            this.btnBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnBox_buttonChangeEvent);
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
            this.btnDown.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnDown.FontSize = 24F;
            this.btnDown.LinkButtonBox = this.btnBox_Sub;
            this.btnDown.LinkGrid = null;
            this.btnDown.LinkMoveSize = 1;
            this.btnDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown.Location = new System.Drawing.Point(940, 274);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(70, 50);
            this.btnDown.TabIndex = 39;
            this.btnDown.Text = "▼";
            this.btnDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown.UseFlag = true;
            this.btnDown.Visible = false;
            // 
            // btnBox_Sub
            // 
            this.btnBox_Sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox_Sub.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnBox_Sub.CountX = 5;
            this.btnBox_Sub.CountY = 1;
            this.btnBox_Sub.CurrentPage = 0;
            this.btnBox_Sub.ExTag = "";
            this.btnBox_Sub.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBox_Sub.Location = new System.Drawing.Point(6, 224);
            this.btnBox_Sub.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox_Sub.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox_Sub.Name = "btnBox_Sub";
            this.btnBox_Sub.SelectCommand = null;
            this.btnBox_Sub.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox_Sub.SelectProcedureName = null;
            this.btnBox_Sub.Size = new System.Drawing.Size(923, 100);
            this.btnBox_Sub.TabIndex = 37;
            this.btnBox_Sub.Visible = false;
            this.btnBox_Sub.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnBox_Sub_buttonChangeEvent);
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
            this.btnUp.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnUp.FontSize = 24F;
            this.btnUp.LinkButtonBox = this.btnBox_Sub;
            this.btnUp.LinkGrid = null;
            this.btnUp.LinkMoveSize = 1;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(940, 224);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(70, 50);
            this.btnUp.TabIndex = 38;
            this.btnUp.Text = "▲";
            this.btnUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp.UseFlag = true;
            this.btnUp.Visible = false;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(210, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(477, 50);
            this.txtWorkCenterName.TabIndex = 75;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(127, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(80, 50);
            this.txtWorkCenterCode.TabIndex = 74;
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
            this.mesLabel1.Location = new System.Drawing.Point(4, 6);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 73;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel2.Location = new System.Drawing.Point(684, 162);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 76;
            this.mesLabel2.Text = "변경유형";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txt4MChangeCode
            // 
            this.txt4MChangeCode.BackColor = System.Drawing.Color.Moccasin;
            this.txt4MChangeCode.BackColor1 = System.Drawing.Color.LightGreen;
            this.txt4MChangeCode.BackColor2 = System.Drawing.Color.White;
            this.txt4MChangeCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txt4MChangeCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txt4MChangeCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txt4MChangeCode.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt4MChangeCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txt4MChangeCode.Location = new System.Drawing.Point(810, 230);
            this.txt4MChangeCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt4MChangeCode.MoveControl = null;
            this.txt4MChangeCode.Name = "txt4MChangeCode";
            this.txt4MChangeCode.Size = new System.Drawing.Size(80, 50);
            this.txt4MChangeCode.TabIndex = 77;
            this.txt4MChangeCode.Text = "Z000";
            this.txt4MChangeCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txt4MChangeCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txt4MChangeCode.Visible = false;
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
            this.btnSelect.Location = new System.Drawing.Point(3, 162);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(204, 50);
            this.btnSelect.TabIndex = 83;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
            // 
            // mesLabel12
            // 
            this.mesLabel12.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel12.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel12.BackColor2 = System.Drawing.Color.White;
            this.mesLabel12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel12.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel12.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel12.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel12.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel12.Location = new System.Drawing.Point(4, 112);
            this.mesLabel12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel12.MoveControl = null;
            this.mesLabel12.Name = "mesLabel12";
            this.mesLabel12.Size = new System.Drawing.Size(120, 50);
            this.mesLabel12.TabIndex = 87;
            this.mesLabel12.Text = "변경내용";
            this.mesLabel12.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel12.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txt4MChangeName
            // 
            this.txt4MChangeName.BackColor = System.Drawing.Color.Moccasin;
            this.txt4MChangeName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txt4MChangeName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt4MChangeName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txt4MChangeName.ColorContent = System.Drawing.Color.Moccasin;
            this.txt4MChangeName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txt4MChangeName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt4MChangeName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txt4MChangeName.Location = new System.Drawing.Point(808, 162);
            this.txt4MChangeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt4MChangeName.MoveControl = null;
            this.txt4MChangeName.Name = "txt4MChangeName";
            this.txt4MChangeName.Size = new System.Drawing.Size(203, 50);
            this.txt4MChangeName.TabIndex = 92;
            this.txt4MChangeName.Text = "가가가가가가가";
            this.txt4MChangeName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txt4MChangeName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesGrid1.Location = new System.Drawing.Point(0, 5);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 227);
            this.mesGrid1.TabIndex = 99;
            this.mesGrid1.Visible = false;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
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
            this.btnSearch.Location = new System.Drawing.Point(541, 162);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ParentBox = null;
            this.btnSearch.Size = new System.Drawing.Size(138, 50);
            this.btnSearch.TabIndex = 110;
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
            this.dtpDate.Location = new System.Drawing.Point(336, 165);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 44);
            this.dtpDate.TabIndex = 109;
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
            this.mesLabel4.Location = new System.Drawing.Point(212, 162);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 108;
            this.mesLabel4.Text = "등록일자";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txt4MMessage
            // 
            this.txt4MMessage.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.txt4MMessage.Location = new System.Drawing.Point(126, 115);
            this.txt4MMessage.MaxLength = 0;
            this.txt4MMessage.Name = "txt4MMessage";
            this.txt4MMessage.Size = new System.Drawing.Size(359, 44);
            this.txt4MMessage.TabIndex = 131;
            this.txt4MMessage.Text = "변경내용";
            // 
            // txtCarType
            // 
            this.txtCarType.BackColor = System.Drawing.Color.Moccasin;
            this.txtCarType.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtCarType.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCarType.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtCarType.ColorContent = System.Drawing.Color.Moccasin;
            this.txtCarType.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtCarType.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCarType.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtCarType.Location = new System.Drawing.Point(127, 60);
            this.txtCarType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCarType.MoveControl = null;
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(95, 50);
            this.txtCarType.TabIndex = 137;
            this.txtCarType.Text = "K7";
            this.txtCarType.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtCarType.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemCode.Location = new System.Drawing.Point(225, 60);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(200, 50);
            this.txtItemCode.TabIndex = 134;
            this.txtItemCode.Text = "12345-78901-34";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel10.Location = new System.Drawing.Point(4, 60);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(120, 50);
            this.mesLabel10.TabIndex = 136;
            this.mesLabel10.Text = "품목";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemName.Location = new System.Drawing.Point(428, 60);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(259, 50);
            this.txtItemName.TabIndex = 135;
            this.txtItemName.Text = "TEST ITEM NAME";
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtSMSSendType
            // 
            this.txtSMSSendType.BackColor = System.Drawing.SystemColors.Window;
            this.txtSMSSendType.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtSMSSendType.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSMSSendType.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtSMSSendType.ColorContent = System.Drawing.SystemColors.Window;
            this.txtSMSSendType.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtSMSSendType.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSMSSendType.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtSMSSendType.Location = new System.Drawing.Point(489, 112);
            this.txtSMSSendType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSMSSendType.MoveControl = null;
            this.txtSMSSendType.Name = "txtSMSSendType";
            this.txtSMSSendType.Size = new System.Drawing.Size(198, 50);
            this.txtSMSSendType.TabIndex = 138;
            this.txtSMSSendType.Tag = "A";
            this.txtSMSSendType.Text = "SMS해당공정전송";
            this.txtSMSSendType.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtSMSSendType.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtSMSSendType._Click += new System.EventHandler(this.txtSMSSendType_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mesGrid2);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txtQCConfirm);
            this.panel1.Controls.Add(this.btnSelect2);
            this.panel1.Controls.Add(this.mesGrid1);
            this.panel1.Location = new System.Drawing.Point(1, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 387);
            this.panel1.TabIndex = 139;
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
            this.mesGrid2.Location = new System.Drawing.Point(0, 291);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(1012, 94);
            this.mesGrid2.TabIndex = 141;
            this.mesGrid2.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnConfirm.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfirm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConfirm.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnConfirm.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnConfirm.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnConfirm.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnConfirm.ButtonPressed = false;
            this.btnConfirm.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnConfirm.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnConfirm.ExTag = null;
            this.btnConfirm.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnConfirm.FontSize = 20F;
            this.btnConfirm.LinkButtonBox = null;
            this.btnConfirm.LinkGrid = null;
            this.btnConfirm.LinkMoveSize = 0;
            this.btnConfirm.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnConfirm.Location = new System.Drawing.Point(572, 238);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ParentBox = null;
            this.btnConfirm.Size = new System.Drawing.Size(138, 50);
            this.btnConfirm.TabIndex = 140;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnConfirm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnConfirm.UseFlag = true;
            this.btnConfirm._Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtQCConfirm
            // 
            this.txtQCConfirm.Font = new System.Drawing.Font("휴먼모음T", 26.5F);
            this.txtQCConfirm.Location = new System.Drawing.Point(208, 238);
            this.txtQCConfirm.MaxLength = 0;
            this.txtQCConfirm.Name = "txtQCConfirm";
            this.txtQCConfirm.Size = new System.Drawing.Size(359, 48);
            this.txtQCConfirm.TabIndex = 140;
            this.txtQCConfirm.Text = "확인내용";
            // 
            // btnSelect2
            // 
            this.btnSelect2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelect2.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnSelect2.CountX = 1;
            this.btnSelect2.CountY = 1;
            this.btnSelect2.CurrentPage = 0;
            this.btnSelect2.ExTag = "";
            this.btnSelect2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect2.Location = new System.Drawing.Point(0, 237);
            this.btnSelect2.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect2.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.SelectCommand = null;
            this.btnSelect2.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect2.SelectProcedureName = null;
            this.btnSelect2.Size = new System.Drawing.Size(204, 50);
            this.btnSelect2.TabIndex = 140;
            this.btnSelect2.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect2_buttonChangeEvent);
            // 
            // DA0130
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0130";
            this.Text = "단말기 설정";
            this.Load += new System.EventHandler(this.DA0130_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.GroupBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.ButtonBox btnBox;
        private Components.MESButton btnDown;
        private Components.ButtonBox btnBox_Sub;
        private Components.MESButton btnUp;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel txt4MChangeCode;
        private Components.ButtonBox btnSelect;
        private Components.MESLabel mesLabel12;
        private Components.MESLabel txt4MChangeName;
        private Components.MESGrid mesGrid1;
        private Components.MESButton btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Components.MESLabel mesLabel4;
        private System.Windows.Forms.TextBox txt4MMessage;
        private Components.MESLabel txtCarType;
        private Components.MESLabel txtItemCode;
        private Components.MESLabel mesLabel10;
        private Components.MESLabel txtItemName;
        private Components.MESLabel txtSMSSendType;
        private System.Windows.Forms.Panel panel1;
        private Components.MESGrid mesGrid2;
        private Components.MESButton btnConfirm;
        private System.Windows.Forms.TextBox txtQCConfirm;
        private Components.ButtonBox btnSelect2;

    }
}
