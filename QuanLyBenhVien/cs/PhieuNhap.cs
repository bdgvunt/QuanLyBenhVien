using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class PhieuNhap
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaNhanVien_Static;
private decimal MaKho_Static;
private string NhaCungCap_Static;
private DateTime NgayLap_Static;
private string MaHoaDon_Static;
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


public decimal MaNhanVien
{ 
     get 
     { 
         return this.MaNhanVien_Static; 
     } 
     set 
     { 
         PhieuNhapCommon.Update_MaNhanVien(this.Id, value);
         this.MaNhanVien_Static = value;
     }
} 


public decimal MaKho
{ 
     get 
     { 
         return this.MaKho_Static; 
     } 
     set 
     { 
         PhieuNhapCommon.Update_MaKho(this.Id, value);
         this.MaKho_Static = value;
     }
} 


public string NhaCungCap
{ 
     get 
     { 
         return this.NhaCungCap_Static; 
     } 
     set 
     { 
         PhieuNhapCommon.Update_NhaCungCap(this.Id, value);
         this.NhaCungCap_Static = value;
     }
} 


public DateTime NgayLap
{ 
     get 
     { 
         return this.NgayLap_Static; 
     } 
     set 
     { 
         PhieuNhapCommon.Update_NgayLap(this.Id, value);
         this.NgayLap_Static = value;
     }
} 


public string MaHoaDon
{ 
     get 
     { 
         return this.MaHoaDon_Static; 
     } 
     set 
     { 
         PhieuNhapCommon.Update_MaHoaDon(this.Id, value);
         this.MaHoaDon_Static = value;
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
         PhieuNhapCommon.Update_GhiChu(this.Id, value);
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
         PhieuNhapCommon.Update_TinhTrangId(this.Id, value);
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
         PhieuNhapCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectPhieuNhap
        /// </summary> 
public PhieuNhap(decimal Id)
{
    DataTable Table = PhieuNhapCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildPhieuNhap(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có PhieuNhap!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildPhieuNhap(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaNhanVien_Static = (decimal)FunctionCommon.GetDBValue(row["MaNhanVien"]); 
    this.MaKho_Static = (decimal)FunctionCommon.GetDBValue(row["MaKho"]); 
    this.NhaCungCap_Static = (string)FunctionCommon.GetDBValue(row["NhaCungCap"]); 
    this.NgayLap_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayLap"]); 
    this.MaHoaDon_Static = (string)FunctionCommon.GetDBValue(row["MaHoaDon"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
