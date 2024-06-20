using System.Collections.Generic;
using BBS.IBLL;
using BBS.Entity;
using BBS.Factory;

namespace BBS.BLL
{
    public class CommentBLL:ICommentBLL 
    {
        /// <summary>
        /// ���������Ϣ
        /// </summary>
        /// <param name="comment">���۶���</param>
        /// <returns></returns>
        public bool Add(CommentInfo comment)
        {
            return DALFactory.CreateCommentDAL().Insert(comment);
        }
        /// <summary>
        /// ͨ���ɣ�ɾ����Ӧ��������Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateCommentDAL().Delete(id);
        }
        /// <summary>
        /// ͨ����Ϣid��������
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public IList<CommentInfo> GetByMessge(int messageid)
        {
            return DALFactory.CreateCommentDAL().GetByMessage(messageid);
        }
        /// <summary>
        /// ͨ����Ϣ�ɣ�ɾ������
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public bool DeleteByMessage(int messageid)
        {
            return DALFactory.CreateCommentDAL().DeleteByMessage(messageid );
        }
    }
}
