namespace InventoryDBApp
{
    partial class mainMenuFrm
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
            this.headerPnl = new System.Windows.Forms.Panel();
            this.menuTitleLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.bodyPnl = new System.Windows.Forms.Panel();
            this.serverSectionLbl = new System.Windows.Forms.Label();
            this.printerSectionLbl = new System.Windows.Forms.Label();
            this.monitorSectionLbl = new System.Windows.Forms.Label();
            this.computerSectionLbl = new System.Windows.Forms.Label();
            this.closeBttn = new System.Windows.Forms.Button();
            this.serverBttn = new System.Windows.Forms.Button();
            this.printerBttn = new System.Windows.Forms.Button();
            this.monitorBttn = new System.Windows.Forms.Button();
            this.computerBttn = new System.Windows.Forms.Button();
            this.headerPnl.SuspendLayout();
            this.bodyPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerPnl.Controls.Add(this.menuTitleLbl);
            this.headerPnl.Controls.Add(this.titleLbl);
            this.headerPnl.Location = new System.Drawing.Point(12, 12);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(524, 83);
            this.headerPnl.TabIndex = 0;
            // 
            // menuTitleLbl
            // 
            this.menuTitleLbl.AutoSize = true;
            this.menuTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitleLbl.Location = new System.Drawing.Point(184, 45);
            this.menuTitleLbl.Name = "menuTitleLbl";
            this.menuTitleLbl.Size = new System.Drawing.Size(133, 26);
            this.menuTitleLbl.TabIndex = 1;
            this.menuTitleLbl.Text = "Main Menu";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(7, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(510, 36);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "The Inventory Database Application";
            // 
            // bodyPnl
            // 
            this.bodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bodyPnl.Controls.Add(this.serverSectionLbl);
            this.bodyPnl.Controls.Add(this.printerSectionLbl);
            this.bodyPnl.Controls.Add(this.monitorSectionLbl);
            this.bodyPnl.Controls.Add(this.computerSectionLbl);
            this.bodyPnl.Controls.Add(this.closeBttn);
            this.bodyPnl.Controls.Add(this.serverBttn);
            this.bodyPnl.Controls.Add(this.printerBttn);
            this.bodyPnl.Controls.Add(this.monitorBttn);
            this.bodyPnl.Controls.Add(this.computerBttn);
            this.bodyPnl.Location = new System.Drawing.Point(12, 101);
            this.bodyPnl.Name = "bodyPnl";
            this.bodyPnl.Size = new System.Drawing.Size(524, 235);
            this.bodyPnl.TabIndex = 1;
            // 
            // serverSectionLbl
            // 
            this.serverSectionLbl.AutoSize = true;
            this.serverSectionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSectionLbl.Location = new System.Drawing.Point(105, 163);
            this.serverSectionLbl.Name = "serverSectionLbl";
            this.serverSectionLbl.Size = new System.Drawing.Size(282, 19);
            this.serverSectionLbl.TabIndex = 8;
            this.serverSectionLbl.Text = "This button leads to the Server Database";
            // 
            // printerSectionLbl
            // 
            this.printerSectionLbl.AutoSize = true;
            this.printerSectionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerSectionLbl.Location = new System.Drawing.Point(105, 115);
            this.printerSectionLbl.Name = "printerSectionLbl";
            this.printerSectionLbl.Size = new System.Drawing.Size(290, 19);
            this.printerSectionLbl.TabIndex = 7;
            this.printerSectionLbl.Text = "This button leads to the Printers Database";
            // 
            // monitorSectionLbl
            // 
            this.monitorSectionLbl.AutoSize = true;
            this.monitorSectionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorSectionLbl.Location = new System.Drawing.Point(105, 68);
            this.monitorSectionLbl.Name = "monitorSectionLbl";
            this.monitorSectionLbl.Size = new System.Drawing.Size(299, 19);
            this.monitorSectionLbl.TabIndex = 6;
            this.monitorSectionLbl.Text = "This button leads to the Monitors Database";
            // 
            // computerSectionLbl
            // 
            this.computerSectionLbl.AutoSize = true;
            this.computerSectionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerSectionLbl.Location = new System.Drawing.Point(105, 24);
            this.computerSectionLbl.Name = "computerSectionLbl";
            this.computerSectionLbl.Size = new System.Drawing.Size(310, 19);
            this.computerSectionLbl.TabIndex = 5;
            this.computerSectionLbl.Text = "This button leads to the Computers Database";
            // 
            // closeBttn
            // 
            this.closeBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBttn.Location = new System.Drawing.Point(442, 205);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(75, 23);
            this.closeBttn.TabIndex = 4;
            this.closeBttn.Text = "Close";
            this.closeBttn.UseVisualStyleBackColor = true;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // serverBttn
            // 
            this.serverBttn.Location = new System.Drawing.Point(66, 162);
            this.serverBttn.Name = "serverBttn";
            this.serverBttn.Size = new System.Drawing.Size(33, 23);
            this.serverBttn.TabIndex = 3;
            this.serverBttn.UseVisualStyleBackColor = true;
            this.serverBttn.Click += new System.EventHandler(this.serverBttn_Click);
            // 
            // printerBttn
            // 
            this.printerBttn.Location = new System.Drawing.Point(66, 114);
            this.printerBttn.Name = "printerBttn";
            this.printerBttn.Size = new System.Drawing.Size(33, 23);
            this.printerBttn.TabIndex = 2;
            this.printerBttn.UseVisualStyleBackColor = true;
            this.printerBttn.Click += new System.EventHandler(this.printerBttn_Click);
            // 
            // monitorBttn
            // 
            this.monitorBttn.Location = new System.Drawing.Point(66, 67);
            this.monitorBttn.Name = "monitorBttn";
            this.monitorBttn.Size = new System.Drawing.Size(33, 23);
            this.monitorBttn.TabIndex = 1;
            this.monitorBttn.UseVisualStyleBackColor = true;
            this.monitorBttn.Click += new System.EventHandler(this.monitorBttn_Click);
            // 
            // computerBttn
            // 
            this.computerBttn.Location = new System.Drawing.Point(66, 23);
            this.computerBttn.Name = "computerBttn";
            this.computerBttn.Size = new System.Drawing.Size(33, 23);
            this.computerBttn.TabIndex = 0;
            this.computerBttn.UseVisualStyleBackColor = true;
            this.computerBttn.Click += new System.EventHandler(this.computerBttn_Click);
            // 
            // mainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 348);
            this.Controls.Add(this.bodyPnl);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();
            this.bodyPnl.ResumeLayout(false);
            this.bodyPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Label menuTitleLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel bodyPnl;
        private System.Windows.Forms.Label serverSectionLbl;
        private System.Windows.Forms.Label printerSectionLbl;
        private System.Windows.Forms.Label monitorSectionLbl;
        private System.Windows.Forms.Label computerSectionLbl;
        private System.Windows.Forms.Button closeBttn;
        private System.Windows.Forms.Button serverBttn;
        private System.Windows.Forms.Button printerBttn;
        private System.Windows.Forms.Button monitorBttn;
        private System.Windows.Forms.Button computerBttn;
    }
}

