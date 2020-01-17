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
using DGVPrinterHelper;
using System.Drawing.Printing;
using System.IO;

namespace QuanLyKhachSan.UC
{
    public partial class ucThanhToan : UserControl
    {
        public ucThanhToan()
        {
            InitializeComponent();
        }

        int maPhieuThueHienTai = -1;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (GlobalVar.listChiTietHD.Count <= 0)
            {
                MessageBox.Show("Danh sách phiếu thuê rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string DiaChi;

            if (txtDiaChi.Text == "")
            {
                DiaChi = "Chưa nhập";
            }
            else
            {
                DiaChi = txtDiaChi.Text;
            }

            // insert hóa đơn
            int idHoaDon = HoaDonDAO.ThemHoaDon(txtTenKhachHang.Text, DiaChi, GlobalVar.TongTien, GlobalVar.idTaiKhoan);

            //insert chi tiết hóa đơn
            for (int i = 0; i < GlobalVar.listChiTietHD.Count; i++)
            {
                HoaDonDAO.ThemChiTietHoaDon(idHoaDon, i + 1, GlobalVar.listChiTietHD[i]);
                //cập nhập lại tình trạng phiếu thuê là 2: Đã thanh toán
                PhieuThueDAO.setTinhTrangPhieuThue(GlobalVar.listChiTietHD[i].MaPhieuThue, 2);//2: Đã trả phòng
            }
            
            //xuất bill
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n HÓA ĐƠN THANH TOÁN";
            printer.SubTitleAlignment = 0;
            printer.SubTitle = "\n\n\nKhách hàng/Cơ quan: "+txtTenKhachHang.Text +".\nĐịa chỉ: "+txtDiaChi.Text+".\nTrị giá: "
                +convertFloatToString(GlobalVar.TongTien)+" đồng.\n\nChi tiết hóa đơn:\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Khách sạn Silver\r\n12 Nguyễn Thị Thập, Quận 7, TP.HCM\r\nĐiện thoại: 0367376455\r\n\nCảm ơn quý khách đã sử dụng dịch vụ";
            printer.FooterSpacing = 15;
            
            printer.SubTitleFont = new Font("Arial Unicode", 12, FontStyle.Regular);
            printer.PrintDataGridView(dtgDSPhieuThue);
            //printer.printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            //printer.printDocument.PrinterSettings.PrintToFile = true;
            //printer.printDocument.PrinterSettings.PrintFileName = Path.Combine(Application.StartupPath + "\\HD"+idHoaDon.ToString() + ".pdf");
            
            //Đặt lại
            DatLaiHoaDon();
        }

        private void ucThanhToan_Load(object sender, EventArgs e)
        {
            dtgDSPhieuThue.DataSource = GlobalVar.tmp;
            dtgDSPhieuThue.DataSource = GlobalVar.listChiTietHD;
            lblTongTien.Text = convertFloatToString(GlobalVar.TongTien);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuThue.Text == "")
            {
                MessageBox.Show("Chưa nhập mã phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra phiếu thuê
            if (!int.TryParse(txtMaPhieuThue.Text, out maPhieuThueHienTai))
            {
                DatLaiGiaTriKiemTra();
                MessageBox.Show("Mã phiếu thuê không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DataTable dt = PhieuThueDAO.KiemTraPhieuThue(maPhieuThueHienTai);
            if (dt.Rows.Count <= 0)
            {
                DatLaiGiaTriKiemTra();
                MessageBox.Show("Phiếu thuê không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
            DateTime date = (DateTime)dt.Rows[0]["NgayThue"];
            txtNgayThue.Text = date.ToString("dd/MM/yyyy HH:mm");
            int tinhTrang = int.Parse(dt.Rows[0]["TinhTrang"].ToString());
            if (tinhTrang == 0)
            {
                txtTinhTrang.Text = "Đang thuê";
            }
            else if (tinhTrang == 1)
            {
                txtTinhTrang.Text = "Đã trả phòng";
            }
            else
            {
                txtTinhTrang.Text = "Đã thanh toán";
            }

            //Kiểm tra danh sách khách thuê

            dt = PhieuThueDAO.KiemTraDSKhachThue(maPhieuThueHienTai);
            dtgDSKhachThue.DataSource = dt;

        }

        void DatLaiGiaTriKiemTra()
        {
            maPhieuThueHienTai = -1;
            txtTenPhong.Text = "";
            txtNgayThue.Text = "";
            txtTinhTrang.Text = "";
            dtgDSKhachThue.DataSource = PhieuThueDAO.KiemTraDSKhachThue(maPhieuThueHienTai);
        }

        void DatLaiHoaDon()
        {
            DatLaiGiaTriKiemTra();
            txtMaPhieuThue.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            GlobalVar.TongTien = 0;
            dtgDSPhieuThue.DataSource = GlobalVar.tmp;
            GlobalVar.listChiTietHD.Clear();
            lblTongTien.Text = "0";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maPhieuThueHienTai < 0)
            {
                MessageBox.Show("Kiểm tra phiếu thuê thành công trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTinhTrang.Text == "Đang thuê")
            {
                MessageBox.Show("Trả phòng trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTinhTrang.Text == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu thuê này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            addListChiTietHDByIDPhieuThue(maPhieuThueHienTai);

        }

        void addListChiTietHDByIDPhieuThue(int idPhieuThue)
        {
            DataTable dt = PhieuThueDAO.LayDuLieuThuePhong(idPhieuThue);
            if (dt.Rows.Count <= 0)
            {
                return;
            }
            DuLieuThuePhong duLieu = new DuLieuThuePhong(dt.Rows[0]);
            //Kiểm tra phiếu thuê đã tồn tại trong list hóa đơn
            for (int i = 0; i < GlobalVar.listChiTietHD.Count; i++)
            {
                if (duLieu.MaPhieuThue == GlobalVar.listChiTietHD[i].MaPhieuThue)
                {
                    MessageBox.Show("Phiếu thuê đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

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
                chiTiet.Tien = chiTiet.DonGia * chiTiet.SoNgay * duLieu.PhuThuLoaiKhach;
            }
            chiTiet.PhuThu = chiTiet.Tien - chiTiet.DonGia * chiTiet.SoNgay;
            //chiTiet.SoNgay = PhieuThueDAO.LaySoNgayThuePhong(idPhieuThue);
            //add vào list danh sách chi tiết hóa đơn
            GlobalVar.listChiTietHD.Add(chiTiet);

            //cập nhập lại tổng tiền
            GlobalVar.TongTien += chiTiet.Tien;
            lblTongTien.Text = convertFloatToString(GlobalVar.TongTien);
            //reload danh sách phiếu thuê
            dtgDSPhieuThue.DataSource = GlobalVar.tmp;
            dtgDSPhieuThue.DataSource = GlobalVar.listChiTietHD;
        }

        string convertFloatToString(float tmp)
        {
            string result;
            string tmp1;
            result = tmp.ToString("#");
            int n = result.Length;
            for (int i = n - 3; i > 0; i = i - 3)
            {
                tmp1 = result.Insert(i, ".");
                result = tmp1;
            }

            return result;

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            DatLaiHoaDon();
        }
    }
}
