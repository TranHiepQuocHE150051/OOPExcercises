using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    public class CanBo
    {
        

        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public CanBo(string hoTen, int tuoi, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
        
        
    }
}
