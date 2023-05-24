using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    public class QLCB
    {
        private List<CanBo> danhsachcanbo;

        public QLCB()
        {
            this.danhsachcanbo = new List<CanBo>();
        }

        public void ThemCanBo(CanBo canbo)
        {
            this.danhsachcanbo.Add(canbo);
        }
        public List<CanBo> TimKiemTheoTen (string name)
        {
            return this.danhsachcanbo.Where(a => a.HoTen.Contains(name)).ToList();
        }
        public List<CanBo> LayDanhSachCanBo()
        {
            return this.danhsachcanbo;
        }
    }
}
