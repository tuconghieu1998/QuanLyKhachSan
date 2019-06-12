using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            panelBaoCaoContainer.Controls.Clear();
            ucThongKeCot uc = new ucThongKeCot();
            uc.Dock = DockStyle.Fill;
            panelBaoCaoContainer.Controls.Add(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
