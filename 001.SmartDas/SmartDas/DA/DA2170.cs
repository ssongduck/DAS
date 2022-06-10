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
    public partial class DA2170 : BaseForm
    {
        WorkCenter wc = Common.SelectedWorkCenter;
        string cur_lotno = "";

        public string Sasang = "N";

        //밸브바디 사상장 (사상1(우남테크): 3101)인 경우 사상인지 쇼트(완료공정)인지 여부가 필요하다..
        //사상인지 여부
        public bool bIsSasang = false;

        public DA2170()
        {
            InitializeComponent();
        }

        private void DA2170_Load(object sender, EventArgs e)
        {
            SetButtons();

            SetGrid();

            Init();

            DoFind();
        }

        // 버튼 생성
        private void SetButtons()
        {
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "조회";
            //btnConfBox[0, 1].Text = "보정"; 
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons();
        }

        private void SetGrid()
        {
            mesGrid1.FontSize = 15;

            mesGrid1.SelectProcedureName = "USP_DA2170_S2";
            mesGrid1.CountRows = 10;
        }

        private void Init()
        {
            txtWorkCenterCode.Text = wc.Code;
            txtWorkCenterName.Text = wc.Name;
            txtDayNight.Text = "전체";
            txtDayNight.Tag = "A";
            dtpDate.Value = Convert.ToDateTime(Common.gRecDate);

            txtLotQty.Text = "0";
            txtTotalProdQty.Text = "0";
        }

        private void DoFind()
        {
            mesGrid1.GetStoreProcedure();

            string sDate = string.Format("{0:yyyy-MM-dd}", dtpDate.Value);

            // 조회
            mesGrid1.ParameterList.Add(new SqlParameter("@pPLANTCODE", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWORKCENTERCODE", wc.Code));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDATE", sDate));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDayNight", txtDayNight.Tag));
            mesGrid1.ParameterList.Add(new SqlParameter("@pSasang", Sasang));
            

            mesGrid1.DoFind();

            int iTotalProd = 0;
            foreach (UltraGridRow row in mesGrid1.Rows)
                iTotalProd += clsDB.nvlInt(row.Cells["GOODQTY"].Value);

            txtLotQty.Text = mesGrid1.Rows.Count.ToString();
            txtTotalProdQty.Text =  string.Format("{0:0,0}", iTotalProd);
        }
            
        // 버튼 컨트롤

        private void btnConfBox_buttonClickEvent(MESButton sender, ButtonBox.ButtonClickEventArg e)
        {
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

                //case "보정":
                //    // 조회시 처리 내역
                //    if (!bUseNetwork)
                //    {
                //        SetMessage("C:S00018");
                //        return;
                //    }

                //    DA2110 da2110 = new DA2110();
                //    da2110.sItemCode = mesGrid1.Row.Cells["ItemCode"].Value.ToString();
                //    da2110.sOrderNo = mesGrid1.Row.Cells["OrderNo"].Value.ToString();
                //    da2110.sRecdate = mesGrid1.Row.Cells["RECDATE"].Value.ToString();

                //    ShowDialogForm(da2110);

                //    break;

                case "취소":
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        // 주간/야간 조회조건 변경

        private void txtDayNight_Click(object sender, EventArgs e)
        {
            // 전체(A) -> 주간(D) -> 야간(N) -> 전체(A)
            switch (txtDayNight.Tag.ToString())
            {
                case "A" :
                    txtDayNight.Text = "주간";
                    txtDayNight.Tag = "D";
                    break;
                case "D" :
                    txtDayNight.Text = "야간";
                    txtDayNight.Tag = "N";
                    break;
                case "N" :
                    txtDayNight.Text = "전체";
                    txtDayNight.Tag = "A";
                    break;
                default :
                    txtDayNight.Text = "전체";
                    txtDayNight.Tag = "A";
                    break;
            }
        }

        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridCell.Text == "재발행")
            {
                cur_lotno = e._UltraGridRow.Cells[1].Value.ToString();//"LOT NO"

                if (bIsSasang == true)
                {
                    //사상(중간공정기준-주조와 동일한데 불량만 추가)기준 발행
                    DA0070 da0070 = new DA0070();
                    da0070.ReDCLabelPrint(cur_lotno,true);
                }
                else
                {
                    if (Common.GetIPAddress() == "192.168.200.72")
                    {
                    //if (Common.GetIPAddress() == "192.168.230.56")
                    //{
                        if (e._UltraGridRow.Cells[4].Value.ToString() == "45231-23145-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "45231-P23000-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-02710-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-02700-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-3D113-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-3D141-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-3D131-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43111-3D110-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43111-2D000-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43111-2C001-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43111-2B000-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43111-2B001-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2D200-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2D110-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2D100-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2D000-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2D010-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2C001-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2C010-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2B000-20" ||
                            e._UltraGridRow.Cells[4].Value.ToString() == "43115-2B001-20")
                        {
                            LabelReport labelReport = new LabelReport();
                            labelReport.Priting(cur_lotno);
                        }
                        else
                        {
                            //// 완료공정기준 발행
                            DA0070 da0070 = new DA0070();
                            da0070.ReDSLabelPrint(cur_lotno, true);
                        }
                    }
                    else
                    {
                        // 완료공정기준 발행
                        DA0070 da0070 = new DA0070();
                        da0070.ReDSLabelPrint(cur_lotno, true);
                    }
                }
            }
            if (e._UltraGridCell.Text == "삭제")
            {

                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection dconn = (SqlConnection)db.CreateConnection();
                SqlCommand cmd = new SqlCommand();

                //DataSet dsReturn; 
                cur_lotno = e._UltraGridRow.Cells[1].Value.ToString();//"LOT NO"

                DA9300 d1 = new DA9300();
                d1.ButtonCount = 2;
                d1.ButtonNames[0] = "삭제\r\n확인";
                d1.ButtonNames[1] = "취소";

                d1.StartPosition = FormStartPosition.Manual;
                d1.Location = new Point(Cursor.Position.X - 350, Cursor.Position.Y - d1.Size.Height - 10);

                ShowDialogForm(d1);

                if (d1.DialogResult == DialogResult.Cancel)
                {
                    return;
                }

                //2018.11.22 MC.YANG 삭제시 인터페이스 오류방지를 위해 등록 후 5분뒤 삭제되게 수정
                DateTime dtime = Convert.ToDateTime(db.ExecuteScalar(CommandType.Text, "SELECT MAX(MakeDate) FROM TPP0100 WITH(NOLOCK) WHERE LOTNO = '" + cur_lotno + "'"));

                if (dtime.AddMinutes(5) > DateTime.Now)
                {
                    TimeSpan ts = dtime.AddMinutes(5).Subtract(DateTime.Now);

                    SetMessage((ts.Minutes > 0 ? "실적 인터페이스 중 입니다. " + ts.Minutes.ToString() + "분" : "") + ts.Seconds.ToString() + "초후 삭제 가능합니다.");
                    return;
                }

                // 사상(밸브바디 사상) -- 중간공정인 경우
                if (bIsSasang == true)
                {
                    // 쇼트까지 완료된경우 삭제하면 안된다. 
                    DataTable tbValveDone = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) QTY from TPP0816 where LotNO = '" + cur_lotno + "'").Tables[0];
                    int ShotDoneQty = Convert.ToInt16(tbValveDone.Rows[0]["QTY"].ToString());

                    if (ShotDoneQty != 0)
                    {
                        SetMessage("이미 쇼트 작업완료가 수행된 LOT번호입니다.");
                        CloseProgressForm();
                        return;
                    }
                }
                
                //if (bIsSasang == false)
                //{
                //    // ERP 실적 삭제
                //    cmd = (SqlCommand)db.GetStoredProcCommand(Common.sERPDB+ ".DBO.RSP_MES_CMD217");
                //    cmd.Connection = dconn;
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Parameters.Add(new SqlParameter("@lot_control_no", cur_lotno));

                //    dsReturn = db.ExecuteDataSet(cmd);
                //}

                // 실적(ERP, MES) 삭제
                //clsDB.BeginTran(dconn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dconn;
                cmd.CommandText = "USP_DA2170_D1";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@pLotNo", cur_lotno));
                if (bIsSasang == true)
                {
                    cmd.Parameters.Add(new SqlParameter("@pSasang", 'Y'));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@pSasang", 'N'));
                }

                DataTable tbResult = db.ExecuteDataSet(cmd).Tables[0];

                if (tbResult.Rows[0][0].ToString().Equals("0"))
                {
                    SetMessage("삭제할수 없습니다");
                    return;
                }
                else
                {
                    SetMessage("삭제되었습니다");
                    mesGrid1.DoFind();
                }

                //if (!clsDB.gExecuteProcedure(dconn, cmd))
                //{
                //    SetMessage(clsDB.ErrorDesc);
                //    //clsDB.Rollback();
                //    return;
                //}
                //else
                //{
                //    SetMessage("삭제되었습니다");
                //    //clsDB.Commit();
                //    mesGrid1.DoFind();
                //}

            }
        }
    }
}
