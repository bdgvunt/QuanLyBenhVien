using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class ChiTietPhieuNhapCommon 
     {       
 /// Insert  
public static decimal Insert(decimal MaPhieuNhap, decimal MaThuoc, string SoLo, DateTime HanDung, decimal SoLuong, decimal DonGia, decimal GhiChu, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("ChiTietPhieuNhap", new object[] { MaPhieuNhap, MaThuoc, SoLo, HanDung, SoLuong, DonGia, GhiChu, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("ChiTietPhieuNhap","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("ChiTietPhieuNhap", field, paraValue); 
 } 
 /// Update 
public static void Update_MaPhieuNhap(decimal Id, decimal MaPhieuNhap)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "MaPhieuNhap", new object[] { Id, MaPhieuNhap});
} 
public static void Update_MaThuoc(decimal Id, decimal MaThuoc)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "MaThuoc", new object[] { Id, MaThuoc});
} 
public static void Update_SoLo(decimal Id, string SoLo)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "SoLo", new object[] { Id, SoLo});
} 
public static void Update_HanDung(decimal Id, DateTime HanDung)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "HanDung", new object[] { Id, HanDung});
} 
public static void Update_SoLuong(decimal Id, decimal SoLuong)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "SoLuong", new object[] { Id, SoLuong});
} 
public static void Update_DonGia(decimal Id, decimal DonGia)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "DonGia", new object[] { Id, DonGia});
} 
public static void Update_GhiChu(decimal Id, decimal GhiChu)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("ChiTietPhieuNhap", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("ChiTietPhieuNhap", Id ); 
} 
} 
} 
