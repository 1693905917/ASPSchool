using System.Collections.Generic;
using BBS.IBLL;
using BBS.Factory;
using BBS.Entity;

namespace BBS.BLL
{
    public class MessageBLL : IMessageBLL
    {
        /// <summary>
        /// ���������Ϣ
        /// </summary>
        /// <param name="message">������Ϣ</param>
        /// <returns></returns>
        public bool Add(MessageInfo message)
        {
            return Factory.DALFactory.CreateMessageDAL().Insert(message);
        }
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="id">��Ϣ��id</param>
        /// <returns></returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateMessageDAL().Delete(id);

        }
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Update(MessageInfo message)
        {
            return DALFactory.CreateMessageDAL().Update(message);
        }
        /// <summary>
        /// ��֤������Ϣ
        /// </summary>
        /// <param name="id">��Ϣid</param>
        /// <returns></returns>
        public bool Pass(int id)
        {
            MessageInfo message = DALFactory.CreateMessageDAL().GetByID(id);
            message.Ispass = "pass";
            return DALFactory.CreateMessageDAL().Update(message);
        }
        /// <summary>
        /// ����������Ϣ��ID���뷵������
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MessageInfo GetMessageByID(int id)
        {
            return DALFactory.CreateMessageDAL().GetByID(id);
        }
        /// <summary>
        /// ������Ϣ���෵����Ӧ����Ϣ���Ҹ��ݲ��������Ƿ񷵻�ͨ����֤������
        /// </summary>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public IList<MessageInfo> GetMessageByCategory(string category, int item)
        {
            return DALFactory.CreateMessageDAL().GetByCategory(category, item);
        }
        /// <summary>
        /// ͨ��������Ϣ����ɾ��������Ϣ
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool DelMessageByCategory(string category)
        {
            return DALFactory.CreateMessageDAL().DeleteByCategory(category);
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public IList<MessageInfo> SearchMessage(string item)
        {
            return DALFactory.CreateMessageDAL().SearchMessage(item);
        }
        /// <summary>
        /// ʮ�󾫻���
        /// </summary>
        /// <returns></returns>
        public IList<MessageInfo> TopTenMesssage()
        {
            return DALFactory.CreateMessageDAL().TopTenMessage();
        }
    }

}