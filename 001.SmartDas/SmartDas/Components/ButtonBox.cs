using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections.ObjectModel;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace SmartDas.Components
{
    /// <summary>
    /// Button box class
    /// </summary>
    public partial class ButtonBox : UserControl
    {
        #region Variables

        /// <summary>
        /// Count X
        /// </summary>
        private int _CountX = 1;

        /// <summary>
        /// Count Y
        /// </summary>
        private int _CountY = 1;

        /// <summary>
        /// Page
        /// </summary>
        private int _iPage = 0;

        /// <summary>
        /// Max page
        /// </summary>
        private int _MaxPage = 0;

        /// <summary>
        /// Margin In
        /// </summary>
        private Padding _MarginIn;

        /// <summary>
        /// Margin Out
        /// </summary>
        private Padding _MarginOut;

        /// <summary>
        /// Button box type enum
        /// </summary>
        private ButtonBoxTypeEnum _bType;

        /// <summary>
        /// Selection mode enum
        /// </summary>
        private SelectionModeEnum _sMode;

        /// <summary>
        /// Up button
        /// </summary>
        private MESButton _UpButton;

        /// <summary>
        /// Dow button
        /// </summary>
        private MESButton _DownButton;

        /// <summary>
        /// Button list
        /// </summary>
        private List<MESButton> _buttonList = new List<MESButton>();

        /// <summary>
        /// Button data list
        /// </summary>
        private List<ButtonData> _buttonDataList = new List<ButtonData>();

        /// <summary>
        /// Select list
        /// </summary>
        private List<ButtonData> _SelList = new List<ButtonData>();

        /// <summary>
        /// External tag
        /// </summary>
        private string _exTag = string.Empty;

        /// <summary>
        /// Database
        /// </summary>
        Database _Database;

        /// <summary>
        /// Data set
        /// </summary>
        DataSet _DataSet;

        /// <summary>
        /// DB command
        /// </summary>
        private DbCommand _DbCommand;

        /// <summary>
        /// Select string
        /// </summary>
        private string _selectString;

        /// <summary>
        /// DB data adapter
        /// </summary>
        DbDataAdapter _DbDataAdapter;

        /// <summary>
        /// Button event
        /// </summary>
        private bool bButtonEvent = false;

        /// <summary>
        /// Button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ButtonClick(MESButton sender, ButtonClickEventArg e);

        /// <summary>
        /// Button change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ButtonChange(MESButton sender, ButtonClickEventArg e);

        /// <summary>
        /// Button click event
        /// </summary>
        public event ButtonClick buttonClickEvent;

        /// <summary>
        /// Button change event
        /// </summary>
        public event ButtonChange buttonChangeEvent;

        #endregion

        #region Constructors

        /// <summary>
        /// Button box constructor
        /// </summary>
        public ButtonBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            _DataSet = new DataSet();
            _bType = ButtonBoxTypeEnum.Selection;
            _sMode = SelectionModeEnum.Single;
            _MarginIn = new System.Windows.Forms.Padding(3, 3, 3, 3);
            _MarginOut = new System.Windows.Forms.Padding(3, 3, 3, 3);
        }

        #endregion

        #region Events

        /// <summary>
        /// On butto click event
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="e"></param>
        private void OnButtonClickEvent(MESButton btn, ButtonClickEventArg e)
        {
            if (buttonClickEvent != null)
            {
                buttonClickEvent(btn, e);
            }
        }

        /// <summary>
        /// On button change event
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="e"></param>
        private void OnButtonChangeEvent(MESButton btn, ButtonClickEventArg e)
        {
            if (buttonChangeEvent != null)
            {
                buttonChangeEvent(btn, e);
            }
        }

        /// <summary>
        /// Button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (!bButtonEvent)
            {
                bButtonEvent = true;
                MESButton t = (MESButton)sender;
                ButtonData btn = t._ButtonData;

                int ix, iy;

                string[] sArr = t.Name.Split(' ');
                ix = Convert.ToInt32(sArr[1]);
                iy = Convert.ToInt32(sArr[2]);

                ButtonClickEventArg ne = new ButtonClickEventArg(ix, iy);

                switch (_bType)
                {
                    case ButtonBoxTypeEnum.Buttons:
                        OnButtonClickEvent(t, ne);
                        break;
                    case ButtonBoxTypeEnum.Selection:
                        SetSelectButtons(btn);
                        OnButtonChangeEvent(t, ne);
                        break;
                }
                bButtonEvent = false;
            }
        }

        /// <summary>
        /// New button box resize event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewButtonBox_Resize(object sender, EventArgs e)
        {
            RedrawButtons();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set store procedure
        /// </summary>
        public void SetStoreProc()
        {
            if (SelectProcedureName == null)
            {
                throw new Exception("설정된 프로시져가 없습니다.");
            }

            _Database = DatabaseFactory.CreateDatabase();
            _DbDataAdapter = _Database.GetDataAdapter();
            _DbCommand = _Database.GetStoredProcCommand(SelectProcedureName);
        }

        /// <summary>
        /// Do find
        /// </summary>
        public void DoFind()
        {
            try
            {
                if (SelectProcedureName == null)
                {
                    throw new Exception("설정된 프로시져가 없습니다.");
                }

                _DataSet = _Database.ExecuteDataSet(_DbCommand);
                MakeButtons();

                _iPage = 0;
                RedrawButtons();
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// Get button list
        /// </summary>
        /// <returns></returns>
        public List<ButtonData> GetButtonList()
        {
            return _buttonDataList;
        }

        /// <summary>
        /// Get selected buttons
        /// </summary>
        /// <returns></returns>
        public List<ButtonData> GetSelectedButtons()
        {
            return _SelList;
        }

        /// <summary>
        /// Re set selected buttons
        /// </summary>
        public void ReSetSelectedButtons()
        {
            if (_SelList != null)
            {
                foreach (ButtonData buttondata in _SelList)
                {
                    if (buttondata.MappingButton != null)
                    {
                        buttondata.MappingButton._ButtonData = null;
                        buttondata.ButtonPressed = false;
                    }
                }
            }
        }

        /// <summary>
        /// Make buttons
        /// </summary>
        private void MakeButtons()
        {
            try
            {
                int i = 0, j = 0;

                if (_CountX < 1)
                {
                    _CountX = 1;
                }

                if (_CountY < 1)
                {
                    _CountY = 1;
                }

                _buttonList.Clear();
                _SelList.Clear();
                _buttonDataList.Clear();

                for (int x = 0; x < _DataSet.Tables[0].Rows.Count; x++)
                {
                    DataRow dr = _DataSet.Tables[0].Rows[x];

                    string sCode = dr[0].ToString();
                    string sText = dr[1].ToString();
                    string sSel = dr[2].ToString();
                    string sUse = dr[3].ToString();

                    string sExTag = string.Empty;

                    if (_DataSet.Tables[0].Columns.Count >= 5)
                    {
                        sExTag = dr[4].ToString();
                    }

                    ButtonData buttonData = new ButtonData();

                    buttonData.Name = "BtnBox " + i.ToString() + " " + j.ToString();

                    buttonData.Text = sText;
                    buttonData.Tag = sCode;

                    _buttonDataList.Add(buttonData);

                    buttonData.UseFlag = sUse == "Y";
                    buttonData.ButtonPressed = sSel == "Y";
                    buttonData.ExTag = sExTag;

                    if (_DataSet.Tables[0].Columns.Count > 5)
                    {
                        for (int ig = 5; ig < _DataSet.Tables[0].Columns.Count; ig++)
                        {
                            buttonData.SetValue(_DataSet.Tables[0].Columns[ig].ColumnName, clsDB.nvlString(dr[ig]));
                        }
                    }

                    if (j < _CountX - 1)
                    {
                        j++;
                    }
                    else
                    {
                        j = 0;
                        i++;
                    }
                }

                SetButtons();

                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            catch (Exception ex)
            {
                throw ex; 
                
            }
        }

        /// <summary>
        /// Set buttons
        /// </summary>
        public void SetButtons()
        {
            try
            {
                bool bMakeButtonData = false;
                int thisWidth = this.Width;
                int thisHeight = this.Height;

                int pWidth;
                int pHeight;

                if (_CountX < 1)
                {
                    _CountX = 1;
                }

                if (_CountY < 1)
                {
                    _CountY = 1;
                }

                this.Controls.Clear();

                bMakeButtonData = _buttonDataList.Count == 0;

                pWidth = (thisWidth - (_MarginOut.Left + _MarginOut.Right) - ((_CountX - 1) * (_MarginIn.Left + _MarginIn.Right))) / _CountX;
                pHeight = (thisHeight - (_MarginOut.Top + _MarginOut.Bottom) - ((_CountY - 1) * (_MarginIn.Top + _MarginIn.Bottom))) / _CountY;

                for (int i = 0; i < _CountY; i++)
                {
                    for (int j = 0; j < _CountX; j++)
                    {
                        int iLeft = _MarginOut.Left + (j * (_MarginIn.Left + _MarginIn.Right + pWidth));
                        int iTop = _MarginOut.Top + (i * (_MarginIn.Top + _MarginIn.Bottom + pHeight));

                        MESButton mesButton = new MESButton();

                        mesButton.Left = iLeft;
                        mesButton.Top = iTop;
                        mesButton.Width = pWidth;
                        mesButton.Height = pHeight;

                        mesButton.ParentBox = this;
                        mesButton.Name = "BtnBox " + i.ToString() + " " + j.ToString();
                        mesButton.Tag = i.ToString() + " " + j.ToString();

                        mesButton._Click += new EventHandler(Button_Click);

                        if (_bType == ButtonBoxTypeEnum.Selection)
                        {
                            mesButton.ButtonClickType = MESButton.ButtonClickTypeEnum.Change;
                        }
                        else
                        {
                            mesButton.ButtonClickType = MESButton.ButtonClickTypeEnum.Click;
                        }

                        mesButton.Font = this.Font;

                        _buttonList.Add(mesButton);

                        if (bMakeButtonData)
                        {
                            ButtonData buttonData = new ButtonData();
                            buttonData.SetData(mesButton);
                            _buttonDataList.Add(buttonData);
                        }

                        this.Controls.Add(mesButton);
                    }
                }

                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Re draw buttons
        /// </summary>
        public void RedrawButtons()
        {
            int thisWidth = this.Width;
            int thisHeight = this.Height;

            int pWidth;
            int pHeight;

            if (_CountX < 1)
            {
                _CountX = 1;
            }

            if (_CountY < 1)
            {
                _CountY = 1;
            }

            if (_buttonList.Count == 0 && _buttonDataList.Count == 0)
            {
                return;
            }

            pWidth = (thisWidth - (_MarginOut.Left + _MarginOut.Right) - ((_CountX - 1) * (_MarginIn.Left + _MarginIn.Right))) / _CountX;
            pHeight = (thisHeight - (_MarginOut.Top + _MarginOut.Bottom) - ((_CountY - 1) * (_MarginIn.Top + _MarginIn.Bottom))) / _CountY;

            for (int i = 0; i < _CountY; i++)
            {
                for (int j = 0; j < _CountX; j++)
                {
                    ButtonData btn = GetButton(i + (_iPage * _CountY), j);

                    int iLeft = _MarginOut.Left + (j * (_MarginIn.Left + _MarginIn.Right + pWidth));
                    int iTop = _MarginOut.Top + (i * (_MarginIn.Top + _MarginIn.Bottom + pHeight));

                    for (int k = 0; k < this.Controls.Count; k++)
                    {
                        if (Controls[k].Left == iLeft && Controls[k].Top == iTop)
                        {
                            MESButton mesButton = (MESButton)Controls[k];

                            if (btn != null)
                            {
                                mesButton._ButtonData = null;
                                btn.MappingButton = mesButton;

                                mesButton.Tag = btn.Tag;
                                mesButton.Text = btn.Text;
                                mesButton.Name = btn.Name;
                                mesButton.UseFlag = true;
                                mesButton.ButtonPressed = btn.ButtonPressed;
                                mesButton.UseFlag = btn.UseFlag;
                                mesButton.ExTag = btn.ExTag;

                                mesButton._ButtonData = btn;

                                if (btn.bAlarm)
                                {
                                    mesButton.SetAlarmBackColor();
                                }
                                else
                                {
                                    mesButton.SetAlarmBackColor(true);
                                }
                            }
                            else
                            {

                                mesButton.Tag = false;
                                mesButton.Text = "";
                                mesButton._ButtonData = null;
                                mesButton.ButtonPressed = false;
                                mesButton.UseFlag = false;
                            }
                            break;
                        }
                    }
                }
            }

            SetSelectButtons();

            SetUpDownButton();

            return;
        }

        /// <summary>
        /// Page move
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="link"></param>
        /// <param name="iSize"></param>
        public void PageMove(MESButton btn, SmartDas.Components.MESButton.LinkGridButtonType link, int iSize)
        {
            iSize = 1;
            switch (link)
            {
                case MESButton.LinkGridButtonType.Up:
                    _UpButton = btn;

                    if (_iPage - iSize <= 0)
                    {
                        _iPage = 0;
                    }
                    else
                    {
                        _iPage = _iPage - iSize;
                    }

                    RedrawButtons();
                    break;
                case MESButton.LinkGridButtonType.Down:
                    _DownButton = btn;

                    SetMaxPage();
                    if (_iPage + iSize >= _MaxPage)
                    {
                        _iPage = (_MaxPage - 1);
                    }
                    else
                    {
                        _iPage = _iPage + iSize;
                    }

                    RedrawButtons();
                    break;
            }
        }

        /// <summary>
        /// Set up down button
        /// </summary>
        private void SetUpDownButton()
        {
            if (_DownButton != null)
            {
                //DownButton.Enabled =  _iPage + CountY < _MaxPage;
            }

            if (_UpButton != null)
            {
                //UpButton.Enabled = _iPage != 0;
            }
        }

        /// <summary>
        /// Set select buttons
        /// </summary>
        /// <param name="t"></param>
        public void SetSelectButtons(ButtonData buttonData)
        {
            switch (_sMode)
            {
                case SelectionModeEnum.None:
                    buttonData.ButtonPressed = false;
                    RedrawButtons();
                    break;
                case SelectionModeEnum.Single:
                    _SelList.Clear();

                    foreach (ButtonData btn in _buttonDataList)
                    {
                        if (btn.Name != buttonData.Name)
                        {
                            if (btn.ButtonPressed)
                            {
                                if (btn.MappingButton != null)
                                {
                                    btn.MappingButton._ButtonData = null;
                                    btn.ButtonPressed = false;
                                    btn.MappingButton._ButtonData = btn;
                                }
                                else
                                {
                                    btn.ButtonPressed = false;
                                }
                            }
                        }
                        else
                        {
                            btn.MappingButton._ButtonData = null;
                            btn.ButtonPressed = true;
                            btn.MappingButton._ButtonData = btn;
                        }
                    }

                    RedrawButtons();
                    break;
                case SelectionModeEnum.Multiple:
                    _SelList.Clear();
                    foreach (ButtonData me in _buttonDataList)
                    {
                        if (me.ButtonPressed)
                        {
                            _SelList.Add(me);
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// Set select buttons
        /// </summary>
        public void SetSelectButtons()
        {
            _SelList.Clear();

            foreach (ButtonData btn in _buttonDataList)
            {
                if (btn.ButtonPressed)
                {
                    foreach (MESButton b in _buttonList)
                    {
                        if (b.Name == btn.Name)
                        {
                            break;
                        }
                    }

                    _SelList.Add(btn);
                }
            }
        }

        /// <summary>
        /// Get button
        /// </summary>
        /// <param name="ix"></param>
        /// <param name="iy"></param>
        /// <returns></returns>
        private ButtonData GetButton(int ix, int iy)
        {
            int iPoint = (ix * _CountX) + iy;
            int i = 0, t = 0;

            if (_exTag == "")
            {
                return this[ix, iy];
            }

            for (; i < _buttonDataList.Count; i++)
            {
                ButtonData btn = _buttonDataList[i];

                if (btn.ExTag == _exTag)
                {
                    if (iPoint == t)
                    {
                        return btn;
                    }

                    t++;
                }
            }

            return null;
        }

        /// <summary>
        /// Set max page
        /// </summary>
        private void SetMaxPage()
        {
            int t = 0;

            if (_exTag != "")
            {
                for (int i = 0; i < _buttonDataList.Count; i++)
                {
                    ButtonData btn = _buttonDataList[i];

                    if (btn.ExTag == _exTag)
                    {
                        t++;
                    }
                }
            }
            else
            {
                t = _buttonDataList.Count;
            }

            _MaxPage = (int)Math.Ceiling((double)t / (_CountX * _CountY));

            return;
        }

        /// <summary>
        /// Get button by tag
        /// </summary>
        /// <param name="sTag"></param>
        /// <returns></returns>
        public ButtonData GetButtonByTag(string sTag)
        {
            foreach (ButtonData btn in _buttonDataList)
            {
                if (btn.Tag.ToString() == sTag)
                {
                    return btn;
                }
            }

            return null;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Button box type enum
        /// </summary>
        public ButtonBoxTypeEnum ButtonBoxType
        {
            get { return _bType; }
            set { _bType = value; }
        }

        /// <summary>
        /// Selection mode enum
        /// </summary>
        public SelectionModeEnum SelectionMode
        {
            get { return _sMode; }
            set { _sMode = value; }
        }

        /// <summary>
        /// Count x
        /// </summary>
        public int CountX
        {
            get { return _CountX; }
            set
            {
                _CountX = value < 1 ? 1 : value;
            }
        }

        /// <summary>
        /// Count y
        /// </summary>
        public int CountY
        {
            get { return _CountY; }
            set
            {
                _CountY = value < 1 ? 1 : value;
            }
        }

        /// <summary>
        /// Select command
        /// </summary>
        public DbCommand SelectCommand
        {
            get { return _DbCommand; }
            set { _DbCommand = value; }
        }

        /// <summary>
        /// Select procedure name
        /// </summary>
        public string SelectProcedureName
        {
            get { return _selectString; }
            set { _selectString = value; }
        }

        /// <summary>
        /// Parameter list
        /// </summary>
        public DbParameterCollection ParameterList
        {
            get { return _DbCommand.Parameters; }
        }

        /// <summary>
        /// Margin in
        /// </summary>
        public Padding MarginIn
        {
            get { return _MarginIn; }
            set { _MarginIn = value; }
        }

        /// <summary>
        /// Margin out
        /// </summary>
        public Padding MarginOut
        {
            get { return _MarginOut; }
            set { _MarginOut = value; }
        }

        /// <summary>
        /// External tag
        /// </summary>
        public string ExTag
        {
            get { return _exTag; }
            set { _exTag = value; }
        }

        /// <summary>
        /// Button data
        /// </summary>
        /// <param name="ix"></param>
        /// <param name="iy"></param>
        /// <returns></returns>
        public ButtonData this[int ix, int iy]
        {
            get
            {
                string sBtnName = "BtnBox " + ix.ToString() + " " + iy.ToString();

                foreach (ButtonData btn in _buttonDataList)
                {
                    if (btn.Name == sBtnName)
                    {

                        return btn;
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Button data
        /// </summary>
        /// <param name="sButtonName"></param>
        /// <returns></returns>
        public ButtonData this[string sButtonName]
        {
            get
            {
                foreach (ButtonData btn in _buttonDataList)
                {
                    if (btn.Name == sButtonName)
                    {
                        return btn;
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Current page
        /// </summary>
        public int CurrentPage
        {
            set { _iPage = value; }
            get { return _iPage; }
        }

        #endregion

        #region Enum

        /// <summary>
        /// Button box type enum
        /// </summary>
        public enum ButtonBoxTypeEnum
        {
            /// <summary>
            /// 버튼으로 구성
            /// </summary>
            Buttons,
            /// <summary>
            /// 선택 가능한 버튼으로 구성
            /// </summary>
            Selection
        }

        /// <summary>
        /// Selection mode enum
        /// </summary>
        public enum SelectionModeEnum
        {
            /// <summary>
            /// 선택할 수 없음.
            /// </summary>
            None,
            /// <summary>
            /// 하나만 선택할 수 있음.
            /// </summary>
            Single,
            /// <summary>
            /// 여러개를 선택할 수 있음.
            /// </summary>
            Multiple
        }

        #endregion

        /// <summary>
        /// Button click event arg
        /// </summary>
        public class ButtonClickEventArg
        {
            #region Variables

            /// <summary>
            /// X
            /// </summary>
            public int _X;

            /// <summary>
            /// Y
            /// </summary>
            public int _Y;

            #endregion

            #region Constructors

            /// <summary>
            /// Button click event arg constructor
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public ButtonClickEventArg(int x, int y)
            {
                this._X = x;
                this._Y = y;
            }

            #endregion
        }
    }
}
