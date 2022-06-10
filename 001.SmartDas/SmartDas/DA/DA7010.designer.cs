namespace SmartDas
{
    partial class DA7010
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
            this.txtMoldPartQty = new SmartDas.Components.MESLabel();
            this.txtMoldPartSpec = new SmartDas.Components.MESLabel();
            this.Labelrepaircode = new SmartDas.Components.MESLabel();
            this.txtMoldRepairName = new SmartDas.Components.MESLabel();
            this.txtMoldRepairCode = new SmartDas.Components.MESLabel();
            this.Labelerrorresson = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.mesGrid2 = new SmartDas.Components.MESGrid();
            this.mesGrid4 = new SmartDas.Components.MESGrid();
            this.txtWorkerName = new SmartDas.Components.MESLabel();
            this.txtWorkerCode = new SmartDas.Components.MESLabel();
            this.mesLabel6 = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.btnDown_1 = new SmartDas.Components.MESButton();
            this.btnUp_1 = new SmartDas.Components.MESButton();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.mesLabel2 = new SmartDas.Components.MESLabel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtRemark_M = new System.Windows.Forms.TextBox();
            this.btnUp_4 = new SmartDas.Components.MESButton();
            this.btnSelection = new SmartDas.Components.ButtonBox();
            this.btnDown_4 = new SmartDas.Components.MESButton();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.mesGrid3 = new SmartDas.Components.MESGrid();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.btnSave_2 = new SmartDas.Components.MESButton();
            this.btnNew_2 = new SmartDas.Components.MESButton();
            this.btnDelete_2 = new SmartDas.Components.MESButton();
            this.btnDelete_3 = new SmartDas.Components.MESButton();
            this.btnNew_3 = new SmartDas.Components.MESButton();
            this.btnDown_3 = new SmartDas.Components.MESButton();
            this.btnUp_3 = new SmartDas.Components.MESButton();
            this.btnSave_3 = new SmartDas.Components.MESButton();
            this.btnDown_2 = new SmartDas.Components.MESButton();
            this.btnUp_2 = new SmartDas.Components.MESButton();
            this.mesLabel9 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.btnNew_1 = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "금형보전";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkGrid = this.mesGrid2;
            this.btnRightPage.LinkMoveSize = 5;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkGrid = this.mesGrid2;
            this.btnLeftPage.LinkMoveSize = 5;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnNew_1);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel9);
            this.GroupBody.Controls.Add(this.btnSelection);
            this.GroupBody.Controls.Add(this.btnDown_2);
            this.GroupBody.Controls.Add(this.btnUp_2);
            this.GroupBody.Controls.Add(this.txtRemark_M);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.btnDelete_3);
            this.GroupBody.Controls.Add(this.btnNew_3);
            this.GroupBody.Controls.Add(this.btnDown_3);
            this.GroupBody.Controls.Add(this.btnUp_3);
            this.GroupBody.Controls.Add(this.btnSave_3);
            this.GroupBody.Controls.Add(this.btnDelete_2);
            this.GroupBody.Controls.Add(this.btnNew_2);
            this.GroupBody.Controls.Add(this.mesLabel8);
            this.GroupBody.Controls.Add(this.txtRemark);
            this.GroupBody.Controls.Add(this.mesLabel2);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.txtWorkerName);
            this.GroupBody.Controls.Add(this.txtWorkerCode);
            this.GroupBody.Controls.Add(this.mesLabel6);
            this.GroupBody.Controls.Add(this.txtMoldPartQty);
            this.GroupBody.Controls.Add(this.txtMoldPartSpec);
            this.GroupBody.Controls.Add(this.Labelrepaircode);
            this.GroupBody.Controls.Add(this.txtMoldRepairName);
            this.GroupBody.Controls.Add(this.txtMoldRepairCode);
            this.GroupBody.Controls.Add(this.Labelerrorresson);
            this.GroupBody.Controls.Add(this.mesGrid3);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.btnDown_4);
            this.GroupBody.Controls.Add(this.btnUp_4);
            this.GroupBody.Controls.Add(this.btnDown_1);
            this.GroupBody.Controls.Add(this.btnUp_1);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.btnSave_2);
            this.GroupBody.Controls.Add(this.mesGrid2);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesGrid1);
            this.GroupBody.Controls.Add(this.mesGrid4);
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
            this.btnConfBox.Location = new System.Drawing.Point(743, 4);
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
            // txtMoldPartQty
            // 
            this.txtMoldPartQty.BackColor = System.Drawing.Color.White;
            this.txtMoldPartQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldPartQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldPartQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldPartQty.ColorContent = System.Drawing.Color.White;
            this.txtMoldPartQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldPartQty.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldPartQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldPartQty.Location = new System.Drawing.Point(333, 281);
            this.txtMoldPartQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldPartQty.MoveControl = null;
            this.txtMoldPartQty.Name = "txtMoldPartQty";
            this.txtMoldPartQty.Size = new System.Drawing.Size(65, 50);
            this.txtMoldPartQty.TabIndex = 96;
            this.txtMoldPartQty.Text = "999";
            this.txtMoldPartQty.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldPartQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldPartQty.Visible = false;
            this.txtMoldPartQty._Click += new System.EventHandler(this.txtMoldPartQty_Click);
            // 
            // txtMoldPartSpec
            // 
            this.txtMoldPartSpec.BackColor = System.Drawing.Color.White;
            this.txtMoldPartSpec.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldPartSpec.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldPartSpec.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldPartSpec.ColorContent = System.Drawing.Color.White;
            this.txtMoldPartSpec.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldPartSpec.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldPartSpec.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldPartSpec.Location = new System.Drawing.Point(165, 281);
            this.txtMoldPartSpec.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldPartSpec.MoveControl = null;
            this.txtMoldPartSpec.Name = "txtMoldPartSpec";
            this.txtMoldPartSpec.Size = new System.Drawing.Size(65, 50);
            this.txtMoldPartSpec.TabIndex = 95;
            this.txtMoldPartSpec.Text = "999";
            this.txtMoldPartSpec.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldPartSpec.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldPartSpec.Visible = false;
            this.txtMoldPartSpec._Click += new System.EventHandler(this.txtMoldPartSpec_Click);
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
            this.Labelrepaircode.Location = new System.Drawing.Point(63, 281);
            this.Labelrepaircode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelrepaircode.MoveControl = null;
            this.Labelrepaircode.Name = "Labelrepaircode";
            this.Labelrepaircode.Size = new System.Drawing.Size(100, 50);
            this.Labelrepaircode.TabIndex = 94;
            this.Labelrepaircode.Text = "규격(Ø)";
            this.Labelrepaircode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelrepaircode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.Labelrepaircode.Visible = false;
            // 
            // txtMoldRepairName
            // 
            this.txtMoldRepairName.BackColor = System.Drawing.Color.White;
            this.txtMoldRepairName.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtMoldRepairName.BackColor2 = System.Drawing.Color.White;
            this.txtMoldRepairName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldRepairName.ColorContent = System.Drawing.Color.White;
            this.txtMoldRepairName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldRepairName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldRepairName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldRepairName.Location = new System.Drawing.Point(232, 227);
            this.txtMoldRepairName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldRepairName.MoveControl = null;
            this.txtMoldRepairName.Name = "txtMoldRepairName";
            this.txtMoldRepairName.Size = new System.Drawing.Size(166, 50);
            this.txtMoldRepairName.TabIndex = 93;
            this.txtMoldRepairName.Text = "반조작측";
            this.txtMoldRepairName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtMoldRepairName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldRepairName.Visible = false;
            this.txtMoldRepairName._Click += new System.EventHandler(this.txtMoldRepairCode_Click);
            // 
            // txtMoldRepairCode
            // 
            this.txtMoldRepairCode.BackColor = System.Drawing.Color.White;
            this.txtMoldRepairCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtMoldRepairCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMoldRepairCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMoldRepairCode.ColorContent = System.Drawing.Color.White;
            this.txtMoldRepairCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMoldRepairCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldRepairCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMoldRepairCode.Location = new System.Drawing.Point(165, 227);
            this.txtMoldRepairCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMoldRepairCode.MoveControl = null;
            this.txtMoldRepairCode.Name = "txtMoldRepairCode";
            this.txtMoldRepairCode.Size = new System.Drawing.Size(65, 50);
            this.txtMoldRepairCode.TabIndex = 92;
            this.txtMoldRepairCode.Text = "999";
            this.txtMoldRepairCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMoldRepairCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtMoldRepairCode.Visible = false;
            this.txtMoldRepairCode._Click += new System.EventHandler(this.txtMoldRepairCode_Click);
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
            this.Labelerrorresson.Location = new System.Drawing.Point(63, 227);
            this.Labelerrorresson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Labelerrorresson.MoveControl = null;
            this.Labelerrorresson.Name = "Labelerrorresson";
            this.Labelerrorresson.Size = new System.Drawing.Size(100, 50);
            this.Labelerrorresson.TabIndex = 91;
            this.Labelerrorresson.Text = "수리내용";
            this.Labelerrorresson.TextHAlign = Infragistics.Win.HAlign.Center;
            this.Labelerrorresson.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.Labelerrorresson.Visible = false;
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
            this.mesGrid1.Location = new System.Drawing.Point(57, 114);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(866, 104);
            this.mesGrid1.TabIndex = 97;
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
            this.mesLabel3.Location = new System.Drawing.Point(3, 222);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(50, 255);
            this.mesLabel3.TabIndex = 98;
            this.mesLabel3.Text = "고장내역";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesGrid2.Location = new System.Drawing.Point(57, 222);
            this.mesGrid2.Name = "mesGrid2";
            this.mesGrid2.Row = null;
            this.mesGrid2.SelectCommand = null;
            this.mesGrid2.SelectProcedureName = null;
            this.mesGrid2.Size = new System.Drawing.Size(449, 200);
            this.mesGrid2.TabIndex = 99;
            this.mesGrid2.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid2_GridClick);
            // 
            // mesGrid4
            // 
            this.mesGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid4.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid4.CountRows = 0;
            this.mesGrid4.FixedCols = 0;
            this.mesGrid4.FontSize = 20.25F;
            this.mesGrid4.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid4.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid4.HeadString = null;
            this.mesGrid4.Location = new System.Drawing.Point(57, 500);
            this.mesGrid4.Name = "mesGrid4";
            this.mesGrid4.Row = null;
            this.mesGrid4.SelectCommand = null;
            this.mesGrid4.SelectProcedureName = null;
            this.mesGrid4.Size = new System.Drawing.Size(859, 99);
            this.mesGrid4.TabIndex = 118;
            this.mesGrid4.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid4_GridClick);
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
            this.txtWorkerName.Location = new System.Drawing.Point(267, 58);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerName.MoveControl = null;
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(90, 50);
            this.txtWorkerName.TabIndex = 105;
            this.txtWorkerName.Text = "이명박";
            this.txtWorkerName.TextHAlign = Infragistics.Win.HAlign.Center;
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
            this.txtWorkerCode.Location = new System.Drawing.Point(124, 58);
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
            this.mesLabel6.Location = new System.Drawing.Point(232, 281);
            this.mesLabel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel6.MoveControl = null;
            this.mesLabel6.Name = "mesLabel6";
            this.mesLabel6.Size = new System.Drawing.Size(100, 50);
            this.mesLabel6.TabIndex = 103;
            this.mesLabel6.Text = "수량(EA)";
            this.mesLabel6.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel6.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel6.Visible = false;
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
            this.mesLabel7.Location = new System.Drawing.Point(3, 114);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(50, 104);
            this.mesLabel7.TabIndex = 111;
            this.mesLabel7.Text = "고장";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnDown_1
            // 
            this.btnDown_1.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDown_1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown_1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDown_1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown_1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown_1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown_1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown_1.ButtonPressed = false;
            this.btnDown_1.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown_1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown_1.ExTag = null;
            this.btnDown_1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown_1.FontSize = 20F;
            this.btnDown_1.LinkButtonBox = null;
            this.btnDown_1.LinkGrid = this.mesGrid1;
            this.btnDown_1.LinkMoveSize = 2;
            this.btnDown_1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown_1.Location = new System.Drawing.Point(926, 168);
            this.btnDown_1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown_1.Name = "btnDown_1";
            this.btnDown_1.ParentBox = null;
            this.btnDown_1.Size = new System.Drawing.Size(87, 50);
            this.btnDown_1.TabIndex = 113;
            this.btnDown_1.Text = "▼";
            this.btnDown_1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown_1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown_1.UseFlag = true;
            // 
            // btnUp_1
            // 
            this.btnUp_1.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnUp_1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp_1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUp_1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp_1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp_1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp_1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp_1.ButtonPressed = false;
            this.btnUp_1.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp_1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp_1.ExTag = null;
            this.btnUp_1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp_1.FontSize = 20F;
            this.btnUp_1.LinkButtonBox = null;
            this.btnUp_1.LinkGrid = this.mesGrid1;
            this.btnUp_1.LinkMoveSize = 2;
            this.btnUp_1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp_1.Location = new System.Drawing.Point(926, 114);
            this.btnUp_1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp_1.Name = "btnUp_1";
            this.btnUp_1.ParentBox = null;
            this.btnUp_1.Size = new System.Drawing.Size(87, 50);
            this.btnUp_1.TabIndex = 112;
            this.btnUp_1.Text = "▲";
            this.btnUp_1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp_1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp_1.UseFlag = true;
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
            this.mesLabel1.TabIndex = 114;
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
            this.mesLabel2.Location = new System.Drawing.Point(359, 58);
            this.mesLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel2.MoveControl = null;
            this.mesLabel2.Name = "mesLabel2";
            this.mesLabel2.Size = new System.Drawing.Size(120, 50);
            this.mesLabel2.TabIndex = 116;
            this.mesLabel2.Text = "비고";
            this.mesLabel2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel2.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(483, 60);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(257, 44);
            this.txtRemark.TabIndex = 117;
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
            this.mesLabel4.Location = new System.Drawing.Point(570, 227);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(303, 50);
            this.mesLabel4.TabIndex = 119;
            this.mesLabel4.Text = "비고";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel4.Visible = false;
            // 
            // txtRemark_M
            // 
            this.txtRemark_M.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark_M.Location = new System.Drawing.Point(570, 281);
            this.txtRemark_M.Multiline = true;
            this.txtRemark_M.Name = "txtRemark_M";
            this.txtRemark_M.Size = new System.Drawing.Size(303, 154);
            this.txtRemark_M.TabIndex = 120;
            this.txtRemark_M.Visible = false;
            // 
            // btnUp_4
            // 
            this.btnUp_4.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnUp_4.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp_4.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUp_4.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp_4.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp_4.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp_4.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp_4.ButtonPressed = false;
            this.btnUp_4.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp_4.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp_4.ExTag = null;
            this.btnUp_4.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp_4.FontSize = 20F;
            this.btnUp_4.LinkButtonBox = this.btnSelection;
            this.btnUp_4.LinkGrid = null;
            this.btnUp_4.LinkMoveSize = 2;
            this.btnUp_4.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp_4.Location = new System.Drawing.Point(926, 481);
            this.btnUp_4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp_4.Name = "btnUp_4";
            this.btnUp_4.ParentBox = null;
            this.btnUp_4.Size = new System.Drawing.Size(87, 58);
            this.btnUp_4.TabIndex = 121;
            this.btnUp_4.Text = "▲";
            this.btnUp_4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp_4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp_4.UseFlag = true;
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
            this.btnSelection.Location = new System.Drawing.Point(57, 481);
            this.btnSelection.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelection.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.SelectCommand = null;
            this.btnSelection.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelection.SelectProcedureName = "USP_DA7100_S5";
            this.btnSelection.Size = new System.Drawing.Size(866, 119);
            this.btnSelection.TabIndex = 138;
            this.btnSelection.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnSelection_buttonClickEvent);
            this.btnSelection.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelection_buttonClickEvent);
            // 
            // btnDown_4
            // 
            this.btnDown_4.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDown_4.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown_4.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDown_4.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown_4.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown_4.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown_4.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown_4.ButtonPressed = false;
            this.btnDown_4.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown_4.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown_4.ExTag = null;
            this.btnDown_4.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown_4.FontSize = 20F;
            this.btnDown_4.LinkButtonBox = this.btnSelection;
            this.btnDown_4.LinkGrid = null;
            this.btnDown_4.LinkMoveSize = 2;
            this.btnDown_4.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown_4.Location = new System.Drawing.Point(926, 542);
            this.btnDown_4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown_4.Name = "btnDown_4";
            this.btnDown_4.ParentBox = null;
            this.btnDown_4.Size = new System.Drawing.Size(87, 58);
            this.btnDown_4.TabIndex = 122;
            this.btnDown_4.Text = "▼";
            this.btnDown_4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown_4.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown_4.UseFlag = true;
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
            this.mesLabel5.Location = new System.Drawing.Point(510, 222);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(50, 255);
            this.mesLabel5.TabIndex = 123;
            this.mesLabel5.Text = "수리내역";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid3
            // 
            this.mesGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid3.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid3.CountRows = 0;
            this.mesGrid3.FixedCols = 0;
            this.mesGrid3.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid3.FontSize = 20.25F;
            this.mesGrid3.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid3.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid3.HeadString = "원인유형@H^250|원인코드@C^250|원인명@C^280";
            this.mesGrid3.Location = new System.Drawing.Point(564, 222);
            this.mesGrid3.Name = "mesGrid3";
            this.mesGrid3.Row = null;
            this.mesGrid3.SelectCommand = null;
            this.mesGrid3.SelectProcedureName = null;
            this.mesGrid3.Size = new System.Drawing.Size(449, 200);
            this.mesGrid3.TabIndex = 124;
            this.mesGrid3.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid3_GridClick);
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
            this.mesLabel8.Location = new System.Drawing.Point(3, 481);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(50, 119);
            this.mesLabel8.TabIndex = 125;
            this.mesLabel8.Text = "선택";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnSave_2
            // 
            this.btnSave_2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnSave_2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave_2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave_2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnSave_2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnSave_2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnSave_2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnSave_2.ButtonPressed = false;
            this.btnSave_2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnSave_2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnSave_2.ExTag = null;
            this.btnSave_2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnSave_2.FontSize = 20F;
            this.btnSave_2.LinkButtonBox = null;
            this.btnSave_2.LinkGrid = null;
            this.btnSave_2.LinkMoveSize = 1;
            this.btnSave_2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnSave_2.Location = new System.Drawing.Point(414, 427);
            this.btnSave_2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSave_2.Name = "btnSave_2";
            this.btnSave_2.ParentBox = null;
            this.btnSave_2.Size = new System.Drawing.Size(88, 50);
            this.btnSave_2.TabIndex = 102;
            this.btnSave_2.Text = "저장";
            this.btnSave_2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSave_2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSave_2.UseFlag = true;
            this.btnSave_2._Click += new System.EventHandler(this.btnSave_2_Click);
            // 
            // btnNew_2
            // 
            this.btnNew_2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnNew_2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew_2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNew_2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnNew_2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnNew_2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnNew_2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnNew_2.ButtonPressed = false;
            this.btnNew_2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnNew_2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnNew_2.ExTag = null;
            this.btnNew_2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnNew_2.FontSize = 20F;
            this.btnNew_2.LinkButtonBox = null;
            this.btnNew_2.LinkGrid = null;
            this.btnNew_2.LinkMoveSize = 1;
            this.btnNew_2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnNew_2.Location = new System.Drawing.Point(237, 427);
            this.btnNew_2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnNew_2.Name = "btnNew_2";
            this.btnNew_2.ParentBox = null;
            this.btnNew_2.Size = new System.Drawing.Size(88, 50);
            this.btnNew_2.TabIndex = 126;
            this.btnNew_2.Text = "신규";
            this.btnNew_2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnNew_2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnNew_2.UseFlag = true;
            this.btnNew_2._Click += new System.EventHandler(this.btnNew_2_Click);
            // 
            // btnDelete_2
            // 
            this.btnDelete_2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDelete_2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete_2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete_2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDelete_2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDelete_2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDelete_2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDelete_2.ButtonPressed = false;
            this.btnDelete_2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDelete_2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDelete_2.ExTag = null;
            this.btnDelete_2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDelete_2.FontSize = 20F;
            this.btnDelete_2.LinkButtonBox = null;
            this.btnDelete_2.LinkGrid = null;
            this.btnDelete_2.LinkMoveSize = 1;
            this.btnDelete_2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDelete_2.Location = new System.Drawing.Point(326, 427);
            this.btnDelete_2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete_2.Name = "btnDelete_2";
            this.btnDelete_2.ParentBox = null;
            this.btnDelete_2.Size = new System.Drawing.Size(88, 50);
            this.btnDelete_2.TabIndex = 127;
            this.btnDelete_2.Text = "삭제";
            this.btnDelete_2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete_2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete_2.UseFlag = true;
            this.btnDelete_2._Click += new System.EventHandler(this.btnDelete_2_Click);
            // 
            // btnDelete_3
            // 
            this.btnDelete_3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDelete_3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete_3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete_3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDelete_3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDelete_3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDelete_3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDelete_3.ButtonPressed = false;
            this.btnDelete_3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDelete_3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDelete_3.ExTag = null;
            this.btnDelete_3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDelete_3.FontSize = 20F;
            this.btnDelete_3.LinkButtonBox = null;
            this.btnDelete_3.LinkGrid = null;
            this.btnDelete_3.LinkMoveSize = 1;
            this.btnDelete_3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDelete_3.Location = new System.Drawing.Point(833, 427);
            this.btnDelete_3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDelete_3.Name = "btnDelete_3";
            this.btnDelete_3.ParentBox = null;
            this.btnDelete_3.Size = new System.Drawing.Size(88, 50);
            this.btnDelete_3.TabIndex = 132;
            this.btnDelete_3.Text = "삭제";
            this.btnDelete_3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDelete_3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDelete_3.UseFlag = true;
            this.btnDelete_3._Click += new System.EventHandler(this.btnDelete_3_Click);
            // 
            // btnNew_3
            // 
            this.btnNew_3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnNew_3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew_3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNew_3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnNew_3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnNew_3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnNew_3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnNew_3.ButtonPressed = false;
            this.btnNew_3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnNew_3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnNew_3.ExTag = null;
            this.btnNew_3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnNew_3.FontSize = 20F;
            this.btnNew_3.LinkButtonBox = null;
            this.btnNew_3.LinkGrid = null;
            this.btnNew_3.LinkMoveSize = 1;
            this.btnNew_3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnNew_3.Location = new System.Drawing.Point(744, 427);
            this.btnNew_3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnNew_3.Name = "btnNew_3";
            this.btnNew_3.ParentBox = null;
            this.btnNew_3.Size = new System.Drawing.Size(88, 50);
            this.btnNew_3.TabIndex = 131;
            this.btnNew_3.Text = "신규";
            this.btnNew_3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnNew_3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnNew_3.UseFlag = true;
            this.btnNew_3._Click += new System.EventHandler(this.btnNew_3_Click);
            // 
            // btnDown_3
            // 
            this.btnDown_3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDown_3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown_3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDown_3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown_3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown_3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown_3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown_3.ButtonPressed = false;
            this.btnDown_3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown_3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown_3.ExTag = null;
            this.btnDown_3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown_3.FontSize = 20F;
            this.btnDown_3.LinkButtonBox = null;
            this.btnDown_3.LinkGrid = this.mesGrid3;
            this.btnDown_3.LinkMoveSize = 2;
            this.btnDown_3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown_3.Location = new System.Drawing.Point(655, 427);
            this.btnDown_3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown_3.Name = "btnDown_3";
            this.btnDown_3.ParentBox = null;
            this.btnDown_3.Size = new System.Drawing.Size(88, 50);
            this.btnDown_3.TabIndex = 130;
            this.btnDown_3.Text = "▶";
            this.btnDown_3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown_3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown_3.UseFlag = true;
            // 
            // btnUp_3
            // 
            this.btnUp_3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnUp_3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp_3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUp_3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp_3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp_3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp_3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp_3.ButtonPressed = false;
            this.btnUp_3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp_3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp_3.ExTag = null;
            this.btnUp_3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp_3.FontSize = 20F;
            this.btnUp_3.LinkButtonBox = null;
            this.btnUp_3.LinkGrid = this.mesGrid3;
            this.btnUp_3.LinkMoveSize = 2;
            this.btnUp_3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp_3.Location = new System.Drawing.Point(566, 427);
            this.btnUp_3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp_3.Name = "btnUp_3";
            this.btnUp_3.ParentBox = null;
            this.btnUp_3.Size = new System.Drawing.Size(88, 50);
            this.btnUp_3.TabIndex = 129;
            this.btnUp_3.Text = "◀";
            this.btnUp_3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp_3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp_3.UseFlag = true;
            // 
            // btnSave_3
            // 
            this.btnSave_3.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnSave_3.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave_3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave_3.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnSave_3.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnSave_3.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnSave_3.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnSave_3.ButtonPressed = false;
            this.btnSave_3.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnSave_3.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnSave_3.ExTag = null;
            this.btnSave_3.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnSave_3.FontSize = 20F;
            this.btnSave_3.LinkButtonBox = null;
            this.btnSave_3.LinkGrid = null;
            this.btnSave_3.LinkMoveSize = 1;
            this.btnSave_3.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnSave_3.Location = new System.Drawing.Point(923, 427);
            this.btnSave_3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSave_3.Name = "btnSave_3";
            this.btnSave_3.ParentBox = null;
            this.btnSave_3.Size = new System.Drawing.Size(88, 50);
            this.btnSave_3.TabIndex = 128;
            this.btnSave_3.Text = "저장";
            this.btnSave_3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnSave_3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnSave_3.UseFlag = true;
            this.btnSave_3._Click += new System.EventHandler(this.btnSave_3_Click);
            // 
            // btnDown_2
            // 
            this.btnDown_2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnDown_2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown_2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDown_2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnDown_2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnDown_2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnDown_2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnDown_2.ButtonPressed = false;
            this.btnDown_2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown_2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown_2.ExTag = null;
            this.btnDown_2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown_2.FontSize = 20F;
            this.btnDown_2.LinkButtonBox = null;
            this.btnDown_2.LinkGrid = this.mesGrid2;
            this.btnDown_2.LinkMoveSize = 2;
            this.btnDown_2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown_2.Location = new System.Drawing.Point(148, 427);
            this.btnDown_2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown_2.Name = "btnDown_2";
            this.btnDown_2.ParentBox = null;
            this.btnDown_2.Size = new System.Drawing.Size(88, 50);
            this.btnDown_2.TabIndex = 134;
            this.btnDown_2.Text = "▶";
            this.btnDown_2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown_2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown_2.UseFlag = true;
            // 
            // btnUp_2
            // 
            this.btnUp_2.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnUp_2.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUp_2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUp_2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnUp_2.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnUp_2.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnUp_2.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnUp_2.ButtonPressed = false;
            this.btnUp_2.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp_2.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp_2.ExTag = null;
            this.btnUp_2.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp_2.FontSize = 20F;
            this.btnUp_2.LinkButtonBox = null;
            this.btnUp_2.LinkGrid = this.mesGrid2;
            this.btnUp_2.LinkMoveSize = 2;
            this.btnUp_2.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp_2.Location = new System.Drawing.Point(59, 427);
            this.btnUp_2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp_2.Name = "btnUp_2";
            this.btnUp_2.ParentBox = null;
            this.btnUp_2.Size = new System.Drawing.Size(88, 50);
            this.btnUp_2.TabIndex = 133;
            this.btnUp_2.Text = "◀";
            this.btnUp_2.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp_2.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp_2.UseFlag = true;
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
            this.mesLabel9.Location = new System.Drawing.Point(3, 58);
            this.mesLabel9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel9.MoveControl = null;
            this.mesLabel9.Name = "mesLabel9";
            this.mesLabel9.Size = new System.Drawing.Size(120, 50);
            this.mesLabel9.TabIndex = 139;
            this.mesLabel9.Text = "작업자";
            this.mesLabel9.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel9.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(209, 4);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(148, 50);
            this.txtWorkCenterName.TabIndex = 141;
            this.txtWorkCenterName.Text = "9999호기";
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(124, 4);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(83, 50);
            this.txtWorkCenterCode.TabIndex = 140;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnNew_1
            // 
            this.btnNew_1.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnNew_1.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew_1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNew_1.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnNew_1.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnNew_1.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnNew_1.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnNew_1.ButtonPressed = false;
            this.btnNew_1.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnNew_1.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnNew_1.ExTag = null;
            this.btnNew_1.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnNew_1.FontSize = 20F;
            this.btnNew_1.LinkButtonBox = null;
            this.btnNew_1.LinkGrid = null;
            this.btnNew_1.LinkMoveSize = 1;
            this.btnNew_1.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnNew_1.Location = new System.Drawing.Point(359, 4);
            this.btnNew_1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnNew_1.Name = "btnNew_1";
            this.btnNew_1.ParentBox = null;
            this.btnNew_1.Size = new System.Drawing.Size(382, 50);
            this.btnNew_1.TabIndex = 142;
            this.btnNew_1.Text = "보전등록생성";
            this.btnNew_1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnNew_1.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnNew_1.UseFlag = true;
            this.btnNew_1._Click += new System.EventHandler(this.btnNew_1_Click);
            // 
            // DA7010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA7010";
            this.Text = "설비 고장";
            this.Load += new System.EventHandler(this.DA7010_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.GroupBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtMoldPartQty;
        private Components.MESLabel txtMoldPartSpec;
        private Components.MESLabel Labelrepaircode;
        private Components.MESLabel txtMoldRepairName;
        private Components.MESLabel txtMoldRepairCode;
        private Components.MESLabel Labelerrorresson;
        private Components.MESLabel mesLabel3;
        private Components.MESGrid mesGrid1;
        private Components.MESGrid mesGrid2;
        private Components.MESLabel txtWorkerName;
        private Components.MESLabel txtWorkerCode;
        private Components.MESLabel mesLabel6;
        private Components.MESLabel mesLabel7;
        private Components.MESButton btnDown_1;
        private Components.MESButton btnUp_1;
        private Components.MESLabel mesLabel2;
        private Components.MESLabel mesLabel1;
        private System.Windows.Forms.TextBox txtRemark;
        private Components.MESGrid mesGrid4;
        private System.Windows.Forms.TextBox txtRemark_M;
        private Components.MESLabel mesLabel4;
        private Components.MESButton btnDown_4;
        private Components.MESButton btnUp_4;
        private Components.MESLabel mesLabel8;
        private Components.MESGrid mesGrid3;
        private Components.MESLabel mesLabel5;
        private Components.MESButton btnSave_2;
        private Components.MESButton btnDown_2;
        private Components.MESButton btnUp_2;
        private Components.MESButton btnDelete_3;
        private Components.MESButton btnNew_3;
        private Components.MESButton btnDown_3;
        private Components.MESButton btnUp_3;
        private Components.MESButton btnSave_3;
        private Components.MESButton btnDelete_2;
        private Components.MESButton btnNew_2;
        private Components.ButtonBox btnSelection;
        private Components.MESLabel mesLabel9;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESButton btnNew_1;

    }
}
