using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class PhongDAO
    {
        public static List<Phong> LoadDSPhong()
        {
            List<Phong> list = new List<Phong>();
            string query = string.Format("exec pro_LoadDSPhong");
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }
            return list;
        }

        public static Phong LoadPhong(int id)
        {
            string query = string.Format("exec pro_LoadPhong '{0}'", id);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            Phong phong = new Phong(dt.Rows[0]);
            return phong;
        }

        public static List<Phong> DuyetDSPhong(int loaiPhong, int tinhTrang)
        {
            List<Phong> list = new List<Phong>();
            string query;
            if (loaiPhong == 0 && tinhTrang == 2)//Tất cả phòng
            {
                query = string.Format("exec pro_LoadDSPhong");
            }
            else if (loaiPhong == 0)//chỉ duyệt theo tình trạng phòng
            {
                query = string.Format("exec pro_DuyetDSPhongTheoTinhTrang '{0}'", tinhTrang);
            }
            else if (tinhTrang == 2) // duyệt theo loại phòng
            {
                query = string.Format("exec pro_DuyetDSPhongTheoLoaiPhong '{0}'", loaiPhong);
            }
            else//duyệt 2 tiêu chí
            {
                query = string.Format("exec pro_DuyetDSPhong '{0}', '{1}'", loaiPhong, tinhTrang);
            }

            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }
            return list;
        }

        public static PhongDetail LoadChiTietPhong(int idPhong)
        {
            PhongDetail phongDetail = new PhongDetail();
            string query = string.Format("exec pro_LoadThongTinChiTietPhong '{0}'", idPhong);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            phongDetail.IdPhong = idPhong;
            phongDetail.GhiChu = dt.Rows[0]["GhiChu"].ToString();
            phongDetail.TinhTrang = int.Parse(dt.Rows[0]["TinhTrang"].ToString());
            phongDetail.DsKhachThue = new List<Dictionary>();
            if (phongDetail.TinhTrang == 1)
            {
                query = string.Format("exec pro_LoadDSKhachThuePhong '{0}'", idPhong);
                dt = DataProvider.Instance.ExcuteQuery(query);
                phongDetail.IdPhieuThue = int.Parse(dt.Rows[0]["idPhieuThue"].ToString());
                DateTime date = (DateTime)dt.Rows[0]["NgayThue"];
                phongDetail.NgayThue = date.ToString("dd/MM/yyyy HH:mm");

                foreach (DataRow item in dt.Rows)
                {
                    Dictionary dsKhachThue = new Dictionary();
                    dsKhachThue.Id = int.Parse(item["STT"].ToString());
                    dsKhachThue.Name = item["TenKhachHang"].ToString();
                    phongDetail.DsKhachThue.Add(dsKhachThue);
                }
            }

            return phongDetail;
        }

        public static List<Dictionary> LoadDSLoaiPhong()
        {
            List<Dictionary> list = new List<Dictionary>();
            string query = string.Format("exec pro_LoadDSLoaiPhong");
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Dictionary loaiPhong = new Dictionary();
                loaiPhong.Id = int.Parse(item["ID"].ToString());
                loaiPhong.Name = item["TenLoai"].ToString();
                list.Add(loaiPhong);
            }
            return list;
        }

        public static int ThemPhong(string tenPhong, int loaiPhong, string ghiChu)
        {
            string query = string.Format("exec pro_ThemPhong N'{0}', '{1}', N'{2}'", tenPhong, loaiPhong, ghiChu);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static bool kiemTraTrungTenPhong(string tenPhong)
        {
            string query = string.Format("exec pro_kiemTraTrungTenPhong '{0}'", tenPhong);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }

        public static bool kiemTraTrungTenPhongKhiCapNhap(int id, string tenPhong)
        {
            string query = string.Format("exec pro_kiemTraTrungTenPhongKhiCapNhap '{0}', N'{1}'", id, tenPhong);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }

        public static int SuaPhong(int id, string tenPhong, int loaiPhong, string ghiChu)
        {
            string query = string.Format("exec pro_SuaPhong '{0}', N'{1}', '{2}', N'{3}'", id, tenPhong, loaiPhong, ghiChu);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static int XoaPhong(int id)
        {
            string query = string.Format("exec pro_XoaPhong '{0}'", id);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static string getTenLoaiPhong(int id)
        {
            string query = string.Format("exec pro_getTenLoaiPhong '{0}'", id);
            return DataProvider.Instance.ExcuteScalarString(query);

        }

        public static int setTinhTrangPhong(int idPhong, int tinhTrang)
        {
            string query = string.Format("exec pro_setTinhTrangPhong '{0}', '{1}'", idPhong, tinhTrang);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static int getSoLuongKhachToiDa(int idPhong)
        {
            string query = string.Format("exec pro_getSLKhachToiDa '{0}'", idPhong);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }

        public static DataTable DSLoaiPhong()
        {
            string query = string.Format("exec pro_DSLoaiPhong");
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public static int updateLoaiPhong(int idLoaiPhong, string tenLoai, int SL_KhachBinhThuong, int SL_KhachToiDa, float DonGia, float phuThu)
        {
            string query = string.Format("exec pro_updateLoaiPhong '{0}',N'{1}', '{2}', '{3}', '{4}', '{5}'", idLoaiPhong, tenLoai, SL_KhachBinhThuong, SL_KhachToiDa, DonGia, phuThu);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
