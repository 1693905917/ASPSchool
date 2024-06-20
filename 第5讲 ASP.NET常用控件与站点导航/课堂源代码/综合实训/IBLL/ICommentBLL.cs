using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IBLL
{
    public interface ICommentBLL
    {
        /// <summary>
        /// 添加回复信息
        /// </summary>
        /// <param name="comment">回复对象</param>
        /// <returns></returns>
        bool Add(CommentInfo comment);
        /// <summary>
        /// 通过帖子ID删除相应的回复信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Remove(int id);
        /// <summary>
        /// 通过帖子id返回所有回复
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        IList<CommentInfo> GetByMessge(int messageid);
        /// <summary>
        /// 通过帖子ID删除所有回复
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        bool DeleteByMessage(int messageid);
    }
}
