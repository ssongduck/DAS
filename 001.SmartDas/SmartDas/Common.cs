using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Management;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace SmartDas
{
    #region WorkCenter class

    /// <summary>
    /// Workcenter class
    /// </summary>
    public class WorkCenter
    {
        #region Variables

        /// <summary>
        /// Worker list
        /// </summary>
        private List<WorkerList> _ListWorker = new List<WorkerList>();

        /// <summary>
        /// Order list
        /// </summary>
        private List<OrderList> _ListOrder = new List<OrderList>();

        /// <summary>
        /// Hash table
        /// </summary>
        private Hashtable _Hashtable;

        /// <summary>
        /// Plant code
        /// </summary>
        private string _PlantCode;

        /// <summary>
        /// Code
        /// </summary>
        private string _Code;

        /// <summary>
        /// Name
        /// </summary>
        private string _Name;

        /// <summary>
        /// Order count
        /// </summary>
        private int _OrderCount;

        /// <summary>
        /// Worker count
        /// </summary>
        private int _WorkerCount;

        /// <summary>
        /// Order No
        /// </summary>
        private string _OrderNo;

        /// <summary>
        /// Item code
        /// </summary>
        private string _ItemCode;

        /// <summary>
        /// Item name
        /// </summary>
        private string _ItemName;

        /// <summary>
        /// Unit code
        /// </summary>
        private string _UnitCode;

        /// <summary>
        /// Plan quantity
        /// </summary>
        private double _PlanQty;

        /// <summary>
        /// Product quantity
        /// </summary>
        private double _ProdQty;

        /// <summary>
        /// Error quantity
        /// </summary>
        private double _ErrorQty;

        /// <summary>
        /// PLC product quantity
        /// </summary>
        private double _PLCProdQty;

        /// <summary>
        /// PLC error quantity
        /// </summary>
        private double _PLCErrorQty;

        /// <summary>
        /// Last line date
        /// </summary>
        private string _LastLineDate;

        /// <summary>
        /// Next work
        /// </summary>
        private string _NextWork;

        /// <summary>
        /// Line status
        /// </summary>
        private string _LineStatus;

        /// <summary>
        /// Machine error count
        /// </summary>
        private int _MachErrorCount;

        /// <summary>
        /// Multi order no
        /// </summary>
        private string _MultiOrderNo;

        /// <summary>
        /// Auto gathering
        /// </summary>
        private string _AutoGathering;
        
        /// <summary>
        /// Plan mold code
        /// </summary>
        private string _PlanMoldCode;

        /// <summary>
        /// Plan mold name
        /// </summary>
        private string _PlanMoldName;

        /// <summary>
        /// Mold code
        /// </summary>
        private string _MoldCode;
        
        /// <summary>
        /// Mold name
        /// </summary>
        private string _MoldName;

        /// <summary>
        /// New old
        /// </summary>
        private string _NewOld;

        /// <summary>
        /// Invalid quantity
        /// </summary>
        private double _InvalidQty;

        /// <summary>
        /// Carry in quantity
        /// </summary>
        private string _CarryInQty;

        /// <summary>
        /// Furnance temp
        /// </summary>
        private string _FurnanceTemp;

        #endregion

        #region Constructor

        /// <summary>
        /// Workcenter constructor
        /// </summary>
        public WorkCenter()
        {
            _Hashtable = new Hashtable();

            _ListWorker.Add(new WorkerList(SmartDas.Common.ListWorkerType.SELECT));
            _ListWorker.Add(new WorkerList(SmartDas.Common.ListWorkerType.MACH));
            _ListWorker.Add(new WorkerList(SmartDas.Common.ListWorkerType.PROD));

            _ListOrder.Add(new OrderList(SmartDas.Common.ListOrderType.SELECT));
            _ListOrder.Add(new OrderList(SmartDas.Common.ListOrderType.MACH));
            _ListOrder.Add(new OrderList(SmartDas.Common.ListOrderType.PROD));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clear hash
        /// </summary>
        public void ClearHash()
        {
            _Hashtable.Clear();
        }

        /// <summary>
        /// Get worker list
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public WorkerList GetWorkerList(SmartDas.Common.ListWorkerType type)
        {
            foreach (WorkerList workerList in _ListWorker)
            {
                if (workerList.ListType == type)
                {
                    return workerList;
                }
            }

            return null;
        }

        /// <summary>
        /// Get order list
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public OrderList GetOrderList(SmartDas.Common.ListOrderType type)
        {
            foreach (OrderList orderList in _ListOrder)
            {
                if (orderList.ListType == type)
                {
                    return orderList;
                }
            }

            return null;
        }

        //public int Save()
        //{
        //    if (_Hashtable.Values.Count == 0) return 0;
        //    Database db = DatabaseFactory.CreateDatabase();
        //    SqlConnection dconn = (SqlConnection)db.CreateConnection();

        //    SqlCommand cmd;

        //    dconn.Open();
        //    SqlTransaction ot = dconn.BeginTransaction();
        //    try
        //    {
        //        int iCnt = 0;
        //        if (_Hashtable.Values.Count > 0)
        //        {
        //            try
        //            {
        //                if (_Code != null && _PlantCode != null)
        //                {
        //                    if (_Code != "" && _PlantCode != "")
        //                    {
        //                        string sSQL;

        //                        sSQL = string.Empty;
        //                        sSQL += "Update TPP1700 set " + "\n";

        //                        foreach (string s in _Hashtable.Keys)
        //                        {
        //                            switch (s)
        //                            {
        //                                case "WorkCenterCode":
        //                                case "PlantCode":
        //                                    // 키는 업데이트문에 넣지 않음.
        //                                    break;
        //                                case "LineStatus":
        //                                    sSQL += (iCnt == 0) ? "   " : "   , ";
        //                                    sSQL += s + " = '" + (_Hashtable[s] == null ? "" : _Hashtable[s].ToString().Replace("'", "''")) + "' " + "\n";
        //                                    break;
        //                                case "OrderCnt":
        //                                case "WorkerCnt":
        //                                case "MachErrorCnt":
        //                                    sSQL += (iCnt == 0) ? "   " : "   , ";
        //                                    sSQL += s + " = " + (_Hashtable[s] == null ? 0 : Convert.ToInt32(_Hashtable[s])) + " " + "\n";
        //                                    break;
        //                                //case "PlanQty":
        //                                //case "ProdQty":
        //                                //case "ErrorQty":
        //                                //case "PLCProdQty":
        //                                //case "PLCErrorQty":
        //                                //    sSQL += (iCnt == 0) ? "   " : "   , ";
        //                                //    sSQL += s + " = " + (_hash[s] == null ? 0 : Convert.ToDouble(_hash[s])) + " " + "\n";
        //                                //    break;
        //                                case "LastLineDate":
        //                                    sSQL += (iCnt == 0) ? "   " : "   , ";
        //                                    sSQL += s + " = " + ((_Hashtable[s] == null || _Hashtable[s].ToString() == "") ? "getdate()" : "'" + Convert.ToDateTime(_Hashtable[s]).ToString("yyyy-MM-dd HH:mm:ss") + "'") + "\n";
        //                                    break;
        //                            }

        //                            iCnt++;
        //                        }

        //                        sSQL += "   , LastDate = getdate() " + "\n";
        //                        sSQL += " where PlantCode = '" + PlantCode + "' " + "\n";
        //                        sSQL += "   and WorkCenterCode = '" + Code + "' " + "\n";

        //                        cmd = (SqlCommand)db.GetSqlStringCommand(sSQL);
        //                        cmd.Connection = dconn;
        //                        cmd.Transaction = ot;
        //                        cmd.CommandType = System.Data.CommandType.Text;

        //                        int iCount = cmd.ExecuteNonQuery();

        //                        iCnt = 0;

        //                        if (iCount == 0)
        //                        {
        //                            string preSql = "";
        //                            string postSql = "";

        //                            sSQL = "";
        //                            sSQL += "Insert into TPP1700 ( " + "\n";

        //                            preSql += "PlantCode, WorkCenterCode";
        //                            postSql += "'" + _PlantCode + "', '" + _Code + "'";

        //                            foreach (string s in _Hashtable.Keys)
        //                            {
        //                                switch (s)
        //                                {
        //                                    case "WorkCenterCode":
        //                                    case "PlantCode":
        //                                        // 키는 인서트문에 기본 설정
        //                                        break;
        //                                    case "LineStatus":
        //                                        preSql += ", " + s;
        //                                        postSql += ", '" + (_Hashtable[s] == null ? "" : _Hashtable[s].ToString()) + "'";
        //                                        break;
        //                                    case "OrderCnt":
        //                                    case "WorkerCnt":
        //                                    case "MachErrorCnt":
        //                                        preSql += ", " + s;
        //                                        postSql += ", " + (_Hashtable[s] == null ? 0 : Convert.ToInt32(_Hashtable[s]));
        //                                        break;
        //                                    //case "PlanQty":
        //                                    //case "ProdQty":
        //                                    //case "ErrorQty":
        //                                    //case "PLCProdQty":
        //                                    //case "PLCErrorQty":
        //                                    //    preSql += ", " + s;
        //                                    //    postSql += ", " + (_hash[s] == null ? 0 : Convert.ToDouble(_hash[s]));
        //                                    //    break;
        //                                    case "LastLineDate":
        //                                        preSql += ", " + s;
        //                                        postSql += ", " + (_Hashtable[s] == null ? "getdate()" : "'" + Convert.ToDateTime(_Hashtable[s]).ToString("yyyy-MM-dd HH:mm:ss") + "'");
        //                                        break;
        //                                }
        //                                iCnt++;
        //                            }

        //                            sSQL = sSQL + preSql + " ) values \n ( " + postSql + ") ";

        //                            cmd = (SqlCommand)db.GetSqlStringCommand(sSQL);
        //                            cmd.Connection = dconn;
        //                            cmd.Transaction = ot;
        //                            cmd.CommandType = System.Data.CommandType.Text;

        //                            iCount = cmd.ExecuteNonQuery();
        //                        }

        //                        _Hashtable.Clear();
        //                    }
        //                }
        //            }
        //            catch (SqlException oe)
        //            {
        //                ot.Rollback();
        //                ot = null;
        //                clsDB.Rollback();
        //                return oe.Number;
        //            }
        //            catch (Exception)
        //            {
        //                ot.Rollback();
        //                ot = null;
        //                clsDB.Rollback();
        //                return -1;
        //            }

        //            ot.Commit();
        //            ot = null;
        //            dconn.Close();
        //            return 0;
        //        }
        //        else
        //        {
        //            clsDB.Rollback();
        //            return -2;
        //        }
        //    }
        //    finally
        //    {
        //        if (ot != null)
        //        {
        //            ot.Rollback();
        //        }
        //        if (dconn != null)
        //        {
        //            if (dconn.State != ConnectionState.Closed)
        //                dconn.Close();
        //        }
        //    }

        //}

        #endregion

        #region Properties

        /// <summary>
        /// Code
        /// </summary>
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Plantcode
        /// </summary>
        public string PlantCode
        {
            get { return _PlantCode; }
            set { _PlantCode = value; }
        }

        /// <summary>
        /// Line status
        /// </summary>
        public string LineStatus
        {
            get { return _LineStatus; }
            set { _LineStatus = value; }
        }

        /// <summary>
        /// Last line date
        /// </summary>
        public string LastLineDate
        {
            get { return _LastLineDate; }
            set { _LastLineDate = value; }
        }

        /// <summary>
        /// Item code
        /// </summary>
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }

        /// <summary>
        /// Item name
        /// </summary>
        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        /// <summary>
        /// Order no
        /// </summary>
        public string OrderNo
        {
            get { return _OrderNo; }
            set { _OrderNo = value; }
        }

        /// <summary>
        /// Worker count
        /// </summary>
        public int WorkerCnt
        {
            get { return _WorkerCount; }
            set { _WorkerCount = value; }
        }

        /// <summary>
        /// PLC prod qty
        /// </summary>
        public double PLCProdQty
        {
            get { return _PLCProdQty; }
            set { _PLCProdQty = value; }
        }

        /// <summary>
        /// PLC Error qty
        /// </summary>
        public double PLCErrorQty
        {
            get { return _PLCErrorQty; }
            set { _PLCErrorQty = value; }
        }
 
        /// <summary>
        /// Plan qty
        /// </summary>
        public double PlanQty
        {
            get { return _PlanQty; }
            set { _PlanQty = value; }
        }

        /// <summary>
        /// Prod qty
        /// </summary>
        public double ProdQty
        {
            get { return _ProdQty; }
            set { _ProdQty = value; }
        }

        /// <summary>
        /// Error qty
        /// </summary>
        public double ErrorQty
        {
            get { return _ErrorQty; }
            set { _ErrorQty = value; }
        }

        /// <summary>
        /// Unit code
        /// </summary>
        public string UnitCode
        {
            get { return _UnitCode; }
            set { _UnitCode = value; }
        }

        /// <summary>
        /// Next work
        /// </summary>
        public string NextWork
        {
            get { return _NextWork; }
            set { _NextWork = value; }
        }

        /// <summary>
        /// Mach error count
        /// </summary>
        public int MachErrorCnt
        {
            get { return _MachErrorCount; }
            set { _MachErrorCount = value; }
        }
    
        /// <summary>
        /// Multi order no
        /// </summary>
        public string MultiOrderNo
        {
            get { return _MultiOrderNo; }
            set { _MultiOrderNo = value; }
        }

        /// <summary>
        /// Auto gathering
        /// </summary>
        public string AutoGathering
        {
            get { return _AutoGathering; }
            set { _AutoGathering = value; }
        }

        /// <summary>
        /// Order count
        /// </summary>
        public int OrderCnt
        {
            get { return _OrderCount; }
            set { _OrderCount = value; }
        }

        /// <summary>
        /// Plan mold code
        /// </summary>
        public string PlanMoldCode
        {
            get { return _PlanMoldCode; }
            set { _PlanMoldCode = value; }
        }

        /// <summary>
        /// Plan mold name
        /// </summary>
        public string PlanMoldName
        {
            get { return _PlanMoldName; }
            set { _PlanMoldName = value; }
        }

        /// <summary>
        /// Mold code
        /// </summary>
        public string MoldCode
        {
            get { return _MoldCode; }
            set { _MoldCode = value; }
        }

        /// <summary>
        /// Mold name
        /// </summary>
        public string MoldName
        {
            get { return _MoldName; }
            set { _MoldName = value; }
        }

        /// <summary>
        /// New old
        /// </summary>
        public string NewOld
        {
            get { return _NewOld; }
            set { _NewOld = value; }
        }

        /// <summary>
        /// Invalid qty
        /// </summary>
        public double InvalidQty
        {
            get { return _InvalidQty; }
            set { _InvalidQty = value; }
        }

        /// <summary>
        /// Carry in qty
        /// </summary>
        public string CarryInQty
        {
            get { return _CarryInQty; }
            set { _CarryInQty = value; }
        }

        /// <summary>
        /// Furnance temp
        /// </summary>
        public string FurnanceTemp
        {
            get { return _FurnanceTemp; }
            set { _FurnanceTemp = value; }
        }

        #endregion
    }

    #endregion

    #region Worker class

    /// <summary>
    /// Worker class
    /// </summary>
    public class Worker
    {
        #region Variables

        /// <summary>
        /// ID
        /// </summary>
        public string ID;

        /// <summary>
        /// Name
        /// </summary>
        public string Name;

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone;

        #endregion

        #region Constructors

        /// <summary>
        /// Worker constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Worker(string id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// Worker constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public Worker(string id, string name, string phone)
        {
            ID = id;
            Name = name;
            Phone = phone;
        }

        #endregion
    }

    #endregion

    #region Order class

    /// <summary>
    /// Order class
    /// </summary>
    public class Order
    {
        #region Variables

        /// <summary>
        /// OrderNo
        /// </summary>
        public string OrderNo;

        /// <summary>
        /// Item code
        /// </summary>
        public string ItemCode;

        /// <summary>
        /// Item name
        /// </summary>
        public string ItemName;

        #endregion

        #region Constructors

        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderNo"></param>
        /// <param name="itemCode"></param>
        public Order(string orderNo, string itemCode)
        {
            OrderNo = orderNo;
            ItemCode = itemCode;
        }

        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderNo"></param>
        /// <param name="itemCode"></param>
        /// <param name="itemName"></param>
        public Order(string orderNo, string itemCode, string itemName)
        {
            OrderNo = orderNo;
            ItemCode = itemCode;
            ItemName = itemName;
        }

        #endregion
    }

    #endregion

    #region OrderList class

    /// <summary>
    /// Order list class
    /// </summary>
    public class OrderList
    {
        #region Variables

        /// <summary>
        /// Order list
        /// </summary>
        private Collection<Order> _Orderlist;

        /// <summary>
        /// Type list
        /// </summary>
        public SmartDas.Common.ListOrderType ListType;

        #endregion

        #region Constructors

        /// <summary>
        /// Order list constructor
        /// </summary>
        public OrderList()
        {
            _Orderlist = new Collection<Order>();
        }

        /// <summary>
        /// Order list constructor
        /// </summary>
        /// <param name="group"></param>
        public OrderList(SmartDas.Common.ListOrderType group)
        {
            _Orderlist = new Collection<Order>();
            ListType = group;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            _Orderlist.Clear();
        }

        /// <summary>
        /// Add order
        /// </summary>
        /// <param name="orderNo"></param>
        /// <param name="itemcode"></param>
        public void AddOrder(string orderNo, string itemcode)
        {
            bool bExist = false;

            foreach (Order order in this._Orderlist)
            {
                if (order.OrderNo == orderNo)
                {
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                this._Orderlist.Add(new Order(orderNo, itemcode));
            }
        }

        /// <summary>
        /// Add order
        /// </summary>
        /// <param name="orderNo"></param>
        /// <param name="itemcode"></param>
        /// <param name="itemname"></param>
        public void AddOrder(string orderNo, string itemcode, string itemname)
        {
            bool bExist = false;

            foreach (Order order in this._Orderlist)
            {
                if (order.OrderNo == orderNo)
                {
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                this._Orderlist.Add(new Order(orderNo, itemcode, itemname));
            }
        }

        /// <summary>
        /// Remove worker
        /// </summary>
        /// <param name="orderNo"></param>
        public void RemoveWorker(string orderNo)
        {
            Order order = null;

            foreach (Order order1 in this._Orderlist)
            {
                if (order1.OrderNo == orderNo)
                {
                    order = order1;
                    break;
                }
            }

            if (order != null)
            {
                this._Orderlist.Remove(order);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// List
        /// </summary>
        public Collection<Order> List
        {
            get
            {
                return _Orderlist;
            }
        }

        /// <summary>
        /// Ordre
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Order this[string str]
        {
            get
            {
                foreach (Order o in _Orderlist)
                {
                    if (o.OrderNo == str)
                        return o;
                }

                return null;
            }
        }

        /// <summary>
        /// All order No
        /// </summary>
        public string AllOrderNo
        {
            get
            {
                string sNameList = "";

                foreach (Order o in _Orderlist)
                {
                    if (sNameList == "")
                        sNameList += o.OrderNo;
                    else
                        sNameList += ", " + o.OrderNo;
                }

                return sNameList;
            }
        }

        /// <summary>
        /// Order Count
        /// </summary>
        public int OrderCount
        {
            get { return _Orderlist.Count; }
        }

        #endregion
    }

    #endregion

    #region Worker list class

    /// <summary>
    /// Workcer list class
    /// </summary>
    public class WorkerList
    {
        #region Variables

        /// <summary>
        /// Worker list
        /// </summary>
        private Collection<Worker> _Workerlist;

        /// <summary>
        /// List type
        /// </summary>
        public SmartDas.Common.ListWorkerType ListType;

        #endregion

        #region Constructors

        /// <summary>
        /// Worker list constructor
        /// </summary>
        public WorkerList()
        {
            _Workerlist = new Collection<Worker>();
        }

        /// <summary>
        /// Worker list constructor
        /// </summary>
        /// <param name="group"></param>
        public WorkerList(SmartDas.Common.ListWorkerType group)
        {
            _Workerlist = new Collection<Worker>();
            ListType = group;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            _Workerlist.Clear();
        }

        /// <summary>
        /// Add worker
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void AddWorker(string id, string name)
        {
            bool bExist = false;

            foreach (Worker worker in this._Workerlist)
            {
                if (worker.ID == id)
                {
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                this._Workerlist.Add(new Worker(id, name));
            }
        }

        /// <summary>
        /// Add worker
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public void AddWorker(string id, string name, string phone)
        {
            bool bExist = false;

            foreach (Worker worker in this._Workerlist)
            {
                if (worker.ID == id)
                {
                    bExist = true;
                    break;
                }
            }

            if (!bExist)
            {
                this._Workerlist.Add(new Worker(id, name, phone));
            }
        }

        /// <summary>
        /// Remove worker
        /// </summary>
        /// <param name="id"></param>
        public void RemoveWorker(string id)
        {
            Worker worker = null;

            foreach (Worker worker1 in this._Workerlist)
            {
                if (worker1.ID == id)
                {
                    worker = worker1;
                    break;
                }
            }

            if (worker != null)
            {
                this._Workerlist.Remove(worker);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// List
        /// </summary>
        public Collection<Worker> List
        {
            get
            {
                return _Workerlist;
            }
        }

        /// <summary>
        /// Worker
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Worker this[string str]
        {
            get
            {
                foreach (Worker w in _Workerlist)
                {
                    if (w.ID == str)
                        return w;

                    if (w.Name == str)
                        return w;
                }

                return null;
            }
        }

        /// <summary>
        /// All worker name
        /// </summary>
        public string AllWorkerName
        {
            get
            {
                string sNameList = "";

                foreach (Worker w in _Workerlist)
                {
                    if (sNameList == "")
                        sNameList += w.Name;
                    else
                        sNameList += ", " + w.Name;
                }

                return sNameList;
            }
        }

        /// <summary>
        /// All worker id
        /// </summary>
        public string AllWorkerID
        {
            get
            {
                string sIDList = "";

                foreach (Worker w in _Workerlist)
                {
                    if (sIDList == "")
                        sIDList += w.ID;
                    else
                        sIDList += ", " + w.ID;
                }

                return sIDList;
            }
        }

        /// <summary>
        /// Worker count
        /// </summary>
        public int WorkerCount
        {
            get { return _Workerlist.Count; }
        }

        #endregion
    }
    #endregion

    #region Common class

    /// <summary>
    /// Common class
    /// </summary>
    public static class Common
    {
        #region Variable

        /// <summary>
        /// Worker type list enum
        /// </summary>
        public enum ListWorkerType { SELECT, PROD, MACH }

        /// <summary>
        /// Order type list enum
        /// </summary>
        public enum ListOrderType { SELECT, PROD, MACH }
        public static string gsIP;
        public static string svrIP;

        public static Worker worker_DA1110 = new Worker("", "");
        public static Worker worker_DA1120 = new Worker("", "");

        private static WorkCenter _selWorkCenter = null;
        public static Collection<WorkCenter> gListWorkCenter = new Collection<WorkCenter>();

        public static string gsPlantCode = "SK1";
        public static string gsDASDivision;   //
        //public static bool gbInSamkeeIP = false;

        public static string gRecDate;
        public static string gDayNight;

        public static double dOverRate;

        public static string sPrintValue;        
        public static string sERPDB = "" ;// System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None).AppSettings.Settings["ERP"].Value;

        public static DateTime startDatetime;

        private static Hashtable hashMessage  = new Hashtable();
        private static Hashtable hashLanguage = new Hashtable();

        private static List<SendProcess> listProcess = new List<SendProcess>();

        #endregion

        #region Events

        /// <summary>
        /// Process end event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void sp_ProcessEndEvent(object sender, EventArgs e)
        {
            SendProcess sendProcess = (SendProcess)sender;
            RemoveSendProcess(sendProcess);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get workcenter
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static WorkCenter GetWorkCenter(string value)
        {
            foreach (WorkCenter workCenter in gListWorkCenter)
            {
                if (workCenter.Code == value)
                {
                    return workCenter;
                }
            }

            return null;
        }

        /// <summary>
        /// Roll back transaction
        /// </summary>
        /// <param name="sqlTransaction"></param>
        public static void RollBackTran(SqlTransaction sqlTransaction)
        {
            if (sqlTransaction != null)
            {
                sqlTransaction.Rollback();

                if (sqlTransaction.Connection != null)
                {
                    if (sqlTransaction.Connection.State != System.Data.ConnectionState.Closed)
                    {
                        sqlTransaction.Connection.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Get IP Address
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            string clientIP = String.Empty;
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());

            for (int i = 0; i < ipHost.AddressList.Length; i++)
            {
                if (ipHost.AddressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    clientIP = ipHost.AddressList[i].ToString();

                    if (!clientIP.Contains("192.168.1.") && !clientIP.Contains("192.168.56."))
                    {
                        clientIP = ipHost.AddressList[i].ToString();
                        break;
                    }
                }
            }

            return clientIP;
        }

        /// <summary>
        /// Printer state check
        /// </summary>
        public static void PrinterStateCheck()
        {
            PrintDocument printDocument = new PrintDocument();

            foreach (string name in PrinterSettings.InstalledPrinters)
            {
                printDocument.PrinterSettings.PrinterName = name;

                if (printDocument.PrinterSettings.IsValid)
                {
                    PrinterSettings printerSettings = printDocument.PrinterSettings;

                    if (printerSettings.PaperSources[0].Kind == PaperSourceKind.Manual && printerSettings.PaperSources[0].SourceName == "Manual feed")
                    {
                        PrinterStateCheck(printerSettings.PrinterName);
                    }
                }
            }
        }

        /// <summary>
        /// Printer state check
        /// </summary>
        /// <param name="szPrinterName"></param>
        /// <returns></returns>
        private static string PrinterStateCheck(string szPrinterName)
        {
            string[] printerStatus = { "Other", "Unknown", "Idle", "Printing", "WarmUp", "Stopped Printing", "Offline" };

            string[] printerState = {"Paused","Error","Pending Deletion","Paper Jam","Paper Out"
                                    ,"Manual Feed","Paper Problem", "Offline","IO Active","Busy","Printing"
                                    , "Output Bin Full","Not Available","Waiting", "Processing","Initialization"
                                    ,"Warming Up","Toner Low","No Toner","Page Punt", "User Intervention Required" 
                                    ,"Out of Memory","Door Open","Server_Unknown","Power Save"};

            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}%'", szPrinterName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection collection = searcher.Get();

            string errorName = string.Empty;
            sPrintValue = string.Empty;

            foreach (ManagementObject managementObject in collection)
            {
                foreach (PropertyData propertyData in managementObject.Properties)
                {
                    sPrintValue += propertyData.Name + " : " + clsDB.nvlString(propertyData.Value) + "\n";
                }

                int state = Convert.ToInt32(managementObject["PrinterState"]);
                MessageBox.Show(printerState[state]);

                state = Convert.ToInt32(managementObject["PrinterStatus"]);
                MessageBox.Show(printerStatus[state]);
            }

            return errorName;
        }

        /// <summary>
        /// Get plant code
        /// </summary>
        /// <param name="sIP"></param>
        public static void GetPlantCode(string sIP)
        {
            try
            {
                Database database = DatabaseFactory.CreateDatabase();
                SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
                DataTable dt = new DataTable();

                string[] sArr = sIP.Split('.');

                if (sArr.Length == 4)
                {
                    string sSQL = "";

                    sSQL += "SELECT MINORCODE FROM TBM0000 WHERE MAJORCODE = 'PLANTIP' AND RELCODE1 LIKE '%" + sArr[2] + ",%'";

                    if (CheckNetwork() >= 1)
                    {
                        if (clsDB.gCreateRSet(sqlConnection, sSQL, dt))
                        {
                            if (dt.Rows.Count == 1)
                            {
                                gsPlantCode = dt.Rows[0]["MINORCODE"].ToString();
                                //gbInSamkeeIP = true;

                            }
                            else
                            {
                                if (sArr[2] == "60" || sArr[2] == "80" || sArr[2] == "100" || sArr[2] == "200"
                                                    || sArr[2] == "201" || sArr[2] == "205" || sArr[2] == "230"
                                                    || sArr[2] == "250" )
                                {
                                    gsPlantCode = "SK2";
                                }
                                else
                                {
                                    gsPlantCode = "SK1";
                                }
                                
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("서버에 연결할 수 없습니다.");
                        Application.Exit();
                    }
                }
                else
                {
                    gsPlantCode = "SK1";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Check network
        /// </summary>
        /// <returns></returns>
        private static int CheckNetwork()
        {
            try
            {
                DateTime dStartTime = DateTime.Now;

                Database database;
                database = DatabaseFactory.CreateDatabase();
                System.Data.Common.DbConnection dbConnection = database.CreateConnection();

                dbConnection.Open();
                dbConnection.Close();

                DateTime dEndTime = DateTime.Now;

                clsDB.bUseNetwork = true;

                if ((dEndTime - dStartTime).TotalSeconds > 0.2)
                {
                    return 2;
                }

                return 1;
            }
            catch (SqlException sqlException)
            {
                switch (sqlException.Number)
                {
                    case 3135:
                        break;
                    case 12543:
                        break;
                    default:
                        break;
                }

                return 0;
            }
        }

        /// <summary>
        /// Get division
        /// </summary>
        /// <param name="sIP"></param>
        public static void GetDivision(string sIP)
        {
            if (CheckNetwork() < 1)
            {
                MessageBox.Show("서버에 연결할 수 없습니다.");
                Application.Exit();
            }

            try
            {
                Database db = DatabaseFactory.CreateDatabase();
                SqlConnection conn = (SqlConnection)db.CreateConnection();
                DataTable dt = new DataTable();


                string sSQL = string.Empty;
                sSQL += "SELECT DASDIVISION  " + "\n";
                sSQL += "  FROM TBM9100      " + "\n";
                sSQL += " WHERE IPADDRESS = '" + sIP + "'\n";

                if (clsDB.gCreateRSet(conn, sSQL, dt))
                {
                    if (dt.Rows.Count == 1)
                    {
                        gsDASDivision = dt.Rows[0]["DASDIVISION"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Send sms
        /// </summary>
        /// <param name="sMsg"></param>
        public static void SendSMS(string sMsg)
        {
            SendProcess sendProcess = new SendProcess(sMsg);
            sendProcess.ProcessEndEvent += new EventHandler(sp_ProcessEndEvent);
            listProcess.Add(sendProcess);
        }

        /// <summary>
        /// Remove send process
        /// </summary>
        /// <param name="sendProcess"></param>
        private static void RemoveSendProcess(SendProcess sendProcess)
        {
            listProcess.Remove(sendProcess);
            sendProcess.ProcessEnd();
        }

        /// <summary>
        /// Clear send process
        /// </summary>
        public static void ClearSendProcess()
        {
            foreach (SendProcess sendProcess in listProcess)
            {
                sendProcess.ProcessEndEvent -= new EventHandler(sp_ProcessEndEvent);
                sendProcess.ProcessEnd();
            }

            listProcess.Clear();
        }

        /// <summary>
        /// Get message list
        /// </summary>
        public static void GetMessageList()
        {
            hashMessage.Clear();

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
            DataTable dt = new DataTable();

            string sSQL = string.Empty;
            sSQL = "SELECT MESSAGEID, MESSAGEDESC FROM TBm4000 WHERE USEFLAG = 'Y'  ";

            if (clsDB.gCreateRSet(sqlConnection, sSQL, dt))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    hashMessage.Add(clsDB.nvlString(dr["MESSAGEID"]), clsDB.nvlString(dr["MESSAGEDESC"]));
                }
            }
        }


        public static void GetLanguageList(string language = "KR")
        {
            hashLanguage.Clear();

            Database database = DatabaseFactory.CreateDatabase();
            SqlConnection sqlConnection = (SqlConnection)database.CreateConnection();
            DataTable dt = new DataTable();

            string sSQL = string.Empty;

            switch (language)
            {
                case "KR":
                    sSQL = "SELECT MessageID, MessageDesc   AS MessageDesc FROM TBm4000 WHERE MessageType = 'T' AND UseFlag = 'Y'";
                    break;
                case "EN":
                    sSQL = "SELECT MessageID, MessageDescEN AS MessageDesc FROM TBm4000 WHERE MessageType = 'T' AND UseFlag = 'Y'";
                    break;
                case "RU":
                    sSQL = "SELECT MessageID, MessageDescRU AS MessageDesc FROM TBm4000 WHERE MessageType = 'T' AND UseFlag = 'Y'";
                    break;
                case "ID":
                    sSQL = "SELECT MessageID, MessageDescID AS MessageDesc FROM TBm4000 WHERE MessageType = 'T' AND UseFlag = 'Y'";
                    break;
                default:
                    sSQL = "SELECT MessageID, MessageDesc   AS MessageDesc FROM TBm4000 WHERE MessageType = 'T' AND UseFlag = 'Y'";
                    break;
            }                
            if (clsDB.gCreateRSet(sqlConnection, sSQL, dt))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    hashLanguage.Add(clsDB.nvlString(dr["MessageID"]), clsDB.nvlString(dr["MessageDesc"]));
                }
            }
        }

        public static string GetLanguage(string messageID)
        {            
            if (messageID != null || messageID != string.Empty)
            {
                if (hashLanguage[messageID] != null)
                {
                    return clsDB.nvlString(hashLanguage[messageID]);
                }
                else if (messageID == "T00030")
                {
                    return "네트워크상태 정상";
                }
                else if (messageID == "T00031")
                {
                    return "네트워크상태 불량";
                }
                else if (messageID == "T00032")
                {
                    return "네트워크상태 연결안됨";
                }
                else
                {
                    return "(" + messageID + ") 를 등록하세요.";
                }
            }
            else
            {
                return clsDB.nvlString(messageID);
            }
        }

        /// <summary>
        /// Get message
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string GetMessage(string mes)
        {
            string[] sArr = mes.Split(':');

            if (sArr.Length == 2 && sArr[0] == "C")
            {
                if (hashMessage[sArr[1]] != null)
                {
                    return clsDB.nvlString(hashMessage[sArr[1]]);
                }
                else
                {
                    return "(" + mes + ") 를 등록하세요.";
                }
            }
            else
            {
                return clsDB.nvlString(mes);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Selected workcenter
        /// </summary>
        public static WorkCenter SelectedWorkCenter
        {
            get { return _selWorkCenter; }
            set { _selWorkCenter = value; }
        }

        #endregion
    }

    #endregion

    #region Send process class

    /// <summary>
    /// Send process class
    /// </summary>
    public class SendProcess
    {
        #region Variables

        /// <summary>
        /// Thread
        /// </summary>
        Thread thread = null;

        /// <summary>
        /// Time max
        /// </summary>
        int iTimeMax = 30;

        /// <summary>
        /// Time
        /// </summary>
        int iTime = 0;

        /// <summary>
        /// Process
        /// </summary>
        Process process = null;

        /// <summary>
        /// Process end event
        /// </summary>
        public event EventHandler ProcessEndEvent;

        /// <summary>
        /// Message
        /// </summary>
        private string message = string.Empty;

        #endregion

        #region Constructors

        /// <summary>
        /// Send process constructor
        /// </summary>
        /// <param name="sMsg"></param>
        public SendProcess(string sMsg)
        {
            iTime = 0;
            message = sMsg;

            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = message;
            process = Process.Start(startInfo);

            thread = new Thread(new ThreadStart(ProcessStoper));
            thread.Start();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Process stoper
        /// </summary>
        private void ProcessStoper()
        {
            try
            {
                while (true)
                {
                    if (iTime >= iTimeMax)
                    {
                        process.Close();
                        process = null;

                        ProcessEndEvent(this, new EventArgs());

                        return;
                    }

                    iTime++;

                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException )
            {
                return;
            }
            finally
            {
                
            }
        }

        /// <summary>
        /// Process end
        /// </summary>
        public void ProcessEnd()
        {
            try
            {
                if (thread != null)
                {
                    if (process != null)
                    {
                        process.Close();
                        process = null;
                    }

                    thread.Abort();
                    thread = null;
                }
            }
            catch (Exception )
            {
                return;
            }
        }

        #endregion
    }

    #endregion
}
