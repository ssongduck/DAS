namespace SmartDas
{
    partial class DA0670
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
            this.txtErrorCode = new SmartDas.Components.MESLabel();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.txtLotNo = new SmartDas.Components.MESLabel();
            this.mesLabel12 = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.mesLabel13 = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.txtErrorName = new SmartDas.Components.MESLabel();
            this.txtTotalQty = new SmartDas.Components.MESLabel();
            this.mesLabel11 = new SmartDas.Components.MESLabel();
            this.txtBadQty = new SmartDas.Components.MESLabel();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtGoodQty = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtLotQty = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "불량 등록";
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
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.txtLotQty);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtGoodQty);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtErrorCode);
            this.GroupBody.Controls.Add(this.txtBadQty);
            this.GroupBody.Controls.Add(this.mesLabel10);
            this.GroupBody.Controls.Add(this.txtTotalQty);
            this.GroupBody.Controls.Add(this.mesLabel11);
            this.GroupBody.Controls.Add(this.txtErrorName);
            this.GroupBody.Controls.Add(this.txtItemName);
            this.GroupBody.Controls.Add(this.mesLabel13);
            this.GroupBody.Controls.Add(this.txtItemCode);
            this.GroupBody.Controls.Add(this.txtLotNo);
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
            this.btnConfBox.Location = new System.Drawing.Point(741, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(269, 104);
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
            this.btnBox.Location = new System.Drawing.Point(1, 263);
            this.btnBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox.Name = "btnBox";
            this.btnBox.SelectCommand = null;
            this.btnBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox.SelectProcedureName = null;
            this.btnBox.Size = new System.Drawing.Size(1012, 339);
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(214, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(155, 50);
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(130, 6);
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
            this.mesLabel1.Location = new System.Drawing.Point(6, 6);
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
            this.mesLabel2.Location = new System.Drawing.Point(686, 114);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 76;
            this.mesLabel2.Text = "불량항목";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtErrorCode.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtErrorCode.BackColor2 = System.Drawing.Color.White;
            this.txtErrorCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtErrorCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtErrorCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtErrorCode.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtErrorCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtErrorCode.Location = new System.Drawing.Point(810, 230);
            this.txtErrorCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtErrorCode.MoveControl = null;
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(80, 50);
            this.txtErrorCode.TabIndex = 77;
            this.txtErrorCode.Text = "Z000";
            this.txtErrorCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtErrorCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtErrorCode.Visible = false;
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
            this.btnSelect.Location = new System.Drawing.Point(6, 114);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(204, 104);
            this.btnSelect.TabIndex = 83;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
            this.btnSelect.Load += new System.EventHandler(this.btnSelect_Load);
            // 
            // txtLotNo
            // 
            this.txtLotNo.BackColor = System.Drawing.Color.Moccasin;
            this.txtLotNo.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLotNo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLotNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLotNo.ColorContent = System.Drawing.Color.Moccasin;
            this.txtLotNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLotNo.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLotNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLotNo.Location = new System.Drawing.Point(497, 6);
            this.txtLotNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLotNo.MoveControl = null;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(236, 50);
            this.txtLotNo.TabIndex = 88;
            this.txtLotNo.Text = "1234567890123";
            this.txtLotNo.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLotNo.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel12.Location = new System.Drawing.Point(373, 7);
            this.mesLabel12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel12.MoveControl = null;
            this.mesLabel12.Name = "mesLabel12";
            this.mesLabel12.Size = new System.Drawing.Size(120, 50);
            this.mesLabel12.TabIndex = 87;
            this.mesLabel12.Text = "LOT번호";
            this.mesLabel12.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel12.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemName.Location = new System.Drawing.Point(319, 60);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(414, 50);
            this.txtItemName.TabIndex = 91;
            this.txtItemName.Text = "TEST ITEM NAME";
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel13
            // 
            this.mesLabel13.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel13.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel13.BackColor2 = System.Drawing.Color.White;
            this.mesLabel13.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel13.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel13.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel13.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel13.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel13.Location = new System.Drawing.Point(6, 60);
            this.mesLabel13.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel13.MoveControl = null;
            this.mesLabel13.Name = "mesLabel13";
            this.mesLabel13.Size = new System.Drawing.Size(120, 50);
            this.mesLabel13.TabIndex = 90;
            this.mesLabel13.Text = "품목";
            this.mesLabel13.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel13.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemCode.Location = new System.Drawing.Point(130, 60);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(185, 50);
            this.txtItemCode.TabIndex = 89;
            this.txtItemCode.Text = "12345-78901-34";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtErrorName
            // 
            this.txtErrorName.BackColor = System.Drawing.Color.Moccasin;
            this.txtErrorName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtErrorName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtErrorName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtErrorName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtErrorName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtErrorName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtErrorName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtErrorName.Location = new System.Drawing.Point(810, 114);
            this.txtErrorName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtErrorName.MoveControl = null;
            this.txtErrorName.Name = "txtErrorName";
            this.txtErrorName.Size = new System.Drawing.Size(200, 50);
            this.txtErrorName.TabIndex = 92;
            this.txtErrorName.Text = "가가가가가가가";
            this.txtErrorName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtErrorName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BackColor = System.Drawing.Color.White;
            this.txtTotalQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtTotalQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotalQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtTotalQty.ColorContent = System.Drawing.Color.White;
            this.txtTotalQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtTotalQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotalQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtTotalQty.Location = new System.Drawing.Point(810, 168);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalQty.MoveControl = null;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(201, 50);
            this.txtTotalQty.TabIndex = 94;
            this.txtTotalQty.Text = "999";
            this.txtTotalQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtTotalQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtTotalQty._Click += new System.EventHandler(this.txtTotalQty_Click);
            // 
            // mesLabel11
            // 
            this.mesLabel11.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel11.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel11.BackColor2 = System.Drawing.Color.White;
            this.mesLabel11.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel11.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel11.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel11.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel11.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel11.Location = new System.Drawing.Point(686, 168);
            this.mesLabel11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel11.MoveControl = null;
            this.mesLabel11.Name = "mesLabel11";
            this.mesLabel11.Size = new System.Drawing.Size(120, 50);
            this.mesLabel11.TabIndex = 93;
            this.mesLabel11.Text = "등록수량";
            this.mesLabel11.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel11.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtBadQty
            // 
            this.txtBadQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtBadQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtBadQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtBadQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtBadQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtBadQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtBadQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBadQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtBadQty.Location = new System.Drawing.Point(573, 168);
            this.txtBadQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBadQty.MoveControl = null;
            this.txtBadQty.Name = "txtBadQty";
            this.txtBadQty.Size = new System.Drawing.Size(107, 50);
            this.txtBadQty.TabIndex = 98;
            this.txtBadQty.Text = "99999";
            this.txtBadQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtBadQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel10.Location = new System.Drawing.Point(214, 168);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(120, 50);
            this.mesLabel10.TabIndex = 97;
            this.mesLabel10.Text = "양품수량";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 224);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 379);
            this.mesGrid1.TabIndex = 99;
            this.mesGrid1.Visible = false;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
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
            this.mesLabel3.Location = new System.Drawing.Point(449, 168);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 100;
            this.mesLabel3.Text = "불량누적수량";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtGoodQty
            // 
            this.txtGoodQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtGoodQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtGoodQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtGoodQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtGoodQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtGoodQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtGoodQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGoodQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtGoodQty.Location = new System.Drawing.Point(338, 168);
            this.txtGoodQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGoodQty.MoveControl = null;
            this.txtGoodQty.Name = "txtGoodQty";
            this.txtGoodQty.Size = new System.Drawing.Size(107, 50);
            this.txtGoodQty.TabIndex = 101;
            this.txtGoodQty.Text = "99999";
            this.txtGoodQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtGoodQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel5.Location = new System.Drawing.Point(214, 114);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 102;
            this.mesLabel5.Text = "LOT수량";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLotQty
            // 
            this.txtLotQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtLotQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLotQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLotQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLotQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtLotQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLotQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLotQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLotQty.Location = new System.Drawing.Point(338, 114);
            this.txtLotQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLotQty.MoveControl = null;
            this.txtLotQty.Name = "txtLotQty";
            this.txtLotQty.Size = new System.Drawing.Size(108, 50);
            this.txtLotQty.TabIndex = 103;
            this.txtLotQty.Text = "99999";
            this.txtLotQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtLotQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel6.Location = new System.Drawing.Point(5, 222);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(1004, 42);
            this.mesLabel6.TabIndex = 113;
            this.mesLabel6.Text = "소재불량[S]  가공/조립불량[M] ";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA0670
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0670";
            this.Text = "단말기 설정";
            this.Load += new System.EventHandler(this.DA0670_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
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
        private Components.MESLabel txtErrorCode;
        private Components.ButtonBox btnSelect;
        private Components.MESLabel txtLotNo;
        private Components.MESLabel mesLabel12;
        private Components.MESLabel txtItemName;
        private Components.MESLabel mesLabel13;
        private Components.MESLabel txtItemCode;
        private Components.MESLabel txtErrorName;
        private Components.MESLabel txtTotalQty;
        private Components.MESLabel mesLabel11;
        private Components.MESLabel txtBadQty;
        private Components.MESLabel mesLabel10;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtLotQty;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtGoodQty;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel mesLabel6;

    }
}
