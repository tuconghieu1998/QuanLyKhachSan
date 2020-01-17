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
    public partial class ucThongKeLuotThueTheoGio : UserControl
    {
        public ucThongKeLuotThueTheoGio()
        {
            InitializeComponent();
            chartThongKe.DataSource = ThongKeDAO.ThongKeLuotThueTheoGio(GlobalVar.dateFrom, GlobalVar.dateTo);
            chartThongKe.ChartAreas["ChartArea1"].AxisX.Title = "Giờ";
            chartThongKe.ChartAreas["ChartArea1"].AxisY.Title = "Lượt thuê";
            chartThongKe.Series["Lượt thuê"].XValueMember = "hour";
            chartThongKe.Series["Lượt thuê"].YValueMembers = "LuotThue";
            //chartThongKe.ChartAreas[0].AxisY.Maximum = 20;
            chartThongKe.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void chartThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
