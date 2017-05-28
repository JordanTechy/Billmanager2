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
            BillCategory demo2 = new BillCategory("Demo2");
            BillsCategory.Add(demo1);
            BillsCategory.Add(demo2);

            // CMB_categorys.Items.Add(demo1.Categoryname);

            demo1.Categorybillslist.Add(new Bill("car", 10, DateTime.Now.AddDays(3)));
            demo1.Categorybillslist.Add(new Bill("room", 10, DateTime.Now.AddDays(3)));
            demo1.Categorybillslist.Add(new Bill("groler", 10, DateTime.Now.AddDays(3)));

            demo2.Categorybillslist.Add(new Bill("bag", 10, DateTime.Now.AddDays(3)));
            demo2.Categorybillslist.Add(new Bill("bud", 10, DateTime.Now.AddDays(3)));
            demo2.Categorybillslist.Add(new Bill("cheeclk", 10, DateTime.Now.AddDays(3)));

            mytable.Clear();

            foreach (var c in BillsCategory)
            {
           

                foreach (var b in c.Categorybillslist)
                {
                    mytable.Rows.Add(c.Categoryname, b.BillName, b.WeeklyCost, b.PaymentDate);
                }
            }
        }




        private void bt_addCategory_Click(object sender, EventArgs e)
        {
            AddCatagoryForm cat_form = new AddCatagoryForm();

            if (cat_form.ShowDialog() == DialogResult.OK)
            {
                BillsCategory.Add(new BillCategory(cat_form.CatNameVal));
               
                LB_catagorys.Items.Clear();
                foreach (var c in BillsCategory)
                {
                   
                    LB_catagorys.Items.Add(c.Categoryname);
                }
                    
                //textBox1.Text = cat_form.CatNameVal + Environment.NewLine + cat_form.CatIncomeVal;
            }



        }

      



        private void BT_AddBill_Click(object sender, EventArgs e)
        {
             AddBillForm bill_form = new AddBillForm();
             bill_form.BillsCatagory = this.BillsCategory;
            if (bill_form.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in BillsCategory)
                {
                    if (item.Categoryname == bill_form.selectedCatagory)
                    {

                        item.Categorybillslist.Add(new Bill(bill_form.billsName,Convert.ToDouble(bill_form.billsCost),bill_form.billsDate));
                        textBox1.Text = bill_form.billsName+Convert.ToDouble(bill_form.billsCost)+bill_form.billsDate;
                    }
                }
                
               
            }

            


        }

        /*
            CMB_categorys.Items.Add(c.Categoryname);
           CMB_categorys.SelectedIndex = 0;
           CMB_categorys.Items.Clear();
                CMB_categorys.Items.Add(c.Categoryname);
                CMB_categorys.SelectedIndex = 0;


         */






        //https://www.youtube.com/watch?v=mjOp4jCTMGI


    }
}
    
