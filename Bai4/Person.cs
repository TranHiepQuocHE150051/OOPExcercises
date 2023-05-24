using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string IdentityNumber { get; set; }

        public Person(string name,int age, string job, string identityNumber)
        {
            Name = name;
            Age = age;
            Job = job;
            IdentityNumber = identityNumber;
        }
    }
}
