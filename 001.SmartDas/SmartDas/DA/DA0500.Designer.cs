namespace SmartDas
{
    partial class DA0500
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.txtRemainQty = new SmartDas.Components.MESLabel();
            this.txtProdQty = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.txtBadQty = new SmartDas.Components.MESLabel();
            this.txtTotalQty = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.mesLabel11 = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtBoxCap = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtLotNo = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtBoxQty = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.txtPlanQty = new SmartDas.Components.MESLabel();
            this.mesLabel9 = new SmartDas.Components.MESLabel();
            this.txtOrderNo = new SmartDas.Components.MESLabel();
            this.mesLabel12 = new SmartDas.Components.MESLabel();
            this.mesLabel13 = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.mesLabel15 = new SmartDas.Components.MESLabel();
            this.txtPLCProdQty = new SmartDas.Components.MESLabel();
            this.txtEnableQty = new SmartDas.Components.MESLabel();
            this.mesLabel17 = new SmartDas.Components.MESLabel();
            this.tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.pnl_Select = new Infragistics.Win.Misc.UltraPanel();
            this.btnstqty3 = new System.Windows.Forms.Button();
            this.btnstqty2 = new System.Windows.Forms.Button();
            this.btnstqty1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bar2Code = new DevExpress.XtraEditors.BarCodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.pnl_Select.ClientArea.SuspendLayout();
            this.pnl_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "실적 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.mesGrid1;
            this.btnRightPage.LinkMoveSize = 7;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.mesGrid1;
            this.btnLeftPage.LinkMoveSize = 7;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.bar2Code);
            this.GroupBody.Controls.Add(this.pnl_Select);
            this.GroupBody.Controls.Add(this.txtEnableQty);
            this.GroupBody.Controls.Add(this.mesLabel17);
            this.GroupBody.Controls.Add(this.txtPLCProdQty);
            this.GroupBody.Controls.Add(this.mesLabel15);
            this.GroupBody.Controls.Add(this.txtItemName);
            this.GroupBody.Controls.Add(this.mesLabel13);
            this.GroupBody.Controls.Add(this.txtOrderNo);
            this.GroupBody.Controls.Add(this.mesLabel12);
            this.GroupBody.Controls.Add(this.txtPlanQty);
            this.GroupBody.Controls.Add(this.mesLabel9);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.txtBoxQty);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.txtLotNo);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.txtBoxCap);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtItemCode);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtBadQty);
            this.GroupBody.Controls.Add(this.txtTotalQty);
            this.GroupBody.Controls.Add(this.mesLabel8);
            this.GroupBody.Controls.Add(this.mesLabel11);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.txtRemainQty);
            this.GroupBody.Controls.Add(this.txtProdQty);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.mesLabel10);
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
            this.btnConfBox.Size = new System.Drawing.Size(320, 104);
            this.btnConfBox.TabIndex = 22;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // txtRemainQty
            // 
            this.txtRemainQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtRemainQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtRemainQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtRemainQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtRemainQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtRemainQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtRemainQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemainQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRemainQty.Location = new System.Drawing.Point(574, 222);
            this.txtRemainQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRemainQty.MoveControl = null;
            this.txtRemainQty.Name = "txtRemainQty";
            this.txtRemainQty.Size = new System.Drawing.Size(108, 50);
            this.txtRemainQty.TabIndex = 64;
            this.txtRemainQty.Text = "99999";
            this.txtRemainQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtRemainQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtProdQty
            // 
            this.txtProdQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtProdQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtProdQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProdQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtProdQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtProdQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtProdQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProdQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtProdQty.Location = new System.Drawing.Point(338, 168);
            this.txtProdQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProdQty.MoveControl = null;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(108, 50);
            this.txtProdQty.TabIndex = 63;
            this.txtProdQty.Text = "99999";
            this.txtProdQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtProdQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel3.Location = new System.Drawing.Point(214, 222);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 62;
            this.mesLabel3.Text = "처리가능수량";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel10.TabIndex = 61;
            this.mesLabel10.Text = "생산누적수량";
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
            this.mesGrid1.FontSize = 20F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(0, 278);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(506, 327);
            this.mesGrid1.TabIndex = 65;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
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
            this.txtBadQty.Location = new System.Drawing.Point(136, 281);
            this.txtBadQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBadQty.MoveControl = null;
            this.txtBadQty.Name = "txtBadQty";
            this.txtBadQty.Size = new System.Drawing.Size(100, 50);
            this.txtBadQty.TabIndex = 69;
            this.txtBadQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtBadQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtBadQty.Visible = false;
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
            this.txtTotalQty.Location = new System.Drawing.Point(810, 114);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalQty.MoveControl = null;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(201, 50);
            this.txtTotalQty.TabIndex = 68;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtTotalQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtTotalQty._Click += new System.EventHandler(this.txtTotalQty_Click);
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
            this.mesLabel8.Location = new System.Drawing.Point(6, 281);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(120, 50);
            this.mesLabel8.TabIndex = 67;
            this.mesLabel8.Text = "불량수량";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel8.Visible = false;
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
            this.mesLabel11.Location = new System.Drawing.Point(686, 114);
            this.mesLabel11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel11.MoveControl = null;
            this.mesLabel11.Name = "mesLabel11";
            this.mesLabel11.Size = new System.Drawing.Size(120, 50);
            this.mesLabel11.TabIndex = 66;
            this.mesLabel11.Text = "생산수량";
            this.mesLabel11.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel11.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemCode.Location = new System.Drawing.Point(130, 114);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(185, 50);
            this.txtItemCode.TabIndex = 74;
            this.txtItemCode.Text = "12345-78901-34";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel6.Location = new System.Drawing.Point(6, 405);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 73;
            this.mesLabel6.Text = "품번";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel6.Visible = false;
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
            this.txtWorkCenterName.Size = new System.Drawing.Size(468, 50);
            this.txtWorkCenterName.TabIndex = 72;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
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
            this.txtWorkCenterCode.TabIndex = 71;
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
            this.mesLabel1.TabIndex = 70;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtBoxCap
            // 
            this.txtBoxCap.BackColor = System.Drawing.Color.White;
            this.txtBoxCap.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtBoxCap.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtBoxCap.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtBoxCap.ColorContent = System.Drawing.Color.White;
            this.txtBoxCap.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtBoxCap.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxCap.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtBoxCap.Location = new System.Drawing.Point(810, 168);
            this.txtBoxCap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxCap.MoveControl = null;
            this.txtBoxCap.Name = "txtBoxCap";
            this.txtBoxCap.Size = new System.Drawing.Size(201, 50);
            this.txtBoxCap.TabIndex = 76;
            this.txtBoxCap.Text = "0";
            this.txtBoxCap.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtBoxCap.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtBoxCap._Click += new System.EventHandler(this.txtQty_Click);
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
            this.mesLabel5.Location = new System.Drawing.Point(686, 168);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 75;
            this.mesLabel5.Text = "용기적입량";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtLotNo.Location = new System.Drawing.Point(136, 343);
            this.txtLotNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLotNo.MoveControl = null;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(100, 50);
            this.txtLotNo.TabIndex = 78;
            this.txtLotNo.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtLotNo.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtLotNo.Visible = false;
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
            this.mesLabel4.Location = new System.Drawing.Point(6, 343);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 77;
            this.mesLabel4.Text = "Lot No";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel4.Visible = false;
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtBoxQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtBoxQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtBoxQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtBoxQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtBoxQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtBoxQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtBoxQty.Location = new System.Drawing.Point(810, 222);
            this.txtBoxQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxQty.MoveControl = null;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(201, 50);
            this.txtBoxQty.TabIndex = 80;
            this.txtBoxQty.Text = "1";
            this.txtBoxQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtBoxQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(686, 222);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 79;
            this.mesLabel7.Text = "용기수량";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid2
            // 
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.Default;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = null;
            this.mesGrid2.Location = new System.Drawing.Point(512, 278);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(502, 327);
            this.mesGrid2.TabIndex = 81;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid2_GridClick);
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
            this.btnSelect.Location = new System.Drawing.Point(6, 168);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(204, 104);
            this.btnSelect.TabIndex = 82;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
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
            this.txtPlanQty.Location = new System.Drawing.Point(443, 60);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlanQty.MoveControl = null;
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(239, 50);
            this.txtPlanQty.TabIndex = 84;
            this.txtPlanQty.Text = "99999";
            this.txtPlanQty.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtPlanQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel9
            // 
            this.mesLabel9.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel9.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel9.BackColor2 = System.Drawing.Color.White;
            this.mesLabel9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel9.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel9.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel9.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel9.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel9.Location = new System.Drawing.Point(319, 60);
            this.mesLabel9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel9.MoveControl = null;
            this.mesLabel9.Name = "mesLabel9";
            this.mesLabel9.Size = new System.Drawing.Size(120, 50);
            this.mesLabel9.TabIndex = 83;
            this.mesLabel9.Text = "계획수량";
            this.mesLabel9.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel9.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtOrderNo.Location = new System.Drawing.Point(130, 60);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrderNo.MoveControl = null;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(185, 50);
            this.txtOrderNo.TabIndex = 86;
            this.txtOrderNo.Text = "1234567890123";
            this.txtOrderNo.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtOrderNo.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel12.Location = new System.Drawing.Point(6, 60);
            this.mesLabel12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel12.MoveControl = null;
            this.mesLabel12.Name = "mesLabel12";
            this.mesLabel12.Size = new System.Drawing.Size(120, 50);
            this.mesLabel12.TabIndex = 85;
            this.mesLabel12.Text = "작업지시";
            this.mesLabel12.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel12.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel13.Location = new System.Drawing.Point(6, 114);
            this.mesLabel13.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel13.MoveControl = null;
            this.mesLabel13.Name = "mesLabel13";
            this.mesLabel13.Size = new System.Drawing.Size(120, 50);
            this.mesLabel13.TabIndex = 87;
            this.mesLabel13.Text = "품목";
            this.mesLabel13.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel13.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemName.Location = new System.Drawing.Point(319, 114);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(363, 50);
            this.txtItemName.TabIndex = 88;
            this.txtItemName.Text = "TEST ITEM NAME";
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel15
            // 
            this.mesLabel15.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel15.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel15.BackColor2 = System.Drawing.Color.White;
            this.mesLabel15.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel15.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel15.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel15.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel15.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel15.Location = new System.Drawing.Point(450, 168);
            this.mesLabel15.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel15.MoveControl = null;
            this.mesLabel15.Name = "mesLabel15";
            this.mesLabel15.Size = new System.Drawing.Size(120, 50);
            this.mesLabel15.TabIndex = 89;
            this.mesLabel15.Text = "총생산량";
            this.mesLabel15.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel15.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtPLCProdQty
            // 
            this.txtPLCProdQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtPLCProdQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPLCProdQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPLCProdQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPLCProdQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPLCProdQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPLCProdQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPLCProdQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPLCProdQty.Location = new System.Drawing.Point(574, 168);
            this.txtPLCProdQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPLCProdQty.MoveControl = null;
            this.txtPLCProdQty.Name = "txtPLCProdQty";
            this.txtPLCProdQty.Size = new System.Drawing.Size(108, 50);
            this.txtPLCProdQty.TabIndex = 90;
            this.txtPLCProdQty.Text = "99999";
            this.txtPLCProdQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtPLCProdQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtEnableQty
            // 
            this.txtEnableQty.BackColor = System.Drawing.Color.Moccasin;
            this.txtEnableQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtEnableQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtEnableQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtEnableQty.ColorContent = System.Drawing.Color.Moccasin;
            this.txtEnableQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtEnableQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEnableQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtEnableQty.Location = new System.Drawing.Point(338, 222);
            this.txtEnableQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEnableQty.MoveControl = null;
            this.txtEnableQty.Name = "txtEnableQty";
            this.txtEnableQty.Size = new System.Drawing.Size(108, 50);
            this.txtEnableQty.TabIndex = 92;
            this.txtEnableQty.Text = "99999";
            this.txtEnableQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtEnableQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel17
            // 
            this.mesLabel17.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel17.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel17.BackColor2 = System.Drawing.Color.White;
            this.mesLabel17.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel17.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel17.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel17.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel17.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel17.Location = new System.Drawing.Point(450, 222);
            this.mesLabel17.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel17.MoveControl = null;
            this.mesLabel17.Name = "mesLabel17";
            this.mesLabel17.Size = new System.Drawing.Size(120, 50);
            this.mesLabel17.TabIndex = 91;
            this.mesLabel17.Text = "미처리잔량";
            this.mesLabel17.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel17.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // tmr_Refresh
            // 
            this.tmr_Refresh.Interval = 1000;
            this.tmr_Refresh.Tick += new System.EventHandler(this.tmr_Refresh_Tick);
            // 
            // pnl_Select
            // 
            this.pnl_Select.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised;
            // 
            // pnl_Select.ClientArea
            // 
            this.pnl_Select.ClientArea.Controls.Add(this.btnstqty3);
            this.pnl_Select.ClientArea.Controls.Add(this.btnstqty2);
            this.pnl_Select.ClientArea.Controls.Add(this.btnstqty1);
            this.pnl_Select.ClientArea.Controls.Add(this.label1);
            this.pnl_Select.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl_Select.Location = new System.Drawing.Point(512, 192);
            this.pnl_Select.Name = "pnl_Select";
            this.pnl_Select.Size = new System.Drawing.Size(498, 263);
            this.pnl_Select.TabIndex = 132;
            this.pnl_Select.Visible = false;
            // 
            // btnstqty3
            // 
            this.btnstqty3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnstqty3.Location = new System.Drawing.Point(327, 137);
            this.btnstqty3.Name = "btnstqty3";
            this.btnstqty3.Size = new System.Drawing.Size(140, 94);
            this.btnstqty3.TabIndex = 132;
            this.btnstqty3.Text = "0";
            this.btnstqty3.UseVisualStyleBackColor = true;
            this.btnstqty3.Click += new System.EventHandler(this.btnstqty_Click);
            // 
            // btnstqty2
            // 
            this.btnstqty2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnstqty2.Location = new System.Drawing.Point(181, 137);
            this.btnstqty2.Name = "btnstqty2";
            this.btnstqty2.Size = new System.Drawing.Size(140, 94);
            this.btnstqty2.TabIndex = 131;
            this.btnstqty2.Text = "0";
            this.btnstqty2.UseVisualStyleBackColor = true;
            this.btnstqty2.Click += new System.EventHandler(this.btnstqty_Click);
            // 
            // btnstqty1
            // 
            this.btnstqty1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnstqty1.Location = new System.Drawing.Point(35, 137);
            this.btnstqty1.Name = "btnstqty1";
            this.btnstqty1.Size = new System.Drawing.Size(140, 94);
            this.btnstqty1.TabIndex = 130;
            this.btnstqty1.Text = "10";
            this.btnstqty1.UseVisualStyleBackColor = true;
            this.btnstqty1.Click += new System.EventHandler(this.btnstqty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.label1.Location = new System.Drawing.Point(133, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "용기적입량 선택";
            // 
            // bar2Code
            // 
            this.bar2Code.AutoModule = true;
            this.bar2Code.BackColor = System.Drawing.Color.White;
            this.bar2Code.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bar2Code.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bar2Code.Location = new System.Drawing.Point(391, 331);
            this.bar2Code.Module = 4D;
            this.bar2Code.Name = "bar2Code";
            this.bar2Code.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.bar2Code.ShowText = false;
            this.bar2Code.ShowToolTips = false;
            this.bar2Code.Size = new System.Drawing.Size(55, 49);
            this.bar2Code.Symbology = dataMatrixGS1Generator1;
            this.bar2Code.TabIndex = 138;
            this.bar2Code.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bar2Code.Visible = false;
            // 
            // DA0500
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0500";
            this.Text = "도장 투입 실적";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DA0500_FormClosing);
            this.Load += new System.EventHandler(this.DA0500_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.pnl_Select.ClientArea.ResumeLayout(false);
            this.pnl_Select.ClientArea.PerformLayout();
            this.pnl_Select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtRemainQty;
        private Components.MESLabel txtProdQty;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel mesLabel10;
        private Components.MESGrid mesGrid1;
        private Components.MESLabel txtBadQty;
        private Components.MESLabel txtTotalQty;
        private Components.MESLabel mesLabel8;
        private Components.MESLabel mesLabel11;
        private Components.MESLabel txtItemCode;
        private Components.MESLabel mesLabel6;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel txtLotNo;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel txtBoxCap;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtBoxQty;
        private Components.MESLabel mesLabel7;
        private Components.MESGrid mesGrid2;
        private Components.ButtonBox btnSelect;
        private Components.MESLabel txtPlanQty;
        private Components.MESLabel mesLabel9;
        private Components.MESLabel txtOrderNo;
        private Components.MESLabel mesLabel12;
        private Components.MESLabel txtItemName;
        private Components.MESLabel mesLabel13;
        private Components.MESLabel txtEnableQty;
        private Components.MESLabel mesLabel17;
        private Components.MESLabel txtPLCProdQty;
        private Components.MESLabel mesLabel15;
        private System.Windows.Forms.Timer tmr_Refresh;
        private Infragistics.Win.Misc.UltraPanel pnl_Select;
        private System.Windows.Forms.Button btnstqty3;
        private System.Windows.Forms.Button btnstqty2;
        private System.Windows.Forms.Button btnstqty1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.BarCodeControl bar2Code;
    }
}
