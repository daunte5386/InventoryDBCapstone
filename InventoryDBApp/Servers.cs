using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDBApp
{
    class Servers : Inventory
    {
        private string serverProcessor, serverProcessorSpeed, serverRAM,
            serverOperatingSystem, serverOperatingSystemBit, serverHDD,
            serverHDDRaidType, serverHDDCapacity, serverVirtual, serverLocation;

        public Servers()
        {

        }

        public Servers(string ma, string mo, string serNum, string serProc, string serProcSp,
            string serRa, string serOS, string serOSBit, string serHDD, string serHDDRaiTy,
            string serHDDCap, string serVirt, string serLoc)
            : base(ma, mo, serNum)
        {
            serverProcessor = serProc;
            serverProcessorSpeed = serProcSp;
            serverRAM = serRa;
            serverOperatingSystem = serOS;
            serverOperatingSystemBit = serOSBit;
            serverHDD = serHDD;
            serverHDDRaidType = serHDDRaiTy;
            serverHDDCapacity = serHDDCap;
            serverVirtual = serVirt;
            serverLocation = serLoc;
        }

        public string ServerProcessor
        {
            get
            {
                return serverProcessor;
            }

            set
            {
                serverProcessor = value;
            }
        }

        public string ServerProcessorSpeed
        {
            get
            {
                return serverProcessorSpeed;
            }

            set
            {
                serverProcessorSpeed = value;
            }
        }

        public string ServerRAM
        {
            get
            {
                return serverRAM;
            }

            set
            {
                serverRAM = value;
            }
        }

        public string ServerOperatingSystem
        {
            get
            {
                return serverOperatingSystem;
            }

            set
            {
                serverOperatingSystem = value;
            }
        }

        public string ServerOperatingSystemBit
        {
            get
            {
                return serverOperatingSystemBit;
            }

            set
            {
                serverOperatingSystemBit = value;
            }
        }

        public string ServerHDD
        {
            get
            {
                return serverHDD;
            }

            set
            {
                serverHDD = value;
            }
        }

        public string ServerHDDRaidType
        {
            get
            {
                return serverHDDRaidType;
            }

            set
            {
                serverHDDRaidType = value;
            }
        }

        public string ServerHDDCapacity
        {
            get
            {
                return serverHDDCapacity;
            }

            set
            {
                serverHDDCapacity = value;
            }
        }

        public string ServerVirtual
        {
            get
            {
                return serverVirtual;
            }

            set
            {
                serverVirtual = value;
            }
        }

        public string ServerLocation
        {
            get
            {
                return serverLocation;
            }

            set
            {
                serverLocation = value;
            }
        }

        public void SaveToDB()
        {
            try
            {

                SqlCeConnection ceConn = new SqlCeConnection();
                //string app = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", string.Empty);
                //string ceConnStr = string.Format("Data Source = {0}\\InventoryDB.sdf", app);

                ceConn = new SqlCeConnection("Data Source=|DataDirectory|\\InventoryDB.sdf");

                //ceConn.ConnectionString = ceConnStr;

                string qry = "INSERT INTO Servers(serverMake, serverModel, serverSerNum, serverProc, serverProcSpeed, serverRAM, serverOS, " +
                                                   "serverOSBitType, serverHDD, serverHDDRaidType, serverHDDCap, serverVirtual, serverLocation) " +
                                                   "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + serverProcessor +
                                                   "', '" + serverProcessorSpeed + "', '" + serverRAM + "', '" + serverOperatingSystem + "', '" +
                                                   serverOperatingSystemBit + "', '" + serverHDD + "', '" + serverHDDRaidType + "', '" + 
                                                   serverHDDCapacity + "', '" + serverVirtual + "', '" +  serverLocation + "'" + ")";

                SqlCeCommand sql1 = new SqlCeCommand(qry, ceConn);
                sql1.CommandType = System.Data.CommandType.Text;

                ceConn.Open();

                sql1.ExecuteNonQuery();

                MessageBox.Show("Database Updated");

                ceConn.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
