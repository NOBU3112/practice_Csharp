using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class SoPhuc:SoThuc
    {
        public double SoAo {  get; set; }
        public SoPhuc(double gt, double soAo) : base(gt) 
        {
            this.SoAo = soAo;
        }
        public SoPhuc() : base() 
        {
            SoAo = 0;
        }
        public void inThongTin()
        {
            Console.WriteLine("Số phức:" + GiaTri + " + " + SoAo +"i");
        }
    }
}
