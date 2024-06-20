using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IBLL
{
    public interface IUserBLL
    {
        /**/
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="user">会员实体类</param>
        /// <returns>是否成功</returns>
        bool Add(UserInfo  user);
        /// <summary>
        /// 更新会员
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Update(UserInfo user);
        /// <summary>
        /// 判断会员是否被列入黑名单
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool IsInBlack(string name);
        /**/
        /// <summary>
        /// 删除会员
        /// </summary>
        /// <param name="id">欲删除的会员的ID</param>
        /// <returns>是否成功</returns>
        bool Remove(int id);
        /**/
        /// <summary>
        /// 修改会员密码
        /// </summary>
        /// <param name="id">欲修改密码的会员的ID</param>
        /// <param name="password">新密码</param>
        /// <returns>是否成功</returns>
        bool ChangePassword(string user, string password);

        bool ChangeOwner(string user, bool isowner);
        
        /**/
        /// <summary>
        /// 会员登录
        /// </summary>
        /// <param name="name">会员登录名</param>
        /// <param name="password">会员密码</param
        /// <returns>如果登录成功，则返回true，否则返回false</returns>
        bool  Login(string name, string password);
        
        /**/
        /// <summary>
        /// 取得全部会员信息
        /// </summary>
        /// <returns>会员实体类集合</returns>
        IList<UserInfo > GetAll();
       
        /// <summary>
        /// 通过会员名返回会员信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        UserInfo GetByName(string username);

    }
}
