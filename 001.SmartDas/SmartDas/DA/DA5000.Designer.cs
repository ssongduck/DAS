using SmartDas.Components;

namespace SmartDas
{
    partial class DA5000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA5000));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid1 = new SmartDas.Components.MESGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mesLabel18 = new SmartDas.Components.MESLabel();
            this.btnIngotDown = new SmartDas.Components.MESButton();
            this.btnIngotUp = new SmartDas.Components.MESButton();
            this.txtIngotQty = new SmartDas.Components.MESLabel();
            this.btnIngotReset = new SmartDas.Components.MESButton();
            this.btnIngotInput = new SmartDas.Components.MESButton();
            this.mesLabel3 = new SmartDas.Components.MESLabel();
            this.btnScrapReset = new SmartDas.Components.MESButton();
            this.btnScrapInput = new SmartDas.Components.MESButton();
            this.txtScrapQty = new SmartDas.Components.MESLabel();
            this.mesLabel10 = new SmartDas.Components.MESLabel();
            this.mesLabel5 = new SmartDas.Components.MESLabel();
            this.txtFurnanceTemp = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterName = new SmartDas.Components.MESLabel();
            this.txtWorkerNames = new SmartDas.Components.MESLabel();
            this.txtWorkerCnt = new SmartDas.Components.MESLabel();
            this.mesLabel4 = new SmartDas.Components.MESLabel();
            this.txtWorkCenterCode = new SmartDas.Components.MESLabel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.bBox1 = new SmartDas.Components.ButtonBox();
            this.sptWeight = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.GroupBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork._Click += new System.EventHandler(this.lblNetwork_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "용해로 메인화면";
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
            // imgMotonic
            // 
            this.imgMotonic.Image = ((object)(resources.GetObject("imgMotonic.Image")));
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
            this.splitContainer1.Panel1.Controls.Add(this.Grid1);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.txtFurnanceTemp);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel8);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterName);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerNames);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkerCnt);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkCenterCode);
            this.splitContainer1.Panel1.Controls.Add(this.mesLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 602);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid1
            // 
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grid1.CountRows = 0;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid1.FixedCols = 0;
            this.Grid1.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.FontSize = 15.75F;
            this.Grid1.GridAutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.None;
            this.Grid1.GridDefaultSelectedBackColor = System.Drawing.Color.Moccasin;
            this.Grid1.HeadString = null;
            this.Grid1.Location = new System.Drawing.Point(0, 172);
            this.Grid1.Name = "Grid1";
            this.Grid1.Row = null;
            this.Grid1.SelectCommand = null;
            this.Grid1.SelectProcedureName = null;
            this.Grid1.Size = new System.Drawing.Size(1012, 176);
            this.Grid1.TabIndex = 0;
            this.Grid1.GridClick += new SmartDas.Components.MESGrid.gridClick(this.Grid1_GridClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 348);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.mesLabel18);
            this.splitContainer2.Panel1.Controls.Add(this.btnIngotDown);
            this.splitContainer2.Panel1.Controls.Add(this.btnIngotUp);
            this.splitContainer2.Panel1.Controls.Add(this.txtIngotQty);
            this.splitContainer2.Panel1.Controls.Add(this.btnIngotReset);
            this.splitContainer2.Panel1.Controls.Add(this.btnIngotInput);
            this.splitContainer2.Panel1.Controls.Add(this.mesLabel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.btnScrapReset);
            this.splitContainer2.Panel2.Controls.Add(this.btnScrapInput);
            this.splitContainer2.Panel2.Controls.Add(this.txtScrapQty);
            this.splitContainer2.Panel2.Controls.Add(this.mesLabel10);
            this.splitContainer2.Panel2.Controls.Add(this.mesLabel5);
            this.splitContainer2.Size = new System.Drawing.Size(1012, 162);
            this.splitContainer2.SplitterDistance = 506;
            this.splitContainer2.TabIndex = 18;
            // 
            // mesLabel18
            // 
            this.mesLabel18.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel18.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel18.BackColor2 = System.Drawing.Color.White;
            this.mesLabel18.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel18.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel18.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel18.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel18.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel18.Location = new System.Drawing.Point(6, 53);
            this.mesLabel18.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel18.MoveControl = null;
            this.mesLabel18.Name = "mesLabel18";
            this.mesLabel18.Size = new System.Drawing.Size(70, 104);
            this.mesLabel18.TabIndex = 137;
            this.mesLabel18.Text = "팔레트 수량  (EA)";
            this.mesLabel18.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel18.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnIngotDown
            // 
            this.btnIngotDown.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnIngotDown.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngotDown.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIngotDown.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnIngotDown.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnIngotDown.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnIngotDown.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnIngotDown.ButtonPressed = false;
            this.btnIngotDown.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnIngotDown.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnIngotDown.ExTag = null;
            this.btnIngotDown.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnIngotDown.FontSize = 20F;
            this.btnIngotDown.LinkButtonBox = null;
            this.btnIngotDown.LinkGrid = null;
            this.btnIngotDown.LinkMoveSize = 1;
            this.btnIngotDown.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Down;
            this.btnIngotDown.Location = new System.Drawing.Point(218, 107);
            this.btnIngotDown.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnIngotDown.Name = "btnIngotDown";
            this.btnIngotDown.ParentBox = null;
            this.btnIngotDown.Size = new System.Drawing.Size(70, 50);
            this.btnIngotDown.TabIndex = 136;
            this.btnIngotDown.Text = "▼";
            this.btnIngotDown.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnIngotDown.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnIngotDown.UseFlag = true;
            this.btnIngotDown._Click += new System.EventHandler(this.btnIngotDown_Click);
            // 
            // btnIngotUp
            // 
            this.btnIngotUp.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnIngotUp.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngotUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIngotUp.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnIngotUp.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnIngotUp.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnIngotUp.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnIngotUp.ButtonPressed = false;
            this.btnIngotUp.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnIngotUp.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnIngotUp.ExTag = null;
            this.btnIngotUp.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnIngotUp.FontSize = 20F;
            this.btnIngotUp.LinkButtonBox = null;
            this.btnIngotUp.LinkGrid = null;
            this.btnIngotUp.LinkMoveSize = 1;
            this.btnIngotUp.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnIngotUp.Location = new System.Drawing.Point(218, 53);
            this.btnIngotUp.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnIngotUp.Name = "btnIngotUp";
            this.btnIngotUp.ParentBox = null;
            this.btnIngotUp.Size = new System.Drawing.Size(70, 50);
            this.btnIngotUp.TabIndex = 135;
            this.btnIngotUp.Text = "▲";
            this.btnIngotUp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnIngotUp.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnIngotUp.UseFlag = true;
            this.btnIngotUp._Click += new System.EventHandler(this.btnIngotUp_Click);
            // 
            // txtIngotQty
            // 
            this.txtIngotQty.BackColor = System.Drawing.Color.White;
            this.txtIngotQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtIngotQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIngotQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtIngotQty.ColorContent = System.Drawing.Color.White;
            this.txtIngotQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtIngotQty.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtIngotQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtIngotQty.Location = new System.Drawing.Point(80, 53);
            this.txtIngotQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIngotQty.MoveControl = null;
            this.txtIngotQty.Name = "txtIngotQty";
            this.txtIngotQty.Size = new System.Drawing.Size(136, 104);
            this.txtIngotQty.TabIndex = 132;
            this.txtIngotQty.Text = "999";
            this.txtIngotQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtIngotQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtIngotQty._Click += new System.EventHandler(this.txtIngotQty_Click);
            // 
            // btnIngotReset
            // 
            this.btnIngotReset.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnIngotReset.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngotReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIngotReset.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnIngotReset.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnIngotReset.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnIngotReset.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnIngotReset.ButtonPressed = false;
            this.btnIngotReset.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnIngotReset.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnIngotReset.ExTag = null;
            this.btnIngotReset.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnIngotReset.FontSize = 20F;
            this.btnIngotReset.LinkButtonBox = null;
            this.btnIngotReset.LinkGrid = null;
            this.btnIngotReset.LinkMoveSize = 0;
            this.btnIngotReset.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnIngotReset.Location = new System.Drawing.Point(290, 53);
            this.btnIngotReset.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnIngotReset.Name = "btnIngotReset";
            this.btnIngotReset.ParentBox = null;
            this.btnIngotReset.Size = new System.Drawing.Size(105, 104);
            this.btnIngotReset.TabIndex = 42;
            this.btnIngotReset.Text = "초기화";
            this.btnIngotReset.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnIngotReset.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnIngotReset.UseFlag = true;
            this.btnIngotReset._Click += new System.EventHandler(this.btnIngotReset_Click);
            // 
            // btnIngotInput
            // 
            this.btnIngotInput.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnIngotInput.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngotInput.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIngotInput.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnIngotInput.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnIngotInput.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnIngotInput.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnIngotInput.ButtonPressed = false;
            this.btnIngotInput.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnIngotInput.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnIngotInput.ExTag = null;
            this.btnIngotInput.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnIngotInput.FontSize = 20F;
            this.btnIngotInput.LinkButtonBox = null;
            this.btnIngotInput.LinkGrid = null;
            this.btnIngotInput.LinkMoveSize = 0;
            this.btnIngotInput.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnIngotInput.Location = new System.Drawing.Point(397, 53);
            this.btnIngotInput.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnIngotInput.Name = "btnIngotInput";
            this.btnIngotInput.ParentBox = null;
            this.btnIngotInput.Size = new System.Drawing.Size(105, 104);
            this.btnIngotInput.TabIndex = 22;
            this.btnIngotInput.Text = "투입";
            this.btnIngotInput.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnIngotInput.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnIngotInput.UseFlag = true;
            this.btnIngotInput._Click += new System.EventHandler(this.btnIngotInput_Click);
            // 
            // mesLabel3
            // 
            this.mesLabel3.BackColor = System.Drawing.Color.Black;
            this.mesLabel3.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel3.BackColor2 = System.Drawing.SystemColors.WindowText;
            this.mesLabel3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel3.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel3.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.mesLabel3.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel3.ForeColor = System.Drawing.Color.White;
            this.mesLabel3.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel3.Location = new System.Drawing.Point(0, 0);
            this.mesLabel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel3.MoveControl = null;
            this.mesLabel3.Name = "mesLabel3";
            this.mesLabel3.Size = new System.Drawing.Size(506, 50);
            this.mesLabel3.TabIndex = 19;
            this.mesLabel3.Text = "인고트(괴)";
            this.mesLabel3.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel3.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnScrapReset
            // 
            this.btnScrapReset.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnScrapReset.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScrapReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnScrapReset.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnScrapReset.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnScrapReset.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnScrapReset.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnScrapReset.ButtonPressed = false;
            this.btnScrapReset.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnScrapReset.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnScrapReset.ExTag = null;
            this.btnScrapReset.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnScrapReset.FontSize = 20F;
            this.btnScrapReset.LinkButtonBox = null;
            this.btnScrapReset.LinkGrid = null;
            this.btnScrapReset.LinkMoveSize = 0;
            this.btnScrapReset.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnScrapReset.Location = new System.Drawing.Point(291, 53);
            this.btnScrapReset.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnScrapReset.Name = "btnScrapReset";
            this.btnScrapReset.ParentBox = null;
            this.btnScrapReset.Size = new System.Drawing.Size(105, 104);
            this.btnScrapReset.TabIndex = 135;
            this.btnScrapReset.Text = "초기화";
            this.btnScrapReset.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnScrapReset.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnScrapReset.UseFlag = true;
            this.btnScrapReset._Click += new System.EventHandler(this.btnScrapReset_Click);
            // 
            // btnScrapInput
            // 
            this.btnScrapInput.AlarmColor1 = System.Drawing.Color.IndianRed;
            this.btnScrapInput.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScrapInput.BackColor = System.Drawing.Color.SkyBlue;
            this.btnScrapInput.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnScrapInput.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnScrapInput.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnScrapInput.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnScrapInput.ButtonPressed = false;
            this.btnScrapInput.ClickBackColor1 = System.Drawing.Color.Yellow;
            this.btnScrapInput.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnScrapInput.ExTag = null;
            this.btnScrapInput.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.btnScrapInput.FontSize = 20F;
            this.btnScrapInput.LinkButtonBox = null;
            this.btnScrapInput.LinkGrid = null;
            this.btnScrapInput.LinkMoveSize = 0;
            this.btnScrapInput.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnScrapInput.Location = new System.Drawing.Point(396, 53);
            this.btnScrapInput.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnScrapInput.Name = "btnScrapInput";
            this.btnScrapInput.ParentBox = null;
            this.btnScrapInput.Size = new System.Drawing.Size(105, 104);
            this.btnScrapInput.TabIndex = 134;
            this.btnScrapInput.Text = "투입";
            this.btnScrapInput.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnScrapInput.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnScrapInput.UseFlag = true;
            this.btnScrapInput._Click += new System.EventHandler(this.btnScrapInput_Click);
            // 
            // txtScrapQty
            // 
            this.txtScrapQty.BackColor = System.Drawing.Color.White;
            this.txtScrapQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtScrapQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtScrapQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtScrapQty.ColorContent = System.Drawing.Color.White;
            this.txtScrapQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtScrapQty.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScrapQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtScrapQty.Location = new System.Drawing.Point(80, 53);
            this.txtScrapQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtScrapQty.MoveControl = null;
            this.txtScrapQty.Name = "txtScrapQty";
            this.txtScrapQty.Size = new System.Drawing.Size(211, 104);
            this.txtScrapQty.TabIndex = 133;
            this.txtScrapQty.Text = "9999.99";
            this.txtScrapQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtScrapQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtScrapQty._Click += new System.EventHandler(this.txtScrapQty_Click);
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
            this.mesLabel10.Location = new System.Drawing.Point(6, 53);
            this.mesLabel10.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel10.MoveControl = null;
            this.mesLabel10.Name = "mesLabel10";
            this.mesLabel10.Size = new System.Drawing.Size(70, 104);
            this.mesLabel10.TabIndex = 24;
            this.mesLabel10.Text = "스크랩 중량 (kg)";
            this.mesLabel10.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel10.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel5
            // 
            this.mesLabel5.BackColor = System.Drawing.Color.Black;
            this.mesLabel5.BackColor1 = System.Drawing.Color.Transparent;
            this.mesLabel5.BackColor2 = System.Drawing.SystemColors.WindowText;
            this.mesLabel5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel5.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel5.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.mesLabel5.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel5.ForeColor = System.Drawing.Color.White;
            this.mesLabel5.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel5.Location = new System.Drawing.Point(0, 0);
            this.mesLabel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel5.MoveControl = null;
            this.mesLabel5.Name = "mesLabel5";
            this.mesLabel5.Size = new System.Drawing.Size(502, 50);
            this.mesLabel5.TabIndex = 20;
            this.mesLabel5.Text = "스크랩";
            this.mesLabel5.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel5.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtFurnanceTemp
            // 
            this.txtFurnanceTemp.BackColor = System.Drawing.Color.Moccasin;
            this.txtFurnanceTemp.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtFurnanceTemp.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtFurnanceTemp.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtFurnanceTemp.ColorContent = System.Drawing.Color.Moccasin;
            this.txtFurnanceTemp.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtFurnanceTemp.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFurnanceTemp.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtFurnanceTemp.Location = new System.Drawing.Point(127, 114);
            this.txtFurnanceTemp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFurnanceTemp.MoveControl = null;
            this.txtFurnanceTemp.Name = "txtFurnanceTemp";
            this.txtFurnanceTemp.Size = new System.Drawing.Size(87, 50);
            this.txtFurnanceTemp.TabIndex = 16;
            this.txtFurnanceTemp.Text = "999";
            this.txtFurnanceTemp.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtFurnanceTemp.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel8.Location = new System.Drawing.Point(6, 114);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(120, 50);
            this.mesLabel8.TabIndex = 15;
            this.mesLabel8.Text = "용탕온도(℃)";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterName.Location = new System.Drawing.Point(215, 6);
            this.txtWorkCenterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkCenterName.MoveControl = null;
            this.txtWorkCenterName.Name = "txtWorkCenterName";
            this.txtWorkCenterName.Size = new System.Drawing.Size(792, 50);
            this.txtWorkCenterName.TabIndex = 9;
            this.txtWorkCenterName.Text = "TEST PLANT NAME";
            this.txtWorkCenterName.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkCenterName.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtWorkerNames
            // 
            this.txtWorkerNames.BackColor = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtWorkerNames.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtWorkerNames.ColorContent = System.Drawing.Color.Moccasin;
            this.txtWorkerNames.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtWorkerNames.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerNames.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtWorkerNames.Location = new System.Drawing.Point(215, 60);
            this.txtWorkerNames.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWorkerNames.MoveControl = null;
            this.txtWorkerNames.Name = "txtWorkerNames";
            this.txtWorkerNames.Size = new System.Drawing.Size(792, 50);
            this.txtWorkerNames.TabIndex = 6;
            this.txtWorkerNames.Text = "정해윤, 채승학, 고국현, 여강기, 차승영";
            this.txtWorkerNames.TextHAlign = Infragistics.Win.HAlign.Left;
            this.txtWorkerNames.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkerCnt.Size = new System.Drawing.Size(87, 50);
            this.txtWorkerCnt.TabIndex = 5;
            this.txtWorkerCnt.Text = "5";
            this.txtWorkerCnt.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtWorkerCnt.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.mesLabel4.Location = new System.Drawing.Point(6, 60);
            this.mesLabel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel4.MoveControl = null;
            this.mesLabel4.Name = "mesLabel4";
            this.mesLabel4.Size = new System.Drawing.Size(120, 50);
            this.mesLabel4.TabIndex = 4;
            this.mesLabel4.Text = "작업자";
            this.mesLabel4.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel4.TextVAlign = Infragistics.Win.VAlign.Middle;
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
            this.txtWorkCenterCode.Size = new System.Drawing.Size(87, 50);
            this.txtWorkCenterCode.TabIndex = 2;
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
            this.mesLabel1.TabIndex = 1;
            this.mesLabel1.Text = "작업장";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // bBox1
            // 
            this.bBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox1.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.bBox1.CountX = 6;
            this.bBox1.CountY = 2;
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
            // 
            // sptWeight
            // 
            this.sptWeight.DataBits = 7;
            this.sptWeight.Parity = System.IO.Ports.Parity.Even;
            this.sptWeight.PortName = "COM2";
            this.sptWeight.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sptWeight_DataReceived);
            // 
            // DA5000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DA5000";
            this.SyncTime = true;
            this.Text = "현장 단말 메인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DA5000_FormClosed);
            this.Load += new System.EventHandler(this.DA5000_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.GroupBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ButtonBox bBox1;
        private MESLabel txtWorkCenterCode;
        private MESLabel mesLabel1;
        private MESGrid Grid1;
        private MESLabel txtWorkerNames;
        private MESLabel txtWorkerCnt;
        private MESLabel mesLabel4;
        private MESLabel txtWorkCenterName;
        private MESLabel txtFurnanceTemp;
        private MESLabel mesLabel8;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MESLabel mesLabel3;
        private MESLabel mesLabel5;
        private MESButton btnIngotInput;
        private MESLabel mesLabel10;
        private MESButton btnIngotReset;
        private MESLabel txtIngotQty;
        private MESButton btnIngotDown;
        private MESButton btnIngotUp;
        private MESLabel mesLabel18;
        private MESButton btnScrapReset;
        private MESButton btnScrapInput;
        private MESLabel txtScrapQty;
        private System.IO.Ports.SerialPort sptWeight;
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
