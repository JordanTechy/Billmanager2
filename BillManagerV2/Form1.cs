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
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd - MMM - yy";
            myTable_init();
        }

        static DataTable mytable = new DataTable(); // mytable 

        List<BillCategory> BillsCategory = new List<BillCategory>();// catagory list

        private void myTable_init()
        {
            dataGridView1.DataSource = mytable;

            mytable.Columns.Add("Category", typeof(string));
            mytable.Columns.Add("Bill name", typeof(string));
            mytable.Columns.Add("bill cost", typeof(int));
            mytable.Columns.Add("date ", typeof(DateTime));

            BillCategory demo1 = new BillCategory("Demo");

            BillsCategory.Add(demo1);

           // CMB_categorys.Items.Add(demo1.Categoryname);

            demo1.Categorybillslist.Add(new Bill("car", 10, DateTime.Now.AddDays(3)));
            demo1.Categorybillslist.Add(new Bill("room", 10, DateTime.Now.AddDays(3)));
            demo1.Categorybillslist.Add(new Bill("groler", 10, DateTime.Now.AddDays(3)));

            mytable.Clear();

            foreach (var c in BillsCategory)
            {
                CMB_categorys.Items.Add(c.Categoryname);
                CMB_categorys.SelectedIndex = 0;
                
                foreach (var b in c.Categorybillslist)
                {
                    mytable.Rows.Add(c.Categoryname, b.BillName, b.WeeklyCost, b.PaymentDate);
                }
            }
        }






        private void bt_Finished_Click(object sender, EventArgs e)
        {
            AddCatagoryForm cat_form = new AddCatagoryForm();
            if (cat_form.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = cat_form.CatNameVal + Environment.NewLine + cat_form.CatIncomeVal;
            }



        }








        //https://www.youtube.com/watch?v=mjOp4jCTMGI
    

    }
}
    
