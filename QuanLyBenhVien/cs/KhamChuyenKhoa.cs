using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class KhamChuyenKhoa
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaLuotKham_Static;
        private decimal MaPhongKham_Static;
        private decimal MaNhanVien_Static;
        private decimal MaLoaiKham_Static;
        private decimal MaTinhTrangKham_Static;
        private DateTime NgayBatDau_Static;
        private DateTime NgayKetThuc_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public decimal MaLuotKham
        {
            get
            {
                return this.MaLuotKham_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_MaLuotKham(this.Id, value);
                this.MaLuotKham_Static = value;
            }
        }


        public decimal MaPhongKham
        {
            get
            {
                return this.MaPhongKham_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_MaPhongKham(this.Id, value);
                this.MaPhongKham_Static = value;
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
                KhamChuyenKhoaCommon.Update_MaNhanVien(this.Id, value);
                this.MaNhanVien_Static = value;
            }
        }


        public decimal MaLoaiKham
        {
            get
            {
                return this.MaLoaiKham_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_MaLoaiKham(this.Id, value);
                this.MaLoaiKham_Static = value;
            }
        }


        public decimal MaTinhTrangKham
        {
            get
            {
                return this.MaTinhTrangKham_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_MaTinhTrangKham(this.Id, value);
                this.MaTinhTrangKham_Static = value;
            }
        }


        public DateTime NgayBatDau
        {
            get
            {
                return this.NgayBatDau_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_NgayBatDau(this.Id, value);
                this.NgayBatDau_Static = value;
            }
        }


        public DateTime NgayKetThuc
        {
            get
            {
                return this.NgayKetThuc_Static;
            }
            set
            {
                KhamChuyenKhoaCommon.Update_NgayKetThuc(this.Id, value);
                this.NgayKetThuc_Static = value;
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
                KhamChuyenKhoaCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectKhamChuyenKhoa
        /// </summary> 
        public KhamChuyenKhoa(decimal Id)
        {
            DataTable Table = KhamChuyenKhoaCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildKhamChuyenKhoa(Table.Rows[0]);
            }
            else
                throw new Exception("Không có KhamChuyenKhoa!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildKhamChuyenKhoa(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaLuotKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaLuotKham"]);
            this.MaPhongKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaPhongKham"]);
            this.MaNhanVien_Static = (decimal)FunctionCommon.GetDBValue(row["MaNhanVien"]);
            this.MaLoaiKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaLoaiKham"]);
            this.MaTinhTrangKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaTinhTrangKham"]);
            this.NgayBatDau_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayBatDau"]);
            this.NgayKetThuc_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayKetThuc"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
