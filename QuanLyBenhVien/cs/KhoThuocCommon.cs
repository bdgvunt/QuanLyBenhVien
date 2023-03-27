using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class KhoThuocCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaThuoc, decimal MaKho, string SoLo, DateTime HanDung, DateTime NgayTao, decimal? MaPhieu, decimal LoaiPhieu, decimal SoLuong, decimal TinhTrangId, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("KhoThuoc", new object[] { MaThuoc, MaKho, SoLo, HanDung, NgayTao, MaPhieu, LoaiPhieu, SoLuong, TinhTrangId, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("KhoThuoc", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("KhoThuoc", field, paraValue);
        }
        /// Update 
        public static void Update_MaThuoc(decimal Id, decimal MaThuoc)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "MaThuoc", new object[] { Id, MaThuoc });
        }
        public static void Update_MaKho(decimal Id, decimal MaKho)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "MaKho", new object[] { Id, MaKho });
        }
        public static void Update_SoLo(decimal Id, string SoLo)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "SoLo", new object[] { Id, SoLo });
        }
        public static void Update_HanDung(decimal Id, DateTime HanDung)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "HanDung", new object[] { Id, HanDung });
        }
        public static void Update_NgayTao(decimal Id, DateTime NgayTao)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "NgayTao", new object[] { Id, NgayTao });
        }
        public static void Update_MaPhieu(decimal Id, decimal? MaPhieu)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "MaPhieu", new object[] { Id, MaPhieu });
        }
        public static void Update_LoaiPhieu(decimal Id, decimal LoaiPhieu)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "LoaiPhieu", new object[] { Id, LoaiPhieu });
        }
        public static void Update_SoLuong(decimal Id, decimal SoLuong)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "SoLuong", new object[] { Id, SoLuong });
        }
        public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "TinhTrangId", new object[] { Id, TinhTrangId });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("KhoThuoc", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("KhoThuoc", Id);
        }
    }
}
