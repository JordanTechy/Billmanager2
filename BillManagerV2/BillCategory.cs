using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagerV2
{
   public class BillCategory
    {

        public string Categoryname { get; set; }

        public List<Bill> Categorybillslist = new List<Bill>();


        public BillCategory(string _name)
        {
            Categoryname = _name;
        }

        public void addBill(Bill _bill)
        {
            Categorybillslist.Add(_bill);
        }

        // return this categorys list of bills
        public List<Bill> getBillsList()
        {
            return Categorybillslist;
        }

    }
}
