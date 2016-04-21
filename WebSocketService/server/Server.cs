using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using Connection.model;
using System.Web;

namespace Connection
{
    public partial class Server : Form
    {
        public Server()
        {

            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        List<User> userlist = new List<User>();
        IPAddress ipserver = null;
        int port = int.Parse(ConfigurationManager.AppSettings["ServicePort"]);
        Socket mylistener = null;
        bool isNormalExit = false;
        private IPEndPoint localEP = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = true;
            isNormalExit = false;
            mylistener = null;
            userlist.Clear();
            try
            {
                ipserver = IPAddress.Parse(textBox1.Text.Trim());
                localEP = new IPEndPoint(ipserver, port);
                mylistener = new Socket(localEP.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                mylistener.Bind(localEP);
                mylistener.Listen(10);
                textBox2.AppendText("Start listen!\r\n");
                btnStart.Enabled = false;
                //监听
                Thread myThread = new Thread(listenClientConn);
                myThread.IsBackground = true;
                myThread.Start();
            }
            catch (Exception)
            {
                textBox2.AppendText("start listen faile!\r\n");
            }



        }
        void listenClientConn()
        {
            Socket Client = null;
            while (true)
            {
                try
                {
                    Client = mylistener.Accept();
                    User user = new User(Client);

                    Thread threadReceive = new Thread(ReceiveData);
                    //threadReceive.IsBackground = true;
                    threadReceive.Start(user);

                }
                catch (Exception e)
                {
                    break;
                }

            }


        }
        void ReceiveData(object userState)
        {
            User user = (User)userState;
            Socket client = user.Client;

            user.Client.Send(PackHandShakeData(GetSecKeyAccetp(user.buffer, user.Bufferlength)));
            textBox2.AppendText("已经发送握手协议了....\r\n");
            userlist.Add(user);
            AddUser(user);
            while (true)
            {
                try
                {
                    //接受客户端数据
                    byte[] buffer = new byte[1024];
                    textBox2.AppendText("等待客户端数据....\r\n");
                    //Thread.Sleep(100);
                    //user.Client.ReceiveTimeout = 10000;

                    int length = user.Client.Receive(buffer);//接受客户端信息
                    string clientMsg = AnalyticData(buffer, length);
                    clientMsg = HttpUtility.UrlDecode(clientMsg);
                    buffer = null;
                    textBox2.AppendText("接受到客户端数据：" + clientMsg + "\r\n");

                    string sendMsg = "";
                    SendTypeEnum.SendType sendtype = SendTypeEnum.SendType.none;
                    //提取其中的action
                    if (clientMsg == "�")
                    {
                        //close
                        user.Client.Close();
                        userlist.Remove(user);
                        RemoveUser(user);
                        break;
                    }

                    var reg = new Regex("\"action\":\"([a-zA-Z]{2,})\"");
                    var ismatch = reg.IsMatch(clientMsg);
                    if (ismatch)
                    {
                        var action = reg.Match(clientMsg).Groups[1].Value;
                        sendMsg = proMessage.MessageHandler(action, clientMsg, user, userlist, out sendtype, new proMessage.Adduser(AddUser));
                        proMessage.SendMessage(user, sendMsg, sendtype, userlist);
                    }
                    else
                    {
                        //传入格式错误
                        textBox2.AppendText("发送数据：“" + sendMsg + "” 至客户端....\r\n");

                        sendMsg = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(new { action = "error", mes = "请求错误" });
                        proMessage.SendMessage(user, sendMsg, SendTypeEnum.SendType.signal, userlist);
                    }

                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.ToString());

                    var sendMsg = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(new { action = "logout", mes = "请求错误" });
                    proMessage.SendMessage(user, sendMsg, SendTypeEnum.SendType.signal, userlist);
                    RemoveUser(user);
                    break;
                }

            }
        }
        public void AddUser(User user)
        {
            listView1.Items.Add(new ListViewItem(user.Ip.ToString()));

        }
        /// <summary>
        /// 移除用户
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(User user)
        {
            string name = user.Ip.ToString();
            if (listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == name)
                    {
                        listView1.Items.Remove(item);
                        break;
                    }
                }
            }
            if (userlist.Count > 0)
            {
                userlist.Remove(user);

            }
            if (user.Client != null)
            {
                user.Client.Close();
            }

            textBox2.AppendText("当前用户数：" + userlist.Count.ToString() + "!");


        }
        private void Server_Load(object sender, EventArgs e)
        {
            textBox1.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.AppendText("停止服务器!\r\n");
                isNormalExit = true;
                for (int i = userlist.Count - 1; i >= 0; i--)
                {
                    RemoveUser(userlist[i]);
                }
                mylistener.Close(5);
                btnStart.Enabled = true;
                btnClose.Enabled = false;
            }
            catch (Exception)
            {


            }




        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mylistener != null)
            {
                btnClose.PerformClick();

            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.FocusedItem.Text);
        }
        /// <summary>
        /// 打包握手信息
        /// </summary>
        /// <param name="secKeyAccept">Sec-WebSocket-Accept</param>
        /// <returns>数据包</returns>
        private static byte[] PackHandShakeData(string secKeyAccept)
        {
            var responseBuilder = new StringBuilder();
            responseBuilder.Append("HTTP/1.1 101 Switching Protocols" + Environment.NewLine);
            responseBuilder.Append("Upgrade: websocket" + Environment.NewLine);
            responseBuilder.Append("Connection: Upgrade" + Environment.NewLine);
            responseBuilder.Append("Sec-WebSocket-Accept: " + secKeyAccept + Environment.NewLine + Environment.NewLine);
            //如果把上一行换成下面两行，才是thewebsocketprotocol-17协议，但居然握手不成功，目前仍没弄明白！
            //responseBuilder.Append("Sec-WebSocket-Accept: " + secKeyAccept + Environment.NewLine);
            //responseBuilder.Append("Sec-WebSocket-Protocol: chat" + Environment.NewLine);

            return Encoding.UTF8.GetBytes(responseBuilder.ToString());
        }
        /// <summary>
        /// 生成Sec-WebSocket-Accept
        /// </summary>
        /// <param name="handShakeText">客户端握手信息</param>
        /// <returns>Sec-WebSocket-Accept</returns>
        private static string GetSecKeyAccetp(byte[] handShakeBytes, int bytesLength)
        {
            string handShakeText = Encoding.UTF8.GetString(handShakeBytes, 0, bytesLength);
            string key = string.Empty;
            Regex r = new Regex(@"Sec\-WebSocket\-Key:(.*?)\r\n");
            Match m = r.Match(handShakeText);
            if (m.Groups.Count != 0)
            {
                key = Regex.Replace(m.Value, @"Sec\-WebSocket\-Key:(.*?)\r\n", "$1").Trim();
            }
            byte[] encryptionString = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(key + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"));
            return Convert.ToBase64String(encryptionString);
        }

        /// <summary>
        /// 解析客户端数据包
        /// </summary>
        /// <param name="recBytes">服务器接收的数据包</param>
        /// <param name="recByteLength">有效数据长度</param>
        /// <returns></returns>
        private static string AnalyticData(byte[] recBytes, int recByteLength)
        {
            if (recByteLength < 2) { return string.Empty; }

            bool fin = (recBytes[0] & 0x80) == 0x80; // 1bit，1表示最后一帧  
            if (!fin)
            {
                return string.Empty;// 超过一帧暂不处理 
            }

            bool mask_flag = (recBytes[1] & 0x80) == 0x80; // 是否包含掩码  
            if (!mask_flag)
            {
                return string.Empty;// 不包含掩码的暂不处理
            }

            int payload_len = recBytes[1] & 0x7F; // 数据长度  

            byte[] masks = new byte[4];
            byte[] payload_data;

            if (payload_len == 126)
            {
                Array.Copy(recBytes, 4, masks, 0, 4);
                payload_len = (UInt16)(recBytes[2] << 8 | recBytes[3]);
                payload_data = new byte[payload_len];
                Array.Copy(recBytes, 8, payload_data, 0, payload_len);

            }
            else if (payload_len == 127)
            {
                Array.Copy(recBytes, 10, masks, 0, 4);
                byte[] uInt64Bytes = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    uInt64Bytes[i] = recBytes[9 - i];
                }
                UInt64 len = BitConverter.ToUInt64(uInt64Bytes, 0);

                payload_data = new byte[len];
                for (UInt64 i = 0; i < len; i++)
                {
                    payload_data[i] = recBytes[i + 14];
                }
            }
            else
            {
                Array.Copy(recBytes, 2, masks, 0, 4);
                payload_data = new byte[payload_len];
                Array.Copy(recBytes, 6, payload_data, 0, payload_len);

            }

            for (var i = 0; i < payload_len; i++)
            {
                payload_data[i] = (byte)(payload_data[i] ^ masks[i % 4]);
            }

            return Encoding.UTF8.GetString(payload_data);
        }



    }
}
