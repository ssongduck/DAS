namespace SmartDas.Components
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.bgProcess = new System.ComponentModel.BackgroundWorker();
            this.tLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Panelmain = new Infragistics.Win.Misc.UltraPanel();
            this.GroupBody = new Infragistics.Win.Misc.UltraGroupBox();
            this.panelRightButton = new System.Windows.Forms.Panel();
            this.btnRightPage = new SmartDas.Components.MESButton();
            this.panelLeftButton = new System.Windows.Forms.Panel();
            this.btnLeftPage = new SmartDas.Components.MESButton();
            this.PanelRightTitle = new System.Windows.Forms.Panel();
            this.SplitTime = new System.Windows.Forms.SplitContainer();
            this.lblDate = new Infragistics.Win.Misc.UltraLabel();
            this.lblTime = new Infragistics.Win.Misc.UltraLabel();
            this.PanelRightBottom = new System.Windows.Forms.Panel();
            this.lblNetwork = new SmartDas.Components.MESLabel();
            this.PanelLeftTitle = new System.Windows.Forms.Panel();
            this.imgSamkee = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.imgMotonic = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.PanelMainTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new SmartDas.Components.MESLabel();
            this.PanelMainBottom = new System.Windows.Forms.Panel();
            this.lblMessage = new SmartDas.Components.MESLabel();
            this.PanelLeftBottom = new System.Windows.Forms.Panel();
            this.lblMes = new SmartDas.Components.MESLabel();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.EventTimer = new System.Windows.Forms.Timer(this.components);
            this.NetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.Msgtimer = new System.Windows.Forms.Timer(this.components);
            this.tLayoutPanel.SuspendLayout();
            this.Panelmain.ClientArea.SuspendLayout();
            this.Panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).BeginInit();
            this.panelRightButton.SuspendLayout();
            this.panelLeftButton.SuspendLayout();
            this.PanelRightTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitTime)).BeginInit();
            this.SplitTime.Panel1.SuspendLayout();
            this.SplitTime.Panel2.SuspendLayout();
            this.SplitTime.SuspendLayout();
            this.PanelRightBottom.SuspendLayout();
            this.PanelLeftTitle.SuspendLayout();
            this.PanelMainTitle.SuspendLayout();
            this.PanelMainBottom.SuspendLayout();
            this.PanelLeftBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgProcess
            // 
            this.bgProcess.WorkerSupportsCancellation = true;
            this.bgProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgProcess_DoWork);
            // 
            // tLayoutPanel
            // 
            this.tLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tLayoutPanel.ColumnCount = 7;
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tLayoutPanel.Controls.Add(this.Panelmain, 0, 1);
            this.tLayoutPanel.Controls.Add(this.panelRightButton, 6, 0);
            this.tLayoutPanel.Controls.Add(this.panelLeftButton, 0, 0);
            this.tLayoutPanel.Controls.Add(this.PanelRightTitle, 4, 0);
            this.tLayoutPanel.Controls.Add(this.PanelRightBottom, 5, 2);
            this.tLayoutPanel.Controls.Add(this.PanelLeftTitle, 1, 0);
            this.tLayoutPanel.Controls.Add(this.PanelMainTitle, 3, 0);
            this.tLayoutPanel.Controls.Add(this.PanelMainBottom, 2, 2);
            this.tLayoutPanel.Controls.Add(this.PanelLeftBottom, 0, 2);
            this.tLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tLayoutPanel.Name = "tLayoutPanel";
            this.tLayoutPanel.RowCount = 3;
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tLayoutPanel.Size = new System.Drawing.Size(1024, 768);
            this.tLayoutPanel.TabIndex = 0;
            // 
            // Panelmain
            // 
            this.Panelmain.BorderStyle = Infragistics.Win.UIElementBorderStyle.Inset;
            // 
            // Panelmain.ClientArea
            // 
            this.Panelmain.ClientArea.Controls.Add(this.GroupBody);
            this.tLayoutPanel.SetColumnSpan(this.Panelmain, 7);
            this.Panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelmain.Location = new System.Drawing.Point(3, 83);
            this.Panelmain.Name = "Panelmain";
            this.Panelmain.Size = new System.Drawing.Size(1018, 607);
            this.Panelmain.TabIndex = 13;
            // 
            // GroupBody
            // 
            this.GroupBody.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.GroupBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBody.Location = new System.Drawing.Point(0, 0);
            this.GroupBody.Name = "GroupBody";
            this.GroupBody.Size = new System.Drawing.Size(1014, 603);
            this.GroupBody.TabIndex = 0;
            // 
            // panelRightButton
            // 
            this.panelRightButton.Controls.Add(this.btnRightPage);
            this.panelRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightButton.Location = new System.Drawing.Point(957, 3);
            this.panelRightButton.Name = "panelRightButton";
            this.panelRightButton.Size = new System.Drawing.Size(64, 74);
            this.panelRightButton.TabIndex = 11;
            // 
            // btnRightPage
            // 
            this.btnRightPage.AlarmColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRightPage.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRightPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRightPage.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnRightPage.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnRightPage.BackGradientStyle = Infragistics.Win.GradientStyle.Circular;
            this.btnRightPage.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnRightPage.ButtonPressed = false;
            this.btnRightPage.ClickBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRightPage.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnRightPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRightPage.ExTag = null;
            this.btnRightPage.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnRightPage.FontSize = 24F;
            this.btnRightPage.LinkButtonBox = null;
            this.btnRightPage.LinkGrid = null;
            this.btnRightPage.LinkMoveSize = 0;
            this.btnRightPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnRightPage.Location = new System.Drawing.Point(0, 0);
            this.btnRightPage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnRightPage.Name = "btnRightPage";
            this.btnRightPage.ParentBox = null;
            this.btnRightPage.Size = new System.Drawing.Size(64, 74);
            this.btnRightPage.TabIndex = 1;
            this.btnRightPage.Text = "▶";
            this.btnRightPage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnRightPage.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnRightPage.UseFlag = true;
            // 
            // panelLeftButton
            // 
            this.panelLeftButton.Controls.Add(this.btnLeftPage);
            this.panelLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftButton.Location = new System.Drawing.Point(3, 3);
            this.panelLeftButton.Name = "panelLeftButton";
            this.panelLeftButton.Size = new System.Drawing.Size(64, 74);
            this.panelLeftButton.TabIndex = 10;
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.AlarmColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeftPage.AlarmColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeftPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLeftPage.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnLeftPage.BackColor2 = System.Drawing.Color.SkyBlue;
            this.btnLeftPage.BackGradientStyle = Infragistics.Win.GradientStyle.Elliptical;
            this.btnLeftPage.ButtonClickType = SmartDas.Components.MESButton.ButtonClickTypeEnum.Click;
            this.btnLeftPage.ButtonPressed = false;
            this.btnLeftPage.ClickBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLeftPage.ClickBackColor2 = System.Drawing.Color.Empty;
            this.btnLeftPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftPage.ExTag = null;
            this.btnLeftPage.Font = new System.Drawing.Font("휴먼모음T", 24F);
            this.btnLeftPage.FontSize = 24F;
            this.btnLeftPage.LinkButtonBox = null;
            this.btnLeftPage.LinkGrid = null;
            this.btnLeftPage.LinkMoveSize = 0;
            this.btnLeftPage.LinkType = SmartDas.Components.MESButton.LinkGridButtonType.Up;
            this.btnLeftPage.Location = new System.Drawing.Point(0, 0);
            this.btnLeftPage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLeftPage.Name = "btnLeftPage";
            this.btnLeftPage.ParentBox = null;
            this.btnLeftPage.Size = new System.Drawing.Size(64, 74);
            this.btnLeftPage.TabIndex = 1;
            this.btnLeftPage.Text = "◀";
            this.btnLeftPage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.btnLeftPage.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.btnLeftPage.UseFlag = true;
            // 
            // PanelRightTitle
            // 
            this.PanelRightTitle.BackColor = System.Drawing.Color.White;
            this.PanelRightTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelRightTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tLayoutPanel.SetColumnSpan(this.PanelRightTitle, 2);
            this.PanelRightTitle.Controls.Add(this.SplitTime);
            this.PanelRightTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRightTitle.Location = new System.Drawing.Point(783, 3);
            this.PanelRightTitle.Name = "PanelRightTitle";
            this.PanelRightTitle.Size = new System.Drawing.Size(168, 74);
            this.PanelRightTitle.TabIndex = 9;
            // 
            // SplitTime
            // 
            this.SplitTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitTime.IsSplitterFixed = true;
            this.SplitTime.Location = new System.Drawing.Point(0, 0);
            this.SplitTime.Name = "SplitTime";
            this.SplitTime.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitTime.Panel1
            // 
            this.SplitTime.Panel1.Controls.Add(this.lblDate);
            // 
            // SplitTime.Panel2
            // 
            this.SplitTime.Panel2.Controls.Add(this.lblTime);
            this.SplitTime.Size = new System.Drawing.Size(164, 70);
            this.SplitTime.SplitterDistance = 35;
            this.SplitTime.TabIndex = 0;
            // 
            // lblDate
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.lblDate.Appearance = appearance1;
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(164, 35);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "2012-00-00";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.lblTime.Appearance = appearance2;
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(164, 31);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // PanelRightBottom
            // 
            this.tLayoutPanel.SetColumnSpan(this.PanelRightBottom, 2);
            this.PanelRightBottom.Controls.Add(this.lblNetwork);
            this.PanelRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRightBottom.Location = new System.Drawing.Point(908, 696);
            this.PanelRightBottom.Name = "PanelRightBottom";
            this.PanelRightBottom.Size = new System.Drawing.Size(113, 69);
            this.PanelRightBottom.TabIndex = 6;
            // 
            // lblNetwork
            // 
            this.lblNetwork.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNetwork.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.lblNetwork.BackColor2 = System.Drawing.Color.White;
            this.lblNetwork.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblNetwork.ColorContent = System.Drawing.Color.Moccasin;
            this.lblNetwork.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNetwork.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNetwork.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblNetwork.Location = new System.Drawing.Point(0, 0);
            this.lblNetwork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNetwork.MoveControl = null;
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(113, 69);
            this.lblNetwork.TabIndex = 2;
            this.lblNetwork.Text = "네트워크 상태";
            this.lblNetwork.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblNetwork.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // PanelLeftTitle
            // 
            this.PanelLeftTitle.BackColor = System.Drawing.Color.White;
            this.PanelLeftTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLeftTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tLayoutPanel.SetColumnSpan(this.PanelLeftTitle, 2);
            this.PanelLeftTitle.Controls.Add(this.imgSamkee);
            this.PanelLeftTitle.Controls.Add(this.imgMotonic);
            this.PanelLeftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLeftTitle.Location = new System.Drawing.Point(73, 3);
            this.PanelLeftTitle.Name = "PanelLeftTitle";
            this.PanelLeftTitle.Size = new System.Drawing.Size(184, 74);
            this.PanelLeftTitle.TabIndex = 2;
            // 
            // imgSamkee
            // 
            this.imgSamkee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSamkee.BorderShadowColor = System.Drawing.Color.Empty;
            this.imgSamkee.Location = new System.Drawing.Point(18, 14);
            this.imgSamkee.Name = "imgSamkee";
            this.imgSamkee.Size = new System.Drawing.Size(140, 43);
            this.imgSamkee.TabIndex = 2;
            this.imgSamkee.Tag = "SK1";
            this.imgSamkee.Click += new System.EventHandler(this.imgSamkee_Click);
            // 
            // imgMotonic
            // 
            this.imgMotonic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMotonic.BorderShadowColor = System.Drawing.Color.Empty;
            this.imgMotonic.Location = new System.Drawing.Point(18, 14);
            this.imgMotonic.Name = "imgMotonic";
            this.imgMotonic.Size = new System.Drawing.Size(140, 43);
            this.imgMotonic.TabIndex = 1;
            this.imgMotonic.Tag = "SK2";
            this.imgMotonic.Click += new System.EventHandler(this.imgSamkee_Click);
            // 
            // PanelMainTitle
            // 
            this.PanelMainTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PanelMainTitle.Controls.Add(this.lblTitle);
            this.PanelMainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainTitle.Location = new System.Drawing.Point(263, 3);
            this.PanelMainTitle.Name = "PanelMainTitle";
            this.PanelMainTitle.Size = new System.Drawing.Size(514, 74);
            this.PanelMainTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BackColor1 = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.BackColor2 = System.Drawing.Color.White;
            this.lblTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.lblTitle.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lblTitle.MoveControl = null;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "화면 제목";
            this.lblTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // PanelMainBottom
            // 
            this.tLayoutPanel.SetColumnSpan(this.PanelMainBottom, 3);
            this.PanelMainBottom.Controls.Add(this.lblMessage);
            this.PanelMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainBottom.Location = new System.Drawing.Point(84, 696);
            this.PanelMainBottom.Name = "PanelMainBottom";
            this.PanelMainBottom.Size = new System.Drawing.Size(818, 69);
            this.PanelMainBottom.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BackColor1 = System.Drawing.Color.White;
            this.lblMessage.BackColor2 = System.Drawing.Color.White;
            this.lblMessage.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMessage.ColorContent = System.Drawing.Color.White;
            this.lblMessage.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("휴먼모음T", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lblMessage.MoveControl = null;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(818, 69);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextHAlign = Infragistics.Win.HAlign.Left;
            this.lblMessage.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // PanelLeftBottom
            // 
            this.tLayoutPanel.SetColumnSpan(this.PanelLeftBottom, 2);
            this.PanelLeftBottom.Controls.Add(this.lblMes);
            this.PanelLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLeftBottom.Location = new System.Drawing.Point(3, 696);
            this.PanelLeftBottom.Name = "PanelLeftBottom";
            this.PanelLeftBottom.Size = new System.Drawing.Size(75, 69);
            this.PanelLeftBottom.TabIndex = 5;
            // 
            // lblMes
            // 
            this.lblMes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMes.BackColor2 = System.Drawing.Color.MistyRose;
            this.lblMes.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblMes.ColorContent = System.Drawing.Color.Moccasin;
            this.lblMes.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMes.Font = new System.Drawing.Font("휴먼모음T", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMes.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblMes.Location = new System.Drawing.Point(0, 0);
            this.lblMes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblMes.MoveControl = null;
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(75, 69);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "알  림";
            this.lblMes.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblMes.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // EventTimer
            // 
            this.EventTimer.Interval = 1000;
            this.EventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // Msgtimer
            // 
            this.Msgtimer.Interval = 500;
            this.Msgtimer.Tick += new System.EventHandler(this.Msgtimer_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Activated += new System.EventHandler(this.BaseForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.tLayoutPanel.ResumeLayout(false);
            this.Panelmain.ClientArea.ResumeLayout(false);
            this.Panelmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBody)).EndInit();
            this.panelRightButton.ResumeLayout(false);
            this.panelLeftButton.ResumeLayout(false);
            this.PanelRightTitle.ResumeLayout(false);
            this.SplitTime.Panel1.ResumeLayout(false);
            this.SplitTime.Panel1.PerformLayout();
            this.SplitTime.Panel2.ResumeLayout(false);
            this.SplitTime.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitTime)).EndInit();
            this.SplitTime.ResumeLayout(false);
            this.PanelRightBottom.ResumeLayout(false);
            this.PanelLeftTitle.ResumeLayout(false);
            this.PanelMainTitle.ResumeLayout(false);
            this.PanelMainBottom.ResumeLayout(false);
            this.PanelLeftBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutPanel;
        private System.Windows.Forms.Panel PanelRightBottom;
        private System.Windows.Forms.Panel PanelLeftBottom;
        private System.Windows.Forms.Panel PanelLeftTitle;
        private System.Windows.Forms.Panel PanelMainTitle;
        private System.Windows.Forms.Panel PanelMainBottom;
        private System.Windows.Forms.Panel PanelRightTitle;
        private System.Windows.Forms.Timer EventTimer;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Timer NetworkTimer;
        private System.Windows.Forms.Panel panelRightButton;
        private System.Windows.Forms.Panel panelLeftButton;
        private System.Windows.Forms.SplitContainer SplitTime;
        private Infragistics.Win.Misc.UltraLabel lblDate;
        private Infragistics.Win.Misc.UltraLabel lblTime;
        protected MESLabel lblNetwork;
        protected MESLabel lblTitle;
        protected MESLabel lblMessage;
        protected MESLabel lblMes;
        protected MESButton btnRightPage;
        protected MESButton btnLeftPage;
        private Infragistics.Win.Misc.UltraPanel Panelmain;
        protected Infragistics.Win.Misc.UltraGroupBox GroupBody;
        private System.ComponentModel.BackgroundWorker bgProcess;
        private System.Windows.Forms.Timer Msgtimer;
        protected Infragistics.Win.UltraWinEditors.UltraPictureBox imgSamkee;
        protected Infragistics.Win.UltraWinEditors.UltraPictureBox imgMotonic;
    }
}