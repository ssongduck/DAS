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
    public partial class DA6020 : BaseForm
    {
        private WorkCenter wc = Common.SelectedWorkCenter;

        public DA6020()
        {
            InitializeComponent();
        }

        private void DA6020_Load(object sender, EventArgs e)
        {
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
        }

        private void SetLblMessageClear()
        {
            SetMessage("원하는 작업을 선택 하세요.");
        }

        private void SetButtons()
        {
            #region btnConfBox
            btnConfBox.CountX = 2;
            btnConfBox.CountY = 1;

            btnConfBox.SetButtons();

            btnConfBox[0, 0].Text = "등록";
            btnConfBox[0, 1].Text = "취소";

            btnConfBox.RedrawButtons(); 
            #endregion

            #region btnSelect   // 사용하지 않음
            //btnSelect.CountX = 2;
            //btnSelect.CountY = 1;

            //btnSelect.SetButtons();

            //btnSelect[0, 0].Text = "실적조회";
            //btnSelect[0, 1].Text = "신규등록";

            //btnSelect[0, 0].ButtonPressed = true;

            //btnSelect.RedrawButtons();

            //btnSelect_buttonChangeEvent(btnSelect[0, 0].MappingButton, new ButtonBox.ButtonClickEventArg(0, 0)); 
            #endregion
            
            #region btnKeyPad   // 사용하지 않음
            //btnKeyPad.CountX = 6;
            //btnKeyPad.CountY = 2;

            //btnKeyPad.SetButtons();

            //btnKeyPad[0, 0].Text = "1";
            //btnKeyPad[0, 1].Text = "2";
            //btnKeyPad[0, 2].Text = "3";
            //btnKeyPad[0, 3].Text = "4";
            //btnKeyPad[0, 4].Text = "5";
            //btnKeyPad[0, 5].Text = "◀";
            //btnKeyPad[1, 0].Text = "6";
            //btnKeyPad[1, 1].Text = "7";
            //btnKeyPad[1, 2].Text = "8";
            //btnKeyPad[1, 3].Text = "9";
            //btnKeyPad[1, 4].Text = "0";
            //btnKeyPad[1, 5].Text = "C";

            //btnKeyPad.RedrawButtons(); 
            #endregion
        }

        private void SetGrid()
        {
            #region mesGrid1
            mesGrid1.FontSize = 15;
            mesGrid1.SelectProcedureName = "USP_DA6020_S1";

            mesGrid1.CountRows = 15;
            mesGrid1.GetStoreProcedure();

            //mesGrid1.DoFind();

            //mesGrid1.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            #endregion

            #region mesGrid2
            mesGrid2.FontSize = 15;
            mesGrid2.SelectProcedureName = "USP_DA6020_S2";

            mesGrid2.CountRows = 15;
            mesGrid2.GetStoreProcedure();

            //mesGrid2.DoFind();

            //mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid2.DataSourceDS.Tables[1].AcceptChanges(); 
            #endregion

            #region mesGrid3    //사용하지 않음
            //mesGrid3.FontSize = 15;
            //mesGrid3.SelectProcedureName = "USP_DA6020_S3";

            //mesGrid3.CountRows = 5;
            //mesGrid3.SetStoreProc();

            //mesGrid3.DoFind();
            #endregion
        }

        private void SetGrid_I()
        {
            #region mesGrid1
            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            //mesGrid1.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid1.DoFind();

            //mesGrid1.DataSourceDS.Tables[1].Rows[0].Delete();
            //mesGrid1.DataSourceDS.Tables[1].AcceptChanges();
            #endregion

            #region mesGrid2
            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            //mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

            mesGrid2.DoFind();

            mesGrid2.DataSourceDS.Tables[1].Rows[0].Delete();
            mesGrid2.DataSourceDS.Tables[1].AcceptChanges();
            #endregion
        }

        private void DoFind()
        {
            #region mesGrid1
            mesGrid1.ParameterList.Clear();
            mesGrid1.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            //mesGrid1.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            //mesGrid1.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));
            mesGrid1.ParameterList.Add(new SqlParameter("@pDate", dtpDate.Value.ToString("yyyy-MM-dd")));

            mesGrid1.DoFind();
            #endregion

            #region mesGrid2
            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", wc.PlantCode));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", wc.Code));
            //mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));

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

                        Database db = DatabaseFactory.CreateDatabase();
                        SqlConnection conn = (SqlConnection)db.CreateConnection();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "USP_DA6020_U2";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@pPlantCode", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@pWorkCenterCode", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@RecDate", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@Seq", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@pLadleNo", SqlDbType.Int));
                        //cmd.Parameters.Add(new SqlParameter("@pArrivalTemp", SqlDbType.Float));
                        string curdt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        bool ball = true;
                        foreach (Infragistics.Win.UltraWinGrid.UltraGridRow dr in mesGrid2.Rows)
                        {
                            if ("확인".Equals(dr.Cells["ArrivalDate"].Value.ToString()))
                            {
                                cmd.Parameters["@pPlantCode"].Value = clsDB.nvlString(dr.Cells["PlantCode"].Value);
                                cmd.Parameters["@pWorkCenterCode"].Value = clsDB.nvlString(dr.Cells["WorkCenterCode"].Value);
                                cmd.Parameters["@RecDate"].Value = clsDB.nvlString(dr.Cells["RecDate"].Value);
                                cmd.Parameters["@Seq"].Value = clsDB.nvlInt(dr.Cells["Seq"].Value);
                                cmd.Parameters["@pLadleNo"].Value = clsDB.nvlInt(dr.Cells["LadleNo"].Value);
                                //cmd.Parameters["@pArrivalTemp"].Value = clsDB.nvlDouble(dr.Cells["ArrivalTemp"].Value);

                                if (clsDB.gExecute(conn, cmd) < 0)
                                {
                                    // 오류 발생시
                                    SetMessage(clsDB.ErrorDesc);
                                    return;
                                }
                                dr.Cells["ArrivalDate"].Value = curdt;
                            }
                            else if ("미확인".Equals(dr.Cells["ArrivalDate"].Value.ToString()))
                            {
                                ball = false;
                            }
                        }

                      //  DoFind();
                        if (ball)
                        {
                            mesGrid1.Row.Cells["cStatus"].Value = "완료";
                        }
                       // mesGrid1_GridClick(null, new MESGrid.GridClickEventArg(drow.Cells[0]));

                        SetMessage("정상적으로 등록하였습니다.");

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

            SetLblMessageClear();
        }

        private void lblNetwork_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mesGrid1_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            mesGrid1.GridDefaultSelectedBackColor = Color.Moccasin;
            mesGrid2.GridDefaultSelectedBackColor = Color.Moccasin;

            mesGrid2.ParameterList.Clear();
            mesGrid2.ParameterList.Add(new SqlParameter("@pPlantCode", e._UltraGridRow.Cells["PlantCode"].Value));
            mesGrid2.ParameterList.Add(new SqlParameter("@pWorkCenterCode", e._UltraGridRow.Cells["WorkCenterCode"].Value));
            //mesGrid2.ParameterList.Add(new SqlParameter("@pSearchflag", sSearchflag));
            mesGrid2.ParameterList.Add(new SqlParameter("@pRecDate", e._UltraGridRow.Cells["RecDate"].Value));
            mesGrid2.ParameterList.Add(new SqlParameter("@pSeq", e._UltraGridRow.Cells["Seq"].Value));

            mesGrid2.DoFind();
        }

        private void mesGrid2_GridClick(object sender, MESGrid.GridClickEventArg e)
        {
            if (e._UltraGridRow != null && "ArrivalDate".Equals(e._UltraGridColumn.ToString()))
            {
                if ("미확인".Equals(e._UltraGridCell.Value.ToString()))
                    e._UltraGridCell.Value = "확인";
                else if ("확인".Equals(e._UltraGridCell.Value.ToString()))
                    e._UltraGridCell.Value = "미확인";
            }
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

        private void txtFinish_Click(object sender, EventArgs e)
        {
            // 전체(A) -> 완료(Y) -> 미완료(N) -> 전체(A)
            switch (txtFinish.Tag.ToString())
            {
                case "A":
                    txtFinish.Text = "완료";
                    txtFinish.Tag = "Y";
                    break;
                case "Y":
                    txtFinish.Text = "미완료";
                    txtFinish.Tag = "N";
                    break;
                case "N":
                    txtFinish.Text = "전체";
                    txtFinish.Tag = "A";
                    break;
                default:
                    txtFinish.Text = "전체";
                    txtFinish.Tag = "A";
                    break;
            }
        }
    }
}
