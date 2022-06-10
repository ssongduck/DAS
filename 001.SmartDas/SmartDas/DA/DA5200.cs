using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using SmartDas.Components;

using SmartDas.POPUP;

namespace SmartDas
{
    public partial class DA5200 : BaseForm
    {
        private string sSearchflag = string.Empty;
        private Infragistics.Win.UltraWinGrid.UltraGridCell SelectedCell = null;
        private WorkCenter wc = new WorkCenter();

        public DA5200()
        {
            InitializeComponent();
        }

        private void DA5200_Load(object sender, EventArgs e)
        {
            wc.PlantCode = Common.gsPlantCode;
            wc.Code = "1351";
            wc.Name = "보온로";

            Common.SelectedWorkCenter = wc;

            SetGrid();

            SetButtons();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            txtWorkerCode.Text = string.Empty;
            txtWorkerName.Text = string.Empty;
            try
            {
                System.Threading.Thread.Sleep(1000);
                dtpDate.Value = Convert.ToDateTime(Common.gRecDate);
            }
            catch { }

        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

        private void SetButtons()
        {
            #region btnConfBox
            btnConfBox.CountX = 1;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            //btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons(); 
            #endregion

            #region btnSelect
            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "실적조회";
            btnSelect[0, 1].Text = "신규등록";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0)); 
            #endregion
            
            #region btnKeyPad
            btnKeyPad.CountX = 6;
            btnKeyPad.CountY = 2;

            btnKeyPad.SetButtons();

            btnKeyPad[0, 0].Text = "1";
            btnKeyPad[0, 1].Text = "2";
            btnKeyPad[0, 2].Text = "3";
            btnKeyPad[0, 3].Text = "4";
            btnKeyPad[0, 4].Text = "5";
            btnKeyPad[0, 5].Text = "◀";
            btnKeyPad[1, 0].Text = "6";
            btnKeyPad[1, 1].Text = "7";
            btnKeyPad[1, 2].Text = "8";
            btnKeyPad[1, 3].Text = "9";
            btnKeyPad[1, 4].Text = "0";
            btnKeyPad[1, 5].Text = "C";

            btnKeyPad.RedrawButtons(); 
            #endregion
        }

        private void SetGrid()
        {
            #region mesGrid1
            mesGrid1.FontSize = 15;
            mesGrid1.SelectProcedureName = "USP_DA5200_S1";

            mesGrid1.CountRows = 11;
            mesGrid1.GetStoreProcedure();

            //mesGrid1.DoFind();

            //mesGrid1.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            #endregion

            #region mesGrid2
            mesGrid2.FontSize = 15;
            mesGrid2.SelectProcedureName = "USP_DA5200_S2";

            mesGrid2.CountRows = 5;
            mesGrid2.GetStoreProcedure();

            //mesGrid2.DoFind();

            //mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid2.DataSourceDS.Tables[1].AcceptChanges(); 
            #endregion

            #region mesGrid3
            mesGrid3.FontSize = 15;
            mesGrid3.SelectProcedureName = "USP_DA5200_S3";

            mesGrid3.CountRows = 5;
            mesGrid3.GetStoreProcedure();

            mesGrid3.DoFind();
            #endregion
        }

        private void SetGrid_I()
        {
            #region mesGrid1
            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid1.DoFind();

            //mesGrid1.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            #endregion


            #region mesGrid2
            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid2.DoFind();

            mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            #endregion
        }

        private void DoFind()
        {
            SelectedCell = null;

            #region mesGrid1
            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));

            mesGrid1.DoFind();
            #endregion

            #region mesGrid2
            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid2.DoFind();
            #endregion
        }

     
        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                switch (sender.Text)
                {
                    case "등록":
                        if (sSearchflag == "I")
                        {
                            if (!_bUseNetwork)
                            {
                                SetMessage("C:S00018");
                                return;
                            }

                            if (string.IsNullOrEmpty(mesGrid1.Rows[0].Cells["PlantCode"].Value.ToString()))
                            {
                                SetMessage("납품업체를 선택하여 주십시오.");
                                return;
                            }
                            if (string.IsNullOrEmpty(mesGrid1.Rows[0].Cells["TappingTemp"].Value.ToString()))
                            {
                                SetMessage("출탕온도를 입력하여 주십시오.");
                                mesGrid1_GridClick(mesGrid1, new MESGrid.GridClickEventArg(mesGrid1.Rows[0].Cells["TappingTemp"]));
                                return;
                            }

                            if (mesGrid2.Rows.Count == 0)
                            {
                                SetMessage("하나 이상의 래들정보를 등록하여 주십시오.");
                                return;
                            }

                            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in mesGrid2.Rows)
                            {
                                if (string.IsNullOrEmpty(dr.Cells["LadleNo"].Value.ToString()))
                                {
                                    SetMessage("래들번호를 입력하여 주십시오.");
                                    mesGrid2_GridClick(mesGrid2, new MESGrid.GridClickEventArg(dr.Cells["LadleNo"]));
                                    return;
                                }

                                if (string.IsNullOrEmpty(dr.Cells["InjectionWeight"].Value.ToString()))
                                {
                                    SetMessage("주입중량을 입력하여 주십시오.");
                                    mesGrid2_GridClick(mesGrid2, new MESGrid.GridClickEventArg(dr.Cells["InjectionWeight"]));
                                    return;
                                }

                                if (string.IsNullOrEmpty(dr.Cells["DepartureTemp"].Value.ToString()))
                                {
                                    SetMessage("출발온도를 입력하여 주십시오.");
                                    mesGrid2_GridClick(mesGrid2, new MESGrid.GridClickEventArg(dr.Cells["DepartureTemp"]));
                                    return;
                                }
                            }

                            Database db = DatabaseFactory.CreateDatabase();
                            SqlConnection conn = (SqlConnection)db.CreateConnection();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;

                            cmd.CommandText = "USP_DA5200_I1";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));

                            cmd.Parameters.Add(new SqlParameter("@RecDate", SqlDbType.VarChar, 10));
                            cmd.Parameters["@RecDate"].Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(new SqlParameter("@Seq", SqlDbType.Int));
                            cmd.Parameters["@Seq"].Direction = ParameterDirection.Output;

                            cmd.Parameters.Add(new SqlParameter("@pBuyerCode", clsDB.nvlString(mesGrid1.Rows[0].Cells["PlantCode"].Value)));
                            cmd.Parameters.Add(new SqlParameter("@pTappingTemp", clsDB.nvlDouble(mesGrid1.Rows[0].Cells["TappingTemp"].Value)));
                            cmd.Parameters.Add(new SqlParameter("@pVehicleNo", clsDB.nvlString(mesGrid1.Rows[0].Cells["VehicleNo"].Value)));
                            cmd.Parameters.Add(new SqlParameter("@pWorkerCode", txtWorkerCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@pLotNo", mesGrid1.Rows[0].Cells["LotNo"].Value));

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                // 오류 발생시
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }

                            int iSeq = Convert.ToInt32(cmd.Parameters["@Seq"].Value);
                            string sRecDate = cmd.Parameters["@RecDate"].Value.ToString();
                            string sMessage;

                            cmd.CommandText = "USP_DA5200_I2";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@RecDate", sRecDate));
                            cmd.Parameters.Add(new SqlParameter("@Seq", iSeq));

                            cmd.Parameters.Add(new SqlParameter("@pLadleNo", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@pInjectionWeight", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pDepartureTemp", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pArrivalTemp", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pWorkerCode", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@ERP_STATUS", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@ERP_ERROR_MSG", SqlDbType.VarChar, 50));

                            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in mesGrid2.Rows)
                            {
                                cmd.Parameters["@pLadleNo"].Value = clsDB.nvlInt(dr.Cells["LadleNo"].Value);
                                cmd.Parameters["@pInjectionWeight"].Value = clsDB.nvlDouble(dr.Cells["InjectionWeight"].Value);
                                cmd.Parameters["@pDepartureTemp"].Value = clsDB.nvlDouble(dr.Cells["DepartureTemp"].Value);
                                cmd.Parameters["@pArrivalTemp"].Value = clsDB.nvlDouble(dr.Cells["ArrivalTemp"].Value);
                                cmd.Parameters["@pWorkerCode"].Value = txtWorkerCode.Text;

                                cmd.Parameters["@ERP_STATUS"].Direction = ParameterDirection.Output;
                                cmd.Parameters["@ERP_ERROR_MSG"].Direction = ParameterDirection.Output;
                                
                                if (clsDB.gExecute(conn, cmd) < 0)
                                {
                                    // 오류 발생시
                                    sMessage = cmd.Parameters["@ERP_ERROR_MSG"].Value.ToString();
                                    SetMessage(sMessage);
                                    //SetMessage(clsDB.ErrorDesc);
                                    return;
                                }
                            }

                            sMessage = cmd.Parameters["@ERP_ERROR_MSG"].Value.ToString();

                            SetMessage(sMessage);
                            SetGrid_I();
                        }
                        else // if (sSearchflag == "S")
                        {
                            Database db = DatabaseFactory.CreateDatabase();
                            SqlConnection conn = (SqlConnection)db.CreateConnection();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;

                            cmd.CommandText = "USP_DA5200_U1";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));

                            cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid1.Row.Cells["RecDate"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid1.Row.Cells["Seq"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pBuyerCode", clsDB.nvlString(mesGrid1.Row.Cells["BuyerCode"].Value)));
                            cmd.Parameters.Add(new SqlParameter("@pTappingTemp", clsDB.nvlDouble(mesGrid1.Row.Cells["TappingTemp"].Value)));
                            cmd.Parameters.Add(new SqlParameter("@pVehicleNo", clsDB.nvlString(mesGrid1.Row.Cells["VehicleNo"].Value)));
                           // cmd.Parameters.Add(new SqlParameter("@pWorkerCode", txtWorkerCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@pLotNo", mesGrid1.Rows[0].Cells["LotNo"].Value));

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                // 오류 발생시
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }

                            string sMessage;

                            cmd = new SqlCommand();
                            cmd.Connection = conn;

                            cmd.CommandText = "USP_DA5200_U2";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@RecDate", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@Seq", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@pLadleNo", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@pInjectionWeight", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pDepartureTemp", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pArrivalTemp", SqlDbType.Float));
                            cmd.Parameters.Add(new SqlParameter("@pWorkerCode", txtWorkerCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@pFlag", SqlDbType.Char, 2));
                            cmd.Parameters.Add(new SqlParameter("@SeqID", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@ERP_STATUS", SqlDbType.VarChar, 10));
                            cmd.Parameters.Add(new SqlParameter("@ERP_ERROR_MSG", SqlDbType.VarChar, 50));

                            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in mesGrid2.Rows)
                            {
                                //if ("".Equals(dr.Cells["Status"].Value.ToString()) && "".Equals(dr.Cells["ArrivalTemp"].Value.ToString()))
                                //    continue;

                                cmd.Parameters["@pPlantCode"].Value = clsDB.nvlString(dr.Cells["PlantCode"].Value);
                                cmd.Parameters["@pWorkCenterCode"].Value = clsDB.nvlString(dr.Cells["WorkCenterCode"].Value);
                                cmd.Parameters["@RecDate"].Value = clsDB.nvlString(dr.Cells["RecDate"].Value);
                                cmd.Parameters["@Seq"].Value = clsDB.nvlInt(dr.Cells["Seq"].Value);
                                cmd.Parameters["@pLadleNo"].Value = clsDB.nvlInt(dr.Cells["LadleNo"].Value);
                                cmd.Parameters["@pInjectionWeight"].Value = clsDB.nvlDouble(dr.Cells["InjectionWeight"].Value);
                                cmd.Parameters["@pDepartureTemp"].Value = clsDB.nvlDouble(dr.Cells["DepartureTemp"].Value);
                                cmd.Parameters["@pArrivalTemp"].Value = clsDB.nvlDouble(dr.Cells["ArrivalTemp"].Value);
                                cmd.Parameters["@SeqID"].Value = clsDB.nvlDouble(dr.Cells["SeqID"].Value);

                                cmd.Parameters["@ERP_STATUS"].Direction = ParameterDirection.Output;
                                cmd.Parameters["@ERP_ERROR_MSG"].Direction = ParameterDirection.Output;

                                switch (dr.Cells["Status"].Value.ToString())
                                {
                                    case "":      // U : Update
                                        cmd.Parameters["@pFlag"].Value = "U";
                                        break;
                                        
                                    case "신규":  // I : Insert
                                        cmd.Parameters["@pFlag"].Value = "I";
                                        break;

                                    case "삭제":  // D : Delete
                                        cmd.Parameters["@pFlag"].Value = "D";
                                        break;
                                        
                                    default :
                                        cmd.Parameters["@pFlag"].Value = "U";
                                        break;
                                }

                                if (clsDB.gExecute(conn, cmd) < 0)
                                {
                                    // 오류 발생시
                                    sMessage = cmd.Parameters["@ERP_ERROR_MSG"].Value == null ? string.Empty : cmd.Parameters["@ERP_ERROR_MSG"].Value.ToString();
                                    SetMessage(sMessage);
                                    //SetMessage(clsDB.ErrorDesc);
                                    return;
                                }
                            }
                            sMessage = cmd.Parameters["@ERP_ERROR_MSG"].Value.ToString();

                            mesGrid1_GridClick(mesGrid1, new MESGrid.GridClickEventArg(mesGrid1.Row.Cells[0]));
                            SetMessage(sMessage);
                        }

                        break;
                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.ToString());
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private void lblMes_Click(object sender, EventArgs e)
        {
            DA9000 DA9000 = new DA9000();
            DA9000.Owner = this;
            ShowDialogForm(DA9000);

            //iSecond = iTarSecond;
            //EventTimer_Tick(this, new EventArgs());

            SetLblMessageClear();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 입력창 팝업 (사용하지 않음)
        //private void txtHour_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "작업시각 입력";
        //    da9100.LabelHeader = "시";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtMinute_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "작업시각 입력";
        //    da9100.LabelHeader = "분";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtLadleNo_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "래들번호 입력";
        //    da9100.LabelHeader = "래들번호";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtInjectionWeight_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "주입중량 입력";
        //    da9100.LabelHeader = "주입중량";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtDepartureTemp_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "출발온도 입력";
        //    da9100.LabelHeader = "출발온도";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtArrivalTemp_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "도착온도 입력";
        //    da9100.LabelHeader = "도착온도";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //}

        //private void txtTappingTemp_Click(object sender, EventArgs e)
        //{
        //    DA9100 da9100 = new DA9100();
        //    da9100.LabelTitle = "출탕온도 입력";
        //    da9100.LabelHeader = "출탕온도";

        //    if (DialogResult.OK == ShowDialogForm(da9100))
        //        ((MESLabel)sender).Text = da9100.ResultString;
        //} 
        #endregion

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                switch (sender.Text)
                {
                    case "실적조회":
                        pnlPlant.Visible = false;

                        dtpDate.Enabled = true;
                        btnSearch.Enabled = true;
                         mesButton2.Enabled = true;
                       //btnNew.Enabled = false;
                        //btnDelete.Enabled = false;

                        sSearchflag = "S"; // SELECT

                        mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
                        mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
                        DoFind();
                        break;

                    case "신규등록":
                        pnlPlant.Visible = true;

                        dtpDate.Enabled = false;
                        btnSearch.Enabled = false;
                        //btnNew.Enabled = true;
                        //btnDelete.Enabled = true;
                        mesButton2.Enabled = false;

                        sSearchflag = "I"; // INPUT

                        mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
                        mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;

                        SetGrid_I();
                        mesGrid1.DataSourceDS.Tables[1].Rows[0]["PlantCode"] = mesGrid3.Rows[0].Cells["PlantCode"].Value;
                        mesGrid1.DataSourceDS.Tables[1].Rows[0]["PlantName"] = mesGrid3.Rows[0].Cells["PlantName"].Value;
                        mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
                        mesGrid1.Row = mesGrid1.Rows[0];
                        SelectedCell = mesGrid1.Rows[0].Cells["TappingTemp"];
                        mesGrid1.GridDefaultSelectedBackColor = Color.Moccasin;
                        SelectedCell.Selected = true;


                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.ToString());
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (sSearchflag == "I" || mesButton2.ButtonPressed )
            {
                mesGrid1.GridDefaultSelectedBackColor = Color.Moccasin;
                mesGrid2.GridDefaultSelectedBackColor = Color.White;
                pnlPlant.Visible = false;
                if (SelectedCell != null) SelectedCell.Selected = false;
                e._UltraGridCell.Selected = true;
                SelectedCell = e._UltraGridCell;
                mesGrid1.Row = e._UltraGridRow;
               
                if (e._UltraGridColumn.Key == "LotNo")
                {
                    DA9210 d = new DA9210();
                     if (DialogResult.OK == ShowDialogForm(d))
                    {
                        SelectedCell.Value = d.resultString;
                    }
                }
                else if (e._UltraGridColumn.Key == "PlantName") 
                {
                    pnlPlant.Top = MousePosition.Y - (MousePosition.Y>450?320: 50);
                    pnlPlant.Visible = true;

                }
                else if (e._UltraGridColumn.Key == "TappingTemp") 
                {

                }
            }
            if (sSearchflag != "I")
            {
                mesGrid1.GridDefaultSelectedBackColor = Color.Moccasin;
                mesGrid2.GridDefaultSelectedBackColor = Color.Moccasin;

                mesGrid2.ParameterList.Clear();
                mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", e._UltraGridRow.Cells["PlantCode"].Value));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", e._UltraGridRow.Cells["WorkCenterCode"].Value));
                mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", e._UltraGridRow.Cells["RecDate"].Value));
                mesGrid2.ParameterList.Add(new SqlParameter("@pSeq", e._UltraGridRow.Cells["Seq"].Value));
                mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

                mesGrid2.DoFind();

              //  SelectedCell = null;

               // if ()
              //                             pnlPlant.Visible = true;

            }
            btnRightPage.LinkGrid = mesGrid1;
            btnRightPage.LinkMoveSize = mesGrid1.CountRows;
            btnLeftPage.LinkGrid = mesGrid1;
            btnLeftPage.LinkMoveSize = mesGrid1.CountRows;

        }

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (sSearchflag == "I")
            {
                mesGrid1.GridDefaultSelectedBackColor = Color.White;
                mesGrid2.GridDefaultSelectedBackColor = Color.Moccasin;

                if (SelectedCell != null) SelectedCell.Selected = false;
                e._UltraGridCell.Selected = true;
                SelectedCell = e._UltraGridCell;
            }
            else
            {
                mesGrid1.GridDefaultSelectedBackColor = Color.Moccasin;
                mesGrid2.GridDefaultSelectedBackColor = Color.Moccasin;

                if ("신규".Equals(e._UltraGridRow.Cells["Status"].Value.ToString()))
                {
                    mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
                    e._UltraGridCell.Selected = true;
                    SelectedCell = e._UltraGridCell;
                }
                else
                {
                    mesGrid2.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
                    e._UltraGridRow.Selected = true;
                    SelectedCell = e._UltraGridRow.Cells["ArrivalTemp"];
                }
            }
            btnRightPage.LinkGrid = mesGrid2;
            btnRightPage.LinkMoveSize = mesGrid2.CountRows;
            btnLeftPage.LinkGrid = mesGrid2;
            btnLeftPage.LinkMoveSize = mesGrid2.CountRows;

        }

        private void mesGrid3_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridRow != null)
            {
                if (sSearchflag == "I")
                {
                    mesGrid1.Row.Cells["PlantCode"].Value = e._UltraGridRow.Cells["PlantCode"].Value;
                }
                else
                {
                    mesGrid1.Row.Cells["BuyerCode"].Value = e._UltraGridRow.Cells["PlantCode"].Value;
                }
                mesGrid1.Row.Cells["PlantName"].Value = e._UltraGridRow.Cells["PlantName"].Value;
             //   mesGrid1.DataSourceDS.Tables[1].Rows[0]["PlantCode"] = e.row.Cells["PlantCode"].Value;
             //   mesGrid1.DataSourceDS.Tables[1].Rows[0]["PlantName"] = e.row.Cells["PlantName"].Value;
                mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            }
        }

        private void btnKeyPad_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                if (SelectedCell == null)
                {
                    //SetMessage("입력할 셀을 선택하세요.");
                    return;
                }

                if (SelectedCell == null || SelectedCell.Column.Key == "PlantName" || SelectedCell.Column.Key == "Status")
                {
                    return;
                }

                switch (sender.Text)
                {
                    case "◀":
                        switch (SelectedCell.Value.ToString().Length)
                        {
                            case 0:
                                break;

                            case 1:
                                if (SelectedCell.Value.GetType().Name == "Double")
                                    SelectedCell.Value = 0;
                                else
                                    SelectedCell.Value = "";

                                break;

                            default:
                                SelectedCell.Value = SelectedCell.Value.ToString().Substring(0, SelectedCell.Value.ToString().Length - 1);
                                
                                break;

                        }
                        break;

                    case "C":
                        try
                        {
                            if (SelectedCell.Value.GetType().Name == "Double")
                                SelectedCell.Value = 0;
                            else
                                SelectedCell.Value = "";
                        }
                        catch { }
                        break;

                    default:
                        SelectedCell.Value = SelectedCell.Value + sender.Text;
                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.ToString());
            }
            finally
            {
                CloseProgressForm();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataRow dr = mesGrid2.DataSourceDS.Tables[1].NewRow();

            if (sSearchflag == "S")
            {
                if (mesGrid1.Row == null || mesGrid1.Row.Index < 0)
                {
                    SetMessage("운송정보를 선택하여 주십시오.");
                    return;
                }

                dr["PlantCode"] = mesGrid1.Row.Cells["PlantCode"].Value;
                dr["WorkCenterCode"] = mesGrid1.Row.Cells["WorkCenterCode"].Value;
                dr["RecDate"] = mesGrid1.Row.Cells["RecDate"].Value;
                dr["Seq"] = mesGrid1.Row.Cells["Seq"].Value;

                dr["Status"] = "신규";

            }

            mesGrid2.DataSourceDS.Tables[1].Rows.InsertAt(dr, mesGrid2.DataSourceDS.Tables[1].Rows.Count);

            mesGrid2.GetGrid();
            
            SelectedCell = mesGrid2.Rows[mesGrid2.Rows.Count - 1].Cells["LadleNo"];
            mesGrid2.GridDefaultSelectedBackColor = Color.Moccasin;
            SelectedCell.Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (sSearchflag == "S")
            {
                if (!(mesGrid2.Row == null || mesGrid2.Row.Index < 0))
                {
                    if (mesGrid2.Row.Cells["Status"].Value.ToString().IndexOf("도착") != -1)
                    {
                        SetMessage("도착된 정보는 삭제 할수없습니다.");
                        return;
                    }

                    if (mesGrid2.Row.Cells["Status"].Value.ToString() == "" || mesGrid2.Row.Cells["Status"].Value.ToString() == "반품")
                        mesGrid2.Row.Cells["Status"].Value = "삭제";
                    else if ("삭제".Equals(mesGrid2.Row.Cells["Status"].Value.ToString()))
                        mesGrid2.Row.Cells["Status"].Value = "";
                    else
                        mesGrid2.Row.Delete(false);
                }
                else if (!(mesGrid1.Row == null || mesGrid1.Row.Index < 0))
                {
                    for (int i = 0; i < mesGrid2.Rows.Count; i++)
                    {
                        if (mesGrid2.Rows[i].Cells["Status"].Value.ToString().IndexOf("도착") != -1)
                        {
                            SetMessage("도착된 정보는 삭제 할수없습니다.");
                            return;
                        }
                    }
                    string strMsg = string.Empty;
                    if (mesGrid1.Row.Cells["RecDate"].Value.ToString() != DateTime.Now.AddHours(-8).ToString("yyyy-MM-dd"))
                    {
                        strMsg += "당일 등록된 운송정보가 아닙니다.";
                        strMsg += "\r\n";
                        strMsg += "그래도 삭제하시겠습니까?";
                        strMsg += "\r\n";
                        strMsg += "\r\n";
                        strMsg += "(운송정보에 등록된 래들정보 또한 삭제됨)";
                        
                        //SetMessage(DateTime.Now.ToString("yyyy-MM-dd"));
                        //return;
                    }
                    else
                    {
                        strMsg += "선택된 운송정보를 삭제하시겠습니까?";
                        strMsg += "\r\n";
                        strMsg += "\r\n";
                        strMsg += "(운송정보에 등록된 래들정보 또한 삭제됨)";
                    }

                    MessageForm MF = new MessageForm(strMsg, MessageBoxButtons.YesNo, "삭제 확인");

                    if (ShowDialogForm(MF) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }


                    Database db = DatabaseFactory.CreateDatabase();
                    SqlConnection conn = (SqlConnection)db.CreateConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "USP_DA5200_D1";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@pPlantCode", mesGrid1.Row.Cells["PlantCode"].Value));
                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", mesGrid1.Row.Cells["WorkCenterCode"].Value));
                    cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid1.Row.Cells["RecDate"].Value));
                    cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid1.Row.Cells["Seq"].Value));

                    if (clsDB.gExecute(conn, cmd) < 0)
                    {
                        // 오류 발생시
                        SetMessage(clsDB.ErrorDesc);
                        return;
                    }
                    else
                        DoFind();
                }
                else
                {
                    SetMessage("삭제할 정보를 선택하십시오.");
                    return;
                }
            }
            else
            {
                if (mesGrid2.Row == null || mesGrid2.Row.Index < 0)
                {
                    SetMessage("삭제할 정보를 선택하십시오.");
                    return;
                }

                mesGrid2.Row.Delete(false);
            }

            mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            SelectedCell = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }

        private void txtWorkerCode_Click(object sender, EventArgs e)
        {
            DA0230 da0230 = new DA0230();

            if (DialogResult.OK == ShowDialogForm(da0230))
            {
                txtWorkerCode.Text = da0230.strWorkerCode;
                txtWorkerName.Text = da0230.strWorkerName;
            }
        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedCell == null || SelectedCell.Column.Key == "InjectionWeight")
                {
                    SelectedCell.Value = "-";
                }
            }
            catch { }

        }

        private void mesButton2_Click(object sender, EventArgs e)
        {
          if (  mesButton2.ButtonPressed ==false)
              pnlPlant.Visible = false;

        }

        private void mesButton3_Click(object sender, EventArgs e)
        {
            pnlPlant.Visible = false;
        }
    }
}
