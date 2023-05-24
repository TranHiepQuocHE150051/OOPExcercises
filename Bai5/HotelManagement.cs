using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class HotelManagement
    {
        private List<Customer> customers;

        public HotelManagement()
        {
            this.customers = new List<Customer>();
        }
        public void AddNewCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }
        public void RemoveCustomer(string identityNumber)
        {
            var customer = this.customers.FirstOrDefault(x => x.IdentityNumber.Equals(identityNumber));
            if(customer != null)
            {
                this.customers.Remove(customer);
            }
            else
            {
                Console.WriteLine("Customer not existed");
            }
        }
        public int CalculateMoney(string identityNumber)
        {
            var customer = this.customers.Where(c => c.IdentityNumber.Equals(identityNumber)).FirstOrDefault();
            if (customer != null)
            {
                return customer.RentDays * customer.Room.Price;
            }
            return 0;
        }
    }
}
