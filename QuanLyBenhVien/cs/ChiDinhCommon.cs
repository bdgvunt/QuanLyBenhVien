using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class ChiDinhCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaPhieuChiDinh, decimal MaDichVu, decimal MaNhanVien, decimal? MaChiTietChungTu, decimal BHYT, DateTime NgayChiDinh, DateTime? NgayKetQua, decimal? NguoiKetQua, decimal SoLuong, decimal DonGia, string GhiChu, decimal TinhTrangId, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("ChiDinh", new object[] { MaPhieuChiDinh, MaDichVu, MaNhanVien, MaChiTietChungTu, BHYT, NgayChiDinh, NgayKetQua, NguoiKetQua, SoLuong, DonGia, GhiChu, TinhTrangId, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("ChiDinh", "", new object[] { });
        }


        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("ChiDinh", field, paraValue);
        }

        public static DataTable Select_LuotKham(decimal MaLuotKham)
        {
            return ConnectionSQL.GetDataTable("ChiDinh_Select_LuotKham", new object[] { MaLuotKham });
        }

        /// Update 
        public static void Update_MaPhieuChiDinh(decimal Id, decimal MaPhieuChiDinh)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "MaPhieuChiDinh", new object[] { Id, MaPhieuChiDinh });
        }
        public static void Update_MaDichVu(decimal Id, decimal MaDichVu)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "MaDichVu", new object[] { Id, MaDichVu });
        }
        public static void Update_MaNhanVien(decimal Id, decimal MaNhanVien)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "MaNhanVien", new object[] { Id, MaNhanVien });
        }
        public static void Update_MaChiTietChungTu(decimal Id, decimal? MaChiTietChungTu)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "MaChiTietChungTu", new object[] { Id, MaChiTietChungTu });
        }
        
        public static void Update_BHYT(decimal Id, decimal BHYT)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "BHYT", new object[] { Id, BHYT });
        }
        public static void Update_NgayChiDinh(decimal Id, DateTime NgayChiDinh)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "NgayChiDinh", new object[] { Id, NgayChiDinh });
        }
        public static void Update_NgayKetQua(decimal Id, DateTime? NgayKetQua)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "NgayKetQua", new object[] { Id, NgayKetQua });
        }
        public static void Update_NguoiKetQua(decimal Id, decimal? NguoiKetQua)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "NguoiKetQua", new object[] { Id, NguoiKetQua });
        }
        public static void Update_SoLuong(decimal Id, decimal SoLuong)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "SoLuong", new object[] { Id, SoLuong });
        }
        public static void Update_DonGia(decimal Id, decimal DonGia)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "DonGia", new object[] { Id, DonGia });
        }
        public static void Update_GhiChu(decimal Id, string GhiChu)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "GhiChu", new object[] { Id, GhiChu });
        }
        public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "TinhTrangId", new object[] { Id, TinhTrangId });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("ChiDinh", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("ChiDinh", Id);
        }
    }
}
