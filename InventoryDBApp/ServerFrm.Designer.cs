namespace InventoryDBApp
{
    partial class ServerFrm
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
            this.servHeadPnl = new System.Windows.Forms.Panel();
            this.servHeadTitleLbl = new System.Windows.Forms.Label();
            this.servHeadLbl = new System.Windows.Forms.Label();
            this.servBodyPnl = new System.Windows.Forms.Panel();
            this.servTabCntl = new System.Windows.Forms.TabControl();
            this.servInputTab = new System.Windows.Forms.TabPage();
            this.servExitBttn = new System.Windows.Forms.Button();
            this.servClearBttn = new System.Windows.Forms.Button();
            this.servSaveBttn = new System.Windows.Forms.Button();
            this.servMakeTxtBx = new System.Windows.Forms.TextBox();
            this.servModelTxtBx = new System.Windows.Forms.TextBox();
            this.servSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.servProcTxtBx = new System.Windows.Forms.TextBox();
            this.servProcSpeedTxtBx = new System.Windows.Forms.TextBox();
            this.servRAMTxtBx = new System.Windows.Forms.TextBox();
            this.servOSTxtBx = new System.Windows.Forms.TextBox();
            this.servOSBitTypeTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDRaidTypeTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDCapTxtBx = new System.Windows.Forms.TextBox();
            this.servVirtTxtBx = new System.Windows.Forms.TextBox();
            this.servLocationLbl = new System.Windows.Forms.Label();
            this.servLocationTxtBx = new System.Windows.Forms.TextBox();
            this.servMakeLbl = new System.Windows.Forms.Label();
            this.servVirtualLbl = new System.Windows.Forms.Label();
            this.servModelLbl = new System.Windows.Forms.Label();
            this.servHDDCapLbl = new System.Windows.Forms.Label();
            this.servHDDLbl = new System.Windows.Forms.Label();
            this.serHDDRaidTypeLbl = new System.Windows.Forms.Label();
            this.servOSBitTypeLbl = new System.Windows.Forms.Label();
            this.servSerNumLbl = new System.Windows.Forms.Label();
            this.servProcLbl = new System.Windows.Forms.Label();
            this.servProcSpeedLbl = new System.Windows.Forms.Label();
            this.servRAMLbl = new System.Windows.Forms.Label();
            this.servOSLbl = new System.Windows.Forms.Label();
            this.servViewTab = new System.Windows.Forms.TabPage();
            this.servGridView = new System.Windows.Forms.DataGridView();
            this.serverInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverProcSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverOSBitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverHDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverHDDRaidTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverHDDCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverDBDataSet = new InventoryDBApp.ServerDBDataSet();
            this.serverRefreshBttn = new System.Windows.Forms.Button();
            this.serversTableAdapter = new InventoryDBApp.ServerDBDataSetTableAdapters.ServersTableAdapter();
            this.servHeadPnl.SuspendLayout();
            this.servBodyPnl.SuspendLayout();
            this.servTabCntl.SuspendLayout();
            this.servInputTab.SuspendLayout();
            this.servViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // servHeadPnl
            // 
            this.servHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servHeadPnl.Controls.Add(this.servHeadTitleLbl);
            this.servHeadPnl.Controls.Add(this.servHeadLbl);
            this.servHeadPnl.Location = new System.Drawing.Point(12, 12);
            this.servHeadPnl.Name = "servHeadPnl";
            this.servHeadPnl.Size = new System.Drawing.Size(784, 94);
            this.servHeadPnl.TabIndex = 0;
            // 
            // servHeadTitleLbl
            // 
            this.servHeadTitleLbl.AutoSize = true;
            this.servHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHeadTitleLbl.Location = new System.Drawing.Point(330, 55);
            this.servHeadTitleLbl.Name = "servHeadTitleLbl";
            this.servHeadTitleLbl.Size = new System.Drawing.Size(136, 26);
            this.servHeadTitleLbl.TabIndex = 1;
            this.servHeadTitleLbl.Text = "Server Page";
            // 
            // servHeadLbl
            // 
            this.servHeadLbl.AutoSize = true;
            this.servHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHeadLbl.Location = new System.Drawing.Point(31, 10);
            this.servHeadLbl.Name = "servHeadLbl";
            this.servHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.servHeadLbl.TabIndex = 0;
            this.servHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // servBodyPnl
            // 
            this.servBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servBodyPnl.Controls.Add(this.servTabCntl);
            this.servBodyPnl.Location = new System.Drawing.Point(12, 112);
            this.servBodyPnl.Name = "servBodyPnl";
            this.servBodyPnl.Size = new System.Drawing.Size(784, 614);
            this.servBodyPnl.TabIndex = 1;
            // 
            // servTabCntl
            // 
            this.servTabCntl.Controls.Add(this.servInputTab);
            this.servTabCntl.Controls.Add(this.servViewTab);
            this.servTabCntl.Location = new System.Drawing.Point(3, 3);
            this.servTabCntl.Name = "servTabCntl";
            this.servTabCntl.SelectedIndex = 0;
            this.servTabCntl.Size = new System.Drawing.Size(774, 604);
            this.servTabCntl.TabIndex = 31;
            // 
            // servInputTab
            // 
            this.servInputTab.Controls.Add(this.servExitBttn);
            this.servInputTab.Controls.Add(this.servClearBttn);
            this.servInputTab.Controls.Add(this.servSaveBttn);
            this.servInputTab.Controls.Add(this.servMakeTxtBx);
            this.servInputTab.Controls.Add(this.servModelTxtBx);
            this.servInputTab.Controls.Add(this.servSerNumTxtBx);
            this.servInputTab.Controls.Add(this.servProcTxtBx);
            this.servInputTab.Controls.Add(this.servProcSpeedTxtBx);
            this.servInputTab.Controls.Add(this.servRAMTxtBx);
            this.servInputTab.Controls.Add(this.servOSTxtBx);
            this.servInputTab.Controls.Add(this.servOSBitTypeTxtBx);
            this.servInputTab.Controls.Add(this.servHDDTxtBx);
            this.servInputTab.Controls.Add(this.servHDDRaidTypeTxtBx);
            this.servInputTab.Controls.Add(this.servHDDCapTxtBx);
            this.servInputTab.Controls.Add(this.servVirtTxtBx);
            this.servInputTab.Controls.Add(this.servLocationLbl);
            this.servInputTab.Controls.Add(this.servLocationTxtBx);
            this.servInputTab.Controls.Add(this.servMakeLbl);
            this.servInputTab.Controls.Add(this.servVirtualLbl);
            this.servInputTab.Controls.Add(this.servModelLbl);
            this.servInputTab.Controls.Add(this.servHDDCapLbl);
            this.servInputTab.Controls.Add(this.servHDDLbl);
            this.servInputTab.Controls.Add(this.serHDDRaidTypeLbl);
            this.servInputTab.Controls.Add(this.servOSBitTypeLbl);
            this.servInputTab.Controls.Add(this.servSerNumLbl);
            this.servInputTab.Controls.Add(this.servProcLbl);
            this.servInputTab.Controls.Add(this.servProcSpeedLbl);
            this.servInputTab.Controls.Add(this.servRAMLbl);
            this.servInputTab.Controls.Add(this.servOSLbl);
            this.servInputTab.Location = new System.Drawing.Point(4, 22);
            this.servInputTab.Name = "servInputTab";
            this.servInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.servInputTab.Size = new System.Drawing.Size(766, 578);
            this.servInputTab.TabIndex = 0;
            this.servInputTab.Text = "Server Input";
            this.servInputTab.UseVisualStyleBackColor = true;
            // 
            // servExitBttn
            // 
            this.servExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servExitBttn.Location = new System.Drawing.Point(685, 549);
            this.servExitBttn.Name = "servExitBttn";
            this.servExitBttn.Size = new System.Drawing.Size(75, 23);
            this.servExitBttn.TabIndex = 15;
            this.servExitBttn.Text = "Exit";
            this.servExitBttn.UseVisualStyleBackColor = true;
            this.servExitBttn.Click += new System.EventHandler(this.servExitBttn_Click);
            // 
            // servClearBttn
            // 
            this.servClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servClearBttn.Location = new System.Drawing.Point(581, 549);
            this.servClearBttn.Name = "servClearBttn";
            this.servClearBttn.Size = new System.Drawing.Size(75, 23);
            this.servClearBttn.TabIndex = 14;
            this.servClearBttn.Text = "Clear";
            this.servClearBttn.UseVisualStyleBackColor = true;
            this.servClearBttn.Click += new System.EventHandler(this.servClearBttn_Click);
            // 
            // servSaveBttn
            // 
            this.servSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servSaveBttn.Location = new System.Drawing.Point(476, 549);
            this.servSaveBttn.Name = "servSaveBttn";
            this.servSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.servSaveBttn.TabIndex = 13;
            this.servSaveBttn.Text = "Save";
            this.servSaveBttn.UseVisualStyleBackColor = true;
            this.servSaveBttn.Click += new System.EventHandler(this.servSaveBttn_Click);
            // 
            // servMakeTxtBx
            // 
            this.servMakeTxtBx.Location = new System.Drawing.Point(379, 32);
            this.servMakeTxtBx.Name = "servMakeTxtBx";
            this.servMakeTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servMakeTxtBx.TabIndex = 0;
            // 
            // servModelTxtBx
            // 
            this.servModelTxtBx.Location = new System.Drawing.Point(379, 76);
            this.servModelTxtBx.Name = "servModelTxtBx";
            this.servModelTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servModelTxtBx.TabIndex = 1;
            // 
            // servSerNumTxtBx
            // 
            this.servSerNumTxtBx.Location = new System.Drawing.Point(379, 119);
            this.servSerNumTxtBx.Name = "servSerNumTxtBx";
            this.servSerNumTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servSerNumTxtBx.TabIndex = 2;
            // 
            // servProcTxtBx
            // 
            this.servProcTxtBx.Location = new System.Drawing.Point(379, 161);
            this.servProcTxtBx.Name = "servProcTxtBx";
            this.servProcTxtBx.Size = new System.Drawing.Size(152, 20);
            this.servProcTxtBx.TabIndex = 3;
            // 
            // servProcSpeedTxtBx
            // 
            this.servProcSpeedTxtBx.Location = new System.Drawing.Point(379, 206);
            this.servProcSpeedTxtBx.Name = "servProcSpeedTxtBx";
            this.servProcSpeedTxtBx.Size = new System.Drawing.Size(152, 20);
            this.servProcSpeedTxtBx.TabIndex = 4;
            // 
            // servRAMTxtBx
            // 
            this.servRAMTxtBx.Location = new System.Drawing.Point(379, 243);
            this.servRAMTxtBx.Name = "servRAMTxtBx";
            this.servRAMTxtBx.Size = new System.Drawing.Size(70, 20);
            this.servRAMTxtBx.TabIndex = 5;
            // 
            // servOSTxtBx
            // 
            this.servOSTxtBx.Location = new System.Drawing.Point(379, 283);
            this.servOSTxtBx.Name = "servOSTxtBx";
            this.servOSTxtBx.Size = new System.Drawing.Size(70, 20);
            this.servOSTxtBx.TabIndex = 6;
            // 
            // servOSBitTypeTxtBx
            // 
            this.servOSBitTypeTxtBx.Location = new System.Drawing.Point(379, 320);
            this.servOSBitTypeTxtBx.Name = "servOSBitTypeTxtBx";
            this.servOSBitTypeTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servOSBitTypeTxtBx.TabIndex = 7;
            // 
            // servHDDTxtBx
            // 
            this.servHDDTxtBx.Location = new System.Drawing.Point(379, 361);
            this.servHDDTxtBx.Name = "servHDDTxtBx";
            this.servHDDTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servHDDTxtBx.TabIndex = 8;
            // 
            // servHDDRaidTypeTxtBx
            // 
            this.servHDDRaidTypeTxtBx.Location = new System.Drawing.Point(379, 401);
            this.servHDDRaidTypeTxtBx.Name = "servHDDRaidTypeTxtBx";
            this.servHDDRaidTypeTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servHDDRaidTypeTxtBx.TabIndex = 9;
            // 
            // servHDDCapTxtBx
            // 
            this.servHDDCapTxtBx.Location = new System.Drawing.Point(379, 443);
            this.servHDDCapTxtBx.Name = "servHDDCapTxtBx";
            this.servHDDCapTxtBx.Size = new System.Drawing.Size(100, 20);
            this.servHDDCapTxtBx.TabIndex = 10;
            // 
            // servVirtTxtBx
            // 
            this.servVirtTxtBx.Location = new System.Drawing.Point(379, 482);
            this.servVirtTxtBx.Name = "servVirtTxtBx";
            this.servVirtTxtBx.Size = new System.Drawing.Size(100, 20);
            this.servVirtTxtBx.TabIndex = 11;
            // 
            // servLocationLbl
            // 
            this.servLocationLbl.AutoSize = true;
            this.servLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servLocationLbl.Location = new System.Drawing.Point(252, 522);
            this.servLocationLbl.Name = "servLocationLbl";
            this.servLocationLbl.Size = new System.Drawing.Size(121, 19);
            this.servLocationLbl.TabIndex = 28;
            this.servLocationLbl.Text = "Server Location:";
            // 
            // servLocationTxtBx
            // 
            this.servLocationTxtBx.Location = new System.Drawing.Point(379, 523);
            this.servLocationTxtBx.Name = "servLocationTxtBx";
            this.servLocationTxtBx.Size = new System.Drawing.Size(358, 20);
            this.servLocationTxtBx.TabIndex = 12;
            // 
            // servMakeLbl
            // 
            this.servMakeLbl.AutoSize = true;
            this.servMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servMakeLbl.Location = new System.Drawing.Point(269, 31);
            this.servMakeLbl.Name = "servMakeLbl";
            this.servMakeLbl.Size = new System.Drawing.Size(104, 19);
            this.servMakeLbl.TabIndex = 16;
            this.servMakeLbl.Text = "Server Make:";
            // 
            // servVirtualLbl
            // 
            this.servVirtualLbl.AutoSize = true;
            this.servVirtualLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servVirtualLbl.Location = new System.Drawing.Point(265, 481);
            this.servVirtualLbl.Name = "servVirtualLbl";
            this.servVirtualLbl.Size = new System.Drawing.Size(108, 19);
            this.servVirtualLbl.TabIndex = 27;
            this.servVirtualLbl.Text = "Server Virtual:";
            // 
            // servModelLbl
            // 
            this.servModelLbl.AutoSize = true;
            this.servModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servModelLbl.Location = new System.Drawing.Point(266, 75);
            this.servModelLbl.Name = "servModelLbl";
            this.servModelLbl.Size = new System.Drawing.Size(107, 19);
            this.servModelLbl.TabIndex = 17;
            this.servModelLbl.Text = "Server Model:";
            // 
            // servHDDCapLbl
            // 
            this.servHDDCapLbl.AutoSize = true;
            this.servHDDCapLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHDDCapLbl.Location = new System.Drawing.Point(211, 442);
            this.servHDDCapLbl.Name = "servHDDCapLbl";
            this.servHDDCapLbl.Size = new System.Drawing.Size(162, 19);
            this.servHDDCapLbl.TabIndex = 26;
            this.servHDDCapLbl.Text = "Server HDD Capacity:";
            // 
            // servHDDLbl
            // 
            this.servHDDLbl.AutoSize = true;
            this.servHDDLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHDDLbl.Location = new System.Drawing.Point(274, 360);
            this.servHDDLbl.Name = "servHDDLbl";
            this.servHDDLbl.Size = new System.Drawing.Size(99, 19);
            this.servHDDLbl.TabIndex = 24;
            this.servHDDLbl.Text = "Server HDD:";
            // 
            // serHDDRaidTypeLbl
            // 
            this.serHDDRaidTypeLbl.AutoSize = true;
            this.serHDDRaidTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serHDDRaidTypeLbl.Location = new System.Drawing.Point(201, 400);
            this.serHDDRaidTypeLbl.Name = "serHDDRaidTypeLbl";
            this.serHDDRaidTypeLbl.Size = new System.Drawing.Size(172, 19);
            this.serHDDRaidTypeLbl.TabIndex = 25;
            this.serHDDRaidTypeLbl.Text = "Server HDD Raid Type:";
            // 
            // servOSBitTypeLbl
            // 
            this.servOSBitTypeLbl.AutoSize = true;
            this.servOSBitTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servOSBitTypeLbl.Location = new System.Drawing.Point(129, 319);
            this.servOSBitTypeLbl.Name = "servOSBitTypeLbl";
            this.servOSBitTypeLbl.Size = new System.Drawing.Size(244, 19);
            this.servOSBitTypeLbl.TabIndex = 23;
            this.servOSBitTypeLbl.Text = "Server Operating System Bit Type:";
            // 
            // servSerNumLbl
            // 
            this.servSerNumLbl.AutoSize = true;
            this.servSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servSerNumLbl.Location = new System.Drawing.Point(213, 118);
            this.servSerNumLbl.Name = "servSerNumLbl";
            this.servSerNumLbl.Size = new System.Drawing.Size(160, 19);
            this.servSerNumLbl.TabIndex = 18;
            this.servSerNumLbl.Text = "Server Serial Number:";
            // 
            // servProcLbl
            // 
            this.servProcLbl.AutoSize = true;
            this.servProcLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servProcLbl.Location = new System.Drawing.Point(244, 160);
            this.servProcLbl.Name = "servProcLbl";
            this.servProcLbl.Size = new System.Drawing.Size(129, 19);
            this.servProcLbl.TabIndex = 19;
            this.servProcLbl.Text = "Server Processor:";
            // 
            // servProcSpeedLbl
            // 
            this.servProcSpeedLbl.AutoSize = true;
            this.servProcSpeedLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servProcSpeedLbl.Location = new System.Drawing.Point(199, 205);
            this.servProcSpeedLbl.Name = "servProcSpeedLbl";
            this.servProcSpeedLbl.Size = new System.Drawing.Size(174, 19);
            this.servProcSpeedLbl.TabIndex = 20;
            this.servProcSpeedLbl.Text = "Server Processor Speed:";
            // 
            // servRAMLbl
            // 
            this.servRAMLbl.AutoSize = true;
            this.servRAMLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servRAMLbl.Location = new System.Drawing.Point(271, 242);
            this.servRAMLbl.Name = "servRAMLbl";
            this.servRAMLbl.Size = new System.Drawing.Size(102, 19);
            this.servRAMLbl.TabIndex = 21;
            this.servRAMLbl.Text = "Server RAM:";
            // 
            // servOSLbl
            // 
            this.servOSLbl.AutoSize = true;
            this.servOSLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servOSLbl.Location = new System.Drawing.Point(190, 282);
            this.servOSLbl.Name = "servOSLbl";
            this.servOSLbl.Size = new System.Drawing.Size(183, 19);
            this.servOSLbl.TabIndex = 22;
            this.servOSLbl.Text = "Server Operating System:";
            // 
            // servViewTab
            // 
            this.servViewTab.Controls.Add(this.servGridView);
            this.servViewTab.Controls.Add(this.serverRefreshBttn);
            this.servViewTab.Location = new System.Drawing.Point(4, 22);
            this.servViewTab.Name = "servViewTab";
            this.servViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.servViewTab.Size = new System.Drawing.Size(766, 578);
            this.servViewTab.TabIndex = 1;
            this.servViewTab.Text = "Server View";
            this.servViewTab.UseVisualStyleBackColor = true;
            // 
            // servGridView
            // 
            this.servGridView.AllowUserToAddRows = false;
            this.servGridView.AllowUserToDeleteRows = false;
            this.servGridView.AllowUserToOrderColumns = true;
            this.servGridView.AutoGenerateColumns = false;
            this.servGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverInvIDNumDataGridViewTextBoxColumn,
            this.serverMakeDataGridViewTextBoxColumn,
            this.serverModelDataGridViewTextBoxColumn,
            this.serverSerNumDataGridViewTextBoxColumn,
            this.serverProcDataGridViewTextBoxColumn,
            this.serverProcSpeedDataGridViewTextBoxColumn,
            this.serverRAMDataGridViewTextBoxColumn,
            this.serverOSDataGridViewTextBoxColumn,
            this.serverOSBitTypeDataGridViewTextBoxColumn,
            this.serverHDDDataGridViewTextBoxColumn,
            this.serverHDDRaidTypeDataGridViewTextBoxColumn,
            this.serverHDDCapDataGridViewTextBoxColumn,
            this.serverLocationDataGridViewTextBoxColumn});
            this.servGridView.DataSource = this.serversBindingSource;
            this.servGridView.Location = new System.Drawing.Point(6, 6);
            this.servGridView.Name = "servGridView";
            this.servGridView.Size = new System.Drawing.Size(754, 537);
            this.servGridView.TabIndex = 1;
            // 
            // serverInvIDNumDataGridViewTextBoxColumn
            // 
            this.serverInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "serverInvIDNum";
            this.serverInvIDNumDataGridViewTextBoxColumn.HeaderText = "Server Inventory ID Number";
            this.serverInvIDNumDataGridViewTextBoxColumn.Name = "serverInvIDNumDataGridViewTextBoxColumn";
            this.serverInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverMakeDataGridViewTextBoxColumn
            // 
            this.serverMakeDataGridViewTextBoxColumn.DataPropertyName = "serverMake";
            this.serverMakeDataGridViewTextBoxColumn.HeaderText = "Server Make";
            this.serverMakeDataGridViewTextBoxColumn.Name = "serverMakeDataGridViewTextBoxColumn";
            // 
            // serverModelDataGridViewTextBoxColumn
            // 
            this.serverModelDataGridViewTextBoxColumn.DataPropertyName = "serverModel";
            this.serverModelDataGridViewTextBoxColumn.HeaderText = "Server Model";
            this.serverModelDataGridViewTextBoxColumn.Name = "serverModelDataGridViewTextBoxColumn";
            // 
            // serverSerNumDataGridViewTextBoxColumn
            // 
            this.serverSerNumDataGridViewTextBoxColumn.DataPropertyName = "serverSerNum";
            this.serverSerNumDataGridViewTextBoxColumn.HeaderText = "Server Serial Number";
            this.serverSerNumDataGridViewTextBoxColumn.Name = "serverSerNumDataGridViewTextBoxColumn";
            // 
            // serverProcDataGridViewTextBoxColumn
            // 
            this.serverProcDataGridViewTextBoxColumn.DataPropertyName = "serverProc";
            this.serverProcDataGridViewTextBoxColumn.HeaderText = "Server Processor";
            this.serverProcDataGridViewTextBoxColumn.Name = "serverProcDataGridViewTextBoxColumn";
            // 
            // serverProcSpeedDataGridViewTextBoxColumn
            // 
            this.serverProcSpeedDataGridViewTextBoxColumn.DataPropertyName = "serverProcSpeed";
            this.serverProcSpeedDataGridViewTextBoxColumn.HeaderText = "Server Processor Speed";
            this.serverProcSpeedDataGridViewTextBoxColumn.Name = "serverProcSpeedDataGridViewTextBoxColumn";
            // 
            // serverRAMDataGridViewTextBoxColumn
            // 
            this.serverRAMDataGridViewTextBoxColumn.DataPropertyName = "serverRAM";
            this.serverRAMDataGridViewTextBoxColumn.HeaderText = "Server RAM";
            this.serverRAMDataGridViewTextBoxColumn.Name = "serverRAMDataGridViewTextBoxColumn";
            // 
            // serverOSDataGridViewTextBoxColumn
            // 
            this.serverOSDataGridViewTextBoxColumn.DataPropertyName = "serverOS";
            this.serverOSDataGridViewTextBoxColumn.HeaderText = "Server Operating System";
            this.serverOSDataGridViewTextBoxColumn.Name = "serverOSDataGridViewTextBoxColumn";
            // 
            // serverOSBitTypeDataGridViewTextBoxColumn
            // 
            this.serverOSBitTypeDataGridViewTextBoxColumn.DataPropertyName = "serverOSBitType";
            this.serverOSBitTypeDataGridViewTextBoxColumn.HeaderText = "Server Operating System Bit Type";
            this.serverOSBitTypeDataGridViewTextBoxColumn.Name = "serverOSBitTypeDataGridViewTextBoxColumn";
            // 
            // serverHDDDataGridViewTextBoxColumn
            // 
            this.serverHDDDataGridViewTextBoxColumn.DataPropertyName = "serverHDD";
            this.serverHDDDataGridViewTextBoxColumn.HeaderText = "Server HDD";
            this.serverHDDDataGridViewTextBoxColumn.Name = "serverHDDDataGridViewTextBoxColumn";
            // 
            // serverHDDRaidTypeDataGridViewTextBoxColumn
            // 
            this.serverHDDRaidTypeDataGridViewTextBoxColumn.DataPropertyName = "serverHDDRaidType";
            this.serverHDDRaidTypeDataGridViewTextBoxColumn.HeaderText = "Server HDD Raid Type";
            this.serverHDDRaidTypeDataGridViewTextBoxColumn.Name = "serverHDDRaidTypeDataGridViewTextBoxColumn";
            // 
            // serverHDDCapDataGridViewTextBoxColumn
            // 
            this.serverHDDCapDataGridViewTextBoxColumn.DataPropertyName = "serverHDDCap";
            this.serverHDDCapDataGridViewTextBoxColumn.HeaderText = "Server HDD Capacity";
            this.serverHDDCapDataGridViewTextBoxColumn.Name = "serverHDDCapDataGridViewTextBoxColumn";
            // 
            // serverLocationDataGridViewTextBoxColumn
            // 
            this.serverLocationDataGridViewTextBoxColumn.DataPropertyName = "serverLocation";
            this.serverLocationDataGridViewTextBoxColumn.HeaderText = "Server Location";
            this.serverLocationDataGridViewTextBoxColumn.Name = "serverLocationDataGridViewTextBoxColumn";
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "Servers";
            this.serversBindingSource.DataSource = this.serverDBDataSet;
            // 
            // serverDBDataSet
            // 
            this.serverDBDataSet.DataSetName = "ServerDBDataSet";
            this.serverDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serverRefreshBttn
            // 
            this.serverRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverRefreshBttn.Location = new System.Drawing.Point(685, 549);
            this.serverRefreshBttn.Name = "serverRefreshBttn";
            this.serverRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.serverRefreshBttn.TabIndex = 0;
            this.serverRefreshBttn.Text = "Refresh";
            this.serverRefreshBttn.UseVisualStyleBackColor = true;
            this.serverRefreshBttn.Click += new System.EventHandler(this.serverRefreshBttn_Click);
            // 
            // serversTableAdapter
            // 
            this.serversTableAdapter.ClearBeforeFill = true;
            // 
            // ServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 738);
            this.Controls.Add(this.servBodyPnl);
            this.Controls.Add(this.servHeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ServerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerFrm";
            this.Load += new System.EventHandler(this.ServerFrm_Load);
            this.servHeadPnl.ResumeLayout(false);
            this.servHeadPnl.PerformLayout();
            this.servBodyPnl.ResumeLayout(false);
            this.servTabCntl.ResumeLayout(false);
            this.servInputTab.ResumeLayout(false);
            this.servInputTab.PerformLayout();
            this.servViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel servHeadPnl;
        private System.Windows.Forms.Label servHeadTitleLbl;
        private System.Windows.Forms.Label servHeadLbl;
        private System.Windows.Forms.Panel servBodyPnl;
        private System.Windows.Forms.Label servLocationLbl;
        private System.Windows.Forms.Label servVirtualLbl;
        private System.Windows.Forms.Label servOSBitTypeLbl;
        private System.Windows.Forms.Label servHDDLbl;
        private System.Windows.Forms.Label servHDDCapLbl;
        private System.Windows.Forms.Label serHDDRaidTypeLbl;
        private System.Windows.Forms.Label servOSLbl;
        private System.Windows.Forms.Label servRAMLbl;
        private System.Windows.Forms.Label servProcSpeedLbl;
        private System.Windows.Forms.Label servProcLbl;
        private System.Windows.Forms.Label servSerNumLbl;
        private System.Windows.Forms.Label servModelLbl;
        private System.Windows.Forms.Label servMakeLbl;
        private System.Windows.Forms.TextBox servVirtTxtBx;
        private System.Windows.Forms.TextBox servLocationTxtBx;
        private System.Windows.Forms.TextBox servHDDCapTxtBx;
        private System.Windows.Forms.TextBox servHDDRaidTypeTxtBx;
        private System.Windows.Forms.TextBox servHDDTxtBx;
        private System.Windows.Forms.TextBox servOSBitTypeTxtBx;
        private System.Windows.Forms.TextBox servOSTxtBx;
        private System.Windows.Forms.TextBox servRAMTxtBx;
        private System.Windows.Forms.TextBox servProcSpeedTxtBx;
        private System.Windows.Forms.TextBox servProcTxtBx;
        private System.Windows.Forms.TextBox servSerNumTxtBx;
        private System.Windows.Forms.TextBox servModelTxtBx;
        private System.Windows.Forms.TextBox servMakeTxtBx;
        private System.Windows.Forms.Button servSaveBttn;
        private System.Windows.Forms.Button servClearBttn;
        private System.Windows.Forms.Button servExitBttn;
        private System.Windows.Forms.TabControl servTabCntl;
        private System.Windows.Forms.TabPage servInputTab;
        private System.Windows.Forms.TabPage servViewTab;
        private System.Windows.Forms.Button serverRefreshBttn;
        private System.Windows.Forms.DataGridView servGridView;
        private ServerDBDataSet serverDBDataSet;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private ServerDBDataSetTableAdapters.ServersTableAdapter serversTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverProcSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverOSBitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverHDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverHDDRaidTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverHDDCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverLocationDataGridViewTextBoxColumn;
    }
}