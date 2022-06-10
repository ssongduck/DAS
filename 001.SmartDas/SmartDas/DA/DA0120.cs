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
    public partial class DA0120 : SmartDas.Components.BaseForm
    {
        string curOrder = Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo;
        string chgOK = "0";
        public DA0120()
        {
            InitializeComponent();
            SetGrid();

            DoFind();
            SetButtons();

            Init();
        }

        private void Init()
        {
            txtWorkCenterCode.Text = Common.SelectedWorkCenter.Code;
            txtWorkCenterName.Text = Common.SelectedWorkCenter.Name;
            txtOrderNo.Text = "";
            dtpStartDate.Value = Convert.ToDateTime(Common.gRecDate);
            // 현재 작지의 lot 발행실적이 있으면 작업완료후에만 작지변경이 가능하게 
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection con = (SqlConnection)db.CreateConnection();
                if (Common.SelectedWorkCenter.Code.StartsWith("2"))// 주조인경우 ,멀티작지인경우는 검토 필요
                {
                    chgOK = db.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM TPP0100 	 WHERE PLANTCODE  ='" + Common.SelectedWorkCenter.PlantCode + "' AND WORKCENTERCODE ='" + Common.SelectedWorkCenter.Code + "' and ORDERNO='" + Common.SelectedWorkCenter.OrderNo + "'").ToString();
                }

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0100_S2");
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                //cmd.ExecuteReader()   
                DataTable tb = db.ExecuteDataSet(cmd).Tables[0];
                string hm = DateTime.Now.ToString("HH:mm");
                if (tb.Rows[0]["starttime"].ToString().CompareTo(hm) <= 0 && tb.Rows[0]["endtime"].ToString().CompareTo(hm) >= 0)
                {
                    btnMakeOrder.Enabled = false;
                    SetMessage(tb.Rows[0]["starttime"].ToString()+"~"+tb.Rows[0]["endtime"].ToString()+" 긴급작업지시서 생성할수 없습니다.");
                }
                if (curOrder != "" && curOrder.StartsWith(Common.gRecDate.Replace("-", "").Substring(2, 6)) == false)
                {
                    SetMessage(" 전일작지 작업완료후 선택하십시오.");
                }
            }
            catch { }
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA0120_S1";
            mesGrid1.CountRows = 6;
        }

        /// <summary>
        /// 버튼 생성
        /// </summary>
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", SqlDbType.VarChar));
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlanDate", SqlDbType.VarChar));

            mesGrid1.ParameterList["@pPLANTCODE"].Value = Common.SelectedWorkCenter.PlantCode;
            mesGrid1.ParameterList["@pWORKCENTERCODE"].Value = Common.SelectedWorkCenter.Code;
            mesGrid1.ParameterList["@pPlanDate"].Value = dtpStartDate.Value.ToString("yyyy-MM-dd");

            mesGrid1.DoFind();
        }



        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
            try
            {
                sender.Enabled = false;
                DoProgress();
                switch (sender.Text)
                {
                    case "등록":
                       
                        //if (Common.SelectedWorkCenter.Code.StartsWith("2") && chgOK != "0") // 주조인경우 멀티작지인경우는 검토 필요
                        //{
                        //    SetMessage("현재작지를 작업완료해야 작지를 변경할수 있습니다.");
                        //    return;
                        //}

                        if (Common.SelectedWorkCenter.MultiOrderNo == "Y" && curOrder != "" && curOrder.StartsWith(Common.gRecDate.Replace("-", "").Substring(2, 6)) == false)
                        {
                            SetMessage("현재작지를 작업완료해야 작지를 선택할수 있습니다.");
                            return;
                        }
                        // 확인시 처리 내역
                        if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }
                        if (mesGrid1.Row == null)
                        {
                            SetMessage("작업지시를 선택하세요.");
                            return;
                        }
                          
                        string OrderNo = "";
                        string ItemCode = "";
                        string ItemName = "";
                        for (int i = mesGrid1.Rows.FixedRows.Count; i < mesGrid1.Rows.Count; i++)
                        {
                            if (mesGrid1.Rows[i].Cells["SEL"].Value.ToString() == "√")
                            {
                                    OrderNo += mesGrid1.Rows[i].Cells["OrderNo"].Value + " ";
                                    ItemCode += mesGrid1.Rows[i].Cells["ItemCode"].Value + " ";
                                    ItemName += mesGrid1.Rows[i].Cells["ItemName"].Value + " ";
                            }
                        }
                        DA9620 d9620 = new DA9620();
                        d9620.txtOrderNo.Text = OrderNo;
                        d9620.txtItemCode.Text = ItemCode;
                        d9620.txtItemName.Text = ItemName;


                        if (DialogResult.OK != ShowDialogForm(d9620))
                            return;
                      
                        //if ((Common.SelectedWorkCenter.LineStatus == "S" || Common.SelectedWorkCenter.LineStatus == "" ? "S" : "R") == "R")
                        //{
                        //    SetMessage("가동 상태일 때 지시를 변경할 수 없습니다.");
                        //    return;
                        //}


                        Database dbSave = DatabaseFactory.CreateDatabase();
                        SqlConnection conSave = (SqlConnection)dbSave.CreateConnection();
                        for (int i = mesGrid1.Rows.FixedRows.Count; i < mesGrid1.Rows.Count; i++)
                        {
                            if (mesGrid1.Rows[i].Cells["SEL"].Value.ToString() == "√")
                            {
                                if (Common.SelectedWorkCenter.OrderNo != mesGrid1.Rows[i].Cells["OrderNo"].Value.ToString())
                                {

                                    SqlCommand cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_D1");
                                    cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));


                                    if (clsDB.gExecuteProcedure(conSave, cmd))
                                    {

                                        cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_I1");

                                        cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                                        cmd.Parameters.Add(new SqlParameter("@pOrderNo", mesGrid1.Rows[i].Cells["OrderNo"].Value));
                                        cmd.Parameters.Add(new SqlParameter("@pItemCode", mesGrid1.Rows[i].Cells["ItemCode"].Value));

                                        if (!clsDB.gExecuteProcedure(conSave, cmd))
                                        {
                                            SetMessage(clsDB.ErrorDesc);
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        SetMessage(clsDB.ErrorDesc);
                                        return;
                                    }
                                }

                            }
                        }

                        DoFind();

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case "취소":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                }

            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
            finally
            {
                sender.Enabled = true;
                CloseProgressForm();
            }

        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            //string wDate = "";
            //if (DateTime.Now.Hour < 8)
            //    wDate = DateTime.Now.AddDays(-1).ToString("yyMMdd");
            //else
            //    wDate = DateTime.Now.ToString("yyMMdd");

            if (e._UltraGridRow.Cells["OrderNo"].Value.ToString().StartsWith(dtpStartDate.Value.ToString("yyMMdd")) == false && e._UltraGridRow.Cells["OrderNo"].Value.ToString().Substring(10, 1) != "8")
            {

                SetMessage("당일(08시기준) 작업지시서만 선택할수 있습니다."); 
                return;

            }
            if (e._UltraGridRow.Cells["SEL"].Value.ToString() == "E")
            {
                SetMessage("완료된 작업지시서는 선택할수 없습니다.");
                return;

            }
            if (e._UltraGridRow.Cells["SEL"].Value.ToString() == "N")
            {
                SetMessage("선택한 품목은 사용할수 없습니다.[작업장별 품목 없음]");
                return;

            }
 
            SetMessage(""); 
 
            DoProgress();

            //txtPlanNo.Text = e.row.Cells["ORDERNO"].Value.ToString();

            if ((e._UltraGridColumn != null) || (e._UltraGridRow != null)) txtOrderNo.Text = e._UltraGridRow.Cells["OrderNo"].Value.ToString();

            string sValue = mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value.ToString();

            if (Common.SelectedWorkCenter.MultiOrderNo != "Y")
            {
                for (int i = 0; i < mesGrid1.Rows.Count; i++)
                {
                    if (mesGrid1.Rows[i].Cells["Sel"].Value.ToString()=="√")
                       mesGrid1.Rows[i].Cells["Sel"].Value = " ";
                }
            }

            if (sValue == " " || sValue == "√")
                mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value = (sValue == " " ? "√" : " ");

            CloseProgressForm();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DoProgress();

            DoFind();

            CloseProgressForm();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            DA8010 da8010 = new DA8010();
            ShowDialogForm(da8010);

            DoFind();
        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            DA8010 da8010 = new DA8010();
            da8010.btest = true;
            ShowDialogForm(da8010);

            DoFind();
  
        }
    }
}