using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class ChiTietHoaDon
    {
        int maPhieuThue, soNgay;
        float donGia, phuThu, tien;
        string tenPhong;

        public int MaPhieuThue { get => maPhieuThue; set => maPhieuThue = value; }
        public int SoNgay { get => soNgay; set => soNgay = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float PhuThu { get => phuThu; set => phuThu = value; }
        public float Tien { get => tien; set => tien = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }

        public ChiTietHoaDon() { }
    }
}
