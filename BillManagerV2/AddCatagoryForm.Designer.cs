﻿namespace BillManagerV2
{
    partial class AddCatagoryForm
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
            this.TB_AddCatagory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Finished = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TB_Income = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_AddCatagory
            // 
            this.TB_AddCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_AddCatagory.Location = new System.Drawing.Point(13, 64);
            this.TB_AddCatagory.Margin = new System.Windows.Forms.Padding(4);
            this.TB_AddCatagory.Name = "TB_AddCatagory";
            this.TB_AddCatagory.Size = new System.Drawing.Size(159, 34);
            this.TB_AddCatagory.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "category name";
            // 
            // bt_Finished
            // 
            this.bt_Finished.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Finished.Location = new System.Drawing.Point(13, 174);
            this.bt_Finished.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Finished.Name = "bt_Finished";
            this.bt_Finished.Size = new System.Drawing.Size(161, 41);
            this.bt_Finished.TabIndex = 61;
            this.bt_Finished.Text = "Finished";
            this.bt_Finished.UseVisualStyleBackColor = true;
            this.bt_Finished.Click += new System.EventHandler(this.bt_addCategory_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "is person";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TB_Income
            // 
            this.TB_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Income.Location = new System.Drawing.Point(13, 132);
            this.TB_Income.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Income.Name = "TB_Income";
            this.TB_Income.Size = new System.Drawing.Size(159, 34);
            this.TB_Income.TabIndex = 63;
            // 
            // AddCatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 255);
            this.Controls.Add(this.TB_Income);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt_Finished);
            this.Controls.Add(this.TB_AddCatagory);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCatagoryForm";
            this.Text = "AddCatagory";
            this.Load += new System.EventHandler(this.AddCatagory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Finished;
        public System.Windows.Forms.TextBox TB_AddCatagory;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox TB_Income;
    }
}