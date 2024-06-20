using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;


namespace BBS.IDAL
{
    public interface IMessageDAL
    {
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        /// <param name="messge">������Ϣ</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Insert(MessageInfo messge);
        
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="id">����id</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Delete(int id);
        
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        /// <param name="message">������Ϣ</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Update(MessageInfo message);
        
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        /// <param name="id">����ID</param>
        /// <returns>������Ϣ</returns>
        MessageInfo GetByID(int id);
        
        /// <summary>
        /// ���ݰ�����Ʒ�����Ӧ����Ϣ�������ݲ��������Ƿ񷵻�δͨ����֤������
        /// </summary>
        /// <param name="category">�������</param>
        /// <param name="item">�Ƿ񷵻�δ��֤������</param>
        /// <returns></returns>
        IList<MessageInfo> GetByCategory(string category,int item);
        
        /// <summary>
        /// ���ݰ����ɾ����Ӧ��������Ϣ
        /// </summary>
        /// <param name="?">�������</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool DeleteByCategory(string category) ;
        
        /// <summary>
        /// ������Ӧ������
        /// </summary>
        /// <param name="item">�ؼ���</param>
        /// <returns>�����ؼ��ʵ����Ӽ���</returns>
        IList<MessageInfo> SearchMessage(string item);
        
        /// <summary>
        /// ����ʮ��������
        /// </summary> 
        IList<MessageInfo> TopTenMessage();

    }
}
