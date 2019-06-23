﻿using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class LoaiKhachDAO
    {
        public static List<Dictionary> LoadDSLoaiKhach()
        {
            List<Dictionary> list = new List<Dictionary>();
            string query = string.Format("exec pro_LoadDSLoaiKhach");
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Dictionary loaiKhach = new Dictionary();
                loaiKhach.Id = int.Parse(item["ID"].ToString());
                loaiKhach.Name = item["TenLoai"].ToString();
                list.Add(loaiKhach);
            }
            return list;
        }

        public static int getIDLoaiKhach(string tenLoaiKhach)
        {
            string query = string.Format("exec pro_getIDLoaiKhach N'{0}'", tenLoaiKhach);
            return DataProvider.Instance.ExcuteScalarInt(query);

        }
    }
}
