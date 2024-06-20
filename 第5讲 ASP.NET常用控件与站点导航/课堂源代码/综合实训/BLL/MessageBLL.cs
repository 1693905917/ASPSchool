using System.Collections.Generic;
using BBS.IBLL;
using BBS.Factory;
using BBS.Entity;

namespace BBS.BLL
{
    public class MessageBLL : IMessageBLL
    {
        /// <summary>
        /// 添加帖子信息
        /// </summary>
        /// <param name="message">帖子信息</param>
        /// <returns></returns>
        public bool Add(MessageInfo message)
        {
            return Factory.DALFactory.CreateMessageDAL().Insert(message);
        }
        /// <summary>
        /// 删除帖子信息
        /// </summary>
        /// <param name="id">信息的id</param>
        /// <returns></returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateMessageDAL().Delete(id);

        }
        /// <summary>
        /// 更新帖子信息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Update(MessageInfo message)
        {
            return DALFactory.CreateMessageDAL().Update(message);
        }
        /// <summary>
        /// 验证帖子信息
        /// </summary>
        /// <param name="id">信息id</param>
        /// <returns></returns>
        public bool Pass(int id)
        {
            MessageInfo message = DALFactory.CreateMessageDAL().GetByID(id);
            message.Ispass = "pass";
            return DALFactory.CreateMessageDAL().Update(message);
        }
        /// <summary>
        /// 根据帖子信息的ID号码返回帖子
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MessageInfo GetMessageByID(int id)
        {
            return DALFactory.CreateMessageDAL().GetByID(id);
        }
        /// <summary>
        /// 根据信息种类返回相应的信息并且根据参数决定是否返回通过验证的帖子
        /// </summary>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public IList<MessageInfo> GetMessageByCategory(string category, int item)
        {
            return DALFactory.CreateMessageDAL().GetByCategory(category, item);
        }
        /// <summary>
        /// 通过帖子信息种类删除帖子信息
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool DelMessageByCategory(string category)
        {
            return DALFactory.CreateMessageDAL().DeleteByCategory(category);
        }
        /// <summary>
        /// 搜索帖子
        /// </summary>
        /// <returns></returns>
        public IList<MessageInfo> SearchMessage(string item)
        {
            return DALFactory.CreateMessageDAL().SearchMessage(item);
        }
        /// <summary>
        /// 十大精华帖
        /// </summary>
        /// <returns></returns>
        public IList<MessageInfo> TopTenMesssage()
        {
            return DALFactory.CreateMessageDAL().TopTenMessage();
        }
    }

}