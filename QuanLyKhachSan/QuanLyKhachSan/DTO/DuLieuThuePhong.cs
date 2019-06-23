using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class DuLieuThuePhong
    {
        int maPhieuThue, sl_Khach, sl_KhachBinhThuong, sl_KhachToiDa;
        DateTime ngayThue, ngayKetThuc;
        string tenPhong;
        float donGia, phuThuLoaiPhong, phuThuLoaiKhach;

        public int MaPhieuThue { get => maPhieuThue; set => maPhieuThue = value; }
        
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }      
        public float DonGia { get => donGia; set => donGia = value; }
        public float PhuThuLoaiPhong { get => phuThuLoaiPhong; set => phuThuLoaiPhong = value; }
        public float PhuThuLoaiKhach { get => phuThuLoaiKhach; set => phuThuLoaiKhach = value; }
        public int Sl_Khach { get => sl_Khach; set => sl_Khach = value; }
        public int Sl_KhachBinhThuong { get => sl_KhachBinhThuong; set => sl_KhachBinhThuong = value; }
        public int Sl_KhachToiDa { get => sl_KhachToiDa; set => sl_KhachToiDa = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }

        public DuLieuThuePhong() { }

        public DuLieuThuePhong(DataRow data)
        {
            this.MaPhieuThue = (int)data["ID"];
            this.NgayThue = (DateTime)data["NgayThue"];
            this.NgayKetThuc = (DateTime)data["NgayKetThuc"];
            this.DonGia = float.Parse(data["DonGia"].ToString());
            this.PhuThuLoaiPhong = float.Parse(data["PhuThu"].ToString());
            this.Sl_Khach = int.Parse(data["SL_Khach"].ToString());
            this.Sl_KhachBinhThuong = int.Parse(data["SL_KhachBinhThuong"].ToString());
            this.Sl_KhachToiDa = int.Parse(data["SL_KhachToiDa"].ToString());
            this.TenPhong = data["TenPhong"].ToString();
        }
    }
}
