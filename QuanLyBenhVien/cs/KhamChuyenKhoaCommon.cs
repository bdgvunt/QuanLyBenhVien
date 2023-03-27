using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class KhamChuyenKhoaCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaLuotKham, decimal MaPhongKham, decimal MaNhanVien, decimal MaLoaiKham, decimal MaTinhTrangKham, DateTime NgayBatDau, DateTime NgayKetThuc, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("KhamChuyenKhoa", new object[] { MaLuotKham, MaPhongKham, MaNhanVien, MaLoaiKham, MaTinhTrangKham, NgayBatDau, NgayKetThuc, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("KhamChuyenKhoa", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("KhamChuyenKhoa", field, paraValue);
        }
        /// Update 
        public static void Update_MaLuotKham(decimal Id, decimal MaLuotKham)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "MaLuotKham", new object[] { Id, MaLuotKham });
        }
        public static void Update_MaPhongKham(decimal Id, decimal MaPhongKham)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "MaPhongKham", new object[] { Id, MaPhongKham });
        }
        public static void Update_MaNhanVien(decimal Id, decimal MaNhanVien)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "MaNhanVien", new object[] { Id, MaNhanVien });
        }
        public static void Update_MaLoaiKham(decimal Id, decimal MaLoaiKham)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "MaLoaiKham", new object[] { Id, MaLoaiKham });
        }
        public static void Update_MaTinhTrangKham(decimal Id, decimal MaTinhTrangKham)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "MaTinhTrangKham", new object[] { Id, MaTinhTrangKham });
        }
        public static void Update_NgayBatDau(decimal Id, DateTime NgayBatDau)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "NgayBatDau", new object[] { Id, NgayBatDau });
        }
        public static void Update_NgayKetThuc(decimal Id, DateTime NgayKetThuc)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "NgayKetThuc", new object[] { Id, NgayKetThuc });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("KhamChuyenKhoa", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("KhamChuyenKhoa", Id);
        }
    }
}
