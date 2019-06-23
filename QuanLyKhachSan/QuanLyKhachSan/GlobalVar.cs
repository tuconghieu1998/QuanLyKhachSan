using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class GlobalVar
    {
        public static int idTaiKhoan = 1;
        //biến được new tại form1.cs hàm Form1.Load()
        public static List<ChiTietHoaDon> listChiTietHD;
        //dùng để reload datagridview
        public static List<ChiTietHoaDon> tmp;
        public static float TongTien = 0;
    }
}
