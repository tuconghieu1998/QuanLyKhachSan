using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class PhongDetail
    {
        int idPhong, idPhieuThue, tinhTrang;
        string ghiChu, ngayThue;
        List<Dictionary> dsKhachThue;

        public int IdPhong { get => idPhong; set => idPhong = value; }
        public int IdPhieuThue { get => idPhieuThue; set => idPhieuThue = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string NgayThue { get => ngayThue; set => ngayThue = value; }
        internal List<Dictionary> DsKhachThue { get => dsKhachThue; set => dsKhachThue = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public PhongDetail() { }


    }
}
