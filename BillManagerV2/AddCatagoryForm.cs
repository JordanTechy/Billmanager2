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
        private bool _personToggle = false;

        private string _myNameVal;

        private double _personIncome;

        public AddCatagoryForm()
        {
            InitializeComponent();
        }
        private void AddCatagory_Load(object sender, EventArgs e)
        {
            TB_Income.Hide();
        }

        public string CatagoryNameVal
        {
            get { return _myNameVal; }
            set { _myNameVal = value; }
        }
        public bool personToggle
        {
            get { return _personToggle; }
            set { _personToggle = value; }
        }
        public double personIncome
        {
            get { return _personIncome; }
            set { _personIncome = value; }
        }

        private void bt_Finished_Click(object sender, EventArgs e)
        {
            if (TB_AddCatagory.Text.ToString() != "")
            {
                if (_personToggle == true)
                {
                    try
                    {
                        double income;

                        income = Convert.ToDouble(TB_Income.Text.ToString());

                        CatagoryNameVal = TB_AddCatagory.Text;

                        return;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input a number for person income");
                        this.DialogResult = DialogResult.None;
                    }
                }

                else if (TB_AddCatagory.Text.ToString() != null)
                {
                    CatagoryNameVal = TB_AddCatagory.Text;

                }
                else
                {
                    MessageBox.Show("Please input a Name for the person");
                    this.DialogResult = DialogResult.None;
                }

            }
            else
            {
                MessageBox.Show("Please input a Name for the catagory");
                this.DialogResult = DialogResult.None;
            }



        }
    


    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        _personToggle = !_personToggle;
        if (_personToggle == true)
        {
            TB_Income.Show();
        }
        else if (_personToggle == false)
        {
            TB_Income.Hide();
        }
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
