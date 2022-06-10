using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using Infragistics.Win.UltraWinGrid;
using System.Data.SqlClient;

namespace SmartDas.Components
{
    /// <summary>
    /// MES grid class
    /// </summary>
    [DefaultEvent("GridClick")]
    public partial class MESGrid : UserControl
    {
        #region Variables

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
        /// Db data adapter
        /// </summary>
        private DbDataAdapter _DbDataAdapter;

        /// <summary>
        /// Select string
        /// </summary>
        private string _SelectString;

        /// <summary>
        /// Head
        /// </summary>
        private string _sHead;

        /// <summary>
        /// Up button
        /// </summary>
        private MESButton UpButton;

        /// <summary>
        /// Down button
        /// </summary>
        private MESButton DownButton;

        /// <summary>
        /// Fixed cols
        /// </summary>
        private int _FixedCols;

        /// <summary>
        /// Row count
        /// </summary>
        private int _RowCount;

        /// <summary>
        /// Row
        /// </summary>
        private UltraGridRow _UltraGridRow;

        /// <summary>
        /// Column
        /// </summary>
        private UltraGridColumn _UltraGridColumn;

        /// <summary>
        /// Grid click event
        /// </summary>
        public event gridClick GridClick;

        /// <summary>
        /// Grid click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void gridClick(object sender, GridClickEventArg e);

        #endregion

        #region Constructors

        /// <summary>
        /// MES grid constructor
        /// </summary>
        public MESGrid()
        {
            InitializeComponent();

            _DataSet = new DataSet();            
            Grid.DataSource = _DataSet;
            Grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
        }

        #endregion

        #region Events

        /// <summary>
        /// On grid click event
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private void OnGridClickEvent(object obj, GridClickEventArg e)
        {
            if (GridClick != null)
            {
                GridClick(obj, e);
            }
        }

        /// <summary>
        /// Grid click cell event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_ClickCell(object sender, ClickCellEventArgs e)
        {
            GridClickEventArg gridClickEventArg = new GridClickEventArg(e.Cell);

            _UltraGridRow = gridClickEventArg._UltraGridRow;
            _UltraGridColumn = gridClickEventArg._UltraGridColumn;

            OnGridClickEvent(this, gridClickEventArg);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get grid
        /// </summary>
        public void GetGrid()
        {
            string[] sArr;

            this.BorderStyle = System.Windows.Forms.BorderStyle.None;

            sArr = _sHead.Split('|');

            if (_DataSet.Tables[0].Columns.Count == 0)
            {
                return;
            }

            UltraGridBand ultraGridBand = Grid.DisplayLayout.Bands[0];
            ultraGridBand.Reset();

            for (int i = 0; true; i++)
            {
                string sName = string.Empty;
                string sAlign = string.Empty;
                string sWidth = string.Empty;
                string sName2 = string.Empty;

                if (_DataSet.Tables[0].Columns.Count > i)
                {
                    sName2 = _DataSet.Tables[0].Columns[i] == null ? "" : _DataSet.Tables[0].Columns[i].ColumnName;
                }
                else
                {
                    sName2 = string.Empty;
                }

                if (sArr.Length > i)
                {
                    if (sArr[i] != null)
                    {
                        string[] arr = sArr[i].Split('@');
                        if (arr.Length == 2)
                        {
                            sName = arr[0];

                            string[] arr2 = arr[1].Split('^');

                            if (arr2.Length == 2)
                            {
                                sAlign = arr2[0];
                                sWidth = arr2[1];
                            }
                            else
                            {
                                sAlign = arr[1];
                            }
                        }
                        else
                        {
                            sName = sArr[i];
                            sAlign = "L";
                        }
                    }
                }
                else
                {
                    sName = string.Empty;
                }

                UltraGridColumn ultraGridColumn = ultraGridBand.Columns[i];

                if (sAlign == "C")
                {
                    ultraGridColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
                }
                else if (sAlign == "L")
                {
                    ultraGridColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left;
                }
                else if (sAlign == "R")
                {
                    ultraGridColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                }
                else if (sAlign == "B")
                {
                    ultraGridColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
                    ultraGridColumn.CellAppearance.ImageBackground = Image.FromFile("bt10.jpg");
                }
                else if (sAlign == "H")
                {
                    ultraGridColumn.Hidden = true;
                }
                else
                {
                    ultraGridColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Default;
                }

                ultraGridColumn.Header.Caption = sName == "" ? sName2 : sName;

                if (sWidth != "")
                {
                    ultraGridColumn.Width = Convert.ToInt32(sWidth);
                }

                if ((i < _DataSet.Tables[0].Columns.Count - 1 || i < sArr.Length - 1))
                {
                    continue;
                }

                break;
            }

            for (int i = 0; i < ultraGridBand.Columns.Count; i++)
            {
                UltraGridColumn ugc = ultraGridBand.Columns[i];

                if (i < FixedCols)
                {
                    ugc.CellActivation = Activation.Disabled;
                    ugc.CellAppearance.BackColor = Grid.DisplayLayout.Override.FixedCellAppearance.BackColor;
                    ugc.CellAppearance.TextHAlign = Grid.DisplayLayout.Override.FixedCellAppearance.TextHAlign;
                    ugc.CellAppearance.TextVAlign = Infragistics.Win.VAlign.Default;
                    ugc.CellAppearance.FontData.Bold = Grid.DisplayLayout.Override.FixedCellAppearance.FontData.Bold;
                }
                else
                {
                    ugc.CellActivation = Activation.NoEdit;
                    ugc.CellAppearance.BackColor = Grid.DisplayLayout.Override.CellAppearance.BackColor;
                    ugc.CellAppearance.TextVAlign = Infragistics.Win.VAlign.Default;
                    ugc.CellAppearance.FontData.Bold = Grid.DisplayLayout.Override.CellAppearance.FontData.Bold;
                    ugc.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
                    ugc.CellAppearance.TextTrimming = Infragistics.Win.TextTrimming.EllipsisWord;
                }
            }

            int iHeight;
            iHeight = (Grid.Height - 38) / CountRows;
            Grid.DisplayLayout.Override.DefaultRowHeight = iHeight;
        }

        /// <summary>
        /// Set store procedure
        /// </summary>
        public void GetStoreProcedure()
        {
            if (SelectProcedureName == null)
            {
                throw new Exception("설정된 프로시져가 없습니다.");
            }

            _Database = DatabaseFactory.CreateDatabase();
            _DbDataAdapter = _Database.GetDataAdapter();
            _DbCommand = _Database.GetStoredProcCommand(SelectProcedureName);
        }

        public void SetRowHeight(int iHeight)
        {
            Grid.DisplayLayout.Override.DefaultRowHeight = iHeight;
        }

        /// <summary>
        /// Do find
        /// </summary>
        public void DoFind()
        {
            try
            {
                int iRow;

                if (SelectProcedureName == null)
                {
                    throw new Exception("설정된 프로시져가 없습니다.");
                }

                this.Cursor = Cursors.WaitCursor;

                if (Grid.ActiveRowScrollRegion.FirstRow != null)
                {
                    iRow = Grid.ActiveRowScrollRegion.FirstRow.Index;
                }
                else
                {
                    iRow = 0;
                }

                _DataSet = _Database.ExecuteDataSet(_DbCommand);

                if (_DataSet.Tables.Count >= 2)
                {
                    Grid.DataSource = _DataSet.Tables[1];
                    _sHead = _DataSet.Tables[0].Rows[0][0].ToString();
                    GetGrid();
                }
                else
                {
                    Grid.DataSource = _DataSet;
                    GetGrid();
                }

                if (Grid.Rows.Count > 0)
                {
                    Grid.ActiveRowScrollRegion.FirstRow = Grid.Rows[iRow];
                }

                _UltraGridRow = null;
                _UltraGridColumn = null;

                SetUpDownButton();

                this.Cursor = Cursors.Default;
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.ToString());
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.Cursor = Cursors.Default;

                return;
            }
        }

        /// <summary>
        /// Select first row
        /// </summary>
        /// <param name="row"></param>
        public void SelectFirstRow(UltraGridRow row = null)
        {
            try
            {
                Grid.ActiveRow.Selected = false;

                if (row == null)
                {
                    row = Grid.Rows[0];
                }

                Grid.ActiveRowScrollRegion.FirstRow = row;
                Grid_ClickCell(Grid, new ClickCellEventArgs(row.Cells[0]));
                this.Row.Selected = true;
            }
            catch { }
        }

        public void GridRowAdd()
        {                                            
            //UltraGridRow row = this.Grid.DisplayLayout.Bands[0].AddNew();
            //row.ParentCollection.Move(row, 0);
            //this.Grid.ActiveRowScrollRegion.ScrollRowIntoView(row);
            Grid.DisplayLayout.Bands[0].AddNew();            
        }


        /// <summary>
        /// Page move
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="type"></param>
        /// <param name="iPageMove"></param>
        public void PageMove(MESButton btn, SmartDas.Components.MESButton.LinkGridButtonType type, int iPageMove)
        {
            int iPoint;

            if (Grid != null)
            {
                if (Grid.Rows.Count <= 1)
                {
                    return;
                }
            }
            else
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            switch (type)
            {
                case MESButton.LinkGridButtonType.Down:
                    DownButton = btn;

                    if (Grid.ActiveRowScrollRegion.FirstRow.Index + iPageMove > Grid.Rows.Count - CountRows)
                    {
                        if (Grid.Rows.Count - (CountRows == 0 ? 1 : CountRows) < 0)
                        {
                            iPoint = 0;
                        }
                        else
                        {
                            iPoint = Grid.Rows.Count - (CountRows == 0 ? 1 : CountRows);
                        }
                    }
                    else
                    {
                        iPoint = Grid.ActiveRowScrollRegion.FirstRow.Index + iPageMove;
                        btn.Enabled = true;
                    }

                    Grid.ActiveRowScrollRegion.FirstRow = Grid.Rows[iPoint];
                    SetUpDownButton();
                    break;

                case MESButton.LinkGridButtonType.Up:
                    UpButton = btn;

                    if (Grid.ActiveRowScrollRegion.FirstRow.Index - iPageMove < 0)
                    {
                        iPoint = 0;

                        //btn.Enabled = false;
                    }
                    else
                    {
                        iPoint = Grid.ActiveRowScrollRegion.FirstRow.Index - iPageMove;

                        btn.Enabled = true;
                    }

                    Grid.ActiveRowScrollRegion.FirstRow = Grid.Rows[iPoint];

                    SetUpDownButton();
                    break;
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Set up down button
        /// </summary>
        private void SetUpDownButton()
        {
            if (UpButton != null)
            {
                //UpButton.Enabled = !(Grid.ActiveRowScrollRegion.FirstRow.Index == 0);
            }

            if (DownButton != null)
            {
                //DownButton.Enabled = !(Grid.ActiveRowScrollRegion.FirstRow.Index >= Grid.Rows.Count - CountRows);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Datasource
        /// </summary>
        public DataTable DataSource
        {
            get
            {
                if (_DataSet.Tables.Count >= 2)
                {
                    return _DataSet.Tables[1];
                }
                else if (_DataSet.Tables.Count == 1)
                {
                    return _DataSet.Tables[0];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// DataSet
        /// </summary>
        public DataSet DataSourceDS
        {
            get
            {
                return _DataSet;
            }
        }

        /// <summary>
        /// Head string
        /// </summary>
        public string HeadString
        {
            get { return _sHead; }
            set { _sHead = value; }
        }

        /// <summary>
        /// Grid auto fit style
        /// </summary>
        public AutoFitStyle GridAutoFitStyle
        {
            get { return Grid.DisplayLayout.AutoFitStyle; }
            set { Grid.DisplayLayout.AutoFitStyle = value; }
        }

        /// <summary>
        /// Grid default seleted back color
        /// </summary>
        public Color GridDefaultSelectedBackColor
        {
            get { return Grid.DisplayLayout.DefaultSelectedBackColor; }
            set { Grid.DisplayLayout.DefaultSelectedBackColor = value; }
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
            get { return _SelectString; }
            set { _SelectString = value; }
        }

        /// <summary>
        /// DB parameter collection
        /// </summary>
        public DbParameterCollection ParameterList
        {
            get { return _DbCommand.Parameters; }
        }

        /// <summary>
        /// Cell click action type
        /// </summary>
        public Infragistics.Win.UltraWinGrid.CellClickAction CellClickActionType
        {
            set { Grid.DisplayLayout.Override.CellClickAction = value; }
            get { return Grid.DisplayLayout.Override.CellClickAction; }
        }

        /// <summary>
        /// Fixed cols
        /// </summary>
        public int FixedCols
        {
            get { return _FixedCols; }
            set { _FixedCols = value; }
        }

        /// <summary>
        /// Count rows
        /// </summary>
        public int CountRows
        {
            get { return _RowCount; }
            set { _RowCount = value; }
        }

        /// <summary>
        /// Font size
        /// </summary>
        public float FontSize
        {
            get { return Grid.Font.Size; }
            set
            {
                Font dFont = (Font)(Grid.Font.Clone());
                Grid.Font = new Font(dFont.FontFamily, value, dFont.Style);
            }
        }

        /// <summary>
        /// Row collection
        /// </summary>
        public RowsCollection Rows
        {
            get { return Grid.Rows; }
        }

        /// <summary>
        /// Columns
        /// </summary>
        public ColumnsCollection Columns
        {
            get { return Grid.DisplayLayout.Bands[0].Columns; }
        }

        /// <summary>
        /// Row
        /// </summary>
        public UltraGridRow Row
        {
            get { return _UltraGridRow; }
            set
            {
                Grid.ActiveRow = value;
                _UltraGridRow = Grid.ActiveRow;

            }
        }

        /// <summary>
        /// Column
        /// </summary>
        public UltraGridColumn Col
        {
            get { return _UltraGridColumn; }
        }

        #endregion

        /// <summary>
        /// Grid click event arg
        /// </summary>
        public class GridClickEventArg
        {
            #region Variables

            /// <summary>
            /// Row
            /// </summary>
            public UltraGridRow _UltraGridRow;

            /// <summary>
            /// Column
            /// </summary>
            public UltraGridColumn _UltraGridColumn;

            /// <summary>
            /// Cell
            /// </summary>
            public UltraGridCell _UltraGridCell;

            #endregion

            #region Constructors

            /// <summary>
            /// Gridclick event arg constructor
            /// </summary>
            /// <param name="cell"></param>
            public GridClickEventArg(UltraGridCell cell)
            {
                this._UltraGridCell = cell;
                this._UltraGridRow = cell.Row;
                this._UltraGridColumn = cell.Column;
            }

            #endregion
        }
    }
}