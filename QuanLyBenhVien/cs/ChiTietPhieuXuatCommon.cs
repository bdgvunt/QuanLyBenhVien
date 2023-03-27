using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class ChiTietPhieuXuatCommon 
     {       
 /// Insert  
public static decimal Insert(decimal MaPhieuXuat, decimal MaKhoThuoc, decimal SoLuong, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("ChiTietPhieuXuat", new object[] { MaPhieuXuat, MaKhoThuoc, SoLuong, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("ChiTietPhieuXuat","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("ChiTietPhieuXuat", field, paraValue); 
 } 
 /// Update 
public static void Update_MaPhieuXuat(decimal Id, decimal MaPhieuXuat)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuXuat", "MaPhieuXuat", new object[] { Id, MaPhieuXuat});
} 
public static void Update_MaKhoThuoc(decimal Id, decimal MaKhoThuoc)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuXuat", "MaKhoThuoc", new object[] { Id, MaKhoThuoc});
} 
public static void Update_SoLuong(decimal Id, decimal SoLuong)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuXuat", "SoLuong", new object[] { Id, SoLuong});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuXuat", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("ChiTietPhieuXuat", Id ); 
} 
} 
} 
