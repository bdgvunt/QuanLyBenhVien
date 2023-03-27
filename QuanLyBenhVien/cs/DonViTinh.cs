using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class DonViTinh
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private string TenDonViTinh_Static;
private string GhiChu_Static;
private decimal TinhTrangId_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public string TenDonViTinh
{ 
     get 
     { 
         return this.TenDonViTinh_Static; 
     } 
     set 
     { 
         DonViTinhCommon.Update_TenDonViTinh(this.Id, value);
         this.TenDonViTinh_Static = value;
     }
} 


public string GhiChu
{ 
     get 
     { 
         return this.GhiChu_Static; 
     } 
     set 
     { 
         DonViTinhCommon.Update_GhiChu(this.Id, value);
         this.GhiChu_Static = value;
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
         DonViTinhCommon.Update_TinhTrangId(this.Id, value);
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
         DonViTinhCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectDonViTinh
        /// </summary> 
public DonViTinh(decimal Id)
{
    DataTable Table = DonViTinhCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildDonViTinh(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có DonViTinh!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildDonViTinh(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.TenDonViTinh_Static = (string)FunctionCommon.GetDBValue(row["TenDonViTinh"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
