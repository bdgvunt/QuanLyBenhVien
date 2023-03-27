using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class LoaiKham
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private string TenLoaiKham_Static;
        private string GhiChu_Static;
        private decimal DichVuId_Static;
        private decimal TinhTrangId_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public string TenLoaiKham
        {
            get
            {
                return this.TenLoaiKham_Static;
            }
            set
            {
                LoaiKhamCommon.Update_TenLoaiKham(this.Id, value);
                this.TenLoaiKham_Static = value;
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
                LoaiKhamCommon.Update_GhiChu(this.Id, value);
                this.GhiChu_Static = value;
            }
        }


        public decimal DichVuId
        {
            get
            {
                return this.DichVuId_Static;
            }
            set
            {
                LoaiKhamCommon.Update_DichVuId(this.Id, value);
                this.DichVuId_Static = value;
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
                LoaiKhamCommon.Update_TinhTrangId(this.Id, value);
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
                LoaiKhamCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectLoaiKham
        /// </summary> 
        public LoaiKham(decimal Id)
        {
            DataTable Table = LoaiKhamCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildLoaiKham(Table.Rows[0]);
            }
            else
                throw new Exception("Không có LoaiKham!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildLoaiKham(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.TenLoaiKham_Static = (string)FunctionCommon.GetDBValue(row["TenLoaiKham"]);
            this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]);
            this.DichVuId_Static = (decimal)FunctionCommon.GetDBValue(row["DichVuId"]);
            this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
