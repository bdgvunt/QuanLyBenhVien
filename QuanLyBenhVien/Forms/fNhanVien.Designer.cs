namespace QuanLyBenhVien.Forms
{
    partial class fNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChucVui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaHanhNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangThaiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 678);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cTenNhanVien,
            this.cChuyenMon,
            this.cKhoa,
            this.cChucVui,
            this.cMaHanhNghe,
            this.cUserName,
            this.cPassWord,
            this.cTrangThaiId});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1241, 678);
            this.dgv.TabIndex = 0;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            // 
            // cTenNhanVien
            // 
            this.cTenNhanVien.DataPropertyName = "TenNhanVien";
            this.cTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.cTenNhanVien.MinimumWidth = 6;
            this.cTenNhanVien.Name = "cTenNhanVien";
            // 
            // cChuyenMon
            // 
            this.cChuyenMon.DataPropertyName = "ChuyenMon";
            this.cChuyenMon.HeaderText = "Chuyên Môn";
            this.cChuyenMon.MinimumWidth = 6;
            this.cChuyenMon.Name = "cChuyenMon";
            // 
            // cKhoa
            // 
            this.cKhoa.DataPropertyName = "Khoa";
            this.cKhoa.HeaderText = "Khoa";
            this.cKhoa.MinimumWidth = 6;
            this.cKhoa.Name = "cKhoa";
            this.cKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cChucVui
            // 
            this.cChucVui.DataPropertyName = "ChucVu";
            this.cChucVui.HeaderText = "Chức Vụ";
            this.cChucVui.MinimumWidth = 6;
            this.cChucVui.Name = "cChucVui";
            // 
            // cMaHanhNghe
            // 
            this.cMaHanhNghe.DataPropertyName = "MaHanhNghe";
            this.cMaHanhNghe.HeaderText = "Mã Hành Nghề";
            this.cMaHanhNghe.MinimumWidth = 6;
            this.cMaHanhNghe.Name = "cMaHanhNghe";
            // 
            // cUserName
            // 
            this.cUserName.DataPropertyName = "UserName";
            this.cUserName.HeaderText = "UserName";
            this.cUserName.MinimumWidth = 6;
            this.cUserName.Name = "cUserName";
            // 
            // cPassWord
            // 
            this.cPassWord.DataPropertyName = "PassWord";
            this.cPassWord.HeaderText = "PassWord";
            this.cPassWord.MinimumWidth = 6;
            this.cPassWord.Name = "cPassWord";
            // 
            // cTrangThaiId
            // 
            this.cTrangThaiId.DataPropertyName = "TrangThaiId";
            this.cTrangThaiId.HeaderText = "TrangThaiId";
            this.cTrangThaiId.MinimumWidth = 6;
            this.cTrangThaiId.Name = "cTrangThaiId";
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 678);
            this.Controls.Add(this.panel1);
            this.Name = "fNhanVien";
            this.Text = "DM Nhân Viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChucVui;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaHanhNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangThaiId;
    }
}