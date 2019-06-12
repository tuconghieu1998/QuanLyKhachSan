using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.UC;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTenTab.Text = "QUẢN LÝ PHÒNG";
            panelContainer.Controls.Clear();
            ucQuanLyPhong uc = new ucQuanLyPhong();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "QUẢN LÝ PHÒNG";
            panelContainer.Controls.Clear();
            ucQuanLyPhong uc = new ucQuanLyPhong();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "THUÊ PHÒNG";
            panelContainer.Controls.Clear();
            ucThuePhong uc = new ucThuePhong();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "HÓA ĐƠN";
            panelContainer.Controls.Clear();
            ucHoaDon uc = new ucHoaDon();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "BÁO CÁO";
            panelContainer.Controls.Clear();
            ucBaoCao uc = new ucBaoCao();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "NHÂN VIÊN";
            panelContainer.Controls.Clear();
            ucNhanVien uc = new ucNhanVien();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "CÀI ĐẶT";
            panelContainer.Controls.Clear();
            ucCaiDat uc = new ucCaiDat();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            lblTenTab.Text = "THANH TOÁN";
            panelContainer.Controls.Clear();
            ucThanhToan uc = new ucThanhToan();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }
    }
}
