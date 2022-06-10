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
    public partial class DA7020 : SmartDas.Components.BaseForm
    {
        public string sSearchflag = string.Empty;

        private WorkCenter wc = Common.SelectedWorkCenter;

        public DA7020()
        {
            InitializeComponent();
        }

        private void DA7020_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@startdate", dtpStartDate.Value.ToString("yyyy-MM-dd")));
            mesGrid1.ParameterList.Add(new SqlParameter("@Enddate", dtpEndDate.Value.ToString("yyyy-MM-dd")));
            mesGrid1.ParameterList.Add(new SqlParameter("@Div", txtSMSSendType.Tag.ToString()));
            mesGrid1.ParameterList.Add(new SqlParameter("@Div1", "O"));
            mesGrid1.CellClickActionType = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            mesGrid1.DoFind();
            mesGrid1.SelectFirstRow();
         }

        private void Init()
        {
            txtWorkCenterCode.Text = "";// wc.Code;
            txtWorkCenterName.Text = "";// wc.Name;

            txtMoldRepairCode.Text = string.Empty;
            txtMoldRepairName.Text = string.Empty;
            txtMoldPartSpec.Text = string.Empty;
            txtMoldPartQty.Text = string.Empty;

            txtWorkerCode.Text = string.Empty;
            txtWorkerName.Text = string.Empty;
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 3;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "수리\n완료";
            btnConfBox[0, 1].Text = "조회";
            btnConfBox[0, 2].Text = "추가";

            btnConfBox.RedrawButtons();

            btnSelection.CountX = 5;
            btnSelection.CountY = 2;

            btnSelection.ButtonBoxType = ButtonBox.ButtonBoxTypeEnum.Selection;
            btnSelection.SelectionMode = ButtonBox.SelectionModeEnum.None;

            btnSelection.SelectProcedureName = "USP_DA7100_S5";
            btnSelection.SetStoreProc();

            btnSelection.SetButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 12;
            mesGrid1.SelectProcedureName = "USP_DA7020_S1";
            mesGrid1.CountRows = 4;
            mesGrid1.GetStoreProcedure();

            mesGrid2.FontSize = 12;
            mesGrid2.SelectProcedureName = "USP_DA7100_S2";
            mesGrid2.CountRows = 4;
            mesGrid2.GetStoreProcedure();

            mesGrid3.FontSize = 12;
            mesGrid3.SelectProcedureName = "USP_DA7100_S3";
            mesGrid3.CountRows = 4;
            mesGrid3.GetStoreProcedure();

            mesGrid4.FontSize = 12;
            mesGrid4.SelectProcedureName = "USP_DA7100_S4";
            mesGrid4.CountRows = 4;
            mesGrid4.GetStoreProcedure();
        }

        private void DoFind()
        {
            // 조회
            //mesGrid4.ParameterList.Clear();
            //mesGrid4.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            //mesGrid4.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            //mesGrid4.ParameterList.Add(new SqlParameter("@searchflag", sSearchflag));

            //mesGrid4.DoFind();

            //if (btnSelection.ParameterList != null)
            btnSelection.ParameterList.Clear();
            btnSelection.ParameterList.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            btnSelection.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", txtWorkCenterCode.Text));
            btnSelection.ParameterList.Add(new SqlParameter("@searchflag", sSearchflag));

            btnSelection.DoFind();

            btnConfBox.RedrawButtons();
            if (sSearchflag == "6") //작업자
                btnSelection.SelectionMode = ButtonBox.SelectionModeEnum.Multiple;
            else
                btnSelection.SelectionMode = ButtonBox.SelectionModeEnum.Single;
        }

     
        private void btnConfBox_buttonClickEvent(Components.MESButton sender, Components.ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "수리\n완료":

                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }

                        if (mesGrid1.Row == null)
                        {
                            SetMessage("처리할 금형보전항목을 선택하십시오.");
                            return;
                        }
                        if (txtWorkerCode.Text == "")
                        {
                            SetMessage("작업자을 선택하십시오.");
                            return;

                        }
                        if (mesGrid3.Rows.Count == 0)
                        {
                            SetMessage("수리내역을 등록하십시오.");
                            return;
                        }
                        //WorkCenter wc = Common.SelectedWorkCenter;

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA7100_I0";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@pMoldCode", clsDB.nvlString(mesGrid1.Row.Cells["MoldCode"].Value)));
                        cmd.Parameters.Add(new SqlParameter("@pRecDate", clsDB.nvlString(mesGrid1.Row.Cells["RecDate"].Value)));
                        cmd.Parameters.Add(new SqlParameter("@Seq", clsDB.nvlInt(mesGrid1.Row.Cells["Seq"].Value)));

                        cmd.Parameters.Add(new SqlParameter("@pRepairWorker", txtWorkerCode.Text));
                        cmd.Parameters.Add(new SqlParameter("@pRepairFlag", 'Y'));
                        cmd.Parameters.Add(new SqlParameter("@pRemark", txtRemark.Text));
                        cmd.Parameters.Add(new SqlParameter("@pRepairWorkerNm", txtWorkerName.Text));



                        if (clsDB.gExecute(conn, cmd) < 0)
                        {
                            // 오류 발생시
                            SetMessage(clsDB.ErrorDesc);
                            return;
                        }
                        txtRemark.Text = "";
                        txtWorkerCode.Text = "";
                        txtWorkerName.Text = "";

                        mesGrid1.Row.Cells["RepairDate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case "조회":
                        mesGrid1.ParameterList.Clear();
                        mesGrid1.ParameterList.Add(new SqlParameter("@startdate", dtpStartDate.Value.ToString("yyyy-MM-dd")));
                        mesGrid1.ParameterList.Add(new SqlParameter("@Enddate", dtpEndDate.Value.ToString("yyyy-MM-dd")));
                        mesGrid1.ParameterList.Add(new SqlParameter("@Div", txtSMSSendType.Tag.ToString()));
                        mesGrid1.ParameterList.Add(new SqlParameter("@Div1", mesLabel10.Text == "고장일자"?"O":"R"));

                        mesGrid1.DoFind();
                        mesGrid1.SelectFirstRow();
                        mesGrid2.SelectFirstRow();

                        // this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                    case "추가":
                        DA9810 da9810 = new DA9810();

                        if (DialogResult.OK == ShowDialogForm(da9810))
                        {
                            mesGrid1.DoFind();
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.ToString());
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }
        }

        //private void DA7020_Load(object sender, EventArgs e)
        //{
        //    txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
        //    txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
        //    txtMoldCode.Text = sMachcode;
        //    txtMoldName.Text = sMachname;
        //}



        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (mesGrid3.DataSourceDS.Tables.Count > 0)
                mesGrid3.DataSourceDS.Tables[1].Rows.Clear();

            if(e._UltraGridRow.Index > -1)
            {
                txtWorkCenterCode.Text = e._UltraGridRow.Cells["WORKCENTERCODE"].Value.ToString();
               // txtWorkCenterName.Text = e.row.Cells["WorkCenterName"].Value.ToString();
                txtRemark.Text = e._UltraGridRow.Cells["Remark"].Value.ToString();

                if (e._UltraGridRow.Cells["RepairDate"].Value.ToString() != "" && e._UltraGridRow.Cells["RepairDate"].Value.ToString().CompareTo(DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd")) <0  )
                {
                    btnConfBox[0, 0].Enable = false;
                    btnSave_2.Enabled = false;
                    btnSave_3.Enabled = false;
                    txtWorkerCode.Text = e._UltraGridRow.Cells["RepairWorker"].Value.ToString();
                    txtWorkerName.Text = e._UltraGridRow.Cells["RepairWorkerNm"].Value.ToString();
                    
                }
                else
                {
                    btnConfBox[0, 0].Enable = true;
                    btnSave_2.Enabled = true;
                    btnSave_3.Enabled = true;

                }
                // 조회
                mesGrid2.ParameterList.Clear();
                mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", txtWorkCenterCode.Text));
                mesGrid2.ParameterList.Add(new SqlParameter("@pMoldCode", clsDB.nvlString(e._UltraGridRow.Cells["MoldCode"].Value)));
                mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", clsDB.nvlString(e._UltraGridRow.Cells["RecDate"].Value)));
                mesGrid2.ParameterList.Add(new SqlParameter("@Seq",  clsDB.nvlInt(e._UltraGridRow.Cells["Seq"].Value)));

                mesGrid2.DoFind();

                mesGrid2.SelectFirstRow();
                //e.row.Cells[""]

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mesGrid2.Row != null && mesGrid2.Row.Index > -1)
            {
                mesGrid2.DataSourceDS.Tables[1].Rows[mesGrid2.Row.Index].Delete();
                mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            }
        }

        private void txtMoldRepairCode_Click(object sender, EventArgs e)
        {
            sSearchflag = "1";
            DoFind();

            btnUp_4.Enabled = true;
            btnDown_4.Enabled = true;
            //mesLabel3.Text = Labelmacherror.Text;
        }

        private void txtworker_Click(object sender, EventArgs e)
        {
            sSearchflag = "6";
            DoFind();

            btnUp_4.Enabled = true;
            btnDown_4.Enabled = true;
            foreach (ButtonData btn in btnSelection.GetButtonList())
            {
                if (txtWorkerCode.Text.IndexOf(btn.Tag.ToString()) != -1)
                    btn.ButtonPressed = true;
            }
            //mesLabel3.Text = Labelworker.Text;
        }

        private void txtMoldPartSpec_Click(object sender, EventArgs e)
        {
            DA9100 da9100 = new DA9100();
            da9100.LabelTitle = "규격(Ø) 입력";
            da9100.LabelHeader = "규격(Ø)";

            if (DialogResult.OK == ShowDialogForm(da9100))
            {
                txtMoldPartSpec.Text = da9100.ResultString;
            }
        }

        private void txtMoldPartQty_Click(object sender, EventArgs e)
        {
            DA9100 da9100 = new DA9100();
            da9100.LabelTitle = "수량(EA) 입력";
            da9100.LabelHeader = "수량(EA)";

            if (DialogResult.OK == ShowDialogForm(da9100))
            {
                txtMoldPartQty.Text = da9100.ResultString;
            }
        }

        //private void mesGrid4_GridClick(object sender, MESGrid.GridClickEventArg e)
        //{
        //    if (mesGrid2.Row == null)
        //    {
        //        SetMessage("고장 내역을 선택하세요.");
        //        return;
        //    }

        //    switch (sSearchflag)
        //    {
        //        case "1":
        //            mesGrid2.Row.Cells["MoldErrCode"].Value = e.row.Cells["FaultCode"].Value;
        //            mesGrid2.Row.Cells["MoldErrName"].Value = e.row.Cells["FaultName"].Value;
        //            break;

        //        case "2":
        //            mesGrid2.Row.Cells["MoldErrLocCode1"].Value = e.row.Cells["FaultCode"].Value;
        //            mesGrid2.Row.Cells["MoldErrLocName1"].Value = e.row.Cells["FaultName"].Value;
        //            break;

        //        case "3":
        //            mesGrid2.Row.Cells["MoldErrLocCode2"].Value = e.row.Cells["FaultCode"].Value;
        //            mesGrid2.Row.Cells["MoldErrLocName2"].Value = e.row.Cells["FaultName"].Value;
        //            break;

        //        case "4":
        //            mesGrid2.Row.Cells["MoldErrDivCode"].Value = e.row.Cells["FaultCode"].Value;
        //            mesGrid2.Row.Cells["MoldErrDivName"].Value = e.row.Cells["FaultName"].Value;
        //            break;

        //        case "5":
        //            if (mesGrid3.Row == null)
        //            {
        //                SetMessage("수리 내역을 선택하세요.");
        //                return;
        //            }
        //            mesGrid3.Row.Cells["MoldRepairCode"].Value = e.row.Cells["FaultCode"].Value;
        //            mesGrid3.Row.Cells["MoldRepairName"].Value = e.row.Cells["FaultName"].Value;
        //            break;
        //        case "7":
        //            if (mesGrid3.Row == null)
        //            {
        //                SetMessage("수리 내역을 선택하세요.");
        //                return;
        //            }
        //             mesGrid3.Row.Cells["RepairItem"].Value = e.row.Cells["FaultCode"].Value;
        //             mesGrid3.Row.Cells["RepairItemNM"].Value = e.row.Cells["FaultName"].Value;
        //            break;

        //        case "6":
        //            txtWorkerCode.Text = e.row.Cells["FaultCode"].Value.ToString();
        //            txtWorkerName.Text = e.row.Cells["FaultName"].Value.ToString();
        //            break;
        //    }
        //    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
        //    mesGrid3.DataSourceDS.Tables[1].AcceptChanges();
        //}

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridRow == null || e._UltraGridRow.Index < 0)   return;

            bool bGrid2Saved;
            bGrid2Saved = !string.IsNullOrEmpty(e._UltraGridRow.Cells["UnitSeq"].Value.ToString());
            btnNew_3.Enabled = bGrid2Saved;
            btnDelete_3.Enabled = bGrid2Saved;
            btnSave_3.Enabled = btnSave_2.Enabled ? bGrid2Saved : btnSave_2.Enabled;

            if (e._UltraGridColumn.ToString() == "MoldErrName")
            {
                sSearchflag = "1";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }

            if (e._UltraGridColumn.ToString() == "MoldErrLocName1")
            {
                sSearchflag = "2";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }

            if (e._UltraGridColumn.ToString() == "MoldErrLocName2")
            {
                sSearchflag = "3";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }

            if (e._UltraGridColumn.ToString() == "MoldErrDivName")
            {
                sSearchflag = "4";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }

            // 조회
            mesGrid3.ParameterList.Clear();
            mesGrid3.ParameterList.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            mesGrid3.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", txtWorkCenterCode.Text));
            mesGrid3.ParameterList.Add(new SqlParameter("@pMoldCode", clsDB.nvlString(e._UltraGridRow.Cells["MoldCode"].Value)));
            mesGrid3.ParameterList.Add(new SqlParameter("@pRecDate", clsDB.nvlString(e._UltraGridRow.Cells["RecDate"].Value)));
            mesGrid3.ParameterList.Add(new SqlParameter("@Seq", clsDB.nvlInt(e._UltraGridRow.Cells["Seq"].Value)));
            mesGrid3.ParameterList.Add(new SqlParameter("@UnitSeq", clsDB.nvlInt(e._UltraGridRow.Cells["UnitSeq"].Value)));

            mesGrid3.DoFind();

        }

        private void btnNew_2_Click(object sender, EventArgs e)
        {
            if (mesGrid1.Row == null || mesGrid1.Row.Index < 0)
            {
                SetMessage("고장을 선택하세요.");
                return;
            }

            DataRow dr = mesGrid2.DataSourceDS.Tables[1].NewRow();

            mesGrid2.DataSourceDS.Tables[1].Rows.InsertAt(dr, mesGrid2.DataSourceDS.Tables[1].Rows.Count);

            mesGrid2.GetGrid();
        }

        private void btnDelete_2_Click(object sender, EventArgs e)
        {
            if (mesGrid1.Row == null || mesGrid1.Row.Index < 0)
            {
                SetMessage("고장을 선택하세요.");
                return;
            }

            if (mesGrid2.Row == null || mesGrid2.Row.Index < 0)
            {
                SetMessage("삭제할 고장 내역을 선택하세요.");
                return;
            }

            if (mesGrid3.Rows.Count > 0)
            {
                SetMessage("등록된 수리 내역이 존재하여 삭제할 수 없습니다.");
                return;
            }

            //if (string.IsNullOrEmpty(mesGrid2.Row.Cells["UnitSeq"].Value.ToString()))
            //{
                mesGrid2.Row.Delete(false);
                mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            //}
            //else
            //{
            //    mesGrid2.Row.Cells["UnitSeq"].Value = Convert.ToInt32(mesGrid2.Row.Cells["UnitSeq"].Value) * -1;
            //}
        }

        private void btnSave_2_Click(object sender, EventArgs e)
        {
            if (mesGrid1.Row == null)
            {
                SetMessage("고장을 선택하세요.");
                return;
            }

            WorkCenter wc = Common.SelectedWorkCenter;

            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "USP_DA7100_D1";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pMoldCode", mesGrid1.Row.Cells["MoldCode"].Value));
            cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid1.Row.Cells["RecDate"].Value));
            cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid1.Row.Cells["Seq"].Value));

            if (clsDB.gExecute(conn, cmd) < 0)
            {
                // 오류 발생시
                SetMessage(clsDB.ErrorDesc);
                return;
            }

            cmd.CommandText = "USP_DA7100_I2";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pMoldCode", mesGrid1.Row.Cells["MoldCode"].Value));
            cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid1.Row.Cells["RecDate"].Value));
            cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid1.Row.Cells["Seq"].Value));

            cmd.Parameters.Add(new SqlParameter("@UnitSeq", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@pMoldErrCode", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pMoldErrLocCode1", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pMoldErrLocCode2", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pMoldErrDivCode", SqlDbType.VarChar, 10));

            foreach (DataRow dr in mesGrid2.DataSourceDS.Tables[1].Rows)
            {
                cmd.Parameters["@UnitSeq"].Value = dr["UnitSeq"];
                cmd.Parameters["@pMoldErrCode"].Value = dr["MoldErrCode"];
                cmd.Parameters["@pMoldErrLocCode1"].Value = dr["MoldErrLocCode1"];
                cmd.Parameters["@pMoldErrLocCode2"].Value = dr["MoldErrLocCode2"];
                cmd.Parameters["@pMoldErrDivCode"].Value = dr["MoldErrDivCode"];

                if (clsDB.gExecute(conn, cmd) < 0)
                {
                    // 오류 발생시
                    SetMessage(clsDB.ErrorDesc);
                    return;
                }
            }

            mesGrid2.DoFind();

            if (mesGrid3.DataSourceDS.Tables.Count > 0)
                mesGrid3.DataSourceDS.Tables[1].Rows.Clear();

            SetMessage("고장 내역이 저장되었습니다.");
        }

        private void btnNew_3_Click(object sender, EventArgs e)
        {
            if (mesGrid2.Row == null || mesGrid2.Row.Index < 0)
            {
                SetMessage("고장 내역을 선택하세요.");
                return;
            }

            DataRow dr = mesGrid3.DataSourceDS.Tables[1].NewRow();

            mesGrid3.DataSourceDS.Tables[1].Rows.InsertAt(dr, mesGrid3.DataSourceDS.Tables[1].Rows.Count);

            mesGrid3.GetGrid();
        }

        private void mesGrid3_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridRow == null || e._UltraGridRow.Index < 0) return;

            if (e._UltraGridColumn.ToString() == "MoldRepairName")
            {
                sSearchflag = "5";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }
            if (e._UltraGridColumn.ToString() == "RepairItemNM")
            {
                sSearchflag = "7";
                DoFind();

                btnUp_4.Enabled = true;
                btnDown_4.Enabled = true;
            }

            if (e._UltraGridColumn.ToString() == "MoldPartSpec")
            {
                DA9210 da9210 = new DA9210();
                da9210.LabelTitle = "규격(Ø) 입력";
                da9210.LabelHeader = "규격(Ø)";

                if (DialogResult.OK == ShowDialogForm(da9210))
                    e._UltraGridCell.Value = da9210.resultString;
            }
            if (e._UltraGridColumn.ToString() == "MoldPartNo")
            {
                DA9210 da9210 = new DA9210();
                da9210.LabelTitle = "No 입력";
                da9210.LabelHeader = "No";

                if (DialogResult.OK == ShowDialogForm(da9210))
                    e._UltraGridCell.Value = da9210.resultString;
            }
            if (e._UltraGridColumn.ToString() == "MoldPartQty")
            {
                DA9100 da9100 = new DA9100();
                da9100.LabelTitle = "수량 입력";
                da9100.LabelHeader = "수량";

                if (DialogResult.OK == ShowDialogForm(da9100))
                    e._UltraGridCell.Value = da9100.ResultString;
            }
            if (e._UltraGridColumn.ToString() == "Remark")
            {
                DA9120 da9120 = new DA9120();

                if (DialogResult.OK == ShowDialogForm(da9120))
                    e._UltraGridCell.Value = da9120.ResultString;
            }
        }

        private void btnDelete_3_Click(object sender, EventArgs e)
        {
            if (mesGrid3.Row == null || mesGrid3.Row.Index < 0)
            {
                SetMessage("삭제할 수리 내역을 선택하세요.");
                return;
            }

            mesGrid3.Row.Delete(false);
            mesGrid3.DataSourceDS.Tables[1].AcceptChanges();
        }

        private void btnSave_3_Click(object sender, EventArgs e)
        {
            if (mesGrid2.Row == null)
            {
                SetMessage("고장 항목을 선택하세요");
                return;
            }
            
            //WorkCenter wc = Common.SelectedWorkCenter;

            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "USP_DA7100_D2";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pMoldCode", mesGrid2.Row.Cells["MoldCode"].Value));
            cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid2.Row.Cells["RecDate"].Value));
            cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid2.Row.Cells["Seq"].Value));
            cmd.Parameters.Add(new SqlParameter("@UnitSeq", mesGrid2.Row.Cells["UnitSeq"].Value));

            if (clsDB.gExecute(conn, cmd) < 0)
            {
                // 오류 발생시
                SetMessage(clsDB.ErrorDesc);
                return;
            }

            cmd.CommandText = "USP_DA7100_I3";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pMoldCode", mesGrid2.Row.Cells["MoldCode"].Value));
            cmd.Parameters.Add(new SqlParameter("@RecDate", mesGrid2.Row.Cells["RecDate"].Value));
            cmd.Parameters.Add(new SqlParameter("@Seq", mesGrid2.Row.Cells["Seq"].Value));
            cmd.Parameters.Add(new SqlParameter("@UnitSeq", mesGrid2.Row.Cells["UnitSeq"].Value));

            cmd.Parameters.Add(new SqlParameter("@RepairSeq", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@pMoldRepairCode", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pMoldPartSpec", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@pMoldPartNo", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@pMoldPartQty", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@pRemark", SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@pRepairItem", SqlDbType.VarChar, 255));

            foreach (DataRow dr in mesGrid3.DataSourceDS.Tables[1].Rows)
            {
                cmd.Parameters["@RepairSeq"].Value = dr["RepairSeq"];
                cmd.Parameters["@pMoldRepairCode"].Value = dr["MoldRepairCode"];
                cmd.Parameters["@pMoldPartSpec"].Value = dr["MoldPartSpec"];
                cmd.Parameters["@pMoldPartNo"].Value = dr["MoldPartNo"];
                cmd.Parameters["@pMoldPartQty"].Value = dr["MoldPartQty"];
                cmd.Parameters["@pRemark"].Value = dr["Remark"];
                cmd.Parameters["@pRepairItem"].Value = dr["RepairItem"];

                if (clsDB.gExecute(conn, cmd) < 0)
                {
                    // 오류 발생시
                    SetMessage(clsDB.ErrorDesc);
                    return;
                }
            }

            mesGrid3.DoFind();

            SetMessage("수리 내역이 저장되었습니다.");
        }

        private void btnSelection_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            //if (mesGrid2.Row == null)
            //{
            //    SetMessage("고장 내역을 선택하세요.");
            //    return;
            //}

            switch (sSearchflag)
            {
                case "1":
                    mesGrid2.Row.Cells["MoldErrCode"].Value = sender.Tag.ToString();
                    mesGrid2.Row.Cells["MoldErrName"].Value = sender.Text;
                    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
                    break;

                case "2":
                    mesGrid2.Row.Cells["MoldErrLocCode1"].Value = sender.Tag.ToString();
                    mesGrid2.Row.Cells["MoldErrLocName1"].Value = sender.Text;
                    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
                    break;

                case "3":
                    mesGrid2.Row.Cells["MoldErrLocCode2"].Value = sender.Tag.ToString();
                    mesGrid2.Row.Cells["MoldErrLocName2"].Value = sender.Text;
                    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
                    break;

                case "4":
                    mesGrid2.Row.Cells["MoldErrDivCode"].Value = sender.Tag.ToString();
                    mesGrid2.Row.Cells["MoldErrDivName"].Value = sender.Text;
                    mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
                    break;

                case "5":
                    //if (mesGrid3.Row == null)
                    //{
                    //    SetMessage("수리 내역을 선택하세요.");
                    //    return;
                    //}
                    mesGrid3.Row.Cells["MoldRepairCode"].Value = sender.Tag.ToString();
                    mesGrid3.Row.Cells["MoldRepairName"].Value = sender.Text;
                    mesGrid3.DataSourceDS.Tables[1].AcceptChanges();
                    break;
                case "7":
                    //if (mesGrid3.Row == null)
                    //{
                    //    SetMessage("수리 내역을 선택하세요.");
                    //    return;
                    //}
                    mesGrid3.Row.Cells["RepairItem"].Value = sender.Tag.ToString();
                    mesGrid3.Row.Cells["RepairItemNM"].Value = sender.Text;
                    break;
                case "6":
                   // 다중처리 
                        txtWorkerCode.Text ="";// sender.Tag.ToString();
                        txtWorkerName.Text = "";//sender.Text;
                    foreach (ButtonData btn in btnSelection.GetSelectedButtons())
                    {
                        txtWorkerCode.Text += btn.Tag.ToString()+",";
                        txtWorkerName.Text += btn.Text + ",";
                    }
                    if (txtWorkerName.Text.Length > 1)
                    {
                        txtWorkerCode.Text = txtWorkerCode.Text.Substring(0, txtWorkerCode.Text.Length - 1);
                        txtWorkerName.Text = txtWorkerName.Text.Substring(0, txtWorkerName.Text.Length - 1);
                    }
                    break;
            }
        }

        private void btnNew_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wc.MoldCode))
            {
                SetMessage("장착된 금형이 없습니다.");
                return;
            }
                
            Database db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "USP_DA7100_I1";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.gsPlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", txtWorkCenterCode.Text));
            cmd.Parameters.Add(new SqlParameter("@pMoldCode", wc.MoldCode));
            cmd.Parameters.Add(new SqlParameter("@pErrorWorker", txtWorkerCode.Text));

            if (clsDB.gExecute(conn, cmd) < 0)
            {
                // 오류 발생시
                SetMessage(clsDB.ErrorDesc);
                return;
            }

            mesGrid1.DoFind();

            SetMessage("보전등록이 생성되었습니다.");
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            EventTimerEnable = false;
            Application.Exit();

        }

        private void lblMes_Click(object sender, EventArgs e)
        {
            DA9000 DA9000 = new DA9000();
            DA9000.Owner = this;
            ShowDialogForm(DA9000);

        }

        private void txtSMSSendType_Click(object sender, EventArgs e)
        {
            // SMS전체전송(A) -> SMS해당공정전송(D)
            mesLabel10.Text = "고장일자";
             switch (txtSMSSendType.Tag.ToString())
            {
                case "N":
                    txtSMSSendType.Text = "수리완료";
                    txtSMSSendType.Tag = "Y";
                    mesLabel10.Text = "수리일자";
                    break;
                case "Y":
                    txtSMSSendType.Text = "전체";
                    txtSMSSendType.Tag = "A";
                    break;
                case "A":
                    txtSMSSendType.Text = "미수리";
                    txtSMSSendType.Tag = "N";
                    break;
            }

        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            if (mesGrid1.Row == null)
                return;
            string prnv = "";
            prnv += mesGrid1.Row.Cells["WorkCenterName"].Value.ToString() + " : ";
            prnv += mesGrid1.Row.Cells["MoldName"].Value.ToString() + " : ";
            prnv += mesGrid1.Row.Cells["cartype"].Value.ToString() + " : ";
            prnv += mesGrid1.Row.Cells["ItemCode"].Value.ToString() + " : ";
            prnv += mesGrid1.Row.Cells["RecDate"].Value.ToString() + "|";

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in mesGrid2.Rows)
            {

                prnv += dr.Cells["UnitSeq"].Value.ToString() + " : ";
                prnv += dr.Cells["MoldErrName"].Value.ToString() + " : ";
                prnv += dr.Cells["MoldErrLocName1"].Value.ToString() + " : ";
                prnv += dr.Cells["MoldErrLocName2"].Value.ToString() + " : ";
                prnv += dr.Cells["MoldErrDivName"].Value.ToString() + "|";
            }

            LabelPrint lp = new LabelPrint(false);
            string[] vals = new string[] { prnv };
            lp.print("금형", vals,true, false); 


        }

        private void mesLabel10_Click(object sender, EventArgs e)
        {
            //if (mesLabel10.Text == "고장일자")
            //{
            //    mesLabel10.Text = "수리일자";
            //    txtSMSSendType.Text = "전체";
            //    txtSMSSendType.Tag = "A";

            //}
            //else
            //{
            //    mesLabel10.Text = "고장일자";
            //    txtSMSSendType.Text = "미수리";
            //    txtSMSSendType.Tag = "N";

            //}
        }

        private void txtRemark_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Windows\system32\osk.exe";
                process.Start();
            }
            catch { }
            txtRemark.Focus();

        }
    }
}
