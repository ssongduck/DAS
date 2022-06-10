using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SmartDas.Components;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SmartDas.POPUP;
using System.Data.SqlClient;
using System.Collections;

namespace SmartDas
{
    public partial class DA2300 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        public DA2300()
        {
            InitializeComponent();
        }

        private void DA2300_Load(object sender, EventArgs e)
        {
            SetGrid();

            Init();

            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);


            mesGrid1.Visible = true;
            mesGrid2.Visible = false;
            btnLeftPage.LinkGrid = mesGrid1;
            btnRightPage.LinkGrid = mesGrid1;

            btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
            btnRightPage.LinkMoveSize = mesGrid1.CountRows;

            dtpDate.Enabled = false;
            btnSearch.Enabled = false;
            SetButtons();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;

        }



        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

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



        private void SetGrid()
        {
            mesGrid1.FontSize = 15;
            mesGrid1.CountRows = 9;

            mesGrid1.SelectProcedureName = "USP_DA2300_S1";

            mesGrid2.FontSize = 15;

            mesGrid2.SelectProcedureName = "USP_DA2300_S2";
            mesGrid2.CountRows = 9;


        }

        private void DoFind()
        {
            if (mesGrid1.Visible)
            {
                mesGrid1.GetStoreProcedure();

                mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid1.DoFind();
            }
            else
            {
                mesGrid2.GetStoreProcedure();

                // 조회
                mesGrid2.ParameterList.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDate", SqlDbType.VarChar));

                mesGrid2.ParameterList["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
                mesGrid2.ParameterList["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;
                mesGrid2.ParameterList["@pDate"].Value = dtpDate.Value.ToString("yyyy-MM-dd");

                mesGrid2.DoFind();
            }
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
                    case "등록":
                       if (  DoSave())
                        DoFind();
                        // this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case "취소":
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

        private bool DoSave()
        {
            try
            {

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA2300_I1");
                if (mesGrid1.Visible)
                {

                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow ur in mesGrid1.Rows)
                    {
                        if (((ur.Cells["stopname"].Value.ToString() != ur.Cells["cstate"].Value.ToString() && ur.Cells["cdt"].Value.ToString() != "") ||
                              ur.Cells["cdt"].Value.ToString() == "") && ur.Cells["cstate"].Value.ToString() != "" && ur.Cells["cstate"].Value.ToString() != "가동")
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterOPCode", ur.Cells["WorkCenterOPCode"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pMachCode", ur.Cells["MachCode"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pStartDate", ur.Cells["cdt"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pStopCode", ur.Cells["Stopcode"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pRemark", ur.Cells["Remark"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pdiv", "S"));
                            cmd.Parameters.Add(new SqlParameter("@pMaker", ""));
                            db.ExecuteNonQuery(cmd);
                        }
                        if (ur.Cells["cdt"].Value.ToString() != "" && ur.Cells["cstate"].Value.ToString() == "가동")
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterOPCode", ur.Cells["WorkCenterOPCode"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pMachCode", ur.Cells["MachCode"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pStartDate", ur.Cells["cdt"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pStopCode", ""));
                            cmd.Parameters.Add(new SqlParameter("@pRemark", ur.Cells["Remark"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pdiv", "E"));
                            cmd.Parameters.Add(new SqlParameter("@pMaker", ""));
                            db.ExecuteNonQuery(cmd);
                        }
                    }
                }
                else
                {
                    cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA2300_U1");
                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow ur in mesGrid2.Rows)
                    {
                        if (ur.Cells["crud"].Value.ToString() == "U")
                        {
                            int sh = Convert.ToInt32(ur.Cells["StartDate"].Value.ToString().Substring(0, 2));
                            int eh = 99;
                            try
                            {
                                eh = Convert.ToInt32(ur.Cells["EndDate"].Value.ToString().Substring(0, 2));
                            }
                            catch { }
                            if (eh != 99)
                            {
                                if (sh < 8 && eh > 7 || ((sh < 8 && eh < 8 || sh > 7 && eh > 7) && ur.Cells["StartDate"].Value.ToString().CompareTo(ur.Cells["EndDate"].Value.ToString()) > 0))
                                {
                                    mesGrid2.SelectFirstRow(ur);
                                    SetMessage("종료시간이 시작시간이전입니다.(08시기준)");
                                    return false;
                                }
                            }
                        }
                    }
                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow ur in mesGrid2.Rows)
                    {
                         if (ur.Cells["crud"].Value.ToString() == "U")
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@SeqID", ur.Cells["seqID"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pStartTime", ur.Cells["StartDate"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pEndTime", ur.Cells["EndDate"].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@pRemark", ur.Cells["Remark"].Value.ToString()));
 
                            db.ExecuteNonQuery(cmd);
                        }
                    }

                }
                clsDB.Commit();
                return true;
               // SetMessage("정상적으로 등록되었습니다.");

            }
            catch (SqlException oe)
            {
                SetMessage(oe.Message);
                clsDB.Rollback();
            }
            return false;
        }


        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "현황":
                    mesGrid1.Visible = true;
                    mesGrid2.Visible = false;
                    btnLeftPage.LinkGrid = mesGrid1;
                    btnRightPage.LinkGrid = mesGrid1;

                    btnLeftPage.LinkMoveSize = mesGrid1.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid1.CountRows;

                    dtpDate.Enabled = false;
                    btnSearch.Enabled = false;
                    DoFind();
 
                    break;
                case "실적":
                    mesGrid2.Visible = true;
                    mesGrid1.Visible = false;
                    btnLeftPage.LinkGrid = mesGrid2;
                    btnRightPage.LinkGrid = mesGrid2;

                    btnLeftPage.LinkMoveSize = mesGrid2.CountRows;
                    btnRightPage.LinkMoveSize = mesGrid2.CountRows;

                    dtpDate.Enabled = true;
                    btnSearch.Enabled = true;

                    DoFind();
                    break;
            }
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoFind();
        }


        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridCell.Column.Key == "cstate")
            {
                string nudt = e._UltraGridRow.Cells["cdt"].Value.ToString();
                if (e._UltraGridCell.Value.ToString() == "")
                {
                    //  e.cell.Value = "비가동";
                    DA9900 da9900 = new DA9900();
                    ShowDialogForm(da9900);
                    if (da9900.DialogResult == DialogResult.Cancel)
                        return;
                    e._UltraGridCell.Value = da9900.resultArray[1];
                    e._UltraGridRow.Cells["StopCode"].Value = da9900.resultArray[0];


                }
                else if (e._UltraGridCell.Value.ToString() == "가동")
                {
                    e._UltraGridCell.Value = "";// e.row.Cells["stopname"].Value;
                }
                else //if (e.cell.Value.ToString() == "비가동")
                {
                    if (nudt == "")
                        e._UltraGridCell.Value = "";
                    else
                        e._UltraGridCell.Value = "가동";
                }
            }
            else if (e._UltraGridCell.Column.Key == "remark")
            {
                if (e._UltraGridRow.Cells["cstate"].Value.ToString() == "")
                    return;

                DA9120 da9120 = new DA9120();
                da9120.ResultString = e._UltraGridCell.Value.ToString();

                if (DialogResult.OK == ShowDialogForm(da9120))
                    e._UltraGridCell.Value = da9120.ResultString;

            }
        }

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (dtpDate.Value > DateTime.Now.AddDays(-7))
            //     if ((dtpDate.Value.Hour < 8 ? DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd")) == dtpDate.Value.ToString("yyyy-MM-dd"))
            {
                seqID = e._UltraGridRow.Cells["seqID"].Value.ToString();
                if (e._UltraGridCell.Column.Key == "StartDate" || e._UltraGridCell.Column.Key == "EndDate")
                {
                    if (e._UltraGridCell.Value.ToString() == "")
                        return;
                    //  e.cell.Value = "비가동";
                    DA9140 da9140 = new DA9140();
                    ShowDialogForm(da9140);
                    if (da9140.DialogResult == DialogResult.Cancel)
                        return;

                    string[] av = da9140.ResultRegTime.Split(':');
                    try
                    {
                        if (Convert.ToInt32(av[0]) > 24 || Convert.ToInt32(av[1]) > 59 || Convert.ToInt32(av[2]) > 59)
                        {
                            SetMessage("잘못된 시간 값입니다.");
                            return;
                        }
                    }
                    catch
                    {
                        SetMessage("잘못된 시간 값입니다.");
                        return;
                    }

                    e._UltraGridCell.Value = da9140.ResultRegTime;
                    e._UltraGridRow.Cells["crud"].Value = "U";

                }

                else if (e._UltraGridCell.Column.Key == "remark")
                {
                    DA9120 da9120 = new DA9120();
                    da9120.ResultString = e._UltraGridCell.Value.ToString();
                    if (DialogResult.OK == ShowDialogForm(da9120))
                    {
                        e._UltraGridCell.Value = da9120.ResultString;
                        e._UltraGridRow.Cells["crud"].Value = "U";

                    }

                }

            }
            else
                seqID = "";
        }
        string seqID = "";
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (seqID != "")
            {
                DA9300 d1 = new DA9300();
                d1.ButtonCount = 2;
                d1.ButtonNames[0] = "삭제\r\n확인";
                d1.ButtonNames[1] = "취소";

                d1.StartPosition = FormStartPosition.CenterScreen;
                ShowDialogForm(d1);


                if (d1.DialogResult == DialogResult.Cancel)
                {
                    return;
                } 
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();

                //clsDB.BeginTran(conn);

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA2300_D1");
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@SeqID", seqID));

                db.ExecuteNonQuery(cmd);
                seqID = "";
                DoFind();
            }
        }
    }
}
