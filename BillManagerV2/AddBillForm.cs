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
    public partial class AddBillForm : Form
    {
        public AddBillForm()
        {
            InitializeComponent();
        }
       public List<BillCategory> BillsCatagory = new List<BillCategory>();


        private void AddBillForm_Load(object sender, EventArgs e)
        {
            DT_BillsDate.Format = DateTimePickerFormat.Custom;
            DT_BillsDate.CustomFormat = "dd - MMM - yy";

                CMB_categorys.Items.Clear();

                foreach (var c in BillsCatagory)
                {
                     CMB_categorys.Items.Add(c.Categoryname);
                     CMB_categorys.SelectedIndex = 0;
                }
        }
        private string _selectedCatagory;
        private string _billsName;
        private string _billsCost;
        private DateTime _billsDate;

        public string selectedCatagory
        {
            get { return _selectedCatagory; }
            set { _selectedCatagory = value; }
        }
        public string billsName
        {
            get { return _billsName; }
            set { _billsName = value; }
        }
        public string billsCost
        {
            get { return _billsCost; }
            set { _billsCost = value; }
        }
        public DateTime billsDate
        {
            get { return _billsDate; }
            set { _billsDate = value; }
        }
        
        private void BT_Finished_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCatagory = CMB_categorys.SelectedItem.ToString();
                billsName = TB_BillsName.Text;
                billsCost = TB_BillCost.Text;
                billsDate = DT_BillsDate.Value;
            }
            catch (Exception)
            {
                this.Close();
            }
        
        }
    }
}
