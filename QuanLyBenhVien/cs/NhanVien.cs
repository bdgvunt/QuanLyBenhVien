using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class NhanVien
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private string TenNhanVien_Static;
private string ChuyenMon_Static;
private string Khoa_Static;
private string Chucvu_Static;
private decimal MaHanhNghe_Static;
private string Username_Static;
private string Password_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public string TenNhanVien
{ 
     get 
     { 
         return this.TenNhanVien_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_TenNhanVien(this.Id, value);
         this.TenNhanVien_Static = value;
     }
} 


public string ChuyenMon
{ 
     get 
     { 
         return this.ChuyenMon_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_ChuyenMon(this.Id, value);
         this.ChuyenMon_Static = value;
     }
} 


public string Khoa
{ 
     get 
     { 
         return this.Khoa_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_Khoa(this.Id, value);
         this.Khoa_Static = value;
     }
} 


public string Chucvu
{ 
     get 
     { 
         return this.Chucvu_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_Chucvu(this.Id, value);
         this.Chucvu_Static = value;
     }
} 


public decimal MaHanhNghe
{ 
     get 
     { 
         return this.MaHanhNghe_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_MaHanhNghe(this.Id, value);
         this.MaHanhNghe_Static = value;
     }
} 


public string Username
{ 
     get 
     { 
         return this.Username_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_Username(this.Id, value);
         this.Username_Static = value;
     }
} 


public string Password
{ 
     get 
     { 
         return this.Password_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_Password(this.Id, value);
         this.Password_Static = value;
     }
} 


public decimal TrangThaiId
{ 
     get 
     { 
         return this.TrangThaiId_Static; 
     } 
     set 
     { 
         NhanVienCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectNhanVien
        /// </summary> 
public NhanVien(decimal Id)
{
    DataTable Table = NhanVienCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildNhanVien(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có NhanVien!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildNhanVien(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.TenNhanVien_Static = (string)FunctionCommon.GetDBValue(row["TenNhanVien"]); 
    this.ChuyenMon_Static = (string)FunctionCommon.GetDBValue(row["ChuyenMon"]); 
    this.Khoa_Static = (string)FunctionCommon.GetDBValue(row["Khoa"]); 
    this.Chucvu_Static = (string)FunctionCommon.GetDBValue(row["Chucvu"]); 
    this.MaHanhNghe_Static = (decimal)FunctionCommon.GetDBValue(row["MaHanhNghe"]); 
    this.Username_Static = (string)FunctionCommon.GetDBValue(row["Username"]); 
    this.Password_Static = (string)FunctionCommon.GetDBValue(row["Password"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
