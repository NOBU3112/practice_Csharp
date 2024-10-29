using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Nhập số lượng học sinh
            int soLuongHS;
            Console.WriteLine("Nhập số lượng học sinh trong lơp: ");
            soLuongHS = int.Parse(Console.ReadLine());
            while (soLuongHS <= 0)
            {
                Console.WriteLine("Số lượng học sinh phải là số nguyên dương");
                Console.WriteLine("\nNhập lại số lượng học sinh: ");
                soLuongHS = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Nhập điểm của từng học sinh
            float tong = 0,diem;
            for (int i = 1; i <= soLuongHS; i++)
            {
                Console.WriteLine($"Nhập điểm trung bình của hoc sinh thứ {i}:");
                diem = float.Parse(Console.ReadLine());
                while (diem<0 || diem>10)
                {
                    Console.WriteLine("Điểm học sinh phải trong khoảng 0-10");
                    Console.WriteLine($"Nhập lại điểm trung bình của hoc sinh thứ {diem}:");
                    diem = float.Parse(Console.ReadLine());
                }
                tong += diem;
            }
            Console.WriteLine();

            //Tính điểm trung bình và xác định xếp loại
            float dtb = tong / soLuongHS;
            Console.WriteLine("Điểm trung bình của cả lớp là :" + dtb);
            if (dtb >= 8.5)
                Console.WriteLine("Lớp xếp loại Xuất sắc");
            else if (dtb >= 7.0)
                Console.WriteLine("Lớp xếp loại Giỏi");
            else if (dtb >= 5.5)
                Console.WriteLine("Lớp xếp loại Khá");
            else if (dtb >= 4.0)
                Console.WriteLine("Lớp xếp loại Trung Bình");
            else
                Console.WriteLine("Lớp xếp loại Yếu");
            Console.WriteLine();

            //Sử dụng toán tử 3 ngôi 
            String xetLop = (dtb >= 5.0) ? "Lớp đã đạt yêu cầu" : "Lớp không đạt yêu cầu";
            Console.WriteLine(xetLop);
            Console.ReadKey();
        }
    }
}
