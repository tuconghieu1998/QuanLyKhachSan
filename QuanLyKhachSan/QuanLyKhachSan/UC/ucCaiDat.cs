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
    public partial class ucCaiDat : UserControl
    {
        public ucCaiDat()
        {
            InitializeComponent();
        }

        private void ucCaiDat_Load(object sender, EventArgs e)
        {
            dtgLoaiKhach.DataSource = LoaiKhachDAO.DSLoaiKhach();
            addBindingLoaiKhach();
            dtgLoaiPhong.DataSource = PhongDAO.DSLoaiPhong();
            addBindingLoaiPhong();
        }

        void addBindingLoaiKhach()
        {

            txtMaLoaiKhach.DataBindings.Add(new Binding("Text", dtgLoaiKhach.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenLoaiKhach.DataBindings.Add(new Binding("Text", dtgLoaiKhach.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
            txtPhuThu.DataBindings.Add(new Binding("Text", dtgLoaiKhach.DataSource, "PhuThu", true, DataSourceUpdateMode.Never));
        }

        void clearBindingLoaiKhach()
        {
            txtMaLoaiKhach.DataBindings.Clear();
            txtTenLoaiKhach.DataBindings.Clear();
            txtPhuThu.DataBindings.Clear();
        }

        void addBindingLoaiPhong()
        {

            txtMaLoaiPhong.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenLoaiPhong.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
            nSL_KhachBinhThuong.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "SL_KhachBinhThuong", true, DataSourceUpdateMode.Never));
            nSoLuongKhachToiDa.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "SL_KhachToiDa", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtPhuThuPhong.DataBindings.Add(new Binding("Text", dtgLoaiPhong.DataSource, "PhuThu", true, DataSourceUpdateMode.Never));
        }

        void clearBindingLoaiPhong()
        {
            txtMaLoaiPhong.DataBindings.Clear();
            txtTenLoaiPhong.DataBindings.Clear();
            nSL_KhachBinhThuong.DataBindings.Clear();
            nSoLuongKhachToiDa.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtPhuThuPhong.DataBindings.Clear();
        }

        private void btnThayDoiLoaiKhach_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaLoaiKhach.Text);
            string tenLoai = txtTenLoaiKhach.Text;
            if (float.TryParse(txtPhuThu.Text, out float phuThu))
            {
                if (tenLoai == "")
                {
                    MessageBox.Show("Tên loại khách không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int result = LoaiKhachDAO.updateLoaiKhach(id, tenLoai, phuThu);
                if (result >= 1)
                {
                    MessageBox.Show("Thay đổi thông tin loại khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgLoaiKhach.DataSource = LoaiKhachDAO.DSLoaiKhach();
                    clearBindingLoaiKhach();
                    addBindingLoaiKhach();

                }
            }
        }

        private void btnThayDoiLoaiPhong_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaLoaiPhong.Text);
            string tenLoai = txtTenLoaiPhong.Text;
            int SL_KhachBinhThuong = int.Parse(nSL_KhachBinhThuong.Value.ToString());
            int SL_KhachToiDa = int.Parse(nSoLuongKhachToiDa.Value.ToString());
            if (float.TryParse(txtDonGia.Text, out float donGia))
            {
                if (float.TryParse(txtPhuThuPhong.Text, out float phuThu))
                {
                    if (tenLoai == "")
                    {
                        MessageBox.Show("Tên loại phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int result = PhongDAO.updateLoaiPhong(id,tenLoai,SL_KhachBinhThuong,SL_KhachToiDa,donGia,phuThu);
                    if (result >= 1)
                    {
                        MessageBox.Show("Thay đổi thông tin loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgLoaiPhong.DataSource = PhongDAO.DSLoaiPhong();
                        clearBindingLoaiPhong();
                        addBindingLoaiPhong();

                    }
                }
            }
        }
    }
}
