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
        public static bool success = false;

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
            if (success)
            {
                success = false;
                LoadDSPhong();
                DatLai();
            }
            
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
            if (txtTinhTrang.Text == "Đã thuê")
            {
                MessageBox.Show("Phòng đã được thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThuePhong.idPhong = idPhong;
            FormThuePhong form = new FormThuePhong();
            form.ShowDialog();
            if (success)
            {
                success = false;
                LoadDSPhong();
                DatLai();
            }
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
            if (success)
            {
                success = false;
                LoadDSPhong();
                DatLai();
            }
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

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (lblTenPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng\nHãy chọn 1 phòng bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTinhTrang.Text != "Đã thuê")
            {
                MessageBox.Show("Phòng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res1 = MessageBox.Show("Trả phòng " + lblTenPhong.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res1 == DialogResult.No)
            {
                return;
            }
            DialogResult res = MessageBox.Show("Bạn có muốn thêm vào hóa đơn " + lblTenPhong.Text + " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //từ id phòng lấy được id_phiếu thuê nhờ xét tình trạng phòng là 0: Đang thuê
                int idPhieuThue = PhieuThueDAO.LayPhieuThueHienTaiCuaPhong(idPhong);
                //cập nhập lại tình trạng phòng là 0:trống, tình trạng phiếu thuê là 1: chưa thanh toán, set ngày kết thúc 
                PhongDAO.setTinhTrangPhong(idPhong, 0);
                string ngayKetThuc = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
                PhieuThueDAO.CapNhapPhieuThueKhiTraPhong(idPhieuThue, ngayKetThuc);


                addListChiTietHDByIDPhieuThue(idPhieuThue);
                

            }
            else
            {
                //từ id phòng lấy được id_phiếu thuê nhờ xét tình trạng phòng là 0: Đang thuê
                int idPhieuThue = PhieuThueDAO.LayPhieuThueHienTaiCuaPhong(idPhong);
                //cập nhập lại tình trạng phòng là 0:trống, tình trạng phiếu thuê là 1: chưa thanh toán, set ngày kết thúc 
                PhongDAO.setTinhTrangPhong(idPhong, 0);
                string ngayKetThuc = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
                PhieuThueDAO.CapNhapPhieuThueKhiTraPhong(idPhieuThue, ngayKetThuc);

                MessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        void addListChiTietHDByIDPhieuThue(int idPhieuThue)
        {
            DataTable dt = PhieuThueDAO.LayDuLieuThuePhong(idPhieuThue);
            if (dt.Rows.Count <= 0)
            {
                return;
            }
            DuLieuThuePhong duLieu = new DuLieuThuePhong(dt.Rows[0]);
            //Chỉ cần một loại khách nước ngoài thì sẽ phụ thu thêm 1.5
            duLieu.PhuThuLoaiKhach = PhieuThueDAO.LayPhuThuLoaiKhachCaoNhatTheoPhieuThue(idPhieuThue);
            //Mã phiếu thuê, Tên phòng, số ngày, đơn giá, phụ thu, tiền
            ChiTietHoaDon chiTiet = new ChiTietHoaDon();
            chiTiet.MaPhieuThue = duLieu.MaPhieuThue;
            chiTiet.TenPhong = duLieu.TenPhong;

            TimeSpan totaldays = duLieu.NgayKetThuc.Subtract(duLieu.NgayThue);
            chiTiet.SoNgay = (int)Math.Ceiling(totaldays.TotalDays);
            chiTiet.DonGia = duLieu.DonGia;

            //nếu số lượng khách vượt quá mức quy định thì sẽ phụ thu thêm
            if (duLieu.Sl_Khach > duLieu.Sl_KhachBinhThuong)
            {
                chiTiet.Tien = chiTiet.DonGia * chiTiet.SoNgay * duLieu.PhuThuLoaiPhong * duLieu.PhuThuLoaiKhach;
            }
            else
            {
                chiTiet.Tien = chiTiet.DonGia * chiTiet.SoNgay * duLieu.PhuThuLoaiPhong * duLieu.PhuThuLoaiKhach;
            }
            chiTiet.PhuThu = chiTiet.Tien - chiTiet.DonGia * chiTiet.SoNgay;
            //chiTiet.SoNgay = PhieuThueDAO.LaySoNgayThuePhong(idPhieuThue);
            //add vào list danh sách chi tiết hóa đơn
            GlobalVar.listChiTietHD.Add(chiTiet);

            //cập nhập lại tổng tiền
            GlobalVar.TongTien += chiTiet.Tien;

            MessageBox.Show("Thêm vào hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
