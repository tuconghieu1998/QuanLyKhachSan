using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Phong
    {
        int id, tinhTrang; //0: phòng trống, 1: đã thuê, -1: bị xóa
        string tenPhong, loaiPhong, ghiChu;

        public int Id { get => id; set => id = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public Phong() { }

        public Phong(DataRow row)
        {
            this.Id = int.Parse(row["ID"].ToString());
            this.TenPhong = row["TenPhong"].ToString();
            this.LoaiPhong = row["TenLoai"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
            this.TinhTrang = int.Parse(row["TinhTrang"].ToString());
        }
    }
}
