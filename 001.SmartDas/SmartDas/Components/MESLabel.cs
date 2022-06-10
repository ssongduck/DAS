using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartDas.Components
{
    /// <summary>
    /// MES label class
    /// </summary>
    [DefaultEvent("Click")]
    public partial class MESLabel : UserControl
    {
        #region Variables

        /// <summary>
        /// Data tag
        /// </summary>
        private object _Tag;

        /// <summary>
        /// Label type
        /// </summary>
        private LabelTypeEnum _LabelType;

        /// <summary>
        /// Drag
        /// </summary>
        private bool _bDrag;

        /// <summary>
        /// Off set
        /// </summary>
        private Point _Offset;

        /// <summary>
        /// Move control
        /// </summary>
        private Control _MoveControl;

        /// <summary>
        /// Click
        /// </summary>
        public new event EventHandler _Click;

        /// <summary>
        /// Label color1
        /// </summary>
        private Color _LabelColor1;

        /// <summary>
        /// Label color2
        /// </summary>
        private Color _LabelColor2;

        /// <summary>
        /// Transparent color
        /// </summary>
        private Color _TransparentColor;

        /// <summary>
        /// Content color
        /// </summary>
        private Color _ContentColor;

        /// <summary>
        /// Set text call back
        /// </summary>
        /// <param name="text"></param>
        private delegate void SetTextCallback(string text);

        /// <summary>
        /// Set color call back
        /// </summary>
        /// <param name="backColor1"></param>
        /// <param name="backColor2"></param>
        private delegate void SetColorCallback(Color backColor1, Color backColor2);

        #endregion

        #region Constructors

        /// <summary>
        /// MES label constructor
        /// </summary>
        public MESLabel()
        {
            InitializeComponent();

            //_LabelColor1 = Color.FromArgb(255, 224, 192);
            _LabelColor2 = Color.White;
            _TransparentColor = Color.Transparent;
            //_ContentColor = Color.Moccasin;

            _ContentColor = Color.Moccasin;

            label.Dock = DockStyle.Fill;

            LabelType = LabelTypeEnum.Label;
        }

        #endregion

        #region Events

        /// <summary>
        /// Label mouse move event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (_MoveControl != null)
            {
                if (_bDrag)
                {
                    _MoveControl.Left = e.X + _MoveControl.Left - _Offset.X;
                    _MoveControl.Top = e.Y + _MoveControl.Top - _Offset.Y;
                }
            }
        }

        /// <summary>
        /// Label mouse up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            if (_MoveControl != null)
            {
                _bDrag = false;
            }
        }

        /// <summary>
        /// Label mouse down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (_MoveControl != null)
            {
                _bDrag = true;
                _Offset = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// Label click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            if (_Click != null)
            {
                _Click(this, e);
            }
        }

        /// <summary>
        /// MES label font changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MESLabel_FontChanged(object sender, EventArgs e)
        {
            label.Font = this.Font;
        }

        /// <summary>
        /// MES label forecolor changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MESLabel_ForeColorChanged(object sender, EventArgs e)
        {
            label.ForeColor = this.ForeColor;
        }

        /// <summary>
        /// MES label back color changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MESLabel_BackColorChanged(object sender, EventArgs e)
        {
            switch (LabelType)
            {
                case LabelTypeEnum.Label:
                    _LabelColor1 = this.label.Appearance.BackColor;
                    _LabelColor2 = this.label.Appearance.BackColor2;
                    break;

                case LabelTypeEnum.Transparent:
                    _TransparentColor = this.BackColor;
                    break;

                case LabelTypeEnum.Content:
                    _ContentColor = this.BackColor;
                    break;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set text
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            if (label.InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(SetText);
                Invoke(callback, new object[] { text });
            }
            else
            {
                label.Text = text;
            }
        }

        /// <summary>
        /// Set color
        /// </summary>
        /// <param name="backColor1"></param>
        /// <param name="backColor2"></param>
        public void SetColor(Color backColor1, Color backColor2)
        {
            if (this.InvokeRequired)
            {
                SetColorCallback callback = new SetColorCallback(SetColor);
                Invoke(callback, new object[] { backColor1, backColor2 });
            }
            else
            {
                this.label.Appearance.BackColor = backColor1;
                this.label.Appearance.BackColor2 = backColor2;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// BackColor
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackColor1
        {
            get
            {
                return this.label.Appearance.BackColor;
            }
            set
            {
                _LabelColor1 = value;
                this.label.Appearance.BackColor = value;
            }
        }

        /// <summary>
        /// BackColor
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackColor2
        {
            get
            {
                return this.label.Appearance.BackColor2;
            }
            set
            {
                _LabelColor2 = value;
                this.label.Appearance.BackColor2 = value;
            }
        }

        /// <summary>
        /// Color read only
        /// </summary>
        public Color ColorReadOnly
        {
            get { return _TransparentColor; }
            set { _TransparentColor = value; }
        }

        /// <summary>
        /// Color content
        /// </summary>
        public Color ColorContent
        {
            get { return _ContentColor; }
            set { _ContentColor = value; }
        }

        /// <summary>
        /// Label type
        /// </summary>
        public LabelTypeEnum LabelType
        {
            get { return _LabelType; }
            set
            {
                _LabelType = value;

                switch (value)
                {
                    case LabelTypeEnum.Label:
                        this.label.Appearance.BackColor = _LabelColor1;
                        this.label.Appearance.BackColor2 = _LabelColor2;
                        BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
                        break;

                    case LabelTypeEnum.Transparent:
                        this.BackColor = _TransparentColor;
                        BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
                        break;

                    case LabelTypeEnum.Content:
                        this.BackColor = _ContentColor;
                        BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
                        break;
                }
            }
        }

        /// <summary>
        /// Back gradient style
        /// </summary>
        public Infragistics.Win.GradientStyle BackGradientStyle
        {
            get { return label.Appearance.BackGradientStyle; }
            set { label.Appearance.BackGradientStyle = value; }
        }

        /// <summary>
        /// Move control
        /// </summary>
        public Control MoveControl
        {
            get { return _MoveControl; }
            set { _MoveControl = value; }
        }

        /// <summary>
        /// Text
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return label.Text; }
            set
            {
                SetText(value);
            }
        }

        /// <summary>
        /// Text VAlign
        /// </summary>
        public Infragistics.Win.VAlign TextVAlign
        {
            get { return label.Appearance.TextVAlign; }
            set { label.Appearance.TextVAlign = value; }
        }

        /// <summary>
        /// Text HAlign
        /// </summary>
        public Infragistics.Win.HAlign TextHAlign
        {
            get { return label.Appearance.TextHAlign; }
            set { label.Appearance.TextHAlign = value; }
        }

        /// <summary>
        /// Tag
        /// </summary>
        public new object Tag
        {
            get { return _Tag; }
            set { _Tag = value; }
        }

        #endregion

        #region Enum

        /// <summary>
        /// Lable type enum
        /// </summary>
        public enum LabelTypeEnum
        {
            Label, Transparent, Content
        }

        #endregion
    }
}
