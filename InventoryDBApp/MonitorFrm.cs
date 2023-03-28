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
    public partial class MonitorFrm : Form
    {
        Monitors mon = new Monitors();

        public MonitorFrm()
        {
            InitializeComponent();
        }

        private void monSaveBttn_Click(object sender, EventArgs e)
        {
            mon.Make = monMakeTxtBx.Text;
            mon.Model = monModelTxtBx.Text;
            mon.SerialNumber = monSerNumTxtBx.Text;
            mon.MonitorSize = monSizeTxtBx.Text;
            mon.MonitorType = monTypeTxtBx.Text;
            mon.MonitorLocation = monLocationTxtBx.Text;

            mon.SaveToDB();
        }

        private void monClearBttn_Click(object sender, EventArgs e)
        {
            monMakeTxtBx.Text = "";
            monModelTxtBx.Text = "";
            monSerNumTxtBx.Text = "";
            monSizeTxtBx.Text = "";
            monTypeTxtBx.Text = "";
            monLocationTxtBx.Text = "";
        }

        private void monExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonitorFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monitorDBDataSet.Monitors' table. You can move, or remove it, as needed.
            this.monitorsTableAdapter.Fill(this.monitorDBDataSet.Monitors);

        }

        private void monRefreshBttn_Click(object sender, EventArgs e)
        {
            this.monitorsTableAdapter.Fill(monitorDBDataSet.Monitors);
        }
    }
}
