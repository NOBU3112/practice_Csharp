using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    public class SoThuc
    {
        private double giaTri;
        public bool LaSoDuong { get; private set; }
        public double GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; LaSoDuong = giaTri > 0; }
        }

        public SoThuc()
        {
            giaTri = 0;
            LaSoDuong = false;
        }
        public SoThuc(double gt) 
        {
            giaTri = gt;
            LaSoDuong = giaTri > 0;
        }
        public SoThuc TimMax(SoThuc a,SoThuc b, SoThuc c)
        {
            double max = a.giaTri;
            if(max < b.giaTri)
                max = b.giaTri;
            if(max < c.giaTri)
                max = c.giaTri;
            return new SoThuc(max);
        }

        public double TinhCanBacN(int n)
        {
            return Math.Pow(GiaTri ,1.0/n);
        }
    }
}
