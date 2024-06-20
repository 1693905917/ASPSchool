using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IBLL
{
    public interface ICommentBLL
    {
        /// <summary>
        /// ��ӻظ���Ϣ
        /// </summary>
        /// <param name="comment">�ظ�����</param>
        /// <returns></returns>
        bool Add(CommentInfo comment);
        /// <summary>
        /// ͨ������IDɾ����Ӧ�Ļظ���Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Remove(int id);
        /// <summary>
        /// ͨ������id�������лظ�
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        IList<CommentInfo> GetByMessge(int messageid);
        /// <summary>
        /// ͨ������IDɾ�����лظ�
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        bool DeleteByMessage(int messageid);
    }
}
