using System;
using System.Collections.Generic;
using System.Text;
using BBS.IDAL;

namespace BBS.Factory
{
    public sealed class DALFactory    {
        
        /// <summary>
        /// �������ݲ��������Ϣ�Ľӿ�
        /// </summary>
        /// <returns></returns>
        public static IMessageDAL CreateMessageDAL()
        {
            return (IMessageDAL)DependencyInjector.GetDALObject("MessageDAL");
        }
        /// <summary>
        /// �������ݲ��������Ϣ�Ľӿ�
        /// </summary>
        /// <returns></returns>
        public static ICommentDAL CreateCommentDAL()
        {
            return (ICommentDAL)DependencyInjector.GetDALObject("CommentDAL");
        }
        /// <summary>
        /// �������ݲ�Ļ�Ա��Ϣ�Ľӿ�
        /// </summary>
        /// <returns></returns>
        public static IUserDAL  CreateUserDAL()
        {
            return (IUserDAL )DependencyInjector.GetDALObject("UserDAL");
        }
        /// <summary>
        /// �������ݲ�İ��Ľӿ�
        /// </summary>
        /// <returns></returns>
        public static ICategoryDAL  CreateCategoryDAL()
        {
            return (ICategoryDAL )DependencyInjector.GetDALObject("CategoryDAL");
        }
    }
}
