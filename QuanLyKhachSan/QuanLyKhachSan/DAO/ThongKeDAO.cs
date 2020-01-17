using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class ThongKeDAO
    {
        public static DataTable ThongKeDoanhThuTheoLoaiPhong(string dateFrom, string dateTo)
        {
            string query = string.Format("exec pro_TKDoanhThuTungLoaiPhong '{0}', '{1}'", dateFrom, dateTo);
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public static DataTable ThongKeLuotThueTheoNgay(string dateFrom, string dateTo)
        {
            string query = string.Format("exec pro_TKLuotThueTheoNgay '{0}', '{1}'", dateFrom, dateTo);
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public static DataTable ThongKeLuotThueTheoGio(string dateFrom, string dateTo)
        {
            string query = string.Format("exec pro_TKThoiGianThuePhong '{0}', '{1}'", dateFrom, dateTo);
            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
