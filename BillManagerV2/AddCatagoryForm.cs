using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillManagerV2
{
    public partial class AddCatagoryForm : Form
    {
        public AddCatagoryForm()
        {
            InitializeComponent();
        }

        private string _myNameVal;
        private string _myIncomeVal;

        public string CatNameVal
        {
            get { return _myNameVal; }
            set { _myNameVal = value; }
        }

        public string CatIncomeVal
        {
            get { return _myIncomeVal; }
            set { _myIncomeVal = value; }
        }



        private void bt_addCategory_Click(object sender, EventArgs e)
        {
            CatNameVal = TB_AddCatagory.Text;
            CatIncomeVal = TB_AddIncome.Text;
        }

        private void AddCatagory_Load(object sender, EventArgs e)
        {

        }
    }
}


/*
 * 
 *tips for making the data to another form
 * set up the button to show dialog result ok
 * 
 

private string _myVal;

public string myVal
{
    get { return _myVal; }
    set { _myVal = value; }
}

in button click make myVal=the text box

    on other form do 

    in the button click

       newform2 form2 = new newform2();
            if (cat_form.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = cat_form.myVal;
            }












 */
