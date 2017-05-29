using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillManagerV2
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTable_init();
            DemoCatagory();
        }

        static DataTable mytable = new DataTable(); // mytable 

        public List<BillCategory> BillsCategory = new List<BillCategory>();// catagory list

        private void myTable_init()
        {
            dataGridView1.DataSource = mytable;

            mytable.Columns.Add("Category", typeof(string));
            mytable.Columns.Add("Bill name", typeof(string));
            mytable.Columns.Add("bill cost", typeof(int));
            mytable.Columns.Add("dasste ", typeof(DateTime));

        }

        public void DemoCatagory()
        {
            BillCategory demo1 = new BillCategory("Demo1");

            // CMB_categorys.Items.Add(demo1.Categoryname);

            demo1.addBill("car", 10, DateTime.Now.AddDays(3));
            demo1.addBill("room", 10, DateTime.Now.AddDays(3));
            demo1.addBill("groler", 10, DateTime.Now.AddDays(3));

            mytable.Clear();

            foreach (var b in demo1.Categorybillslist)
            {
                mytable.Rows.Add(demo1.Categoryname, b.BillName, b.WeeklyCost, b.PaymentDate);
            }
        }

        public void updateTable()
        {
            mytable.Clear();

            foreach (var c in BillsCategory)
            {
                if (c.Categorybillslist.Count == 0)
                {
                    mytable.Rows.Add(c.Categoryname, null, null, null); // add new catagory without data
                }
                else
                {
                    foreach (var b in c.Categorybillslist)
                    {
                        mytable.Rows.Add(c.Categoryname, b.BillName, b.WeeklyCost, b.PaymentDate);
                    }

                }
            }
        }
        private void bt_addCategory_Click(object sender, EventArgs e)
        {
            AddCatagoryForm add_cat_form = new AddCatagoryForm();

            if (add_cat_form.ShowDialog() == DialogResult.OK)
            {
                BillsCategory.Add(new BillCategory(add_cat_form.CatNameVal));

                LB_catagorys.Items.Clear();

                foreach (var c in BillsCategory)
                {
                    LB_catagorys.Items.Add(c.Categoryname);
                }
            }
            updateTable();
        }

        private void BT_AddBill_Click(object sender, EventArgs e)
        {
            AddBillForm add_bill_form = new AddBillForm();

            add_bill_form.BillsCatagory = BillsCategory;

            if (add_bill_form.ShowDialog() == DialogResult.OK)// if finished button pressed
            {
                foreach (BillCategory catagory in BillsCategory)
                {
                    if (catagory.Categoryname == add_bill_form.selectedCatagory)
                    {
                        try
                        {
                            Convert.ToDouble(add_bill_form.billsCost);

                            catagory.addBill(add_bill_form.billsName, Convert.ToDouble(add_bill_form.billsCost), add_bill_form.billsDate);

                            textBox1.Text = catagory.getBillToString(add_bill_form.billsName);
                        }
                        catch (Exception)
                        {

                            textBox1.Text = "please input a number";
                        }
                    }
                }
            }
            updateTable();
        }




        private void BT_printbillList_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox1.Font = new Font(textBox1.Font.FontFamily,8);
            foreach (var c in BillsCategory)
            {
                if (c.Categorybillslist.Count == 0)
                {
                    textBox1.AppendText(c.Categoryname);
                }
                else
                {
                    foreach (var b in c.Categorybillslist)
                    {
                        textBox1.AppendText(c.Categoryname + "\n\r" + b.ToString() + "\n\r");
                    }

                }
            }

           
        }
    }
}
//textBox1.Text = add_bill_form.billsName + Convert.ToDouble(add_bill_form.billsCost) + add_bill_form.billsDate;




/*
    CMB_categorys.Items.Add(c.Categoryname);
   CMB_categorys.SelectedIndex = 0;
   CMB_categorys.Items.Clear();
        CMB_categorys.Items.Add(c.Categoryname);
        CMB_categorys.SelectedIndex = 0;

 */

//https://www.youtube.com/watch?v=mjOp4jCTMGI

