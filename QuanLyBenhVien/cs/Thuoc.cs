using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class Thuoc
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaDonViTinh_Static;
private string MaThuoc_Static;
private string TenThuoc_Static;
private string HoatChat_Static;
private string HamLuong_Static;
private string CachDung_Static;
private decimal TinhTrangId_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaDonViTinh
{ 
     get 
     { 
         return this.MaDonViTinh_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_MaDonViTinh(this.Id, value);
         this.MaDonViTinh_Static = value;
     }
} 


public string MaThuoc
{ 
     get 
     { 
         return this.MaThuoc_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_MaThuoc(this.Id, value);
         this.MaThuoc_Static = value;
     }
} 


public string TenThuoc
{ 
     get 
     { 
         return this.TenThuoc_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_TenThuoc(this.Id, value);
         this.TenThuoc_Static = value;
     }
} 


public string HoatChat
{ 
     get 
     { 
         return this.HoatChat_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_HoatChat(this.Id, value);
         this.HoatChat_Static = value;
     }
} 


public string HamLuong
{ 
     get 
     { 
         return this.HamLuong_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_HamLuong(this.Id, value);
         this.HamLuong_Static = value;
     }
} 


public string CachDung
{ 
     get 
     { 
         return this.CachDung_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_CachDung(this.Id, value);
         this.CachDung_Static = value;
     }
} 


public decimal TinhTrangId
{ 
     get 
     { 
         return this.TinhTrangId_Static; 
     } 
     set 
     { 
         ThuocCommon.Update_TinhTrangId(this.Id, value);
         this.TinhTrangId_Static = value;
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
         ThuocCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectThuoc
        /// </summary> 
public Thuoc(decimal Id)
{
    DataTable Table = ThuocCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildThuoc(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có Thuoc!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildThuoc(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaDonViTinh_Static = (decimal)FunctionCommon.GetDBValue(row["MaDonViTinh"]); 
    this.MaThuoc_Static = (string)FunctionCommon.GetDBValue(row["MaThuoc"]); 
    this.TenThuoc_Static = (string)FunctionCommon.GetDBValue(row["TenThuoc"]); 
    this.HoatChat_Static = (string)FunctionCommon.GetDBValue(row["HoatChat"]); 
    this.HamLuong_Static = (string)FunctionCommon.GetDBValue(row["HamLuong"]); 
    this.CachDung_Static = (string)FunctionCommon.GetDBValue(row["CachDung"]); 
    this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
