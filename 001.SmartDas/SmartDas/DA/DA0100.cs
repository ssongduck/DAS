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
    public partial class DA0100 : SmartDas.Components.BaseForm
    {
        string chgOK = "0";
        string curOrder = Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo;
        public DA0100()
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
            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection con = (SqlConnection)db.CreateConnection();
                if (Common.SelectedWorkCenter.MultiOrderNo != "Y")
                {
                    chgOK = db.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM TPP0100 	 WHERE PLANTCODE  ='" + Common.SelectedWorkCenter.PlantCode + "' AND WORKCENTERCODE ='" + Common.SelectedWorkCenter.Code + "' and ORDERNO in ('" + Common.SelectedWorkCenter.GetOrderList(Common.ListOrderType.SELECT).AllOrderNo.Replace(",", "','") + "')").ToString();
                }

                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_DA0100_S2");
                cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                //cmd.ExecuteReader()   
                DataTable tb = db.ExecuteDataSet(cmd).Tables[0];
                string hm = DateTime.Now.ToString("HH:mm");
                if (tb.Rows[0]["starttime"].ToString().CompareTo(hm) <= 0 && tb.Rows[0]["endtime"].ToString().CompareTo(hm) >= 0)
                {
                    btnMakeOrder.Enabled = false;
                    SetMessage(tb.Rows[0]["starttime"].ToString() + "~" + tb.Rows[0]["endtime"].ToString() + " 긴급작업지시서 생성할수 없습니다.");
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

            mesGrid1.SelectProcedureName = "USP_DA0100_S1";
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
                      // 확인시 처리 내역
                       if (!_bUseNetwork)
                        {
                            SetMessage("C:S00018");
                            return;
                        }
                        if (chgOK != "0" && Common.SelectedWorkCenter.MultiOrderNo != "Y")  
                        {
                            SetMessage("현재작지를 작업완료해야 작지를 변경할수 있습니다.");
                             return;
                        }
                        if (Common.SelectedWorkCenter.MultiOrderNo == "Y" && curOrder != "" && curOrder.StartsWith(Common.gRecDate.Replace("-", "").Substring(2, 6)) == false)  
                        {
                            SetMessage("현재작지를 작업완료해야 작지를 선택할수 있습니다.");
                            return;
                        }
                        //if ((Common.SelectedWorkCenter.LineStatus == "S" || Common.SelectedWorkCenter.LineStatus == "" ? "S" : "R") == "R")
                        //{
                        //    SetMessage("가동 상태일 때 지시를 변경할 수 없습니다.");
                        //    return;
                        //}
                        //if (mesGrid1.Row == null)
                        //{
                        //    SetMessage("작업지시를 선택하세요.");
                        //    return;
                        //}
                         
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
                         
                        Database dbSave = DatabaseFactory.CreateDatabase();
                        SqlConnection conSave = (SqlConnection)dbSave.CreateConnection();

                        SqlCommand cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_D1");
                        if (Common.SelectedWorkCenter.MultiOrderNo != "Y")
                        {
                            cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                            if (clsDB.gExecuteProcedure(conSave, cmd))
                            {
                                for (int i = mesGrid1.Rows.FixedRows.Count; i < mesGrid1.Rows.Count; i++)
                                {
                                    if (mesGrid1.Rows[i].Cells["SEL"].Value.ToString() == "√")
                                    {
                                        cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_I1");
                                        cmd.Parameters.Clear();
                                        cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                                        cmd.Parameters.Add(new SqlParameter("@pOrderNo", mesGrid1.Rows[i].Cells["OrderNo"].Value));
                                        cmd.Parameters.Add(new SqlParameter("@pItemCode", mesGrid1.Rows[i].Cells["ItemCode"].Value));

                                        if (!clsDB.gExecuteProcedure(conSave, cmd))
                                        {
                                            SetMessage(clsDB.ErrorDesc);
                                             return;
                                        }
                                        break;
                                    } 
                                }
                            }
                        }
                        else
                        {

                            for (int i = mesGrid1.Rows.FixedRows.Count; i < mesGrid1.Rows.Count; i++)
                            {
                                if (mesGrid1.Rows[i].Cells["SEL"].Value.ToString() == "√" && mesGrid1.Rows[i].Cells["org_SEL"].Value.ToString() != "√")
                                {
                                    // 현재선택안된 작지만 추가로 작지를 등록할수 있게 처리

                                    cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_I1");
                                    cmd.Parameters.Clear();
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
                                if (mesGrid1.Rows[i].Cells["SEL"].Value.ToString() == " " && mesGrid1.Rows[i].Cells["org_SEL"].Value.ToString() == "√")
                                {

                                    cmd = (SqlCommand)dbSave.GetStoredProcCommand("USP_DA0100_D1");
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.Add(new SqlParameter("@pPLANTCODE", Common.SelectedWorkCenter.PlantCode));
                                    cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                                    cmd.Parameters.Add(new SqlParameter("@pOrderNo", mesGrid1.Rows[i].Cells["OrderNo"].Value.ToString()));
                                    if (!clsDB.gExecuteProcedure(conSave, cmd))
                                    {
                                        SetMessage(clsDB.ErrorDesc);
                                        return;
                                    }
                                }
                            }
                        }
                        //}
                        //else
                        //{
                        //    SetMessage(clsDB.ErrorDesc);
                        //    return;
                        //}

                       // DoFind();

                        //가동처리 
                        if (Common.SelectedWorkCenter.LineStatus == "S")
                        {
                            cmd.CommandText = "USP_DA0000_RunStop";
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@pPlantCode", Common.SelectedWorkCenter.PlantCode));
                            cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", Common.SelectedWorkCenter.Code));
                            cmd.Parameters.Add(new SqlParameter("@pStopCode", ""));
                            cmd.Parameters.Add(new SqlParameter("@pStatus", "R"));

                            if (clsDB.gExecuteProcedure(conSave, cmd))
                            {
                                SetMessage(clsDB.ErrorDesc);
                                return;
                            }
                        }

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
            if ((e._UltraGridColumn == null) || (e._UltraGridRow == null))
                return;
            if (e._UltraGridColumn.ToString() == "ItemCode")
            {
                DA9520 da9520 = new DA9520();
                da9520.bOrderNo = e._UltraGridRow.Cells["OrderNo"].Value.ToString();
                ShowDialogForm(da9520);
            }

            if (Common.SelectedWorkCenter.MultiOrderNo == "Y" && curOrder != "" && curOrder.StartsWith(Common.gRecDate.Replace("-", "").Substring(2, 6)) == false)
            {
                SetMessage("현재작지를 작업완료해야 작지를 선택할수 있습니다.");
                return;
            }

            if (e._UltraGridRow.Cells["OrderNo"].Value.ToString().StartsWith(dtpStartDate.Value.ToString("yyMMdd")) == false && e._UltraGridRow.Cells["OrderNo"].Value.ToString().Substring(10,1) != "8")
            {

                SetMessage("당일 작업지시서만 선택할수 있습니다.");
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
            DoProgress();

            //txtPlanNo.Text = e.row.Cells["ORDERNO"].Value.ToString();


            txtOrderNo.Text = e._UltraGridRow.Cells["OrderNo"].Value.ToString();

            string sValue = mesGrid1.Rows[e._UltraGridRow.Index].Cells["Sel"].Value.ToString();

            if (Common.SelectedWorkCenter.MultiOrderNo == "Y")
            {
                //선택취소한 작지가  현재선택된 작지이면 lot발행 된 경우 완료해야함 메시지처리
                if (sValue == "√" && curOrder.IndexOf(txtOrderNo.Text) != -1)
                {
                    //Database db = DatabaseFactory.CreateDatabase();
                    //SqlConnection con = (SqlConnection)db.CreateConnection();

                    //chgOK = db.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM TPP0100 	 WHERE PLANTCODE  ='" + Common.SelectedWorkCenter.PlantCode + "' AND WORKCENTERCODE ='" + Common.SelectedWorkCenter.Code + "' and ORDERNO ='" + txtOrderNo.Text + "'").ToString();
                    //if (chgOK != "0")
                    if (e._UltraGridRow.Cells["ProdQty"].Value.ToString() != "0")
                    {
                        SetMessage("현재작지를 작업완료해야 선택취소 할수 있습니다.");
                        CloseProgressForm();
                        return;
                    }
                    else
                        SetMessage("");
                }

            }
            else
            {
                for (int i = 0; i < mesGrid1.Rows.Count; i++)
                {
                    if (mesGrid1.Rows[i].Cells["Sel"].Value.ToString() == "√")
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
            DA8000 da8000 = new DA8000();
            ShowDialogForm(da8000);

            DoFind();
        }

        private void mesButton1_Click(object sender, EventArgs e)
        {
            DA8000 da8000 = new DA8000();
            da8000.btest = true;
            ShowDialogForm(da8000);

            DoFind();
 
        }

        private void btnRework_Click(object sender, EventArgs e)
        {
            DA8000 da8000 = new DA8000();
            da8000.bHam = true;
            ShowDialogForm(da8000);

        }
    }
}