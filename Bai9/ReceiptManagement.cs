using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class ReceiptManagement
    {
        private List<FamilyInfo> customerList;
        private List<Receipt> receipts;

        public ReceiptManagement()
        {
            customerList = new List<FamilyInfo>();
            receipts = new List<Receipt>();
        }
        public List<FamilyInfo> CustomerList()
        {
            return this.customerList;
        }
        public void AddCustomer(FamilyInfo family)
        {
            this.customerList.Add(family);
        }
        public void DeleteCustomer(int electricMeterCode)
        {
            var customer = this.customerList.Where(c => c.ElectricMeterCode == electricMeterCode).SingleOrDefault();
            if (customer != null)
            {
                this.customerList.Remove(customer);
                Console.WriteLine("Delete success");
            }
            else
            {
                Console.WriteLine("Customer not exist");
            }
        }
        public void UpdateCustomer(int electricMeterCode, string newName, int newAddress)
        {
            var customer = this.customerList.Where(c => c.ElectricMeterCode == electricMeterCode).SingleOrDefault();
            if (customer != null)
            {
               customer.OwnerName = newName;
                customer.AddressNumber = newAddress;
                Console.WriteLine("Update success");
            }
            else
            {
                Console.WriteLine("Customer not exist");
            }
        }
        public decimal CalculateMoney(int electricMeterCode,int oldNumber , int newNumber)
        {
            decimal money = 0;
            var customer = this.customerList.Where(c => c.ElectricMeterCode == electricMeterCode).SingleOrDefault();
            if (customer != null)
            {
                 money = (newNumber - oldNumber) * 5;

                this.receipts.Add(new Receipt(customer, oldNumber, newNumber,money));
                return money;
            }
            else
            {
                Console.WriteLine("Customer not exist");
                return money;
            }
        }

    }
}
