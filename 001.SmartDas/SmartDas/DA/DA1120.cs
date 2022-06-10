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

namespace SmartDas
{
    public partial class DA1120 : SmartDas.Components.BaseForm
    {
        private string lastWorkerID = "";
        private string lastWorkerName = "";

        private Hashtable hash = null;

        public DA1120()
        {
            InitializeComponent();

            SetGrid();
            SetButtons();

            SetHash();

            txtItemCode.Text = Common.SelectedWorkCenter.ItemCode;
            txtItemName.Text = Common.SelectedWorkCenter.ItemName;

            if (Common.SelectedWorkCenter.OrderCnt >= 2)
            {
                btnItem.Visible = true;
            }
            else
            {
                btnItem.Visible = false;
            }

            dtpStartDate.Value = Convert.ToDateTime(Common.gRecDate);

            DoFind();
            
            SetMessage("검사 실적을 등록하십시오");

            txtWorker.Tag = Common.worker_DA1120.ID;
            txtWorker.Text = Common.worker_DA1120.Name;
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 11;
            //mesGrid1.HeadString = sHead;
            mesGrid1.SelectProcedureName = "USP_DA1120_S1";
            mesGrid1.CountRows = 7;
            
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pItemCode", txtItemCode.Text));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpStartDate.Value.ToString("yyyy-MM-dd")));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", btnDayNight.GetSelectedButtons()[0].Tag.ToString()));

            mesGrid1.DoFind();

            mesGrid1.Columns["ManaLSL"].Format = "#,##0.000";
            mesGrid1.Columns["ManaUSL"].Format = "#,##0.000";

            CheckResult("RstData1", "Result1");
            CheckResult("RstData2", "Result2");
            CheckResult("RstData3", "Result3");

            mesGrid1.Columns["OpSeq"].MergedCellContentArea = MergedCellContentArea.VisibleRect;
            mesGrid1.Columns["OpSeq"].MergedCellEvaluationType = MergedCellEvaluationType.MergeSameValue;
            mesGrid1.Columns["OpSeq"].MergedCellStyle = MergedCellStyle.Always;

            for (int i = 0; i < mesGrid1.Rows.Count; i++)
            {
                if (clsDB.nvlString(mesGrid1.Rows[i].Cells["SPCFLAG"].Value) == "Y")
                {
                    mesGrid1.Rows[i].Cells["RstData1"].Value = "SPC";
                    mesGrid1.Rows[i].Cells["RstData2"].Value = "SPC";
                    mesGrid1.Rows[i].Cells["RstData3"].Value = "SPC";
                }
            }
        }

        /// <summary>
        /// 버튼 생성
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            btnConfBox[0, 1].Text = "완료";

            btnConfBox.RedrawButtons();

            btnDayNight.CountX = 2;
            btnDayNight.CountY = 1;

            btnDayNight.SetButtons();

            btnDayNight[0, 0].Text = "주간";
            btnDayNight[0, 0].Tag = "D";
            btnDayNight[0, 1].Text = "야간";
            btnDayNight[0, 1].Tag = "N";

            btnDayNight.GetButtonByTag(Common.gDayNight).ButtonPressed = true;
            //btnDayNight[0, 0].ButtonPressed = true;

            btnDayNight.RedrawButtons();
        }

        private void lblResultStateChange(string sResultCode, string sText)
        {
            MESLabel lbl = null;

            switch (sResultCode)
            {
                case "Result1":
                    lbl = lblResult1;
                    break;
                case "Result2":
                    lbl = lblResult2;
                    break;
                case "Result3":
                    lbl = lblResult3;
                    break;
            }

            lbl.Text = clsDB.nvlString(hash[sText]);

            switch (sText)
            {
                case "Y":
                    lbl.BackColor = Color.DeepSkyBlue;
                    break;
                case "N":
                    lbl.BackColor = Color.Red;
                    break;
            }
        }


        private void SetHash()
        {
            DataTable dt = GetTBM0000Code("INSPRESULT");
            hash = new Hashtable();

            foreach (DataRow dr in dt.Rows)
            {
                hash.Add(clsDB.nvlString(dr["CODE_ID"]), clsDB.gGetName(dr["CODE_NAME"]));
            }
        }

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            switch (sender.Text)
            {
                case "조회" :
                    DoFind();

                    break;
                case "완료":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void CheckResult(string sDataCode, string sResultCode)
        {
            bool bResult = true;
            int iTotal, itCount;

            iTotal = mesGrid1.Rows.Count * 3;

            // Y 여부 및 리스트 데이터 처리
            int iCount = 0;

            for (int i = 0; i < mesGrid1.Rows.Count; i++)
            {
                if (mesGrid1.Rows[i].Cells["RstData1"].Value.ToString() != "")
                {
                    iCount++;
                }

                if (mesGrid1.Rows[i].Cells["RstData2"].Value.ToString() != "")
                {
                    iCount++;
                }

                if (mesGrid1.Rows[i].Cells["RstData3"].Value.ToString() != "")
                {
                    iCount++;
                }

                if (mesGrid1.Rows[i].Cells[sResultCode].Value.ToString() == "N")
                {
                    bResult = false;
                    mesGrid1.Rows[i].Cells[sDataCode].Appearance.ForeColor = Color.Red;
                }
                else
                {
                    mesGrid1.Rows[i].Cells[sDataCode].Appearance.ForeColor = Color.Blue;
                }
            }

            if (bResult)
            {
                lblResultStateChange(sResultCode, "Y");
            }
            else
            {
                lblResultStateChange(sResultCode, "N");
            }

            itCount = (mesGrid1.Rows.Count * 3) - iCount;

            txtTotal.Text = itCount.ToString() + " / " + iTotal.ToString();
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            string sDataCode = "", sResultCode = "";

            List<int> modList = new List<int>();

            DoProgress();

            try
            {
                if (e._UltraGridColumn != null)
                {
                    if (clsDB.nvlString(e._UltraGridRow.Cells["SPCFLAG"].Value) != "Y")
                    {
                        if (e._UltraGridColumn.Header.Caption == "작업자")
                        {
                            DA0210 da2100 = new DA0210(
                                clsDB.nvlString(e._UltraGridRow.Cells["WorkerID"].Value) == "" ? lastWorkerID : clsDB.nvlString(e._UltraGridRow.Cells["WorkerID"].Value)
                               , clsDB.nvlString(e._UltraGridRow.Cells["WorkerName"].Value) == "" ? lastWorkerName : clsDB.nvlString(e._UltraGridRow.Cells["WorkerName"].Value)
                                );

                            if (DialogResult.OK == ShowDialogForm(da2100))
                            {
                                e._UltraGridRow.Cells["WorkerID"].Value = da2100.WorkerID;
                                e._UltraGridRow.Cells["WorkerName"].Value = da2100.WorkerName;

                                lastWorkerID = da2100.WorkerID;
                                lastWorkerName = da2100.WorkerName;
                            }

                            if (!modList.Contains(e._UltraGridRow.Index))
                                modList.Add(e._UltraGridRow.Index);
                        }

                        if (e._UltraGridColumn.Header.Caption == "초품" || e._UltraGridColumn.Header.Caption == "중품" || e._UltraGridColumn.Header.Caption == "종품")
                        {
                            switch (e._UltraGridColumn.Header.Caption)
                            {
                                case "초품":
                                    sDataCode = "RstData1";
                                    sResultCode = "Result1";
                                    break;
                                case "중품":
                                    sDataCode = "RstData2";
                                    sResultCode = "Result2";
                                    break;
                                case "종품":
                                    sDataCode = "RstData3";
                                    sResultCode = "Result3";
                                    break;
                            }

                            string sOK = "Y", sNG = "N";

                            if (clsDB.nvlString(e._UltraGridRow.Cells["RelCode3"].Value) != "Y")
                            {
                                sNG = "Y";
                            }

                            string sOKItem = clsDB.nvlString(e._UltraGridRow.Cells["RelCode1"].Value);
                            string sNGItem = clsDB.nvlString(e._UltraGridRow.Cells["RelCode2"].Value);

                            string sValType = clsDB.gGetCode(e._UltraGridRow.Cells["InspValType"].Value);

                            if (sOKItem == "" && sNGItem == "")
                            {
                                // 수치값 입력
                                DA9400 d94 = new DA9400(new string[] { txtItemCode.Text
                                    , clsDB.nvlString( e._UltraGridRow.Cells["InspCode"].Value)
                                    , clsDB.nvlString( e._UltraGridRow.Cells[sDataCode].Value) });

                                DialogResult d = this.ShowDialogForm(d94);
                                double dValue = 0;
                                string sValue = "";

                                if (d == System.Windows.Forms.DialogResult.OK)
                                {
                                    dValue = clsDB.nvlDouble(d94.resultString);
                                    sValue = d94.resultString;
                                }

                                if (d == System.Windows.Forms.DialogResult.Yes)
                                {
                                    DA9100 d4 = new DA9100();
                                    d4.LabelTitle = "측정치 입력";
                                    d4.LabelHeader = "측정치";
                                    d4.ContentText = "";

                                    d = ShowDialogForm(d4);
                                    dValue = clsDB.nvlDouble(d4.ResultString);
                                    sValue = d4.ResultString;
                                }

                                if (DialogResult.OK == d)
                                {
                                    if (sValue != "")
                                    {
                                        double dLSL, dUSL;
                                        e._UltraGridRow.Cells[sDataCode].Value = dValue;

                                        dValue = clsDB.nvlDouble(e._UltraGridRow.Cells[sDataCode].Value);
                                        dLSL = clsDB.nvlDouble(e._UltraGridRow.Cells["ManaLSL"].Value);
                                        dUSL = clsDB.nvlDouble(e._UltraGridRow.Cells["ManaUSL"].Value);

                                        if (e._UltraGridRow.Cells["ManaLSL"].Value == DBNull.Value)
                                        {
                                            // 하한이 없을 경우
                                            if (dUSL < dValue)
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sNG;
                                            }
                                            else
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sOK;
                                            }
                                        }
                                        else if (e._UltraGridRow.Cells["ManaUSL"].Value == DBNull.Value)
                                        {
                                            // 상한이 없을 경우
                                            if (dLSL > dValue)
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sNG;
                                            }
                                            else
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sOK;
                                            }
                                        }
                                        else
                                        {
                                            if (dLSL > dValue || dUSL < dValue)
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sNG;
                                            }
                                            else
                                            {
                                                e._UltraGridRow.Cells[sResultCode].Value = sOK;
                                            }
                                        }

                                        if (!modList.Contains(e._UltraGridRow.Index))
                                            modList.Add(e._UltraGridRow.Index);
                                    }
                                    else
                                    {
                                        e._UltraGridRow.Cells[sDataCode].Value = "";
                                        e._UltraGridRow.Cells[sResultCode].Value = "";
                                    }
                                }
                            }
                            else
                            {
                                DA9300 d1 = new DA9300();
                                d1.ButtonCount = 4;
                                d1.ButtonNames[0] = sOKItem;
                                d1.ButtonNames[1] = sNGItem;
                                d1.ButtonNames[2] = "삭제";
                                d1.ButtonNames[3] = "취소";

                                d1.StartPosition = FormStartPosition.Manual;
                                d1.Location = new Point(Cursor.Position.X - d1.Width, Cursor.Position.Y - d1.Size.Height - 10);

                                DialogResult dResult =  ShowDialogForm(d1);
                                if (DialogResult.OK == dResult)
                                {
                                    int iRet1 = d1.ReturnValue;

                                    if (iRet1 == 0)
                                    {
                                        e._UltraGridRow.Cells[sDataCode].Value = sOKItem;
                                        e._UltraGridRow.Cells[sResultCode].Value = sOK;
                                    }
                                    else if (iRet1 == 1)
                                    {
                                        e._UltraGridRow.Cells[sDataCode].Value = sNGItem;
                                        e._UltraGridRow.Cells[sResultCode].Value = sNG;
                                    }

                                    if (!modList.Contains(e._UltraGridRow.Index))
                                        modList.Add(e._UltraGridRow.Index);

                                    for (int ia = e._UltraGridRow.Index + 1; ia < mesGrid1.Rows.Count; ia++)
                                    {
                                        string sValType2 = clsDB.gGetCode(mesGrid1.Rows[ia].Cells["InspValType"].Value);

                                        if (sValType == sValType2)
                                        {
                                            if (clsDB.nvlString(mesGrid1.Rows[ia].Cells[sDataCode].Value) == "")
                                            {
                                                mesGrid1.Rows[ia].Cells[sDataCode].Value = e._UltraGridRow.Cells[sDataCode].Value;
                                                mesGrid1.Rows[ia].Cells[sResultCode].Value = e._UltraGridRow.Cells[sResultCode].Value;

                                                if (!modList.Contains(ia))
                                                    modList.Add(ia);
                                            }
                                        }
                                    }
                                }
                                else if (DialogResult.Abort == dResult)
                                {
                                    // 삭제 처리
                                    e._UltraGridRow.Cells[sDataCode].Value = "";
                                    e._UltraGridRow.Cells[sResultCode].Value = "";
                                }
                            }
                        }

                        if (sDataCode != "")
                        {
                            if (e._UltraGridRow.Cells[sResultCode].Value.ToString() == "Y")
                            {
                                e._UltraGridCell.Appearance.ForeColor = Color.Blue;
                            }
                            else
                            {
                                e._UltraGridCell.Appearance.ForeColor = Color.Red;
                            }

                            CheckResult(sDataCode, sResultCode);
                        }

                        DoProgress();
                        DataExecute(modList);
                    }
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

        private void DataExecute(List<int> listRow)
        {
            foreach (int i in listRow)
            {
                DataProcess(mesGrid1.Rows[i]);
            }

            listRow.Clear();
        }

        private void DataProcess(UltraGridRow row)
        {
            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection con = (SqlConnection)db.CreateConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.CommandText = "USP_DA1120_I1";

            if (clsDB.nvlString(row.Cells["WorkerID"].Value) == "")
            {
                row.Cells["WorkerID"].Value = txtWorker.Tag.ToString();
                row.Cells["WorkerName"].Value = txtWorker.Text;
            }

            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
            cmd.Parameters.Add(new SqlParameter("@pItemCode", txtItemCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pDate", dtpStartDate.Value.ToString("yyyy-MM-dd")));
            cmd.Parameters.Add(new SqlParameter("@pDayNight", btnDayNight.GetSelectedButtons()[0].Tag.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspCode", row.Cells["InspCode"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pWorkerID", row.Cells["WorkerID"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspValue1", row.Cells["RstData1"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspResult1", row.Cells["Result1"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspValue2", row.Cells["RstData2"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspResult2", row.Cells["Result2"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspValue3", row.Cells["RstData3"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspResult3", row.Cells["Result3"].Value.ToString()));

            if (!clsDB.gExecuteProcedure(con, cmd))
            {
                //  오류 발생시
                SetMessage(clsDB.ErrorDesc);
                return;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DoProgress();
            DoFind();
            CloseProgressForm();
        }

        private void btnDayNight_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            DoProgress();
            DoFind();
            CloseProgressForm();
        }

        private void txtWorker_Click(object sender, EventArgs e)
        {
            DA0210 da2100 = new DA0210(lastWorkerID, lastWorkerName);

            if (DialogResult.OK == ShowDialogForm(da2100))
            {
                txtWorker.Tag = da2100.WorkerID;
                txtWorker.Text = da2100.WorkerName;

                Common.worker_DA1120.ID = txtWorker.Tag.ToString();
                Common.worker_DA1120.Name = txtWorker.Text;

                lastWorkerID = da2100.WorkerID;
                lastWorkerName = da2100.WorkerName;
            }
        }

        private void txtItemCode_Click(object sender, EventArgs e)
        {
            if (btnItem.Visible)
            {
                DA9500 d1 = new DA9500();
                d1.LabelTitle = "품번선택";

                if (DialogResult.OK == ShowDialogForm(d1))
                {
                    if (d1.resultArray != null)
                    {
                        if (d1.resultArray.Length == 2)
                        {
                            txtItemCode.Text = d1.resultArray[0];
                            txtItemName.Text = d1.resultArray[1];

                            DoFind();
                        }
                    }
                }
            }
        }
    }
}
