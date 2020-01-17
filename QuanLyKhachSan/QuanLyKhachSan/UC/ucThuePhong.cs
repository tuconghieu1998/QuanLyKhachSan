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
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.UC
{
    public partial class ucThuePhong : UserControl
    {
        public ucThuePhong()
        {
            InitializeComponent();
        }

        int limit = 10;
        int offset = 0;
        int total;

        private void dtgDSPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                if(int.TryParse(dgv["maPhieu", e.RowIndex].Value.ToString(), out int idPhieuThue))
                {
                    dtgChiTietPhieuThue.DataSource = PhieuThueDAO.LayChiTietPhieuThue(idPhieuThue);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            offset++;
            if(offset*limit >= total)
            {
                offset--;
                return;
            }
            dtgDSPhieuThue.DataSource = PhieuThueDAO.LayDSPhieuThue(limit, offset);
        }

        private void ucThuePhong_Load(object sender, EventArgs e)
        {
            setUpCMBTinhTrangPhieuThue();
            total = PhieuThueDAO.LaySoLuongPhieuThue();
            dtgDSPhieuThue.DataSource = PhieuThueDAO.LayDSPhieuThue(limit, offset);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            offset--;
            if (offset<0)
            {
                offset++;
                return;
            }
            dtgDSPhieuThue.DataSource = PhieuThueDAO.LayDSPhieuThue(limit, offset);
        }

        private void dtgDSPhieuThue_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (dtgDSPhieuThue.Columns[e.ColumnIndex].Name.Equals("TinhTrang"))
            {
                int? tinhTrang = e.Value as int?;

                // replace statement checks with your own conditions
                if (tinhTrang == 0)
                {
                    e.Value = "Đang thuê";
                }
                else if (tinhTrang == 1)
                {
                    e.Value = "Đã trả phòng";
                }
                else
                {
                    e.Value = "Đã thanh toán";
                }
            }
        }

        void setUpCMBTinhTrangPhieuThue()
        {
            List<Dictionary> list = new List<Dictionary>();
            list.Add(new Dictionary() { Id = 3, Name = "Tất cả" });
            list.Add(new Dictionary() { Id = 0, Name = "Đang thuê phòng" });
            list.Add(new Dictionary() { Id = 1, Name = "Đã trả phòng" });
            list.Add(new Dictionary() { Id = 2, Name = "Đã thanh toán" });
            cmbTinhTrang.DataSource = list;
            cmbTinhTrang.ValueMember = "id";
            cmbTinhTrang.DisplayMember = "name";
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            int tinhTrang = int.Parse(cmbTinhTrang.SelectedValue.ToString());
            string DateFrom = this.dateFrom.Value.ToString("yyyy/MM/dd HH:mm");
            string DateTo = this.dateTo.Value.ToString("yyyy/MM/dd HH:mm");
            total = PhieuThueDAO.LaySoLuongPhieuThue(DateFrom, DateTo, tinhTrang);
            dtgDSPhieuThue.DataSource = PhieuThueDAO.DuyetDSPhieuThue(DateFrom, DateTo, tinhTrang, limit, offset);
            dtgChiTietPhieuThue.DataSource = PhieuThueDAO.LayChiTietPhieuThue(-1);//load lại bảng chi tiết phiếu thuê
        }
    }
}
