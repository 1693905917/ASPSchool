using System.Collections.Generic;
using BBS.IBLL;
using BBS.Entity;
using BBS.Factory;

namespace BBS.BLL
{
    public class CommentBLL:ICommentBLL 
    {
        /// <summary>
        /// 添加评论信息
        /// </summary>
        /// <param name="comment">评论对象</param>
        /// <returns></returns>
        public bool Add(CommentInfo comment)
        {
            return DALFactory.CreateCommentDAL().Insert(comment);
        }
        /// <summary>
        /// 通过ＩＤ删除相应的评论信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateCommentDAL().Delete(id);
        }
        /// <summary>
        /// 通过信息id返回评论
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public IList<CommentInfo> GetByMessge(int messageid)
        {
            return DALFactory.CreateCommentDAL().GetByMessage(messageid);
        }
        /// <summary>
        /// 通过信息ＩＤ删除评论
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public bool DeleteByMessage(int messageid)
        {
            return DALFactory.CreateCommentDAL().DeleteByMessage(messageid );
        }
    }
}
