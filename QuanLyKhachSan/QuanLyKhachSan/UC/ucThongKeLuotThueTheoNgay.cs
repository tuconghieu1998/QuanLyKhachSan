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
    public partial class ucThongKeLuotThueTheoNgay : UserControl
    {
        public ucThongKeLuotThueTheoNgay()
        {
            InitializeComponent();
            chartThongKe.DataSource = ThongKeDAO.ThongKeLuotThueTheoNgay(GlobalVar.dateFrom, GlobalVar.dateTo);
            chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "Lượt thuê";
            chartThongKe.Series["Lượt thuê"].XValueMember = "day";
            chartThongKe.Series["Lượt thuê"].YValueMembers = "LuotThue";
            //chartThongKe.ChartAreas[0].AxisY.Maximum = 20;
            chartThongKe.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
