using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class ThuocCommon 
     {       
 /// Insert  
public static decimal Insert(decimal MaDonViTinh, string MaThuoc, string TenThuoc, string HoatChat, string HamLuong, string CachDung, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("Thuoc", new object[] { MaDonViTinh, MaThuoc, TenThuoc, HoatChat, HamLuong, CachDung, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("Thuoc","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("Thuoc", field, paraValue); 
 } 
 /// Update 
public static void Update_MaDonViTinh(decimal Id, decimal MaDonViTinh)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "MaDonViTinh", new object[] { Id, MaDonViTinh});
} 
public static void Update_MaThuoc(decimal Id, string MaThuoc)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "MaThuoc", new object[] { Id, MaThuoc});
} 
public static void Update_TenThuoc(decimal Id, string TenThuoc)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "TenThuoc", new object[] { Id, TenThuoc});
} 
public static void Update_HoatChat(decimal Id, string HoatChat)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "HoatChat", new object[] { Id, HoatChat});
} 
public static void Update_HamLuong(decimal Id, string HamLuong)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "HamLuong", new object[] { Id, HamLuong});
} 
public static void Update_CachDung(decimal Id, string CachDung)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "CachDung", new object[] { Id, CachDung});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("Thuoc", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("Thuoc", Id ); 
} 
} 
} 
