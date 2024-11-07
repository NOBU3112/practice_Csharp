﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class Nguoi
    {
        public int MaSo {  get; set; }
        private string hoTen;
        public DateTime NgaySinh { get; set; }
        public string Ho {  get; private set; }
        public string Dem { get; private set; }
        public string Ten { get; private set; }
        public string HoTen
        {
            get { return hoTen; }
            set 
            {
                hoTen = value.Trim();
                TachTen(hoTen);
            }
        }

        public void InThongTin()
        {
            Console.WriteLine($"{MaSo} có tên là {HoTen} sinh ngày {NgaySinh.ToString("dd/MM/yyyy")}");
        }

        public Nguoi(int maSo, string ht, DateTime ngaySinh) 
        {
            MaSo = maSo;
            hoTen = ht.Trim();
            NgaySinh = ngaySinh;
            TachTen(hoTen);
        }

        public Nguoi()
        {
            Console.WriteLine("Nhập vào mã số:");
            MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào họ tên:");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập vào ngày sinh(tháng/ngày/năm):");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            TachTen(HoTen);

        }

        public void TachTen(string ht)
        {
            string[] ds = ht.Split(' ');
            Ho = ds[0];
            Ten = ds[ds.Length - 1];
            ds[0] = "";
            ds[ds.Length - 1] = "";
            Dem = string.Join(" ", ds).Trim();
        }
    }
}