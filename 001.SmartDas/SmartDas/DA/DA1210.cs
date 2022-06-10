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
using System.Collections;

using SmartDas.POPUP;

namespace SmartDas
{
    public partial class DA1210 : SmartDas.Components.BaseForm
    {
        private WorkCenter wc = Common.SelectedWorkCenter;
        private double fUPH = 0;
        private string sSearchflag = string.Empty;
        private string qty = "0";
        private string remark = "";
        public DA1210()
        {
            InitializeComponent();

            lblSelection.MoveControl = pnlSelection;
        }

        private void DA1210_Load(object sender, EventArgs e)
        {
            SetGrid();

            SetButtons();

            //SetHash();

            Init();

            DoFind();

            //SetMessage("실적을 등록하십시오");            
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 14;
            mesGrid1.CountRows = 8;
            mesGrid1.SelectProcedureName = "USP_DA1210_S1";
    
            btnLeftPage.LinkGrid = mesGrid1;
            btnRightPage.LinkGrid = mesGrid1;

            btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
            btnRightPage.LinkMoveSize = mesGrid1.CountRows;


            mesGrid2.FontSize = 14;
            mesGrid2.CountRows = 6;
            mesGrid2.SelectProcedureName = "[USP_DA1210_S2]";

            btnUp.LinkGrid = mesGrid2;
            btnDown.LinkGrid = mesGrid2;

            btnUp.LinkMoveSize = mesGrid2.CountRows;
            btnDown.LinkMoveSize = mesGrid2.CountRows;

        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "닫기";

            btnConfBox.RedrawButtons();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

        }

        private void DoFind()
        {
            pnlSelection.Visible = false;

            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));

            mesGrid1.ParameterList.Add(new SqlParameter("@pUPH", SqlDbType.Float));
            mesGrid1.ParameterList["@pUPH"].Direction = ParameterDirection.Output;

            mesGrid1.DoFind();

            fUPH = clsDB.nvlDouble(mesGrid1.ParameterList["@pUPH"].Value);
   //         if ((dtpDate.Value.Hour < 8 ? DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd")) == dtpDate.Value.ToString("yyyy-MM-dd"))

            //if (dtpDate.Value > DateTime.Now.AddDays(-7))




            //if (dtpDate.Value.Month == DateTime.Now.Month) //월단위입력
            //{
            //    btnNew.Enabled = true;
            //    btnModify.Enabled = true;
            //    btnDelete.Enabled = true;
            //}
            //else
            //{
            //    btnNew.Enabled = false;
            //    btnModify.Enabled = false;
            //    btnDelete.Enabled = false;
            //}
            
         }

        private void DoFind_Sub()
        {
            mesGrid2.GetStoreProcedure();

            // 조회
            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid2.DoFind();
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                if (!_bUseNetwork)
                {
                    SetMessage("C:S00018");
                    return;
                }

                DoProgress();
                switch (sender.Text)
                {
                    case "조회":
                        DoFind();
                        break;

                    case "등록":
                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA1210_I1";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                        cmd.Parameters.Add(new SqlParameter("@pUPH", fUPH));

                        cmd.Parameters.Add(new SqlParameter("@Seq", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@pWorkerName", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pWorkName", SqlDbType.VarChar, 50));
                        cmd.Parameters.Add(new SqlParameter("@pProcessName", SqlDbType.VarChar, 50));

                        cmd.Parameters.Add(new SqlParameter("@pStartTime", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pEndTime", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pTotalTime", SqlDbType.Float));

                        cmd.Parameters.Add(new SqlParameter("@pPlanQty", SqlDbType.Float));
                        cmd.Parameters.Add(new SqlParameter("@pProdQty", SqlDbType.Float));
                        cmd.Parameters.Add(new SqlParameter("@pNote", SqlDbType.VarChar, 255));

                        cmd.Parameters.Add(new SqlParameter("@pFlag", SqlDbType.Char, 2));                        

                        foreach (UltraGridRow row in mesGrid1.Rows)
                        {

                            if (row.Cells["WorkerName"].Value.ToString() == "" && row.Cells["ProdQty"].Value.ToString() != "")
                            {
                                SetMessage("작업자 미선택!!!!!");
                                return;
                            }

                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (row.Cells["Status"].Value.ToString() == "" || row.Cells["WorkerName"].Value.ToString() == "")
                                continue;

                            cmd.Parameters["@pWorkerName"].Value = clsDB.nvlString(row.Cells["WorkerName"].Value);
                            cmd.Parameters["@pWorkName"].Value = clsDB.nvlString(row.Cells["WorkName"].Value);
                            cmd.Parameters["@pProcessName"].Value = clsDB.nvlString(row.Cells["ProcessName"].Value);
                            cmd.Parameters["@Seq"].Value = clsDB.nvlInt(row.Cells["Seq"].Value);

                            cmd.Parameters["@pStartTime"].Value = clsDB.nvlString(row.Cells["StartTime"].Value);
                            cmd.Parameters["@pEndTime"].Value = clsDB.nvlString(row.Cells["EndTime"].Value);
                            cmd.Parameters["@pTotalTime"].Value = clsDB.nvlDouble(row.Cells["TotalTime"].Value);

                            cmd.Parameters["@pPlanQty"].Value = clsDB.nvlDouble(row.Cells["PlanQty"].Value);
                            cmd.Parameters["@pProdQty"].Value = clsDB.nvlDouble(row.Cells["ProdQty"].Value);
                            cmd.Parameters["@pNote"].Value = clsDB.nvlString(row.Cells["Note"].Value);

                            switch (row.Cells["Status"].Value.ToString())
                            {
                                case "신규":
                                    cmd.Parameters["@pFlag"].Value = "I";
                                    break;

                                case "삭제":
                                    cmd.Parameters["@pFlag"].Value = "D";
                                    break;

                                case "수정":
                                    cmd.Parameters["@pFlag"].Value = "U";
                                    break;
                            }

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                // 오류 발생시
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }

                        SetMessage("등록이 완료되었습니다.");

                        DoFind();
                        break;

                    case "닫기":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            try
            {
                pnlSelection.Visible = false;

                if (e._UltraGridColumn == null || e._UltraGridRow == null)
                    return;

                if ("".Equals(e._UltraGridRow.Cells["STATUS"].Value.ToString()))
                    return;

                if ("삭제".Equals(e._UltraGridRow.Cells["STATUS"].Value.ToString()))
                    return;

                switch (e._UltraGridColumn.ToString())
                {
                    case "WorkerName":

                        lblSelection.Text = "작업자 선택";
                        sSearchflag = "1";
                        DoFind_Sub();
                        pnlSelection.Visible = true;

                        break;
                    case "WorkName":
                        lblSelection.Text = "작업명 선택";
                        sSearchflag = "2";
                        DoFind_Sub();
                        pnlSelection.Visible = true;

                        break;

                    case "ProcessName":
                        lblSelection.Text = "공정명 선택";
                        sSearchflag = "4";
                        DoFind_Sub();
                        pnlSelection.Visible = true;

                        break;

                    case "StartTime":
                    case "EndTime":
                        lblSelection.Text = "작업시간 선택";                        
                        sSearchflag = "3";
                        DoFind_Sub();
                        pnlSelection.Visible = true;

                        break;

                    case "TotalTime":
                        DA9100 da9101 = new DA9100();
                        da9101.LabelTitle = "작업시간 입력";
                        da9101.LabelHeader = "작업시간";

                        if (DialogResult.OK == ShowDialogForm(da9101))
                        {
                            e._UltraGridCell.Value = da9101.ResultString;
                        }
                        break;
                    case "ProdQty" :
                        DA9100 da9100 = new DA9100();
                        da9100.LabelTitle = "생산수량 입력";
                        da9100.LabelHeader = "생산수량";

                        if (DialogResult.OK == ShowDialogForm(da9100))
                        {
                            e._UltraGridCell.Value = da9100.ResultString;
                            qty = da9100.ResultString;
                        }
                        break;

                    case "Note":
                        DA9120 da9120 = new DA9120();
                        da9120.ResultString = e._UltraGridRow.Cells["Note"].Value.ToString();
                        if (DialogResult.OK == ShowDialogForm(da9120))
                        {
                            e._UltraGridCell.Value = da9120.ResultString;
                            remark = da9120.ResultString;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
            finally
            {
                CloseProgressForm();
            }
        }

        //private void DataExecute(List<int> listRow)
        //{
        //    foreach (int i in listRow)
        //    {
        //        DataProcess(mesGrid1.Rows[i]);
        //    }

        //    listRow.Clear();
        //}

        //private void DataProcess(UltraGridRow row)
        //{
        //    Database db = DatabaseFactory.CreateDatabase();
        //    SqlConnection con = (SqlConnection)db.CreateConnection();
        //    SqlCommand cmd = new SqlCommand();

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;

        //    cmd.CommandText = "USP_DA1210_I1";

        //    if (clsDB.nvlString(row.Cells["WorkerID"].Value) == "")
        //    {
        //        row.Cells["WorkerID"].Value = clsDB.nvlString(txtWorker.Tag);
        //        row.Cells["WorkerName"].Value = clsDB.nvlString(txtWorker.Text);
        //    }

        //    cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
        //    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
        //    cmd.Parameters.Add(new SqlParameter("@pMachCode", row.Cells["MachCode"].Value.ToString()));
        //    cmd.Parameters.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
        //    //cmd.Parameters.Add(new SqlParameter("@pDayNight", btnDayNight.GetSelectedButtons()[0].Tag.ToString()));
        //    cmd.Parameters.Add(new SqlParameter("@pInspCode", row.Cells["InspCode"].Value.ToString()));
        //    cmd.Parameters.Add(new SqlParameter("@pInspValue", row.Cells["RstData"].Value.ToString()));
        //    cmd.Parameters.Add(new SqlParameter("@pInspResult", row.Cells["Result"].Value.ToString()));
        //    cmd.Parameters.Add(new SqlParameter("@pWorkerID", row.Cells["WorkerID"].Value.ToString()));

        //    if (!clsDB.gExecuteProcedure(con, cmd))
        //    {
        //        //  오류 발생시
        //        SetMessage(clsDB.ErrorDesc);
        //        return;
        //    }
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //if (dtpDate.Value.Month == DateTime.Now.Month) //월단위입력
            //{
            //    btnNew.Enabled = true;
            //    btnModify.Enabled = true;
            //    btnDelete.Enabled = true;
            //}
            //else
            //{
            //    btnNew.Enabled = false;
            //    btnModify.Enabled = false;
            //    btnDelete.Enabled = false;
            //    DoFind();
            //    return;
            //}


            int curl = mesGrid1.Rows.Count;
            int len = 1;
           // if (curl == 0)
            {
                sSearchflag = "4";
                DoFind_Sub();
                len = mesGrid2.Rows.Count;

            }
            for (int i = 0; i < len; i++)
            {
                DataRow dr = mesGrid1.DataSourceDS.Tables[1].NewRow();

                dr["STATUS"] = "신규";

                mesGrid1.DataSourceDS.Tables[1].Rows.Add(dr);//mesGrid1.DataSourceDS.Tables[1].Rows.Count);

                mesGrid1.GetGrid();
                mesGrid1.Row = mesGrid1.Rows[mesGrid1.Rows.Count-1];

                sSearchflag = "4";
                DoFind_Sub();
                try
                {
                    mesGrid1.Row.Cells["ProcessName"].Value = mesGrid2.Rows[i].Cells["CodeName"].Value;
                }
                catch { }
                //if (curl <= mesGrid2.Rows.Count)
                //    return;


                //sSearchflag = "1";
                //DoFind_Sub();
                //mesGrid1.Row.Cells["WorkerName"].Value = mesGrid2.Rows[0].Cells["WorkerName"].Value;

                sSearchflag = "2";
                DoFind_Sub();
                try
                {
                    mesGrid1.Row.Cells["WorkName"].Value = mesGrid2.Rows[0].Cells["CodeName"].Value;
                }
                catch { }
                sSearchflag = "3";
                DoFind_Sub();
                try
                {
                    int pp = 3;
                    if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 20)
                        pp = 1;
                    mesGrid1.Row.Cells["StartTime"].Value = mesGrid2.Rows[pp].Cells["StartTime"].Value;
                    mesGrid1.Row.Cells["EndTime"].Value = mesGrid2.Rows[pp].Cells["EndTime"].Value;
                    mesGrid1.Row.Cells["TotalTime"].Value = mesGrid2.Rows[pp].Cells["TotalTime"].Value;
                    mesGrid1.Row.Cells["PlanQty"].Value = (fUPH * clsDB.nvlDouble(mesGrid2.Rows[pp].Cells["TotalTime"].Value)).ToString("###");
                    //mesGrid1.Row.Cells["ProdQty"].Value = qty;
                    mesGrid1.Row.Cells["Note"].Value = remark;
                }
                catch { }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlSelection.Visible = false;
        }

        private void FillTotalTime()
        {
            if (mesGrid1.Row == null)   return;

            if (string.IsNullOrWhiteSpace(mesGrid1.Row.Cells["StartTime"].Value.ToString())) return;
            if (string.IsNullOrWhiteSpace(mesGrid1.Row.Cells["EndTime"].Value.ToString())) return;

            string[] arrStartTime = new string[2];
            string[] arrEndTime = new string[2];

            arrStartTime = mesGrid1.Row.Cells["StartTime"].Value.ToString().Split(':');
            arrEndTime = mesGrid1.Row.Cells["EndTime"].Value.ToString().Split(':');

            int iStartTime_H = Convert.ToInt32(arrStartTime[0]);
            int iStartTime_M = Convert.ToInt32(arrStartTime[1]);
            int iEndTime_H = Convert.ToInt32(arrEndTime[0]);
            int iEndTime_M = Convert.ToInt32(arrEndTime[1]);

            if ((iStartTime_H > iEndTime_H) || ((iStartTime_H == iEndTime_H) && iStartTime_M > iEndTime_M))
                iEndTime_H += 24;

            float fTotalTime = (float)((iEndTime_H * 60 + iEndTime_M) - (iStartTime_H * 60 + iStartTime_M)) / 60F;

            mesGrid1.Row.Cells["TotalTime"].Value = fTotalTime.ToString("###.#");
            mesGrid1.Row.Cells["PlanQty"].Value = (fTotalTime * fUPH).ToString("###");
        }

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridColumn == null || e._UltraGridRow == null)
                    return;

            pnlSelection.Visible = false;

            switch (sSearchflag)
            {
                case "1":
                    if (ShowDialogForm(new MessageForm("해당 작업자로 전부 입력하시겠습니까? ",
                        MessageBoxButtons.YesNo, "전체 입력")) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int i = 0;
                        foreach (UltraGridRow row in mesGrid1.Rows)
                        {
                            mesGrid1.Rows[i].Cells["WorkerName"].Value = e._UltraGridRow.Cells["WorkerName"].Value;
                            ++i;
                        }
                    }
                    else
                    {
                        mesGrid1.Row.Cells["WorkerName"].Value = e._UltraGridRow.Cells["WorkerName"].Value;
                    }
                    break;

                case "2":
                    mesGrid1.Row.Cells["WorkName"].Value = e._UltraGridRow.Cells["CodeName"].Value;

                    break;

                case "3":
                    if ("수기입력".Equals(e._UltraGridRow.Cells["CodeName"].Value.ToString()))
                    {
                        DA9120 da9120 = new DA9120();

                        if (DialogResult.OK == ShowDialogForm(da9120))
                        {
                            string ResultString = da9120.ResultString.Trim();
                            string[] arrStr = new string[2];
                            arrStr = ResultString.Split(':');
                            if (arrStr.Length < 2)
                            {
                                SetMessage("[00:00 ~ 23:59] 형식으로 입력하여 주십시오.");
                                return;
                            }
                            else if (Convert.ToInt32(arrStr[0]) < 0 || Convert.ToInt32(arrStr[0]) >= 24)
                            {
                                SetMessage("[00:00 ~ 23:59] 형식으로 입력하여 주십시오.");
                                return;
                            }
                            else if (Convert.ToInt32(arrStr[1]) < 0 || Convert.ToInt32(arrStr[0]) >= 60)
                            {
                                SetMessage("[00:00 ~ 23:59] 형식으로 입력하여 주십시오.");
                                return;
                            }

                            mesGrid1.Row.Cells[mesGrid1.Col].Value = da9120.ResultString;

                            FillTotalTime();
                        }
                    }
                    else
                    {
                        mesGrid1.Row.Cells["StartTime"].Value = e._UltraGridRow.Cells["StartTime"].Value;
                        mesGrid1.Row.Cells["EndTime"].Value = e._UltraGridRow.Cells["EndTime"].Value;
                        mesGrid1.Row.Cells["TotalTime"].Value = e._UltraGridRow.Cells["TotalTime"].Value;
                        mesGrid1.Row.Cells["PlanQty"].Value = (fUPH * clsDB.nvlDouble(e._UltraGridRow.Cells["TotalTime"].Value)).ToString("###");
                    }
                    break;

                case "4":
                    mesGrid1.Row.Cells["ProcessName"].Value = e._UltraGridRow.Cells["CodeName"].Value;

                    break;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                pnlSelection.Visible = false;

                if (mesGrid1.Row == null)
                {
                    SetMessage("수정하실 데이터를 선택하십시오.");
                    return;
                }

                switch (mesGrid1.Row.Cells["STATUS"].Value.ToString())
                {
                    case "":
                        mesGrid1.Row.Cells["STATUS"].Value = "수정";
                        break;
                }
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                pnlSelection.Visible = false;

                if (mesGrid1.Row == null)
                {
                    SetMessage("삭제하실 데이터를 선택하십시오.");
                    return;
                }

                switch (mesGrid1.Row.Cells["STATUS"].Value.ToString())
                {
                    case "":
                    case "수정":
                        mesGrid1.Row.Cells["STATUS"].Value = "삭제";
                        break;

                    case "삭제":
                        mesGrid1.Row.Cells["STATUS"].Value = "";
                        break;

                    case "신규":
                        mesGrid1.Row.Delete(false);
                        break;
                }

                mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            }
            catch { }
        }


    }
}
