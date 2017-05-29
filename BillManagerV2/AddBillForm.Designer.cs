namespace BillManagerV2
{
    partial class AddBillForm
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
            this.BT_Finished = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CMB_categorys = new System.Windows.Forms.ComboBox();
            this.TB_BillsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DT_BillsDate = new System.Windows.Forms.DateTimePicker();
            this.TB_BillCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Finished
            // 
            this.BT_Finished.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Finished.Location = new System.Drawing.Point(246, 147);
            this.BT_Finished.Name = "BT_Finished";
            this.BT_Finished.Size = new System.Drawing.Size(167, 47);
            this.BT_Finished.TabIndex = 1;
            this.BT_Finished.Text = "Finished";
            this.BT_Finished.UseVisualStyleBackColor = true;
            this.BT_Finished.Click += new System.EventHandler(this.BT_Finished_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "select category";
            // 
            // CMB_categorys
            // 
            this.CMB_categorys.FormattingEnabled = true;
            this.CMB_categorys.Location = new System.Drawing.Point(30, 89);
            this.CMB_categorys.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_categorys.Name = "CMB_categorys";
            this.CMB_categorys.Size = new System.Drawing.Size(143, 24);
            this.CMB_categorys.TabIndex = 68;
            // 
            // TB_BillsName
            // 
            this.TB_BillsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillsName.Location = new System.Drawing.Point(207, 79);
            this.TB_BillsName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_BillsName.Name = "TB_BillsName";
            this.TB_BillsName.Size = new System.Drawing.Size(141, 34);
            this.TB_BillsName.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Bills name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "payment date";
            // 
            // DT_BillsDate
            // 
            this.DT_BillsDate.AllowDrop = true;
            this.DT_BillsDate.CustomFormat = "\"mmmm yyyy\"";
            this.DT_BillsDate.Location = new System.Drawing.Point(561, 91);
            this.DT_BillsDate.Margin = new System.Windows.Forms.Padding(4);
            this.DT_BillsDate.Name = "DT_BillsDate";
            this.DT_BillsDate.Size = new System.Drawing.Size(141, 22);
            this.DT_BillsDate.TabIndex = 67;
            // 
            // TB_BillCost
            // 
            this.TB_BillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillCost.Location = new System.Drawing.Point(384, 83);
            this.TB_BillCost.Margin = new System.Windows.Forms.Padding(4);
            this.TB_BillCost.Name = "TB_BillCost";
            this.TB_BillCost.Size = new System.Drawing.Size(141, 34);
            this.TB_BillCost.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Bills Cost";
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 253);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CMB_categorys);
            this.Controls.Add(this.TB_BillsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DT_BillsDate);
            this.Controls.Add(this.TB_BillCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Finished);
            this.Name = "AddBillForm";
            this.Text = "AddBillForm";
            this.Load += new System.EventHandler(this.AddBillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Finished;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMB_categorys;
        private System.Windows.Forms.TextBox TB_BillsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_BillsDate;
        private System.Windows.Forms.TextBox TB_BillCost;
        private System.Windows.Forms.Label label3;
    }
}