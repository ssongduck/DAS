namespace SmartDas
{
    partial class DA0210
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
            this.btnListBox = new SmartDas.Components.ButtonBox();
            this.btnDeptCode = new SmartDas.Components.ButtonBox();
            this.btnUp = new SmartDas.Components.MESButton();
            this.btnDown = new SmartDas.Components.MESButton();
            this.txtWorkerName = new SmartDas.Components.MESLabel();
            this.txtWorkerID = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "작업자 선택";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnListBox;
            this.btnRightPage.LinkMoveSize = 5;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnListBox;
            this.btnLeftPage.LinkMoveSize = 5;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.txtWorkerName);
            this.GroupBody.Controls.Add(this.txtWorkerID);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.btnDown);
            this.GroupBody.Controls.Add(this.btnUp);
            this.GroupBody.Controls.Add(this.btnDeptCode);
            this.GroupBody.Controls.Add(this.btnListBox);
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
            this.btnConfBox.Location = new System.Drawing.Point(727, 4);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(280, 102);
            this.btnConfBox.TabIndex = 16;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // btnListBox
            // 
            this.btnListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox.CountX = 1;
            this.btnListBox.CountY = 1;
            this.btnListBox.CurrentPage = 0;
            this.btnListBox.ExTag = "";
            this.btnListBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox.Location = new System.Drawing.Point(6, 229);
            this.btnListBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.SelectCommand = null;
            this.btnListBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox.SelectProcedureName = null;
            this.btnListBox.Size = new System.Drawing.Size(1001, 370);
            this.btnListBox.TabIndex = 17;
            this.btnListBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.bntListBox_buttonChangeEvent);
            // 
            // btnDeptCode
            // 
            this.btnDeptCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDeptCode.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnDeptCode.CountX = 1;
            this.btnDeptCode.CountY = 1;
            this.btnDeptCode.CurrentPage = 0;
            this.btnDeptCode.ExTag = "";
            this.btnDeptCode.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeptCode.Location = new System.Drawing.Point(6, 112);
            this.btnDeptCode.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnDeptCode.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnDeptCode.Name = "btnDeptCode";
            this.btnDeptCode.SelectCommand = null;
            this.btnDeptCode.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnDeptCode.SelectProcedureName = null;
            this.btnDeptCode.Size = new System.Drawing.Size(940, 108);
            this.btnDeptCode.TabIndex = 19;
            this.btnDeptCode.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnDeptCode_buttonChangeEvent);
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
            this.btnUp.ClickBackColor1 = System.Drawing.Color.Empty;
            this.btnUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp.ExTag = null;
            this.btnUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp.FontSize = 20F;
            this.btnUp.LinkButtonBox = null;
            this.btnUp.LinkGrid = null;
            this.btnUp.LinkMoveSize = 0;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(950, 112);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(56, 49);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "▲";
            this.btnUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnUp.UseFlag = true;
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
            this.btnDown.ClickBackColor1 = System.Drawing.Color.Empty;
            this.btnDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown.ExTag = null;
            this.btnDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown.FontSize = 20F;
            this.btnDown.LinkButtonBox = null;
            this.btnDown.LinkGrid = null;
            this.btnDown.LinkMoveSize = 0;
            this.btnDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnDown.Location = new System.Drawing.Point(950, 169);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(56, 49);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "▼";
            this.btnDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown.UseFlag = true;
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerName.Location = new System.Drawing.Point(375, 4);
            this.txtWorkerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerName.MoveControl = null;
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(347, 50);
            this.txtWorkerName.TabIndex = 24;
            this.txtWorkerName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkerID
            // 
            this.txtWorkerID.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerID.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerID.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerID.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerID.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerID.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerID.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerID.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerID.Location = new System.Drawing.Point(178, 4);
            this.txtWorkerID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerID.MoveControl = null;
            this.txtWorkerID.Name = "txtWorkerID";
            this.txtWorkerID.Size = new System.Drawing.Size(187, 50);
            this.txtWorkerID.TabIndex = 23;
            this.txtWorkerID.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerID.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel1.Location = new System.Drawing.Point(9, 4);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(163, 50);
            this.mesLabel1.TabIndex = 22;
            this.mesLabel1.Text = "선택 작업자";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA0210
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0210";
            this.Text = "작업자 선택";
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnListBox;
        private Components.ButtonBox btnConfBox;
        private Components.MESButton btnDown;
        private Components.MESButton btnUp;
        private Components.ButtonBox btnDeptCode;
        private Components.MESLabel txtWorkerName;
        private Components.MESLabel txtWorkerID;
        private Components.MESLabel mesLabel1;
    }
}
