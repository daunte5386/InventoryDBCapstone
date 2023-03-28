namespace InventoryDBApp
{
    partial class ComputerFrm
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
            this.compHeadPnl = new System.Windows.Forms.Panel();
            this.compHeadTitleLbl = new System.Windows.Forms.Label();
            this.compHeadLbl = new System.Windows.Forms.Label();
            this.computerBodyPnl = new System.Windows.Forms.Panel();
            this.compTabCntl = new System.Windows.Forms.TabControl();
            this.compInpTab = new System.Windows.Forms.TabPage();
            this.compSaveBttn = new System.Windows.Forms.Button();
            this.compClearBttn = new System.Windows.Forms.Button();
            this.compExitBttn = new System.Windows.Forms.Button();
            this.compLocationTxtBx = new System.Windows.Forms.TextBox();
            this.compHDDSizeTxtBx = new System.Windows.Forms.TextBox();
            this.compOSBitTypeTxtBx = new System.Windows.Forms.TextBox();
            this.compOSTxtBx = new System.Windows.Forms.TextBox();
            this.compRAMTxtBx = new System.Windows.Forms.TextBox();
            this.compProcSpeedTxtBx = new System.Windows.Forms.TextBox();
            this.compProcTxtBx = new System.Windows.Forms.TextBox();
            this.compSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.compModelTxtBx = new System.Windows.Forms.TextBox();
            this.compMakeTxtBx = new System.Windows.Forms.TextBox();
            this.compLocationLbl = new System.Windows.Forms.Label();
            this.compHDDLbl = new System.Windows.Forms.Label();
            this.compOSBitTypeLbl = new System.Windows.Forms.Label();
            this.compOSLbl = new System.Windows.Forms.Label();
            this.compRAMLbl = new System.Windows.Forms.Label();
            this.compProcSpeedLbl = new System.Windows.Forms.Label();
            this.compProcLbl = new System.Windows.Forms.Label();
            this.compSerNumLbl = new System.Windows.Forms.Label();
            this.compModelLbl = new System.Windows.Forms.Label();
            this.compMakeLbl = new System.Windows.Forms.Label();
            this.computerTabView = new System.Windows.Forms.TabPage();
            this.compRefreshBttn = new System.Windows.Forms.Button();
            this.compDataGrid = new System.Windows.Forms.DataGridView();
            this.computerInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerProcSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerOSBitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerHDDSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSet = new InventoryDBApp.ComputerDBDataSet();
            this.inventoryDBDataSet = new InventoryDBApp.InventoryDBDataSet();
            this.inventoryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computersTableAdapter = new InventoryDBApp.ComputerDBDataSetTableAdapters.ComputersTableAdapter();
            this.compHeadPnl.SuspendLayout();
            this.computerBodyPnl.SuspendLayout();
            this.compTabCntl.SuspendLayout();
            this.compInpTab.SuspendLayout();
            this.computerTabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // compHeadPnl
            // 
            this.compHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compHeadPnl.Controls.Add(this.compHeadTitleLbl);
            this.compHeadPnl.Controls.Add(this.compHeadLbl);
            this.compHeadPnl.Location = new System.Drawing.Point(12, 12);
            this.compHeadPnl.Name = "compHeadPnl";
            this.compHeadPnl.Size = new System.Drawing.Size(784, 100);
            this.compHeadPnl.TabIndex = 0;
            // 
            // compHeadTitleLbl
            // 
            this.compHeadTitleLbl.AutoSize = true;
            this.compHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compHeadTitleLbl.Location = new System.Drawing.Point(289, 57);
            this.compHeadTitleLbl.Name = "compHeadTitleLbl";
            this.compHeadTitleLbl.Size = new System.Drawing.Size(172, 26);
            this.compHeadTitleLbl.TabIndex = 1;
            this.compHeadTitleLbl.Text = "Computer Page";
            // 
            // compHeadLbl
            // 
            this.compHeadLbl.AutoSize = true;
            this.compHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compHeadLbl.Location = new System.Drawing.Point(35, 12);
            this.compHeadLbl.Name = "compHeadLbl";
            this.compHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.compHeadLbl.TabIndex = 0;
            this.compHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // computerBodyPnl
            // 
            this.computerBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerBodyPnl.Controls.Add(this.compTabCntl);
            this.computerBodyPnl.Location = new System.Drawing.Point(12, 118);
            this.computerBodyPnl.Name = "computerBodyPnl";
            this.computerBodyPnl.Size = new System.Drawing.Size(784, 499);
            this.computerBodyPnl.TabIndex = 1;
            // 
            // compTabCntl
            // 
            this.compTabCntl.Controls.Add(this.compInpTab);
            this.compTabCntl.Controls.Add(this.computerTabView);
            this.compTabCntl.Location = new System.Drawing.Point(3, 3);
            this.compTabCntl.Name = "compTabCntl";
            this.compTabCntl.SelectedIndex = 0;
            this.compTabCntl.Size = new System.Drawing.Size(774, 489);
            this.compTabCntl.TabIndex = 0;
            // 
            // compInpTab
            // 
            this.compInpTab.Controls.Add(this.compSaveBttn);
            this.compInpTab.Controls.Add(this.compClearBttn);
            this.compInpTab.Controls.Add(this.compExitBttn);
            this.compInpTab.Controls.Add(this.compLocationTxtBx);
            this.compInpTab.Controls.Add(this.compHDDSizeTxtBx);
            this.compInpTab.Controls.Add(this.compOSBitTypeTxtBx);
            this.compInpTab.Controls.Add(this.compOSTxtBx);
            this.compInpTab.Controls.Add(this.compRAMTxtBx);
            this.compInpTab.Controls.Add(this.compProcSpeedTxtBx);
            this.compInpTab.Controls.Add(this.compProcTxtBx);
            this.compInpTab.Controls.Add(this.compSerNumTxtBx);
            this.compInpTab.Controls.Add(this.compModelTxtBx);
            this.compInpTab.Controls.Add(this.compMakeTxtBx);
            this.compInpTab.Controls.Add(this.compLocationLbl);
            this.compInpTab.Controls.Add(this.compHDDLbl);
            this.compInpTab.Controls.Add(this.compOSBitTypeLbl);
            this.compInpTab.Controls.Add(this.compOSLbl);
            this.compInpTab.Controls.Add(this.compRAMLbl);
            this.compInpTab.Controls.Add(this.compProcSpeedLbl);
            this.compInpTab.Controls.Add(this.compProcLbl);
            this.compInpTab.Controls.Add(this.compSerNumLbl);
            this.compInpTab.Controls.Add(this.compModelLbl);
            this.compInpTab.Controls.Add(this.compMakeLbl);
            this.compInpTab.Location = new System.Drawing.Point(4, 22);
            this.compInpTab.Name = "compInpTab";
            this.compInpTab.Padding = new System.Windows.Forms.Padding(3);
            this.compInpTab.Size = new System.Drawing.Size(766, 463);
            this.compInpTab.TabIndex = 0;
            this.compInpTab.Text = "Computer Input";
            this.compInpTab.UseVisualStyleBackColor = true;
            // 
            // compSaveBttn
            // 
            this.compSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compSaveBttn.Location = new System.Drawing.Point(475, 434);
            this.compSaveBttn.Name = "compSaveBttn";
            this.compSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.compSaveBttn.TabIndex = 10;
            this.compSaveBttn.Text = "Save";
            this.compSaveBttn.UseVisualStyleBackColor = true;
            this.compSaveBttn.Click += new System.EventHandler(this.compSaveBttn_Click);
            // 
            // compClearBttn
            // 
            this.compClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compClearBttn.Location = new System.Drawing.Point(580, 434);
            this.compClearBttn.Name = "compClearBttn";
            this.compClearBttn.Size = new System.Drawing.Size(75, 23);
            this.compClearBttn.TabIndex = 11;
            this.compClearBttn.Text = "Clear";
            this.compClearBttn.UseVisualStyleBackColor = true;
            this.compClearBttn.Click += new System.EventHandler(this.compClearBttn_Click);
            // 
            // compExitBttn
            // 
            this.compExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compExitBttn.Location = new System.Drawing.Point(685, 434);
            this.compExitBttn.Name = "compExitBttn";
            this.compExitBttn.Size = new System.Drawing.Size(75, 23);
            this.compExitBttn.TabIndex = 12;
            this.compExitBttn.Text = "Exit";
            this.compExitBttn.UseVisualStyleBackColor = true;
            this.compExitBttn.Click += new System.EventHandler(this.compExitBttn_Click);
            // 
            // compLocationTxtBx
            // 
            this.compLocationTxtBx.Location = new System.Drawing.Point(321, 395);
            this.compLocationTxtBx.Name = "compLocationTxtBx";
            this.compLocationTxtBx.Size = new System.Drawing.Size(420, 20);
            this.compLocationTxtBx.TabIndex = 9;
            // 
            // compHDDSizeTxtBx
            // 
            this.compHDDSizeTxtBx.Location = new System.Drawing.Point(321, 356);
            this.compHDDSizeTxtBx.Name = "compHDDSizeTxtBx";
            this.compHDDSizeTxtBx.Size = new System.Drawing.Size(100, 20);
            this.compHDDSizeTxtBx.TabIndex = 8;
            // 
            // compOSBitTypeTxtBx
            // 
            this.compOSBitTypeTxtBx.Location = new System.Drawing.Point(321, 314);
            this.compOSBitTypeTxtBx.Name = "compOSBitTypeTxtBx";
            this.compOSBitTypeTxtBx.Size = new System.Drawing.Size(100, 20);
            this.compOSBitTypeTxtBx.TabIndex = 7;
            // 
            // compOSTxtBx
            // 
            this.compOSTxtBx.Location = new System.Drawing.Point(321, 275);
            this.compOSTxtBx.Name = "compOSTxtBx";
            this.compOSTxtBx.Size = new System.Drawing.Size(129, 20);
            this.compOSTxtBx.TabIndex = 6;
            // 
            // compRAMTxtBx
            // 
            this.compRAMTxtBx.Location = new System.Drawing.Point(321, 234);
            this.compRAMTxtBx.Name = "compRAMTxtBx";
            this.compRAMTxtBx.Size = new System.Drawing.Size(100, 20);
            this.compRAMTxtBx.TabIndex = 5;
            // 
            // compProcSpeedTxtBx
            // 
            this.compProcSpeedTxtBx.Location = new System.Drawing.Point(321, 194);
            this.compProcSpeedTxtBx.Name = "compProcSpeedTxtBx";
            this.compProcSpeedTxtBx.Size = new System.Drawing.Size(100, 20);
            this.compProcSpeedTxtBx.TabIndex = 4;
            // 
            // compProcTxtBx
            // 
            this.compProcTxtBx.Location = new System.Drawing.Point(321, 154);
            this.compProcTxtBx.Name = "compProcTxtBx";
            this.compProcTxtBx.Size = new System.Drawing.Size(129, 20);
            this.compProcTxtBx.TabIndex = 3;
            // 
            // compSerNumTxtBx
            // 
            this.compSerNumTxtBx.Location = new System.Drawing.Point(321, 113);
            this.compSerNumTxtBx.Name = "compSerNumTxtBx";
            this.compSerNumTxtBx.Size = new System.Drawing.Size(171, 20);
            this.compSerNumTxtBx.TabIndex = 2;
            // 
            // compModelTxtBx
            // 
            this.compModelTxtBx.Location = new System.Drawing.Point(321, 73);
            this.compModelTxtBx.Name = "compModelTxtBx";
            this.compModelTxtBx.Size = new System.Drawing.Size(171, 20);
            this.compModelTxtBx.TabIndex = 1;
            // 
            // compMakeTxtBx
            // 
            this.compMakeTxtBx.Location = new System.Drawing.Point(321, 30);
            this.compMakeTxtBx.Name = "compMakeTxtBx";
            this.compMakeTxtBx.Size = new System.Drawing.Size(171, 20);
            this.compMakeTxtBx.TabIndex = 0;
            // 
            // compLocationLbl
            // 
            this.compLocationLbl.AutoSize = true;
            this.compLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compLocationLbl.Location = new System.Drawing.Point(173, 394);
            this.compLocationLbl.Name = "compLocationLbl";
            this.compLocationLbl.Size = new System.Drawing.Size(142, 19);
            this.compLocationLbl.TabIndex = 10;
            this.compLocationLbl.Text = "Computer Location:";
            // 
            // compHDDLbl
            // 
            this.compHDDLbl.AutoSize = true;
            this.compHDDLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compHDDLbl.Location = new System.Drawing.Point(124, 355);
            this.compHDDLbl.Name = "compHDDLbl";
            this.compHDDLbl.Size = new System.Drawing.Size(191, 19);
            this.compHDDLbl.TabIndex = 9;
            this.compHDDLbl.Text = "Computer Hard Drive Size:";
            // 
            // compOSBitTypeLbl
            // 
            this.compOSBitTypeLbl.AutoSize = true;
            this.compOSBitTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compOSBitTypeLbl.Location = new System.Drawing.Point(50, 313);
            this.compOSBitTypeLbl.Name = "compOSBitTypeLbl";
            this.compOSBitTypeLbl.Size = new System.Drawing.Size(265, 19);
            this.compOSBitTypeLbl.TabIndex = 8;
            this.compOSBitTypeLbl.Text = "Computer Operating System Bit Type:";
            // 
            // compOSLbl
            // 
            this.compOSLbl.AutoSize = true;
            this.compOSLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compOSLbl.Location = new System.Drawing.Point(111, 274);
            this.compOSLbl.Name = "compOSLbl";
            this.compOSLbl.Size = new System.Drawing.Size(204, 19);
            this.compOSLbl.TabIndex = 7;
            this.compOSLbl.Text = "Computer Operating System:";
            // 
            // compRAMLbl
            // 
            this.compRAMLbl.AutoSize = true;
            this.compRAMLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRAMLbl.Location = new System.Drawing.Point(192, 233);
            this.compRAMLbl.Name = "compRAMLbl";
            this.compRAMLbl.Size = new System.Drawing.Size(123, 19);
            this.compRAMLbl.TabIndex = 6;
            this.compRAMLbl.Text = "Computer RAM:";
            // 
            // compProcSpeedLbl
            // 
            this.compProcSpeedLbl.AutoSize = true;
            this.compProcSpeedLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compProcSpeedLbl.Location = new System.Drawing.Point(120, 193);
            this.compProcSpeedLbl.Name = "compProcSpeedLbl";
            this.compProcSpeedLbl.Size = new System.Drawing.Size(195, 19);
            this.compProcSpeedLbl.TabIndex = 5;
            this.compProcSpeedLbl.Text = "Computer Processor Speed:";
            // 
            // compProcLbl
            // 
            this.compProcLbl.AutoSize = true;
            this.compProcLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compProcLbl.Location = new System.Drawing.Point(165, 153);
            this.compProcLbl.Name = "compProcLbl";
            this.compProcLbl.Size = new System.Drawing.Size(150, 19);
            this.compProcLbl.TabIndex = 4;
            this.compProcLbl.Text = "Computer Processor:";
            // 
            // compSerNumLbl
            // 
            this.compSerNumLbl.AutoSize = true;
            this.compSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compSerNumLbl.Location = new System.Drawing.Point(134, 112);
            this.compSerNumLbl.Name = "compSerNumLbl";
            this.compSerNumLbl.Size = new System.Drawing.Size(181, 19);
            this.compSerNumLbl.TabIndex = 3;
            this.compSerNumLbl.Text = "Computer Serial Number:";
            // 
            // compModelLbl
            // 
            this.compModelLbl.AutoSize = true;
            this.compModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compModelLbl.Location = new System.Drawing.Point(187, 72);
            this.compModelLbl.Name = "compModelLbl";
            this.compModelLbl.Size = new System.Drawing.Size(128, 19);
            this.compModelLbl.TabIndex = 2;
            this.compModelLbl.Text = "Computer Model:";
            // 
            // compMakeLbl
            // 
            this.compMakeLbl.AutoSize = true;
            this.compMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compMakeLbl.Location = new System.Drawing.Point(190, 29);
            this.compMakeLbl.Name = "compMakeLbl";
            this.compMakeLbl.Size = new System.Drawing.Size(125, 19);
            this.compMakeLbl.TabIndex = 1;
            this.compMakeLbl.Text = "Computer Make:";
            // 
            // computerTabView
            // 
            this.computerTabView.Controls.Add(this.compRefreshBttn);
            this.computerTabView.Controls.Add(this.compDataGrid);
            this.computerTabView.Location = new System.Drawing.Point(4, 22);
            this.computerTabView.Name = "computerTabView";
            this.computerTabView.Padding = new System.Windows.Forms.Padding(3);
            this.computerTabView.Size = new System.Drawing.Size(766, 463);
            this.computerTabView.TabIndex = 1;
            this.computerTabView.Text = "Computer View";
            this.computerTabView.UseVisualStyleBackColor = true;
            // 
            // compRefreshBttn
            // 
            this.compRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRefreshBttn.Location = new System.Drawing.Point(685, 433);
            this.compRefreshBttn.Name = "compRefreshBttn";
            this.compRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.compRefreshBttn.TabIndex = 1;
            this.compRefreshBttn.Text = "Refresh";
            this.compRefreshBttn.UseVisualStyleBackColor = true;
            this.compRefreshBttn.Click += new System.EventHandler(this.compRefreshBttn_Click);
            // 
            // compDataGrid
            // 
            this.compDataGrid.AllowUserToAddRows = false;
            this.compDataGrid.AllowUserToDeleteRows = false;
            this.compDataGrid.AllowUserToOrderColumns = true;
            this.compDataGrid.AutoGenerateColumns = false;
            this.compDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computerInvIDNumDataGridViewTextBoxColumn,
            this.computerMakeDataGridViewTextBoxColumn,
            this.computerModelDataGridViewTextBoxColumn,
            this.computerSerNumDataGridViewTextBoxColumn,
            this.computerProcDataGridViewTextBoxColumn,
            this.computerProcSpeedDataGridViewTextBoxColumn,
            this.computerRAMDataGridViewTextBoxColumn,
            this.computerOSDataGridViewTextBoxColumn,
            this.computerOSBitTypeDataGridViewTextBoxColumn,
            this.computerHDDSizeDataGridViewTextBoxColumn,
            this.computerLocationDataGridViewTextBoxColumn});
            this.compDataGrid.DataSource = this.computersBindingSource;
            this.compDataGrid.Location = new System.Drawing.Point(3, 3);
            this.compDataGrid.Name = "compDataGrid";
            this.compDataGrid.Size = new System.Drawing.Size(763, 424);
            this.compDataGrid.TabIndex = 0;
            // 
            // computerInvIDNumDataGridViewTextBoxColumn
            // 
            this.computerInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "computerInvIDNum";
            this.computerInvIDNumDataGridViewTextBoxColumn.HeaderText = "Computer Inventory ID Number";
            this.computerInvIDNumDataGridViewTextBoxColumn.Name = "computerInvIDNumDataGridViewTextBoxColumn";
            this.computerInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // computerMakeDataGridViewTextBoxColumn
            // 
            this.computerMakeDataGridViewTextBoxColumn.DataPropertyName = "computerMake";
            this.computerMakeDataGridViewTextBoxColumn.HeaderText = "Computer Make";
            this.computerMakeDataGridViewTextBoxColumn.Name = "computerMakeDataGridViewTextBoxColumn";
            // 
            // computerModelDataGridViewTextBoxColumn
            // 
            this.computerModelDataGridViewTextBoxColumn.DataPropertyName = "computerModel";
            this.computerModelDataGridViewTextBoxColumn.HeaderText = "Computer Model";
            this.computerModelDataGridViewTextBoxColumn.Name = "computerModelDataGridViewTextBoxColumn";
            // 
            // computerSerNumDataGridViewTextBoxColumn
            // 
            this.computerSerNumDataGridViewTextBoxColumn.DataPropertyName = "computerSerNum";
            this.computerSerNumDataGridViewTextBoxColumn.HeaderText = "Computer Serial Number";
            this.computerSerNumDataGridViewTextBoxColumn.Name = "computerSerNumDataGridViewTextBoxColumn";
            // 
            // computerProcDataGridViewTextBoxColumn
            // 
            this.computerProcDataGridViewTextBoxColumn.DataPropertyName = "computerProc";
            this.computerProcDataGridViewTextBoxColumn.HeaderText = "Computer Processor";
            this.computerProcDataGridViewTextBoxColumn.Name = "computerProcDataGridViewTextBoxColumn";
            // 
            // computerProcSpeedDataGridViewTextBoxColumn
            // 
            this.computerProcSpeedDataGridViewTextBoxColumn.DataPropertyName = "computerProcSpeed";
            this.computerProcSpeedDataGridViewTextBoxColumn.HeaderText = "Computer Processor Speed";
            this.computerProcSpeedDataGridViewTextBoxColumn.Name = "computerProcSpeedDataGridViewTextBoxColumn";
            // 
            // computerRAMDataGridViewTextBoxColumn
            // 
            this.computerRAMDataGridViewTextBoxColumn.DataPropertyName = "computerRAM";
            this.computerRAMDataGridViewTextBoxColumn.HeaderText = "Computer RAM";
            this.computerRAMDataGridViewTextBoxColumn.Name = "computerRAMDataGridViewTextBoxColumn";
            // 
            // computerOSDataGridViewTextBoxColumn
            // 
            this.computerOSDataGridViewTextBoxColumn.DataPropertyName = "computerOS";
            this.computerOSDataGridViewTextBoxColumn.HeaderText = "Computer Operating System";
            this.computerOSDataGridViewTextBoxColumn.Name = "computerOSDataGridViewTextBoxColumn";
            // 
            // computerOSBitTypeDataGridViewTextBoxColumn
            // 
            this.computerOSBitTypeDataGridViewTextBoxColumn.DataPropertyName = "computerOSBitType";
            this.computerOSBitTypeDataGridViewTextBoxColumn.HeaderText = "Computer Operating System Bit Type";
            this.computerOSBitTypeDataGridViewTextBoxColumn.Name = "computerOSBitTypeDataGridViewTextBoxColumn";
            // 
            // computerHDDSizeDataGridViewTextBoxColumn
            // 
            this.computerHDDSizeDataGridViewTextBoxColumn.DataPropertyName = "computerHDDSize";
            this.computerHDDSizeDataGridViewTextBoxColumn.HeaderText = "Computer HDD Size";
            this.computerHDDSizeDataGridViewTextBoxColumn.Name = "computerHDDSizeDataGridViewTextBoxColumn";
            // 
            // computerLocationDataGridViewTextBoxColumn
            // 
            this.computerLocationDataGridViewTextBoxColumn.DataPropertyName = "computerLocation";
            this.computerLocationDataGridViewTextBoxColumn.HeaderText = "Computer Location";
            this.computerLocationDataGridViewTextBoxColumn.Name = "computerLocationDataGridViewTextBoxColumn";
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.computerDBDataSet;
            // 
            // computerDBDataSet
            // 
            this.computerDBDataSet.DataSetName = "ComputerDBDataSet";
            this.computerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDBDataSetBindingSource
            // 
            this.inventoryDBDataSetBindingSource.DataSource = this.inventoryDBDataSet;
            this.inventoryDBDataSetBindingSource.Position = 0;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // ComputerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 629);
            this.Controls.Add(this.computerBodyPnl);
            this.Controls.Add(this.compHeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ComputerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Database Screen";
            this.Load += new System.EventHandler(this.ComputerFrm_Load);
            this.compHeadPnl.ResumeLayout(false);
            this.compHeadPnl.PerformLayout();
            this.computerBodyPnl.ResumeLayout(false);
            this.compTabCntl.ResumeLayout(false);
            this.compInpTab.ResumeLayout(false);
            this.compInpTab.PerformLayout();
            this.computerTabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel compHeadPnl;
        private System.Windows.Forms.Label compHeadTitleLbl;
        private System.Windows.Forms.Label compHeadLbl;
        private System.Windows.Forms.Panel computerBodyPnl;
        private System.Windows.Forms.TabControl compTabCntl;
        private System.Windows.Forms.TabPage compInpTab;
        private System.Windows.Forms.Button compSaveBttn;
        private System.Windows.Forms.Button compClearBttn;
        private System.Windows.Forms.Button compExitBttn;
        private System.Windows.Forms.TextBox compLocationTxtBx;
        private System.Windows.Forms.TextBox compHDDSizeTxtBx;
        private System.Windows.Forms.TextBox compOSBitTypeTxtBx;
        private System.Windows.Forms.TextBox compOSTxtBx;
        private System.Windows.Forms.TextBox compRAMTxtBx;
        private System.Windows.Forms.TextBox compProcSpeedTxtBx;
        private System.Windows.Forms.TextBox compProcTxtBx;
        private System.Windows.Forms.TextBox compSerNumTxtBx;
        private System.Windows.Forms.TextBox compModelTxtBx;
        private System.Windows.Forms.TextBox compMakeTxtBx;
        private System.Windows.Forms.Label compLocationLbl;
        private System.Windows.Forms.Label compHDDLbl;
        private System.Windows.Forms.Label compOSBitTypeLbl;
        private System.Windows.Forms.Label compOSLbl;
        private System.Windows.Forms.Label compRAMLbl;
        private System.Windows.Forms.Label compProcSpeedLbl;
        private System.Windows.Forms.Label compProcLbl;
        private System.Windows.Forms.Label compSerNumLbl;
        private System.Windows.Forms.Label compModelLbl;
        private System.Windows.Forms.Label compMakeLbl;
        private System.Windows.Forms.TabPage computerTabView;
        private System.Windows.Forms.DataGridView compDataGrid;
        private System.Windows.Forms.Button compRefreshBttn;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource inventoryDBDataSetBindingSource;
        private ComputerDBDataSet computerDBDataSet;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private ComputerDBDataSetTableAdapters.ComputersTableAdapter computersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerProcSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerOSBitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerHDDSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerLocationDataGridViewTextBoxColumn;
    }
}