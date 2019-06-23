using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    public partial class FormThuePhong : Form
    {
        public FormThuePhong()
        {
            InitializeComponent();
        }

        List<Khach> dsKhach = new List<Khach>();
        //biến dùng để làm mới datasource
        List<Khach> tmp = new List<Khach>();
        int stt = 1;
        public static int idPhong;
        public static int SLKhachToiDa;

        void setUpCMBLoaiKhach()
        {
            List<Dictionary> list = LoaiKhachDAO.LoadDSLoaiKhach();
            cmbLoaiKhach.DataSource = list;
            cmbLoaiKhach.ValueMember = "id";
            cmbLoaiKhach.DisplayMember = "name";
        }

        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            setUpCMBLoaiKhach();
            SLKhachToiDa = PhongDAO.getSoLuongKhachToiDa(idPhong);
            this.dtNgayThue.Value = DateTime.Now;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            //kiểm tra chưa nhập thông tin khách hàng
            if(dtgKhachThuePhong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //insert phiếu thuê phòng
            //DateTime now = DateTime.Now;

            int idPhieuThue = PhieuThueDAO.ThemPhieuThue(idPhong, this.dtNgayThue.Value.ToString("yyyy/MM/dd HH:mm"), GlobalVar.idTaiKhoan);//id nhân viên tạm thời cho là 1
                                                                                                       //insert chi tiết phiếu thuê phòng
            for (int i=0;i<dsKhach.Count;i++)
            {      
                PhieuThueDAO.ThemChiTietPhieuThue(idPhieuThue, dsKhach[i]);
            }

            //set lại tình trang phòng là 1: đã thuê
            PhongDAO.setTinhTrangPhong(idPhong, 1);
            MessageBox.Show("Thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucQuanLyPhong.success = true;
            this.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dsKhach.Count >= SLKhachToiDa)
            {
                MessageBox.Show("Số lượng khách đã đạt tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Khach khach = new Khach();
            khach.Stt = stt;
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            khach.TenKhach = txtTenKhach.Text;
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Chưa nhập CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            khach.CMND1 = txtCMND.Text;
            khach.DiaChi = txtDiaChi.Text;
            if (khach.DiaChi == "")
            {
                khach.DiaChi = "trống";
            }
            khach.LoaiKhach = cmbLoaiKhach.Text;

            dsKhach.Add(khach);
            dtgKhachThuePhong.DataSource = tmp;
            dtgKhachThuePhong.DataSource = dsKhach;
            stt++;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgKhachThuePhong.SelectedRows)
            {                
                dsKhach.RemoveAt(row.Index);
                for (int i = row.Index; i < dsKhach.Count; i++)
                {
                    dsKhach[i].Stt = i + 1;
                }
                dtgKhachThuePhong.DataSource = tmp;
                dtgKhachThuePhong.DataSource = dsKhach;
            }
        }
    }
}
