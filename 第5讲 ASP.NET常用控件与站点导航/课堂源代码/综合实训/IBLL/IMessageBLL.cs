using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;
namespace BBS.IBLL
{
    public interface IMessageBLL
    {
        /// <summary>
        /// 添加帖子信息
        /// </summary>
        /// <param name="message">帖子信息</param>
        /// <returns></returns>
        bool Add(MessageInfo message);
        
        /// <summary>
        /// 删除帖子信息
        /// </summary>
        /// <param name="id">帖子的id</param>
        /// <returns></returns>
        bool Remove(int id);
        
        /// <summary>
        /// 更新帖子信息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Update(MessageInfo message);
        
        /// <summary>
        /// 验证帖子信息
        /// </summary>
        /// <param name="id">帖子id</param>
        /// <returns></returns>
        bool Pass(int id);
        
        /// <summary>
        /// 根据帖子的ID返回帖子
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MessageInfo GetMessageByID(int id);
        
        /// <summary>
        /// 根据版块名返回相应的帖子，并且根据参数决定是否返回未通过验证的帖子
        /// </summary>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        IList<MessageInfo> GetMessageByCategory(string category , int item);
        
        /// <summary>
        /// 删除指定版块的帖子及相关回复
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        bool DelMessageByCategory(string category);
        
        /// <summary>
        /// 搜索帖子
        /// </summary>
        /// <returns></returns>
        IList<MessageInfo> SearchMessage(string item );
        
        /// <summary>
        /// 十大热门帖
        /// </summary>
        /// <returns></returns>
        IList<MessageInfo> TopTenMesssage();


    }
}
