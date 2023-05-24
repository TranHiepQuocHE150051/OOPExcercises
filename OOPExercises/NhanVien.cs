using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    public class NhanVien:CanBo
    {
        public NhanVien(string hoTen, int tuoi, string gioiTinh, string diaChi, string congviec) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            CongViec = congviec;
        }

        public string CongViec { get; set; }

        public override string ToString()
        {
            return "Nghe nghiep: Nhan vien" + "\n" + "Ten: " + this.HoTen + "\n" + "Tuoi: " + this.Tuoi + "\n" + "Gioi tinh: " + this.GioiTinh + "\n" + "Dia chi: " + this.DiaChi + "\n" + "Cong viec : " + this.CongViec;

        }
    }
}
