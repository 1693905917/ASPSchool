using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface IUserDAL
    {
        /// <summary>
        /// 插入会员
        /// </summary>
        /// <param name="user">会员对象</param>
        /// <returns></returns>
        bool Insert(UserInfo  user);
        
        /// <summary>
        /// 加入黑名单操作
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Update(UserInfo user);
        
        /// <summary>
        /// 是否在黑名单中
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool InBlack(string name);
        
        /// <summary>
        /// 通过Id删除会员
        /// </summary>
        /// <param name="id">会员id</param>
        /// <returns></returns>
        bool Delete(int id);
       
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user">会员名</param>
        /// <param name="pwd">修改后的密码</param>
        /// <returns></returns>
        bool UpdatePass(string user, string pwd);
        
        // <summary>
        /// 修改会员的版主身份
        /// </summary>
        /// <param name="user">会员名</param>
        /// <param name="own">是否为版主身份</param>
        /// <returns></returns>
        bool UpdateOwner(string user, bool own);

        /// <summary>
        /// 返回所有会员信息
        /// </summary>
        /// <returns></returns>
        IList<UserInfo > GetAll();
        
        /// <summary>
        /// 验证会员身份
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        bool IsRight(string name, string pwd);
        
        /// <summary>
        /// 通过会员名返回会员信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        UserInfo GetByName(string name);
    }
}
