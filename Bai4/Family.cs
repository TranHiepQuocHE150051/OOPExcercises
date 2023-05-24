using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Family
    {
        public int MembersNo { get; set; }
        public int ApartmentNo { get; set; }
        public List<Person> MembersInfo { get; set; }

        public Family(int membersNo, int apartmentNo, List<Person> membersInfo)
        {
            MembersNo = membersNo;
            ApartmentNo = apartmentNo;
            MembersInfo = membersInfo;
        }
    }
}
