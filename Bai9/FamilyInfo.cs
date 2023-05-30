using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class FamilyInfo
    {
        public string OwnerName { get; set; }
        public int AddressNumber { get; set; }
        public int ElectricMeterCode { get; set; }

        public FamilyInfo(string ownerName, int addressNumber, int electricMeterCode)
        {
            OwnerName = ownerName;
            AddressNumber = addressNumber;
            ElectricMeterCode = electricMeterCode;
        }
        public override string ToString()
        {
            return "FamilyInfo :" + "\n" + "Owner: " + this.OwnerName + "\n" + " Address number: " + this.AddressNumber + "\n" + "Electric meter code: " + this.ElectricMeterCode;
        }
    }
}
