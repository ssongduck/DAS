using SmartDas.Components;

namespace SmartDas
{
    partial class DA0060
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
            this.btnWorkReport = new SmartDas.Components.MESButton();
            this.btnAutonomyInsp = new SmartDas.Components.MESButton();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.lblDayOrder = new SmartDas.Components.MESLabel();
            this.mesLabel17 = new SmartDas.Components.MESLabel();
            this.lblCavity = new SmartDas.Components.MESLabel();
            this.txtCarryInQty = new SmartDas.Components.MESLabel();
            this.lblOverQty = new SmartDas.Components.MESLabel();
            this.txtPlanMoldName = new SmartDas.Components.MESLabel();
            this.txtPlanQty = new SmartDas.Components.MESLabel();
            this.lblOrderQty = new SmartDas.Components.MESLabel();
            this.txtLastLineDate = new SmartDas.Components.MESLabel();
            this.txtLineStatus = new SmartDas.Components.MESLabel();
            this.lblWorkShopStatus = new SmartDas.Components.MESLabel();
            this.txtPCName = new SmartDas.Components.MESLabel();
            this.lblTerminal = new SmartDas.Components.MESLabel();
            this.txtMoldName = new SmartDas.Components.MESLabel();
            this.txtMoldCode = new SmartDas.Components.MESLabel();
            this.txtPlanMoldCode = new SmartDas.Components.MESLabel();
            this.lblOrderDie = new SmartDas.Components.MESLabel();
            this.lblLoadDie = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.txtOrderNo = new SmartDas.Components.MESLabel();
            this.lblOrderNo = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.lblItem = new SmartDas.Components.MESLabel();
            this.txtWorkerNames = new SmartDas.Components.MESLabel();
            this.txtWorkerCnt = new SmartDas.Components.MESLabel();
            this.lblWorker = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.lblWorkShop = new SmartDas.Components.MESLabel();
            this.mesLabel16 = new SmartDas.Components.MESLabel();
            this.mesLabel15 = new SmartDas.Components.MESLabel();
            this.mesLabel12 = new SmartDas.Components.MESLabel();
            this.mesLabel11 = new SmartDas.Components.MESLabel();
            this.mesLabel14 = new SmartDas.Components.MESLabel();
            this.mesLabel13 = new SmartDas.Components.MESLabel();
            this.mesLabel9 = new SmartDas.Components.MESLabel();
            this.Grid2 = new SmartDas.Components.MESGrid();
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
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "현장 단말 메인";
            // 
            // lblMes
            // 
            this.lblMes._Click += new System.EventHandler(this.lblMes_Click);
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.Grid1;
            this.btnRightPage.LinkMoveSize = 2;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.Grid1;
            this.btnLeftPage.LinkMoveSize = 2;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnWorkReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnAutonomyInsp);
            this.splitContainer1.Panel1.Controls.Add(this.Grid1);
            this.splitContainer1.Panel1.Controls.Add(this.lblDayOrder);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel17);
            this.splitContainer1.Panel1.Controls.Add(this.lblCavity);
            this.splitContainer1.Panel1.Controls.Add(this.txtCarryInQty);
            this.splitContainer1.Panel1.Controls.Add(this.lblOverQty);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlanMoldName);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlanQty);
            this.splitContainer1.Panel1.Controls.Add(this.lblOrderQty);
            this.splitContainer1.Panel1.Controls.Add(this.txtLastLineDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtLineStatus);
            this.splitContainer1.Panel1.Controls.Add(this.lblWorkShopStatus);
            this.splitContainer1.Panel1.Controls.Add(this.txtPCName);
            this.splitContainer1.Panel1.Controls.Add(this.lblTerminal);
            this.splitContainer1.Panel1.Controls.Add(this.txtMoldName);
            this.splitContainer1.Panel1.Controls.Add(this.txtMoldCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlanMoldCode);
            this.splitContainer1.Panel1.Controls.Add(this.lblOrderDie);
            this.splitContainer1.Panel1.Controls.Add(this.lblLoadDie);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemName);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblOrderNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterName);
            this.splitContainer1.Panel1.Controls.Add(this.lblItem);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerNames);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerCnt);
            this.splitContainer1.Panel1.Controls.Add(this.lblWorker);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterCode);
            this.splitContainer1.Panel1.Controls.Add(this.lblWorkShop);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel16);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel15);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel12);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel11);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel14);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel13);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel9);
            this.splitContainer1.Panel1.Controls.Add(this.Grid2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnStatus);
            this.splitContainer1.Panel2.Controls.Add(this.bBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 602);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnWorkReport
            // 
            this.btnWorkReport.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnWorkReport.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWorkReport.BackColor = System.Drawing.Color.SkyBlue;
            this.btnWorkReport.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnWorkReport.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnWorkReport.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnWorkReport.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnWorkReport.ButtonPressed = false;
            this.btnWorkReport.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnWorkReport.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnWorkReport.ExTag = null;
            this.btnWorkReport.Font = new System.Drawing.Font("휴먼모음T", 18F);
            this.btnWorkReport.FontSize = 18F;
            this.btnWorkReport.LinkButtonBox = null;
            this.btnWorkReport.LinkGrid = null;
            this.btnWorkReport.LinkMoveSize = 0;
            this.btnWorkReport.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnWorkReport.Location = new System.Drawing.Point(915, 5);
            this.btnWorkReport.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnWorkReport.Name = "btnWorkReport";
            this.btnWorkReport.ParentBox = null;
            this.btnWorkReport.Size = new System.Drawing.Size(94, 104);
            this.btnWorkReport.TabIndex = 126;
            this.btnWorkReport.Text = "특이사항 등록";
            this.btnWorkReport.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnWorkReport.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnWorkReport.UseFlag = true;
            this.btnWorkReport._Click += new System.EventHandler(this.btnWorkReport_Click);
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
            this.btnAutonomyInsp.Font = new System.Drawing.Font("휴먼모음T", 18F);
            this.btnAutonomyInsp.FontSize = 18F;
            this.btnAutonomyInsp.LinkButtonBox = null;
            this.btnAutonomyInsp.LinkGrid = null;
            this.btnAutonomyInsp.LinkMoveSize = 0;
            this.btnAutonomyInsp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnAutonomyInsp.Location = new System.Drawing.Point(815, 5);
            this.btnAutonomyInsp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnAutonomyInsp.Name = "btnAutonomyInsp";
            this.btnAutonomyInsp.ParentBox = null;
            this.btnAutonomyInsp.Size = new System.Drawing.Size(94, 104);
            this.btnAutonomyInsp.TabIndex = 125;
            this.btnAutonomyInsp.Text = "언어  선택";
            this.btnAutonomyInsp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnAutonomyInsp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnAutonomyInsp.UseFlag = true;
            this.btnAutonomyInsp._Click += new System.EventHandler(this.btnAutonomyInsp_Click);
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
            this.Grid1.Location = new System.Drawing.Point(0, 114);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(1012, 161);
            this.Grid1.TabIndex = 0;
            this.Grid1.Visible = false;
            this.Grid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid1_GridClick);
            // 
            // lblDayOrder
            // 
            this.lblDayOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblDayOrder.BackColor1 = System.Drawing.Color.LightSeaGreen;
            this.lblDayOrder.BackColor2 = System.Drawing.Color.White;
            this.lblDayOrder.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblDayOrder.ColorContent = System.Drawing.Color.Moccasin;
            this.lblDayOrder.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblDayOrder.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDayOrder.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblDayOrder.Location = new System.Drawing.Point(460, 222);
            this.lblDayOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblDayOrder.MoveControl = null;
            this.lblDayOrder.Name = "lblDayOrder";
            this.lblDayOrder.Size = new System.Drawing.Size(100, 50);
            this.lblDayOrder.TabIndex = 123;
            this.lblDayOrder.Text = "작지기준";
            this.lblDayOrder.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblDayOrder.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.lblDayOrder._Click += new System.EventHandler(this.lblDayOrder_Click);
            // 
            // mesLabel17
            // 
            this.mesLabel17.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel17.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel17.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel17.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel17.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel17.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel17.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel17.Location = new System.Drawing.Point(671, 222);
            this.mesLabel17.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel17.MoveControl = null;
            this.mesLabel17.Name = "mesLabel17";
            this.mesLabel17.Size = new System.Drawing.Size(100, 50);
            this.mesLabel17.TabIndex = 122;
            this.mesLabel17.Text = "1";
            this.mesLabel17.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel17.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblCavity
            // 
            this.lblCavity.BackColor = System.Drawing.Color.LightGreen;
            this.lblCavity.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblCavity.BackColor2 = System.Drawing.Color.White;
            this.lblCavity.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblCavity.ColorContent = System.Drawing.Color.Moccasin;
            this.lblCavity.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblCavity.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCavity.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblCavity.Location = new System.Drawing.Point(561, 222);
            this.lblCavity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblCavity.MoveControl = null;
            this.lblCavity.Name = "lblCavity";
            this.lblCavity.Size = new System.Drawing.Size(108, 50);
            this.lblCavity.TabIndex = 121;
            this.lblCavity.Text = "Cavity";
            this.lblCavity.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblCavity.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtCarryInQty.Location = new System.Drawing.Point(890, 222);
            this.txtCarryInQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCarryInQty.MoveControl = null;
            this.txtCarryInQty.Name = "txtCarryInQty";
            this.txtCarryInQty.Size = new System.Drawing.Size(118, 50);
            this.txtCarryInQty.TabIndex = 120;
            this.txtCarryInQty.Text = "99,999";
            this.txtCarryInQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtCarryInQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblOverQty
            // 
            this.lblOverQty.BackColor = System.Drawing.Color.LightGreen;
            this.lblOverQty.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblOverQty.BackColor2 = System.Drawing.Color.White;
            this.lblOverQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblOverQty.ColorContent = System.Drawing.Color.Moccasin;
            this.lblOverQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblOverQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOverQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblOverQty.Location = new System.Drawing.Point(773, 222);
            this.lblOverQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblOverQty.MoveControl = null;
            this.lblOverQty.Name = "lblOverQty";
            this.lblOverQty.Size = new System.Drawing.Size(114, 50);
            this.lblOverQty.TabIndex = 119;
            this.lblOverQty.Text = "이월수량";
            this.lblOverQty.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblOverQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtPlanMoldName
            // 
            this.txtPlanMoldName.BackColor = System.Drawing.Color.Moccasin;
            this.txtPlanMoldName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPlanMoldName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPlanMoldName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPlanMoldName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPlanMoldName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPlanMoldName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanMoldName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPlanMoldName.Location = new System.Drawing.Point(460, 168);
            this.txtPlanMoldName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanMoldName.MoveControl = null;
            this.txtPlanMoldName.Name = "txtPlanMoldName";
            this.txtPlanMoldName.Size = new System.Drawing.Size(100, 50);
            this.txtPlanMoldName.TabIndex = 112;
            this.txtPlanMoldName.Text = "SK-99";
            this.txtPlanMoldName.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtPlanMoldName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtPlanQty.Location = new System.Drawing.Point(889, 168);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanQty.MoveControl = null;
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(119, 50);
            this.txtPlanQty.TabIndex = 111;
            this.txtPlanQty.Text = "10,000";
            this.txtPlanQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtPlanQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblOrderQty
            // 
            this.lblOrderQty.BackColor = System.Drawing.Color.LightGreen;
            this.lblOrderQty.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblOrderQty.BackColor2 = System.Drawing.Color.White;
            this.lblOrderQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblOrderQty.ColorContent = System.Drawing.Color.Moccasin;
            this.lblOrderQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblOrderQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblOrderQty.Location = new System.Drawing.Point(773, 168);
            this.lblOrderQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblOrderQty.MoveControl = null;
            this.lblOrderQty.Name = "lblOrderQty";
            this.lblOrderQty.Size = new System.Drawing.Size(114, 50);
            this.lblOrderQty.TabIndex = 110;
            this.lblOrderQty.Text = "지시수량";
            this.lblOrderQty.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblOrderQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLastLineDate
            // 
            this.txtLastLineDate.BackColor = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLastLineDate.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLastLineDate.ColorContent = System.Drawing.Color.Moccasin;
            this.txtLastLineDate.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLastLineDate.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLastLineDate.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLastLineDate.Location = new System.Drawing.Point(206, 222);
            this.txtLastLineDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastLineDate.MoveControl = null;
            this.txtLastLineDate.Name = "txtLastLineDate";
            this.txtLastLineDate.Size = new System.Drawing.Size(252, 50);
            this.txtLastLineDate.TabIndex = 100;
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
            this.txtLineStatus.Location = new System.Drawing.Point(125, 222);
            this.txtLineStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLineStatus.MoveControl = null;
            this.txtLineStatus.Name = "txtLineStatus";
            this.txtLineStatus.Size = new System.Drawing.Size(80, 50);
            this.txtLineStatus.TabIndex = 98;
            this.txtLineStatus.Text = "비가동";
            this.txtLineStatus.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLineStatus.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblWorkShopStatus
            // 
            this.lblWorkShopStatus.BackColor = System.Drawing.Color.LightGreen;
            this.lblWorkShopStatus.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblWorkShopStatus.BackColor2 = System.Drawing.Color.White;
            this.lblWorkShopStatus.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblWorkShopStatus.ColorContent = System.Drawing.Color.Moccasin;
            this.lblWorkShopStatus.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblWorkShopStatus.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkShopStatus.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblWorkShopStatus.Location = new System.Drawing.Point(4, 222);
            this.lblWorkShopStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWorkShopStatus.MoveControl = null;
            this.lblWorkShopStatus.Name = "lblWorkShopStatus";
            this.lblWorkShopStatus.Size = new System.Drawing.Size(120, 50);
            this.lblWorkShopStatus.TabIndex = 97;
            this.lblWorkShopStatus.Text = "작업장상태";
            this.lblWorkShopStatus.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblWorkShopStatus.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtPCName.Location = new System.Drawing.Point(589, 6);
            this.txtPCName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPCName.MoveControl = null;
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(224, 50);
            this.txtPCName.TabIndex = 96;
            this.txtPCName.Text = "SmartDAS-9999";
            this.txtPCName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtPCName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblTerminal
            // 
            this.lblTerminal.BackColor = System.Drawing.Color.LightGreen;
            this.lblTerminal.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblTerminal.BackColor2 = System.Drawing.Color.White;
            this.lblTerminal.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblTerminal.ColorContent = System.Drawing.Color.Moccasin;
            this.lblTerminal.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblTerminal.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTerminal.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblTerminal.Location = new System.Drawing.Point(467, 6);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTerminal.MoveControl = null;
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(120, 50);
            this.lblTerminal.TabIndex = 95;
            this.lblTerminal.Text = "단말기";
            this.lblTerminal.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblTerminal.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMoldName
            // 
            this.txtMoldName.BackColor = System.Drawing.Color.Moccasin;
            this.txtMoldName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtMoldName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldName.Location = new System.Drawing.Point(671, 168);
            this.txtMoldName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldName.MoveControl = null;
            this.txtMoldName.Name = "txtMoldName";
            this.txtMoldName.Size = new System.Drawing.Size(100, 50);
            this.txtMoldName.TabIndex = 94;
            this.txtMoldName.Text = "SK-99";
            this.txtMoldName.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldName._Click += new System.EventHandler(this.txtMoldName_Click);
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
            this.txtMoldCode.Location = new System.Drawing.Point(130, 346);
            this.txtMoldCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldCode.MoveControl = null;
            this.txtMoldCode.Name = "txtMoldCode";
            this.txtMoldCode.Size = new System.Drawing.Size(300, 50);
            this.txtMoldCode.TabIndex = 93;
            this.txtMoldCode.Text = "MOLD0100";
            this.txtMoldCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldCode.Visible = false;
            // 
            // txtPlanMoldCode
            // 
            this.txtPlanMoldCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtPlanMoldCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPlanMoldCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPlanMoldCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPlanMoldCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPlanMoldCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPlanMoldCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanMoldCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPlanMoldCode.Location = new System.Drawing.Point(130, 284);
            this.txtPlanMoldCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanMoldCode.MoveControl = null;
            this.txtPlanMoldCode.Name = "txtPlanMoldCode";
            this.txtPlanMoldCode.Size = new System.Drawing.Size(300, 50);
            this.txtPlanMoldCode.TabIndex = 92;
            this.txtPlanMoldCode.Text = "MOLD0100";
            this.txtPlanMoldCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtPlanMoldCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtPlanMoldCode.Visible = false;
            // 
            // lblOrderDie
            // 
            this.lblOrderDie.BackColor = System.Drawing.Color.LightGreen;
            this.lblOrderDie.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblOrderDie.BackColor2 = System.Drawing.Color.White;
            this.lblOrderDie.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblOrderDie.ColorContent = System.Drawing.Color.Moccasin;
            this.lblOrderDie.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblOrderDie.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderDie.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblOrderDie.Location = new System.Drawing.Point(355, 168);
            this.lblOrderDie.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblOrderDie.MoveControl = null;
            this.lblOrderDie.Name = "lblOrderDie";
            this.lblOrderDie.Size = new System.Drawing.Size(103, 50);
            this.lblOrderDie.TabIndex = 91;
            this.lblOrderDie.Text = "지시금형";
            this.lblOrderDie.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblOrderDie.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblLoadDie
            // 
            this.lblLoadDie.BackColor = System.Drawing.Color.LightGreen;
            this.lblLoadDie.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblLoadDie.BackColor2 = System.Drawing.Color.White;
            this.lblLoadDie.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblLoadDie.ColorContent = System.Drawing.Color.Moccasin;
            this.lblLoadDie.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblLoadDie.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLoadDie.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblLoadDie.Location = new System.Drawing.Point(561, 168);
            this.lblLoadDie.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblLoadDie.MoveControl = null;
            this.lblLoadDie.Name = "lblLoadDie";
            this.lblLoadDie.Size = new System.Drawing.Size(108, 50);
            this.lblLoadDie.TabIndex = 90;
            this.lblLoadDie.Text = "장착금형";
            this.lblLoadDie.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblLoadDie.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemName.Location = new System.Drawing.Point(460, 114);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(549, 50);
            this.txtItemName.TabIndex = 89;
            this.txtItemName.Text = "TEST ITEM NAME";
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
            this.txtItemCode.Location = new System.Drawing.Point(125, 114);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(333, 50);
            this.txtItemCode.TabIndex = 75;
            this.txtItemCode.Text = "12345-78901-34";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtOrderNo.Location = new System.Drawing.Point(125, 168);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrderNo.MoveControl = null;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(229, 50);
            this.txtOrderNo.TabIndex = 16;
            this.txtOrderNo.Text = "0303114401001";
            this.txtOrderNo.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtOrderNo.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtOrderNo._Click += new System.EventHandler(this.txtOrderNo_Click);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.BackColor = System.Drawing.Color.LightGreen;
            this.lblOrderNo.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblOrderNo.BackColor2 = System.Drawing.Color.White;
            this.lblOrderNo.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblOrderNo.ColorContent = System.Drawing.Color.Moccasin;
            this.lblOrderNo.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblOrderNo.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderNo.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblOrderNo.Location = new System.Drawing.Point(4, 168);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblOrderNo.MoveControl = null;
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(120, 50);
            this.lblOrderNo.TabIndex = 15;
            this.lblOrderNo.Text = "작업지시";
            this.lblOrderNo.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblOrderNo.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(213, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(251, 50);
            this.txtWorkCenterName.TabIndex = 9;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.LightGreen;
            this.lblItem.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblItem.BackColor2 = System.Drawing.Color.White;
            this.lblItem.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblItem.ColorContent = System.Drawing.Color.Moccasin;
            this.lblItem.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItem.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblItem.Location = new System.Drawing.Point(4, 114);
            this.lblItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblItem.MoveControl = null;
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(120, 50);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "품목";
            this.lblItem.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblItem.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkerNames.Location = new System.Drawing.Point(213, 60);
            this.txtWorkerNames.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerNames.MoveControl = null;
            this.txtWorkerNames.Name = "txtWorkerNames";
            this.txtWorkerNames.Size = new System.Drawing.Size(600, 50);
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
            this.txtWorkerCnt.Location = new System.Drawing.Point(125, 60);
            this.txtWorkerCnt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCnt.MoveControl = null;
            this.txtWorkerCnt.Name = "txtWorkerCnt";
            this.txtWorkerCnt.Size = new System.Drawing.Size(85, 50);
            this.txtWorkerCnt.TabIndex = 5;
            this.txtWorkerCnt.Text = "5";
            this.txtWorkerCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.lblWorker.Location = new System.Drawing.Point(4, 60);
            this.lblWorker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWorker.MoveControl = null;
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(120, 50);
            this.lblWorker.TabIndex = 4;
            this.lblWorker.Text = "작업자";
            this.lblWorker.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblWorker.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(125, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(85, 50);
            this.txtWorkCenterCode.TabIndex = 2;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // lblWorkShop
            // 
            this.lblWorkShop.BackColor = System.Drawing.Color.LightGreen;
            this.lblWorkShop.BackColor1 = System.Drawing.Color.LightGreen;
            this.lblWorkShop.BackColor2 = System.Drawing.Color.White;
            this.lblWorkShop.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblWorkShop.ColorContent = System.Drawing.Color.Moccasin;
            this.lblWorkShop.ColorReadOnly = System.Drawing.Color.Transparent;
            this.lblWorkShop.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkShop.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblWorkShop.Location = new System.Drawing.Point(4, 6);
            this.lblWorkShop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWorkShop.MoveControl = null;
            this.lblWorkShop.Name = "lblWorkShop";
            this.lblWorkShop.Size = new System.Drawing.Size(120, 50);
            this.lblWorkShop.TabIndex = 1;
            this.lblWorkShop.Text = "작업장";
            this.lblWorkShop.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblWorkShop.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel16
            // 
            this.mesLabel16.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel16.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel16.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel16.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel16.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel16.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel16.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel16.Location = new System.Drawing.Point(86, 386);
            this.mesLabel16.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel16.MoveControl = null;
            this.mesLabel16.Name = "mesLabel16";
            this.mesLabel16.Size = new System.Drawing.Size(120, 40);
            this.mesLabel16.TabIndex = 109;
            this.mesLabel16.Text = "주간";
            this.mesLabel16.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel16.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel16.Visible = false;
            // 
            // mesLabel15
            // 
            this.mesLabel15.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel15.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel15.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel15.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel15.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel15.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel15.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel15.Location = new System.Drawing.Point(86, 316);
            this.mesLabel15.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel15.MoveControl = null;
            this.mesLabel15.Name = "mesLabel15";
            this.mesLabel15.Size = new System.Drawing.Size(120, 70);
            this.mesLabel15.TabIndex = 108;
            this.mesLabel15.Text = "50000";
            this.mesLabel15.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel15.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel15.Visible = false;
            // 
            // mesLabel12
            // 
            this.mesLabel12.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel12.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel12.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel12.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel12.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel12.Location = new System.Drawing.Point(86, 278);
            this.mesLabel12.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel12.MoveControl = null;
            this.mesLabel12.Name = "mesLabel12";
            this.mesLabel12.Size = new System.Drawing.Size(120, 38);
            this.mesLabel12.TabIndex = 107;
            this.mesLabel12.Text = "계획수량";
            this.mesLabel12.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel12.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel12.Visible = false;
            // 
            // mesLabel11
            // 
            this.mesLabel11.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel11.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel11.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel11.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel11.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel11.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel11.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel11.Location = new System.Drawing.Point(6, 386);
            this.mesLabel11.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel11.MoveControl = null;
            this.mesLabel11.Name = "mesLabel11";
            this.mesLabel11.Size = new System.Drawing.Size(80, 40);
            this.mesLabel11.TabIndex = 106;
            this.mesLabel11.Text = "합계";
            this.mesLabel11.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel11.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel11.Visible = false;
            // 
            // mesLabel14
            // 
            this.mesLabel14.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel14.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel14.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel14.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel14.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel14.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel14.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel14.Location = new System.Drawing.Point(6, 351);
            this.mesLabel14.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel14.MoveControl = null;
            this.mesLabel14.Name = "mesLabel14";
            this.mesLabel14.Size = new System.Drawing.Size(80, 35);
            this.mesLabel14.TabIndex = 105;
            this.mesLabel14.Text = "야간";
            this.mesLabel14.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel14.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel14.Visible = false;
            // 
            // mesLabel13
            // 
            this.mesLabel13.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel13.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel13.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel13.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel13.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel13.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel13.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel13.Location = new System.Drawing.Point(6, 316);
            this.mesLabel13.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel13.MoveControl = null;
            this.mesLabel13.Name = "mesLabel13";
            this.mesLabel13.Size = new System.Drawing.Size(80, 35);
            this.mesLabel13.TabIndex = 104;
            this.mesLabel13.Text = "주간";
            this.mesLabel13.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel13.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel13.Visible = false;
            // 
            // mesLabel9
            // 
            this.mesLabel9.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel9.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel9.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel9.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel9.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel9.Location = new System.Drawing.Point(6, 278);
            this.mesLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.mesLabel9.MoveControl = null;
            this.mesLabel9.Name = "mesLabel9";
            this.mesLabel9.Size = new System.Drawing.Size(80, 38);
            this.mesLabel9.TabIndex = 101;
            this.mesLabel9.Text = "작업조";
            this.mesLabel9.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel9.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel9.Visible = false;
            // 
            // Grid2
            // 
            this.Grid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grid2.CountRows = 0;
            this.Grid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid2.FixedCols = 0;
            this.Grid2.FontSize = 15.75F;
            this.Grid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid2.HeadString = null;
            this.Grid2.Location = new System.Drawing.Point(0, 275);
            this.Grid2.Name = "Grid2";
            this.Grid2.Row = null;
            this.Grid2.SelectCommand = null;
            this.Grid2.SelectProcedureName = null;
            this.Grid2.Size = new System.Drawing.Size(1012, 164);
            this.Grid2.TabIndex = 124;
            this.Grid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid2_GridClick);
            // 
            // btnStatus
            // 
            this.btnStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStatus.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnStatus.CountX = 1;
            this.btnStatus.CountY = 1;
            this.btnStatus.CurrentPage = 0;
            this.btnStatus.ExTag = "";
            this.btnStatus.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStatus.Location = new System.Drawing.Point(862, 0);
            this.btnStatus.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnStatus.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.SelectCommand = null;
            this.btnStatus.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnStatus.SelectProcedureName = null;
            this.btnStatus.Size = new System.Drawing.Size(146, 158);
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
            this.bBox1.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // DA0060
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0060";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA0060_FormClosed);
            this.Load += new System.EventHandler(this.DA0060_Load);
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
        private MESLabel lblWorkShop;
        private ButtonBox btnStatus;
        private MESGrid Grid1;
        private MESLabel txtWorkerNames;
        private MESLabel txtWorkerCnt;
        private MESLabel lblWorker;
        private MESLabel lblItem;
        private MESLabel txtWorkCenterName;
        private MESLabel txtOrderNo;
        private MESLabel lblOrderNo;
        private MESLabel txtItemCode;
        private MESLabel txtItemName;
        private MESLabel txtMoldName;
        private MESLabel txtMoldCode;
        private MESLabel txtPlanMoldCode;
        private MESLabel lblOrderDie;
        private MESLabel lblLoadDie;
        private MESLabel txtPCName;
        private MESLabel lblTerminal;
        private MESLabel txtLineStatus;
        private MESLabel lblWorkShopStatus;
        private MESLabel txtLastLineDate;
        private MESLabel mesLabel9;
        private MESLabel mesLabel16;
        private MESLabel mesLabel15;
        private MESLabel mesLabel12;
        private MESLabel mesLabel11;
        private MESLabel mesLabel14;
        private MESLabel mesLabel13;
        private MESLabel txtPlanQty;
        private MESLabel lblOrderQty;
        private MESLabel txtPlanMoldName;
        private MESLabel txtCarryInQty;
        private MESLabel lblOverQty;
        private MESLabel mesLabel17;
        private MESLabel lblCavity;
        private MESLabel lblDayOrder;
        private MESGrid Grid2;
        private MESButton btnAutonomyInsp;
        private MESButton btnWorkReport;
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
