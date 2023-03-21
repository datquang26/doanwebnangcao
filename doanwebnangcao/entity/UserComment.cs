using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanwebnangcao.entity
{
    public class UserComment
    {
        public int MaComment { get; set; }
        public int ID { get; set; }
        public string FullName { get; set; }
        public string TextComment { get; set; }
        public int MaSanPham { get; set; }

        public string Anh1 { get; set; }

    }
}