using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagerV2
{
    
    
    public class Bill
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
                "\n\r" + "\n\r" +
                "Bill name is: {0}  " + "\n\r" + "\n\r" +
                "cost pw is : {1}  " + "\n\r" + "\n\r" +
                "date is : {2} " + "\n\r" + "\n\r",

           this.BillName, this.WeeklyCost, date);

        }
    }
}
