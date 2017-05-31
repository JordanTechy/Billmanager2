using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagerV2
{
    public class BillCategory
    {
        public BillCategory(string _name, double income = 0)
        {
            _Categoryname = _name;
            _income = income;
        }

        private string _Categoryname;

        public string Categoryname
        {
            get { return _Categoryname; }
        }

        private double _income;

        public double income
        {
            get { return _income; }
        }

        private List<Bill> _Categorybillslist = new List<Bill>();

        public List<Bill> Categorybillslist
        {
            get { return _Categorybillslist; }
            set { _Categorybillslist = value; }
        }
        // return this categorys list of bills

        public string getBillToString(string _billName)
        {
            string catname;
            foreach (Bill item in _Categorybillslist)
            {
                if (item.BillName == _billName)
                {
                    catname = "Catagory = " + Categoryname + "\n\r" + item.ToString();

                    return catname;
                }
            }
            return "bill doesent exist";
        }


        public void addBill(string _BillName, double _cost, DateTime _PaymentDate)
        {
            _Categorybillslist.Add(new Bill(_BillName, _cost, _PaymentDate));
        }

        public struct Bill
        {
            public string BillName { get; set; }
            public double WeeklyCost { get; set; }
            public DateTime PaymentDate { get; set; }

            public Bill(string _BillName, double _cost, DateTime _PaymentDate)
            {
                BillName = _BillName;
                WeeklyCost = _cost;
                PaymentDate = _PaymentDate;
            }

            public override string ToString()
            {
                string date = this.PaymentDate.ToString();

                return String.Format(
                    "\n\r" +
                    "Bill name is: {0}  " + "\n\r" + "\n\r" +
                    "cost pw is : {1}  " + "\n\r" + "\n\r" +
                    "date is : {2} " + "\n\r" + "\n\r",

                    BillName, WeeklyCost, date);
            }
        }


    }
    // BILL STRUCTURE
}
