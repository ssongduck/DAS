using SmartDas.Components;

namespace SmartDas
{
    partial class DA6010
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA6010));
            this.btnConfBox = new SmartDas.Components.ButtonBox();
            this.txtRequestTime = new SmartDas.Components.MESLabel();
            this.mesLabel25 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel28 = new SmartDas.Components.MESLabel();
            this.txtForkliftName = new SmartDas.Components.MESLabel();
            this.txtForkliftCode = new SmartDas.Components.MESLabel();
            this.mesLabel34 = new SmartDas.Components.MESLabel();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.txtRequest = new SmartDas.Components.MESLabel();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.txtDISSStatus = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtmItemname = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtpitemname = new SmartDas.Components.MESLabel();
            this.mesLabel7 = new SmartDas.Components.MESLabel();
            this.mesGrid1 = new SmartDas.Components.MESGrid();
            this.txtDISSCODE = new SmartDas.Components.MESLabel();
            this.txtmItemcode = new SmartDas.Components.MESLabel();
            this.txtpitemcode = new SmartDas.Components.MESLabel();
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
            this.GroupBody.Controls.Add(this.txtpitemcode);
            this.GroupBody.Controls.Add(this.txtmItemcode);
            this.GroupBody.Controls.Add(this.txtDISSCODE);
            this.GroupBody.Controls.Add(this.txtpitemname);
            this.GroupBody.Controls.Add(this.mesLabel7);
            this.GroupBody.Controls.Add(this.txtmItemname);
            this.GroupBody.Controls.Add(this.mesLabel5);
            this.GroupBody.Controls.Add(this.txtDISSStatus);
            this.GroupBody.Controls.Add(this.mesLabel4);
            this.GroupBody.Controls.Add(this.mesLabel3);
            this.GroupBody.Controls.Add(this.txtRequest);
            this.GroupBody.Controls.Add(this.Grid1);
            this.GroupBody.Controls.Add(this.btnConfBox);
            this.GroupBody.Controls.Add(this.txtRequestTime);
            this.GroupBody.Controls.Add(this.mesLabel25);
            this.GroupBody.Controls.Add(this.txtWorkCenterName);
            this.GroupBody.Controls.Add(this.txtWorkCenterCode);
            this.GroupBody.Controls.Add(this.mesLabel28);
            this.GroupBody.Controls.Add(this.txtForkliftName);
            this.GroupBody.Controls.Add(this.txtForkliftCode);
            this.GroupBody.Controls.Add(this.mesLabel34);
            this.GroupBody.Controls.Add(this.mesGrid1);
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
            this.btnConfBox.Location = new System.Drawing.Point(652, 6);
            this.btnConfBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnConfBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnConfBox.Name = "btnConfBox";
            this.btnConfBox.SelectCommand = null;
            this.btnConfBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnConfBox.SelectProcedureName = null;
            this.btnConfBox.Size = new System.Drawing.Size(357, 104);
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
            this.txtRequestTime.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRequestTime.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRequestTime.Location = new System.Drawing.Point(127, 167);
            this.txtRequestTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRequestTime.MoveControl = null;
            this.txtRequestTime.Name = "txtRequestTime";
            this.txtRequestTime.Size = new System.Drawing.Size(368, 50);
            this.txtRequestTime.TabIndex = 124;
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
            this.mesLabel25.Location = new System.Drawing.Point(6, 167);
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(273, 60);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(376, 50);
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
            this.txtWorkCenterCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkCenterCode.Location = new System.Drawing.Point(127, 60);
            this.txtWorkCenterCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterCode.MoveControl = null;
            this.txtWorkCenterCode.Name = "txtWorkCenterCode";
            this.txtWorkCenterCode.Size = new System.Drawing.Size(145, 50);
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
            this.mesLabel28.Location = new System.Drawing.Point(6, 60);
            this.mesLabel28.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel28.MoveControl = null;
            this.mesLabel28.Name = "mesLabel28";
            this.mesLabel28.Size = new System.Drawing.Size(120, 50);
            this.mesLabel28.TabIndex = 120;
            this.mesLabel28.Text = "작업장";
            this.mesLabel28.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel28.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtForkliftName.Location = new System.Drawing.Point(273, 6);
            this.txtForkliftName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtForkliftName.MoveControl = null;
            this.txtForkliftName.Name = "txtForkliftName";
            this.txtForkliftName.Size = new System.Drawing.Size(376, 50);
            this.txtForkliftName.TabIndex = 116;
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
            this.txtForkliftCode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtForkliftCode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtForkliftCode.Location = new System.Drawing.Point(127, 6);
            this.txtForkliftCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtForkliftCode.MoveControl = null;
            this.txtForkliftCode.Name = "txtForkliftCode";
            this.txtForkliftCode.Size = new System.Drawing.Size(145, 50);
            this.txtForkliftCode.TabIndex = 115;
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
            this.mesLabel34.Location = new System.Drawing.Point(6, 6);
            this.mesLabel34.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel34.MoveControl = null;
            this.mesLabel34.Name = "mesLabel34";
            this.mesLabel34.Size = new System.Drawing.Size(120, 50);
            this.mesLabel34.TabIndex = 114;
            this.mesLabel34.Text = "지게차";
            this.mesLabel34.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel34.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.Grid1.Location = new System.Drawing.Point(32, 354);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(416, 169);
            this.Grid1.TabIndex = 141;
            this.Grid1.Visible = false;
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
            this.txtRequest.Location = new System.Drawing.Point(620, 167);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRequest.MoveControl = null;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(388, 50);
            this.txtRequest.TabIndex = 145;
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
            this.mesLabel3.Location = new System.Drawing.Point(498, 167);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(120, 50);
            this.mesLabel3.TabIndex = 146;
            this.mesLabel3.Text = "요청확인시각";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtDISSStatus.Location = new System.Drawing.Point(127, 221);
            this.txtDISSStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDISSStatus.MoveControl = null;
            this.txtDISSStatus.Name = "txtDISSStatus";
            this.txtDISSStatus.Size = new System.Drawing.Size(204, 50);
            this.txtDISSStatus.TabIndex = 148;
            this.txtDISSStatus.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDISSStatus.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel4.Location = new System.Drawing.Point(6, 221);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 147;
            this.mesLabel4.Text = "보급상태";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtmItemname
            // 
            this.txtmItemname.BackColor = System.Drawing.Color.Moccasin;
            this.txtmItemname.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtmItemname.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtmItemname.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtmItemname.ColorContent = System.Drawing.Color.Moccasin;
            this.txtmItemname.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtmItemname.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtmItemname.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtmItemname.Location = new System.Drawing.Point(127, 114);
            this.txtmItemname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmItemname.MoveControl = null;
            this.txtmItemname.Name = "txtmItemname";
            this.txtmItemname.Size = new System.Drawing.Size(368, 50);
            this.txtmItemname.TabIndex = 152;
            this.txtmItemname.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtmItemname.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel5.Location = new System.Drawing.Point(6, 114);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(120, 50);
            this.mesLabel5.TabIndex = 151;
            this.mesLabel5.Text = "품목";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtpitemname
            // 
            this.txtpitemname.BackColor = System.Drawing.Color.Moccasin;
            this.txtpitemname.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtpitemname.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtpitemname.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtpitemname.ColorContent = System.Drawing.Color.Moccasin;
            this.txtpitemname.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtpitemname.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtpitemname.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtpitemname.Location = new System.Drawing.Point(620, 114);
            this.txtpitemname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpitemname.MoveControl = null;
            this.txtpitemname.Name = "txtpitemname";
            this.txtpitemname.Size = new System.Drawing.Size(388, 50);
            this.txtpitemname.TabIndex = 154;
            this.txtpitemname.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtpitemname.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel7.Location = new System.Drawing.Point(498, 114);
            this.mesLabel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel7.MoveControl = null;
            this.mesLabel7.Name = "mesLabel7";
            this.mesLabel7.Size = new System.Drawing.Size(120, 50);
            this.mesLabel7.TabIndex = 153;
            this.mesLabel7.Text = "요청 소재";
            this.mesLabel7.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel7.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesGrid1
            // 
            this.mesGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.mesGrid1.CountRows = 0;
            this.mesGrid1.FixedCols = 0;
            this.mesGrid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesGrid1.FontSize = 15.75F;
            this.mesGrid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.mesGrid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.mesGrid1.HeadString = null;
            this.mesGrid1.Location = new System.Drawing.Point(6, 280);
            this.mesGrid1.Name = "mesGrid1";
            this.mesGrid1.Row = null;
            this.mesGrid1.SelectCommand = null;
            this.mesGrid1.SelectProcedureName = null;
            this.mesGrid1.Size = new System.Drawing.Size(1001, 319);
            this.mesGrid1.TabIndex = 142;
            this.mesGrid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.mesGrid1_GridClick);
            // 
            // txtDISSCODE
            // 
            this.txtDISSCODE.BackColor = System.Drawing.Color.Moccasin;
            this.txtDISSCODE.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtDISSCODE.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDISSCODE.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtDISSCODE.ColorContent = System.Drawing.Color.Moccasin;
            this.txtDISSCODE.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtDISSCODE.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDISSCODE.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtDISSCODE.Location = new System.Drawing.Point(332, 221);
            this.txtDISSCODE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDISSCODE.MoveControl = null;
            this.txtDISSCODE.Name = "txtDISSCODE";
            this.txtDISSCODE.Size = new System.Drawing.Size(163, 50);
            this.txtDISSCODE.TabIndex = 155;
            this.txtDISSCODE.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtDISSCODE.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtDISSCODE.Visible = false;
            // 
            // txtmItemcode
            // 
            this.txtmItemcode.BackColor = System.Drawing.Color.Moccasin;
            this.txtmItemcode.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtmItemcode.BackColor2 = System.Drawing.Color.White;
            this.txtmItemcode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtmItemcode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtmItemcode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtmItemcode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtmItemcode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtmItemcode.Location = new System.Drawing.Point(498, 221);
            this.txtmItemcode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmItemcode.MoveControl = null;
            this.txtmItemcode.Name = "txtmItemcode";
            this.txtmItemcode.Size = new System.Drawing.Size(120, 50);
            this.txtmItemcode.TabIndex = 156;
            this.txtmItemcode.Text = "mitemcode";
            this.txtmItemcode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtmItemcode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtmItemcode.Visible = false;
            // 
            // txtpitemcode
            // 
            this.txtpitemcode.BackColor = System.Drawing.Color.Moccasin;
            this.txtpitemcode.BackColor1 = System.Drawing.Color.LightGreen;
            this.txtpitemcode.BackColor2 = System.Drawing.Color.White;
            this.txtpitemcode.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtpitemcode.ColorContent = System.Drawing.Color.Moccasin;
            this.txtpitemcode.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtpitemcode.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtpitemcode.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtpitemcode.Location = new System.Drawing.Point(619, 221);
            this.txtpitemcode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpitemcode.MoveControl = null;
            this.txtpitemcode.Name = "txtpitemcode";
            this.txtpitemcode.Size = new System.Drawing.Size(120, 50);
            this.txtpitemcode.TabIndex = 157;
            this.txtpitemcode.Text = "pitemcode";
            this.txtpitemcode.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtpitemcode.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtpitemcode.Visible = false;
            // 
            // DA6010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA6010";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA6010_FormClosed);
            this.Load += new System.EventHandler(this.DA6010_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonBox btnConfBox;
        private MESLabel txtRequestTime;
        private MESLabel mesLabel25;
        private MESLabel txtWorkCenterName;
        private MESLabel txtWorkCenterCode;
        private MESLabel mesLabel28;
        private MESLabel txtForkliftName;
        private MESLabel txtForkliftCode;
        private MESLabel mesLabel34;
        private MESGrid Grid1;
        private MESLabel txtRequest;
        private MESLabel mesLabel3;
        private MESLabel txtDISSStatus;
        private MESLabel mesLabel4;
        private MESLabel txtmItemname;
        private MESLabel mesLabel5;
        private MESLabel txtpitemname;
        private MESLabel mesLabel7;
        private MESGrid mesGrid1;
        private MESLabel txtDISSCODE;
        private MESLabel txtpitemcode;
        private MESLabel txtmItemcode;

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
