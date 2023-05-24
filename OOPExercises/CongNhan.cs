using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    public class CongNhan : CanBo
    {
        public int Bac { get; set; }
        public CongNhan(string hoTen, int tuoi, string gioiTinh, string diaChi,int bac) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            Bac = bac;
        }

        public override string ToString() {
            return "Nghe nghiep: Cong nhan" + "\n" + "Ten: " + this.HoTen + "\n" + "Tuoi: " + this.Tuoi + "\n" + "Gioi tinh: " + this.GioiTinh + "\n" + "Dia chi: " + this.DiaChi + "\n" + "Bac: " + this.Bac;

        }

    }
}
