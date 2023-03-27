using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class BenhNhanCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaBenhNhan, string TenBenhNhan, decimal GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, decimal MaQuocTich, decimal MaDantoc, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("BenhNhan", new object[] { MaBenhNhan, TenBenhNhan, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaQuocTich, MaDantoc, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("BenhNhan", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("BenhNhan", field, paraValue);
        }
        
        /// Update 
        public static void Update_MaBenhNhan(decimal Id, decimal MaBenhNhan)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "MaBenhNhan", new object[] { Id, MaBenhNhan });
        }
        public static void Update_TenBenhNhan(decimal Id, string TenBenhNhan)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "TenBenhNhan", new object[] { Id, TenBenhNhan });
        }
        
        public static void Update_GioiTinh(decimal Id, decimal GioiTinh)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "GioiTinh", new object[] { Id, GioiTinh });
        }
        public static void Update_NgaySinh(decimal Id, DateTime NgaySinh)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "NgaySinh", new object[] { Id, NgaySinh });
        }
        public static void Update_DiaChi(decimal Id, string DiaChi)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "DiaChi", new object[] { Id, DiaChi });
        }
        public static void Update_SoDienThoai(decimal Id, string SoDienThoai)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "SoDienThoai", new object[] { Id, SoDienThoai });
        }
        public static void Update_MaQuocTich(decimal Id, decimal MaQuocTich)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "MaQuocTich", new object[] { Id, MaQuocTich });
        }
        public static void Update_MaDantoc(decimal Id, decimal MaDantoc)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "MaDantoc", new object[] { Id, MaDantoc });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("BenhNhan", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("BenhNhan", Id);
        }
    }
}
