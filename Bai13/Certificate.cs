using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string CertificateName { get; set; }
        public int CertificateRank { get; set; }
        public DateTime CertificateDate { get; set; }

        public Certificate(int certificateId, string certificateName, int certificateRank, DateTime certificateDate)
        {
            CertificateId = certificateId;
            CertificateName = certificateName;
            CertificateRank = certificateRank;
            CertificateDate = certificateDate;
        }
        public override string ToString()
        {
            return  "CertificateID: " + this.CertificateId + "\n" + "CertificateName: " + this.CertificateName + "\n" + "CertificateRank: " + this.CertificateRank + "\n" + "CertificateDate: " + this.CertificateDate + "\n";

        }
    }
}
