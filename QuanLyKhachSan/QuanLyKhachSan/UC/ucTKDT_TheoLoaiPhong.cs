using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.UC
{
    public partial class ucTKDT_TheoLoaiPhong : UserControl
    {
        public ucTKDT_TheoLoaiPhong()
        {
            InitializeComponent();
            chartThongKe.DataSource = ThongKeDAO.ThongKeDoanhThuTheoLoaiPhong(GlobalVar.dateFrom, GlobalVar.dateTo);
            //chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Loại phòng";
            //chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            //chartThongKe.Series["Doanh Thu (VND)"]["PixelPointWidth"] = "30";
            //chartThongKe.Series["Doanh Thu (VND)"].IsValueShownAsLabel = true;
            chartThongKe.Series["Doanh Thu (VND)"].XValueMember = "TenLoai";
            chartThongKe.Series["Doanh Thu (VND)"].YValueMembers = "DoanhThu";
            chartThongKe.Series[0].Label = "#VALX: #VALY (#PERCENT{P0})";
            //chartThongKe.Series[0].Label = "#VALX";
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
