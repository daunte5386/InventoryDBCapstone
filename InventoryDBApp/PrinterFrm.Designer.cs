namespace InventoryDBApp
{
    partial class PrinterFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printHeadPnl = new System.Windows.Forms.Panel();
            this.printerHeadTitleLbl = new System.Windows.Forms.Label();
            this.printerHeadLbl = new System.Windows.Forms.Label();
            this.printerBodyPnl = new System.Windows.Forms.Panel();
            this.printTabCntl = new System.Windows.Forms.TabControl();
            this.printInputTab = new System.Windows.Forms.TabPage();
            this.printExitBttn = new System.Windows.Forms.Button();
            this.printClearBttn = new System.Windows.Forms.Button();
            this.printSaveBttn = new System.Windows.Forms.Button();
            this.printLocationLbl = new System.Windows.Forms.Label();
            this.printMakeLbl = new System.Windows.Forms.Label();
            this.printCartNumLbl = new System.Windows.Forms.Label();
            this.printerLocTxtBx = new System.Windows.Forms.TextBox();
            this.printModelLbl = new System.Windows.Forms.Label();
            this.printerCartNumTxtBx = new System.Windows.Forms.TextBox();
            this.printTypeLbl = new System.Windows.Forms.Label();
            this.printerSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.printerTypeTxtBx = new System.Windows.Forms.TextBox();
            this.printSerNumLbl = new System.Windows.Forms.Label();
            this.printerMakeTxtBx = new System.Windows.Forms.TextBox();
            this.printerModelTxtBx = new System.Windows.Forms.TextBox();
            this.printViewTab = new System.Windows.Forms.TabPage();
            this.printGridView = new System.Windows.Forms.DataGridView();
            this.printerInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerCartNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerDBDataSet = new InventoryDBApp.PrinterDBDataSet();
            this.printRefreshBttn = new System.Windows.Forms.Button();
            this.printersTableAdapter = new InventoryDBApp.PrinterDBDataSetTableAdapters.PrintersTableAdapter();
            this.printHeadPnl.SuspendLayout();
            this.printerBodyPnl.SuspendLayout();
            this.printTabCntl.SuspendLayout();
            this.printInputTab.SuspendLayout();
            this.printViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // printHeadPnl
            // 
            this.printHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printHeadPnl.Controls.Add(this.printerHeadTitleLbl);
            this.printHeadPnl.Controls.Add(this.printerHeadLbl);
            this.printHeadPnl.Location = new System.Drawing.Point(12, 12);
            this.printHeadPnl.Name = "printHeadPnl";
            this.printHeadPnl.Size = new System.Drawing.Size(784, 98);
            this.printHeadPnl.TabIndex = 0;
            // 
            // printerHeadTitleLbl
            // 
            this.printerHeadTitleLbl.AutoSize = true;
            this.printerHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerHeadTitleLbl.Location = new System.Drawing.Point(313, 56);
            this.printerHeadTitleLbl.Name = "printerHeadTitleLbl";
            this.printerHeadTitleLbl.Size = new System.Drawing.Size(144, 26);
            this.printerHeadTitleLbl.TabIndex = 1;
            this.printerHeadTitleLbl.Text = "Printer Page";
            // 
            // printerHeadLbl
            // 
            this.printerHeadLbl.AutoSize = true;
            this.printerHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerHeadLbl.Location = new System.Drawing.Point(34, 11);
            this.printerHeadLbl.Name = "printerHeadLbl";
            this.printerHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.printerHeadLbl.TabIndex = 0;
            this.printerHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // printerBodyPnl
            // 
            this.printerBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printerBodyPnl.Controls.Add(this.printTabCntl);
            this.printerBodyPnl.Location = new System.Drawing.Point(12, 116);
            this.printerBodyPnl.Name = "printerBodyPnl";
            this.printerBodyPnl.Size = new System.Drawing.Size(784, 424);
            this.printerBodyPnl.TabIndex = 1;
            // 
            // printTabCntl
            // 
            this.printTabCntl.Controls.Add(this.printInputTab);
            this.printTabCntl.Controls.Add(this.printViewTab);
            this.printTabCntl.Location = new System.Drawing.Point(3, 3);
            this.printTabCntl.Name = "printTabCntl";
            this.printTabCntl.SelectedIndex = 0;
            this.printTabCntl.Size = new System.Drawing.Size(774, 414);
            this.printTabCntl.TabIndex = 17;
            // 
            // printInputTab
            // 
            this.printInputTab.Controls.Add(this.printExitBttn);
            this.printInputTab.Controls.Add(this.printClearBttn);
            this.printInputTab.Controls.Add(this.printSaveBttn);
            this.printInputTab.Controls.Add(this.printLocationLbl);
            this.printInputTab.Controls.Add(this.printMakeLbl);
            this.printInputTab.Controls.Add(this.printCartNumLbl);
            this.printInputTab.Controls.Add(this.printerLocTxtBx);
            this.printInputTab.Controls.Add(this.printModelLbl);
            this.printInputTab.Controls.Add(this.printerCartNumTxtBx);
            this.printInputTab.Controls.Add(this.printTypeLbl);
            this.printInputTab.Controls.Add(this.printerSerNumTxtBx);
            this.printInputTab.Controls.Add(this.printerTypeTxtBx);
            this.printInputTab.Controls.Add(this.printSerNumLbl);
            this.printInputTab.Controls.Add(this.printerMakeTxtBx);
            this.printInputTab.Controls.Add(this.printerModelTxtBx);
            this.printInputTab.Location = new System.Drawing.Point(4, 22);
            this.printInputTab.Name = "printInputTab";
            this.printInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.printInputTab.Size = new System.Drawing.Size(766, 388);
            this.printInputTab.TabIndex = 0;
            this.printInputTab.Text = "Printer Input";
            this.printInputTab.UseVisualStyleBackColor = true;
            // 
            // printExitBttn
            // 
            this.printExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printExitBttn.Location = new System.Drawing.Point(670, 359);
            this.printExitBttn.Name = "printExitBttn";
            this.printExitBttn.Size = new System.Drawing.Size(75, 23);
            this.printExitBttn.TabIndex = 8;
            this.printExitBttn.Text = "Exit";
            this.printExitBttn.UseVisualStyleBackColor = true;
            this.printExitBttn.Click += new System.EventHandler(this.printExitBttn_Click);
            // 
            // printClearBttn
            // 
            this.printClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printClearBttn.Location = new System.Drawing.Point(561, 359);
            this.printClearBttn.Name = "printClearBttn";
            this.printClearBttn.Size = new System.Drawing.Size(75, 23);
            this.printClearBttn.TabIndex = 7;
            this.printClearBttn.Text = "Clear";
            this.printClearBttn.UseVisualStyleBackColor = true;
            this.printClearBttn.Click += new System.EventHandler(this.printClearBttn_Click);
            // 
            // printSaveBttn
            // 
            this.printSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSaveBttn.Location = new System.Drawing.Point(453, 359);
            this.printSaveBttn.Name = "printSaveBttn";
            this.printSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.printSaveBttn.TabIndex = 6;
            this.printSaveBttn.Text = "Save";
            this.printSaveBttn.UseVisualStyleBackColor = true;
            this.printSaveBttn.Click += new System.EventHandler(this.printSaveBttn_Click);
            // 
            // printLocationLbl
            // 
            this.printLocationLbl.AutoSize = true;
            this.printLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLocationLbl.Location = new System.Drawing.Point(266, 308);
            this.printLocationLbl.Name = "printLocationLbl";
            this.printLocationLbl.Size = new System.Drawing.Size(122, 19);
            this.printLocationLbl.TabIndex = 14;
            this.printLocationLbl.Text = "Printer Location:";
            // 
            // printMakeLbl
            // 
            this.printMakeLbl.AutoSize = true;
            this.printMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printMakeLbl.Location = new System.Drawing.Point(283, 40);
            this.printMakeLbl.Name = "printMakeLbl";
            this.printMakeLbl.Size = new System.Drawing.Size(105, 19);
            this.printMakeLbl.TabIndex = 9;
            this.printMakeLbl.Text = "Printer Make:";
            // 
            // printCartNumLbl
            // 
            this.printCartNumLbl.AutoSize = true;
            this.printCartNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCartNumLbl.Location = new System.Drawing.Point(202, 257);
            this.printCartNumLbl.Name = "printCartNumLbl";
            this.printCartNumLbl.Size = new System.Drawing.Size(186, 19);
            this.printCartNumLbl.TabIndex = 13;
            this.printCartNumLbl.Text = "Printer Cartridge Number:";
            // 
            // printerLocTxtBx
            // 
            this.printerLocTxtBx.Location = new System.Drawing.Point(394, 309);
            this.printerLocTxtBx.Name = "printerLocTxtBx";
            this.printerLocTxtBx.Size = new System.Drawing.Size(351, 20);
            this.printerLocTxtBx.TabIndex = 5;
            // 
            // printModelLbl
            // 
            this.printModelLbl.AutoSize = true;
            this.printModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printModelLbl.Location = new System.Drawing.Point(280, 94);
            this.printModelLbl.Name = "printModelLbl";
            this.printModelLbl.Size = new System.Drawing.Size(108, 19);
            this.printModelLbl.TabIndex = 10;
            this.printModelLbl.Text = "Printer Model:";
            // 
            // printerCartNumTxtBx
            // 
            this.printerCartNumTxtBx.Location = new System.Drawing.Point(394, 258);
            this.printerCartNumTxtBx.Name = "printerCartNumTxtBx";
            this.printerCartNumTxtBx.Size = new System.Drawing.Size(172, 20);
            this.printerCartNumTxtBx.TabIndex = 4;
            // 
            // printTypeLbl
            // 
            this.printTypeLbl.AutoSize = true;
            this.printTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTypeLbl.Location = new System.Drawing.Point(291, 204);
            this.printTypeLbl.Name = "printTypeLbl";
            this.printTypeLbl.Size = new System.Drawing.Size(97, 19);
            this.printTypeLbl.TabIndex = 12;
            this.printTypeLbl.Text = "Printer Type:";
            // 
            // printerSerNumTxtBx
            // 
            this.printerSerNumTxtBx.Location = new System.Drawing.Point(394, 149);
            this.printerSerNumTxtBx.Name = "printerSerNumTxtBx";
            this.printerSerNumTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerSerNumTxtBx.TabIndex = 2;
            // 
            // printerTypeTxtBx
            // 
            this.printerTypeTxtBx.Location = new System.Drawing.Point(394, 205);
            this.printerTypeTxtBx.Name = "printerTypeTxtBx";
            this.printerTypeTxtBx.Size = new System.Drawing.Size(172, 20);
            this.printerTypeTxtBx.TabIndex = 3;
            // 
            // printSerNumLbl
            // 
            this.printSerNumLbl.AutoSize = true;
            this.printSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSerNumLbl.Location = new System.Drawing.Point(227, 148);
            this.printSerNumLbl.Name = "printSerNumLbl";
            this.printSerNumLbl.Size = new System.Drawing.Size(161, 19);
            this.printSerNumLbl.TabIndex = 11;
            this.printSerNumLbl.Text = "Printer Serial Number:";
            // 
            // printerMakeTxtBx
            // 
            this.printerMakeTxtBx.Location = new System.Drawing.Point(394, 41);
            this.printerMakeTxtBx.Name = "printerMakeTxtBx";
            this.printerMakeTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerMakeTxtBx.TabIndex = 0;
            // 
            // printerModelTxtBx
            // 
            this.printerModelTxtBx.Location = new System.Drawing.Point(394, 95);
            this.printerModelTxtBx.Name = "printerModelTxtBx";
            this.printerModelTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerModelTxtBx.TabIndex = 1;
            // 
            // printViewTab
            // 
            this.printViewTab.Controls.Add(this.printGridView);
            this.printViewTab.Controls.Add(this.printRefreshBttn);
            this.printViewTab.Location = new System.Drawing.Point(4, 22);
            this.printViewTab.Name = "printViewTab";
            this.printViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.printViewTab.Size = new System.Drawing.Size(766, 388);
            this.printViewTab.TabIndex = 1;
            this.printViewTab.Text = "Printer View";
            this.printViewTab.UseVisualStyleBackColor = true;
            // 
            // printGridView
            // 
            this.printGridView.AllowUserToAddRows = false;
            this.printGridView.AllowUserToDeleteRows = false;
            this.printGridView.AllowUserToOrderColumns = true;
            this.printGridView.AutoGenerateColumns = false;
            this.printGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printerInvIDNumDataGridViewTextBoxColumn,
            this.printerMakeDataGridViewTextBoxColumn,
            this.printerModelDataGridViewTextBoxColumn,
            this.printerSerNumDataGridViewTextBoxColumn,
            this.printerTypeDataGridViewTextBoxColumn,
            this.printerCartNumDataGridViewTextBoxColumn,
            this.printerLocationDataGridViewTextBoxColumn});
            this.printGridView.DataSource = this.printersBindingSource;
            this.printGridView.Location = new System.Drawing.Point(6, 6);
            this.printGridView.Name = "printGridView";
            this.printGridView.Size = new System.Drawing.Size(754, 347);
            this.printGridView.TabIndex = 1;
            // 
            // printerInvIDNumDataGridViewTextBoxColumn
            // 
            this.printerInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "printerInvIDNum";
            this.printerInvIDNumDataGridViewTextBoxColumn.HeaderText = "Printer Inventory ID Number";
            this.printerInvIDNumDataGridViewTextBoxColumn.Name = "printerInvIDNumDataGridViewTextBoxColumn";
            this.printerInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printerMakeDataGridViewTextBoxColumn
            // 
            this.printerMakeDataGridViewTextBoxColumn.DataPropertyName = "printerMake";
            this.printerMakeDataGridViewTextBoxColumn.HeaderText = "Printer Make";
            this.printerMakeDataGridViewTextBoxColumn.Name = "printerMakeDataGridViewTextBoxColumn";
            // 
            // printerModelDataGridViewTextBoxColumn
            // 
            this.printerModelDataGridViewTextBoxColumn.DataPropertyName = "printerModel";
            this.printerModelDataGridViewTextBoxColumn.HeaderText = "Printer Model";
            this.printerModelDataGridViewTextBoxColumn.Name = "printerModelDataGridViewTextBoxColumn";
            // 
            // printerSerNumDataGridViewTextBoxColumn
            // 
            this.printerSerNumDataGridViewTextBoxColumn.DataPropertyName = "printerSerNum";
            this.printerSerNumDataGridViewTextBoxColumn.HeaderText = "Printer Serial Number";
            this.printerSerNumDataGridViewTextBoxColumn.Name = "printerSerNumDataGridViewTextBoxColumn";
            // 
            // printerTypeDataGridViewTextBoxColumn
            // 
            this.printerTypeDataGridViewTextBoxColumn.DataPropertyName = "printerType";
            this.printerTypeDataGridViewTextBoxColumn.HeaderText = "Printer Type";
            this.printerTypeDataGridViewTextBoxColumn.Name = "printerTypeDataGridViewTextBoxColumn";
            // 
            // printerCartNumDataGridViewTextBoxColumn
            // 
            this.printerCartNumDataGridViewTextBoxColumn.DataPropertyName = "printerCartNum";
            this.printerCartNumDataGridViewTextBoxColumn.HeaderText = "Printer Cartridge Number";
            this.printerCartNumDataGridViewTextBoxColumn.Name = "printerCartNumDataGridViewTextBoxColumn";
            // 
            // printerLocationDataGridViewTextBoxColumn
            // 
            this.printerLocationDataGridViewTextBoxColumn.DataPropertyName = "printerLocation";
            this.printerLocationDataGridViewTextBoxColumn.HeaderText = "Printer Location";
            this.printerLocationDataGridViewTextBoxColumn.Name = "printerLocationDataGridViewTextBoxColumn";
            // 
            // printersBindingSource
            // 
            this.printersBindingSource.DataMember = "Printers";
            this.printersBindingSource.DataSource = this.printerDBDataSet;
            // 
            // printerDBDataSet
            // 
            this.printerDBDataSet.DataSetName = "PrinterDBDataSet";
            this.printerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printRefreshBttn
            // 
            this.printRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printRefreshBttn.Location = new System.Drawing.Point(688, 359);
            this.printRefreshBttn.Name = "printRefreshBttn";
            this.printRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.printRefreshBttn.TabIndex = 0;
            this.printRefreshBttn.Text = "Refresh";
            this.printRefreshBttn.UseVisualStyleBackColor = true;
            this.printRefreshBttn.Click += new System.EventHandler(this.printRefreshBttn_Click);
            // 
            // printersTableAdapter
            // 
            this.printersTableAdapter.ClearBeforeFill = true;
            // 
            // PrinterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 552);
            this.Controls.Add(this.printerBodyPnl);
            this.Controls.Add(this.printHeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrinterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrinterFrm";
            this.Load += new System.EventHandler(this.PrinterFrm_Load);
            this.printHeadPnl.ResumeLayout(false);
            this.printHeadPnl.PerformLayout();
            this.printerBodyPnl.ResumeLayout(false);
            this.printTabCntl.ResumeLayout(false);
            this.printInputTab.ResumeLayout(false);
            this.printInputTab.PerformLayout();
            this.printViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel printHeadPnl;
        private System.Windows.Forms.Label printerHeadTitleLbl;
        private System.Windows.Forms.Label printerHeadLbl;
        private System.Windows.Forms.Panel printerBodyPnl;
        private System.Windows.Forms.Label printLocationLbl;
        private System.Windows.Forms.Label printCartNumLbl;
        private System.Windows.Forms.Label printTypeLbl;
        private System.Windows.Forms.Label printSerNumLbl;
        private System.Windows.Forms.Label printModelLbl;
        private System.Windows.Forms.Label printMakeLbl;
        private System.Windows.Forms.Button printSaveBttn;
        private System.Windows.Forms.Button printClearBttn;
        private System.Windows.Forms.Button printExitBttn;
        private System.Windows.Forms.TextBox printerLocTxtBx;
        private System.Windows.Forms.TextBox printerCartNumTxtBx;
        private System.Windows.Forms.TextBox printerTypeTxtBx;
        private System.Windows.Forms.TextBox printerSerNumTxtBx;
        private System.Windows.Forms.TextBox printerModelTxtBx;
        private System.Windows.Forms.TextBox printerMakeTxtBx;
        private System.Windows.Forms.TabControl printTabCntl;
        private System.Windows.Forms.TabPage printInputTab;
        private System.Windows.Forms.TabPage printViewTab;
        private System.Windows.Forms.DataGridView printGridView;
        private System.Windows.Forms.Button printRefreshBttn;
        private PrinterDBDataSet printerDBDataSet;
        private System.Windows.Forms.BindingSource printersBindingSource;
        private PrinterDBDataSetTableAdapters.PrintersTableAdapter printersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerCartNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerLocationDataGridViewTextBoxColumn;
    }
}