using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartDas.Components
{
    /// <summary>
    /// Mes button class
    /// </summary>
    [DefaultEvent("Click")]
    public partial class MESButton : UserControl
    {
        #region Variables

        /// <summary>
        /// Mes grid
        /// </summary>
        private MESGrid _MESGrid;

        /// <summary>
        /// Button box
        /// </summary>
        private ButtonBox _ButtonBox;

        /// <summary>
        /// Parent button box
        /// </summary>
        private ButtonBox _parentButtonBox;

        /// <summary>
        /// Link grid button type
        /// </summary>
        private LinkGridButtonType _LinkGridButtonType;

        /// <summary>
        /// Back color1
        /// </summary>
        private Color _BackColor1;

        /// <summary>
        /// Back color2
        /// </summary>
        private Color _BackColor2;

        /// <summary>
        /// Disable back color1
        /// </summary>
        private Color _DisableBackColor1;

        /// <summary>
        /// Disable back color2
        /// </summary>
        private Color _DisableBackColor2;

        /// <summary>
        /// Click back color1
        /// </summary>
        private Color _ClickBackColor1;

        /// <summary>
        /// Click back color2
        /// </summary>
        private Color _ClickBackColor2;

        /// <summary>
        /// Alarm back color1
        /// </summary>
        private Color _AlarmBackColor1;

        /// <summary>
        /// Alarm back color2
        /// </summary>
        private Color _AlarmBackColor2;

        /// <summary>
        /// Button data
        /// </summary>
        public ButtonData _ButtonData;

        /// <summary>
        /// Tag
        /// </summary>
        private object _Tag;

        /// <summary>
        /// Size
        /// </summary>
        private int _iSize;

        /// <summary>
        /// Button press flag
        /// </summary>
        private bool _bPress = false;

        /// <summary>
        /// Use flag
        /// </summary>
        private bool _bUse = true;

        /// <summary>
        /// Initialize flag
        /// </summary>
        public bool _bInit = true;

        /// <summary>
        /// External tag
        /// </summary>
        private string _ExTag;

        /// <summary>
        /// Button event
        /// </summary>
        private bool bButtonEvent = false;

        /// <summary>
        /// Gradient
        /// </summary>
        private Infragistics.Win.GradientStyle _Gradient;

        /// <summary>
        /// Button type
        /// </summary>
        private ButtonClickTypeEnum _ButtonType = ButtonClickTypeEnum.Click;

        /// <summary>
        /// Click event
        /// </summary>
        public new event EventHandler _Click;

        #endregion

        #region Constructors

        /// <summary>
        /// MES button constructor
        /// </summary>
        public MESButton()
        {
            InitializeComponent();
            if (Common.sERPDB.Equals("ERPSVR.SKE_MFG") || Common.sERPDB.Equals("ERPSVR.SKE_SFG"))
            {
                //this.label.Appearance.BackColor = Color.LightSteelBlue;
                this.label.Appearance.BackColor = Color.LightSteelBlue;
                this.label.Appearance.BackColor2 = Color.White;

                _BackColor1 = Color.LightSteelBlue;
                _BackColor2 = Color.White;
            }
            else
            {
                this.label.Appearance.BackColor = Color.LightSkyBlue;
                this.label.Appearance.BackColor2 = Color.SkyBlue;

                _BackColor1 = Color.LightSkyBlue;
                _BackColor2 = Color.SkyBlue;
            }   

            _DisableBackColor1 = panel.Appearance.BackColorDisabled;
            _DisableBackColor2 = panel.Appearance.BackColorDisabled;

            _ClickBackColor1 = Color.FromArgb(255, 255, 128);
            _ClickBackColor1 = Color.FromArgb(255, 255, 192);            

            _AlarmBackColor1 = Color.FromArgb(255, 128, 128);
            _AlarmBackColor2 = Color.FromArgb(255, 192, 192);

            _Gradient = panel.Appearance.BackGradientStyle;
        }

        #endregion

        #region Events

        /// <summary>
        /// Panel mouse down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_bUse)
            {
                if (_ButtonType == ButtonClickTypeEnum.Click)
                {
                    panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Inset;
                    this.label.Appearance.BackColor = _ClickBackColor1;
                    this.label.Appearance.BackColor2 = _ClickBackColor2;

                    panel.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.None;
                }
                else
                {
                    _bPress = !_bPress;
                    if (_ButtonData != null)
                        _ButtonData.ButtonPressed = _bPress;

                    if (_bPress)
                    {
                        panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Inset;
                        this.label.Appearance.BackColor = _ClickBackColor1;
                        this.label.Appearance.BackColor2 = _ClickBackColor2;
                        panel.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.None;
                    }
                    else
                    {
                        panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised;
                        this.label.Appearance.BackColor = _BackColor1;
                        this.label.Appearance.BackColor2 = _BackColor2;
                        panel.Appearance.BackGradientStyle = _Gradient;
                    }
                }
            }
        }

        /// <summary>
        /// Panel mouse up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (_bUse)
            {
                if (_ButtonType == ButtonClickTypeEnum.Click)
                {
                    panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised;
                    this.label.Appearance.BackColor = _BackColor1;
                    this.label.Appearance.BackColor2 = _BackColor2;
                    panel.Appearance.BackGradientStyle = _Gradient;
                }
            }
        }

        /// <summary>
        /// Label click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            if (_bUse)
            {
                if (!bButtonEvent)
                {
                    bButtonEvent = true;

                    if (_Click != null)
                    {
                        _Click(this, e);
                    }

                    if (_MESGrid != null)
                    {
                        _MESGrid.PageMove(this, _LinkGridButtonType, _iSize);
                    }

                    if (_ButtonBox != null)
                    {
                        _ButtonBox.PageMove(this, _LinkGridButtonType, _iSize);
                    }

                    bButtonEvent = false;
                }
            }
        }

        /// <summary>
        /// New MES button font changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMESButton_FontChanged(object sender, EventArgs e)
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
        /// New MES button back color changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMESButton_BackColorChanged(object sender, EventArgs e)
        {
            this.label.Appearance.BackColor = _BackColor1;
            this.label.Appearance.BackColor2 = _BackColor2;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set alarm back color
        /// </summary>
        /// <param name="nInit"></param>
        public void SetAlarmBackColor(bool nInit = false)
        {
            if (_bUse)
            {
                if (nInit)
                {
                    if (panel.BorderStyle != Infragistics.Win.UIElementBorderStyle.Inset)
                    {
                        this.label.Appearance.BackColor = _BackColor1;
                        this.label.Appearance.BackColor2 = _BackColor2;

                        if (_ButtonData != null)
                        {
                            _ButtonData._thisColor = _BackColor1;
                        }
                    }
                }
                else
                {
                    if (panel.BorderStyle != Infragistics.Win.UIElementBorderStyle.Inset)
                    {
                        if (_ButtonData != null)
                        {
                            if (_ButtonData._thisColor != _AlarmBackColor1)
                            {
                                this.label.Appearance.BackColor = _AlarmBackColor1;
                                this.label.Appearance.BackColor2 = _AlarmBackColor2;
                                _ButtonData._thisColor = _AlarmBackColor1;
                            }
                            else
                            {
                                this.label.Appearance.BackColor = _BackColor1;
                                this.label.Appearance.BackColor2 = _BackColor2;
                                _ButtonData._thisColor = _BackColor1;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Back color1
        /// </summary>
        public Color BackColor1
        {
            get { return _BackColor1; }
            set
            {
                this.label.Appearance.BackColor = value;
                _BackColor1 = value;
            }
        }

        /// <summary>
        /// Back color2
        /// </summary>
        public Color BackColor2
        {
            get { return _BackColor2; }
            set
            {
                this.label.Appearance.BackColor2 = value;
                _BackColor2 = value;
            }
        }

        /// <summary>
        /// Click back color1
        /// </summary>
        public Color ClickBackColor1
        {
            get { return _ClickBackColor1; }
            set { _ClickBackColor1 = value; }
        }

        /// <summary>
        /// Click back color2
        /// </summary>
        public Color ClickBackColor2
        {
            get { return _ClickBackColor2; }
            set { _ClickBackColor2 = value; }
        }

        /// <summary>
        /// Alarm color1
        /// </summary>
        public Color AlarmColor1
        {
            get { return _AlarmBackColor1; }
            set { _AlarmBackColor1 = value; }
        }

        /// <summary>
        /// Alarm color2
        /// </summary>
        public Color AlarmColor2
        {
            get { return _AlarmBackColor2; }
            set { _AlarmBackColor2 = value; }
        }

        /// <summary>
        /// Button click type
        /// </summary>
        public ButtonClickTypeEnum ButtonClickType
        {
            get { return _ButtonType; }
            set { _ButtonType = value; }
        }

        /// <summary>
        /// External tag
        /// </summary>
        public string ExTag
        {
            get { return _ExTag; }
            set { _ExTag = value; }
        }

        /// <summary>
        /// Button pressed
        /// </summary>
        public bool ButtonPressed
        {
            get { return _bPress; }
            set
            {
                if (_bUse)
                {
                    _bPress = value;
                    if (_bPress)
                    {
                        panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Inset;
                        this.label.Appearance.BackColor = _ClickBackColor1;
                        this.label.Appearance.BackColor2 = _ClickBackColor2;
                        panel.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom50Bright;
                    }
                    else
                    {
                        panel.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised;
                        this.label.Appearance.BackColor = _BackColor1;
                        this.label.Appearance.BackColor2 = _BackColor2;
                        panel.Appearance.BackGradientStyle = _Gradient;
                    }
                }

                if (_ButtonData != null)
                {
                    _ButtonData.ButtonPressed = value;
                }
            }
        }

        /// <summary>
        /// Use flag
        /// </summary>
        public bool UseFlag
        {
            get { return _bUse; }
            set
            {
                _bUse = value;

                if (!_bPress)
                {
                    if (_bUse)
                    {
                        //this.label.Appearance.BackColor = _ClickBackColor1;
                        //this.label.Appearance.BackColor2 = _ClickBackColor2;
                        panel.Appearance.BackGradientStyle = _Gradient;
                    }
                    else
                    {
                        this.label.Appearance.BackColor = _DisableBackColor1;
                        this.label.Appearance.BackColor2 = _DisableBackColor1;
                        panel.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.None;
                    }
                }

                if (_ButtonData != null)
                {
                    this._ButtonData.UseFlag = value;
                }
            }
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
            set { label.Text = value; }
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

        /// <summary>
        /// Link grid
        /// </summary>
        public MESGrid LinkGrid
        {
            get { return _MESGrid; }
            set { _MESGrid = value; }
        }

        /// <summary>
        /// Link button box
        /// </summary>
        public ButtonBox LinkButtonBox
        {
            get { return _ButtonBox; }
            set { _ButtonBox = value; }
        }

        /// <summary>
        /// Link type
        /// </summary>
        public LinkGridButtonType LinkType
        {
            get { return _LinkGridButtonType; }
            set { _LinkGridButtonType = value; }
        }

        /// <summary>
        /// Link move size
        /// </summary>
        public int LinkMoveSize
        {
            get { return _iSize; }
            set { _iSize = value; }
        }

        /// <summary>
        /// Parent box
        /// </summary>
        public ButtonBox ParentBox
        {
            get { return _parentButtonBox; }
            set { _parentButtonBox = value; }
        }

        /// <summary>
        /// Back gradient style
        /// </summary>
        public Infragistics.Win.GradientStyle BackGradientStyle
        {
            get { return _Gradient; }
            set { _Gradient = value; }
        }

        /// <summary>
        /// Font size
        /// </summary>
        public float FontSize
        {
            get { return this.Font.Size; }
            set
            {
                Font dFont = (Font)(this.Font.Clone());
                this.Font = new Font(dFont.FontFamily, value, dFont.Style);
            }
        }

        #endregion

        #region Enum

        /// <summary>
        /// Button click type enum
        /// </summary>
        public enum ButtonClickTypeEnum
        {
            /// <summary>
            /// 클릭 형태 ( 일반 버튼 )
            /// </summary>
            Click,
            /// <summary>
            /// 변화 없음. ( 종류 변경 )
            /// </summary>
            Change
        }

        /// <summary>
        /// Link grid button type
        /// </summary>
        public enum LinkGridButtonType { Up, Down }

        #endregion
    }
}
