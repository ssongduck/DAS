namespace SmartDas
{
    partial class DA0800
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
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.btnListBox_Stop = new SmartDas.Components.ButtonBox();
            this.btnListBox_StopList = new SmartDas.Components.ButtonBox();
            this.txtStopName = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.btnListDown = new SmartDas.Components.MESButton();
            this.btnListUp = new SmartDas.Components.MESButton();
            this.txtStopCode = new SmartDas.Components.MESLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "비가동 등록";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnListBox_StopList;
            this.btnRightPage.LinkMoveSize = 2;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnListBox_StopList;
            this.btnLeftPage.LinkMoveSize = 2;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.txtStopCode);
            this.GroupBody.Controls.Add(this.btnListDown);
            this.GroupBody.Controls.Add(this.btnListUp);
            this.GroupBody.Controls.Add(this.txtStopName);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.btnListBox_StopList);
            this.GroupBody.Controls.Add(this.btnListBox_Stop);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel1);
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
            this.txtWorkCenterName.TabIndex = 11;
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
            this.txtWorkCenterCode.TabIndex = 10;
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
            this.mesLabel1.TabIndex = 9;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            // btnListBox_Stop
            // 
            this.btnListBox_Stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox_Stop.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox_Stop.CountX = 1;
            this.btnListBox_Stop.CountY = 1;
            this.btnListBox_Stop.CurrentPage = 0;
            this.btnListBox_Stop.ExTag = "";
            this.btnListBox_Stop.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox_Stop.Location = new System.Drawing.Point(6, 116);
            this.btnListBox_Stop.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox_Stop.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox_Stop.Name = "btnListBox_Stop";
            this.btnListBox_Stop.SelectCommand = null;
            this.btnListBox_Stop.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox_Stop.SelectProcedureName = null;
            this.btnListBox_Stop.Size = new System.Drawing.Size(923, 100);
            this.btnListBox_Stop.TabIndex = 19;
            this.btnListBox_Stop.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnListBox_Stop_buttonChangeEvent);
            // 
            // btnListBox_StopList
            // 
            this.btnListBox_StopList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnListBox_StopList.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnListBox_StopList.CountX = 1;
            this.btnListBox_StopList.CountY = 1;
            this.btnListBox_StopList.CurrentPage = 0;
            this.btnListBox_StopList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListBox_StopList.ExTag = "";
            this.btnListBox_StopList.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnListBox_StopList.Location = new System.Drawing.Point(1, 222);
            this.btnListBox_StopList.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnListBox_StopList.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnListBox_StopList.Name = "btnListBox_StopList";
            this.btnListBox_StopList.SelectCommand = null;
            this.btnListBox_StopList.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnListBox_StopList.SelectProcedureName = null;
            this.btnListBox_StopList.Size = new System.Drawing.Size(1012, 380);
            this.btnListBox_StopList.TabIndex = 20;
            this.btnListBox_StopList.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnListBox_ErrorList_buttonChangeEvent);
            // 
            // txtStopName
            // 
            this.txtStopName.BackColor = System.Drawing.Color.Moccasin;
            this.txtStopName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtStopName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtStopName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtStopName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtStopName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtStopName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStopName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtStopName.Location = new System.Drawing.Point(214, 60);
            this.txtStopName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStopName.MoveControl = null;
            this.txtStopName.Name = "txtStopName";
            this.txtStopName.Size = new System.Drawing.Size(468, 50);
            this.txtStopName.TabIndex = 22;
            this.txtStopName.Text = "TEST STOP NAME";
            this.txtStopName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtStopName.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel7.Location = new System.Drawing.Point(6, 60);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 21;
            this.mesLabel7.Text = "비가동";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnListDown
            // 
            this.btnListDown.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnListDown.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListDown.BackColor = System.Drawing.Color.SkyBlue;
            this.btnListDown.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnListDown.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnListDown.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnListDown.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnListDown.ButtonPressed = false;
            this.btnListDown.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnListDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnListDown.ExTag = null;
            this.btnListDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnListDown.FontSize = 20F;
            this.btnListDown.LinkButtonBox = this.btnListBox_Stop;
            this.btnListDown.LinkGrid = null;
            this.btnListDown.LinkMoveSize = 1;
            this.btnListDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnListDown.Location = new System.Drawing.Point(933, 167);
            this.btnListDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnListDown.Name = "btnListDown";
            this.btnListDown.ParentBox = null;
            this.btnListDown.Size = new System.Drawing.Size(74, 49);
            this.btnListDown.TabIndex = 36;
            this.btnListDown.Text = "▼";
            this.btnListDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnListDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnListDown.UseFlag = true;
            // 
            // btnListUp
            // 
            this.btnListUp.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnListUp.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnListUp.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnListUp.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnListUp.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnListUp.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnListUp.ButtonPressed = false;
            this.btnListUp.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnListUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnListUp.ExTag = null;
            this.btnListUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnListUp.FontSize = 20F;
            this.btnListUp.LinkButtonBox = this.btnListBox_Stop;
            this.btnListUp.LinkGrid = null;
            this.btnListUp.LinkMoveSize = 1;
            this.btnListUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnListUp.Location = new System.Drawing.Point(933, 116);
            this.btnListUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnListUp.Name = "btnListUp";
            this.btnListUp.ParentBox = null;
            this.btnListUp.Size = new System.Drawing.Size(74, 49);
            this.btnListUp.TabIndex = 35;
            this.btnListUp.Text = "▲";
            this.btnListUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnListUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnListUp.UseFlag = true;
            // 
            // txtStopCode
            // 
            this.txtStopCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtStopCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtStopCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtStopCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtStopCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtStopCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtStopCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStopCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtStopCode.Location = new System.Drawing.Point(130, 60);
            this.txtStopCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStopCode.MoveControl = null;
            this.txtStopCode.Name = "txtStopCode";
            this.txtStopCode.Size = new System.Drawing.Size(80, 50);
            this.txtStopCode.TabIndex = 37;
            this.txtStopCode.Text = "999-99";
            this.txtStopCode.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtStopCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // DA0800
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA0800";
            this.Text = "불량 내역 등록";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA0800_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MESLabel txtWorkCenterName;
        private Components.MESLabel txtWorkCenterCode;
        private Components.MESLabel mesLabel1;
        private Components.ButtonBox btnConfBox;
        private Components.ButtonBox btnListBox_Stop;
        private Components.ButtonBox btnListBox_StopList;
        private Components.MESLabel txtStopName;
        private Components.MESLabel mesLabel7;
        private Components.MESButton btnListDown;
        private Components.MESButton btnListUp;
        private Components.MESLabel txtStopCode;
    }
}
