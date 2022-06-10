using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;   

namespace SmartDas
{
    /// <summary>
    /// Program class
    /// </summary>
    static class Program
    {
        #region Methods

        /// <summary>
        /// Main method
        /// </summary>
        [STAThread]
        static void Main()
        {
            Common.gsIP = Common.GetIPAddress();

            //Common.gsIP = "192.168.219.104"; //더마스터

            Common.GetMessageList();
            

            Common.GetPlantCode(Common.gsIP);
           

            Common.GetDivision(Common.gsIP);
            Common.sERPDB = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None).AppSettings.Settings["ERP"].Value;
            Common.svrIP  = clsDB.sqlConn.ConnectionString;

            switch (Common.gsDASDivision)
            {
                case "M":   // 용해로
                    Application.Run(new DA5000());
                    break;
                case "B":   // 보온로
                    Application.Run(new DA5200());
                    break;
                case "S":   // 사상
                    Application.Run(new DA0070());
                    break;
                case "H":   // 함침
                    Application.Run(new DA0080());
                    break;

                case "R":   // AS
                case "A":   // 가공/조립
                    Application.Run(new DA0050());
                    break;

                case "C":   //주조
                    //Application.Run(new DA0040());
                    Application.Run(new DA0060());
                    break;

                case "L":   // 주조 지게차
                    Application.Run(new DA6000());
                    break;

                case "P":   // 가공/조립 지게차
                    Application.Run(new DA6010());
                    break;

                case "X":   //금형수리
                    Application.Run(new DA7020());
                    break;

                default:
                    Application.Run(new DA9000());
                    break;
            }
        }

        #endregion
    }
}
