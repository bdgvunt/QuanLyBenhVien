using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class PhieuNhapCommon 
     {       
 /// Insert  
public static decimal Insert(decimal MaNhanVien, decimal MaKho, string NhaCungCap, DateTime NgayLap, string MaHoaDon, string GhiChu, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("PhieuNhap", new object[] { MaNhanVien, MaKho, NhaCungCap, NgayLap, MaHoaDon, GhiChu, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("PhieuNhap","", new object[] { }); 
}
        public static DataTable PhieuNhap_Select_Ngay(DateTime Tungay,DateTime Denngay)
        {
            return ConnectionSQL.GetDataTable("PhieuNhap_Select_Ngay", new object[] {Tungay , Denngay });
        }
        public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("PhieuNhap", field, paraValue); 
 } 
 /// Update 
public static void Update_MaNhanVien(decimal Id, decimal MaNhanVien)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "MaNhanVien", new object[] { Id, MaNhanVien});
} 
public static void Update_MaKho(decimal Id, decimal MaKho)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "MaKho", new object[] { Id, MaKho});
} 
public static void Update_NhaCungCap(decimal Id, string NhaCungCap)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "NhaCungCap", new object[] { Id, NhaCungCap});
} 
public static void Update_NgayLap(decimal Id, DateTime NgayLap)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "NgayLap", new object[] { Id, NgayLap});
} 
public static void Update_MaHoaDon(decimal Id, string MaHoaDon)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "MaHoaDon", new object[] { Id, MaHoaDon});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("PhieuNhap", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("PhieuNhap", Id ); 
} 
} 
} 
