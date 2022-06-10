namespace SmartDas
{
    partial class DA0200
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
            this.txtWorkerList = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.btnListBox = new SmartDas.Components.ButtonBox();
            this.txtWorkerCnt = new SmartDas.Components.MESLabel();
            this.btnDeptCode = new SmartDas.Components.ButtonBox();
            this.btnUp = new SmartDas.Components.MESButton();
            this.btnDown = new SmartDas.Components.MESButton();
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
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.btnDown);
            this.GroupBody.Controls.Add(this.btnUp);
            this.GroupBody.Controls.Add(this.btnDeptCode);
            this.GroupBody.Controls.Add(this.txtWorkerCnt);
            this.GroupBody.Controls.Add(this.btnListBox);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtWorkerList);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            // 
            // txtWorkerList
            // 
            this.txtWorkerList.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerList.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerList.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerList.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerList.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerList.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerList.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerList.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerList.Location = new System.Drawing.Point(214, 60);
            this.txtWorkerList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerList.MoveControl = null;
            this.txtWorkerList.Name = "txtWorkerList";
            this.txtWorkerList.Size = new System.Drawing.Size(474, 50);
            this.txtWorkerList.TabIndex = 15;
            this.txtWorkerList.Text = "정해윤, 채승학, 고국현, 여강기, 차승영";
            this.txtWorkerList.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerList.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel5.Location = new System.Drawing.Point(6, 60);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 14;
            this.mesLabel5.Text = "작업자";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Size = new System.Drawing.Size(474, 50);
            this.txtWorkCenterName.TabIndex = 13;
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
            this.txtWorkCenterCode.Location = new System.Drawing.Point(127, 6);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(86, 50);
            this.txtWorkCenterCode.TabIndex = 12;
            this.txtWorkCenterCode.Text = "9999";
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListBox.ExTag = "";
            this.btnListBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox.Location = new System.Drawing.Point(1, 222);
            this.btnListBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.SelectCommand = null;
            this.btnListBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Multiple;
            this.btnListBox.SelectProcedureName = null;
            this.btnListBox.Size = new System.Drawing.Size(1012, 380);
            this.btnListBox.TabIndex = 17;
            this.btnListBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.bntListBox_buttonChangeEvent);
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
            this.txtWorkerCnt.Location = new System.Drawing.Point(127, 60);
            this.txtWorkerCnt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerCnt.MoveControl = null;
            this.txtWorkerCnt.Name = "txtWorkerCnt";
            this.txtWorkerCnt.Size = new System.Drawing.Size(86, 50);
            this.txtWorkerCnt.TabIndex = 18;
            this.txtWorkerCnt.Text = "5";
            this.txtWorkerCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.btnDeptCode.Location = new System.Drawing.Point(6, 116);
            this.btnDeptCode.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnDeptCode.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnDeptCode.Name = "btnDeptCode";
            this.btnDeptCode.SelectCommand = null;
            this.btnDeptCode.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnDeptCode.SelectProcedureName = null;
            this.btnDeptCode.Size = new System.Drawing.Size(931, 100);
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
            this.btnUp.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnUp.ExTag = null;
            this.btnUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnUp.FontSize = 20F;
            this.btnUp.LinkButtonBox = this.btnDeptCode;
            this.btnUp.LinkGrid = null;
            this.btnUp.LinkMoveSize = 1;
            this.btnUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnUp.Location = new System.Drawing.Point(940, 116);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.ParentBox = null;
            this.btnUp.Size = new System.Drawing.Size(70, 50);
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
            this.btnDown.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnDown.ExTag = null;
            this.btnDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnDown.FontSize = 20F;
            this.btnDown.LinkButtonBox = this.btnDeptCode;
            this.btnDown.LinkGrid = null;
            this.btnDown.LinkMoveSize = 1;
            this.btnDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnDown.Location = new System.Drawing.Point(940, 166);
            this.btnDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.ParentBox = null;
            this.btnDown.Size = new System.Drawing.Size(70, 50);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "▼";
            this.btnDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnDown.UseFlag = true;
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
            this.mesLabel1.TabIndex = 22;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA0200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA0200";
            this.Text = "작업자 선택";
            this.Load += new System.EventHandler(this.DA0200_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtWorkerList;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.ButtonBox btnListBox;
        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtWorkerCnt;
        private Components.MESButton btnDown;
        private Components.MESButton btnUp;
        private Components.ButtonBox btnDeptCode;
        private Components.MESLabel mesLabel1;
    }
}
