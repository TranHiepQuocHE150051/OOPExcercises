using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement()
        {
            this.employees = new List<Employee>();
        }
        public List<Employee> GetAllEmployees()
        {
            return this.employees;
        }
        public void AddNewEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }
        public void UpdateEmployee(int employeeId, Employee newEmployee)
        {
            var employee=this.employees.Where(e => e.Id == employeeId).FirstOrDefault();
            employee.FullName = newEmployee.FullName;
            employee.BirthDay = newEmployee.BirthDay;
            employee.Phone = newEmployee.Phone;
            employee.Email = newEmployee.Email;
            
        }
        public void DeleteEmployee(int employeeId)
        {
            var employee = this.employees.Where(e => e.Id == employeeId).FirstOrDefault();
            this.employees.Remove(employee);
        }

        public bool CheckEmployeeExist(int employeeId)
        {
            var employee = this.employees.Where(e => e.Id == employeeId).FirstOrDefault();
            if (employee == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Employee> FindByEmployeeType(int type)
        {
            return this.employees.Where(e => e.Employee_type == type).ToList();
        }
    }
}
