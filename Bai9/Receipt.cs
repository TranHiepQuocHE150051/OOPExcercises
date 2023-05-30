using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class Receipt
    {
        public FamilyInfo Customer { get; set; }
        public int OldElectricNumber { get; set; }
        public int NewElectricNumber { get; set; }
        public decimal PaidAmount { get; set; }

        public Receipt(FamilyInfo customer, int oldElectricNumber, int newElectricNumber, decimal paidAmount)
        {
            Customer = customer;
            OldElectricNumber = oldElectricNumber;
            NewElectricNumber = newElectricNumber;
            PaidAmount = paidAmount;
        }
    }
}
