

using OOPExercises;
using System.Xml.Linq;

QLCB qlcb = new QLCB();
while (true)
{
    Console.WriteLine("Quan Ly Can Bo");
    Console.WriteLine(" 1: Them moi can bo");
    Console.WriteLine(" 2: Tim kiem theo ten: ");
    Console.WriteLine(" 3: Danh sach can bo : ");
    Console.WriteLine(" 4: Thoat: ");
    String choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("a: Them cong nhan");
                Console.WriteLine("b: Them ky su");
                Console.WriteLine("c: Them nhan vien");
                String type = Console.ReadLine();
                switch (type)
                {
                    case "a":
                        {
                            Console.WriteLine("Ho va ten: ");
                            String hoten = Console.ReadLine();
                            Console.WriteLine("Tuoi :");
                            int tuoi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Gioi tinh: ");                      
                            String gioitinh = Console.ReadLine();
                            Console.WriteLine("Dia chi : ");
                            String diachi = Console.ReadLine();
                            Console.WriteLine("Bac : ");
                            int bac = Convert.ToInt32(Console.ReadLine());
                            CanBo congnhan = new CongNhan(hoten, tuoi, gioitinh, diachi, bac);
                            qlcb.ThemCanBo(congnhan);
                            Console.WriteLine("Them can bo thanh cong.");
                            break;

                        }
                    case "b":
                        {
                            Console.WriteLine("Ho va ten: ");
                            String hoten = Console.ReadLine();
                            Console.WriteLine("Tuoi :");
                            int tuoi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Gioi tinh: ");
                            String gioitinh = Console.ReadLine();
                            Console.WriteLine("Dia chi : ");
                            String diachi = Console.ReadLine();
                            Console.WriteLine("Nganh dao tao : ");
                            String nganhdaotao = Console.ReadLine();
                            CanBo kysu = new KySu(hoten, tuoi, gioitinh, diachi, nganhdaotao);
                            qlcb.ThemCanBo(kysu);
                            Console.WriteLine("Them can bo thanh cong.");
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine("Ho va ten: ");
                            String hoten = Console.ReadLine();
                            Console.WriteLine("Tuoi :");
                            int tuoi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Gioi tinh: ");
                            String gioitinh = Console.ReadLine();
                            Console.WriteLine("Dia chi : ");
                            String diachi = Console.ReadLine();
                            Console.WriteLine("Cong viec : ");
                            String congviec = Console.ReadLine();
                            CanBo nhanvien = new NhanVien(hoten, tuoi, gioitinh, diachi, congviec);
                            qlcb.ThemCanBo(nhanvien);
                            Console.WriteLine("Them can bo thanh cong.");
                            break;
                        }
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
                break;
            }
        case "2":
            {
                Console.WriteLine("Nhap ten can tim: ");
                String name = Console.ReadLine();
                Console.WriteLine("=====Danh sach can bo====");
                List<CanBo>danhsachcanbo =qlcb.TimKiemTheoTen(name);
                foreach(var canbo in danhsachcanbo)
                {
                    Console.WriteLine(canbo.ToString());
                }
                break;
            }
        case "3":
            {
                Console.WriteLine("=====Danh sach can bo====");
                List<CanBo> danhsachcanbo = qlcb.LayDanhSachCanBo();
                foreach (var canbo in danhsachcanbo)
                {
                    Console.WriteLine("--- Can bo ---");
                    Console.WriteLine(canbo.ToString());
                }
                break;
            }
        case "4":
            {
                return;
            }
        default:
            Console.WriteLine("Hay nhap dung format !!!");
            continue;
    }

}