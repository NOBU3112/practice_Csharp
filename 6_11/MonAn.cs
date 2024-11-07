using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class MonAn
    {
        public String TenMonAn { get; set; }
        public int GiaBan { get; set; }
        public String GioiThieu { get; set; }
        public String NguyenLieuChinh { get; set; }

        public MonAn (String tenMonAn, int giaBan, String gioiThieu, String nguyenLieuChinh)
        {
            TenMonAn = tenMonAn;
            GiaBan = giaBan;
            GioiThieu = gioiThieu;
            NguyenLieuChinh = nguyenLieuChinh;
        }

        public void inThongTin()
        {
            Console.WriteLine("Món {0},{1}, được làm từ nguyên liệu chính {2}",TenMonAn,GioiThieu,NguyenLieuChinh);
        }



    }
}
