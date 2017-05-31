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

        static DataTable mytable = new DataTable(); // mytable 

        const string ShowAll = "show all";

        public List<BillCategory> MainCatagoryslist = new List<BillCategory>();// catagory list

        public Main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTable_init();
            DemoCatagory();
        }

        private void myTable_init()
        {

            dataGridView1.DataSource = mytable;

            LB_catagorys.Items.Add(ShowAll);

            mytable.Columns.Add("Category", typeof(string));
            mytable.Columns.Add("Bill name", typeof(string));
            mytable.Columns.Add("bill cost", typeof(int));
            mytable.Columns.Add("dasste ", typeof(DateTime));

        }

        public void DemoCatagory()
        {
            BillCategory demo1 = new BillCategory("Demo1");
            BillCategory demo2 = new BillCategory("Demo2");

            demo1.addBill("car", 10, DateTime.Now.AddDays(3));
            demo1.addBill("room", 10, DateTime.Now.AddDays(3));
            demo1.addBill("groler", 10, DateTime.Now.AddDays(3));
            demo2.addBill("ninja", 10, DateTime.Now.AddDays(3));
            demo2.addBill("odd", 10, DateTime.Now.AddDays(3));
            demo2.addBill("strang", 10, DateTime.Now.AddDays(3));

            MainCatagoryslist.Add(demo1);
            MainCatagoryslist.Add(demo2);

            LB_catagorys.Items.Add(demo1.Categoryname);
            LB_catagorys.Items.Add(demo2.Categoryname);

            mytable.Clear();

            foreach (var b in demo1.Categorybillslist)
            {
                mytable.Rows.Add(demo1.Categoryname, b.BillName, b.WeeklyCost, b.PaymentDate);
            }

            updateTable(MainCatagoryslist);
        }

        public void updateTable(List<BillCategory> _catagoryList)
        {
            mytable.Clear();

            List<BillCategory> catagoryList = new List<BillCategory>();

            catagoryList = _catagoryList;

            foreach (var c in catagoryList)
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
                MainCatagoryslist.Add(new BillCategory(add_cat_form.CatagoryNameVal));

                LB_catagorys.Items.Clear();

                LB_catagorys.Items.Add(ShowAll);

                foreach (var c in MainCatagoryslist)
                {
                    LB_catagorys.Items.Add(c.Categoryname);
                }
            }
            updateTable(MainCatagoryslist);
        }

        private void BT_AddBill_Click(object sender, EventArgs e)
        {
            AddBillForm add_bill_form = new AddBillForm();

            add_bill_form.BillsCatagory = MainCatagoryslist;

            if (add_bill_form.ShowDialog() == DialogResult.OK)// if finished button pressed
            {
                foreach (BillCategory catagory in MainCatagoryslist)
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
            updateTable(MainCatagoryslist);
        }

        private void BT_printbillList_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var catagory in MainCatagoryslist)
            {
                if (catagory.Categorybillslist.Count == 0)
                {
                    textBox1.AppendText(catagory.Categoryname);
                }
                else
                {
                    foreach (var bill in catagory.Categorybillslist)
                    {
                        textBox1.AppendText(catagory.Categoryname + "\n\r" + bill.ToString() + "\n\r");
                    }
                }
            }
        }

        private void LB_catagorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BillCategory> selectedList = new List<BillCategory>();

            try
            {
                string SelectedItem = LB_catagorys.SelectedItem.ToString();
                if (SelectedItem == ShowAll.ToLower())
                {
                    updateTable(MainCatagoryslist);
                }
                else
                {
                    foreach (var item in MainCatagoryslist)
                    {
                        if (SelectedItem == item.Categoryname)
                        {
                            selectedList.Add(item);
                            updateTable(selectedList);
                        }
                    }
                }
            }
            catch (Exception)
            {
                updateTable(MainCatagoryslist);
            }
        }
    }
}
//textBox1.Text = add_bill_form.billsName + Convert.ToDouble(add_bill_form.billsCost) + add_bill_form.billsDate;




/*
 *              int caseSwitch = 5;

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


                textBox1.Font = new Font(textBox1.Font.FontFamily,8);

    CMB_categorys.Items.Add(c.Categoryname);
   CMB_categorys.SelectedIndex = 0;
   CMB_categorys.Items.Clear();
        CMB_categorys.Items.Add(c.Categoryname);
        CMB_categorys.SelectedIndex = 0;

 */

//https://www.youtube.com/watch?v=mjOp4jCTMGI

