using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace ZYPasswordManager
{
    public class MD5Algorithm
    {
        public string ToMD5(string strs)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(strs);//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(bytes);//将字符串加密后也转换为字符数组
            return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串
        }

        public string FromMD5(string strs)
        {
            return strs;
        }
    }
}
