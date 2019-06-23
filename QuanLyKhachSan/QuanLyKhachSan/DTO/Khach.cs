using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Khach
    {
        int stt;
        string tenKhach, CMND, diaChi, loaiKhach;
        public int Stt { get => stt; set => stt = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiKhach { get => loaiKhach; set => loaiKhach = value; }

        public Khach() { }

        public Khach(DataRow row)
        {
            this.Stt = int.Parse(row["stt"].ToString());
            this.TenKhach = row["tenKhach"].ToString();
            this.CMND1 = row["CMND1"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.LoaiKhach = row["loaiKhach"].ToString();
        }
    }
}
