using SmartDas.Components;

namespace SmartDas
{
    partial class DA0080
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtPCName = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkerNames = new SmartDas.Components.MESLabel();
            this.txtWorkerCnt = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.buttonBox2 = new SmartDas.Components.ButtonBox();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.txtQty = new SmartDas.Components.MESLabel();
            this.lbCarKind = new SmartDas.Components.MESLabel();
            this.mesLabel17 = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtLotNo = new SmartDas.Components.MESLabel();
            this.lbItemNm = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.bBox1 = new SmartDas.Components.ButtonBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "현장 단말 메인";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            // 
            // lblMes
            // 
            this.lblMes._Click += new System.EventHandler(this.lblMes_Click);
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.Grid1;
            this.btnRightPage.LinkMoveSize = 1;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.Grid1;
            this.btnLeftPage.LinkMoveSize = 1;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtPCName);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel6);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterName);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerNames);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerCnt);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterCode);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.Grid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonBox2);
            this.splitContainer1.Panel2.Controls.Add(this.mesLabel7);
            this.splitContainer1.Panel2.Controls.Add(this.txtQty);
            this.splitContainer1.Panel2.Controls.Add(this.lbCarKind);
            this.splitContainer1.Panel2.Controls.Add(this.mesLabel17);
            this.splitContainer1.Panel2.Controls.Add(this.mesLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.txtLotNo);
            this.splitContainer1.Panel2.Controls.Add(this.lbItemNm);
            this.splitContainer1.Panel2.Controls.Add(this.mesLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.bBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 602);
            this.splitContainer1.SplitterDistance = 405;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtPCName
            // 
            this.txtPCName.BackColor = System.Drawing.Color.Moccasin;
            this.txtPCName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPCName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPCName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPCName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPCName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPCName.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPCName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPCName.Location = new System.Drawing.Point(642, 6);
            this.txtPCName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPCName.MoveControl = null;
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(365, 50);
            this.txtPCName.TabIndex = 96;
            this.txtPCName.Text = "SmartDAS-9999";
            this.txtPCName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtPCName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(518, 6);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 95;
            this.mesLabel6.Text = "단말기";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkCenterName
            // 
            this.txtWorkCenterName.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkCenterName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkCenterName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkCenterName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkCenterName.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterName.Location = new System.Drawing.Point(215, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(299, 50);
            this.txtWorkCenterName.TabIndex = 9;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkerNames
            // 
            this.txtWorkerNames.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerNames.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerNames.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerNames.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerNames.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerNames.Location = new System.Drawing.Point(215, 60);
            this.txtWorkerNames.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerNames.MoveControl = null;
            this.txtWorkerNames.Name = "txtWorkerNames";
            this.txtWorkerNames.Size = new System.Drawing.Size(792, 50);
            this.txtWorkerNames.TabIndex = 6;
            this.txtWorkerNames.Text = "정해윤, 채승학, 고국현, 여강기, 차승영";
            this.txtWorkerNames.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerNames.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkerCnt
            // 
            this.txtWorkerCnt.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerCnt.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerCnt.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerCnt.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerCnt.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerCnt.Location = new System.Drawing.Point(130, 60);
            this.txtWorkerCnt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCnt.MoveControl = null;
            this.txtWorkerCnt.Name = "txtWorkerCnt";
            this.txtWorkerCnt.Size = new System.Drawing.Size(80, 50);
            this.txtWorkerCnt.TabIndex = 5;
            this.txtWorkerCnt.Text = "5";
            this.txtWorkerCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel4.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel4.Location = new System.Drawing.Point(6, 60);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 4;
            this.mesLabel4.Text = "작업자";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkCenterCode
            // 
            this.txtWorkCenterCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkCenterCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkCenterCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkCenterCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkCenterCode.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterCode.Location = new System.Drawing.Point(130, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(80, 50);
            this.txtWorkCenterCode.TabIndex = 2;
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
            this.mesLabel1.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel1.Location = new System.Drawing.Point(6, 6);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 1;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // Grid1
            // 
            this.Grid1.AutoScroll = true;
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grid1.CountRows = 0;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid1.FixedCols = 0;
            this.Grid1.FontSize = 15.75F;
            this.Grid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid1.HeadString = null;
            this.Grid1.Location = new System.Drawing.Point(0, 111);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(1012, 294);
            this.Grid1.TabIndex = 0;
            this.Grid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid1_GridClick);
            // 
            // buttonBox2
            // 
            this.buttonBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonBox2.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.buttonBox2.CountX = 6;
            this.buttonBox2.CountY = 2;
            this.buttonBox2.CurrentPage = 0;
            this.buttonBox2.ExTag = "";
            this.buttonBox2.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBox2.Location = new System.Drawing.Point(756, 0);
            this.buttonBox2.MarginIn = new System.Windows.Forms.Padding(3);
            this.buttonBox2.MarginOut = new System.Windows.Forms.Padding(3);
            this.buttonBox2.Name = "buttonBox2";
            this.buttonBox2.SelectCommand = null;
            this.buttonBox2.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.buttonBox2.SelectProcedureName = null;
            this.buttonBox2.Size = new System.Drawing.Size(256, 113);
            this.buttonBox2.TabIndex = 106;
            this.buttonBox2.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.bBox1_buttonClickEvent);
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
            this.mesLabel7.Location = new System.Drawing.Point(336, 60);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 105;
            this.mesLabel7.Text = "차  종";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtQty.ColorContent = System.Drawing.Color.White;
            this.txtQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtQty.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtQty.Location = new System.Drawing.Point(117, 60);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtQty.MoveControl = null;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(217, 50);
            this.txtQty.TabIndex = 104;
            this.txtQty.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtQty._Click += new System.EventHandler(this.txtQty_Click);
            // 
            // lbCarKind
            // 
            this.lbCarKind.BackColor = System.Drawing.Color.Moccasin;
            this.lbCarKind.BackColor1 = System.Drawing.Color.Moccasin;
            this.lbCarKind.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbCarKind.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lbCarKind.ColorContent = System.Drawing.Color.Moccasin;
            this.lbCarKind.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lbCarKind.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCarKind.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.lbCarKind.Location = new System.Drawing.Point(458, 61);
            this.lbCarKind.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbCarKind.MoveControl = null;
            this.lbCarKind.Name = "lbCarKind";
            this.lbCarKind.Size = new System.Drawing.Size(297, 50);
            this.lbCarKind.TabIndex = 103;
            this.lbCarKind.TextHAlign = Infragistics.Win.HAlign.Left;
            this.lbCarKind.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel17
            // 
            this.mesLabel17.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel17.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel17.BackColor2 = System.Drawing.Color.White;
            this.mesLabel17.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel17.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel17.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel17.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel17.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel17.Location = new System.Drawing.Point(5, 60);
            this.mesLabel17.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel17.MoveControl = null;
            this.mesLabel17.Name = "mesLabel17";
            this.mesLabel17.Size = new System.Drawing.Size(109, 50);
            this.mesLabel17.TabIndex = 102;
            this.mesLabel17.Text = "수  량";
            this.mesLabel17.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel17.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel5.BackColor2 = System.Drawing.Color.White;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel5.Location = new System.Drawing.Point(336, 5);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 101;
            this.mesLabel5.Text = "품  명";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLotNo
            // 
            this.txtLotNo.BackColor = System.Drawing.Color.White;
            this.txtLotNo.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLotNo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLotNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLotNo.ColorContent = System.Drawing.Color.White;
            this.txtLotNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLotNo.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLotNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLotNo.Location = new System.Drawing.Point(117, 5);
            this.txtLotNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLotNo.MoveControl = null;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(217, 51);
            this.txtLotNo.TabIndex = 100;
            this.txtLotNo.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLotNo.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtLotNo._Click += new System.EventHandler(this.txtLotNo_Click);
            // 
            // lbItemNm
            // 
            this.lbItemNm.BackColor = System.Drawing.Color.Moccasin;
            this.lbItemNm.BackColor1 = System.Drawing.Color.Moccasin;
            this.lbItemNm.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbItemNm.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lbItemNm.ColorContent = System.Drawing.Color.Moccasin;
            this.lbItemNm.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lbItemNm.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbItemNm.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.lbItemNm.Location = new System.Drawing.Point(458, 6);
            this.lbItemNm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbItemNm.MoveControl = null;
            this.lbItemNm.Name = "lbItemNm";
            this.lbItemNm.Size = new System.Drawing.Size(297, 50);
            this.lbItemNm.TabIndex = 11;
            this.lbItemNm.TextHAlign = Infragistics.Win.HAlign.Left;
            this.lbItemNm.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(5, 5);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(109, 50);
            this.mesLabel3.TabIndex = 10;
            this.mesLabel3.Text = "Lot No";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // bBox1
            // 
            this.bBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.bBox1.CountX = 6;
            this.bBox1.CountY = 2;
            this.bBox1.CurrentPage = 0;
            this.bBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBox1.ExTag = "";
            this.bBox1.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bBox1.Location = new System.Drawing.Point(0, 114);
            this.bBox1.MarginIn = new System.Windows.Forms.Padding(3);
            this.bBox1.MarginOut = new System.Windows.Forms.Padding(3);
            this.bBox1.Name = "bBox1";
            this.bBox1.SelectCommand = null;
            this.bBox1.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.bBox1.SelectProcedureName = null;
            this.bBox1.Size = new System.Drawing.Size(1012, 79);
            this.bBox1.TabIndex = 0;
            this.bBox1.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.bBox1_buttonClickEvent);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 107;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // DA0080
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0080";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.Activated += new System.EventHandler(this.DA0080_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA0080_FormClosed);
            this.Load += new System.EventHandler(this.DA0080_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ButtonBox bBox1;
        private MESLabel txtWorkCenterCode;
        private MESLabel mesLabel1;
        private MESGrid Grid1;
        private MESLabel txtWorkerNames;
        private MESLabel txtWorkerCnt;
        private MESLabel mesLabel4;
        private MESLabel txtWorkCenterName;
        private MESLabel txtPCName;
        private MESLabel mesLabel6;
        private MESLabel lbItemNm;
        private MESLabel mesLabel3;
        private MESLabel txtLotNo;
        private ButtonBox buttonBox2;
        private MESLabel mesLabel7;
        private MESLabel txtQty;
        private MESLabel lbCarKind;
        private MESLabel mesLabel17;
        private MESLabel mesLabel5;
        private System.Windows.Forms.TextBox textBox1;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
        //private Infragistics.Win.Misc.UltraLabel lblDate;
        //private Infragistics.Win.Misc.UltraLabel lblTime;
        //private Infragistics.Win.Misc.UltraGroupBox GroupBody;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
        //private Infragistics.Win.Misc.UltraLabel lblDate;
        //private Infragistics.Win.Misc.UltraLabel lblTime;
        //private Infragistics.Win.Misc.UltraGroupBox GroupBody;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
    }
}
