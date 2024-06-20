using System;
using System.Collections.Generic;
using System.Text;
using BBS.IDAL;

namespace BBS.Factory
{
    public sealed class DALFactory    {
        
        /// <summary>
        /// 返回数据层的帖子信息的接口
        /// </summary>
        /// <returns></returns>
        public static IMessageDAL CreateMessageDAL()
        {
            return (IMessageDAL)DependencyInjector.GetDALObject("MessageDAL");
        }
        /// <summary>
        /// 返回数据层的评论信息的接口
        /// </summary>
        /// <returns></returns>
        public static ICommentDAL CreateCommentDAL()
        {
            return (ICommentDAL)DependencyInjector.GetDALObject("CommentDAL");
        }
        /// <summary>
        /// 返回数据层的会员信息的接口
        /// </summary>
        /// <returns></returns>
        public static IUserDAL  CreateUserDAL()
        {
            return (IUserDAL )DependencyInjector.GetDALObject("UserDAL");
        }
        /// <summary>
        /// 返回数据层的版块的接口
        /// </summary>
        /// <returns></returns>
        public static ICategoryDAL  CreateCategoryDAL()
        {
            return (ICategoryDAL )DependencyInjector.GetDALObject("CategoryDAL");
        }
    }
}
