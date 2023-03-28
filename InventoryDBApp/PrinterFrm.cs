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
    public partial class PrinterFrm : Form
    {
        Printers print = new Printers();

        public PrinterFrm()
        {
            InitializeComponent();
        }

        private void printSaveBttn_Click(object sender, EventArgs e)
        {
            print.Make = printerMakeTxtBx.Text;
            print.Model = printerModelTxtBx.Text;
            print.SerialNumber = printerSerNumTxtBx.Text;
            print.PrinterType = printerTypeTxtBx.Text;
            print.PrinterCartridgeNumber = printerCartNumTxtBx.Text;
            print.PrinterLocation = printerLocTxtBx.Text;

            print.SaveToDB();
        }

        private void printClearBttn_Click(object sender, EventArgs e)
        {
            printerMakeTxtBx.Text = "";
            printerModelTxtBx.Text = "";
            printerSerNumTxtBx.Text = "";
            printerTypeTxtBx.Text = "";
            printerCartNumTxtBx.Text = "";
            printerLocTxtBx.Text = "";
        }

        private void printExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrinterFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printerDBDataSet.Printers' table. You can move, or remove it, as needed.
            this.printersTableAdapter.Fill(this.printerDBDataSet.Printers);

        }

        private void printRefreshBttn_Click(object sender, EventArgs e)
        {
            this.printersTableAdapter.Fill(printerDBDataSet.Printers);
        }
    }
}
