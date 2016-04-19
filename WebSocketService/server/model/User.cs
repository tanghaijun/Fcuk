using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Connection
{
    public class User
    {
        private Socket _client;

        public Socket Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        /// <summary>
        /// 接收到的字节数组
        /// </summary>
        public byte[] buffer { get; set; }
        /// <summary>
        /// 接收到的数组长度
        /// </summary>
        public int Bufferlength { get; set; }
        /// <summary>
        /// 接收到的内容
        /// </summary>
        //public string Content { get; set; }
        public User(Socket client)
        {
            byte[] _buffer = new byte[1024];
            this._client = client;
            Bufferlength = client.Receive(_buffer);
            Ip = client.RemoteEndPoint;
            //Content = System.Text.Encoding.UTF8.GetString(_buffer);
            //Content = AnalyticData(_buffer, Bufferlength);
            buffer = _buffer;
            
        }

        public EndPoint Ip { get; set; }
    }
}
