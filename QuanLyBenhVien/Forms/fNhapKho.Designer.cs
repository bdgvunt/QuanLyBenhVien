namespace QuanLyBenhVien.Forms
{
    partial class fNhapKho
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
            this.lbThongTinPhieuNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btNhapKho = new System.Windows.Forms.Button();
            this.tbNhaCungCap = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNhapDanhSach = new System.Windows.Forms.Button();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lbDienMaPhieu = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNgayNhapPhieu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.cId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThaiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThongTinPhieuNhap
            // 
            this.lbThongTinPhieuNhap.AutoSize = true;
            this.lbThongTinPhieuNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinPhieuNhap.Location = new System.Drawing.Point(3, 9);
            this.lbThongTinPhieuNhap.Name = "lbThongTinPhieuNhap";
            this.lbThongTinPhieuNhap.Size = new System.Drawing.Size(222, 21);
            this.lbThongTinPhieuNhap.TabIndex = 1;
            this.lbThongTinPhieuNhap.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btNhapKho);
            this.panel1.Controls.Add(this.tbNhaCungCap);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btNhapDanhSach);
            this.panel1.Controls.Add(this.tbMaHoaDon);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.dtpNgayLapPhieu);
            this.panel1.Controls.Add(this.dtpNgayNhan);
            this.panel1.Controls.Add(this.lbDienMaPhieu);
            this.panel1.Controls.Add(this.lbMaHoaDon);
            this.panel1.Controls.Add(this.lbNhaCungCap);
            this.panel1.Controls.Add(this.lbGhiChu);
            this.panel1.Controls.Add(this.lbNgayNhapPhieu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbMaPhieu);
            this.panel1.Controls.Add(this.lbThongTinPhieuNhap);
            this.panel1.Location = new System.Drawing.Point(700, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 271);
            this.panel1.TabIndex = 2;
            // 
            // btNhapKho
            // 
            this.btNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapKho.Location = new System.Drawing.Point(513, 221);
            this.btNhapKho.Name = "btNhapKho";
            this.btNhapKho.Size = new System.Drawing.Size(75, 36);
            this.btNhapKho.TabIndex = 21;
            this.btNhapKho.Text = "Nhập kho";
            this.btNhapKho.UseVisualStyleBackColor = true;
            this.btNhapKho.Click += new System.EventHandler(this.btNhapKho_Click);
            // 
            // tbNhaCungCap
            // 
            this.tbNhaCungCap.Location = new System.Drawing.Point(111, 165);
            this.tbNhaCungCap.Name = "tbNhaCungCap";
            this.tbNhaCungCap.Size = new System.Drawing.Size(514, 22);
            this.tbNhaCungCap.TabIndex = 20;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(164, 219);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 36);
            this.btEdit.TabIndex = 18;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNhapDanhSach
            // 
            this.btNhapDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapDanhSach.Location = new System.Drawing.Point(52, 219);
            this.btNhapDanhSach.Name = "btNhapDanhSach";
            this.btNhapDanhSach.Size = new System.Drawing.Size(106, 36);
            this.btNhapDanhSach.TabIndex = 9;
            this.btNhapDanhSach.Text = "Tạo Phiếu";
            this.btNhapDanhSach.UseVisualStyleBackColor = true;
            this.btNhapDanhSach.Click += new System.EventHandler(this.btNhapDanhSach_Click);
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Location = new System.Drawing.Point(111, 81);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(514, 22);
            this.tbMaHoaDon.TabIndex = 17;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(108, 193);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(517, 22);
            this.tbGhiChu.TabIndex = 16;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(111, 107);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(514, 22);
            this.dtpNgayLapPhieu.TabIndex = 14;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Location = new System.Drawing.Point(111, 135);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(514, 22);
            this.dtpNgayNhan.TabIndex = 13;
            // 
            // lbDienMaPhieu
            // 
            this.lbDienMaPhieu.AutoSize = true;
            this.lbDienMaPhieu.Location = new System.Drawing.Point(77, 56);
            this.lbDienMaPhieu.Name = "lbDienMaPhieu";
            this.lbDienMaPhieu.Size = new System.Drawing.Size(104, 17);
            this.lbDienMaPhieu.TabIndex = 11;
            this.lbDienMaPhieu.Text = "____________";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(12, 87);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(87, 17);
            this.lbMaHoaDon.TabIndex = 9;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Location = new System.Drawing.Point(4, 163);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(96, 17);
            this.lbNhaCungCap.TabIndex = 8;
            this.lbNhaCungCap.Text = "Nhà cung cấp";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(4, 189);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(59, 17);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // lbNgayNhapPhieu
            // 
            this.lbNgayNhapPhieu.AutoSize = true;
            this.lbNgayNhapPhieu.Location = new System.Drawing.Point(3, 112);
            this.lbNgayNhapPhieu.Name = "lbNgayNhapPhieu";
            this.lbNgayNhapPhieu.Size = new System.Drawing.Size(103, 17);
            this.lbNgayNhapPhieu.TabIndex = 5;
            this.lbNgayNhapPhieu.Text = "Ngày lập phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhận";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Location = new System.Drawing.Point(4, 56);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(66, 17);
            this.lbMaPhieu.TabIndex = 3;
            this.lbMaPhieu.Text = "Mã phiếu";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dtpDenNgay);
            this.panel2.Controls.Add(this.dtpTuNgay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 30);
            this.panel2.TabIndex = 4;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(497, 5);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(167, 22);
            this.dtpDenNgay.TabIndex = 5;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(329, 5);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(162, 22);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dgvDanhSachPhieu
            // 
            this.dgvDanhSachPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId1,
            this.clSoHoaDon,
            this.clTinhTrang,
            this.clNgayLap,
            this.clNhaCungCap});
            this.dgvDanhSachPhieu.Location = new System.Drawing.Point(12, 48);
            this.dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            this.dgvDanhSachPhieu.RowHeadersWidth = 51;
            this.dgvDanhSachPhieu.RowTemplate.Height = 24;
            this.dgvDanhSachPhieu.Size = new System.Drawing.Size(682, 510);
            this.dgvDanhSachPhieu.TabIndex = 5;
            this.dgvDanhSachPhieu.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieu_SelectionChanged);
            // 
            // cId1
            // 
            this.cId1.DataPropertyName = "Id";
            this.cId1.HeaderText = "Mã";
            this.cId1.MinimumWidth = 6;
            this.cId1.Name = "cId1";
            this.cId1.Width = 125;
            // 
            // clSoHoaDon
            // 
            this.clSoHoaDon.DataPropertyName = "SoHoaDon";
            this.clSoHoaDon.HeaderText = "Số Hóa Đơn";
            this.clSoHoaDon.MinimumWidth = 6;
            this.clSoHoaDon.Name = "clSoHoaDon";
            this.clSoHoaDon.Width = 125;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "TinhTrangId";
            this.clTinhTrang.HeaderText = "Tình Trạng ";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 125;
            // 
            // clNgayLap
            // 
            this.clNgayLap.DataPropertyName = "NgayLap";
            this.clNgayLap.HeaderText = "Ngày Lập";
            this.clNgayLap.MinimumWidth = 6;
            this.clNgayLap.Name = "clNgayLap";
            this.clNgayLap.Width = 125;
            // 
            // clNhaCungCap
            // 
            this.clNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.clNhaCungCap.MinimumWidth = 6;
            this.clNhaCungCap.Name = "clNhaCungCap";
            this.clNhaCungCap.Width = 125;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(700, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 31);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chi tiết phiếu";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.clMaThuoc,
            this.clSoLo,
            this.clHanDung,
            this.clSoLuong,
            this.clDonGia,
            this.clGhiChu,
            this.clTrangThaiId});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(700, 316);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(630, 242);
            this.dgvChiTietPhieuNhap.TabIndex = 8;
            this.dgvChiTietPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellValueChanged);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // clMaThuoc
            // 
            this.clMaThuoc.DataPropertyName = "MaThuoc";
            this.clMaThuoc.HeaderText = "Mã Thuốc";
            this.clMaThuoc.MinimumWidth = 6;
            this.clMaThuoc.Name = "clMaThuoc";
            this.clMaThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaThuoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clSoLo
            // 
            this.clSoLo.DataPropertyName = "SoLo";
            this.clSoLo.HeaderText = "Số lô";
            this.clSoLo.MinimumWidth = 6;
            this.clSoLo.Name = "clSoLo";
            // 
            // clHanDung
            // 
            this.clHanDung.DataPropertyName = "HanDung";
            this.clHanDung.HeaderText = "Hạn Dùng";
            this.clHanDung.MinimumWidth = 6;
            this.clHanDung.Name = "clHanDung";
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.MinimumWidth = 6;
            this.clDonGia.Name = "clDonGia";
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clTrangThaiId
            // 
            this.clTrangThaiId.HeaderText = "Trạng Thái Id";
            this.clTrangThaiId.MinimumWidth = 6;
            this.clTrangThaiId.Name = "clTrangThaiId";
            this.clTrangThaiId.Visible = false;
            // 
            // fNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 593);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvDanhSachPhieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fNhapKho";
            this.Text = "Nhập Kho";
            this.Load += new System.EventHandler(this.fNhapKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbThongTinPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNgayNhapPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Label lbDienMaPhieu;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btNhapDanhSach;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.TextBox tbNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCungCap;
        private System.Windows.Forms.Button btNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewComboBoxColumn clMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThaiId;
    }
}