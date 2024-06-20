using System;
using System.Collections.Generic;
using System.Text;
using BBS.IBLL;

namespace  BBS.Factory
{
    public sealed class BLLFactory
    {        
        /// <summary>
        /// ����ҵ���߼����������Ϣ���߼��ӿ�
        /// </summary>
        /// <returns></returns>
        public static IMessageBLL CreateMessageBLL()
        {
            return (IMessageBLL)DependencyInjector.GetBLLObject("MessageBLL");
        }
        /// <summary>
        /// ����ҵ���߼����������Ϣ���߼��ӿ�
        /// </summary>
        /// <returns></returns>
        public static ICommentBLL CreateCommentBLL()
        {
            return (ICommentBLL)DependencyInjector.GetBLLObject("CommentBLL");
        }
        /// <summary>
        /// ����ҵ���߼�������߼��ӿ�
        /// </summary>
        /// <returns></returns>
        public static ICategoryBLL  CreateCategoryBLL()
        {
            return (ICategoryBLL )DependencyInjector.GetBLLObject("CategoryBLL");
        }
        /// <summary>
        /// ����ҵ���߼���Ļ�Ա��Ϣ���߼��ӿ�
        /// </summary>
        /// <returns></returns>
        public static IUserBLL  CreateUserBLL()
        {
            return (IUserBLL )DependencyInjector.GetBLLObject("UserBLL");
        }
    }
}
