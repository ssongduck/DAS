using SmartDas.Components;

namespace SmartDas
{
    partial class DA0050
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
            this.btnInspReg = new SmartDas.Components.MESButton();
            this.btnAutonomyInsp = new SmartDas.Components.MESButton();
            this.txtCarryInQty = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txtPlanQty = new SmartDas.Components.MESLabel();
            this.mesLabel18 = new SmartDas.Components.MESLabel();
            this.txtLastLineDate = new SmartDas.Components.MESLabel();
            this.txtLineStatus = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.txtPCName = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.txtOrderCnt = new SmartDas.Components.MESLabel();
            this.txtOrderNo = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtWorkerNames = new SmartDas.Components.MESLabel();
            this.txtWorkerCnt = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.buttonBox1 = new SmartDas.Components.ButtonBox();
            this.btnStatus = new SmartDas.Components.ButtonBox();
            this.bBox1 = new SmartDas.Components.ButtonBox();
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
            this.lblNetwork.BackColor = System.Drawing.Color.White;
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "현장 단말 메인";
            // 
            // lblMes
            // 
            this.lblMes.BackColor = System.Drawing.Color.White;
            this.lblMes._Click += new System.EventHandler(this.lblMes_Click);
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.Grid1;
            this.btnRightPage.LinkMoveSize = 5;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.Grid1;
            this.btnLeftPage.LinkMoveSize = 5;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnInspReg);
            this.splitContainer1.Panel1.Controls.Add(this.btnAutonomyInsp);
            this.splitContainer1.Panel1.Controls.Add(this.txtCarryInQty);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlanQty);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel18);
            this.splitContainer1.Panel1.Controls.Add(this.txtLastLineDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtLineStatus);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel7);
            this.splitContainer1.Panel1.Controls.Add(this.txtPCName);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel6);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemName);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderCnt);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderNo);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel8);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterName);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerNames);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerCnt);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterCode);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.Grid1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnStatus);
            this.splitContainer1.Panel2.Controls.Add(this.bBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 602);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnInspReg
            // 
            this.btnInspReg.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnInspReg.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInspReg.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInspReg.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnInspReg.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnInspReg.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnInspReg.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnInspReg.ButtonPressed = false;
            this.btnInspReg.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnInspReg.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnInspReg.ExTag = null;
            this.btnInspReg.Font = new System.Drawing.Font("휴먼모음T", 20.25F);
            this.btnInspReg.FontSize = 20.25F;
            this.btnInspReg.LinkButtonBox = null;
            this.btnInspReg.LinkGrid = null;
            this.btnInspReg.LinkMoveSize = 0;
            this.btnInspReg.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnInspReg.Location = new System.Drawing.Point(914, 6);
            this.btnInspReg.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnInspReg.Name = "btnInspReg";
            this.btnInspReg.ParentBox = null;
            this.btnInspReg.Size = new System.Drawing.Size(90, 104);
            this.btnInspReg.TabIndex = 126;
            this.btnInspReg.Text = "검사 등록";
            this.btnInspReg.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnInspReg.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnInspReg.UseFlag = true;
            this.btnInspReg._Click += new System.EventHandler(this.btnInspReg_Click);
            // 
            // btnAutonomyInsp
            // 
            this.btnAutonomyInsp.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnAutonomyInsp.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutonomyInsp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAutonomyInsp.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnAutonomyInsp.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnAutonomyInsp.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnAutonomyInsp.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnAutonomyInsp.ButtonPressed = false;
            this.btnAutonomyInsp.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnAutonomyInsp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnAutonomyInsp.ExTag = null;
            this.btnAutonomyInsp.Font = new System.Drawing.Font("휴먼모음T", 20.25F);
            this.btnAutonomyInsp.FontSize = 20.25F;
            this.btnAutonomyInsp.LinkButtonBox = null;
            this.btnAutonomyInsp.LinkGrid = null;
            this.btnAutonomyInsp.LinkMoveSize = 0;
            this.btnAutonomyInsp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnAutonomyInsp.Location = new System.Drawing.Point(814, 6);
            this.btnAutonomyInsp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnAutonomyInsp.Name = "btnAutonomyInsp";
            this.btnAutonomyInsp.ParentBox = null;
            this.btnAutonomyInsp.Size = new System.Drawing.Size(95, 104);
            this.btnAutonomyInsp.TabIndex = 125;
            this.btnAutonomyInsp.Text = "비가동 등록";
            this.btnAutonomyInsp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnAutonomyInsp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnAutonomyInsp.UseFlag = true;
            this.btnAutonomyInsp._Click += new System.EventHandler(this.btnAutonomyInsp_Click);
            // 
            // txtCarryInQty
            // 
            this.txtCarryInQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtCarryInQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtCarryInQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCarryInQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtCarryInQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtCarryInQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtCarryInQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCarryInQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtCarryInQty.Location = new System.Drawing.Point(897, 222);
            this.txtCarryInQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCarryInQty.MoveControl = null;
            this.txtCarryInQty.Name = "txtCarryInQty";
            this.txtCarryInQty.Size = new System.Drawing.Size(110, 50);
            this.txtCarryInQty.TabIndex = 118;
            this.txtCarryInQty.Text = "99,999";
            this.txtCarryInQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtCarryInQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel2
            // 
            this.mesLabel2.BackColor = System.Drawing.Color.White;
            this.mesLabel2.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel2.BackColor2 = System.Drawing.Color.White;
            this.mesLabel2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel2.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel2.Location = new System.Drawing.Point(775, 222);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(121, 50);
            this.mesLabel2.TabIndex = 117;
            this.mesLabel2.Text = "이월수량";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtPlanQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPlanQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPlanQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPlanQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPlanQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPlanQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPlanQty.Location = new System.Drawing.Point(897, 168);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanQty.MoveControl = null;
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(110, 50);
            this.txtPlanQty.TabIndex = 116;
            this.txtPlanQty.Text = "99,999";
            this.txtPlanQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtPlanQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel18
            // 
            this.mesLabel18.BackColor = System.Drawing.Color.White;
            this.mesLabel18.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel18.BackColor2 = System.Drawing.Color.White;
            this.mesLabel18.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel18.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel18.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel18.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel18.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel18.Location = new System.Drawing.Point(775, 168);
            this.mesLabel18.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel18.MoveControl = null;
            this.mesLabel18.Name = "mesLabel18";
            this.mesLabel18.Size = new System.Drawing.Size(121, 50);
            this.mesLabel18.TabIndex = 115;
            this.mesLabel18.Text = "지시수량";
            this.mesLabel18.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel18.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLastLineDate
            // 
            this.txtLastLineDate.BackColor = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLastLineDate.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLastLineDate.ColorContent = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLastLineDate.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLastLineDate.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLastLineDate.Location = new System.Drawing.Point(214, 222);
            this.txtLastLineDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastLineDate.MoveControl = null;
            this.txtLastLineDate.Name = "txtLastLineDate";
            this.txtLastLineDate.Size = new System.Drawing.Size(231, 50);
            this.txtLastLineDate.TabIndex = 114;
            this.txtLastLineDate.Text = "1900-01-01 00:00:00";
            this.txtLastLineDate.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLastLineDate.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLineStatus
            // 
            this.txtLineStatus.BackColor = System.Drawing.Color.Moccasin;
            this.txtLineStatus.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLineStatus.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLineStatus.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLineStatus.ColorContent = System.Drawing.Color.Moccasin;
            this.txtLineStatus.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLineStatus.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLineStatus.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLineStatus.Location = new System.Drawing.Point(128, 222);
            this.txtLineStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLineStatus.MoveControl = null;
            this.txtLineStatus.Name = "txtLineStatus";
            this.txtLineStatus.Size = new System.Drawing.Size(85, 50);
            this.txtLineStatus.TabIndex = 113;
            this.txtLineStatus.Text = "비가동";
            this.txtLineStatus.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLineStatus.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.White;
            this.mesLabel7.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(6, 222);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 112;
            this.mesLabel7.Text = "작업장상태";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtPCName
            // 
            this.txtPCName.BackColor = System.Drawing.Color.Moccasin;
            this.txtPCName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPCName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPCName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPCName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPCName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPCName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPCName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPCName.Location = new System.Drawing.Point(588, 6);
            this.txtPCName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPCName.MoveControl = null;
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(225, 50);
            this.txtPCName.TabIndex = 98;
            this.txtPCName.Text = "SmartDAS-9999";
            this.txtPCName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtPCName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.White;
            this.mesLabel6.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(466, 6);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 97;
            this.mesLabel6.Text = "단말기";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemName.Location = new System.Drawing.Point(448, 114);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(559, 50);
            this.txtItemName.TabIndex = 89;
            this.txtItemName.Text = "TEST ITEM NAME 외 1";
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemCode.Location = new System.Drawing.Point(128, 114);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(319, 50);
            this.txtItemCode.TabIndex = 75;
            this.txtItemCode.Text = "12345-78901-34 외 1";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtOrderCnt
            // 
            this.txtOrderCnt.BackColor = System.Drawing.Color.Moccasin;
            this.txtOrderCnt.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtOrderCnt.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtOrderCnt.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtOrderCnt.ColorContent = System.Drawing.Color.Moccasin;
            this.txtOrderCnt.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtOrderCnt.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderCnt.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtOrderCnt.Location = new System.Drawing.Point(128, 168);
            this.txtOrderCnt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrderCnt.MoveControl = null;
            this.txtOrderCnt.Name = "txtOrderCnt";
            this.txtOrderCnt.Size = new System.Drawing.Size(85, 50);
            this.txtOrderCnt.TabIndex = 17;
            this.txtOrderCnt.Text = "1";
            this.txtOrderCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtOrderCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BackColor = System.Drawing.Color.Moccasin;
            this.txtOrderNo.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtOrderNo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtOrderNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtOrderNo.ColorContent = System.Drawing.Color.Moccasin;
            this.txtOrderNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtOrderNo.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtOrderNo.Location = new System.Drawing.Point(214, 168);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrderNo.MoveControl = null;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(559, 50);
            this.txtOrderNo.TabIndex = 16;
            this.txtOrderNo.Text = "1234567890123";
            this.txtOrderNo.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtOrderNo.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtOrderNo._Click += new System.EventHandler(this.txtOrderNo_Click);
            // 
            // mesLabel8
            // 
            this.mesLabel8.BackColor = System.Drawing.Color.White;
            this.mesLabel8.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel8.BackColor2 = System.Drawing.Color.White;
            this.mesLabel8.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel8.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel8.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel8.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel8.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel8.Location = new System.Drawing.Point(6, 168);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(120, 50);
            this.mesLabel8.TabIndex = 15;
            this.mesLabel8.Text = "작업지시";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Size = new System.Drawing.Size(250, 50);
            this.txtWorkCenterName.TabIndex = 9;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.White;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(6, 114);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 8;
            this.mesLabel3.Text = "품목";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkerNames
            // 
            this.txtWorkerNames.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerNames.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerNames.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerNames.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerNames.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerNames.Location = new System.Drawing.Point(214, 60);
            this.txtWorkerNames.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerNames.MoveControl = null;
            this.txtWorkerNames.Name = "txtWorkerNames";
            this.txtWorkerNames.Size = new System.Drawing.Size(599, 50);
            this.txtWorkerNames.TabIndex = 6;
            this.txtWorkerNames.Text = "정해윤, 채승학, 고국현, 여강기, 차승영";
            this.txtWorkerNames.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerNames.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtWorkerNames._Click += new System.EventHandler(this.txtWorkerNames_Click);
            // 
            // txtWorkerCnt
            // 
            this.txtWorkerCnt.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerCnt.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerCnt.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerCnt.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerCnt.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerCnt.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerCnt.Location = new System.Drawing.Point(128, 60);
            this.txtWorkerCnt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCnt.MoveControl = null;
            this.txtWorkerCnt.Name = "txtWorkerCnt";
            this.txtWorkerCnt.Size = new System.Drawing.Size(85, 50);
            this.txtWorkerCnt.TabIndex = 5;
            this.txtWorkerCnt.Text = "5";
            this.txtWorkerCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.White;
            this.mesLabel4.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.txtWorkCenterCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterCode.Location = new System.Drawing.Point(128, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(85, 50);
            this.txtWorkCenterCode.TabIndex = 2;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel1
            // 
            this.mesLabel1.BackColor = System.Drawing.Color.White;
            this.mesLabel1.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel1.BackColor2 = System.Drawing.Color.White;
            this.mesLabel1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel1.ColorContent = System.Drawing.Color.Empty;
            this.mesLabel1.ColorReadOnly = System.Drawing.Color.Empty;
            this.mesLabel1.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grid1.CountRows = 0;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid1.FixedCols = 0;
            this.Grid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.FontSize = 15.75F;
            this.Grid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid1.HeadString = null;
            this.Grid1.Location = new System.Drawing.Point(0, 275);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(1012, 164);
            this.Grid1.TabIndex = 0;
            this.Grid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid1_GridClick);
            // 
            // buttonBox1
            // 
            this.buttonBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.buttonBox1.CountX = 1;
            this.buttonBox1.CountY = 1;
            this.buttonBox1.CurrentPage = 0;
            this.buttonBox1.ExTag = "";
            this.buttonBox1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBox1.Location = new System.Drawing.Point(433, 0);
            this.buttonBox1.MarginIn = new System.Windows.Forms.Padding(3);
            this.buttonBox1.MarginOut = new System.Windows.Forms.Padding(3);
            this.buttonBox1.Name = "buttonBox1";
            this.buttonBox1.SelectCommand = null;
            this.buttonBox1.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.buttonBox1.SelectProcedureName = null;
            this.buttonBox1.Size = new System.Drawing.Size(147, 158);
            this.buttonBox1.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStatus.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnStatus.CountX = 1;
            this.btnStatus.CountY = 1;
            this.btnStatus.CurrentPage = 0;
            this.btnStatus.ExTag = "";
            this.btnStatus.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStatus.Location = new System.Drawing.Point(865, 0);
            this.btnStatus.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnStatus.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.SelectCommand = null;
            this.btnStatus.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnStatus.SelectProcedureName = null;
            this.btnStatus.Size = new System.Drawing.Size(147, 158);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnStatus_buttonClickEvent);
            // 
            // bBox1
            // 
            this.bBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.bBox1.CountX = 6;
            this.bBox1.CountY = 2;
            this.bBox1.CurrentPage = 0;
            this.bBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBox1.ExTag = "";
            this.bBox1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bBox1.Location = new System.Drawing.Point(0, 0);
            this.bBox1.MarginIn = new System.Windows.Forms.Padding(3);
            this.bBox1.MarginOut = new System.Windows.Forms.Padding(3);
            this.bBox1.Name = "bBox1";
            this.bBox1.SelectCommand = null;
            this.bBox1.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.bBox1.SelectProcedureName = null;
            this.bBox1.Size = new System.Drawing.Size(1012, 159);
            this.bBox1.TabIndex = 0;
            this.bBox1.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.bBox1_buttonClickEvent);
            // 
            // DA0050
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0050";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA0050_FormClosed);
            this.Load += new System.EventHandler(this.DA0050_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ButtonBox bBox1;
        private MESLabel txtWorkCenterCode;
        private MESLabel mesLabel1;
        private ButtonBox btnStatus;
        private MESGrid Grid1;
        private MESLabel txtWorkerNames;
        private MESLabel txtWorkerCnt;
        private MESLabel mesLabel4;
        private MESLabel mesLabel3;
        private MESLabel txtWorkCenterName;
        private MESLabel txtOrderNo;
        private MESLabel mesLabel8;
        private MESLabel txtOrderCnt;
        private MESLabel txtItemCode;
        private MESLabel txtItemName;
        private MESLabel txtPCName;
        private MESLabel mesLabel6;
        private MESLabel txtPlanQty;
        private MESLabel mesLabel18;
        private MESLabel txtLastLineDate;
        private MESLabel txtLineStatus;
        private MESLabel mesLabel7;
        private MESLabel txtCarryInQty;
        private MESLabel mesLabel2;
        private ButtonBox buttonBox1;
        private MESButton btnAutonomyInsp;
        private MESButton btnInspReg;
    }
}
