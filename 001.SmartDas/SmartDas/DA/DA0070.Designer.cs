using SmartDas.Components;

namespace SmartDas
{
    partial class DA0070
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
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_Select = new Infragistics.Win.Misc.UltraPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtDoneQty = new SmartDas.Components.MESLabel();
            this.txtCarType = new SmartDas.Components.MESLabel();
            this.txtGoodQty = new SmartDas.Components.MESLabel();
            this.txtLotQty = new SmartDas.Components.MESLabel();
            this.txtItemCode = new SmartDas.Components.MESLabel();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.txtBadQty = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.bBox_WC = new SmartDas.Components.ButtonBox();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.txtItemName = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.mesLabel16 = new SmartDas.Components.MESLabel();
            this.mesLabel15 = new SmartDas.Components.MESLabel();
            this.mesLabel12 = new SmartDas.Components.MESLabel();
            this.mesLabel11 = new SmartDas.Components.MESLabel();
            this.mesLabel14 = new SmartDas.Components.MESLabel();
            this.mesLabel13 = new SmartDas.Components.MESLabel();
            this.mesLabel9 = new SmartDas.Components.MESLabel();
            this.bBox1 = new SmartDas.Components.ButtonBox();
            this.bar2Code = new DevExpress.XtraEditors.BarCodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_Select.ClientArea.SuspendLayout();
            this.pnl_Select.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.bar2Code);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Select);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoneQty);
            this.splitContainer1.Panel1.Controls.Add(this.txtCarType);
            this.splitContainer1.Panel1.Controls.Add(this.txtGoodQty);
            this.splitContainer1.Panel1.Controls.Add(this.txtLotQty);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtLotNo);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfBox);
            this.splitContainer1.Panel1.Controls.Add(this.txtBadQty);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel7);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel6);
            this.splitContainer1.Panel1.Controls.Add(this.bBox_WC);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel10);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemName);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel8);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.Grid1);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel16);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel15);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel12);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel11);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel14);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel13);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 602);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_Select
            // 
            this.pnl_Select.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched;
            // 
            // pnl_Select.ClientArea
            // 
            this.pnl_Select.ClientArea.Controls.Add(this.btnCancel);
            this.pnl_Select.ClientArea.Controls.Add(this.btnSelect);
            this.pnl_Select.ClientArea.Controls.Add(this.label1);
            this.pnl_Select.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl_Select.Location = new System.Drawing.Point(355, 222);
            this.pnl_Select.Name = "pnl_Select";
            this.pnl_Select.Size = new System.Drawing.Size(376, 285);
            this.pnl_Select.TabIndex = 131;
            this.pnl_Select.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnCancel.Location = new System.Drawing.Point(195, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 94);
            this.btnCancel.TabIndex = 131;
            this.btnCancel.Text = "쇼트";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelect.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnSelect.Location = new System.Drawing.Point(49, 143);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 94);
            this.btnSelect.TabIndex = 130;
            this.btnSelect.Text = "사상";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.label1.Location = new System.Drawing.Point(158, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "선택";
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.White;
            this.mesLabel3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(529, 168);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(90, 50);
            this.mesLabel3.TabIndex = 135;
            this.mesLabel3.Text = "작업수량";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtDoneQty
            // 
            this.txtDoneQty.BackColor = System.Drawing.Color.White;
            this.txtDoneQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtDoneQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDoneQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDoneQty.ColorContent = System.Drawing.Color.White;
            this.txtDoneQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDoneQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDoneQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDoneQty.Location = new System.Drawing.Point(622, 168);
            this.txtDoneQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDoneQty.MoveControl = null;
            this.txtDoneQty.Name = "txtDoneQty";
            this.txtDoneQty.Size = new System.Drawing.Size(150, 50);
            this.txtDoneQty.TabIndex = 134;
            this.txtDoneQty.Text = "0";
            this.txtDoneQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtDoneQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtCarType.Location = new System.Drawing.Point(376, 222);
            this.txtCarType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCarType.MoveControl = null;
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(125, 50);
            this.txtCarType.TabIndex = 133;
            this.txtCarType.Text = "K7";
            this.txtCarType.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtCarType.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtGoodQty
            // 
            this.txtGoodQty.BackColor = System.Drawing.Color.White;
            this.txtGoodQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtGoodQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtGoodQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtGoodQty.ColorContent = System.Drawing.Color.White;
            this.txtGoodQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtGoodQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGoodQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtGoodQty.Location = new System.Drawing.Point(130, 168);
            this.txtGoodQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGoodQty.MoveControl = null;
            this.txtGoodQty.Name = "txtGoodQty";
            this.txtGoodQty.Size = new System.Drawing.Size(150, 50);
            this.txtGoodQty.TabIndex = 132;
            this.txtGoodQty.Text = "0";
            this.txtGoodQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtGoodQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtGoodQty._Click += new System.EventHandler(this.txtGoodQty_Click);
            // 
            // txtLotQty
            // 
            this.txtLotQty.BackColor = System.Drawing.Color.White;
            this.txtLotQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLotQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLotQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLotQty.ColorContent = System.Drawing.Color.White;
            this.txtLotQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLotQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLotQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLotQty.Location = new System.Drawing.Point(376, 168);
            this.txtLotQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLotQty.MoveControl = null;
            this.txtLotQty.Name = "txtLotQty";
            this.txtLotQty.Size = new System.Drawing.Size(150, 50);
            this.txtLotQty.TabIndex = 125;
            this.txtLotQty.Text = "0";
            this.txtLotQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtLotQty.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtItemCode.Location = new System.Drawing.Point(504, 222);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCode.MoveControl = null;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(230, 50);
            this.txtItemCode.TabIndex = 75;
            this.txtItemCode.Text = "12345-78901-34";
            this.txtItemCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtItemCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLotNo
            // 
            this.txtLotNo.Font = new System.Drawing.Font("휴먼모음T", 26.5F);
            this.txtLotNo.Location = new System.Drawing.Point(130, 114);
            this.txtLotNo.MaxLength = 0;
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(642, 48);
            this.txtLotNo.TabIndex = 130;
            this.txtLotNo.Text = "1305212101901-001";
            this.txtLotNo.Click += new System.EventHandler(this.txtLotNo_Click);
            this.txtLotNo.TextChanged += new System.EventHandler(this.txtLotNo_TextChanged);
            this.txtLotNo.DoubleClick += new System.EventHandler(this.txtLotNo_DoubleClick);
            this.txtLotNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotNo_KeyPress);
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
            this.btnConfBox.Location = new System.Drawing.Point(777, 114);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(229, 104);
            this.btnConfBox.TabIndex = 128;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // txtBadQty
            // 
            this.txtBadQty.BackColor = System.Drawing.Color.White;
            this.txtBadQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtBadQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtBadQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtBadQty.ColorContent = System.Drawing.Color.White;
            this.txtBadQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtBadQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBadQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtBadQty.Location = new System.Drawing.Point(130, 222);
            this.txtBadQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBadQty.MoveControl = null;
            this.txtBadQty.Name = "txtBadQty";
            this.txtBadQty.Size = new System.Drawing.Size(150, 50);
            this.txtBadQty.TabIndex = 127;
            this.txtBadQty.Text = "0";
            this.txtBadQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtBadQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.White;
            this.mesLabel5.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel5.BackColor2 = System.Drawing.Color.White;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel5.Location = new System.Drawing.Point(6, 222);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 126;
            this.mesLabel5.Text = "불량수량";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.White;
            this.mesLabel7.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(283, 168);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(90, 50);
            this.mesLabel7.TabIndex = 124;
            this.mesLabel7.Text = "재고수량";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.White;
            this.mesLabel6.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(6, 114);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(120, 50);
            this.mesLabel6.TabIndex = 122;
            this.mesLabel6.Text = "LOT";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // bBox_WC
            // 
            this.bBox_WC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox_WC.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.bBox_WC.CountX = 3;
            this.bBox_WC.CountY = 1;
            this.bBox_WC.CurrentPage = 0;
            this.bBox_WC.ExTag = "";
            this.bBox_WC.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bBox_WC.Location = new System.Drawing.Point(130, 6);
            this.bBox_WC.MarginIn = new System.Windows.Forms.Padding(3);
            this.bBox_WC.MarginOut = new System.Windows.Forms.Padding(3);
            this.bBox_WC.Name = "bBox_WC";
            this.bBox_WC.SelectCommand = null;
            this.bBox_WC.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.bBox_WC.SelectProcedureName = null;
            this.bBox_WC.Size = new System.Drawing.Size(876, 104);
            this.bBox_WC.TabIndex = 121;
            this.bBox_WC.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.bBox_WC_buttonClickEvent);
            // 
            // mesLabel10
            // 
            this.mesLabel10.BackColor = System.Drawing.Color.White;
            this.mesLabel10.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel10.BackColor2 = System.Drawing.Color.White;
            this.mesLabel10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel10.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel10.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel10.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel10.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel10.Location = new System.Drawing.Point(283, 222);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(90, 50);
            this.mesLabel10.TabIndex = 119;
            this.mesLabel10.Text = "품목";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtItemName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtItemName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtItemName.ColorContent = System.Drawing.Color.White;
            this.txtItemName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtItemName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtItemName.Location = new System.Drawing.Point(738, 222);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemName.MoveControl = null;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(268, 50);
            this.txtItemName.TabIndex = 89;
            this.txtItemName.Text = "TEST ITEM NAME";
            this.txtItemName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtItemName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel8
            // 
            this.mesLabel8.BackColor = System.Drawing.Color.White;
            this.mesLabel8.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.mesLabel8.Text = "양품수량";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel1
            // 
            this.mesLabel1.BackColor = System.Drawing.Color.White;
            this.mesLabel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.mesLabel1.Size = new System.Drawing.Size(120, 104);
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
            this.Grid1.FixedCols = 0;
            this.Grid1.FontSize = 15.75F;
            this.Grid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid1.HeadString = null;
            this.Grid1.Location = new System.Drawing.Point(0, 278);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(1012, 233);
            this.Grid1.TabIndex = 0;
            this.Grid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid1_GridClick);
            // 
            // mesLabel16
            // 
            this.mesLabel16.BackColor = System.Drawing.Color.Transparent;
            this.mesLabel16.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel16.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel16.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel16.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel16.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel16.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel15.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel15.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel15.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel15.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel15.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel15.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel12.BackColor = System.Drawing.Color.Silver;
            this.mesLabel12.BackColor1 = System.Drawing.Color.Silver;
            this.mesLabel12.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel12.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel12.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel12.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel11.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel11.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel11.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel11.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel11.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel14.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel14.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel14.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel14.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel14.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel14.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel13.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel13.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel13.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesLabel13.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel13.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel13.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.mesLabel9.BackColor = System.Drawing.Color.Silver;
            this.mesLabel9.BackColor1 = System.Drawing.Color.Silver;
            this.mesLabel9.BackColor2 = System.Drawing.Color.Empty;
            this.mesLabel9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel9.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel9.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // bBox1
            // 
            this.bBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.bBox1.CountX = 6;
            this.bBox1.CountY = 1;
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
            this.bBox1.Size = new System.Drawing.Size(1012, 88);
            this.bBox1.TabIndex = 0;
            this.bBox1.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.bBox1_buttonClickEvent);
            this.bBox1.Load += new System.EventHandler(this.bBox1_Load);
            // 
            // bar2Code
            // 
            this.bar2Code.AutoModule = true;
            this.bar2Code.BackColor = System.Drawing.Color.White;
            this.bar2Code.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bar2Code.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bar2Code.Location = new System.Drawing.Point(196, 302);
            this.bar2Code.Module = 4D;
            this.bar2Code.Name = "bar2Code";
            this.bar2Code.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.bar2Code.ShowText = false;
            this.bar2Code.ShowToolTips = false;
            this.bar2Code.Size = new System.Drawing.Size(55, 49);
            this.bar2Code.Symbology = dataMatrixGS1Generator1;
            this.bar2Code.TabIndex = 137;
            this.bar2Code.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bar2Code.Visible = false;
            // 
            // DA0070
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0070";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA0070_FormClosed);
            this.Load += new System.EventHandler(this.DA0070_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_Select.ClientArea.ResumeLayout(false);
            this.pnl_Select.ClientArea.PerformLayout();
            this.pnl_Select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ButtonBox bBox1;
        private MESLabel mesLabel1;
        private MESGrid Grid1;
        private MESLabel mesLabel8;
        private MESLabel mesLabel9;
        private MESLabel mesLabel16;
        private MESLabel mesLabel15;
        private MESLabel mesLabel12;
        private MESLabel mesLabel11;
        private MESLabel mesLabel14;
        private MESLabel mesLabel13;
        private MESLabel mesLabel10;
        private ButtonBox bBox_WC;
        private MESLabel txtItemName;
        private MESLabel txtItemCode;
        private MESLabel mesLabel6;
        private MESLabel txtBadQty;
        private MESLabel mesLabel5;
        private MESLabel txtLotQty;
        private MESLabel mesLabel7;
        private ButtonBox btnConfBox;
        private System.Windows.Forms.TextBox txtLotNo;
        private Infragistics.Win.Misc.UltraPanel pnl_Select;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private MESLabel txtGoodQty;
        private MESLabel txtCarType;
        private MESLabel mesLabel3;
        private MESLabel txtDoneQty;
        private DevExpress.XtraEditors.BarCodeControl bar2Code;
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
