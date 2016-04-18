using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace 通信.model
{
    public class proMessage
    {
        public delegate void Adduser(User user);
        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="action"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string MessageHandler(string action, string data, User user, List<User> userlist, out SendTypeEnum.SendType sendtype, Adduser add)
        {
            string returnMes = "";
            string returndata = "";
            string mes = "";
            sendtype = SendTypeEnum.SendType.none;
            var js = new System.Web.Script.Serialization.JavaScriptSerializer();
            switch (action)
            {
                case "login":
                    var model = js.Deserialize<Login>(data);
                    var umodel = new LoginUser();
                    if (UserBLL.CheckHasUser(model.name, model.pwd, out umodel))
                    {
                        mes = umodel.NickName + "欢迎登陆。。" + DateTime.Now.ToString();
                        returndata = "ok";
                        user.UserName = umodel.NickName;
                        user.UserPwd = umodel.LoginPwd;
                        user.Id = umodel.Id;
                        userlist.Add(user);
                        add(user);
                    }
                    else
                    {
                        returndata = "用户名或者密码错误";
                    }
                    sendtype = SendTypeEnum.SendType.signal;
                    break;
                case "logout":
                    returndata = "ok";
                    //取消用户列表中的数据
                    break;
                case "allmessage":
                    var messagemodel = js.Deserialize<Message>(data);
                    returndata = "ok";
                    mes = user.UserName + "(" + user.Ip + ")对所有人说：" + messagemodel.message + "----------" + DateTime.Now.ToString();
                    mes = HttpUtility.UrlEncode(mes, Encoding.UTF8);
                    sendtype = SendTypeEnum.SendType.all;
                    break;
            }
            returnMes = js.Serialize(new Message { action = action, state = returndata, message = mes });
            return returnMes;
        }
        public static void SendMessage(User user, string message, SendTypeEnum.SendType type, List<User> userlist)
        {
            switch (type)
            {
                case SendTypeEnum.SendType.all:
                    SendToAllClient(user, message, userlist);
                    break;
                case SendTypeEnum.SendType.error:
                    SendToClient(user, message);
                    break;
                case SendTypeEnum.SendType.signal:
                    SendToClient(user, message);
                    break;
                case SendTypeEnum.SendType.none:
                    SendToClient(user, message);
                    break;
                case SendTypeEnum.SendType.logout:
                    user.Client.Close();
                    break;
            }
        }
        /// <summary>
        /// 发送消息给指定用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        static void SendToClient(User user, string message)
        {

            try
            {
                if (user.Client.Connected)
                {
                    //textBox2.AppendText("向" + user.Ip.ToString() + "发送消息!\r\n");
                    //int num = user.Client.SendTo(Common.PackData(message), user.Ip);
                    var bt = Common.PackData(message);
                    user.Client.Send(bt,bt.Length,System.Net.Sockets.SocketFlags.None);
                }

                //user.Client.Send(Common.PackData(message));
                //
            }
            catch (Exception e)
            {
                //textBox2.AppendText("向" + user.UserName + "发送消息失败!\r\n");

            }
        }
        /// <summary>
        /// 发送消息给所有用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        static void SendToAllClient(User user, string message, List<User> userlist)
        {
            for (int i = 0; i < userlist.Count; i++)
            {

                SendToClient(userlist[i], message);

            }

        }

    }
}
