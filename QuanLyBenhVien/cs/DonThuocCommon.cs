using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class DonThuocCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaKhoThuoc, decimal? MaKhamChuyenKhoa, decimal? MaChiTietChungTu, decimal Sang, decimal Trua, decimal Chieu, decimal Toi, decimal Soluong, decimal NgayDung, decimal DonGia, string CachDung, DateTime NgayKe, DateTime? NgayPhat, decimal? NguoiPhat, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("DonThuoc", new object[] { MaKhoThuoc, MaKhamChuyenKhoa, MaChiTietChungTu, Sang, Trua, Chieu, Toi, Soluong, NgayDung, DonGia, CachDung, NgayKe, NgayPhat, NguoiPhat, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("DonThuoc", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("DonThuoc", field, paraValue);
        }
        public static DataTable Select_MaKhamChuyenKhoa(decimal MaKhamChuyenKhoa)
        {
            return ConnectionSQL.GetDataTable("DonThuoc_Select_MaKhamChuyenKhoa", new object[] { MaKhamChuyenKhoa });
        }


        /// Update 
        public static void Update_MaKhoThuoc(decimal Id, decimal MaKhoThuoc)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "MaKhoThuoc", new object[] { Id, MaKhoThuoc });
        }
        public static void Update_MaKhamChuyenKhoa(decimal Id, decimal MaKhamChuyenKhoa)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "MaKhamChuyenKhoa", new object[] { Id, MaKhamChuyenKhoa });
        }
        public static void Update_MaChiTietChungTu(decimal Id, decimal? MaChiTietChungTu)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "MaChiTietChungTu", new object[] { Id, MaChiTietChungTu });
        }
        public static void Update_Sang(decimal Id, decimal Sang)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "Sang", new object[] { Id, Sang });
        }
        public static void Update_Trua(decimal Id, decimal Trua)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "Trua", new object[] { Id, Trua });
        }
        public static void Update_Chieu(decimal Id, decimal Chieu)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "Chieu", new object[] { Id, Chieu });
        }
        public static void Update_Toi(decimal Id, decimal Toi)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "Toi", new object[] { Id, Toi });
        }
        public static void Update_Soluong(decimal Id, decimal Soluong)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "Soluong", new object[] { Id, Soluong });
        }
        public static void Update_NgayDung(decimal Id, decimal NgayDung)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "NgayDung", new object[] { Id, NgayDung });
        }
        public static void Update_DonGia(decimal Id, decimal DonGia)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "DonGia", new object[] { Id, DonGia });
        }
        public static void Update_CachDung(decimal Id, string CachDung)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "CachDung", new object[] { Id, CachDung });
        }
        public static void Update_NgayKe(decimal Id, DateTime NgayKe)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "NgayKe", new object[] { Id, NgayKe });
        }
        public static void Update_NgayPhat(decimal Id, DateTime? NgayPhat)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "NgayPhat", new object[] { Id, NgayPhat });
        }
        public static void Update_NguoiPhat(decimal Id, decimal? NguoiPhat)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "NguoiPhat", new object[] { Id, NguoiPhat });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("DonThuoc", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("DonThuoc", Id);
        }
    }
}
