using System.Collections.Generic;
using System.Data.SqlClient;
using BBS.IDAL;
using BBS.Entity;
using BBS.Utility;

namespace BBS.SQLServerDAL
{
    public class UserDAL:IUserDAL 
    {



        /// <summary>
        /// 插入会员
        /// </summary>
        /// <param name="user">会员对象</param>
        /// <returns></returns>
        public bool Insert(UserInfo user)
        { 
            string sql = "insert into TUser (UserName,UserPwd,UserEmail , InBlack , Question,Answer ) values('"+user.UserName +"','"+user.UserPwd +"','"+user.UserEmail+"','"+user.InBlack +"','"+user.Question +"','"+user.Answer +"')";
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
        /// 更新操作
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Update(UserInfo user)
        {
            string sql = "update TUser set InBlack= '"+user.InBlack+"' where UserName='"+user.UserName+"'" ;
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
        /// 是否在黑名单中
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool InBlack(string name)
        {
            string sql = "select UserName from TUser where UserName='"+name+"' and InBlack='Yes'";
            try
            {
                string username = SQLServerDALHelper.ExecuteSQLScalar(sql).ToString();
                if (username != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        
        }
        /// <summary>
        /// 通过Id删除会员
        /// </summary>
        /// <param name="id">会员id</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            string sql = "delete from TUser where UserID="+id ;
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
        /// 修改密码
        /// </summary>
        /// <param name="user">会员名</param>
        /// <param name="pwd">修改后的密码</param>
        /// <returns></returns>
        public bool UpdatePass(string user, string pwd)
        {
            string sql ="update TUser set UserPwd='" + pwd + "'" + "where UserName='" + user + "'";
            try
            {
                SQLServerDALHelper.ExecuteSQLReader(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateOwner(string user, bool own)
        {
            string sql = "Update TUser set IsOwner='" +　own + "' where UserName='" +　user + "'";
            try
            {
                SQLServerDALHelper.ExecuteSQLReader(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }



        
        /// <summary>
        /// 返回所有会员信息
        /// </summary>
        /// <returns></returns>
        public IList<UserInfo> GetAll()
        {
            SqlDataReader dataReader = null;
            string sql = "select * from TUser where UserName <> 'admin'";
            dataReader = SQLServerDALHelper.ExecuteSQLReader(sql);
            IList<UserInfo > userCollection = new List<UserInfo >();
            try
            {
                while (dataReader.Read())
                {
                    UserInfo  user = new UserInfo ();
                    user.ID = (int)dataReader["UserID"];
                    user.UserName  = (string)dataReader["UserName"];
                    user.UserPwd  = (string)dataReader["UserPwd"];
                    user.UserEmail  = (string)dataReader["UserEmail"];
                    user.InBlack = (string)dataReader["InBlack"];
                    user.Question = (string)dataReader["Question"];
                    user.Answer = (string)dataReader["Answer"];
                    //user.MessOwner = (string)dataReader["MessOwner"];
                    userCollection.Add(user);
                }
                return userCollection;
            }
            catch
            {
                return null;
            }
            finally
            {
                dataReader.Close();
            }
        }
        /// <summary>
        /// 是否是本站的会员
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool IsRight(string name, string pwd)
        {
            string sql = "select UserPwd from TUser where UserName='" + name + "'";
            try
            {
                string strpwd = SQLServerDALHelper.ExecuteSQLScalar(sql).ToString();
                string md = Encryptor.MD5Encrypt( pwd) ;
                if (md == strpwd)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }            
        }
        /// <summary>
        /// 通过会员名返回会员信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserInfo GetByName(string name)
        {

            string sql = "select  * from TUser where UserName='" + name + "'";
            SqlDataReader dataReader = null;
            dataReader = SQLServerDALHelper.ExecuteSQLReader(sql);
            UserInfo user = new UserInfo();
            try
            {
                dataReader.Read();
                user.ID = (int)dataReader["UserID"];
                user.UserName  = (string)dataReader["UserName"];
                user.UserPwd  = (string)dataReader["UserPwd"];
                user.UserEmail  = (string)dataReader["UserEmail"];
                user.InBlack = (string)dataReader["InBlack"];
                user.Question = (string)dataReader["Question"];
                user.Answer = (string)dataReader["Answer"];
                user.IsOwner = (bool)dataReader["IsOwner"];
                return user;
            }
            catch
            {
                return null;
            }
            finally
            {
                dataReader.Close();
            }

        
        }
    }
}
