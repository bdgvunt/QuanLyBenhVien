using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class ChiTietPhieuXuat
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaPhieuXuat_Static;
private decimal MaKhoThuoc_Static;
private decimal SoLuong_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaPhieuXuat
{ 
     get 
     { 
         return this.MaPhieuXuat_Static; 
     } 
     set 
     { 
         ChiTietPhieuXuatCommon.Update_MaPhieuXuat(this.Id, value);
         this.MaPhieuXuat_Static = value;
     }
} 


public decimal MaKhoThuoc
{ 
     get 
     { 
         return this.MaKhoThuoc_Static; 
     } 
     set 
     { 
         ChiTietPhieuXuatCommon.Update_MaKhoThuoc(this.Id, value);
         this.MaKhoThuoc_Static = value;
     }
} 


public decimal SoLuong
{ 
     get 
     { 
         return this.SoLuong_Static; 
     } 
     set 
     { 
         ChiTietPhieuXuatCommon.Update_SoLuong(this.Id, value);
         this.SoLuong_Static = value;
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
         ChiTietPhieuXuatCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectChiTietPhieuXuat
        /// </summary> 
public ChiTietPhieuXuat(decimal Id)
{
    DataTable Table = ChiTietPhieuXuatCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildChiTietPhieuXuat(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có ChiTietPhieuXuat!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildChiTietPhieuXuat(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaPhieuXuat_Static = (decimal)FunctionCommon.GetDBValue(row["MaPhieuXuat"]); 
    this.MaKhoThuoc_Static = (decimal)FunctionCommon.GetDBValue(row["MaKhoThuoc"]); 
    this.SoLuong_Static = (decimal)FunctionCommon.GetDBValue(row["SoLuong"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
