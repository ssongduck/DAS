using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SmartDas.Components;
using SmartDas.POPUP;
using Infragistics.Win.UltraWinGrid;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace SmartDas
{
    public partial class DA0400 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        bool bIsOKBarcode = false;
        bool blnScanRefresh = true;

        public DA0400()
        {
            InitializeComponent();
        }

        private void DA0400_Load(object sender, EventArgs e)
        {
            mesGrid1.Left = 0;//iLeft1;
            mesGrid1.Width = 1014;// itWidth;

            mesGrid2.Left = 0;//iLeft1;
            mesGrid2.Width = 1014;//itWidth;

            SetGrid();

            SetButtons();
            if (DateTime.Now.Hour < 8)
                dtpDate.Value = DateTime.Now.AddHours(-8);

            DoFind2();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtLotNo.Text = "";
            txtQty.Text = "";
            txtLotNo.Focus();


            {
                dtpDate.Enabled = true;

                mesGrid1.Visible = false;
                mesGrid2.Visible = true;

                btnLeftPage.LinkGrid = mesGrid2;
                btnRightPage.LinkGrid = mesGrid2;
                btnLeftPage.LinkMoveSize = mesGrid2.CountRows;
                btnRightPage.LinkMoveSize = mesGrid2.CountRows;
            }
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;
            mesGrid1.CountRows = 10;

            mesGrid1.SelectProcedureName = "USP_DA0400_S1";

            mesGrid2.FontSize = 15;
            mesGrid2.CountRows = 10;

            mesGrid2.SelectProcedureName = "USP_DA0400_S2";
        }

        private void DoFind()
        {
            return;
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));

            mesGrid1.DoFind();
        }

        private void DoFind2()
        {
            mesGrid2.GetStoreProcedure();

            // 조회
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value));
            
            mesGrid2.DoFind();
        }

        /// <summary>
        /// 버튼 생성
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "초기화";
            btnConfBox[0, 1].Text = "등록";
            btnConfBox[0, 2].Text = "닫기";

            btnConfBox.RedrawButtons();

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "현황";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "초기화":
                        Init();
                        break;

                    case "등록":

                        #region 네트워크 테스트
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            CloseProgressForm();
                            return;
                        }
                        #endregion

                        if (bIsOKBarcode && txtLotNo.Text != "" && txtQty.Text != "0" && txtQty.Text != "")
                        {
                            Database db = DatabaseFactory.CreateDatabase();
                            SqlConnection conn = (SqlConnection)db.CreateConnection();
                            SqlCommand cmd = new SqlCommand();

                            cmd.Connection = conn;
                            cmd.CommandText = "[USP_PDA410_I1]";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@WorkCenterName", wc.Name));
                            cmd.Parameters.Add(new SqlParameter("@ItemCode", txtItemCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@ItemName", txtItemName.Text));
                            cmd.Parameters.Add(new SqlParameter("@Maker", "MES_TM"));
                            cmd.Parameters.Add(new SqlParameter("@LotNo", txtLotNo.Text));
                            cmd.Parameters.Add(new SqlParameter("@ProdQty", txtQty.Text));
                            cmd.Parameters.Add(new SqlParameter("@FromWorkCenterName", ""));
                            SqlParameter ERRMSG = cmd.Parameters.Add(new SqlParameter("@ERRMSG", SqlDbType.VarChar, 255));
                            ERRMSG.Direction = ParameterDirection.Output;
                            SqlParameter ERRCODE = cmd.Parameters.Add(new SqlParameter("@ERRCODE", SqlDbType.VarChar, 255));
                            ERRCODE.Direction = ParameterDirection.Output;

                            if (!clsDB.gExecuteProcedure(conn, cmd))
                            {
                                SetMessage(clsDB.ErrorDesc);

                                CloseProgressForm();
                                return;
                            }
                            if (clsDB.nvlInt(cmd.Parameters["@ERRCODE"].Value) == 1)
                            {
                                SetMessage(clsDB.nvlString(cmd.Parameters["@ERRMSG"].Value));

                                CloseProgressForm();
                                return;

                            }

                            txtLotNo.Text = "";
                            txtItemCode.Text = "";
                            txtItemName.Text = "";
                            txtQty.Text = "";

                            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
                            DoFind2();

                            SetMessage("정상적으로 처리 되었습니다.");

                        }
                        else
                        {
                            SetMessage("바코드를 확인하세요.");
                        }
                        break;

                    case "닫기":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }
        #region 모토닉 - 바코드분할로직
        //private void BarcodeCheck(string[] sArr)
        //{
        //    DoProgress();

        //    bIsOKBarcode = false;


        //    if (!bUseNetwork)
        //    {
        //        SetMessage("C:S00018");
        //        ClosePrgForm();
        //        return;
        //    }

        //    switch (sArr[0])
        //    {
        //        case "M":
        //            //M|820|1234|13395-08007K|12J30|업체LOT|100|1
        //            if (sArr.Length != 8)
        //            {
        //                SetMessage("자재 바코드를 확인하세요.");
        //                ClosePrgForm();
        //                return;
        //            }
        //            // 1 : PlantCode, 2 : 업체코드, 3 : 품번, 4 : 입고LOT, 5 : 업체LOT, 6 : 수량, 7 : 순번
        //            txtItemCode.Text = sArr[3];
        //            txtQty.Text = sArr[6];
        //            txtQty.Tag = sArr[6];
        //            txtLotNo.Text = sArr[4] + "-" + sArr[7].PadLeft(3, '0');

        //            SetMessage("작업 가능한 바코드입니다.");
        //            sCode = "M";
        //            bIsOKBarcode = true;
        //            break;
        //        case "P":
        //            ////P|820|2007K180|12J30-001
        //            //if ( sArr.Length != 4 )
        //            //{
        //            //    SetMessage("제품 바코드는 구분자가 3개 있어야 합니다.");
        //            //    ClosePrgForm();
        //            //    return;
        //            //}
        //            DataTable dt = new DataTable();

        //            string sSQL;

        //            Database db = DatabaseFactory.CreateDatabase();
        //            SqlConnection dconn = (SqlConnection)db.CreateConnection();

        //            sSQL = "";
        //            sSQL += "select NowQty  FROM TPP0501 " + "\n";
        //            sSQL += "   where PlantCode = '" + sArr[1] + "' " + "\n";
        //            sSQL += "     and ItemCode = '" + sArr[2] + "' " + "\n";
        //            sSQL += "     and LotNo = '" + sArr[3] + "' " + "\n";

        //            SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand(sSQL);
        //            cmd.Connection = dconn;

        //            cmd.CommandType = CommandType.Text;

        //            cmd.CommandText = sSQL;

        //            if (clsDB.gCreateRSet(cmd, dt))
        //            {
        //                if (dt.Rows.Count > 0)
        //                {
        //                    txtItemCode.Text = sArr[2];
        //                    txtLotNo.Text = sArr[3];
        //                    txtQty.Text = dt.Rows[0]["NowQty"].ToString();
        //                    txtQty.Tag = dt.Rows[0]["NowQty"].ToString();
        //                }
        //                else
        //                {
        //                    SetMessage("재공정보가 없습니다.");
        //                    ClosePrgForm();
        //                    bIsOKBarcode = false;
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                SetMessage(clsDB.ErrorDesc);
        //                ClosePrgForm();
        //                bIsOKBarcode = false;
        //                return;
        //            }

        //            SetMessage("작업 가능한 바코드입니다.");
        //            sCode = "P";
        //            bIsOKBarcode = true;
        //            break;
        //        default:
        //            SetMessage("바코드를 확인하세요.");
        //            break;
        //    }
        //    ClosePrgForm();
        //} 
        #endregion

        #region 삼기
        private void BarcodeCheck(string sArr)
        {
            bIsOKBarcode = false;

            #region 네트워크 테스트
            if (!_bUseNetwork)
            {
                SetMessage("C:S00018");
                CloseProgressForm();
                return;
            } 
            #endregion

            #region 바코드 검증

            DataTable dt = new DataTable();

            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            if (txtLotNo.Text.Length == 17)
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0400_I0");
                cmd.Connection = conn;

                cmd.Parameters.Add(new SqlParameter("@LotNo", txtLotNo.Text));

                SqlParameter pItemCode = cmd.Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.VarChar, 30));
                pItemCode.Direction = ParameterDirection.Output;
                SqlParameter pItemName = cmd.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 50));
                pItemName.Direction = ParameterDirection.Output;
                SqlParameter pQty = cmd.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Float));
                pQty.Direction = ParameterDirection.Output;

                if (!clsDB.gExecuteProcedure(conn, cmd))
                {
                    SetMessage(clsDB.ErrorDesc);

                    txtItemCode.Text = "";
                    txtItemName.Text = "";
                    txtQty.Text = "";

                    return;
                }
                else
                {
                    txtItemCode.Text = clsDB.nvlString(cmd.Parameters["@ItemCode"].Value);
                    txtItemName.Text = clsDB.nvlString(cmd.Parameters["@ItemName"].Value);
                    txtQty.Text = string.Format("{0:#,##0}", cmd.Parameters["@Qty"].Value);

                    SetMessage("작업 가능한 바코드입니다.");

                    bIsOKBarcode = true;
                }
            }
            else
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand(Common.sERPDB+ ".DBO.USP_POP_SK164");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@move_ticket", txtLotNo.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@gubun", "L"));
                cmd.Parameters.Add(new SqlParameter("@workcentercode", Common.SelectedWorkCenter.Code));
                DataTable tbLot = db.ExecuteDataSet(cmd).Tables[0];

                if (tbLot.Columns[0].ColumnName.ToLower() == "err_code" && tbLot.Rows[0]["err_code"].ToString().Equals("1"))
                {
                    SetMessage(tbLot.Rows[0]["msg"].ToString());
                    txtItemCode.Text = "";
                    txtItemName.Text = "";
                    txtQty.Text = "";

                }
                else
                {
                    txtItemName.Text = tbLot.Rows[0]["description"].ToString();
                    txtItemCode.Text = tbLot.Rows[0]["resource_no"].ToString();
                    txtQty.Text = string.Format("{0:#,##0}", Convert.ToInt32(tbLot.Rows[0]["qty_on_hand"]));
                    SetMessage("작업 가능한 바코드입니다.");

                    bIsOKBarcode = true;
                }

            }
            #endregion
        }
        #endregion

        private void txtLotNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoProgress();

            bIsOKBarcode = false;


            if (blnScanRefresh)
            {
                txtLotNo.Text = string.Empty;
                blnScanRefresh = false;
            }

            if (e.KeyChar == 13)
            {
                txtLotNo.Text = txtLotNo.Text.Trim();
                BarcodeCheck(txtLotNo.Text);
                blnScanRefresh = true;
            }
            
            CloseProgressForm();
        }

        private void DA0500_Activated(object sender, EventArgs e)
        {
            txtLotNo.Focus();
        }

        private void txtLotNo_Leave(object sender, EventArgs e)
        {
            txtLotNo.Focus();
        }

        private void txtLotNo_Click(object sender, EventArgs e)
        {
            DA9200 d = new DA9200();
            d.ContentText = txtLotNo.Text.Trim();

            if (DialogResult.OK == ShowDialogForm(d))
            {
                txtLotNo.Text = d.resultString;
                blnScanRefresh = false;
                txtLotNo_KeyPress(txtLotNo, new KeyPressEventArgs((char)Keys.Enter));
            }
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            if (btnSelect.GetSelectedButtons().Count != 0)
            {
                //DoProgress();
                switch (btnSelect.GetSelectedButtons()[0].Text)
                {
                    case "현황":
                        dtpDate.Enabled = false;

                        mesGrid1.Visible = true;
                        mesGrid2.Visible = false;

                        btnLeftPage.LinkGrid = mesGrid1;
                        btnRightPage.LinkGrid = mesGrid1;
                        btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                        btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                        DoFind();
                        break;

                    case "실적":
                        dtpDate.Enabled = true;

                        mesGrid1.Visible = false;
                        mesGrid2.Visible = true;

                        btnLeftPage.LinkGrid = mesGrid2;
                        btnRightPage.LinkGrid = mesGrid2;
                        btnLeftPage.LinkMoveSize = mesGrid2.CountRows;
                        btnRightPage.LinkMoveSize = mesGrid2.CountRows;

                        DoFind2();
                        break;
                }
                //ClosePrgForm();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind2();
        }
    }
}
