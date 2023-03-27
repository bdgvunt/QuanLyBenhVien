namespace QuanLyBenhVien.Forms
{
    partial class fXuatKho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btInPhieuXuat = new System.Windows.Forms.Button();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btTaoPhieuXuat = new System.Windows.Forms.Button();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.lbDienMaPhieu = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNhanVienLapPhieu = new System.Windows.Forms.Label();
            this.lbNgayNhapPhieu = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.lbThongTinPhieuXuat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachPhieuXuat = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clMaKhoThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThaiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btInPhieuXuat);
            this.panel1.Controls.Add(this.tbMaNhanVien);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btTaoPhieuXuat);
            this.panel1.Controls.Add(this.tbMaHoaDon);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.dtpNgayLapPhieu);
            this.panel1.Controls.Add(this.lbDienMaPhieu);
            this.panel1.Controls.Add(this.lbMaHoaDon);
            this.panel1.Controls.Add(this.lbGhiChu);
            this.panel1.Controls.Add(this.lbNhanVienLapPhieu);
            this.panel1.Controls.Add(this.lbNgayNhapPhieu);
            this.panel1.Controls.Add(this.lbMaPhieu);
            this.panel1.Controls.Add(this.lbThongTinPhieuXuat);
            this.panel1.Location = new System.Drawing.Point(323, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 236);
            this.panel1.TabIndex = 3;
            // 
            // btInPhieuXuat
            // 
            this.btInPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPhieuXuat.Location = new System.Drawing.Point(412, 186);
            this.btInPhieuXuat.Name = "btInPhieuXuat";
            this.btInPhieuXuat.Size = new System.Drawing.Size(165, 37);
            this.btInPhieuXuat.TabIndex = 10;
            this.btInPhieuXuat.Text = "In Phiếu Xuất";
            this.btInPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Location = new System.Drawing.Point(94, 84);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(100, 22);
            this.tbMaNhanVien.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(235, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sửa Phiếu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btTaoPhieuXuat
            // 
            this.btTaoPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoPhieuXuat.Location = new System.Drawing.Point(53, 187);
            this.btTaoPhieuXuat.Name = "btTaoPhieuXuat";
            this.btTaoPhieuXuat.Size = new System.Drawing.Size(141, 36);
            this.btTaoPhieuXuat.TabIndex = 9;
            this.btTaoPhieuXuat.Text = "Tạo Phiếu Xuất";
            this.btTaoPhieuXuat.UseVisualStyleBackColor = true;
            this.btTaoPhieuXuat.Click += new System.EventHandler(this.btTaoPhieuXuat_Click);
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Location = new System.Drawing.Point(292, 81);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(285, 22);
            this.tbMaHoaDon.TabIndex = 17;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(110, 136);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(467, 22);
            this.tbGhiChu.TabIndex = 16;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(111, 107);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(466, 22);
            this.dtpNgayLapPhieu.TabIndex = 14;
            // 
            // lbDienMaPhieu
            // 
            this.lbDienMaPhieu.AutoSize = true;
            this.lbDienMaPhieu.Location = new System.Drawing.Point(77, 56);
            this.lbDienMaPhieu.Name = "lbDienMaPhieu";
            this.lbDienMaPhieu.Size = new System.Drawing.Size(91, 16);
            this.lbDienMaPhieu.TabIndex = 11;
            this.lbDienMaPhieu.Text = "____________";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(209, 84);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(82, 16);
            this.lbMaHoaDon.TabIndex = 9;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(4, 142);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(53, 16);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // lbNhanVienLapPhieu
            // 
            this.lbNhanVienLapPhieu.AutoSize = true;
            this.lbNhanVienLapPhieu.Location = new System.Drawing.Point(4, 87);
            this.lbNhanVienLapPhieu.Name = "lbNhanVienLapPhieu";
            this.lbNhanVienLapPhieu.Size = new System.Drawing.Size(84, 16);
            this.lbNhanVienLapPhieu.TabIndex = 6;
            this.lbNhanVienLapPhieu.Text = "NV lập phiếu";
            // 
            // lbNgayNhapPhieu
            // 
            this.lbNgayNhapPhieu.AutoSize = true;
            this.lbNgayNhapPhieu.Location = new System.Drawing.Point(3, 112);
            this.lbNgayNhapPhieu.Name = "lbNgayNhapPhieu";
            this.lbNgayNhapPhieu.Size = new System.Drawing.Size(98, 16);
            this.lbNgayNhapPhieu.TabIndex = 5;
            this.lbNgayNhapPhieu.Text = "Ngày lập phiếu";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Location = new System.Drawing.Point(4, 56);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(62, 16);
            this.lbMaPhieu.TabIndex = 3;
            this.lbMaPhieu.Text = "Mã phiếu";
            // 
            // lbThongTinPhieuXuat
            // 
            this.lbThongTinPhieuXuat.AutoSize = true;
            this.lbThongTinPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinPhieuXuat.Location = new System.Drawing.Point(3, 9);
            this.lbThongTinPhieuXuat.Name = "lbThongTinPhieuXuat";
            this.lbThongTinPhieuXuat.Size = new System.Drawing.Size(220, 21);
            this.lbThongTinPhieuXuat.TabIndex = 1;
            this.lbThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 30);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH PHIẾU";
            // 
            // dgvDanhSachPhieuXuat
            // 
            this.dgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clTinhTrang});
            this.dgvDanhSachPhieuXuat.Location = new System.Drawing.Point(2, 32);
            this.dgvDanhSachPhieuXuat.Name = "dgvDanhSachPhieuXuat";
            this.dgvDanhSachPhieuXuat.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuXuat.RowTemplate.Height = 24;
            this.dgvDanhSachPhieuXuat.Size = new System.Drawing.Size(315, 561);
            this.dgvDanhSachPhieuXuat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(323, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 38);
            this.panel3.TabIndex = 8;
            // 
            // dgvChiTietPhieuXuat
            // 
            this.dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.clMaThuoc,
            this.clMaKhoThuoc,
            this.clSoLuong,
            this.clTrangThaiId});
            this.dgvChiTietPhieuXuat.Location = new System.Drawing.Point(323, 277);
            this.dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            this.dgvChiTietPhieuXuat.RowHeadersWidth = 51;
            this.dgvChiTietPhieuXuat.RowTemplate.Height = 24;
            this.dgvChiTietPhieuXuat.Size = new System.Drawing.Size(1086, 316);
            this.dgvChiTietPhieuXuat.TabIndex = 9;
            this.dgvChiTietPhieuXuat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuXuat_CellValueChanged);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Mã ";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.Width = 125;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "TinhTrangId";
            this.clTinhTrang.HeaderText = "Tình Trạng Id";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 125;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Width = 125;
            // 
            // clMaThuoc
            // 
            this.clMaThuoc.DataPropertyName = "MaThuoc";
            this.clMaThuoc.HeaderText = "Mã Thuốc";
            this.clMaThuoc.MinimumWidth = 6;
            this.clMaThuoc.Name = "clMaThuoc";
            this.clMaThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaThuoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clMaThuoc.Width = 125;
            // 
            // clMaKhoThuoc
            // 
            this.clMaKhoThuoc.DataPropertyName = "MaKhoThuoc";
            this.clMaKhoThuoc.HeaderText = "Mã Kho Thuốc";
            this.clMaKhoThuoc.MinimumWidth = 6;
            this.clMaKhoThuoc.Name = "clMaKhoThuoc";
            this.clMaKhoThuoc.Width = 125;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 125;
            // 
            // clTrangThaiId
            // 
            this.clTrangThaiId.DataPropertyName = "TrangThaiId";
            this.clTrangThaiId.HeaderText = "Trạng Thái Id";
            this.clTrangThaiId.MinimumWidth = 6;
            this.clTrangThaiId.Name = "clTrangThaiId";
            this.clTrangThaiId.Width = 125;
            // 
            // fXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 596);
            this.Controls.Add(this.dgvChiTietPhieuXuat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDanhSachPhieuXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fXuatKho";
            this.Text = "Xuất Kho";
            this.Load += new System.EventHandler(this.fXuatKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btTaoPhieuXuat;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label lbDienMaPhieu;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNhanVienLapPhieu;
        private System.Windows.Forms.Label lbNgayNhapPhieu;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Label lbThongTinPhieuXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuXuat;
        private System.Windows.Forms.Button btInPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewComboBoxColumn clMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKhoThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThaiId;
    }
}