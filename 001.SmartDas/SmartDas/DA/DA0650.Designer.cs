namespace SmartDas
{
    partial class DA0650
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
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.btnBox = new SmartDas.Components.ButtonBox();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtTotalQty = new SmartDas.Components.MESLabel();
            this.mesLabel11 = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.btnDown_1 = new SmartDas.Components.MESButton();
            this.btnUp_1 = new SmartDas.Components.MESButton();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.btnBox2 = new SmartDas.Components.ButtonBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "공정 불량 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkMoveSize = 4;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkMoveSize = 4;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnBox2);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.btnDown_1);
            this.GroupBody.Controls.Add(this.btnUp_1);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtTotalQty);
            this.GroupBody.Controls.Add(this.mesLabel11);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.btnBox);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.mesLabel5);
            // 
            // mesGrid1
            // 
            this.mesGrid1.AutoScroll = true;
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 20.25F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(1, 58);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1012, 143);
            this.mesGrid1.TabIndex = 104;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // mesGrid2
            // 
            this.mesGrid2.AutoScroll = true;
            this.mesGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid2.CountRows = 0;
            this.mesGrid2.FixedCols = 0;
            this.mesGrid2.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid2.FontSize = 20.25F;
            this.mesGrid2.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid2.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid2.HeadString = null;
            this.mesGrid2.Location = new System.Drawing.Point(552, 228);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(416, 375);
            this.mesGrid2.TabIndex = 106;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid2_GridClick);
            // 
            // btnConfBox
            // 
            this.btnConfBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnConfBox.CountX = 1;
            this.btnConfBox.CountY = 1;
            this.btnConfBox.CurrentPage = 0;
            this.btnConfBox.ExTag = "";
            this.btnConfBox.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfBox.Location = new System.Drawing.Point(590, 2);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(422, 55);
            this.btnConfBox.TabIndex = 107;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // btnBox
            // 
            this.btnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnBox.CountX = 2;
            this.btnBox.CountY = 4;
            this.btnBox.CurrentPage = 0;
            this.btnBox.ExTag = "";
            this.btnBox.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBox.Location = new System.Drawing.Point(0, 228);
            this.btnBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox.Name = "btnBox";
            this.btnBox.SelectCommand = null;
            this.btnBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox.SelectProcedureName = null;
            this.btnBox.Size = new System.Drawing.Size(550, 174);
            this.btnBox.TabIndex = 108;
            this.btnBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnBox_buttonChangeEvent);
            // 
            // mesLabel6
            // 
            this.mesLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel6.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mesLabel6.BackColor2 = System.Drawing.Color.White;
            this.mesLabel6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel6.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel6.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel6.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel6.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel6.Location = new System.Drawing.Point(1, 202);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(543, 26);
            this.mesLabel6.TabIndex = 113;
            this.mesLabel6.Text = "[ 소재 불량(S) ]";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel1
            // 
            this.mesLabel1.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel1.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel1.Location = new System.Drawing.Point(552, 202);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(459, 26);
            this.mesLabel1.TabIndex = 114;
            this.mesLabel1.Text = "[ 투입자재 리스트 ]";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtTotalQty.Location = new System.Drawing.Point(449, 2);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalQty.MoveControl = null;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(139, 55);
            this.txtTotalQty.TabIndex = 116;
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
            this.mesLabel11.Location = new System.Drawing.Point(361, 2);
            this.mesLabel11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel11.MoveControl = null;
            this.mesLabel11.Name = "mesLabel11";
            this.mesLabel11.Size = new System.Drawing.Size(86, 55);
            this.mesLabel11.TabIndex = 115;
            this.mesLabel11.Text = "등록수량";
            this.mesLabel11.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel11.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel2
            // 
            this.mesLabel2.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel2.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel2.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel2.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel2.Enabled = false;
            this.mesLabel2.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel2.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel2.Location = new System.Drawing.Point(127, 2);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(233, 55);
            this.mesLabel2.TabIndex = 118;
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Left;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel3.BackColor2 = System.Drawing.Color.White;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.LightGreen;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(2, 2);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(125, 55);
            this.mesLabel3.TabIndex = 117;
            this.mesLabel3.Text = "선택 된 품번";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel4
            // 
            this.mesLabel4.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel4.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel4.BackColor2 = System.Drawing.Color.White;
            this.mesLabel4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel4.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel4.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel4.Enabled = false;
            this.mesLabel4.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel4.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel4.Location = new System.Drawing.Point(127, 73);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(225, 40);
            this.mesLabel4.TabIndex = 119;
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Left;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel4.Visible = false;
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel5.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel5.BackColor2 = System.Drawing.Color.White;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Enabled = false;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel5.Location = new System.Drawing.Point(127, 58);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(225, 55);
            this.mesLabel5.TabIndex = 120;
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Left;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel5.Visible = false;
            // 
            // btnDown_1
            // 
            this.btnDown_1.AlarmColor1 = System.Drawing.Color.Transparent;
            this.btnDown_1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown_1.BackColor = System.Drawing.Color.Transparent;
            this.btnDown_1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown_1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown_1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown_1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown_1.ButtonPressed = false;
            this.btnDown_1.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnDown_1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown_1.ExTag = null;
            this.btnDown_1.Font = new System.Drawing.Font("휴먼모음T", 14F);
            this.btnDown_1.FontSize = 14F;
            this.btnDown_1.LinkButtonBox = null;
            this.btnDown_1.LinkGrid = this.mesGrid2;
            this.btnDown_1.LinkMoveSize = 2;
            this.btnDown_1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown_1.Location = new System.Drawing.Point(969, 416);
            this.btnDown_1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown_1.Name = "btnDown_1";
            this.btnDown_1.ParentBox = null;
            this.btnDown_1.Size = new System.Drawing.Size(41, 186);
            this.btnDown_1.TabIndex = 122;
            this.btnDown_1.Text = "▼";
            this.btnDown_1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown_1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown_1.UseFlag = true;
            // 
            // btnUp_1
            // 
            this.btnUp_1.AlarmColor1 = System.Drawing.Color.Transparent;
            this.btnUp_1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp_1.BackColor = System.Drawing.Color.Transparent;
            this.btnUp_1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp_1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp_1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp_1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp_1.ButtonPressed = false;
            this.btnUp_1.ClickBackColor1 = System.Drawing.Color.Transparent;
            this.btnUp_1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp_1.ExTag = null;
            this.btnUp_1.Font = new System.Drawing.Font("휴먼모음T", 14F);
            this.btnUp_1.FontSize = 14F;
            this.btnUp_1.LinkButtonBox = null;
            this.btnUp_1.LinkGrid = this.mesGrid2;
            this.btnUp_1.LinkMoveSize = 2;
            this.btnUp_1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp_1.Location = new System.Drawing.Point(969, 228);
            this.btnUp_1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp_1.Name = "btnUp_1";
            this.btnUp_1.ParentBox = null;
            this.btnUp_1.Size = new System.Drawing.Size(41, 186);
            this.btnUp_1.TabIndex = 121;
            this.btnUp_1.Text = "▲";
            this.btnUp_1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp_1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp_1.UseFlag = true;
            // 
            // mesLabel7
            // 
            this.mesLabel7.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel7.BackColor2 = System.Drawing.Color.White;
            this.mesLabel7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel7.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel7.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel7.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel7.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel7.Location = new System.Drawing.Point(1, 403);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(543, 26);
            this.mesLabel7.TabIndex = 123;
            this.mesLabel7.Text = "[ 가공 불량(M) ]";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnBox2
            // 
            this.btnBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox2.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnBox2.CountX = 2;
            this.btnBox2.CountY = 4;
            this.btnBox2.CurrentPage = 0;
            this.btnBox2.ExTag = "";
            this.btnBox2.Font = new System.Drawing.Font("휴먼모음T", 9.75F);
            this.btnBox2.Location = new System.Drawing.Point(0, 429);
            this.btnBox2.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox2.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.SelectCommand = null;
            this.btnBox2.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox2.SelectProcedureName = null;
            this.btnBox2.Size = new System.Drawing.Size(550, 173);
            this.btnBox2.TabIndex = 124;
            this.btnBox2.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnBox2_buttonChangeEvent);
            // 
            // DA0650
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0650";
            this.Text = "단말기 설정";
            this.Load += new System.EventHandler(this.DA0650_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESGrid mesGrid1;
        private Components.MESGrid mesGrid2;
        private Components.ButtonBox btnConfBox;
        private Components.ButtonBox btnBox;
        private Components.MESLabel mesLabel6;
        private Components.MESLabel mesLabel1;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel mesLabel3;
        private Components.MESLabel txtTotalQty;
        private Components.MESLabel mesLabel11;
        private Components.MESLabel mesLabel4;
        private Components.MESLabel mesLabel5;
        private Components.MESButton btnDown_1;
        private Components.MESButton btnUp_1;
        private Components.ButtonBox btnBox2;
        private Components.MESLabel mesLabel7;

    }
}
