using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class PhieuChiDinh
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaKhamChuyenKhoa_Static;
private decimal MaNhanVien_Static;
private DateTime NgayLapPhieu_Static;
private string GhiChu_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaKhamChuyenKhoa
{ 
     get 
     { 
         return this.MaKhamChuyenKhoa_Static; 
     } 
     set 
     { 
         PhieuChiDinhCommon.Update_MaKhamChuyenKhoa(this.Id, value);
         this.MaKhamChuyenKhoa_Static = value;
     }
} 


public decimal MaNhanVien
{ 
     get 
     { 
         return this.MaNhanVien_Static; 
     } 
     set 
     { 
         PhieuChiDinhCommon.Update_MaNhanVien(this.Id, value);
         this.MaNhanVien_Static = value;
     }
} 


public DateTime NgayLapPhieu
{ 
     get 
     { 
         return this.NgayLapPhieu_Static; 
     } 
     set 
     { 
         PhieuChiDinhCommon.Update_NgayLapPhieu(this.Id, value);
         this.NgayLapPhieu_Static = value;
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
         PhieuChiDinhCommon.Update_GhiChu(this.Id, value);
         this.GhiChu_Static = value;
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
         PhieuChiDinhCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectPhieuChiDinh
        /// </summary> 
public PhieuChiDinh(decimal Id)
{
    DataTable Table = PhieuChiDinhCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildPhieuChiDinh(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có PhieuChiDinh!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildPhieuChiDinh(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaKhamChuyenKhoa_Static = (decimal)FunctionCommon.GetDBValue(row["MaKhamChuyenKhoa"]); 
    this.MaNhanVien_Static = (decimal)FunctionCommon.GetDBValue(row["MaNhanVien"]); 
    this.NgayLapPhieu_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayLapPhieu"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
