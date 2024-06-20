using System.Collections.Generic;
using BBS.Entity;
using BBS.Factory;
using BBS.IBLL;

namespace BBS.BLL
{
    public class UserBLL :IUserBLL 
    {
        /**/
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="user">会员实体类</param>
        /// <returns>是否成功</returns>
        public bool Add(UserInfo user)
        {
            return DALFactory.CreateUserDAL().Insert(user);
        }
        /// <summary>
        /// 更新会员
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Update(UserInfo user)
        {
            return DALFactory.CreateUserDAL().Update(user);
        }
        /// <summary>
        /// 判断会员是否被列入黑名单
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsInBlack(string name)
        {
            return DALFactory.CreateUserDAL().InBlack(name);
        }
        /**/
        /// <summary>
        /// 删除会员
        /// </summary>
        /// <param name="id">欲删除的会员的ID</param>
        /// <returns>是否成功</returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateUserDAL().Delete(id);
        }
        /**/
        /// <summary>
        /// 修改会员密码
        /// </summary>
        /// <param name="id">欲修改密码的会员的ID</param>
        /// <param name="password">新密码</param>
        /// <returns>是否成功</returns>
        public bool ChangePassword(string user, string password)
        {
            return DALFactory.CreateUserDAL().UpdatePass(user, password);
        }

        /// <summary>
        /// 修改会员版主身份
        /// </summary>
        /// <param name="user">欲修改身份的会员名</param>
        /// <param name="isowner">是否为版主</param>
         /// <returns>是否成功</returns>
        public bool ChangeOwner(string user, bool isowner)
        {
            return DALFactory.CreateUserDAL().UpdateOwner(user, isowner);
        }
        
        
       
       
        /// <summary>
        /// 会员登录
        /// </summary>
        /// <param name="name">会员登录名</param>
        /// <param name="password">会员密码</param
        /// /// <returns>如果登录成功，则返回true 否则返回false</returns>
        public bool Login(string name, string password)
        {
            return DALFactory.CreateUserDAL().IsRight(name, password);
        }
        /**/
        /// <summary>
        /// 取得全部会员信息
        /// </summary>
        /// <returns>会员实体类集合</returns>
        public IList<UserInfo> GetAll()
        {
            return DALFactory.CreateUserDAL().GetAll();
        }
        /// <summary>
        /// 通过会员名返回会员信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserInfo GetByName(string username)
        {
            return DALFactory.CreateUserDAL().GetByName(username );
        }
    }
}
