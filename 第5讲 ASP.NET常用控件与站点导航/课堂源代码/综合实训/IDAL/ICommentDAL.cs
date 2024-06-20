using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface ICommentDAL
    {
        /// <summary>
        /// ����ظ�
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        bool Insert(CommentInfo comment);
        
        /// <summary>
        /// ɾ���ظ�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        
        /// <summary>
        /// ͨ������id���ػظ�
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        IList<CommentInfo> GetByMessage(int messageid);
       
        /// <summary>
        /// ɾ��ָ��������صĻظ�
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        bool DeleteByMessage(int messageid );
    }
}
