using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.UI;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.UC
{
    public partial class ucQuanLyPhong : UserControl
    {
        public ucQuanLyPhong()
        {
            InitializeComponent();
        }

        public static int idPhong;

        void setUpCMBLoaiPhong()
        {
            List<Dictionary> list = PhongDAO.LoadDSLoaiPhong();
            Dictionary item = new Dictionary() { Id = 0, Name = "Tất cả" };
            list.Insert(0, item);
            cmbLoaiPhong.DataSource = list;
            cmbLoaiPhong.ValueMember = "id";
            cmbLoaiPhong.DisplayMember = "name";
        }

        void setUpCMBTinhTrangPhong()
        {
            List<Dictionary> list = new List<Dictionary>();
            list.Add(new Dictionary() { Id = 2, Name = "Tất cả" });
            list.Add(new Dictionary() { Id = 0, Name = "Còn trống" });
            list.Add(new Dictionary() { Id = 1, Name = "Đã thuê" });
            cmbTinhTrang.DataSource = list;
            cmbTinhTrang.ValueMember = "id";
            cmbTinhTrang.DisplayMember = "name";
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            int loaiPhong = int.Parse(cmbLoaiPhong.SelectedValue.ToString());
            int tinhTrang = int.Parse(cmbTinhTrang.SelectedValue.ToString());
            HienThiDanhSachPhong(PhongDAO.DuyetDSPhong(loaiPhong, tinhTrang));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            FormThemPhong.luaChon = "them";
            FormThemPhong form = new FormThemPhong();
            form.ShowDialog();
            LoadDSPhong();
            DatLai();
        }

        void HienThiDanhSachPhong(List<Phong> listPhong)
        {
            flowDSPhong.Controls.Clear();
            foreach (Phong item in listPhong)
            {
                Button btn = new Button() { Width = 108, Height = 100 };
                btn.Name = item.Id.ToString();
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;

                if (item.LoaiPhong.Equals("Vip"))
                {
                    btn.Image = new Bitmap(Application.StartupPath + "\\image\\roomVip.png");

                }
                else if (item.LoaiPhong.Equals("Cao cấp"))
                {
                    btn.Image = new Bitmap(Application.StartupPath + "\\image\\roomCaoCap.png");
                }
                else
                {
                    btn.Image = new Bitmap(Application.StartupPath + "\\image\\roomBinhThuong.png");
                }
                btn.ImageAlign = ContentAlignment.MiddleCenter;

                if (item.TinhTrang.Equals(1))//Đã thuê
                {
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));

                }

                btn.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.Text = item.TenPhong;
                btn.TextAlign = ContentAlignment.BottomCenter;


                flowDSPhong.Controls.Add(btn);
            }
        }

        void LoadDSPhong()
        {
            
            List<Phong> listPhong;
            listPhong = PhongDAO.LoadDSPhong();
            HienThiDanhSachPhong(listPhong);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = ((sender as Button));
            lblTenPhong.Text = btn.Text;
            idPhong = int.Parse(btn.Name);
            PhongDetail phongDetail = PhongDAO.LoadChiTietPhong(int.Parse(btn.Name));
            if(phongDetail.TinhTrang == 0)
            {
                txtTinhTrang.Text = "Còn trống";
                txtNgayThue.Text = "";
            }
            else
            {
                txtTinhTrang.Text = "Đã thuê";
                txtNgayThue.Text = phongDetail.NgayThue;            
            }
            txtGhiChu.Text = phongDetail.GhiChu;
            dtgDSKhachThue.DataSource = phongDetail.DsKhachThue;
        }

        private void ucQuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadDSPhong();
            setUpCMBLoaiPhong();
            setUpCMBTinhTrangPhong();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (lblTenPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng\nHãy chọn 1 phòng bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThuePhong form = new FormThuePhong();
            form.ShowDialog();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if(lblTenPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng\nHãy chọn 1 phòng bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThemPhong.idPhong = idPhong;
            FormThemPhong.luaChon = "sua";
            FormThemPhong form = new FormThemPhong();
            form.ShowDialog();
            LoadDSPhong();
            DatLai();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (lblTenPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng\nHãy chọn 1 phòng bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("Bạn có muốn xóa phòng " + lblTenPhong.Text + " không ?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            PhongDAO.XoaPhong(idPhong);
            LoadDSPhong();
            DatLai();
        }

        void DatLai()
        {
            lblTenPhong.Text = "";
            idPhong = -1;
            PhongDetail phongDetail = new PhongDetail();
            phongDetail.DsKhachThue = new List<Dictionary>();
            txtTinhTrang.Text = "";
            txtNgayThue.Text = "";
            txtGhiChu.Text = "";
            dtgDSKhachThue.DataSource = phongDetail.DsKhachThue;
        }
    }
}
