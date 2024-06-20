using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;


namespace BBS.IDAL
{
    public interface IMessageDAL
    {
        /// <summary>
        /// 插入帖子信息
        /// </summary>
        /// <param name="messge">帖子信息</param>
        /// <returns>是否成功</returns>
        bool Insert(MessageInfo messge);
        
        /// <summary>
        /// 删除帖子信息
        /// </summary>
        /// <param name="id">帖子id</param>
        /// <returns>是否成功</returns>
        bool Delete(int id);
        
        /// <summary>
        /// 更新帖子信息
        /// </summary>
        /// <param name="message">帖子信息</param>
        /// <returns>是否成功</returns>
        bool Update(MessageInfo message);
        
        /// <summary>
        /// 返回帖子信息
        /// </summary>
        /// <param name="id">帖子ID</param>
        /// <returns>帖子信息</returns>
        MessageInfo GetByID(int id);
        
        /// <summary>
        /// 根据版块名称返回相应的信息，并根据参数决定是否返回未通过验证的帖子
        /// </summary>
        /// <param name="category">版块名称</param>
        /// <param name="item">是否返回未验证的帖子</param>
        /// <returns></returns>
        IList<MessageInfo> GetByCategory(string category,int item);
        
        /// <summary>
        /// 根据版块名删除相应的帖子信息
        /// </summary>
        /// <param name="?">版块名称</param>
        /// <returns>是否成功</returns>
        bool DeleteByCategory(string category) ;
        
        /// <summary>
        /// 搜索相应的帖子
        /// </summary>
        /// <param name="item">关键词</param>
        /// <returns>包含关键词的帖子集合</returns>
        IList<MessageInfo> SearchMessage(string item);
        
        /// <summary>
        /// 返回十大热门帖
        /// </summary> 
        IList<MessageInfo> TopTenMessage();

    }
}
