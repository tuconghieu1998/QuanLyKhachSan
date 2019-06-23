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
    public partial class FormThemPhong : Form
    {
        public FormThemPhong()
        {
            InitializeComponent();
        }

        public static string luaChon;
        public static int idPhong;

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string tenPhong = txtTenPhong.Text;
            int loaiPhong = int.Parse(cmbLoaiPhong.SelectedValue.ToString());
            string ghiChu = txtGhiChu.Text;

            if (tenPhong == "")
            {
                MessageBox.Show("Chưa nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (ghiChu == "")
            {
                ghiChu = "không có";
            }
            if (luaChon == "them")
            {
                if (PhongDAO.kiemTraTrungTenPhong(tenPhong))
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhongDAO.ThemPhong(tenPhong, loaiPhong, ghiChu);
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucQuanLyPhong.success = true;
                this.Close();
            }
            else
            {

                if (PhongDAO.kiemTraTrungTenPhongKhiCapNhap(idPhong, tenPhong))
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhongDAO.SuaPhong(idPhong, tenPhong, loaiPhong, ghiChu);
                MessageBox.Show("Sửa thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucQuanLyPhong.success = true;
                this.Close();
            }
        }

        void setUpCMBLoaiPhong()
        {
            List<Dictionary> list = PhongDAO.LoadDSLoaiPhong();
            cmbLoaiPhong.DataSource = list;
            cmbLoaiPhong.ValueMember = "id";
            cmbLoaiPhong.DisplayMember = "name";
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            setUpCMBLoaiPhong();
            if(luaChon == "sua")
            {
                Phong phong = PhongDAO.LoadPhong(idPhong);
                txtTenPhong.Text = phong.TenPhong;
                cmbLoaiPhong.Text = phong.LoaiPhong;
                txtGhiChu.Text = phong.GhiChu;
            }
        }
    }
}
