using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    public class KySu: CanBo
    {
        public string NganhDaoTao { get; set; }
        public KySu(string hoTen, int tuoi, string gioiTinh, string diaChi,string nganhDaoTao) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            NganhDaoTao = nganhDaoTao;
        }

        public override string ToString()
        {
            return "Nghe nghiep: Ky su" + "\n" + "Ten: " + this.HoTen + "\n" + "Tuoi: " + this.Tuoi + "\n" + "Gioi tinh: " + this.GioiTinh + "\n" + "Dia chi: " + this.DiaChi + "\n" + "Nganh dao tao: " + this.NganhDaoTao;

        }
    }
}
