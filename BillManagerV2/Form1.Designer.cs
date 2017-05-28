namespace BillManagerV2
{
    partial class Main_form
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_addCategory = new System.Windows.Forms.Button();
            this.BT_Testevent = new System.Windows.Forms.Button();
            this.TB_deletebill = new System.Windows.Forms.TextBox();
            this.BT_TestButton = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BT_totalweekcost = new System.Windows.Forms.Button();
            this.BT_printbillList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_AddBill = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.LB_catagorys = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.readFromFileToolStripMenuItem,
            this.saveFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "FIle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            // 
            // saveFromFileToolStripMenuItem
            // 
            this.saveFromFileToolStripMenuItem.Name = "saveFromFileToolStripMenuItem";
            this.saveFromFileToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.saveFromFileToolStripMenuItem.Text = "Save to file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bt_addCategory
            // 
            this.bt_addCategory.Location = new System.Drawing.Point(176, 104);
            this.bt_addCategory.Margin = new System.Windows.Forms.Padding(4);
            this.bt_addCategory.Name = "bt_addCategory";
            this.bt_addCategory.Size = new System.Drawing.Size(161, 41);
            this.bt_addCategory.TabIndex = 55;
            this.bt_addCategory.Text = "Add category ";
            this.bt_addCategory.UseVisualStyleBackColor = true;
            this.bt_addCategory.Click += new System.EventHandler(this.bt_addCategory_Click);
            // 
            // BT_Testevent
            // 
            this.BT_Testevent.Location = new System.Drawing.Point(1267, 324);
            this.BT_Testevent.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Testevent.Name = "BT_Testevent";
            this.BT_Testevent.Size = new System.Drawing.Size(105, 53);
            this.BT_Testevent.TabIndex = 53;
            this.BT_Testevent.Text = "Testevent";
            this.BT_Testevent.UseVisualStyleBackColor = true;
            // 
            // TB_deletebill
            // 
            this.TB_deletebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_deletebill.Location = new System.Drawing.Point(1267, 169);
            this.TB_deletebill.Margin = new System.Windows.Forms.Padding(4);
            this.TB_deletebill.Name = "TB_deletebill";
            this.TB_deletebill.Size = new System.Drawing.Size(104, 34);
            this.TB_deletebill.TabIndex = 49;
            // 
            // BT_TestButton
            // 
            this.BT_TestButton.Location = new System.Drawing.Point(1267, 264);
            this.BT_TestButton.Margin = new System.Windows.Forms.Padding(4);
            this.BT_TestButton.Name = "BT_TestButton";
            this.BT_TestButton.Size = new System.Drawing.Size(107, 53);
            this.BT_TestButton.TabIndex = 52;
            this.BT_TestButton.Text = "TestButton";
            this.BT_TestButton.UseVisualStyleBackColor = true;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(1263, 212);
            this.BT_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(105, 34);
            this.BT_Delete.TabIndex = 39;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(807, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 233);
            this.textBox1.TabIndex = 38;
            // 
            // BT_totalweekcost
            // 
            this.BT_totalweekcost.Location = new System.Drawing.Point(1267, 108);
            this.BT_totalweekcost.Margin = new System.Windows.Forms.Padding(4);
            this.BT_totalweekcost.Name = "BT_totalweekcost";
            this.BT_totalweekcost.Size = new System.Drawing.Size(101, 53);
            this.BT_totalweekcost.TabIndex = 51;
            this.BT_totalweekcost.Text = "total weekley cost";
            this.BT_totalweekcost.UseVisualStyleBackColor = true;
            // 
            // BT_printbillList
            // 
            this.BT_printbillList.Location = new System.Drawing.Point(1267, 48);
            this.BT_printbillList.Margin = new System.Windows.Forms.Padding(4);
            this.BT_printbillList.Name = "BT_printbillList";
            this.BT_printbillList.Size = new System.Drawing.Size(99, 53);
            this.BT_printbillList.TabIndex = 50;
            this.BT_printbillList.Text = "print all bills";
            this.BT_printbillList.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 410);
            this.dataGridView1.TabIndex = 37;
            // 
            // BT_AddBill
            // 
            this.BT_AddBill.Location = new System.Drawing.Point(176, 195);
            this.BT_AddBill.Margin = new System.Windows.Forms.Padding(4);
            this.BT_AddBill.Name = "BT_AddBill";
            this.BT_AddBill.Size = new System.Drawing.Size(161, 41);
            this.BT_AddBill.TabIndex = 43;
            this.BT_AddBill.Text = "Add Bill";
            this.BT_AddBill.UseVisualStyleBackColor = true;
            this.BT_AddBill.Click += new System.EventHandler(this.BT_AddBill_Click);
            // 
            // LB_catagorys
            // 
            this.LB_catagorys.FormattingEnabled = true;
            this.LB_catagorys.ItemHeight = 16;
            this.LB_catagorys.Location = new System.Drawing.Point(930, 504);
            this.LB_catagorys.Margin = new System.Windows.Forms.Padding(4);
            this.LB_catagorys.Name = "LB_catagorys";
            this.LB_catagorys.Size = new System.Drawing.Size(93, 244);
            this.LB_catagorys.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Catagory";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1177, 825);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_catagorys);
            this.Controls.Add(this.bt_addCategory);
            this.Controls.Add(this.BT_Testevent);
            this.Controls.Add(this.TB_deletebill);
            this.Controls.Add(this.BT_TestButton);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BT_totalweekcost);
            this.Controls.Add(this.BT_printbillList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_AddBill);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bt_addCategory;
        private System.Windows.Forms.Button BT_Testevent;
        private System.Windows.Forms.TextBox TB_deletebill;
        private System.Windows.Forms.Button BT_TestButton;
        private System.Windows.Forms.Button BT_Delete;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BT_totalweekcost;
        private System.Windows.Forms.Button BT_printbillList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_AddBill;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ListBox LB_catagorys;
        private System.Windows.Forms.Label label1;
    }
}

