using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class NhanVienCommon 
     {       
 /// Insert  
public static decimal Insert(string TenNhanVien, string ChuyenMon, string Khoa, string Chucvu, decimal MaHanhNghe, string Username, string Password, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("NhanVien", new object[] { TenNhanVien, ChuyenMon, Khoa, Chucvu, MaHanhNghe, Username, Password, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("NhanVien","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("NhanVien", field, paraValue); 
 } 
 /// Update 
public static void Update_TenNhanVien(decimal Id, string TenNhanVien)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "TenNhanVien", new object[] { Id, TenNhanVien});
} 
public static void Update_ChuyenMon(decimal Id, string ChuyenMon)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "ChuyenMon", new object[] { Id, ChuyenMon});
} 
public static void Update_Khoa(decimal Id, string Khoa)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "Khoa", new object[] { Id, Khoa});
} 
public static void Update_Chucvu(decimal Id, string Chucvu)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "Chucvu", new object[] { Id, Chucvu});
} 
public static void Update_MaHanhNghe(decimal Id, decimal MaHanhNghe)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "MaHanhNghe", new object[] { Id, MaHanhNghe});
} 
public static void Update_Username(decimal Id, string Username)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "Username", new object[] { Id, Username});
} 
public static void Update_Password(decimal Id, string Password)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "Password", new object[] { Id, Password});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("NhanVien", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("NhanVien", Id ); 
} 
} 
} 
