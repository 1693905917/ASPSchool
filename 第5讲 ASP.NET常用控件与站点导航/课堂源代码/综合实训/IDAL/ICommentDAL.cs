using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface ICommentDAL
    {
        /// <summary>
        /// 插入回复
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        bool Insert(CommentInfo comment);
        
        /// <summary>
        /// 删除回复
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        
        /// <summary>
        /// 通过帖子id返回回复
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        IList<CommentInfo> GetByMessage(int messageid);
       
        /// <summary>
        /// 删除指定帖子相关的回复
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        bool DeleteByMessage(int messageid );
    }
}
