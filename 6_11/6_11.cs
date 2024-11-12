using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class _6_11
    {
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
            int n = int.Parse(Console.ReadLine());
        double kq = numberMax.TinhCanBacN(n);
        Console.WriteLine($"Căn bậc {n} của {numberMax.GiaTri} là {kq} ");
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

            #endregion
    }
}
