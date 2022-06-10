namespace SmartDas.POPUP
{
    partial class DA9600
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
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mesLabel1 = new SmartDas.Components.MESLabel();
            this.txtMessage = new SmartDas.Components.MESLabel();
            this.txtRemainQty = new SmartDas.Components.MESLabel();
            this.lblTitle = new SmartDas.Components.MESLabel();
            this.mesLabel8 = new SmartDas.Components.MESLabel();
            this.btnBox = new SmartDas.Components.ButtonBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Checked = true;
            this.radioButtonY.Font = new System.Drawing.Font("휴먼모음T", 15.75F);
            this.radioButtonY.Location = new System.Drawing.Point(205, 53);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(45, 27);
            this.radioButtonY.TabIndex = 100;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "예";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Font = new System.Drawing.Font("휴먼모음T", 15.75F);
            this.radioButtonN.Location = new System.Drawing.Point(278, 53);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(79, 27);
            this.radioButtonN.TabIndex = 101;
            this.radioButtonN.Text = "아니오";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mesLabel1);
            this.panel1.Controls.Add(this.radioButtonN);
            this.panel1.Controls.Add(this.radioButtonY);
            this.panel1.Location = new System.Drawing.Point(5, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 94);
            this.panel1.TabIndex = 102;
            // 
            // mesLabel1
            // 
            this.mesLabel1.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel1.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel1.BackColor2 = System.Drawing.Color.White;
            this.mesLabel1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel1.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel1.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel1.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel1.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel1.Location = new System.Drawing.Point(5, 44);
            this.mesLabel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel1.MoveControl = null;
            this.mesLabel1.Name = "mesLabel1";
            this.mesLabel1.Size = new System.Drawing.Size(177, 50);
            this.mesLabel1.TabIndex = 99;
            this.mesLabel1.Text = "잔량 Lot카드발행";
            this.mesLabel1.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel1.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor1 = System.Drawing.Color.Empty;
            this.txtMessage.BackColor2 = System.Drawing.Color.White;
            this.txtMessage.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtMessage.ColorContent = System.Drawing.Color.White;
            this.txtMessage.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Font = new System.Drawing.Font("휴먼모음T", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMessage.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtMessage.Location = new System.Drawing.Point(0, 85);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMessage.MoveControl = null;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(777, 251);
            this.txtMessage.TabIndex = 98;
            this.txtMessage.TextHAlign = Infragistics.Win.HAlign.Center;
            this.txtMessage.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // txtRemainQty
            // 
            this.txtRemainQty.BackColor = System.Drawing.Color.White;
            this.txtRemainQty.BackColor1 = System.Drawing.Color.Moccasin;
            this.txtRemainQty.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtRemainQty.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.txtRemainQty.ColorContent = System.Drawing.Color.White;
            this.txtRemainQty.ColorReadOnly = System.Drawing.Color.Transparent;
            this.txtRemainQty.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemainQty.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Content;
            this.txtRemainQty.Location = new System.Drawing.Point(188, 340);
            this.txtRemainQty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRemainQty.MoveControl = null;
            this.txtRemainQty.Name = "txtRemainQty";
            this.txtRemainQty.Size = new System.Drawing.Size(177, 50);
            this.txtRemainQty.TabIndex = 97;
            this.txtRemainQty.Text = "999";
            this.txtRemainQty.TextHAlign = Infragistics.Win.HAlign.Right;
            this.txtRemainQty.TextVAlign = Infragistics.Win.VAlign.Middle;
            this.txtRemainQty._Click += new System.EventHandler(this.txtRemainQty_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.BackColor2 = System.Drawing.Color.White;
            this.lblTitle.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.lblTitle.ColorContent = System.Drawing.Color.Moccasin;
            this.lblTitle.ColorReadOnly = System.Drawing.Color.LightGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lblTitle.MoveControl = null;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(777, 85);
            this.lblTitle.TabIndex = 96;
            this.lblTitle.Text = "작업종료";
            this.lblTitle.TextHAlign = Infragistics.Win.HAlign.Center;
            this.lblTitle.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // mesLabel8
            // 
            this.mesLabel8.BackColor = System.Drawing.Color.LightGreen;
            this.mesLabel8.BackColor1 = System.Drawing.Color.LightGreen;
            this.mesLabel8.BackColor2 = System.Drawing.Color.White;
            this.mesLabel8.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
            this.mesLabel8.ColorContent = System.Drawing.Color.Moccasin;
            this.mesLabel8.ColorReadOnly = System.Drawing.Color.Transparent;
            this.mesLabel8.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mesLabel8.LabelType = SmartDas.Components.MESLabel.LabelTypeEnum.Label;
            this.mesLabel8.Location = new System.Drawing.Point(10, 340);
            this.mesLabel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mesLabel8.MoveControl = null;
            this.mesLabel8.Name = "mesLabel8";
            this.mesLabel8.Size = new System.Drawing.Size(177, 50);
            this.mesLabel8.TabIndex = 94;
            this.mesLabel8.Text = "미처리잔량";
            this.mesLabel8.TextHAlign = Infragistics.Win.HAlign.Center;
            this.mesLabel8.TextVAlign = Infragistics.Win.VAlign.Middle;
            // 
            // btnBox
            // 
            this.btnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBox.ButtonBoxType = SmartDas.Components.ButtonBox.ButtonBoxTypeEnum.Buttons;
            this.btnBox.CountX = 1;
            this.btnBox.CountY = 1;
            this.btnBox.CurrentPage = 0;
            this.btnBox.ExTag = "";
            this.btnBox.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBox.Location = new System.Drawing.Point(514, 340);
            this.btnBox.MarginIn = new System.Windows.Forms.Padding(3);
            this.btnBox.MarginOut = new System.Windows.Forms.Padding(3);
            this.btnBox.Name = "btnBox";
            this.btnBox.SelectCommand = null;
            this.btnBox.SelectionMode = SmartDas.Components.ButtonBox.SelectionModeEnum.Single;
            this.btnBox.SelectProcedureName = null;
            this.btnBox.Size = new System.Drawing.Size(263, 100);
            this.btnBox.TabIndex = 2;
            this.btnBox.buttonClickEvent += new SmartDas.Components.ButtonBox.ButtonClick(this.btnBox_buttonClickEvent);
            // 
            // DA9600
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 451);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mesLabel8);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.txtRemainQty);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DA9600";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DA9600";
            this.Load += new System.EventHandler(this.DA9600_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ButtonBox btnBox;
        private Components.MESLabel mesLabel8;
        protected Components.MESLabel lblTitle;
        private Components.MESLabel txtRemainQty;
        private Components.MESLabel txtMessage;
        private Components.MESLabel mesLabel1;
        private System.Windows.Forms.RadioButton radioButtonY;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.Panel panel1;
    }
}