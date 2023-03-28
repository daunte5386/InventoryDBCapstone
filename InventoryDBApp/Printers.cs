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
    class Printers : Inventory
    {
        private string printerType, printerCartridgeNumber, printerLocation;

        public Printers()
        {
        }

        public Printers(string ma, string mo, string serNum, string priTyp, string priCartNum, string priLoc)
            : base(ma, mo, serNum)
        {
            printerType = priTyp;
            printerCartridgeNumber = priCartNum;
            printerLocation = priLoc;
        }

        public string PrinterType
        {
            get
            {
                return printerType;
            }

            set
            {
                printerType = value;
            }
        }

        public string PrinterCartridgeNumber
        {
            get
            {
                return printerCartridgeNumber;
            }

            set
            {
                printerCartridgeNumber = value;
            }
        }

        public string PrinterLocation
        {
            get
            {
                return printerLocation;
            }

            set
            {
                printerLocation = value;
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

                string qry = "INSERT INTO Printers(printerMake, printerModel, printerSerNum, printerType, printerCartNum, printerLocation)" +
                                           "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + printerType +
                                                   "', '" + printerCartridgeNumber + "', '" + printerLocation + "'" + ")";

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
