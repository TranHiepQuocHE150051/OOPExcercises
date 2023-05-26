using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Employee_type { get; set; }
        public int Employee_count { get; set; }
        public List<Certificate> Certificates { get; set; }

        public Employee(int id, string fullName, DateTime birthDay, string phone, string email, int employee_type, int employee_count, List<Certificate> certificates)
        {
            Id = id;
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Employee_type = employee_type;
            Employee_count = employee_count;
            Certificates = certificates;
        }

        public Employee(string fullName, DateTime birthDay, string phone, string email)
        {
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
        }

        public virtual string ShowInfo()
        {
            return "Employee Info " + "\n" + "Id: " + this.Id + "\n" + "Full Name: " + this.FullName + "\n" + "Date of birth: " + this.BirthDay + "\n" + "Phone: " + this.Phone + "\n" + "Email: " + this.Email;
        }
    }
}
