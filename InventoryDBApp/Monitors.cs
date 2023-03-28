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
    class Monitors : Inventory
    {
        private string monitorSize, monitorType, monitorLocation;

        public Monitors()
        {
        }

        public Monitors(string ma, string mo, string serNum, string monSize, string monType, string monLoc)
            : base(ma, mo, serNum)
        {
            monitorSize = monSize;
            monitorType = monType;
            monitorLocation = monLoc;
        }

        public string MonitorSize
        {
            get
            {
                return monitorSize;
            }

            set
            {
                monitorSize = value;
            }
        }

        public string MonitorType
        {
            get
            {
                return monitorType;
            }

            set
            {
                monitorType = value;
            }
        }

        public string MonitorLocation
        {
            get
            {
                return monitorLocation;
            }

            set
            {
                monitorLocation = value;
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

                string qry = "INSERT INTO Monitors(monitorMake, monitorModel, monitorSerNum, monitorSize, monitorType, monitorLocation)" +
                                           "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + monitorSize +
                                                   "', '" + monitorType + "', '" + monitorLocation + "'" + ")";

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
