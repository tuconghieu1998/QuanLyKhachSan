namespace QuanLyKhachSan.UC
{
    partial class ucThuePhong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThuePhong));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgChiTietPhieuThue = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dtgDSPhieuThue = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietPhieuThue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDuyet);
            this.panel2.Controls.Add(this.cmbTinhTrang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 78);
            this.panel2.TabIndex = 1;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(625, 39);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(75, 23);
            this.btnDuyet.TabIndex = 5;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(485, 41);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(120, 21);
            this.cmbTinhTrang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(254, 42);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(17, 42);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgChiTietPhieuThue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(410, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 472);
            this.panel1.TabIndex = 2;
            // 
            // dtgChiTietPhieuThue
            // 
            this.dtgChiTietPhieuThue.AllowUserToAddRows = false;
            this.dtgChiTietPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChiTietPhieuThue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgChiTietPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CustomerName,
            this.Column3,
            this.Column1,
            this.DiaChi});
            this.dtgChiTietPhieuThue.Location = new System.Drawing.Point(6, 63);
            this.dtgChiTietPhieuThue.Name = "dtgChiTietPhieuThue";
            this.dtgChiTietPhieuThue.Size = new System.Drawing.Size(540, 284);
            this.dtgChiTietPhieuThue.TabIndex = 19;
            // 
            // id
            // 
            this.id.DataPropertyName = "STT";
            this.id.FillWeight = 44.48299F;
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "TenKhachHang";
            this.CustomerName.FillWeight = 114.314F;
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoai";
            this.Column3.HeaderText = "Loại khách";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CMND";
            this.Column1.FillWeight = 101.5229F;
            this.Column1.HeaderText = "CMND";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 139.6802F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Danh sách khách thuê";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 64);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 62);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh sách phiếu thuê";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 39);
            this.panel4.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(232, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(319, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dtgDSPhieuThue
            // 
            this.dtgDSPhieuThue.AllowUserToAddRows = false;
            this.dtgDSPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDSPhieuThue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgDSPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column5,
            this.Column6,
            this.Column7,
            this.TinhTrang,
            this.Column9,
            this.maPhieu});
            this.dtgDSPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDSPhieuThue.Location = new System.Drawing.Point(0, 142);
            this.dtgDSPhieuThue.Name = "dtgDSPhieuThue";
            this.dtgDSPhieuThue.Size = new System.Drawing.Size(410, 369);
            this.dtgDSPhieuThue.TabIndex = 5;
            this.dtgDSPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSPhieuThue_CellClick);
            this.dtgDSPhieuThue.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDSPhieuThue_CellFormatting);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "RowNum";
            this.Column10.FillWeight = 53.29951F;
            this.Column10.HeaderText = "STT";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenPhong";
            this.Column5.FillWeight = 116.2092F;
            this.Column5.HeaderText = "Tên phòng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayThue";
            this.Column6.FillWeight = 116.2092F;
            this.Column6.HeaderText = "Ngày thuê";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayKetThuc";
            this.Column7.FillWeight = 116.2092F;
            this.Column7.HeaderText = "Ngày kết thúc";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 116.2092F;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Ten";
            this.Column9.FillWeight = 116.2092F;
            this.Column9.HeaderText = "Người tạo phiếu";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // maPhieu
            // 
            this.maPhieu.DataPropertyName = "ID";
            this.maPhieu.FillWeight = 65.65486F;
            this.maPhieu.HeaderText = "Mã phiếu";
            this.maPhieu.Name = "maPhieu";
            this.maPhieu.ReadOnly = true;
            // 
            // ucThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dtgDSPhieuThue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucThuePhong";
            this.Size = new System.Drawing.Size(969, 550);
            this.Load += new System.EventHandler(this.ucThuePhong_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietPhieuThue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhieuThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgChiTietPhieuThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dtgDSPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
