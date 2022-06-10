namespace SmartDas
{
    partial class DA1010
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
            this.txtMachName = new SmartDas.Components.MESLabel();
            this.txtMachCode = new SmartDas.Components.MESLabel();
            this.txtrepaircodeNm = new SmartDas.Components.MESLabel();
            this.txtrepaircode = new SmartDas.Components.MESLabel();
            this.Labelrepaircode = new SmartDas.Components.MESLabel();
            this.txterrorressonNm = new SmartDas.Components.MESLabel();
            this.txterrorresson = new SmartDas.Components.MESLabel();
            this.Labelerrorresson = new SmartDas.Components.MESLabel();
            this.txterrortypeNm = new SmartDas.Components.MESLabel();
            this.txterrortype = new SmartDas.Components.MESLabel();
            this.txtmacherrorNm = new SmartDas.Components.MESLabel();
            this.txtmacherror = new SmartDas.Components.MESLabel();
            this.Labelerrortype = new SmartDas.Components.MESLabel();
            this.Labelmacherror = new SmartDas.Components.MESLabel();
            this.txtworker = new SmartDas.Components.MESLabel();
            this.Labelworker = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtworkerid = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtMAdesc = new System.Windows.Forms.TextBox();
            this.btnListBox = new SmartDas.Components.ButtonBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "설비 수리유형 선택";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnListBox;
            this.btnRightPage.LinkMoveSize = 3;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnListBox;
            this.btnLeftPage.LinkMoveSize = 3;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.btnListBox);
            this.GroupBody.Controls.Add(this.txtMAdesc);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtworkerid);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtMachName);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtMachCode);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.txtrepaircodeNm);
            this.GroupBody.Controls.Add(this.txtrepaircode);
            this.GroupBody.Controls.Add(this.Labelrepaircode);
            this.GroupBody.Controls.Add(this.txterrorressonNm);
            this.GroupBody.Controls.Add(this.txterrorresson);
            this.GroupBody.Controls.Add(this.Labelerrorresson);
            this.GroupBody.Controls.Add(this.txterrortypeNm);
            this.GroupBody.Controls.Add(this.txterrortype);
            this.GroupBody.Controls.Add(this.txtmacherrorNm);
            this.GroupBody.Controls.Add(this.txtmacherror);
            this.GroupBody.Controls.Add(this.Labelerrortype);
            this.GroupBody.Controls.Add(this.Labelmacherror);
            this.GroupBody.Controls.Add(this.txtworker);
            this.GroupBody.Controls.Add(this.Labelworker);
            this.GroupBody.Controls.Add(this.btnConfBox);
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(211, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(478, 50);
            this.txtWorkCenterName.TabIndex = 51;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
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
            this.btnConfBox.Location = new System.Drawing.Point(690, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(320, 104);
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
            this.mesLabel1.Location = new System.Drawing.Point(6, 6);
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(130, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(80, 50);
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
            this.mesLabel2.Location = new System.Drawing.Point(6, 60);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 59;
            this.mesLabel2.Text = "고장설비";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtMachName.Location = new System.Drawing.Point(211, 60);
            this.txtMachName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachName.MoveControl = null;
            this.txtMachName.Name = "txtMachName";
            this.txtMachName.Size = new System.Drawing.Size(478, 50);
            this.txtMachName.TabIndex = 60;
            this.txtMachName.Text = "TEST MACHINE NAME";
            this.txtMachName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMachName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtMachCode.Location = new System.Drawing.Point(130, 60);
            this.txtMachCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachCode.MoveControl = null;
            this.txtMachCode.Name = "txtMachCode";
            this.txtMachCode.Size = new System.Drawing.Size(80, 50);
            this.txtMachCode.TabIndex = 50;
            this.txtMachCode.Text = "Z-999";
            this.txtMachCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMachCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtrepaircodeNm
            // 
            this.txtrepaircodeNm.BackColor = System.Drawing.Color.White;
            this.txtrepaircodeNm.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtrepaircodeNm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtrepaircodeNm.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtrepaircodeNm.ColorContent = System.Drawing.Color.White;
            this.txtrepaircodeNm.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtrepaircodeNm.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtrepaircodeNm.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtrepaircodeNm.Location = new System.Drawing.Point(715, 168);
            this.txtrepaircodeNm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtrepaircodeNm.MoveControl = null;
            this.txtrepaircodeNm.Name = "txtrepaircodeNm";
            this.txtrepaircodeNm.Size = new System.Drawing.Size(295, 50);
            this.txtrepaircodeNm.TabIndex = 96;
            this.txtrepaircodeNm.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtrepaircodeNm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtrepaircodeNm._Click += new System.EventHandler(this.txtrepaircode_Click);
            // 
            // txtrepaircode
            // 
            this.txtrepaircode.BackColor = System.Drawing.Color.White;
            this.txtrepaircode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtrepaircode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtrepaircode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtrepaircode.ColorContent = System.Drawing.Color.White;
            this.txtrepaircode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtrepaircode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtrepaircode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtrepaircode.Location = new System.Drawing.Point(629, 168);
            this.txtrepaircode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtrepaircode.MoveControl = null;
            this.txtrepaircode.Name = "txtrepaircode";
            this.txtrepaircode.Size = new System.Drawing.Size(85, 50);
            this.txtrepaircode.TabIndex = 95;
            this.txtrepaircode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtrepaircode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtrepaircode._Click += new System.EventHandler(this.txtrepaircode_Click);
            // 
            // Labelrepaircode
            // 
            this.Labelrepaircode.BackColor = System.Drawing.Color.LightGreen;
            this.Labelrepaircode.BackColor1 = System.Drawing.Color.LightGreen;
            this.Labelrepaircode.BackColor2 = System.Drawing.Color.White;
            this.Labelrepaircode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.Labelrepaircode.ColorContent = System.Drawing.Color.Moccasin;
            this.Labelrepaircode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.Labelrepaircode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Labelrepaircode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.Labelrepaircode.Location = new System.Drawing.Point(507, 168);
            this.Labelrepaircode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelrepaircode.MoveControl = null;
            this.Labelrepaircode.Name = "Labelrepaircode";
            this.Labelrepaircode.Size = new System.Drawing.Size(120, 50);
            this.Labelrepaircode.TabIndex = 94;
            this.Labelrepaircode.Text = "수리내역";
            this.Labelrepaircode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelrepaircode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txterrorressonNm
            // 
            this.txterrorressonNm.BackColor = System.Drawing.Color.White;
            this.txterrorressonNm.BackColor1 = System.Drawing.Color.Moccasin;
            this.txterrorressonNm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txterrorressonNm.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txterrorressonNm.ColorContent = System.Drawing.Color.White;
            this.txterrorressonNm.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txterrorressonNm.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txterrorressonNm.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txterrorressonNm.Location = new System.Drawing.Point(211, 168);
            this.txterrorressonNm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txterrorressonNm.MoveControl = null;
            this.txterrorressonNm.Name = "txterrorressonNm";
            this.txterrorressonNm.Size = new System.Drawing.Size(295, 50);
            this.txterrorressonNm.TabIndex = 93;
            this.txterrorressonNm.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txterrorressonNm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txterrorressonNm._Click += new System.EventHandler(this.txterrorresson_Click);
            // 
            // txterrorresson
            // 
            this.txterrorresson.BackColor = System.Drawing.Color.White;
            this.txterrorresson.BackColor1 = System.Drawing.Color.Moccasin;
            this.txterrorresson.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txterrorresson.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txterrorresson.ColorContent = System.Drawing.Color.White;
            this.txterrorresson.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txterrorresson.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txterrorresson.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txterrorresson.Location = new System.Drawing.Point(130, 168);
            this.txterrorresson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txterrorresson.MoveControl = null;
            this.txterrorresson.Name = "txterrorresson";
            this.txterrorresson.Size = new System.Drawing.Size(80, 50);
            this.txterrorresson.TabIndex = 92;
            this.txterrorresson.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txterrorresson.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txterrorresson._Click += new System.EventHandler(this.txterrorresson_Click);
            // 
            // Labelerrorresson
            // 
            this.Labelerrorresson.BackColor = System.Drawing.Color.LightGreen;
            this.Labelerrorresson.BackColor1 = System.Drawing.Color.LightGreen;
            this.Labelerrorresson.BackColor2 = System.Drawing.Color.White;
            this.Labelerrorresson.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.Labelerrorresson.ColorContent = System.Drawing.Color.Moccasin;
            this.Labelerrorresson.ColorReadOnly = System.Drawing.Color.Transparent;
            this.Labelerrorresson.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Labelerrorresson.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.Labelerrorresson.Location = new System.Drawing.Point(6, 168);
            this.Labelerrorresson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelerrorresson.MoveControl = null;
            this.Labelerrorresson.Name = "Labelerrorresson";
            this.Labelerrorresson.Size = new System.Drawing.Size(120, 50);
            this.Labelerrorresson.TabIndex = 91;
            this.Labelerrorresson.Text = "고장원인";
            this.Labelerrorresson.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelerrorresson.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txterrortypeNm
            // 
            this.txterrortypeNm.BackColor = System.Drawing.Color.White;
            this.txterrortypeNm.BackColor1 = System.Drawing.Color.Moccasin;
            this.txterrortypeNm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txterrortypeNm.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txterrortypeNm.ColorContent = System.Drawing.Color.White;
            this.txterrortypeNm.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txterrortypeNm.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txterrortypeNm.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txterrortypeNm.Location = new System.Drawing.Point(715, 114);
            this.txterrortypeNm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txterrortypeNm.MoveControl = null;
            this.txterrortypeNm.Name = "txterrortypeNm";
            this.txterrortypeNm.Size = new System.Drawing.Size(295, 50);
            this.txterrortypeNm.TabIndex = 90;
            this.txterrortypeNm.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txterrortypeNm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txterrortypeNm._Click += new System.EventHandler(this.txterrortype_Click);
            // 
            // txterrortype
            // 
            this.txterrortype.BackColor = System.Drawing.Color.White;
            this.txterrortype.BackColor1 = System.Drawing.Color.Moccasin;
            this.txterrortype.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txterrortype.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txterrortype.ColorContent = System.Drawing.Color.White;
            this.txterrortype.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txterrortype.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txterrortype.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txterrortype.Location = new System.Drawing.Point(629, 114);
            this.txterrortype.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txterrortype.MoveControl = null;
            this.txterrortype.Name = "txterrortype";
            this.txterrortype.Size = new System.Drawing.Size(85, 50);
            this.txterrortype.TabIndex = 89;
            this.txterrortype.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txterrortype.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txterrortype._Click += new System.EventHandler(this.txterrortype_Click);
            // 
            // txtmacherrorNm
            // 
            this.txtmacherrorNm.BackColor = System.Drawing.Color.White;
            this.txtmacherrorNm.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtmacherrorNm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtmacherrorNm.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtmacherrorNm.ColorContent = System.Drawing.Color.White;
            this.txtmacherrorNm.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtmacherrorNm.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtmacherrorNm.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtmacherrorNm.Location = new System.Drawing.Point(211, 114);
            this.txtmacherrorNm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmacherrorNm.MoveControl = null;
            this.txtmacherrorNm.Name = "txtmacherrorNm";
            this.txtmacherrorNm.Size = new System.Drawing.Size(294, 50);
            this.txtmacherrorNm.TabIndex = 88;
            this.txtmacherrorNm.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtmacherrorNm.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtmacherrorNm._Click += new System.EventHandler(this.txtmacherror_Click);
            // 
            // txtmacherror
            // 
            this.txtmacherror.BackColor = System.Drawing.Color.White;
            this.txtmacherror.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtmacherror.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtmacherror.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtmacherror.ColorContent = System.Drawing.Color.White;
            this.txtmacherror.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtmacherror.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtmacherror.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtmacherror.Location = new System.Drawing.Point(130, 114);
            this.txtmacherror.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmacherror.MoveControl = null;
            this.txtmacherror.Name = "txtmacherror";
            this.txtmacherror.Size = new System.Drawing.Size(80, 50);
            this.txtmacherror.TabIndex = 87;
            this.txtmacherror.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtmacherror.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtmacherror._Click += new System.EventHandler(this.txtmacherror_Click);
            // 
            // Labelerrortype
            // 
            this.Labelerrortype.BackColor = System.Drawing.Color.LightGreen;
            this.Labelerrortype.BackColor1 = System.Drawing.Color.LightGreen;
            this.Labelerrortype.BackColor2 = System.Drawing.Color.White;
            this.Labelerrortype.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.Labelerrortype.ColorContent = System.Drawing.Color.Moccasin;
            this.Labelerrortype.ColorReadOnly = System.Drawing.Color.Transparent;
            this.Labelerrortype.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Labelerrortype.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.Labelerrortype.Location = new System.Drawing.Point(507, 114);
            this.Labelerrortype.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelerrortype.MoveControl = null;
            this.Labelerrortype.Name = "Labelerrortype";
            this.Labelerrortype.Size = new System.Drawing.Size(120, 50);
            this.Labelerrortype.TabIndex = 86;
            this.Labelerrortype.Text = "고장유형";
            this.Labelerrortype.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelerrortype.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // Labelmacherror
            // 
            this.Labelmacherror.BackColor = System.Drawing.Color.LightGreen;
            this.Labelmacherror.BackColor1 = System.Drawing.Color.LightGreen;
            this.Labelmacherror.BackColor2 = System.Drawing.Color.White;
            this.Labelmacherror.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.Labelmacherror.ColorContent = System.Drawing.Color.Moccasin;
            this.Labelmacherror.ColorReadOnly = System.Drawing.Color.Transparent;
            this.Labelmacherror.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Labelmacherror.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.Labelmacherror.Location = new System.Drawing.Point(6, 114);
            this.Labelmacherror.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelmacherror.MoveControl = null;
            this.Labelmacherror.Name = "Labelmacherror";
            this.Labelmacherror.Size = new System.Drawing.Size(120, 50);
            this.Labelmacherror.TabIndex = 85;
            this.Labelmacherror.Text = "설비고장";
            this.Labelmacherror.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelmacherror.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtworker
            // 
            this.txtworker.BackColor = System.Drawing.Color.White;
            this.txtworker.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtworker.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtworker.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtworker.ColorContent = System.Drawing.Color.White;
            this.txtworker.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtworker.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtworker.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtworker.Location = new System.Drawing.Point(812, 221);
            this.txtworker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtworker.MoveControl = null;
            this.txtworker.Name = "txtworker";
            this.txtworker.Size = new System.Drawing.Size(198, 50);
            this.txtworker.TabIndex = 84;
            this.txtworker.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtworker.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtworker._Click += new System.EventHandler(this.txtworker_Click);
            // 
            // Labelworker
            // 
            this.Labelworker.BackColor = System.Drawing.Color.LightGreen;
            this.Labelworker.BackColor1 = System.Drawing.Color.LightGreen;
            this.Labelworker.BackColor2 = System.Drawing.Color.White;
            this.Labelworker.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.Labelworker.ColorContent = System.Drawing.Color.Moccasin;
            this.Labelworker.ColorReadOnly = System.Drawing.Color.Transparent;
            this.Labelworker.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Labelworker.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.Labelworker.Location = new System.Drawing.Point(715, 221);
            this.Labelworker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelworker.MoveControl = null;
            this.Labelworker.Name = "Labelworker";
            this.Labelworker.Size = new System.Drawing.Size(96, 50);
            this.Labelworker.TabIndex = 83;
            this.Labelworker.Text = "보전원";
            this.Labelworker.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelworker.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(45, 367);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(382, 196);
            this.mesGrid1.TabIndex = 97;
            this.mesGrid1.Visible = false;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(6, 275);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(1004, 50);
            this.mesLabel3.TabIndex = 98;
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtworkerid
            // 
            this.txtworkerid.BackColor = System.Drawing.Color.White;
            this.txtworkerid.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtworkerid.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtworkerid.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtworkerid.ColorContent = System.Drawing.Color.White;
            this.txtworkerid.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtworkerid.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtworkerid.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtworkerid.Location = new System.Drawing.Point(896, 221);
            this.txtworkerid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtworkerid.MoveControl = null;
            this.txtworkerid.Name = "txtworkerid";
            this.txtworkerid.Size = new System.Drawing.Size(114, 50);
            this.txtworkerid.TabIndex = 99;
            this.txtworkerid.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtworkerid.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtworkerid.Visible = false;
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
            this.mesLabel5.Location = new System.Drawing.Point(6, 221);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 100;
            this.mesLabel5.Text = "특이사항";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMAdesc
            // 
            this.txtMAdesc.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMAdesc.Location = new System.Drawing.Point(130, 224);
            this.txtMAdesc.Name = "txtMAdesc";
            this.txtMAdesc.Size = new System.Drawing.Size(583, 44);
            this.txtMAdesc.TabIndex = 101;
            // 
            // btnListBox
            // 
            this.btnListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox.CountX = 1;
            this.btnListBox.CountY = 1;
            this.btnListBox.CurrentPage = 0;
            this.btnListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListBox.ExTag = "";
            this.btnListBox.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox.Location = new System.Drawing.Point(1, 329);
            this.btnListBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.SelectCommand = null;
            this.btnListBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox.SelectProcedureName = null;
            this.btnListBox.Size = new System.Drawing.Size(1012, 273);
            this.btnListBox.TabIndex = 102;
            this.btnListBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnListBox_buttonClickEvent);
            this.btnListBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnListBox_buttonClickEvent);
            // 
            // DA1010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA1010";
            this.Text = "설비 고장";
            this.Load += new System.EventHandler(this.DA1010_Load);
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
        private Components.MESLabel txtMachName;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel txtMachCode;
        private Components.MESLabel txtrepaircodeNm;
        private Components.MESLabel txtrepaircode;
        private Components.MESLabel Labelrepaircode;
        private Components.MESLabel txterrorressonNm;
        private Components.MESLabel txterrorresson;
        private Components.MESLabel Labelerrorresson;
        private Components.MESLabel txterrortypeNm;
        private Components.MESLabel txterrortype;
        private Components.MESLabel txtmacherrorNm;
        private Components.MESLabel txtmacherror;
        private Components.MESLabel Labelerrortype;
        private Components.MESLabel Labelmacherror;
        private Components.MESLabel txtworker;
        private Components.MESLabel Labelworker;
        private Components.MESLabel mesLabel3;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtworkerid;
        private Components.MESLabel mesLabel5;
        private System.Windows.Forms.TextBox txtMAdesc;
        private Components.ButtonBox btnListBox;

    }
}
