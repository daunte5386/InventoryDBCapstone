namespace InventoryDBApp
{
    partial class MonitorFrm
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
            this.monHeadPnl = new System.Windows.Forms.Panel();
            this.monHeadTitleLbl = new System.Windows.Forms.Label();
            this.monHeadLbl = new System.Windows.Forms.Label();
            this.monBodyPnl = new System.Windows.Forms.Panel();
            this.monTabCntl = new System.Windows.Forms.TabControl();
            this.monInputTab = new System.Windows.Forms.TabPage();
            this.monSaveBttn = new System.Windows.Forms.Button();
            this.monClearBttn = new System.Windows.Forms.Button();
            this.monExitBttn = new System.Windows.Forms.Button();
            this.monLocationTxtBx = new System.Windows.Forms.TextBox();
            this.monTypeTxtBx = new System.Windows.Forms.TextBox();
            this.monSizeTxtBx = new System.Windows.Forms.TextBox();
            this.monSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.monModelTxtBx = new System.Windows.Forms.TextBox();
            this.monMakeTxtBx = new System.Windows.Forms.TextBox();
            this.monLocationLbl = new System.Windows.Forms.Label();
            this.monTypeLbl = new System.Windows.Forms.Label();
            this.monSizeLbl = new System.Windows.Forms.Label();
            this.monSerNumLbl = new System.Windows.Forms.Label();
            this.monModelLbl = new System.Windows.Forms.Label();
            this.monMakeLbl = new System.Windows.Forms.Label();
            this.monViewTab = new System.Windows.Forms.TabPage();
            this.monGridView = new System.Windows.Forms.DataGridView();
            this.monitorInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitorDBDataSet = new InventoryDBApp.MonitorDBDataSet();
            this.monRefreshBttn = new System.Windows.Forms.Button();
            this.monitorsTableAdapter = new InventoryDBApp.MonitorDBDataSetTableAdapters.MonitorsTableAdapter();
            this.monHeadPnl.SuspendLayout();
            this.monBodyPnl.SuspendLayout();
            this.monTabCntl.SuspendLayout();
            this.monInputTab.SuspendLayout();
            this.monViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monHeadPnl
            // 
            this.monHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monHeadPnl.Controls.Add(this.monHeadTitleLbl);
            this.monHeadPnl.Controls.Add(this.monHeadLbl);
            this.monHeadPnl.Location = new System.Drawing.Point(12, 12);
            this.monHeadPnl.Name = "monHeadPnl";
            this.monHeadPnl.Size = new System.Drawing.Size(784, 101);
            this.monHeadPnl.TabIndex = 0;
            // 
            // monHeadTitleLbl
            // 
            this.monHeadTitleLbl.AutoSize = true;
            this.monHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHeadTitleLbl.Location = new System.Drawing.Point(310, 62);
            this.monHeadTitleLbl.Name = "monHeadTitleLbl";
            this.monHeadTitleLbl.Size = new System.Drawing.Size(154, 26);
            this.monHeadTitleLbl.TabIndex = 1;
            this.monHeadTitleLbl.Text = "Monitor Page";
            // 
            // monHeadLbl
            // 
            this.monHeadLbl.AutoSize = true;
            this.monHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHeadLbl.Location = new System.Drawing.Point(34, 16);
            this.monHeadLbl.Name = "monHeadLbl";
            this.monHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.monHeadLbl.TabIndex = 0;
            this.monHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // monBodyPnl
            // 
            this.monBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monBodyPnl.Controls.Add(this.monTabCntl);
            this.monBodyPnl.Location = new System.Drawing.Point(12, 119);
            this.monBodyPnl.Name = "monBodyPnl";
            this.monBodyPnl.Size = new System.Drawing.Size(784, 416);
            this.monBodyPnl.TabIndex = 1;
            // 
            // monTabCntl
            // 
            this.monTabCntl.Controls.Add(this.monInputTab);
            this.monTabCntl.Controls.Add(this.monViewTab);
            this.monTabCntl.Location = new System.Drawing.Point(3, 3);
            this.monTabCntl.Name = "monTabCntl";
            this.monTabCntl.SelectedIndex = 0;
            this.monTabCntl.Size = new System.Drawing.Size(774, 406);
            this.monTabCntl.TabIndex = 0;
            // 
            // monInputTab
            // 
            this.monInputTab.Controls.Add(this.monSaveBttn);
            this.monInputTab.Controls.Add(this.monClearBttn);
            this.monInputTab.Controls.Add(this.monExitBttn);
            this.monInputTab.Controls.Add(this.monLocationTxtBx);
            this.monInputTab.Controls.Add(this.monTypeTxtBx);
            this.monInputTab.Controls.Add(this.monSizeTxtBx);
            this.monInputTab.Controls.Add(this.monSerNumTxtBx);
            this.monInputTab.Controls.Add(this.monModelTxtBx);
            this.monInputTab.Controls.Add(this.monMakeTxtBx);
            this.monInputTab.Controls.Add(this.monLocationLbl);
            this.monInputTab.Controls.Add(this.monTypeLbl);
            this.monInputTab.Controls.Add(this.monSizeLbl);
            this.monInputTab.Controls.Add(this.monSerNumLbl);
            this.monInputTab.Controls.Add(this.monModelLbl);
            this.monInputTab.Controls.Add(this.monMakeLbl);
            this.monInputTab.Location = new System.Drawing.Point(4, 22);
            this.monInputTab.Name = "monInputTab";
            this.monInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.monInputTab.Size = new System.Drawing.Size(766, 380);
            this.monInputTab.TabIndex = 0;
            this.monInputTab.Text = "Monitor Input";
            this.monInputTab.UseVisualStyleBackColor = true;
            // 
            // monSaveBttn
            // 
            this.monSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSaveBttn.Location = new System.Drawing.Point(482, 351);
            this.monSaveBttn.Name = "monSaveBttn";
            this.monSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.monSaveBttn.TabIndex = 6;
            this.monSaveBttn.Text = "Save";
            this.monSaveBttn.UseVisualStyleBackColor = true;
            this.monSaveBttn.Click += new System.EventHandler(this.monSaveBttn_Click);
            // 
            // monClearBttn
            // 
            this.monClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monClearBttn.Location = new System.Drawing.Point(583, 351);
            this.monClearBttn.Name = "monClearBttn";
            this.monClearBttn.Size = new System.Drawing.Size(75, 23);
            this.monClearBttn.TabIndex = 7;
            this.monClearBttn.Text = "Clear";
            this.monClearBttn.UseVisualStyleBackColor = true;
            this.monClearBttn.Click += new System.EventHandler(this.monClearBttn_Click);
            // 
            // monExitBttn
            // 
            this.monExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monExitBttn.Location = new System.Drawing.Point(685, 351);
            this.monExitBttn.Name = "monExitBttn";
            this.monExitBttn.Size = new System.Drawing.Size(75, 23);
            this.monExitBttn.TabIndex = 8;
            this.monExitBttn.Text = "Exit";
            this.monExitBttn.UseVisualStyleBackColor = true;
            this.monExitBttn.Click += new System.EventHandler(this.monExitBttn_Click);
            // 
            // monLocationTxtBx
            // 
            this.monLocationTxtBx.Location = new System.Drawing.Point(385, 293);
            this.monLocationTxtBx.Name = "monLocationTxtBx";
            this.monLocationTxtBx.Size = new System.Drawing.Size(345, 20);
            this.monLocationTxtBx.TabIndex = 5;
            // 
            // monTypeTxtBx
            // 
            this.monTypeTxtBx.Location = new System.Drawing.Point(385, 242);
            this.monTypeTxtBx.Name = "monTypeTxtBx";
            this.monTypeTxtBx.Size = new System.Drawing.Size(121, 20);
            this.monTypeTxtBx.TabIndex = 4;
            // 
            // monSizeTxtBx
            // 
            this.monSizeTxtBx.Location = new System.Drawing.Point(385, 192);
            this.monSizeTxtBx.Name = "monSizeTxtBx";
            this.monSizeTxtBx.Size = new System.Drawing.Size(72, 20);
            this.monSizeTxtBx.TabIndex = 3;
            // 
            // monSerNumTxtBx
            // 
            this.monSerNumTxtBx.Location = new System.Drawing.Point(385, 140);
            this.monSerNumTxtBx.Name = "monSerNumTxtBx";
            this.monSerNumTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monSerNumTxtBx.TabIndex = 2;
            // 
            // monModelTxtBx
            // 
            this.monModelTxtBx.Location = new System.Drawing.Point(385, 90);
            this.monModelTxtBx.Name = "monModelTxtBx";
            this.monModelTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monModelTxtBx.TabIndex = 1;
            // 
            // monMakeTxtBx
            // 
            this.monMakeTxtBx.Location = new System.Drawing.Point(385, 38);
            this.monMakeTxtBx.Name = "monMakeTxtBx";
            this.monMakeTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monMakeTxtBx.TabIndex = 0;
            // 
            // monLocationLbl
            // 
            this.monLocationLbl.AutoSize = true;
            this.monLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monLocationLbl.Location = new System.Drawing.Point(248, 292);
            this.monLocationLbl.Name = "monLocationLbl";
            this.monLocationLbl.Size = new System.Drawing.Size(131, 19);
            this.monLocationLbl.TabIndex = 6;
            this.monLocationLbl.Text = "Monitor Location:";
            // 
            // monTypeLbl
            // 
            this.monTypeLbl.AutoSize = true;
            this.monTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monTypeLbl.Location = new System.Drawing.Point(273, 241);
            this.monTypeLbl.Name = "monTypeLbl";
            this.monTypeLbl.Size = new System.Drawing.Size(106, 19);
            this.monTypeLbl.TabIndex = 5;
            this.monTypeLbl.Text = "Monitor Type:";
            // 
            // monSizeLbl
            // 
            this.monSizeLbl.AutoSize = true;
            this.monSizeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSizeLbl.Location = new System.Drawing.Point(279, 191);
            this.monSizeLbl.Name = "monSizeLbl";
            this.monSizeLbl.Size = new System.Drawing.Size(100, 19);
            this.monSizeLbl.TabIndex = 4;
            this.monSizeLbl.Text = "Monitor Size:";
            // 
            // monSerNumLbl
            // 
            this.monSerNumLbl.AutoSize = true;
            this.monSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSerNumLbl.Location = new System.Drawing.Point(209, 139);
            this.monSerNumLbl.Name = "monSerNumLbl";
            this.monSerNumLbl.Size = new System.Drawing.Size(170, 19);
            this.monSerNumLbl.TabIndex = 3;
            this.monSerNumLbl.Text = "Monitor Serial Number:";
            // 
            // monModelLbl
            // 
            this.monModelLbl.AutoSize = true;
            this.monModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monModelLbl.Location = new System.Drawing.Point(262, 89);
            this.monModelLbl.Name = "monModelLbl";
            this.monModelLbl.Size = new System.Drawing.Size(117, 19);
            this.monModelLbl.TabIndex = 2;
            this.monModelLbl.Text = "Monitor Model:";
            // 
            // monMakeLbl
            // 
            this.monMakeLbl.AutoSize = true;
            this.monMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monMakeLbl.Location = new System.Drawing.Point(269, 37);
            this.monMakeLbl.Name = "monMakeLbl";
            this.monMakeLbl.Size = new System.Drawing.Size(110, 19);
            this.monMakeLbl.TabIndex = 1;
            this.monMakeLbl.Text = "Monitor make:";
            // 
            // monViewTab
            // 
            this.monViewTab.Controls.Add(this.monGridView);
            this.monViewTab.Controls.Add(this.monRefreshBttn);
            this.monViewTab.Location = new System.Drawing.Point(4, 22);
            this.monViewTab.Name = "monViewTab";
            this.monViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.monViewTab.Size = new System.Drawing.Size(766, 380);
            this.monViewTab.TabIndex = 1;
            this.monViewTab.Text = "Monitor View";
            this.monViewTab.UseVisualStyleBackColor = true;
            // 
            // monGridView
            // 
            this.monGridView.AllowUserToAddRows = false;
            this.monGridView.AllowUserToDeleteRows = false;
            this.monGridView.AllowUserToOrderColumns = true;
            this.monGridView.AutoGenerateColumns = false;
            this.monGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monitorInvIDNumDataGridViewTextBoxColumn,
            this.monitorMakeDataGridViewTextBoxColumn,
            this.monitorModelDataGridViewTextBoxColumn,
            this.monitorSerNumDataGridViewTextBoxColumn,
            this.monitorSizeDataGridViewTextBoxColumn,
            this.monitorTypeDataGridViewTextBoxColumn,
            this.monitorLocationDataGridViewTextBoxColumn});
            this.monGridView.DataSource = this.monitorsBindingSource;
            this.monGridView.Location = new System.Drawing.Point(6, 6);
            this.monGridView.Name = "monGridView";
            this.monGridView.Size = new System.Drawing.Size(757, 339);
            this.monGridView.TabIndex = 1;
            // 
            // monitorInvIDNumDataGridViewTextBoxColumn
            // 
            this.monitorInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "monitorInvIDNum";
            this.monitorInvIDNumDataGridViewTextBoxColumn.HeaderText = "Monitor Inventory ID Number";
            this.monitorInvIDNumDataGridViewTextBoxColumn.Name = "monitorInvIDNumDataGridViewTextBoxColumn";
            this.monitorInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorMakeDataGridViewTextBoxColumn
            // 
            this.monitorMakeDataGridViewTextBoxColumn.DataPropertyName = "monitorMake";
            this.monitorMakeDataGridViewTextBoxColumn.HeaderText = "Monitor Make";
            this.monitorMakeDataGridViewTextBoxColumn.Name = "monitorMakeDataGridViewTextBoxColumn";
            // 
            // monitorModelDataGridViewTextBoxColumn
            // 
            this.monitorModelDataGridViewTextBoxColumn.DataPropertyName = "monitorModel";
            this.monitorModelDataGridViewTextBoxColumn.HeaderText = "Monitor Model";
            this.monitorModelDataGridViewTextBoxColumn.Name = "monitorModelDataGridViewTextBoxColumn";
            // 
            // monitorSerNumDataGridViewTextBoxColumn
            // 
            this.monitorSerNumDataGridViewTextBoxColumn.DataPropertyName = "monitorSerNum";
            this.monitorSerNumDataGridViewTextBoxColumn.HeaderText = "Monitor Serial Number";
            this.monitorSerNumDataGridViewTextBoxColumn.Name = "monitorSerNumDataGridViewTextBoxColumn";
            // 
            // monitorSizeDataGridViewTextBoxColumn
            // 
            this.monitorSizeDataGridViewTextBoxColumn.DataPropertyName = "monitorSize";
            this.monitorSizeDataGridViewTextBoxColumn.HeaderText = "Monitor Size";
            this.monitorSizeDataGridViewTextBoxColumn.Name = "monitorSizeDataGridViewTextBoxColumn";
            // 
            // monitorTypeDataGridViewTextBoxColumn
            // 
            this.monitorTypeDataGridViewTextBoxColumn.DataPropertyName = "monitorType";
            this.monitorTypeDataGridViewTextBoxColumn.HeaderText = "Monitor Type";
            this.monitorTypeDataGridViewTextBoxColumn.Name = "monitorTypeDataGridViewTextBoxColumn";
            // 
            // monitorLocationDataGridViewTextBoxColumn
            // 
            this.monitorLocationDataGridViewTextBoxColumn.DataPropertyName = "monitorLocation";
            this.monitorLocationDataGridViewTextBoxColumn.HeaderText = "Monitor Location";
            this.monitorLocationDataGridViewTextBoxColumn.Name = "monitorLocationDataGridViewTextBoxColumn";
            // 
            // monitorsBindingSource
            // 
            this.monitorsBindingSource.DataMember = "Monitors";
            this.monitorsBindingSource.DataSource = this.monitorDBDataSet;
            // 
            // monitorDBDataSet
            // 
            this.monitorDBDataSet.DataSetName = "MonitorDBDataSet";
            this.monitorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monRefreshBttn
            // 
            this.monRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monRefreshBttn.Location = new System.Drawing.Point(685, 351);
            this.monRefreshBttn.Name = "monRefreshBttn";
            this.monRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.monRefreshBttn.TabIndex = 0;
            this.monRefreshBttn.Text = "Refresh";
            this.monRefreshBttn.UseVisualStyleBackColor = true;
            this.monRefreshBttn.Click += new System.EventHandler(this.monRefreshBttn_Click);
            // 
            // monitorsTableAdapter
            // 
            this.monitorsTableAdapter.ClearBeforeFill = true;
            // 
            // MonitorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.monBodyPnl);
            this.Controls.Add(this.monHeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MonitorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Database Screen";
            this.Load += new System.EventHandler(this.MonitorFrm_Load);
            this.monHeadPnl.ResumeLayout(false);
            this.monHeadPnl.PerformLayout();
            this.monBodyPnl.ResumeLayout(false);
            this.monTabCntl.ResumeLayout(false);
            this.monInputTab.ResumeLayout(false);
            this.monInputTab.PerformLayout();
            this.monViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel monHeadPnl;
        private System.Windows.Forms.Label monHeadTitleLbl;
        private System.Windows.Forms.Label monHeadLbl;
        private System.Windows.Forms.Panel monBodyPnl;
        private System.Windows.Forms.TabControl monTabCntl;
        private System.Windows.Forms.TabPage monInputTab;
        private System.Windows.Forms.Button monSaveBttn;
        private System.Windows.Forms.Button monClearBttn;
        private System.Windows.Forms.Button monExitBttn;
        private System.Windows.Forms.TextBox monLocationTxtBx;
        private System.Windows.Forms.TextBox monTypeTxtBx;
        private System.Windows.Forms.TextBox monSizeTxtBx;
        private System.Windows.Forms.TextBox monSerNumTxtBx;
        private System.Windows.Forms.TextBox monModelTxtBx;
        private System.Windows.Forms.TextBox monMakeTxtBx;
        private System.Windows.Forms.Label monLocationLbl;
        private System.Windows.Forms.Label monTypeLbl;
        private System.Windows.Forms.Label monSizeLbl;
        private System.Windows.Forms.Label monSerNumLbl;
        private System.Windows.Forms.Label monModelLbl;
        private System.Windows.Forms.Label monMakeLbl;
        private System.Windows.Forms.TabPage monViewTab;
        private System.Windows.Forms.DataGridView monGridView;
        private System.Windows.Forms.Button monRefreshBttn;
        private MonitorDBDataSet monitorDBDataSet;
        private System.Windows.Forms.BindingSource monitorsBindingSource;
        private MonitorDBDataSetTableAdapters.MonitorsTableAdapter monitorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorLocationDataGridViewTextBoxColumn;
    }
}