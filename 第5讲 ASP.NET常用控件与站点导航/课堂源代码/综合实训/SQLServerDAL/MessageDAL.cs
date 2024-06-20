using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BBS.IDAL ;
using BBS.Entity ;

namespace BBS.SQLServerDAL
{
    public class MessageDAL:IMessageDAL 
    {


        /// <summary>
        /// 插入帖子信息
        /// </summary>
        /// <param name="messge">帖子信息</param>
        /// <returns></returns>
        public bool Insert(MessageInfo messge)
        {
            string sql = "insert into TMessage (GuestName,MessageContent,MessageTime,IsPass,MessKind,MessageTitle,ClickNumber,IsTop,LastCommentTime) values('" + messge.GuestName + "','" + messge.Content + "','" + messge.Time + "','" + messge.Ispass + "','" + messge.MessKind + "','"+messge.Title+"','"+messge.ClickNumber +"','"+messge.IsTop +"','"+messge.LastTime +"')";
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
                
        }
        /// <summary>
        /// 删除帖子信息
        /// </summary>
        /// <param name="id">帖子id</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            string sql ="delete from TMessage where MessageID="+ id;
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        
        }
        /// <summary>
        /// 更新帖子信息
        /// </summary>
        /// <param name="message">帖子信息</param>
        /// <returns></returns>
        public bool Update(MessageInfo message)
        {
            string sql = "update TMessage set GuestName='"+message.GuestName +"',MessageContent='"+message.Content +"',MessageTime='"+message.Time+"',IsPass='"+message.Ispass +"',MessKind='"+message.MessKind +"',MessageTitle='"+message.Title+"',ClickNumber='"+message.ClickNumber +"',IsTop='"+message.IsTop+"',LastCommentTime='"+message.LastTime+ "'where MessageID="+message.ID ;
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        
        }
        /// <summary>
        /// 返回帖子信息
        /// </summary>
        /// <param name="id">帖子Id</param>
        /// <returns></returns>
        public MessageInfo GetByID(int id)
        {
            SqlDataReader datareader = null;
            string sql = "select * from TMessage where MessageID="+ id;
            try
            {
                datareader = SQLServerDALHelper.ExecuteSQLReader(sql);
                MessageInfo message = new MessageInfo();
                datareader.Read();
                message.ID = (int)datareader["MessageID"];
                message.GuestName = (string)datareader["GuestName"];
                //message.GuestEmail = (string)datareader["GuestEmail"];
                message.Content = (string)datareader["MessageContent"];
                message.Time = (DateTime )datareader["MessageTime"];
                message.Ispass = (string)datareader["IsPass"];
                message.MessKind = (string)datareader["MessKind"];
                message.Title = (string)datareader["MessageTitle"];
                message.ClickNumber = (int)datareader["ClickNumber"];
                message.IsTop = (int)datareader["IsTop"];
                message.LastTime = (DateTime)datareader["LastCommentTime"];
                return message;
            }
            catch
            {
                return null;
            }
            finally
            {
                 datareader.Close();
            }
        }
        /// <summary>
        /// 根据信息种类返回相应的信息并且根据参数决定是否返回通过验证的帖子
        /// </summary>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public IList<MessageInfo> GetByCategory(string category,int item)
        {
            string sql = "select * from TMessage where MessKind='" + category + "' order by IsTop DESC,LastCommentTime DESC,MessageTime DESC";
            if( item == 0 )
                sql = "select * from TMessage where MessKind ='" + category + "' and IsPass='pass' order by IsTop DESC ,LastCommentTime DESC ,MessageTime DESC";
            SqlDataReader datareader = null;
            datareader = SQLServerDALHelper.ExecuteSQLReader(sql);
            IList<MessageInfo> messagecollection = new List<MessageInfo>();
            try
            {
                while (datareader.Read())
                {
                    MessageInfo message = new MessageInfo();
                    message.ID = (int)datareader["MessageID"];
                    message.GuestName = (string)datareader["GuestName"];
                    //message.GuestEmail = (string)datareader["GuestEmail"];
                    message.Content = (string)datareader["MessageContent"];
                    message.Time = (DateTime)datareader["MessageTime"];
                    message.Ispass = (string)datareader["IsPass"];
                    message.MessKind = (string)datareader["MessKind"];
                    message.Title = (string)datareader["MessageTitle"];
                    message.ClickNumber = (int)datareader["ClickNumber"];
                    message.IsTop = (int)datareader["IsTop"];
                    message.LastTime = (DateTime)datareader["LastCommentTime"];
                    messagecollection.Add(message);
                }
                return messagecollection;
            }
            catch
            {
                return null;
            }
            finally
            {
                datareader.Close();
            }      
        }
        /// <summary>
        /// 根据版块名称删除相应的帖子及回复信息
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public bool DeleteByCategory(string category)
        {
            string sql1 = "select * from TMessage where MessKind='" + category + "'";
            string sql2;
            SqlDataReader datareader = null;
            datareader = SQLServerDALHelper.ExecuteSQLReader(sql1);
            IList<MessageInfo> messagecollection = new List<MessageInfo>();
            try
            {
                while (datareader.Read())
                {
                    MessageInfo message = new MessageInfo();
                    message.ID = (int)datareader["MessageID"];
                    message.GuestName = (string)datareader["GuestName"];
                    //message.GuestEmail = (string)datareader["GuestEmail"];
                    message.Content = (string)datareader["MessageContent"];
                    message.Time = (DateTime)datareader["MessageTime"];
                    message.Ispass = (string)datareader["IsPass"];
                    message.MessKind = (string)datareader["MessKind"];
                    message.Title = (string)datareader["MessageTitle"];
                    message.ClickNumber = (int)datareader["ClickNumber"];
                    message.IsTop = (int)datareader["IsTop"];
                    message.LastTime = (DateTime)datareader["LastCommentTime"];
                    messagecollection.Add(message);
                }
                datareader.Close();
                if (messagecollection != null)
                {
                    for (int i = 0; i < messagecollection.Count; i++)//删除本版块帖子相关的回复记录
                    {
                        sql2 = "delete from TComment where MessageID=" + messagecollection[i].ID;
                        SQLServerDALHelper.ExecuteSQLNonQurey(sql2);                       
                    }
                
                }
                 string sql3 = "delete from TMessage where MessKind='" + category + "'";//删除本版块所有帖子
                 SQLServerDALHelper.ExecuteSQLNonQurey(sql3);
                 return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 搜索相应的帖子
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public IList<MessageInfo> SearchMessage(string item)
        {
            string sql = "select * from TMessage where MessageContent like '%" + item +"%' or MessageTitle like '%" +  item +"%'" ;
            SqlDataReader datareader = null;
            datareader = SQLServerDALHelper.ExecuteSQLReader(sql);
            IList<MessageInfo> messagecollection = new List<MessageInfo>();
            try
            {
                while (datareader.Read())
                {
                    MessageInfo message = new MessageInfo();
                    message.ID = (int)datareader["MessageID"];
                    message.GuestName = (string)datareader["GuestName"];
                    //message.GuestEmail = (string)datareader["GuestEmail"];
                    message.Content = (string)datareader["MessageContent"];
                    message.Time = (DateTime)datareader["MessageTime"];
                    message.Ispass = (string)datareader["IsPass"];
                    message.MessKind = (string)datareader["MessKind"];
                    message.Title = (string)datareader["MessageTitle"];
                    message.ClickNumber = (int)datareader["ClickNumber"];
                    message.IsTop = (int)datareader["IsTop"];
                    message.LastTime = (DateTime)datareader["LastCommentTime"];
                    messagecollection.Add(message);
                }
                return messagecollection;
            }
            catch
            {
                return null;
            }
            finally
            {
                datareader.Close();
            }      
        
        }
        /// <summary>
        /// 十大热门帖
        /// </summary>
        /// <returns></returns>
        public IList<MessageInfo> TopTenMessage()
        { 
            string sql = "select top 10 *  from TMessage order by ClickNumber DESC" ;
            SqlDataReader datareader = null;
            datareader = SQLServerDALHelper.ExecuteSQLReader(sql);
            IList<MessageInfo> messagecollection = new List<MessageInfo>();
            try
            {
                while (datareader.Read())
                {
                    MessageInfo message = new MessageInfo();
                    message.ID = (int)datareader["MessageID"];
                    message.GuestName = (string)datareader["GuestName"];
                    //message.GuestEmail = (string)datareader["GuestEmail"];
                    message.Content = (string)datareader["MessageContent"];
                    message.Time = (DateTime)datareader["MessageTime"];
                    message.Ispass = (string)datareader["IsPass"];
                    message.MessKind = (string)datareader["MessKind"];
                    message.Title = (string)datareader["MessageTitle"];
                    message.ClickNumber = (int)datareader["ClickNumber"];
                    message.IsTop = (int)datareader["IsTop"];
                    message.LastTime = (DateTime)datareader["LastCommentTime"];
                    messagecollection.Add(message);
                }
                return messagecollection;
            }
            catch
            {
                return null;
            }
            finally
            {
                datareader.Close();
            }      
        
        }
    }
}
