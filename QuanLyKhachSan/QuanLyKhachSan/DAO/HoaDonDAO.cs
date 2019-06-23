using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class HoaDonDAO
    {
        public static int ThemHoaDon(string tenKhachHang, string DiaChi, float tongTien, int idNhanVien)
        {
            string query = string.Format("exec pro_insertHoaDon N'{0}', N'{1}', '{2}', '{3}'", tenKhachHang, DiaChi, tongTien, idNhanVien);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }

        public static int ThemChiTietHoaDon(int idHoaDon, int stt, ChiTietHoaDon ct)
        {
            string query = string.Format("exec pro_insertChiTietHoaDon '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", idHoaDon, stt, ct.MaPhieuThue, ct.SoNgay, ct.DonGia, ct.PhuThu, ct.Tien);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
