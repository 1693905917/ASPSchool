using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;
namespace BBS.IBLL
{
    public interface IMessageBLL
    {
        /// <summary>
        /// ���������Ϣ
        /// </summary>
        /// <param name="message">������Ϣ</param>
        /// <returns></returns>
        bool Add(MessageInfo message);
        
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="id">���ӵ�id</param>
        /// <returns></returns>
        bool Remove(int id);
        
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Update(MessageInfo message);
        
        /// <summary>
        /// ��֤������Ϣ
        /// </summary>
        /// <param name="id">����id</param>
        /// <returns></returns>
        bool Pass(int id);
        
        /// <summary>
        /// �������ӵ�ID��������
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MessageInfo GetMessageByID(int id);
        
        /// <summary>
        /// ���ݰ����������Ӧ�����ӣ����Ҹ��ݲ��������Ƿ񷵻�δͨ����֤������
        /// </summary>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        IList<MessageInfo> GetMessageByCategory(string category , int item);
        
        /// <summary>
        /// ɾ��ָ���������Ӽ���ػظ�
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        bool DelMessageByCategory(string category);
        
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        IList<MessageInfo> SearchMessage(string item );
        
        /// <summary>
        /// ʮ��������
        /// </summary>
        /// <returns></returns>
        IList<MessageInfo> TopTenMesssage();


    }
}
