using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanwebnangcao.entity
{
    public class GioHang
    {
        public int MaGioHang { get; set; }
        public int MaSanPham { get; set; }
        public int ID { get; set; }
        public int SoLuong { get; set; }
         public string TenSanPham { get; set; }

        public int GiaTien { get; set; }

        public string Anh1 { get; set; }

        public string Anh2 { get; set; }

        public string TongTien { get; set; }

        public double ThanhTien { get; set; }


    }
}