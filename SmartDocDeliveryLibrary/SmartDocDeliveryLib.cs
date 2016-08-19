using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseServiceLib;
using System.Data.SqlClient;
using SmartDocDeliveryLibrary;

namespace SmartDocDeliveryLibrary
{
    public class SmartDocDeliveryLib
    {
        SqlConnection m_Connection;

        // Service Variable
        SmartDocDeliveryService m_SmartDocDeliveryService;

        public SmartDocDeliveryLib(string _pConn)
        {
            this.m_Connection = new SqlConnection(_pConn);
            this.m_SmartDocDeliveryService = new SmartDocDeliveryService(this.m_Connection);            
        }

        // Service Property Set Here
        public SmartDocDeliveryService SmartDocDeliveryService
        {
            get { return this.m_SmartDocDeliveryService; }
            
        }




    }
}
