using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.UC
{
    public partial class ucBaoCao : UserControl
    {
        public ucBaoCao()
        {
            InitializeComponent();
        }

        private void ucBaoCao_Load(object sender, EventArgs e)
        {
            setUpCMBTinhTrangPhieuThue();
        }

        void setUpCMBTinhTrangPhieuThue()
        {
            List<Dictionary> list = new List<Dictionary>();
            list.Add(new Dictionary() { Id = 1, Name = "Thống kê doanh thu từng loại phòng" });
            list.Add(new Dictionary() { Id = 2, Name = "Thống kê lượt thuê theo ngày" });
            list.Add(new Dictionary() { Id = 3, Name = "Thống kê thời gian thuê phòng trong ngày" });
            cmbThongKe.DataSource = list;
            cmbThongKe.ValueMember = "id";
            cmbThongKe.DisplayMember = "name";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(cmbThongKe.SelectedValue.ToString()) == 1)
            {
                GlobalVar.dateFrom = dateFrom.Value.ToString("yyyy-MM-dd HH:mm");
                GlobalVar.dateTo = dateTo.Value.ToString("yyyy-MM-dd HH:mm");
                panelBaoCaoContainer.Controls.Clear();
                ucTKDT_TheoLoaiPhong uc = new ucTKDT_TheoLoaiPhong();
                uc.Dock = DockStyle.Fill;
                panelBaoCaoContainer.Controls.Add(uc);
            }
            else if (int.Parse(cmbThongKe.SelectedValue.ToString()) == 2)
            {
                GlobalVar.dateFrom = dateFrom.Value.ToString("yyyy-MM-dd");
                GlobalVar.dateTo = dateTo.Value.ToString("yyyy-MM-dd");
                panelBaoCaoContainer.Controls.Clear();
                ucThongKeLuotThueTheoNgay uc = new ucThongKeLuotThueTheoNgay();
                uc.Dock = DockStyle.Fill;
                panelBaoCaoContainer.Controls.Add(uc);
            }
            else if (int.Parse(cmbThongKe.SelectedValue.ToString()) == 3)
            {
                GlobalVar.dateFrom = dateFrom.Value.ToString("yyyy-MM-dd");
                GlobalVar.dateTo = dateTo.Value.ToString("yyyy-MM-dd");
                panelBaoCaoContainer.Controls.Clear();
                ucThongKeLuotThueTheoGio uc = new ucThongKeLuotThueTheoGio();
                uc.Dock = DockStyle.Fill;
                panelBaoCaoContainer.Controls.Add(uc);
            }
        }
    }
}
