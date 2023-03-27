using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class ChiDinh
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaPhieuChiDinh_Static;
        private decimal MaDichVu_Static;
        private decimal MaNhanVien_Static;
        private decimal? MaChiTietChungTu_Static;
        private decimal BHYT_Static;
        private DateTime NgayChiDinh_Static;
        private DateTime? NgayKetQua_Static;
        private decimal? NguoiKetQua_Static;
        private decimal SoLuong_Static;
        private decimal DonGia_Static;
        private string GhiChu_Static;
        private decimal TinhTrangId_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public decimal MaPhieuChiDinh
        {
            get
            {
                return this.MaPhieuChiDinh_Static;
            }
            set
            {
                ChiDinhCommon.Update_MaPhieuChiDinh(this.Id, value);
                this.MaPhieuChiDinh_Static = value;
            }
        }


        public decimal MaDichVu
        {
            get
            {
                return this.MaDichVu_Static;
            }
            set
            {
                ChiDinhCommon.Update_MaDichVu(this.Id, value);
                this.MaDichVu_Static = value;
            }
        }


        public decimal MaNhanVien
        {
            get
            {
                return this.MaNhanVien_Static;
            }
            set
            {
                ChiDinhCommon.Update_MaNhanVien(this.Id, value);
                this.MaNhanVien_Static = value;
            }
        }

        public decimal? MaChiTietChungTu
        {
            get
            {
                return this.MaChiTietChungTu_Static;
            }
            set
            {
                ChiDinhCommon.Update_MaChiTietChungTu(this.Id, value);
                this.MaChiTietChungTu_Static = value;
            }
        }
        
        public decimal BHYT
        {
            get
            {
                return this.BHYT_Static;
            }
            set
            {
                ChiDinhCommon.Update_BHYT(this.Id, value);
                this.BHYT_Static = value;
            }
        }


        public DateTime NgayChiDinh
        {
            get
            {
                return this.NgayChiDinh_Static;
            }
            set
            {
                ChiDinhCommon.Update_NgayChiDinh(this.Id, value);
                this.NgayChiDinh_Static = value;
            }
        }


        public DateTime? NgayKetQua
        {
            get
            {
                return this.NgayKetQua_Static;
            }
            set
            {
                ChiDinhCommon.Update_NgayKetQua(this.Id, value);
                this.NgayKetQua_Static = value;
            }
        }


        public decimal? NguoiKetQua
        {
            get
            {
                return this.NguoiKetQua_Static;
            }
            set
            {
                ChiDinhCommon.Update_NguoiKetQua(this.Id, value);
                this.NguoiKetQua_Static = value;
            }
        }


        public decimal SoLuong
        {
            get
            {
                return this.SoLuong_Static;
            }
            set
            {
                ChiDinhCommon.Update_SoLuong(this.Id, value);
                this.SoLuong_Static = value;
            }
        }


        public decimal DonGia
        {
            get
            {
                return this.DonGia_Static;
            }
            set
            {
                ChiDinhCommon.Update_DonGia(this.Id, value);
                this.DonGia_Static = value;
            }
        }


        public string GhiChu
        {
            get
            {
                return this.GhiChu_Static;
            }
            set
            {
                ChiDinhCommon.Update_GhiChu(this.Id, value);
                this.GhiChu_Static = value;
            }
        }


        public decimal TinhTrangId
        {
            get
            {
                return this.TinhTrangId_Static;
            }
            set
            {
                ChiDinhCommon.Update_TinhTrangId(this.Id, value);
                this.TinhTrangId_Static = value;
            }
        }


        public decimal TrangThaiId
        {
            get
            {
                return this.TrangThaiId_Static;
            }
            set
            {
                ChiDinhCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectChiDinh
        /// </summary> 
        public ChiDinh(decimal Id)
        {
            DataTable Table = ChiDinhCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildChiDinh(Table.Rows[0]);
            }
            else
                throw new Exception("Không có ChiDinh!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildChiDinh(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaPhieuChiDinh_Static = (decimal)FunctionCommon.GetDBValue(row["MaPhieuChiDinh"]);
            this.MaDichVu_Static = (decimal)FunctionCommon.GetDBValue(row["MaDichVu"]);
            this.MaNhanVien_Static = (decimal)FunctionCommon.GetDBValue(row["MaNhanVien"]);
            this.MaChiTietChungTu_Static = (decimal?)FunctionCommon.GetDBValue(row["MaChiTietChungTu"]);
            this.BHYT_Static = (decimal)FunctionCommon.GetDBValue(row["BHYT"]);
            this.NgayChiDinh_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayChiDinh"]);
            this.NgayKetQua_Static = (DateTime?)FunctionCommon.GetDBValue(row["NgayKetQua"]);
            this.NguoiKetQua_Static = (decimal?)FunctionCommon.GetDBValue(row["NguoiKetQua"]);
            this.SoLuong_Static = (decimal)FunctionCommon.GetDBValue(row["SoLuong"]);
            this.DonGia_Static = (decimal)FunctionCommon.GetDBValue(row["DonGia"]);
            this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]);
            this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
