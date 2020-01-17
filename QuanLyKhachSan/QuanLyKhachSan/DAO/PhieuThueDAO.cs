using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class PhieuThueDAO
    {
        //trả về id phiếu thuê khi thêm thành công
        public static int ThemPhieuThue(int idPhong, string ngayThue, int idNhanVien)
        {
            string query = string.Format("exec pro_insertPhieuThue '{0}', '{1}', '{2}'", idPhong, ngayThue, idNhanVien);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }

        public static int ThemChiTietPhieuThue(int idPhieuThue, Khach khach)
        {
            int idLoaiKhach = LoaiKhachDAO.getIDLoaiKhach(khach.LoaiKhach);
            string query = string.Format("exec pro_insertChiTietPhieuThue '{0}', '{1}', N'{2}', '{3}', N'{4}', N'{5}'", idPhieuThue, khach.Stt, khach.TenKhach, idLoaiKhach, khach.CMND1, khach.DiaChi);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static int LayPhieuThueHienTaiCuaPhong(int idPhong)//xét 
        {
            string query = string.Format("exec pro_getIDPhieuThueHienTai '{0}'", idPhong);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }

        public static int CapNhapPhieuThueKhiTraPhong(int idPhieuThue, string ngayKetThuc)
        {
            string query = string.Format("exec pro_updatePhieuThueKhiTraPhong '{0}', '{1}'", idPhieuThue, ngayKetThuc);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static int LaySoNgayThuePhong(int idPhieuThue)
        {
            string query = string.Format("exec pro_getThoiGianThuePhong '{0}'", idPhieuThue);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DateTime ngayThue = (DateTime)dt.Rows[0]["NgayThue"];
                DateTime ngayKetThuc = (DateTime)dt.Rows[0]["NgayKetThuc"];

                TimeSpan totaldays = ngayKetThuc.Subtract(ngayThue);
                return (int)Math.Ceiling(totaldays.TotalDays);
            }
            return -1;
        }

        public static DataTable LayDuLieuThuePhong(int idPhieuThue)
        {
            string query = string.Format("exec pro_LayDuLieuThuePhong '{0}'", idPhieuThue);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static float LayPhuThuLoaiKhachCaoNhatTheoPhieuThue(int idPhieuThue)
        {
            string query = string.Format("exec pro_LayPhuThuLoaiKhachCaoNhatTheoPhieuThue '{0}'", idPhieuThue);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if (dt.Rows.Count <= 0)
            {
                return -1;
            }
            return float.Parse(dt.Rows[0]["PhuThu"].ToString());
        }

        public static DataTable KiemTraPhieuThue(int idPhieuThue)
        {
            string query = string.Format("exec pro_KiemTraPhieuThue '{0}'", idPhieuThue);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static DataTable KiemTraDSKhachThue(int idPhieuThue)
        {
            string query = string.Format("exec pro_KiemTraDSKhachThue '{0}'", idPhieuThue);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static int setTinhTrangPhieuThue(int idPhieuThue, int tinhTrang)
        {
            string query = string.Format("exec pro_setTinhTrangPhieuThue '{0}', '{1}'", idPhieuThue, tinhTrang);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static DataTable LayDSPhieuThue(int limit, int offset)
        {
            string query = string.Format("exec pro_LayDanhSachPhieuThue '{0}', '{1}'", limit, offset);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static int LaySoLuongPhieuThue()
        {
            string query = string.Format("exec pro_LaySoLuongPhieuThue");
            return DataProvider.Instance.ExcuteScalarInt(query);

        }

        public static DataTable LayChiTietPhieuThue(int idPhieuThue)
        {
            string query = string.Format("exec pro_LayChiTietPhieuThue '{0}'", idPhieuThue);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static DataTable DuyetDSPhieuThue(string dateFrom, string dateTo, int tinhTrang, int limit, int offset)
        {
            string query;
            if (tinhTrang == 3)//Duyệt theo ngày thuê
            {
                query = string.Format("exec pro_DuyetPhieuThueTheoNgayBatDau '{0}', '{1}', '{2}', '{3}'", dateFrom, dateTo, limit, offset);
            }
            else//duyệt 2 tiêu chí ngày thuê và tình trạng phiếu thuê
            {
                query = string.Format("exec pro_DuyetPhieuThueTheoNgayBatDauVaTinhTrangThue '{0}', '{1}','{2}', '{3}', '{4}'", dateFrom, dateTo, tinhTrang, limit, offset);
            }

            return DataProvider.Instance.ExcuteQuery(query);
            
        }

        public static int LaySoLuongPhieuThue(string dateFrom, string dateTo, int tinhTrang)
        {
            string query;
            if (tinhTrang == 3)//Duyệt theo ngày thuê
            {
                query = string.Format("exec pro_LaySoLuongPhieuThueTheoNgayBatDau '{0}', '{1}'", dateFrom, dateTo);
            }
            else//duyệt 2 tiêu chí ngày thuê và tình trạng phiếu thuê
            {
                query = string.Format("exec pro_LaySoLuongPhieuThueTheoNgayBatDauVaTinhTrangThue '{0}', '{1}', '{2}'", dateFrom, dateTo, tinhTrang);
            }
            return DataProvider.Instance.ExcuteScalarInt(query);

        }
    }
}
