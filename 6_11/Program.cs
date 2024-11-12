using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            MonAn ma = new MonAn();
            SoPhuc sp = new SoPhuc();
            PhanSo ps = new PhanSo();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("1 - Nhập món ăn");
                Console.WriteLine("2 - Nhập số phức");
                Console.WriteLine("3 - Nhập phân số");
                Console.WriteLine("4 - In danh sách thông tin món ăn, số phức, phân số");
                Console.WriteLine("5 - Thoát");
                Console.WriteLine("Lựa chọn của bạn (1->5):");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Write("Nhập vào tên món ăn: ");
                            ma.TenMonAn = Console.ReadLine();
                            Console.Write("\nNhập vào giá bán: ");
                            ma.GiaBan = int.Parse(Console.ReadLine());
                            Console.Write("\nGiới thiệu món ăn: ");
                            ma.GioiThieu = Console.ReadLine();
                            Console.Write("\nNhập vào nguyên liệu chính của món ăn: ");
                            ma.NguyenLieuChinh = Console.ReadLine();
                            Console.WriteLine("Món ăn bạn vừa nhập:");
                            ma.inThongTin();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhập vào phần thực: ");
                            sp.GiaTri = double.Parse(Console.ReadLine());
                            Console.Write("\nNhập vào phần ảo: ");
                            sp.SoAo = double.Parse(Console.ReadLine());
                            Console.WriteLine("Số phức bạn vừa nhập là: " + sp.GiaTri + " + " + sp.SoAo + "i");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập vào tử số: ");
                            ps.TuSo = int.Parse(Console.ReadLine());
                            do
                            {
                                Console.Write("\nNhập vào mẫu số(!=0): ");
                                ps.MauSo = int.Parse(Console.ReadLine());
                            } while (ps.MauSo == 0);
                            Console.WriteLine("Phân số bạn vừa nhập la: " + ps.TuSo + "/" + ps.MauSo);
                            break;
                        }
                    case 4:
                        {
                            ma.inThongTin();
                            sp.inThongTin();
                            ps.inThongTin();
                            break;
                        }
                    case 5:
                        {
                            check = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Bạn nhập sai!");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            }

























            #region Class MonAn
            //Class MonAn
            MonAn monAn1 = new MonAn("Phở bò", 10, "có phở", "phở");
            monAn1.inThongTin();
            Console.WriteLine("-----------------------------");
            #endregion
            #region Class SoThuc
            //Class SoThuc
            SoThuc number1 = new SoThuc(-1.4);
            Console.WriteLine(number1.GiaTri);
            Console.WriteLine(number1.LaSoDuong);
            number1.GiaTri = 3;
            Console.WriteLine(number1.GiaTri);
            Console.WriteLine(number1.LaSoDuong);
            Console.WriteLine();

            SoThuc numberMax = new SoThuc(0);
            SoThuc number2 = new SoThuc(4);
            SoThuc number3 = new SoThuc(2);
            number1.GiaTri = 1;
            numberMax = numberMax.TimMax(number1, number2, number3);
            Console.WriteLine($"Số thực lớn nhất trong 3 số {number1.GiaTri}, {number2.GiaTri}, {number3.GiaTri} là {numberMax.GiaTri}");
            Console.WriteLine();

            Console.WriteLine("Nhập vào n:");
            int cn = int.Parse(Console.ReadLine());
            double kq = numberMax.TinhCanBacN(cn);
            Console.WriteLine($"Căn bậc {cn} của {numberMax.GiaTri} là {kq} ");
            Console.WriteLine("------------------------------------------------");
            #endregion
            #region Class Nguoi
            // Class Nguoi
            DateTime day = new DateTime(2003, 12, 31);
            Nguoi nguoi1 = new Nguoi(1, " Nguyen Tuan Dat DAS", day);
            Console.WriteLine($"nguoi1 có họ là {nguoi1.Ho}, đệm là {nguoi1.Dem}, tên là {nguoi1.Ten}");
            nguoi1.InThongTin();
            Console.WriteLine();

            Nguoi nguoi2 = new Nguoi();
            Console.WriteLine("Nhập vào mã số:");
            nguoi2.MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào họ tên:");
            nguoi2.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập vào ngày sinh(tháng/ngày/năm):");
            nguoi2.NgaySinh = DateTime.Parse(Console.ReadLine());
            nguoi2.InThongTin();
            Console.WriteLine(nguoi2.Ho);
            #endregion
            #region Class PhanSo
            PhanSo ps1 = new PhanSo(3,4);
            PhanSo ps2 = new PhanSo();
            Console.WriteLine("Nhap tu so PhanSo2:");
            ps2.TuSo = int.Parse(Console.ReadLine());

            #endregion
        }
    }
}
