using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SmartDas
{
    /// <summary>
    /// Label report class
    /// </summary>
    public partial class LabelReport : DevExpress.XtraReports.UI.XtraReport
    {
        #region Variables

        WorkCenter wc = Common.SelectedWorkCenter;

        private Configuration appConfig;

        #endregion

        #region Constructors

        /// <summary>
        /// Label report constructor
        /// </summary>
        public LabelReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Preview
        /// </summary>
        public void PreView()
        {
            this.PrintingSystem.ShowMarginsWarning = false;

            this.ShowPreview();
        }

        /// <summary>
        /// Priting
        /// </summary>
        /// <param name="lotNo"></param>
        public void Priting(string lotNo)
        {
            string Worker = string.Empty;
            //string LotNo = string.Empty;
            string MoldName = string.Empty;
            string CarType = string.Empty;
            string CarTypeName = string.Empty;
            string CostCenter2 = string.Empty;
            string CenterName = string.Empty;
            string LotCnt = string.Empty;
            string Shift = string.Empty;
            string Shift2 = string.Empty;
            string SItemCode = string.Empty;
            string SItemName = string.Empty;

            //신규 LOT의 기존 LOT번호
            int NewLotQty;
            string NewLot = string.Empty;
            string PrevLot = string.Empty;

            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();

            //구lot, 신lot 판단 필요. 메인창에서는 구로트, 현황창에서는 신로트
            DataTable tbNewLotQTY = db.ExecuteDataSet(CommandType.Text, "SELECT COUNT(*) NEWLOTQTY "
                                                    + " FROM TPP0816 A "
                                                    + " WHERE PrevLOTNO = '" + lotNo + "'").Tables[0];
            NewLotQty = Convert.ToInt16(tbNewLotQTY.Rows[0][0].ToString());

            if (NewLotQty != 0)
            {
                //외주입고분의 경우 같은 LOT가 계속 들어오므로, 가장 마지막것을 가지고온다...
                DataTable tbNewLot = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 LOTNO "
                                                        + " FROM TPP0816 A "
                                                        + " WHERE PrevLOTNO = '" + lotNo + "'"
                                                        + " ORDER BY MAKEDATE DESC ").Tables[0];

                NewLot = tbNewLot.Rows[0][0].ToString();
                PrevLot = lotNo;
            }
            else
            {
                DataTable tbNewLot = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 PREVLOTNO "
                                    + " FROM TPP0816 A "
                                    + " WHERE LOTNO = '" + lotNo + "'"
                                    + " ORDER BY MAKEDATE DESC ").Tables[0];

                PrevLot = tbNewLot.Rows[0][0].ToString();
                NewLot = lotNo;
            }

            DataTable tbLot1 = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + PrevLot + "'").Tables[0];

            string PrevLotInfo = PrevLot;

            if (tbLot1.Rows.Count != 0)
            {
                PrevLotInfo += " : " + tbLot1.Rows[0]["ItemCode"].ToString().Trim() + " : " + string.Format("{0:n0}", tbLot1.Rows[0]["ProdQty"]) + "EA";
            }

            DataTable tbLot = db.ExecuteDataSet(CommandType.Text, "SELECT * from TPP0100 where LotNO ='" + NewLot + "'").Tables[0];
            if (tbLot.Rows.Count == 0)
                return;

            //현재 작업자명 로드 - 작업자가 바뀌었을 경우 현재 작업자가 찍힘
            DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT  dbo.FN_WorkerName('" + tbLot.Rows[0]["WorkerID"].ToString() + "')").Tables[0];
            //DataTable tbWorkerName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 dbo.FN_WorkerName(WorkerID) "
            //                                                     + " FROM TBM2400 "
            //                                                     + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];
            //형번 txtOrderNo.Text - 이전 금형일 경우 현재금형이 찍힘 수정필요.
            //DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
            //                                                    + " FROM TAP0100 A "
            //                                                    + " LEFT OUTER JOIN TBM1600 B "
            //                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
            //                                                    + " WHERE PlanNO = '" + tbLot.Rows[0]["OrderNo"].ToString() + "'").Tables[0];

            if (PrevLot.Length == 17)
            {
                DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                                    + " FROM TPP0100 A "
                                                                    + " LEFT OUTER JOIN TBM1600 B "
                                                                    + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                    + " WHERE LotNO = '" + PrevLot + "'").Tables[0];

                if (tbMoldNo.Rows.Count > 0)
                {
                    MoldName = tbMoldNo.Rows[0][0].ToString();
                }
            }

            if (wc.PlantCode == "SK2")
            {
                if (string.IsNullOrEmpty(MoldName))
                {
                    DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                                        + " FROM TPP1790 A "
                                                                        + " LEFT OUTER JOIN TBM1600 B "
                                                                        + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                                        + " WHERE OrderNo = '" + PrevLot.Substring(0, 13) + "'").Tables[0];

                    if (tbMoldNo.Rows.Count > 0)
                    {
                        MoldName = tbMoldNo.Rows[0][0].ToString();
                    }
                }

                if (string.IsNullOrEmpty(MoldName))
                {
                    DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
                                                + " FROM SKMES.SK_MESDB_V1.dbo.TPP0100 A "
                                                + " LEFT OUTER JOIN SKMES.SK_MESDB_V1.dbo.TBM1600 B "
                                                + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
                                                + " WHERE LotNO = '" + PrevLot + "'").Tables[0];

                    if (tbMoldNo.Rows.Count > 0)
                    {
                        MoldName = string.Format("{0} : {1}", "평택", tbMoldNo.Rows[0][0].ToString());
                    }
                }
            }

            //DataTable tbMoldNo = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 B.MoldName "
            //                                                     + " FROM TAP0100 A "
            //                                                     + " LEFT OUTER JOIN TBM1600 B "
            //                                                     + " ON A.PlantCode = B.PlantCode AND A.MoldCode = B.MoldCode "
            //                                                     + " WHERE PlanNO = '" + txtOrderNo.Text + "'").Tables[0];
            //차종 
            //DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
            //                                                    + " FROM TBM0100 A "
            //                                                    + " WHERE ItemCode = '" + txtItemCode.Text + "'").Tables[0];
            string itemcode = tbLot.Rows[0]["ItemCode"].ToString().Trim();
            DataTable tbCarType = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 CarType "
                                                                    + " FROM TBM0100 A "
                                                                    + " WHERE ItemCode = '" + itemcode + "'").Tables[0];


            DataTable tbCarTypeName = new DataTable();
            DataTable tbCostCenter2 = new DataTable();


            if (Common.sERPDB.Equals("ERPSVR.SKA_MFG") || Common.sERPDB.Equals("ERPSVR.SKA_SFG"))
            {

                //차종 이름
                 tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                    + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER3 A "
                                                                    + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                    + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                    + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                //제품군 이름
                 tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                    + " FROM ERPSVR.SKA_FIN.DBO.AC_COST_CENTER2 A "
                                                                    + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                    + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                    + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
            }
            else
            {
                //차종 이름
                 tbCarTypeName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 AC3_NAME "
                                                                    + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER3 A "
                                                                    + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                    + " ON A.AC3_CODE = B.COST_CENTER3 "
                                                                    + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];

                //제품군 이름
                 tbCostCenter2 = db.ExecuteDataSet(CommandType.Text, " SELECT TOP 1 AC2_NAME "
                                                                    + " FROM ERPSVR.SKE_FIN.DBO.AC_COST_CENTER2 A "
                                                                    + " JOIN " + Common.sERPDB + ".DBO.PROCURE_DET B "
                                                                    + " ON A.AC2_CODE = B.COST_CENTER2 "
                                                                    + " WHERE B.RESOURCE_NO = '" + itemcode + "'").Tables[0];
            }

            //현재 작업장명 로드
            DataTable tbCenterName = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 WorkCenterName "
                                                                  + " FROM TBM0600 "
                                                                  + " WHERE WorkCenterCode = '" + Common.SelectedWorkCenter.Code + "'").Tables[0];

            //사상 품번, 품명
            //DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 ItemCode, ItemName "
            //                                                    + " FROM TBM0100 A "
            //                                                    + " WHERE ItemCode LIKE '" + txtItemCode.Text.Trim().Substring(0, (txtItemCode.Text.Trim().Length - 2)) + "3'" + " + '%'"
            //                                                    + " AND ItemCode <> '" + txtItemCode.Text + "'").Tables[0];


            string sql = "SELECT TOP 1 ItemCode, ItemName  FROM TBM0100 A   WHERE ItemCode ='" + itemcode + "'";

            DataTable tbSItemCode = db.ExecuteDataSet(CommandType.Text, sql).Tables[0];


            //LotCnt
            //if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 20)
            // if (Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour > 8 && Convert.ToDateTime(mesGrid2.Row.Cells["Indate"].Value).Hour < 20)
            DateTime mdt = (DateTime)tbLot.Rows[0]["MakeDate"];
            if (mdt.Hour > 8 && mdt.Hour < 20)
            {
                Shift = "주간   ";
                //Shift2 = "A - ";
                Shift2 = "";
                LotCnt = "A - #" + tbLot.Rows[0]["LotSno"].ToString();
            }
            else
            {
                Shift = "야간   ";
                //Shift2 = "B - ";
                Shift2 = "";
                LotCnt = "B - #" + tbLot.Rows[0]["LotSno"].ToString();
            }

            if (tbWorkerName.Rows.Count > 0)
            {
                Worker = tbWorkerName.Rows[0][0].ToString();
            }

            if (tbCarType.Rows.Count > 0)
            {
                CarType = tbCarType.Rows[0][0].ToString();
            }

            if (tbCarTypeName.Rows.Count > 0)
            {
                CarTypeName = tbCarTypeName.Rows[0][0].ToString();
            }

            if (tbCostCenter2.Rows.Count > 0)
            {
                CostCenter2 = tbCostCenter2.Rows[0][0].ToString();
            }

            if (tbCenterName.Rows.Count > 0)
            {
                CenterName = tbCenterName.Rows[0][0].ToString();
            }
            // 제품군 -> 작업장으로 변경 (2016.10.11)

            if (tbSItemCode.Rows.Count > 0)
            {
                SItemName = tbSItemCode.Rows[0][1].ToString();
            }
            else //if (tbSItemCode.Rows.Count == 0)
            {
                SItemName = "";// txtItemName.Text;
            }

            string qty = clsDB.nvlString(tbLot.Rows[0]["ProdQty"]);

            this.PrintingSystem.ShowMarginsWarning = false;
            lblBarCode1.Text = string.Format("{0}", NewLot);
            lblItemCode.Text = string.Format("{0}", itemcode);
            lblCastLotNo.Text = string.Format("{0}", PrevLot);
            lblQtyMold.Text = string.Format("{0}EA / {1}", qty, MoldName);
            lblBarCode2.Text = string.Format("{0}", NewLot);
            lblDate.Text = string.Format("{0}", mdt.ToString("yyyy-MM-dd HH:mm:ss"));
            lblLotNo.Text = string.Format("{0}", NewLot);

            this.Print("TSC TE210");
        }

        #endregion
    }
}
