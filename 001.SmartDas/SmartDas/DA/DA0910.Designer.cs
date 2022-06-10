namespace SmartDas
{
    partial class DA0910
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
            this.txtMachName = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.txtMachCode = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.txtMAdesc = new System.Windows.Forms.TextBox();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.txtWorkerName = new SmartDas.Components.MESLabel();
            this.txtWorkerCode = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtMachErrName = new SmartDas.Components.MESLabel();
            this.txtMachErrCode = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.btnSelection = new SmartDas.Components.ButtonBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "설비 고장 내역 선택";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkMoveSize = 3;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkMoveSize = 3;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnSelection);
            this.GroupBody.Controls.Add(this.txtMachErrName);
            this.GroupBody.Controls.Add(this.txtMachErrCode);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.txtWorkerName);
            this.GroupBody.Controls.Add(this.txtWorkerCode);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.txtMAdesc);
            this.GroupBody.Controls.Add(this.mesLabel8);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.txtMachCode);
            this.GroupBody.Controls.Add(this.txtMachName);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
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
            this.txtMachName.Location = new System.Drawing.Point(211, 58);
            this.txtMachName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachName.MoveControl = null;
            this.txtMachName.Name = "txtMachName";
            this.txtMachName.Size = new System.Drawing.Size(480, 50);
            this.txtMachName.TabIndex = 71;
            this.txtMachName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMachName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel2.Location = new System.Drawing.Point(1, 58);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 70;
            this.mesLabel2.Text = "고장 설비";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Size = new System.Drawing.Size(480, 50);
            this.txtWorkCenterName.TabIndex = 63;
            this.txtWorkCenterName.Text = "세타연료펌프 브라킷 아답터";
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
            this.btnConfBox.Location = new System.Drawing.Point(693, 4);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(320, 104);
            this.btnConfBox.TabIndex = 65;
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
            this.mesLabel1.Location = new System.Drawing.Point(1, 4);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 61;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(122, 4);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(88, 50);
            this.txtWorkCenterCode.TabIndex = 62;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtMachCode.Location = new System.Drawing.Point(122, 58);
            this.txtMachCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachCode.MoveControl = null;
            this.txtMachCode.Name = "txtMachCode";
            this.txtMachCode.Size = new System.Drawing.Size(88, 50);
            this.txtMachCode.TabIndex = 76;
            this.txtMachCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMachCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.ForeColor = System.Drawing.Color.Black;
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(1, 112);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(1012, 50);
            this.mesLabel3.TabIndex = 77;
            this.mesLabel3.Text = "긴급요청";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel3._Click += new System.EventHandler(this.mesLabel3_Click);
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.Black;
            this.mesLabel4.BackColor1 = System.Drawing.Color.Black;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel4.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel4.Location = new System.Drawing.Point(4, 220);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(1009, 4);
            this.mesLabel4.TabIndex = 78;
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.ForeColor = System.Drawing.Color.Black;
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(1, 229);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(1012, 50);
            this.mesLabel6.TabIndex = 80;
            this.mesLabel6.Text = "설비점검";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel6._Click += new System.EventHandler(this.mesLabel6_Click);
            // 
            // txtMAdesc
            // 
            this.txtMAdesc.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMAdesc.Location = new System.Drawing.Point(127, 285);
            this.txtMAdesc.Name = "txtMAdesc";
            this.txtMAdesc.Size = new System.Drawing.Size(885, 44);
            this.txtMAdesc.TabIndex = 103;
            this.txtMAdesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMAdesc_MouseClick);
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
            this.mesLabel8.Location = new System.Drawing.Point(1, 283);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(120, 50);
            this.mesLabel8.TabIndex = 102;
            this.mesLabel8.Text = "요청내역";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesGrid1.Location = new System.Drawing.Point(1, 357);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 245);
            this.mesGrid1.TabIndex = 105;
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
            this.txtWorkerName.Location = new System.Drawing.Point(269, 166);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerName.MoveControl = null;
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(742, 50);
            this.txtWorkerName.TabIndex = 114;
            this.txtWorkerName.Text = "이명박";
            this.txtWorkerName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerName._Click += new System.EventHandler(this.txtWorkerCode_Click);
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
            this.txtWorkerCode.Location = new System.Drawing.Point(128, 166);
            this.txtWorkerCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCode.MoveControl = null;
            this.txtWorkerCode.Name = "txtWorkerCode";
            this.txtWorkerCode.Size = new System.Drawing.Size(140, 50);
            this.txtWorkerCode.TabIndex = 113;
            this.txtWorkerCode.Text = "1234567890";
            this.txtWorkerCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerCode._Click += new System.EventHandler(this.txtWorkerCode_Click);
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
            this.mesLabel5.Location = new System.Drawing.Point(1, 166);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 112;
            this.mesLabel5.Text = "작업자";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMachErrName
            // 
            this.txtMachErrName.BackColor = System.Drawing.Color.White;
            this.txtMachErrName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMachErrName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMachErrName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMachErrName.ColorContent = System.Drawing.Color.White;
            this.txtMachErrName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMachErrName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachErrName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMachErrName.Location = new System.Drawing.Point(729, 166);
            this.txtMachErrName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachErrName.MoveControl = null;
            this.txtMachErrName.Name = "txtMachErrName";
            this.txtMachErrName.Size = new System.Drawing.Size(283, 50);
            this.txtMachErrName.TabIndex = 117;
            this.txtMachErrName.Text = "설비고장명";
            this.txtMachErrName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMachErrName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMachErrName.Visible = false;
            this.txtMachErrName._Click += new System.EventHandler(this.txtMachErrCode_Click);
            // 
            // txtMachErrCode
            // 
            this.txtMachErrCode.BackColor = System.Drawing.Color.White;
            this.txtMachErrCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMachErrCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMachErrCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMachErrCode.ColorContent = System.Drawing.Color.White;
            this.txtMachErrCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMachErrCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMachErrCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMachErrCode.Location = new System.Drawing.Point(649, 166);
            this.txtMachErrCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMachErrCode.MoveControl = null;
            this.txtMachErrCode.Name = "txtMachErrCode";
            this.txtMachErrCode.Size = new System.Drawing.Size(80, 50);
            this.txtMachErrCode.TabIndex = 116;
            this.txtMachErrCode.Text = "S-999";
            this.txtMachErrCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMachErrCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMachErrCode.Visible = false;
            this.txtMachErrCode._Click += new System.EventHandler(this.txtMachErrCode_Click);
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(519, 166);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 115;
            this.mesLabel7.Text = "설비고장";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel7.Visible = false;
            // 
            // btnSelection
            // 
            this.btnSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelection.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnSelection.CountX = 1;
            this.btnSelection.CountY = 1;
            this.btnSelection.CurrentPage = 0;
            this.btnSelection.ExTag = "";
            this.btnSelection.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelection.Location = new System.Drawing.Point(1, 336);
            this.btnSelection.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelection.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.SelectCommand = null;
            this.btnSelection.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelection.SelectProcedureName = "USP_DA7100_S5";
            this.btnSelection.Size = new System.Drawing.Size(1012, 261);
            this.btnSelection.TabIndex = 139;
            this.btnSelection.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelection_buttonChangeEvent);
            this.btnSelection.Leave += new System.EventHandler(this.btnSelection_Leave);
            // 
            // DA0910
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0910";
            this.Text = "설비 고장 내역 선택";
            this.Load += new System.EventHandler(this.DA0910_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.GroupBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtMachName;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel txtWorkCenterName;
        private Components.ButtonBox btnConfBox;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel txtMachCode;
        private Components.MESLabel mesLabel6;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel mesLabel3;
        private System.Windows.Forms.TextBox txtMAdesc;
        private Components.MESLabel mesLabel8;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtWorkerName;
        private Components.MESLabel txtWorkerCode;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtMachErrName;
        private Components.MESLabel txtMachErrCode;
        private Components.MESLabel mesLabel7;
        private Components.ButtonBox btnSelection;

    }
}
