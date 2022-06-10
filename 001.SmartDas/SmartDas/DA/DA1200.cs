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
    public partial class DA1200 : SmartDas.Components.BaseForm
    {
        //private string lastWorkerID = "";
        //private string lastWorkerName = "";

        //private Hashtable hash = null;

        private WorkCenter wc = Common.SelectedWorkCenter;

        public DA1200()
        {
            InitializeComponent();
        }

        private void DA1200_Load(object sender, EventArgs e)
        {            
            SetChasu();
            SetGrid();
            SetButtons();

            //SetHash();

            Init();
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            //DoFind();

            //SetMessage("실적을 등록하십시오");
        }

        private void SetGrid()
        {
            //mesGrid1.FontSize = 12;
            //mesGrid1.CountRows = 16;
            //if (Common.gsPlantCode == "SK1") { mesGrid1.SelectProcedureName = "USP_DA1200_S1"; } else { mesGrid1.SelectProcedureName = "USP_DA1201_S1"; }

            //mesGrid2.FontSize = 12;
            //mesGrid2.CountRows = 16;
            //if (Common.gsPlantCode == "SK1") { mesGrid2.SelectProcedureName = "USP_DA1200_S2"; } else { mesGrid2.SelectProcedureName = "USP_DA1201_S2"; }


            if (Common.gsPlantCode == "SK1")
            {
                mesGrid1.SelectProcedureName = "USP_DA1200_S1";
                mesGrid2.SelectProcedureName = "USP_DA1200_S2";

                mesGrid1.FontSize = 12;
                mesGrid1.CountRows = 16;
                mesGrid2.FontSize = 12;
                mesGrid2.CountRows = 16;

                mesGrid1.Location = new Point(1, 62);
                mesGrid2.Location = new Point(510, 62);
                mesGrid1.Size = new Size(506, 540);
                mesGrid2.Size = new Size(506, 540);
                mesGrid3.Visible = false;
                mesGrid4.Visible = false;
                mesGrid5.Visible = false;
            }
            else
            {
                /*그리드 4개*/
                //mesGrid1.SelectProcedureName = "USP_DA1201_S1";
                //mesGrid2.SelectProcedureName = "USP_DA1201_S2";
                //mesGrid3.SelectProcedureName = "USP_DA1201_S3";
                //mesGrid4.SelectProcedureName = "USP_DA1201_S4";

                //mesGrid1.FontSize  = 10;
                //mesGrid1.CountRows = 16;
                //mesGrid2.FontSize  = 10;
                //mesGrid2.CountRows = 16;
                //mesGrid3.FontSize  = 10;                                
                //mesGrid3.CountRows = 16;
                //mesGrid4.FontSize  = 10;
                //mesGrid4.CountRows = 16;

                //mesGrid1.Location = new Point(1, 62);
                //mesGrid2.Location = new Point(254, 62); //255
                //mesGrid3.Location = new Point(507, 62); //509
                //mesGrid4.Location = new Point(760, 62); //763
                //mesGrid1.Size = new Size(253, 540);
                //mesGrid2.Size = new Size(253, 540);
                //mesGrid3.Size = new Size(253, 540);
                //mesGrid4.Size = new Size(253, 540);
                //mesGrid3.Visible = true;
                //mesGrid4.Visible = true;


                /*그리드 5개*/
                mesGrid1.SelectProcedureName = "USP_DA1201_S1";
                mesGrid2.SelectProcedureName = "USP_DA1201_S2";
                mesGrid3.SelectProcedureName = "USP_DA1201_S3";
                mesGrid4.SelectProcedureName = "USP_DA1201_S4";
                mesGrid5.SelectProcedureName = "USP_DA1201_S5";

                mesGrid1.FontSize  = 10;
                mesGrid1.CountRows = 16;
                mesGrid2.FontSize  = 10;
                mesGrid2.CountRows = 16;
                mesGrid3.FontSize  = 10;
                mesGrid3.CountRows = 16;
                mesGrid4.FontSize  = 10;
                mesGrid4.CountRows = 16;
                mesGrid5.FontSize  = 10;
                mesGrid5.CountRows = 16;

                mesGrid1.Location = new Point(1, 62);
                mesGrid2.Location = new Point(203, 62); 
                mesGrid3.Location = new Point(405, 62); 
                mesGrid4.Location = new Point(607, 62); 
                mesGrid5.Location = new Point(809, 62); 

                mesGrid1.Size = new Size(202, 540);
                mesGrid2.Size = new Size(202, 540);
                mesGrid3.Size = new Size(202, 540);
                mesGrid4.Size = new Size(202, 540);
                mesGrid4.Size = new Size(202, 540);
                mesGrid3.Visible = true;
                mesGrid4.Visible = true;
                mesGrid5.Visible = true;
            }            
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "닫기";

            btnConfBox.RedrawButtons();
            

            btnSelect.CountX = 2;
            btnSelect.CountY = 1;

            btnSelect.SetButtons();

            btnSelect[0, 0].Text = "입력";
            btnSelect[0, 1].Text = "실적";

            btnSelect[0, 0].ButtonPressed = true;

            btnSelect.RedrawButtons();

            btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0));
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
        }

        private void DoFind(string sFlag = "")
        {
            if (Common.gsPlantCode == "SK1")
            {
                mesGrid1.GetStoreProcedure();
                mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid1.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid1.DoFind();

                mesGrid2.GetStoreProcedure();
                mesGrid2.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid2.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid2.DoFind();
            }
            else
            {
                mesGrid1.GetStoreProcedure();
                mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid1.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid1.DoFind();

                mesGrid2.GetStoreProcedure();
                mesGrid2.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid2.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid2.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid2.DoFind();

                mesGrid3.GetStoreProcedure();
                mesGrid3.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid3.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid3.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid3.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid3.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid3.DoFind();


                mesGrid4.GetStoreProcedure();
                mesGrid4.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid4.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid4.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid4.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid4.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid4.DoFind();

                mesGrid5.GetStoreProcedure();
                mesGrid5.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
                mesGrid5.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                mesGrid5.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
                mesGrid5.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag.ToString()));
                mesGrid5.ParameterList.Add(new SqlParameter("@pFlag", sFlag));
                mesGrid5.DoFind();

                mesGrid1.SetRowHeight(12);
                mesGrid2.SetRowHeight(12);
                mesGrid3.SetRowHeight(12);
                mesGrid4.SetRowHeight(12);
                mesGrid5.SetRowHeight(12);
            }
        }


        private void SetChasu()
        {
            Database db = DatabaseFactory.CreateDatabase();            
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            //string query = string.Format("select isnull(max(seq),0) from tbm3610 where recdate = '{0}' and workcentercode = '{1}'",
            //                             dtpDate.Value.ToString("yyyy-MM-dd"), wc.Code);


//            string query = @"select  case when convert(time, '08:00:00') < convert(time,getdate()) and convert(time, '10:00:00') > convert(time,getdate()) then 1
//					                      when convert(time, '13:00:00') < convert(time,getdate()) and convert(time, '15:00:00') > convert(time,getdate()) then 2
//					                      when convert(time, '18:00:00') < convert(time,getdate()) and convert(time, '20:00:00') > convert(time,getdate()) then 3
//				                          when convert(time, '20:00:00') < convert(time,getdate()) and convert(time, '23:59:59') > convert(time,getdate()) then 1
//					                      when convert(time, '00:00:01') < convert(time,getdate()) and convert(time, '05:00:00') > convert(time,getdate()) then 2
//					                      when convert(time, '05:00:00') < convert(time,getdate()) and convert(time, '08:00:00') > convert(time,getdate()) then 3 else 0 end";



            string query = @"select  case when convert(time, '08:00:00') < convert(time,getdate()) and convert(time, '12:00:00') > convert(time,getdate()) then 1  
					                      when convert(time, '12:00:00') < convert(time,getdate()) and convert(time, '16:00:00') > convert(time,getdate()) then 2
					                      when convert(time, '16:00:00') < convert(time,getdate()) and convert(time, '20:00:00') > convert(time,getdate()) then 3
				                          when convert(time, '20:00:00') < convert(time,getdate()) and convert(time, '00:00:00') > convert(time,getdate()) then 1
					                      when convert(time, '00:00:00') < convert(time,getdate()) and convert(time, '04:00:00') > convert(time,getdate()) then 2
					                      when convert(time, '04:00:00') < convert(time,getdate()) and convert(time, '08:00:00') > convert(time,getdate()) then 3 else 0 end";

            int curChasu = Convert.ToInt16(clsDB.gExecuteScalar(conn, query));            

            switch (curChasu)
            {
                //case 0:
                //    lblChasu.Text = "불가";
                //    lblChasu.Tag  = 0;
                //    break;
                case 1:
                    lblChasu.Text = "1차";
                    lblChasu.Tag  = 1;
                    break;
                case 2:
                    lblChasu.Text = "2차";
                    lblChasu.Tag  = 2;
                    break;
                case 3:
                    lblChasu.Text = "3차";
                    lblChasu.Tag  = 3;
                    break;
                default:
                    lblChasu.Text = "1차";
                    lblChasu.Tag  = 1;
                    break;
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
                    case "조회":
                        DoFind("S");
                        break;

                    case "등록":

                        SetChasu();

                        if (Convert.ToInt16(lblChasu.Tag) == 0)
                        {
                            SetMessage("현재 시간에는 등록이 불가합니다.");
                            return;
                        }                        
                        if (DateTime.Now.Hour < 8)
                        {
                            dtpDate.Value = DateTime.Now.AddHours(-8);
                        }
                        else
                        {
                            dtpDate.Value = DateTime.Now;
                        }
                        if (DateTime.Now.Hour < 8 || DateTime.Now.Hour > 20)
                        {
                            txtDayNight.Text = "야간";
                            txtDayNight.Tag = "N";
                        }
                        else
                        {
                            txtDayNight.Text = "주간";
                            txtDayNight.Tag = "D";
                        }                                        

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        if (Common.gsPlantCode == "SK1") { cmd.CommandText = "USP_DA1200_I1"; } else { cmd.CommandText = "USP_DA1201_I1"; }
                        //cmd.CommandText = "USP_DA1200_I1";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pPlantCode",      wc.PlantCode));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
                        cmd.Parameters.Add(new SqlParameter("@pDate",           dtpDate.Value.ToString("yyyy-MM-dd")));                                               
                        cmd.Parameters.Add(new SqlParameter("@pItemCode",       wc.ItemCode));
                        cmd.Parameters.Add(new SqlParameter("@pDayNight",       txtDayNight.Tag.ToString()));
                        //cmd.Parameters.Add(new SqlParameter("@pDayNight",       "N"));
                        cmd.Parameters.Add(new SqlParameter("@pInspSeq",        SqlDbType.Int));                        
                        cmd.Parameters.Add(new SqlParameter("@pInspValue",      SqlDbType.Float));

                        if (Common.gsPlantCode == "SK2")
                        {
                            cmd.Parameters.Add(new SqlParameter("@pChasu", SqlDbType.Int));
                            cmd.Parameters["@pChasu"].Value = Convert.ToInt16(lblChasu.Tag);
                        }
                        foreach (UltraGridRow row in mesGrid1.Rows)
                        {
                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (string.IsNullOrEmpty(row.Cells["INPUT"].Value.ToString()))
                                continue;

                            cmd.Parameters["@pInspSeq"].Value   = clsDB.nvlInt(row.Cells["InspSeq"].Value);
                            cmd.Parameters["@pInspValue"].Value = clsDB.nvlDouble(row.Cells["INPUT"].Value);

                            if (clsDB.gExecute(conn, cmd) < 0)// 오류 발생시
                            {                                
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        foreach (UltraGridRow row in mesGrid2.Rows)
                        {
                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (string.IsNullOrEmpty(row.Cells["INPUT"].Value.ToString()))
                                continue;

                            cmd.Parameters["@pInspSeq"].Value  = clsDB.nvlInt(row.Cells["InspSeq"].Value);
                            cmd.Parameters["@pInspValue"].Value = clsDB.nvlDouble(row.Cells["INPUT"].Value);

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {                                
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        foreach (UltraGridRow row in mesGrid3.Rows)
                        {
                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (string.IsNullOrEmpty(row.Cells["INPUT"].Value.ToString()))
                                continue;

                            cmd.Parameters["@pInspSeq"].Value = clsDB.nvlInt(row.Cells["InspSeq"].Value);
                            cmd.Parameters["@pInspValue"].Value = clsDB.nvlDouble(row.Cells["INPUT"].Value);

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        foreach (UltraGridRow row in mesGrid4.Rows)
                        {
                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (string.IsNullOrEmpty(row.Cells["INPUT"].Value.ToString()))
                                continue;

                            cmd.Parameters["@pInspSeq"].Value = clsDB.nvlInt(row.Cells["InspSeq"].Value);
                            cmd.Parameters["@pInspValue"].Value = clsDB.nvlDouble(row.Cells["INPUT"].Value);

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        foreach (UltraGridRow row in mesGrid5.Rows)
                        {
                            //if (row.Cells["STATUS"].Value.ToString() != "R")
                            if (string.IsNullOrEmpty(row.Cells["INPUT"].Value.ToString()))
                                continue;

                            cmd.Parameters["@pInspSeq"].Value = clsDB.nvlInt(row.Cells["InspSeq"].Value);
                            cmd.Parameters["@pInspValue"].Value = clsDB.nvlDouble(row.Cells["INPUT"].Value);

                            if (clsDB.gExecute(conn, cmd) < 0)
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }
                        SetMessage("등록이 완료되었습니다.");
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
            //List<int> modList = new List<int>();

            try
            {
                if (e._UltraGridColumn == null)
                    return;

                if (e._UltraGridColumn.ToString() == "INPUT")
                {
                    if (Convert.ToInt16(lblChasu.Tag) == 0)
                    {
                        SetMessage("현재 시간에는 등록이 불가합니다.");
                        return;
                    }

                    DA9100 da9100 = new DA9100();
                    da9100.LabelTitle = e._UltraGridRow.Cells["InspName"].Value.ToString() + "(" + e._UltraGridRow.Cells["InspUnit"].Value.ToString() + ")" + " 입력";
                    da9100.LabelHeader = "입력";

                    if (DialogResult.OK != ShowDialogForm(da9100))
                        return;

                    if (!string.IsNullOrEmpty(da9100.ResultString))
                    {
                        e._UltraGridRow.Cells["INPUT"].Value = da9100.ResultString;
                        e._UltraGridRow.Cells["STATUS"].Value = "R";
                        //e.cell.Appearance.ForeColor = Color.Red;
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

            if (Common.gsPlantCode == "SK1") { cmd.CommandText = "USP_DA1200_I1"; } else { cmd.CommandText = "USP_DA1201_I1"; }
            //cmd.CommandText = "USP_DA1200_I1";

            if (clsDB.nvlString(row.Cells["WorkerID"].Value) == "")
            {       
                row.Cells["WorkerID"].Value = clsDB.nvlString(txtWorker.Tag);
                row.Cells["WorkerName"].Value = clsDB.nvlString(txtWorker.Text);
            }

            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
            cmd.Parameters.Add(new SqlParameter("@pMachCode", row.Cells["MachCode"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));
            //cmd.Parameters.Add(new SqlParameter("@pDayNight", btnDayNight.GetSelectedButtons()[0].Tag.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspCode", row.Cells["InspCode"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspValue", row.Cells["RstData"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pInspResult", row.Cells["Result"].Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@pWorkerID", row.Cells["WorkerID"].Value.ToString()));

            if (!clsDB.gExecuteProcedure(con, cmd))
            {
                //  오류 발생시
                SetMessage(clsDB.ErrorDesc);
                return;
            }
        }

        private void txtDayNight_Click(object sender, EventArgs e)
        {
            if (txtDayNight.Tag == "D")
            {
                txtDayNight.Text = "야간";
                txtDayNight.Tag = "N";
            }
            else
            {
                txtDayNight.Text = "주간";
                txtDayNight.Tag = "D";
            }
        }

        private void btnSelect_buttonChangeEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            sender.Select();
            switch (sender.Text)
            {
                case "입력":
                    dtpDate.Enabled = false;
                    txtDayNight.Enabled = false;
                    lblChasu.Visible = true;
                    btnConfBox[0, 0].Text = "등록";
                    btnConfBox.RedrawButtons();
                    //btnSearch.Enabled = false;

                    lblChasu.Enabled = false;

                    if (DateTime.Now.Hour < 8)
                    {
                        dtpDate.Value = DateTime.Now.AddHours(-8);
                    }
                    else
                    {
                        dtpDate.Value = DateTime.Now;
                    }
                    if (DateTime.Now.Hour < 8 || DateTime.Now.Hour > 20)
                    {
                        txtDayNight.Text = "야간";
                        txtDayNight.Tag = "N";
                    }
                    else
                    {
                        txtDayNight.Text = "주간";
                        txtDayNight.Tag = "D";
                    }                    
                    DoFind("I");    // 입력

                    break;
                case "실적":
                    dtpDate.Enabled = true;
                    txtDayNight.Enabled = true;
                    lblChasu.Visible = false;
                    btnConfBox[0, 0].Text = "조회";
                    btnConfBox.RedrawButtons();
                    //btnSearch.Enabled = true;

                    lblChasu.Enabled = true;

                    DoFind("S");    // 조회
                    break;
            }
        }

        private void lblChasu_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Convert.ToInt16(lblChasu.Tag))
                {
                    case 1:
                        lblChasu.Text = "2차";
                        lblChasu.Tag  = "2";
                        break;
                    case 2:
                        lblChasu.Text = "3차";
                        lblChasu.Tag  = "3";
                        break;
                    case 3:
                        lblChasu.Text = "1차";
                        lblChasu.Tag  = "1";
                        break;
                    default:
                        lblChasu.Text = "불가";
                        lblChasu.Tag  = "0";
                        break;
                }
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }
    }
}
