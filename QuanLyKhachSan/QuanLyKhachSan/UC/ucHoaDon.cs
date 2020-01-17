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
    public partial class ucHoaDon : UserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }

        int limit = 10;
        int offset = 0;
        int total;

        private void dtgDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                if (int.TryParse(dgv["MaHoaDon", e.RowIndex].Value.ToString(), out int idHoaDon))
                {
                    dtgChiTietHoaDon.DataSource = HoaDonDAO.LayChiTietHoaDon(idHoaDon);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            offset++;
            if (offset * limit >= total)
            {
                offset--;
                return;
            }
            dtgDSHoaDon.DataSource = HoaDonDAO.LayDSHoaDon(limit, offset);
        }

        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            total = HoaDonDAO.LaySoLuongHoaDon();
            dtgDSHoaDon.DataSource = HoaDonDAO.LayDSHoaDon(limit, offset);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            offset--;
            if (offset < 0)
            {
                offset++;
                return;
            }
            dtgDSHoaDon.DataSource = HoaDonDAO.LayDSHoaDon(limit, offset);
        }
    }
}
