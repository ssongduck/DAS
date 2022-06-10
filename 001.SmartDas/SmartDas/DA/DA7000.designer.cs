namespace SmartDas
{
    partial class DA7000
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
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txtMoldName = new SmartDas.Components.MESLabel();
            this.txtMoldCode = new SmartDas.Components.MESLabel();
            this.txtMoldErrDivName = new SmartDas.Components.MESLabel();
            this.txtMoldErrDivCode = new SmartDas.Components.MESLabel();
            this.lblMoldErrDivCode = new SmartDas.Components.MESLabel();
            this.txtMoldErrLocName2 = new SmartDas.Components.MESLabel();
            this.txtMoldErrLocCode2 = new SmartDas.Components.MESLabel();
            this.lblMoldErrLocCode2 = new SmartDas.Components.MESLabel();
            this.txtMoldErrLocName1 = new SmartDas.Components.MESLabel();
            this.txtMoldErrLocCode1 = new SmartDas.Components.MESLabel();
            this.txtMoldErrName = new SmartDas.Components.MESLabel();
            this.txtMoldErrCode = new SmartDas.Components.MESLabel();
            this.lblMoldErrLocCode1 = new SmartDas.Components.MESLabel();
            this.lblMoldErrCode = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.lblList = new SmartDas.Components.MESLabel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.btnDown = new SmartDas.Components.MESButton();
            this.btnUp = new SmartDas.Components.MESButton();
            this.btnRegister = new SmartDas.Components.MESButton();
            this.txtWorkerName = new SmartDas.Components.MESLabel();
            this.txtWorkerCode = new SmartDas.Components.MESLabel();
            this.lblWorker = new SmartDas.Components.MESLabel();
            this.btnDelete = new SmartDas.Components.MESButton();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtEmergency = new SmartDas.Components.MESLabel();
            this.txtCause = new SmartDas.Components.MESLabel();
            this.btnListBox = new SmartDas.Components.ButtonBox();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "금형고장";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnListBox;
            this.btnRightPage.LinkMoveSize = 2;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnListBox;
            this.btnLeftPage.LinkMoveSize = 2;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.txtRemark);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.btnListBox);
            this.GroupBody.Controls.Add(this.txtCause);
            this.GroupBody.Controls.Add(this.txtEmergency);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.btnDelete);
            this.GroupBody.Controls.Add(this.txtWorkerName);
            this.GroupBody.Controls.Add(this.txtWorkerCode);
            this.GroupBody.Controls.Add(this.lblWorker);
            this.GroupBody.Controls.Add(this.btnRegister);
            this.GroupBody.Controls.Add(this.btnDown);
            this.GroupBody.Controls.Add(this.btnUp);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.lblList);
            this.GroupBody.Controls.Add(this.txtMoldName);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtMoldCode);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.txtMoldErrDivName);
            this.GroupBody.Controls.Add(this.txtMoldErrDivCode);
            this.GroupBody.Controls.Add(this.lblMoldErrDivCode);
            this.GroupBody.Controls.Add(this.txtMoldErrLocName2);
            this.GroupBody.Controls.Add(this.txtMoldErrLocCode2);
            this.GroupBody.Controls.Add(this.lblMoldErrLocCode2);
            this.GroupBody.Controls.Add(this.txtMoldErrLocName1);
            this.GroupBody.Controls.Add(this.txtMoldErrLocCode1);
            this.GroupBody.Controls.Add(this.txtMoldErrName);
            this.GroupBody.Controls.Add(this.txtMoldErrCode);
            this.GroupBody.Controls.Add(this.lblMoldErrLocCode1);
            this.GroupBody.Controls.Add(this.lblMoldErrCode);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesGrid1);
            // 
            // txtWorkCenterName
            // 
            this.txtWorkCenterName.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtWorkCenterName.BackColor2 = System.Drawing.Color.White;
            this.txtWorkCenterName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkCenterName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkCenterName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterName.Location = new System.Drawing.Point(210, 4);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(242, 50);
            this.txtWorkCenterName.TabIndex = 51;
            this.txtWorkCenterName.Text = "1001호기";
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
            this.btnConfBox.Location = new System.Drawing.Point(741, 4);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(270, 104);
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(125, 4);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(83, 50);
            this.txtWorkCenterCode.TabIndex = 50;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel2.Location = new System.Drawing.Point(3, 58);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 59;
            this.mesLabel2.Text = "고장금형";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldName
            // 
            this.txtMoldName.BackColor = System.Drawing.Color.Moccasin;
            this.txtMoldName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldName.BackColor2 = System.Drawing.Color.White;
            this.txtMoldName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtMoldName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldName.Location = new System.Drawing.Point(270, 58);
            this.txtMoldName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldName.MoveControl = null;
            this.txtMoldName.Name = "txtMoldName";
            this.txtMoldName.Size = new System.Drawing.Size(182, 50);
            this.txtMoldName.TabIndex = 60;
            this.txtMoldName.Text = "SK-01";
            this.txtMoldName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldCode
            // 
            this.txtMoldCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtMoldCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtMoldCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldCode.Location = new System.Drawing.Point(125, 58);
            this.txtMoldCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldCode.MoveControl = null;
            this.txtMoldCode.Name = "txtMoldCode";
            this.txtMoldCode.Size = new System.Drawing.Size(143, 50);
            this.txtMoldCode.TabIndex = 50;
            this.txtMoldCode.Text = "TAI9999999";
            this.txtMoldCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldErrDivName
            // 
            this.txtMoldErrDivName.BackColor = System.Drawing.Color.White;
            this.txtMoldErrDivName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldErrDivName.BackColor2 = System.Drawing.Color.White;
            this.txtMoldErrDivName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrDivName.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrDivName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrDivName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrDivName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrDivName.Location = new System.Drawing.Point(210, 273);
            this.txtMoldErrDivName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrDivName.MoveControl = null;
            this.txtMoldErrDivName.Name = "txtMoldErrDivName";
            this.txtMoldErrDivName.Size = new System.Drawing.Size(152, 50);
            this.txtMoldErrDivName.TabIndex = 96;
            this.txtMoldErrDivName.Text = "작동불량";
            this.txtMoldErrDivName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldErrDivName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrDivName._Click += new System.EventHandler(this.txtMoldErrDivCode_Click);
            // 
            // txtMoldErrDivCode
            // 
            this.txtMoldErrDivCode.BackColor = System.Drawing.Color.White;
            this.txtMoldErrDivCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldErrDivCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldErrDivCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrDivCode.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrDivCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrDivCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrDivCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrDivCode.Location = new System.Drawing.Point(125, 273);
            this.txtMoldErrDivCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrDivCode.MoveControl = null;
            this.txtMoldErrDivCode.Name = "txtMoldErrDivCode";
            this.txtMoldErrDivCode.Size = new System.Drawing.Size(83, 50);
            this.txtMoldErrDivCode.TabIndex = 95;
            this.txtMoldErrDivCode.Text = "999";
            this.txtMoldErrDivCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldErrDivCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrDivCode._Click += new System.EventHandler(this.txtMoldErrDivCode_Click);
            // 
            // lblMoldErrDivCode
            // 
            this.lblMoldErrDivCode.BackColor = System.Drawing.Color.LightGreen;
            this.lblMoldErrDivCode.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblMoldErrDivCode.BackColor2 = System.Drawing.Color.White;
            this.lblMoldErrDivCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMoldErrDivCode.ColorContent = System.Drawing.Color.Moccasin;
            this.lblMoldErrDivCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblMoldErrDivCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoldErrDivCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblMoldErrDivCode.Location = new System.Drawing.Point(3, 273);
            this.lblMoldErrDivCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblMoldErrDivCode.MoveControl = null;
            this.lblMoldErrDivCode.Name = "lblMoldErrDivCode";
            this.lblMoldErrDivCode.Size = new System.Drawing.Size(120, 50);
            this.lblMoldErrDivCode.TabIndex = 94;
            this.lblMoldErrDivCode.Text = "고장현상";
            this.lblMoldErrDivCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblMoldErrDivCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldErrLocName2
            // 
            this.txtMoldErrLocName2.BackColor = System.Drawing.Color.White;
            this.txtMoldErrLocName2.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldErrLocName2.BackColor2 = System.Drawing.Color.White;
            this.txtMoldErrLocName2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrLocName2.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrLocName2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrLocName2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrLocName2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrLocName2.Location = new System.Drawing.Point(210, 220);
            this.txtMoldErrLocName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrLocName2.MoveControl = null;
            this.txtMoldErrLocName2.Name = "txtMoldErrLocName2";
            this.txtMoldErrLocName2.Size = new System.Drawing.Size(152, 50);
            this.txtMoldErrLocName2.TabIndex = 93;
            this.txtMoldErrLocName2.Text = "반조작측";
            this.txtMoldErrLocName2.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldErrLocName2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrLocName2._Click += new System.EventHandler(this.txtMoldErrLocCode2_Click);
            // 
            // txtMoldErrLocCode2
            // 
            this.txtMoldErrLocCode2.BackColor = System.Drawing.Color.White;
            this.txtMoldErrLocCode2.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldErrLocCode2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldErrLocCode2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrLocCode2.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrLocCode2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrLocCode2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrLocCode2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrLocCode2.Location = new System.Drawing.Point(125, 220);
            this.txtMoldErrLocCode2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrLocCode2.MoveControl = null;
            this.txtMoldErrLocCode2.Name = "txtMoldErrLocCode2";
            this.txtMoldErrLocCode2.Size = new System.Drawing.Size(83, 50);
            this.txtMoldErrLocCode2.TabIndex = 92;
            this.txtMoldErrLocCode2.Text = "999";
            this.txtMoldErrLocCode2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldErrLocCode2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrLocCode2._Click += new System.EventHandler(this.txtMoldErrLocCode2_Click);
            // 
            // lblMoldErrLocCode2
            // 
            this.lblMoldErrLocCode2.BackColor = System.Drawing.Color.LightGreen;
            this.lblMoldErrLocCode2.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblMoldErrLocCode2.BackColor2 = System.Drawing.Color.White;
            this.lblMoldErrLocCode2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMoldErrLocCode2.ColorContent = System.Drawing.Color.Moccasin;
            this.lblMoldErrLocCode2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblMoldErrLocCode2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoldErrLocCode2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblMoldErrLocCode2.Location = new System.Drawing.Point(3, 220);
            this.lblMoldErrLocCode2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblMoldErrLocCode2.MoveControl = null;
            this.lblMoldErrLocCode2.Name = "lblMoldErrLocCode2";
            this.lblMoldErrLocCode2.Size = new System.Drawing.Size(120, 50);
            this.lblMoldErrLocCode2.TabIndex = 91;
            this.lblMoldErrLocCode2.Text = "고장위치";
            this.lblMoldErrLocCode2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblMoldErrLocCode2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldErrLocName1
            // 
            this.txtMoldErrLocName1.BackColor = System.Drawing.Color.White;
            this.txtMoldErrLocName1.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldErrLocName1.BackColor2 = System.Drawing.Color.White;
            this.txtMoldErrLocName1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrLocName1.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrLocName1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrLocName1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrLocName1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrLocName1.Location = new System.Drawing.Point(210, 166);
            this.txtMoldErrLocName1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrLocName1.MoveControl = null;
            this.txtMoldErrLocName1.Name = "txtMoldErrLocName1";
            this.txtMoldErrLocName1.Size = new System.Drawing.Size(152, 50);
            this.txtMoldErrLocName1.TabIndex = 90;
            this.txtMoldErrLocName1.Text = "슬라이드(S)";
            this.txtMoldErrLocName1.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldErrLocName1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrLocName1._Click += new System.EventHandler(this.txtMoldErrLocCode1_Click);
            // 
            // txtMoldErrLocCode1
            // 
            this.txtMoldErrLocCode1.BackColor = System.Drawing.Color.White;
            this.txtMoldErrLocCode1.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldErrLocCode1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldErrLocCode1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrLocCode1.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrLocCode1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrLocCode1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrLocCode1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrLocCode1.Location = new System.Drawing.Point(125, 166);
            this.txtMoldErrLocCode1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrLocCode1.MoveControl = null;
            this.txtMoldErrLocCode1.Name = "txtMoldErrLocCode1";
            this.txtMoldErrLocCode1.Size = new System.Drawing.Size(83, 50);
            this.txtMoldErrLocCode1.TabIndex = 89;
            this.txtMoldErrLocCode1.Text = "999";
            this.txtMoldErrLocCode1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldErrLocCode1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrLocCode1._Click += new System.EventHandler(this.txtMoldErrLocCode1_Click);
            // 
            // txtMoldErrName
            // 
            this.txtMoldErrName.BackColor = System.Drawing.Color.White;
            this.txtMoldErrName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldErrName.BackColor2 = System.Drawing.Color.White;
            this.txtMoldErrName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrName.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrName.Location = new System.Drawing.Point(210, 112);
            this.txtMoldErrName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrName.MoveControl = null;
            this.txtMoldErrName.Name = "txtMoldErrName";
            this.txtMoldErrName.Size = new System.Drawing.Size(152, 50);
            this.txtMoldErrName.TabIndex = 88;
            this.txtMoldErrName.Text = "스퀴즈 코어핀";
            this.txtMoldErrName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldErrName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrName._Click += new System.EventHandler(this.txtMoldErrCode_Click);
            // 
            // txtMoldErrCode
            // 
            this.txtMoldErrCode.BackColor = System.Drawing.Color.White;
            this.txtMoldErrCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldErrCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldErrCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldErrCode.ColorContent = System.Drawing.Color.White;
            this.txtMoldErrCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldErrCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldErrCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldErrCode.Location = new System.Drawing.Point(125, 112);
            this.txtMoldErrCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldErrCode.MoveControl = null;
            this.txtMoldErrCode.Name = "txtMoldErrCode";
            this.txtMoldErrCode.Size = new System.Drawing.Size(83, 50);
            this.txtMoldErrCode.TabIndex = 87;
            this.txtMoldErrCode.Text = "999";
            this.txtMoldErrCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldErrCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldErrCode._Click += new System.EventHandler(this.txtMoldErrCode_Click);
            // 
            // lblMoldErrLocCode1
            // 
            this.lblMoldErrLocCode1.BackColor = System.Drawing.Color.LightGreen;
            this.lblMoldErrLocCode1.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblMoldErrLocCode1.BackColor2 = System.Drawing.Color.White;
            this.lblMoldErrLocCode1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMoldErrLocCode1.ColorContent = System.Drawing.Color.Moccasin;
            this.lblMoldErrLocCode1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblMoldErrLocCode1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoldErrLocCode1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblMoldErrLocCode1.Location = new System.Drawing.Point(3, 166);
            this.lblMoldErrLocCode1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblMoldErrLocCode1.MoveControl = null;
            this.lblMoldErrLocCode1.Name = "lblMoldErrLocCode1";
            this.lblMoldErrLocCode1.Size = new System.Drawing.Size(120, 50);
            this.lblMoldErrLocCode1.TabIndex = 86;
            this.lblMoldErrLocCode1.Text = "고장항목(2)";
            this.lblMoldErrLocCode1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblMoldErrLocCode1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblMoldErrCode
            // 
            this.lblMoldErrCode.BackColor = System.Drawing.Color.LightGreen;
            this.lblMoldErrCode.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblMoldErrCode.BackColor2 = System.Drawing.Color.White;
            this.lblMoldErrCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMoldErrCode.ColorContent = System.Drawing.Color.Moccasin;
            this.lblMoldErrCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblMoldErrCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoldErrCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblMoldErrCode.Location = new System.Drawing.Point(3, 112);
            this.lblMoldErrCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblMoldErrCode.MoveControl = null;
            this.lblMoldErrCode.Name = "lblMoldErrCode";
            this.lblMoldErrCode.Size = new System.Drawing.Size(120, 50);
            this.lblMoldErrCode.TabIndex = 85;
            this.lblMoldErrCode.Text = "고장항목(1)";
            this.lblMoldErrCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblMoldErrCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesGrid1.Location = new System.Drawing.Point(21, 457);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(448, 123);
            this.mesGrid1.TabIndex = 97;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.LightGreen;
            this.lblList.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblList.BackColor2 = System.Drawing.Color.White;
            this.lblList.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblList.ColorContent = System.Drawing.Color.Moccasin;
            this.lblList.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblList.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblList.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblList.Location = new System.Drawing.Point(365, 380);
            this.lblList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblList.MoveControl = null;
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(646, 50);
            this.lblList.TabIndex = 98;
            this.lblList.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblList.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesGrid2.HeadString = "원인유형@H^250|원인코드@C^250|원인명@C^280";
            this.mesGrid2.Location = new System.Drawing.Point(365, 111);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(567, 265);
            this.mesGrid2.TabIndex = 99;
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
            this.btnDown.Location = new System.Drawing.Point(935, 166);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(75, 50);
            this.btnDown.TabIndex = 101;
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
            this.btnUp.LinkGrid = this.mesGrid2;
            this.btnUp.LinkMoveSize = 5;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(935, 112);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(75, 50);
            this.btnUp.TabIndex = 100;
            this.btnUp.Text = "▲";
            this.btnUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp.UseFlag = true;
            // 
            // btnRegister
            // 
            this.btnRegister.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnRegister.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegister.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegister.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnRegister.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnRegister.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnRegister.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnRegister.ButtonPressed = false;
            this.btnRegister.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnRegister.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnRegister.ExTag = null;
            this.btnRegister.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnRegister.FontSize = 20F;
            this.btnRegister.LinkButtonBox = null;
            this.btnRegister.LinkGrid = null;
            this.btnRegister.LinkMoveSize = 1;
            this.btnRegister.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnRegister.Location = new System.Drawing.Point(935, 299);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ParentBox = null;
            this.btnRegister.Size = new System.Drawing.Size(75, 75);
            this.btnRegister.TabIndex = 102;
            this.btnRegister.Text = "등록";
            this.btnRegister.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnRegister.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnRegister.UseFlag = true;
            this.btnRegister._Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.BackColor = System.Drawing.Color.White;
            this.txtWorkerName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtWorkerName.BackColor2 = System.Drawing.Color.White;
            this.txtWorkerName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerName.ColorContent = System.Drawing.Color.White;
            this.txtWorkerName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerName.Location = new System.Drawing.Point(269, 380);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerName.MoveControl = null;
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(92, 50);
            this.txtWorkerName.TabIndex = 105;
            this.txtWorkerName.Text = "이명박";
            this.txtWorkerName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerName._Click += new System.EventHandler(this.txtworker_Click);
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
            this.txtWorkerCode.Location = new System.Drawing.Point(125, 380);
            this.txtWorkerCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCode.MoveControl = null;
            this.txtWorkerCode.Name = "txtWorkerCode";
            this.txtWorkerCode.Size = new System.Drawing.Size(143, 50);
            this.txtWorkerCode.TabIndex = 104;
            this.txtWorkerCode.Text = "1234567890";
            this.txtWorkerCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerCode._Click += new System.EventHandler(this.txtworker_Click);
            // 
            // lblWorker
            // 
            this.lblWorker.BackColor = System.Drawing.Color.LightGreen;
            this.lblWorker.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblWorker.BackColor2 = System.Drawing.Color.White;
            this.lblWorker.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblWorker.ColorContent = System.Drawing.Color.Moccasin;
            this.lblWorker.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblWorker.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorker.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblWorker.Location = new System.Drawing.Point(3, 380);
            this.lblWorker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWorker.MoveControl = null;
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(120, 50);
            this.lblWorker.TabIndex = 103;
            this.lblWorker.Text = "작업자";
            this.lblWorker.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblWorker.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnDelete.LinkMoveSize = 1;
            this.btnDelete.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDelete.Location = new System.Drawing.Point(935, 219);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ParentBox = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 106;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete.UseFlag = true;
            this.btnDelete._Click += new System.EventHandler(this.btnDelete_Click);
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
            this.mesLabel4.Location = new System.Drawing.Point(453, 4);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(122, 50);
            this.mesLabel4.TabIndex = 107;
            this.mesLabel4.Text = "긴급여부";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel5.Location = new System.Drawing.Point(453, 58);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(122, 50);
            this.mesLabel5.TabIndex = 108;
            this.mesLabel5.Text = "하형사유";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtEmergency
            // 
            this.txtEmergency.BackColor = System.Drawing.Color.White;
            this.txtEmergency.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtEmergency.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtEmergency.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtEmergency.ColorContent = System.Drawing.Color.White;
            this.txtEmergency.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtEmergency.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmergency.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtEmergency.Location = new System.Drawing.Point(577, 4);
            this.txtEmergency.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmergency.MoveControl = null;
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(162, 50);
            this.txtEmergency.TabIndex = 109;
            this.txtEmergency.Tag = "N";
            this.txtEmergency.Text = "일반등록";
            this.txtEmergency.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtEmergency.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtEmergency._Click += new System.EventHandler(this.txtEmergency_Click);
            // 
            // txtCause
            // 
            this.txtCause.BackColor = System.Drawing.Color.White;
            this.txtCause.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtCause.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCause.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtCause.ColorContent = System.Drawing.Color.White;
            this.txtCause.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtCause.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCause.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtCause.Location = new System.Drawing.Point(577, 58);
            this.txtCause.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCause.MoveControl = null;
            this.txtCause.Name = "txtCause";
            this.txtCause.Size = new System.Drawing.Size(162, 50);
            this.txtCause.TabIndex = 110;
            this.txtCause.Tag = "N";
            this.txtCause.Text = "생산변경";
            this.txtCause.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtCause.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtCause._Click += new System.EventHandler(this.txtCause_Click);
            // 
            // btnListBox
            // 
            this.btnListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnListBox.CountX = 1;
            this.btnListBox.CountY = 1;
            this.btnListBox.CurrentPage = 0;
            this.btnListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListBox.ExTag = "";
            this.btnListBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox.Location = new System.Drawing.Point(1, 435);
            this.btnListBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.SelectCommand = null;
            this.btnListBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Multiple;
            this.btnListBox.SelectProcedureName = null;
            this.btnListBox.Size = new System.Drawing.Size(1012, 167);
            this.btnListBox.TabIndex = 111;
            this.btnListBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnListBox_buttonClickEvent);
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
            this.mesLabel3.Location = new System.Drawing.Point(3, 326);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 112;
            this.mesLabel3.Text = "비 고";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(127, 328);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(232, 44);
            this.txtRemark.TabIndex = 118;
            // 
            // DA7000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA7000";
            this.Text = "설비 고장";
            this.Load += new System.EventHandler(this.DA7000_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.GroupBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtWorkCenterName;
        private Components.ButtonBox btnConfBox;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel txtMoldName;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel txtMoldCode;
        private Components.MESLabel txtMoldErrDivName;
        private Components.MESLabel txtMoldErrDivCode;
        private Components.MESLabel lblMoldErrDivCode;
        private Components.MESLabel txtMoldErrLocName2;
        private Components.MESLabel txtMoldErrLocCode2;
        private Components.MESLabel lblMoldErrLocCode2;
        private Components.MESLabel txtMoldErrLocName1;
        private Components.MESLabel txtMoldErrLocCode1;
        private Components.MESLabel txtMoldErrName;
        private Components.MESLabel txtMoldErrCode;
        private Components.MESLabel lblMoldErrLocCode1;
        private Components.MESLabel lblMoldErrCode;
        private Components.MESLabel lblList;
        private Components.MESGrid mesGrid1;
        private Components.MESGrid mesGrid2;
        private Components.MESButton btnRegister;
        private Components.MESButton btnDown;
        private Components.MESButton btnUp;
        private Components.MESLabel txtWorkerName;
        private Components.MESLabel txtWorkerCode;
        private Components.MESLabel lblWorker;
        private Components.MESButton btnDelete;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtEmergency;
        private Components.MESLabel txtCause;
        private Components.ButtonBox btnListBox;
        private Components.MESLabel mesLabel3;
        private System.Windows.Forms.TextBox txtRemark;

    }
}
