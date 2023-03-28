using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDBApp
{
    class Computers : Inventory
    {
        private string computerProcessor, computerProcessorSpeed, computerRAM,
                       computerOperatingSystem, computerOperatingSystemBitType,
                       computerHardDriveSize, computerLocation;

        public Computers()
        {
        }

        public Computers(string ma, string mo, string serNum, string compProc, 
                         string compProcSp, string compR, string compOS, 
                         string compOSBT, string compHDD, string compLoc)
                         :base (ma, mo, serNum)
        {
            computerProcessor = compProc;
            computerProcessorSpeed = compProcSp;
            computerRAM = compR;
            computerOperatingSystem = compOS;
            computerOperatingSystemBitType = compOSBT;
            computerHardDriveSize = compHDD;
            computerLocation = compLoc;
        }

        public string ComputerProcessor
        {
            get
            {
                return computerProcessor;
            }

            set
            {
                computerProcessor = value;
            }
        }

        public string ComputerProcessorSpeed
        {
            get
            {
                return computerProcessorSpeed;
            }

            set
            {
                computerProcessorSpeed = value;
            }
        }

        public string ComputerRAM
        {
            get
            {
                return computerRAM;
            }

            set
            {
                computerRAM = value;
            }
        }

        public string ComputerOperatingSystem
        {
            get
            {
                return computerOperatingSystem;
            }

            set
            {
                computerOperatingSystem = value;
            }
        }

        public string ComputerOperatingSystemBitType
        {
            get
            {
                return computerOperatingSystemBitType;
            }

            set
            {
                computerOperatingSystemBitType = value;
            }
        }

        public string ComputerHardDriveSize
        {
            get
            {
                return computerHardDriveSize;
            }

            set
            {
                computerHardDriveSize = value;
            }
        }

        public string ComputerLocation
        {
            get
            {
                return computerLocation;
            }

            set
            {
                computerLocation = value;
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

                string qry = "INSERT INTO Computers(computerMake, computerModel, computerSerNum, computerProc, computerProcSpeed, " +
                                                   "computerRAM, computerOS, computerOSBitType, computerHDDSize, computerLocation) " +
                                                   "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + computerProcessor +
                                                   "', '" + computerProcessorSpeed + "', '" + computerRAM + "', '" + computerOperatingSystem +
                                                   "', '" + computerOperatingSystemBitType + "', '" + computerHardDriveSize + "', '" + computerLocation + "'" + ")";

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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
