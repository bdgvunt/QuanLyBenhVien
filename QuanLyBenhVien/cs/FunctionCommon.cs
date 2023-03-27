using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace QuanLyBenhVien
{
    public static class FunctionCommon
    {
        /// <summary>
        /// Hàm trả về giá trị từ database
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static object GetDBValue(object src)
        {
            if (src == DBNull.Value)
                return null;
            else
                return src;
        }

        /// <summary>
        /// Hàm hỗ trợ mã hóa
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string MD5Sum(string source)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(source));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
