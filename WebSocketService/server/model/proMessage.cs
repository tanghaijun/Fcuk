using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace Connection.model
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
            // dynamic returndata = null;
            int state = 0;
            string returndata = "";
            string message = "";
            sendtype = SendTypeEnum.SendType.none;
            var js = new System.Web.Script.Serialization.JavaScriptSerializer();
            try
            {
                state = 100;
                switch (action)
                {
                    case "login":
                        var model = js.Deserialize<Login>(data);
                        var umodel = new LoginUser();
                        if (UserBLL.CheckHasUser(model.name, model.pwd, out umodel))
                        {
                            returndata = umodel.NickName + "欢迎登陆。。" + DateTime.Now.ToString();
                            message = "ok";
                            user.UserName = umodel.NickName;
                            user.UserPwd = umodel.LoginPwd;
                            user.Id = umodel.Id;
                            userlist.Add(user);
                            add(user);
                        }
                        else
                        {
                            message = "用户名或者密码错误";
                        }
                        sendtype = SendTypeEnum.SendType.signal;
                        break;
                    case "logout":
                        message = "ok";
                        //取消用户列表中的数据
                        userlist.Remove(user);
                        break;
                    case "allmessage":
                        var messagemodel = js.Deserialize<Message>(data);
                        message = "ok";
                        returndata = user.UserName + "(" + user.Ip + ")对所有人说：" + messagemodel.message;
                        sendtype = SendTypeEnum.SendType.all;
                        break;
                    case "list"://获取用户数据列表
                        //returndata = userlist;
                        string aggregate = (from e in userlist
                                            select string.Format("{0}", e.Ip)).Aggregate((a, b) => a + "," + b);
                        returndata = String.Format("[{0}]", aggregate);

                        message = "ok";
                        sendtype = SendTypeEnum.SendType.list;
                        break;
                }
            }
            catch (Exception ex)
            {

                state = 101;
                message = ex.ToString();
                action = "error";
            }

            returnMes = js.Serialize(new { action = action, state = state, message = message, data = returndata });
            return returnMes;
        }
        public static void SendMessage(User user, string message, SendTypeEnum.SendType type, List<User> userlist)
        {
            switch (type)
            {
                case SendTypeEnum.SendType.all:
                    SendToAllClient(user, userlist, message);
                    break;
                case SendTypeEnum.SendType.error:
                    SendToClient(user, userlist, message);
                    break;
                case SendTypeEnum.SendType.signal:
                    SendToClient(user, userlist, message);
                    break;
                case SendTypeEnum.SendType.none:
                    SendToClient(user, userlist, message);
                    break;
                case SendTypeEnum.SendType.logout:
                    user.Client.Close();
                    break;
                case SendTypeEnum.SendType.list:
                    SendToClient(user, userlist, message);
                    break;
            }
        }
        /// <summary>
        /// 发送消息给指定用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        static void SendToClient(User user, List<User> list, string message)
        {

            try
            {
                if (user.Client.Connected)
                {
                    //textBox2.AppendText("向" + user.Ip.ToString() + "发送消息!\r\n");
                    //int num = user.Client.SendTo(Common.PackData(message), user.Ip);
                    //var bt = Common.PackData(message);
                    //user.Client.Send(bt,bt.Length,System.Net.Sockets.SocketFlags.None);
                    user.Client.Send(Common.PackData(message));
                }
                else
                {

                    user.Client.Close();
                    list.Remove(user);
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
        static void SendToAllClient(User user, List<User> userlist, string message)
        {
            for (int i = 0; i < userlist.Count; i++)
            {

                SendToClient(userlist[i], userlist, message);

            }

        }

    }
}
