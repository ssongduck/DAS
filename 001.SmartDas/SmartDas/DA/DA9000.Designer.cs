namespace SmartDas
{
    partial class DA9000
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
            this.txtCount = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtIP = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.btnBox = new SmartDas.Components.ButtonBox();
            this.btnSelect = new SmartDas.Components.ButtonBox();
            this.txtPlantCode = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.btnPlantChg = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "단말기 설정";
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkButtonBox = this.btnBox;
            this.btnRightPage.LinkMoveSize = 5;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkButtonBox = this.btnBox;
            this.btnLeftPage.LinkMoveSize = 5;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnPlantChg);
            this.GroupBody.Controls.Add(this.txtPlantCode);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.btnBox);
            this.GroupBody.Controls.Add(this.btnSelect);
            this.GroupBody.Controls.Add(this.txtCount);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtIP);
            this.GroupBody.Controls.Add(this.mesLabel1);
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
            this.btnConfBox.Location = new System.Drawing.Point(685, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(327, 104);
            this.btnConfBox.TabIndex = 10;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.Moccasin;
            this.txtCount.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtCount.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCount.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtCount.ColorContent = System.Drawing.Color.Moccasin;
            this.txtCount.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtCount.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCount.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtCount.Location = new System.Drawing.Point(158, 60);
            this.txtCount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCount.MoveControl = null;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(187, 50);
            this.txtCount.TabIndex = 15;
            this.txtCount.Text = "0";
            this.txtCount.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtCount.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel5.Size = new System.Drawing.Size(150, 50);
            this.mesLabel5.TabIndex = 14;
            this.mesLabel5.Text = "선택 작업장 수";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Moccasin;
            this.txtIP.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtIP.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIP.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtIP.ColorContent = System.Drawing.Color.Moccasin;
            this.txtIP.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtIP.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtIP.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtIP.Location = new System.Drawing.Point(497, 6);
            this.txtIP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIP.MoveControl = null;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(185, 50);
            this.txtIP.TabIndex = 12;
            this.txtIP.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtIP.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel1.Location = new System.Drawing.Point(346, 6);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(150, 50);
            this.mesLabel1.TabIndex = 11;
            this.mesLabel1.Text = "IP Address";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnBox
            // 
            this.btnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnBox.CountX = 2;
            this.btnBox.CountY = 5;
            this.btnBox.CurrentPage = 0;
            this.btnBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBox.ExTag = "";
            this.btnBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBox.Location = new System.Drawing.Point(1, 116);
            this.btnBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox.Name = "btnBox";
            this.btnBox.SelectCommand = null;
            this.btnBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Multiple;
            this.btnBox.SelectProcedureName = null;
            this.btnBox.Size = new System.Drawing.Size(1012, 486);
            this.btnBox.TabIndex = 17;
            this.btnBox.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnBox_buttonChangeEvent);
            this.btnBox.Load += new System.EventHandler(this.btnBox_Load);
            // 
            // btnSelect
            // 
            this.btnSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelect.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Selection;
            this.btnSelect.CountX = 4;
            this.btnSelect.CountY = 1;
            this.btnSelect.CurrentPage = 0;
            this.btnSelect.ExTag = "";
            this.btnSelect.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(346, 60);
            this.btnSelect.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnSelect.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectCommand = null;
            this.btnSelect.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnSelect.SelectProcedureName = null;
            this.btnSelect.Size = new System.Drawing.Size(336, 50);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.buttonChangeEvent += new SmartDas.Components.ButtonBox.ButtonChange(this.btnSelect_buttonChangeEvent);
            // 
            // txtPlantCode
            // 
            this.txtPlantCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtPlantCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtPlantCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPlantCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtPlantCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtPlantCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtPlantCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlantCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtPlantCode.Location = new System.Drawing.Point(158, 6);
            this.txtPlantCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlantCode.MoveControl = null;
            this.txtPlantCode.Name = "txtPlantCode";
            this.txtPlantCode.Size = new System.Drawing.Size(132, 50);
            this.txtPlantCode.TabIndex = 19;
            this.txtPlantCode.Text = "삼기오토모티브";
            this.txtPlantCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtPlantCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtPlantCode._Click += new System.EventHandler(this.txtPlantCode_Click);
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
            this.mesLabel3.Location = new System.Drawing.Point(6, 6);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(150, 50);
            this.mesLabel3.TabIndex = 18;
            this.mesLabel3.Text = "사업장";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnPlantChg
            // 
            this.btnPlantChg.AlarmColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPlantChg.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlantChg.BackColor = System.Drawing.Color.White;
            this.btnPlantChg.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnPlantChg.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnPlantChg.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnPlantChg.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnPlantChg.ButtonPressed = false;
            this.btnPlantChg.ClickBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlantChg.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnPlantChg.ExTag = null;
            this.btnPlantChg.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.btnPlantChg.FontSize = 12F;
            this.btnPlantChg.LinkButtonBox = null;
            this.btnPlantChg.LinkGrid = null;
            this.btnPlantChg.LinkMoveSize = 0;
            this.btnPlantChg.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnPlantChg.Location = new System.Drawing.Point(291, 6);
            this.btnPlantChg.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnPlantChg.Name = "btnPlantChg";
            this.btnPlantChg.ParentBox = null;
            this.btnPlantChg.Size = new System.Drawing.Size(54, 50);
            this.btnPlantChg.TabIndex = 20;
            this.btnPlantChg.Text = "사업장 변경";
            this.btnPlantChg.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnPlantChg.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnPlantChg.UseFlag = true;
            this.btnPlantChg._Click += new System.EventHandler(this.btnPlantChg_Click);
            // 
            // DA9000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "DA9000";
            this.Text = "단말기 설정";
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnConfBox;
        private Components.MESLabel txtCount;
        private Components.MESLabel mesLabel5;
        private Components.MESLabel txtIP;
        private Components.MESLabel mesLabel1;
        private Components.ButtonBox btnBox;
        private Components.MESLabel txtPlantCode;
        private Components.MESLabel mesLabel3;
        private Components.ButtonBox btnSelect;
        private Components.MESButton btnPlantChg;

    }
}
