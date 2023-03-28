using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDBApp
{
    public partial class mainMenuFrm : Form
    {
        public mainMenuFrm()
        {
            InitializeComponent();
        }

        private void computerBttn_Click(object sender, EventArgs e)
        {
            ComputerFrm comp = new ComputerFrm();
            comp.ShowDialog();
        }

        private void monitorBttn_Click(object sender, EventArgs e)
        {
            MonitorFrm mon = new MonitorFrm();
            mon.ShowDialog();
        }

        private void printerBttn_Click(object sender, EventArgs e)
        {
            PrinterFrm prin = new PrinterFrm();
            prin.ShowDialog();
        }

        private void serverBttn_Click(object sender, EventArgs e)
        {
            ServerFrm serv = new ServerFrm();
            serv.ShowDialog();
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
