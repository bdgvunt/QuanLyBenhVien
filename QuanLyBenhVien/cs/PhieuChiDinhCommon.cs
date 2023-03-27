using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class PhieuChiDinhCommon 
     {       
 /// Insert  
public static decimal Insert(decimal MaKhamChuyenKhoa, decimal MaNhanVien, DateTime NgayLapPhieu, string GhiChu, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("PhieuChiDinh", new object[] { MaKhamChuyenKhoa, MaNhanVien, NgayLapPhieu, GhiChu, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("PhieuChiDinh","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("PhieuChiDinh", field, paraValue); 
 } 
 /// Update 
public static void Update_MaKhamChuyenKhoa(decimal Id, decimal MaKhamChuyenKhoa)
{
     ConnectionSQL.ExecuteUpdate("PhieuChiDinh", "MaKhamChuyenKhoa", new object[] { Id, MaKhamChuyenKhoa});
} 
public static void Update_MaNhanVien(decimal Id, decimal MaNhanVien)
{
     ConnectionSQL.ExecuteUpdate("PhieuChiDinh", "MaNhanVien", new object[] { Id, MaNhanVien});
} 
public static void Update_NgayLapPhieu(decimal Id, DateTime NgayLapPhieu)
{
     ConnectionSQL.ExecuteUpdate("PhieuChiDinh", "NgayLapPhieu", new object[] { Id, NgayLapPhieu});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("PhieuChiDinh", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("PhieuChiDinh", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("PhieuChiDinh", Id ); 
} 
} 
} 
