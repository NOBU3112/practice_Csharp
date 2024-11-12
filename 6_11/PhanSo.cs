using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set;}
        public PhanSo() 
        {
            MauSo = 1;
            TuSo = 0;
        }


        public PhanSo(int tuSo,int mauSo)
        {
            this.MauSo = mauSo;
            this.TuSo = tuSo;
        }

        public void inThongTin()
        {
            Console.WriteLine("Phân số:" + TuSo + "/" + MauSo);
        }
        static int timUCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b; 
                a = temp;
            }
            return Math.Abs(a);
        }

        public void ToiGian(ref PhanSo phanso)
        {
            int ucln = timUCLN(phanso.TuSo,phanso.MauSo);
            phanso.TuSo /= ucln;
            phanso.MauSo /= ucln;
            if(MauSo<0)
            {
                MauSo = -MauSo;
                TuSo = -TuSo;
            }
        }

        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            a.TuSo *= b.MauSo;
            b.TuSo *= a.MauSo;
            PhanSo c = new PhanSo(a.TuSo + b.TuSo, a.MauSo * b.MauSo);
            ToiGian(ref c);
            return c;
        }

        public PhanSo Tru(PhanSo a, PhanSo b)
        {
            a.TuSo *= b.MauSo;
            b.TuSo *= a.MauSo;
            PhanSo c = new PhanSo(a.TuSo - b.TuSo, a.MauSo * b.MauSo);
            ToiGian(ref c);
            return c;
        }
    }
}
