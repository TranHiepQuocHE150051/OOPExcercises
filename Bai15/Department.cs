using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Student> Students { get; set; }

        public Department(string departmentName, List<Student> students)
        {
            DepartmentName = departmentName;
            Students = students;
        }
    }
}
