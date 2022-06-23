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
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace SmartDas
{
    public partial class DA2200 : SmartDas.Components.BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;        

        public DA2200()
        {
            InitializeComponent();
        }

        //커밋 테스트

        private void DA2200_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();
            
            Init();

            DoFind();
        }

        private void SetButtons()
        {
            btnConfBox.CountX = 4;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            btnConfBox[0, 1].Text = "추가";
            btnConfBox[0, 2].Text = "등록";
            btnConfBox[0, 3].Text = "취소";

            if (Common.gsPlantCode == "SK1")
            {
                btnConfBox[0, 1].Enable = false;
                btnConfBox[0, 2].Enable = false;
            }


            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA2200_S1";
            mesGrid1.CountRows = 12;                        
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtRunStop.Text = "전체";
            txtRunStop.Tag = "A";
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            if (wc.Code.StartsWith("2"))
                lblTitle.Text = "비가동";            
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            string sDate = string.Format("{0:yyyy-MM-dd}", dtpDate.Value);

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@PLANTCODE",      wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@WORKCENTERCODE", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@STARTDATE",      sDate));
            mesGrid1.ParameterList.Add(new SqlParameter("@pRunStop",       txtRunStop.Tag));

            mesGrid1.DoFind();
        }



        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            //DoProgress();
            switch (sender.Text)
            {
                case "조회":
                    // 조회시 처리 내역
                    if (!_bUseNetwork)
                    {
                        SetMessage("C:S00018");
                        return;
                    }
                    DoFind();
                    break;
                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;

                case "추가":
                    mesGrid1.GridRowAdd();
                    mesGrid1.Rows[mesGrid1.Rows.Count-1].Cells[4].Value = "비가동";
                    mesGrid1.Rows[mesGrid1.Rows.Count-1].Cells[5].Value = wc.ItemCode;                    
                    break;


                case "등록":
                    DoSave();
                    break;
            } 
            //ClosePrgForm();
        }

        private void DoSave()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "USP_DA2200_I1";
                cmd.CommandType = CommandType.StoredProcedure;


                //"기준일자|시작시각|종료시각|시간(분)|상태|내역|비가동|비가동명|startdate|recdate|enddate|Seq";
                foreach (UltraGridRow row in mesGrid1.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@AS_PLANTCODE",      wc.PlantCode));
                    cmd.Parameters.Add(new SqlParameter("@AS_WORKCENTERCODE", wc.Code));
                    cmd.Parameters.Add(new SqlParameter("@AS_SEQ",            row.Cells[11].Value == DBNull.Value ? -1 : Convert.ToInt16(row.Cells[11].Value)));
                    cmd.Parameters.Add(new SqlParameter("@AS_STARTDATE",      Convert.ToDateTime(row.Cells[8].Value)));
                    cmd.Parameters.Add(new SqlParameter("@AS_ENDDATE",        Convert.ToDateTime(row.Cells[10].Value)));
                    cmd.Parameters.Add(new SqlParameter("@AS_STOPTIME",       row.Cells[3].Value));
                    cmd.Parameters.Add(new SqlParameter("@AS_WORKERCNT",      wc.WorkerCnt));
                    cmd.Parameters.Add(new SqlParameter("@AS_LOTNO",          ""));
                    cmd.Parameters.Add(new SqlParameter("@AS_ITEMCODE" ,      wc.ItemCode));
                    cmd.Parameters.Add(new SqlParameter("@AS_RECDATE",        string.Format("{0:yyyy-MM-dd}", dtpDate.Value)));
                    cmd.Parameters.Add(new SqlParameter("@AS_DAYNIGHT",       Common.gDayNight));
                    cmd.Parameters.Add(new SqlParameter("@AS_ORDERNO",        wc.OrderNo));
                    cmd.Parameters.Add(new SqlParameter("@AS_STOPTYPE",       row.Cells[6].Value.ToString().Substring(0,1)));
                    cmd.Parameters.Add(new SqlParameter("@AS_STOPCODE",       row.Cells[6].Value));
                    cmd.Parameters.Add(new SqlParameter("@AS_REMARK",         row.Cells[12].Value));                                                        

                    if (clsDB.gExecute(conn, cmd) < 0)
                    {
                        SetMessage(clsDB.ErrorDesc);
                        return;
                    }
                }
                SetMessage("등록이 완료되었습니다.");                
            }
            
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }


        private void txtRunStop_Click(object sender, EventArgs e)
        {
            // 전체(A) -> 가동(R) -> 비가동(S) -> 전체(A)
            switch (txtRunStop.Tag.ToString())
            {
                case "A":
                    txtRunStop.Text = "가동";
                    txtRunStop.Tag = "R";
                    break;
                case "R":
                    txtRunStop.Text = "비가동";
                    txtRunStop.Tag = "S";
                    break;
                case "S":
                    txtRunStop.Text = "전체";
                    txtRunStop.Tag = "A";
                    break;
                default:
                    txtRunStop.Text = "전체";
                    txtRunStop.Tag = "A";
                    break;
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
           // if (e.cell.Column.Header.Caption == "비가동" && wc.Code.StartsWith("2") && dtpDate.Value >= DateTime.Now.AddDays(-1).AddHours(-(DateTime.Now.Hour + 1)))
           if (e._UltraGridCell.Column.Header.Caption == "비가동"  && dtpDate.Value >= DateTime.Now.AddDays(-7).AddHours(-(DateTime.Now.Hour + 1)))
           {
               string stopCode = string.Empty;

               if (Common.gsPlantCode == "SK1")
               {
                   DA9900 da9900 = new DA9900();
                   ShowDialogForm(da9900);
                   if (da9900.DialogResult == DialogResult.Cancel)
                       return;
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[6].Value = stopCode = da9900.resultArray[0];
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[7].Value = da9900.resultArray[1];                   
               }
               else
               {
                   DA9901 da9901 = new DA9901();
                   ShowDialogForm(da9901);
                   if (da9901.DialogResult == DialogResult.Cancel)
                       return;

                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[6].Value = stopCode = da9901.resultArray[0];
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[7].Value = da9901.resultArray[1];
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[12].Value = da9901.resultArray[3] == string.Empty ? da9901.resultArray[4] == string.Empty ? da9901.resultArray[5] : da9901.resultArray[4] + " " + da9901.resultArray[5] : da9901.resultArray[3];
               }

               Database db = DatabaseFactory.CreateDatabase();
               SqlConnection con = (SqlConnection)db.CreateConnection();
               SqlCommand cmd = new SqlCommand();

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Connection = con;
              
               cmd.CommandText = "USP_DA2200_U1";
               cmd.Parameters.Clear();
               cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
               cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
               cmd.Parameters.Add(new SqlParameter("@STARTDATE", mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[8].Value));
               cmd.Parameters.Add(new SqlParameter("@StopCode" , stopCode));

               try
               {
                   db.ExecuteNonQuery(cmd);
               }
               catch(Exception ex)
               {
                   SetMessage(ex.Message);
               }
           }
           if (Common.gsPlantCode == "SK2")
           {
               if (e._UltraGridCell.Column.Header.Caption == "시작시각")
               {
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[2].Value = string.Empty;                   
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[10].Value = string.Empty;
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[3].Value = 0;

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
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[1].Value = da9140.ResultRegDate + " " + da9140.ResultRegTime;
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[8].Value = da9140.ResultRegYear + "-" + da9140.ResultRegDate + " " + da9140.ResultRegTime;
               }
               if (e._UltraGridCell.Column.Header.Caption == "종료시각")
               {

                   if (mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[1].Value.ToString() == "")
                   {
                       SetMessage("시작시간을 먼저 입력하세요.");
                       return;
                   }

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
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[2].Value = da9140.ResultRegDate + " " + da9140.ResultRegTime;
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[10].Value = da9140.ResultRegYear + "-" + da9140.ResultRegDate + " " + da9140.ResultRegTime;
                   DateTime sDt = Convert.ToDateTime(mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[8].Value);
                   DateTime eDt = Convert.ToDateTime(mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[10].Value);
                   TimeSpan time = eDt - sDt;
                   var norunTime = Math.Round(time.TotalMinutes, 1);
                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[3].Value = norunTime;                   
               }

               if (e._UltraGridCell.Column.Header.Caption == "비고")
               {
                   string remarks = string.Empty;

                   DA9210 da9210 = new DA9210();
                   ShowDialogForm(da9210);
                   if (da9210.DialogResult == DialogResult.Cancel)
                       return;

                   mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[12].Value = remarks = da9210.resultString;

                   Database db = DatabaseFactory.CreateDatabase();
                   SqlConnection con = (SqlConnection)db.CreateConnection();
                   SqlCommand cmd = new SqlCommand();

                   cmd.CommandType = CommandType.Text;
                   cmd.Connection = con;

                   cmd.CommandText = "UPDATE TPP1600 SET Remarks = @Remarks WHERE 1 = 1 AND PLANTCODE = @PlantCode AND WorkcenterCode = @WorkCenterCode AND StartDate = @STARTDATE";
                   cmd.Parameters.Clear();
                   cmd.Parameters.Add(new SqlParameter("@PlantCode", wc.PlantCode));
                   cmd.Parameters.Add(new SqlParameter("@WorkCenterCode", wc.Code));
                   cmd.Parameters.Add(new SqlParameter("@STARTDATE", mesGrid1.Rows[e._UltraGridCell.Row.Index].Cells[8].Value));
                   cmd.Parameters.Add(new SqlParameter("@Remarks", remarks));

                   try
                   {
                       db.ExecuteNonQuery(cmd);
                   }
                   catch (Exception ex)
                   {
                       SetMessage(ex.Message);
                   }

               }
           }
        }
    }
}
