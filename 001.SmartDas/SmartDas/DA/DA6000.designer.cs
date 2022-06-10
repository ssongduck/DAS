using SmartDas.Components;

namespace SmartDas
{
    partial class DA6000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA6000));
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.txtRequestTime = new SmartDas.Components.MESLabel();
            this.mesLabel25 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel28 = new SmartDas.Components.MESLabel();
            this.txtLadleName = new SmartDas.Components.MESLabel();
            this.txtLadleCode = new SmartDas.Components.MESLabel();
            this.mesLabel31 = new SmartDas.Components.MESLabel();
            this.txtForkliftName = new SmartDas.Components.MESLabel();
            this.txtForkliftCode = new SmartDas.Components.MESLabel();
            this.mesLabel34 = new SmartDas.Components.MESLabel();
            this.bBox1 = new SmartDas.Components.ButtonBox();
            this.txtRequest = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtDISSStatus = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.mesLabel22 = new SmartDas.Components.MESLabel();
            this.txtRemainRate = new SmartDas.Components.MESLabel();
            this.mesLabel20 = new SmartDas.Components.MESLabel();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.btnLiquidTrans = new SmartDas.Components.MESButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "지게차 메인화면";
            // 
            // lblMes
            // 
            this.lblMes._Click += new System.EventHandler(this.lblMes_Click);
            // 
            // btnRightPage
            // 
            this.btnRightPage.LinkMoveSize = 2;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.LinkMoveSize = 2;
            // 
            // GroupBody
            // 
            this.GroupBody.Controls.Add(this.btnLiquidTrans);
            this.GroupBody.Controls.Add(this.Grid1);
            this.GroupBody.Controls.Add(this.txtDISSStatus);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtRequest);
            this.GroupBody.Controls.Add(this.mesLabel1);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.mesLabel20);
            this.GroupBody.Controls.Add(this.txtRemainRate);
            this.GroupBody.Controls.Add(this.mesLabel22);
            this.GroupBody.Controls.Add(this.txtRequestTime);
            this.GroupBody.Controls.Add(this.mesLabel25);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel28);
            this.GroupBody.Controls.Add(this.txtLadleName);
            this.GroupBody.Controls.Add(this.txtLadleCode);
            this.GroupBody.Controls.Add(this.mesLabel31);
            this.GroupBody.Controls.Add(this.txtForkliftName);
            this.GroupBody.Controls.Add(this.txtForkliftCode);
            this.GroupBody.Controls.Add(this.mesLabel34);
            this.GroupBody.Controls.Add(this.bBox1);
            // 
            // imgMotonic
            // 
            this.imgMotonic.Image = ((object)(resources.GetObject("imgMotonic.Image")));
            // 
            // btnConfBox
            // 
            this.btnConfBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnConfBox.CountX = 2;
            this.btnConfBox.CountY = 1;
            this.btnConfBox.CurrentPage = 0;
            this.btnConfBox.ExTag = "";
            this.btnConfBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfBox.Location = new System.Drawing.Point(700, 7);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(314, 105);
            this.btnConfBox.TabIndex = 129;
            this.btnConfBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnConfBox_buttonClickEvent);
            // 
            // txtRequestTime
            // 
            this.txtRequestTime.BackColor = System.Drawing.Color.Moccasin;
            this.txtRequestTime.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtRequestTime.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtRequestTime.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtRequestTime.ColorContent = System.Drawing.Color.Moccasin;
            this.txtRequestTime.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtRequestTime.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRequestTime.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRequestTime.Location = new System.Drawing.Point(124, 117);
            this.txtRequestTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRequestTime.MoveControl = null;
            this.txtRequestTime.Name = "txtRequestTime";
            this.txtRequestTime.Size = new System.Drawing.Size(225, 50);
            this.txtRequestTime.TabIndex = 124;
            this.txtRequestTime.Text = "2013-12-31 24:00:00";
            this.txtRequestTime.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtRequestTime.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel25
            // 
            this.mesLabel25.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel25.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel25.BackColor2 = System.Drawing.Color.White;
            this.mesLabel25.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel25.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel25.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel25.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel25.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel25.Location = new System.Drawing.Point(4, 117);
            this.mesLabel25.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel25.MoveControl = null;
            this.mesLabel25.Name = "mesLabel25";
            this.mesLabel25.Size = new System.Drawing.Size(120, 50);
            this.mesLabel25.TabIndex = 123;
            this.mesLabel25.Text = "보급요청시각";
            this.mesLabel25.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel25.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(211, 62);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(260, 50);
            this.txtWorkCenterName.TabIndex = 122;
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
            this.txtWorkCenterCode.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterCode.Location = new System.Drawing.Point(124, 62);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(86, 50);
            this.txtWorkCenterCode.TabIndex = 121;
            this.txtWorkCenterCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkCenterCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel28
            // 
            this.mesLabel28.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel28.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel28.BackColor2 = System.Drawing.Color.White;
            this.mesLabel28.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel28.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel28.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel28.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel28.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel28.Location = new System.Drawing.Point(4, 62);
            this.mesLabel28.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel28.MoveControl = null;
            this.mesLabel28.Name = "mesLabel28";
            this.mesLabel28.Size = new System.Drawing.Size(120, 50);
            this.mesLabel28.TabIndex = 120;
            this.mesLabel28.Text = "작업장";
            this.mesLabel28.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel28.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtLadleName
            // 
            this.txtLadleName.BackColor = System.Drawing.Color.White;
            this.txtLadleName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLadleName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLadleName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLadleName.ColorContent = System.Drawing.Color.White;
            this.txtLadleName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLadleName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLadleName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLadleName.Location = new System.Drawing.Point(124, 179);
            this.txtLadleName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLadleName.MoveControl = null;
            this.txtLadleName.Name = "txtLadleName";
            this.txtLadleName.Size = new System.Drawing.Size(333, 50);
            this.txtLadleName.TabIndex = 119;
            this.txtLadleName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtLadleName.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtLadleName.Visible = false;
            this.txtLadleName._Click += new System.EventHandler(this.txtLadleCode_Click);
            // 
            // txtLadleCode
            // 
            this.txtLadleCode.BackColor = System.Drawing.Color.White;
            this.txtLadleCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtLadleCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLadleCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtLadleCode.ColorContent = System.Drawing.Color.White;
            this.txtLadleCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtLadleCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLadleCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtLadleCode.Location = new System.Drawing.Point(599, 7);
            this.txtLadleCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLadleCode.MoveControl = null;
            this.txtLadleCode.Name = "txtLadleCode";
            this.txtLadleCode.Size = new System.Drawing.Size(97, 50);
            this.txtLadleCode.TabIndex = 118;
            this.txtLadleCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtLadleCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtLadleCode._Click += new System.EventHandler(this.txtLadleCode_Click);
            // 
            // mesLabel31
            // 
            this.mesLabel31.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel31.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel31.BackColor2 = System.Drawing.Color.White;
            this.mesLabel31.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel31.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel31.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel31.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel31.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel31.Location = new System.Drawing.Point(473, 7);
            this.mesLabel31.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel31.MoveControl = null;
            this.mesLabel31.Name = "mesLabel31";
            this.mesLabel31.Size = new System.Drawing.Size(125, 50);
            this.mesLabel31.TabIndex = 117;
            this.mesLabel31.Text = "래들";
            this.mesLabel31.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel31.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtForkliftName
            // 
            this.txtForkliftName.BackColor = System.Drawing.Color.Moccasin;
            this.txtForkliftName.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtForkliftName.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtForkliftName.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtForkliftName.ColorContent = System.Drawing.Color.Moccasin;
            this.txtForkliftName.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtForkliftName.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtForkliftName.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtForkliftName.Location = new System.Drawing.Point(211, 7);
            this.txtForkliftName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtForkliftName.MoveControl = null;
            this.txtForkliftName.Name = "txtForkliftName";
            this.txtForkliftName.Size = new System.Drawing.Size(260, 50);
            this.txtForkliftName.TabIndex = 116;
            this.txtForkliftName.Text = "액상보급 지게차 1호기";
            this.txtForkliftName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtForkliftName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtForkliftCode
            // 
            this.txtForkliftCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtForkliftCode.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtForkliftCode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtForkliftCode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtForkliftCode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtForkliftCode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtForkliftCode.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtForkliftCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtForkliftCode.Location = new System.Drawing.Point(125, 7);
            this.txtForkliftCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtForkliftCode.MoveControl = null;
            this.txtForkliftCode.Name = "txtForkliftCode";
            this.txtForkliftCode.Size = new System.Drawing.Size(85, 50);
            this.txtForkliftCode.TabIndex = 115;
            this.txtForkliftCode.Text = "9999";
            this.txtForkliftCode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtForkliftCode.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel34
            // 
            this.mesLabel34.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel34.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel34.BackColor2 = System.Drawing.Color.White;
            this.mesLabel34.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel34.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel34.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel34.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel34.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel34.Location = new System.Drawing.Point(4, 7);
            this.mesLabel34.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel34.MoveControl = null;
            this.mesLabel34.Name = "mesLabel34";
            this.mesLabel34.Size = new System.Drawing.Size(120, 50);
            this.mesLabel34.TabIndex = 114;
            this.mesLabel34.Text = "지게차";
            this.mesLabel34.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel34.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // bBox1
            // 
            this.bBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.bBox1.CountX = 6;
            this.bBox1.CountY = 4;
            this.bBox1.CurrentPage = 0;
            this.bBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBox1.ExTag = "";
            this.bBox1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bBox1.Location = new System.Drawing.Point(1, 173);
            this.bBox1.MarginIn = new System.Windows.Forms.Padding(3);
            this.bBox1.MarginOut = new System.Windows.Forms.Padding(3);
            this.bBox1.Name = "bBox1";
            this.bBox1.SelectCommand = null;
            this.bBox1.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.bBox1.SelectProcedureName = null;
            this.bBox1.Size = new System.Drawing.Size(1012, 429);
            this.bBox1.TabIndex = 135;
            this.bBox1.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.bBox1_buttonClickEvent);
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.Color.Moccasin;
            this.txtRequest.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtRequest.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtRequest.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtRequest.ColorContent = System.Drawing.Color.Moccasin;
            this.txtRequest.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtRequest.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRequest.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRequest.Location = new System.Drawing.Point(473, 117);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRequest.MoveControl = null;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(225, 50);
            this.txtRequest.TabIndex = 137;
            this.txtRequest.Text = "2013-12-31 24:00:00";
            this.txtRequest.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtRequest.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel3.Location = new System.Drawing.Point(4, 233);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 138;
            this.mesLabel3.Text = "보급상태";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.mesLabel3.Visible = false;
            // 
            // txtDISSStatus
            // 
            this.txtDISSStatus.BackColor = System.Drawing.Color.Moccasin;
            this.txtDISSStatus.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtDISSStatus.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDISSStatus.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDISSStatus.ColorContent = System.Drawing.Color.Moccasin;
            this.txtDISSStatus.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDISSStatus.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDISSStatus.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDISSStatus.Location = new System.Drawing.Point(124, 233);
            this.txtDISSStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDISSStatus.MoveControl = null;
            this.txtDISSStatus.Name = "txtDISSStatus";
            this.txtDISSStatus.Size = new System.Drawing.Size(333, 50);
            this.txtDISSStatus.TabIndex = 139;
            this.txtDISSStatus.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDISSStatus.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDISSStatus.Visible = false;
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
            this.mesLabel1.Location = new System.Drawing.Point(351, 117);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(120, 50);
            this.mesLabel1.TabIndex = 136;
            this.mesLabel1.Text = "요청확인시각";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel22
            // 
            this.mesLabel22.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel22.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel22.BackColor2 = System.Drawing.Color.White;
            this.mesLabel22.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel22.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel22.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel22.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel22.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel22.Location = new System.Drawing.Point(473, 62);
            this.mesLabel22.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel22.MoveControl = null;
            this.mesLabel22.Name = "mesLabel22";
            this.mesLabel22.Size = new System.Drawing.Size(125, 50);
            this.mesLabel22.TabIndex = 126;
            this.mesLabel22.Text = "잔여량";
            this.mesLabel22.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel22.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtRemainRate
            // 
            this.txtRemainRate.BackColor = System.Drawing.Color.Moccasin;
            this.txtRemainRate.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtRemainRate.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtRemainRate.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtRemainRate.ColorContent = System.Drawing.Color.Moccasin;
            this.txtRemainRate.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtRemainRate.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemainRate.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRemainRate.Location = new System.Drawing.Point(599, 62);
            this.txtRemainRate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRemainRate.MoveControl = null;
            this.txtRemainRate.Name = "txtRemainRate";
            this.txtRemainRate.Size = new System.Drawing.Size(71, 50);
            this.txtRemainRate.TabIndex = 127;
            this.txtRemainRate.Text = "100";
            this.txtRemainRate.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtRemainRate.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel20
            // 
            this.mesLabel20.BackColor = System.Drawing.Color.Moccasin;
            this.mesLabel20.BackColor1 = System.Drawing.Color.Moccasin;
            this.mesLabel20.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesLabel20.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel20.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel20.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel20.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel20.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.mesLabel20.Location = new System.Drawing.Point(669, 62);
            this.mesLabel20.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel20.MoveControl = null;
            this.mesLabel20.Name = "mesLabel20";
            this.mesLabel20.Size = new System.Drawing.Size(27, 50);
            this.mesLabel20.TabIndex = 128;
            this.mesLabel20.Text = "%";
            this.mesLabel20.TextHAlign = Infragistics.Win.HAlign.Left;
            this.mesLabel20.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // Grid1
            // 
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grid1.CountRows = 0;
            this.Grid1.FixedCols = 0;
            this.Grid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.FontSize = 15.75F;
            this.Grid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid1.HeadString = null;
            this.Grid1.Location = new System.Drawing.Point(28, 357);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(420, 104);
            this.Grid1.TabIndex = 140;
            this.Grid1.Visible = false;
            // 
            // btnLiquidTrans
            // 
            this.btnLiquidTrans.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnLiquidTrans.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLiquidTrans.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLiquidTrans.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnLiquidTrans.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnLiquidTrans.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnLiquidTrans.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnLiquidTrans.ButtonPressed = false;
            this.btnLiquidTrans.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnLiquidTrans.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnLiquidTrans.ExTag = null;
            this.btnLiquidTrans.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnLiquidTrans.FontSize = 20F;
            this.btnLiquidTrans.LinkButtonBox = null;
            this.btnLiquidTrans.LinkGrid = null;
            this.btnLiquidTrans.LinkMoveSize = 0;
            this.btnLiquidTrans.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnLiquidTrans.Location = new System.Drawing.Point(700, 117);
            this.btnLiquidTrans.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLiquidTrans.Name = "btnLiquidTrans";
            this.btnLiquidTrans.ParentBox = null;
            this.btnLiquidTrans.Size = new System.Drawing.Size(313, 50);
            this.btnLiquidTrans.TabIndex = 141;
            this.btnLiquidTrans.Text = "액상운송정보 확인";
            this.btnLiquidTrans.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnLiquidTrans.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnLiquidTrans.UseFlag = true;
            this.btnLiquidTrans._Click += new System.EventHandler(this.btnLiquidTrans_Click);
            // 
            // DA6000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA6000";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA6000_FormClosed);
            this.Load += new System.EventHandler(this.DA6000_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonBox bBox1;
        private ButtonBox btnConfBox;
        private MESLabel txtRequestTime;
        private MESLabel mesLabel25;
        private MESLabel txtWorkCenterName;
        private MESLabel txtWorkCenterCode;
        private MESLabel mesLabel28;
        private MESLabel txtLadleName;
        private MESLabel txtLadleCode;
        private MESLabel mesLabel31;
        private MESLabel txtForkliftName;
        private MESLabel txtForkliftCode;
        private MESLabel mesLabel34;
        private MESLabel txtDISSStatus;
        private MESLabel mesLabel3;
        private MESLabel txtRequest;
        private MESLabel mesLabel1;
        private MESLabel mesLabel20;
        private MESLabel txtRemainRate;
        private MESLabel mesLabel22;
        private MESGrid Grid1;
        private MESButton btnLiquidTrans;

        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
        //private Infragistics.Win.Misc.UltraLabel lblDate;
        //private Infragistics.Win.Misc.UltraLabel lblTime;
        //private Infragistics.Win.Misc.UltraGroupBox GroupBody;
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
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
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
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
        //private Infragistics.Win.Misc.UltraLabel lblDate;
        //private Infragistics.Win.Misc.UltraLabel lblTime;
        //private Infragistics.Win.Misc.UltraGroupBox GroupBody;
        //private Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
    }
}
