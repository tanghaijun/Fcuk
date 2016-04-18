using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace 通信.model
{
    public class Common
    {
        /// <summary>
        /// 打包服务器数据
        /// </summary>
        /// <param name="message">数据</param>
        /// <returns>数据包</returns>
        public static byte[] PackData(string message)
        {
            byte[] contentBytes = null;
            byte[] temp = Encoding.UTF8.GetBytes(message);

            if (temp.Length < 126)
            {
                contentBytes = new byte[temp.Length + 2];
                contentBytes[0] = 0x81;
                contentBytes[1] = (byte)temp.Length;
                Array.Copy(temp, 0, contentBytes, 2, temp.Length);
            }
            else if (temp.Length < 0xFFFF)
            {
                contentBytes = new byte[temp.Length + 4];
                contentBytes[0] = 0x81;
                contentBytes[1] = 126;
                contentBytes[2] = (byte)(temp.Length & 0xFF);
                contentBytes[3] = (byte)(temp.Length >> 8 & 0xFF);
                Array.Copy(temp, 0, contentBytes, 4, temp.Length);
            }
            else
            {
                // 暂不处理超长内容  
            }

            return contentBytes;
        }
        /// <summary>
        /// 获取字符串的md5码
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>返回的md5码</returns>
        public static string getMD5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] md5byte = md5.ComputeHash(bytes);
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5byte.Length; i++)
            {
                sb.Append(md5byte[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
