using System;
using System.Collections.Generic;
using System.Text;
using BBS.IBLL;

namespace  BBS.Factory
{
    public sealed class BLLFactory
    {        
        /// <summary>
        /// 返回业务逻辑层的帖子信息的逻辑接口
        /// </summary>
        /// <returns></returns>
        public static IMessageBLL CreateMessageBLL()
        {
            return (IMessageBLL)DependencyInjector.GetBLLObject("MessageBLL");
        }
        /// <summary>
        /// 返回业务逻辑层的评论信息的逻辑接口
        /// </summary>
        /// <returns></returns>
        public static ICommentBLL CreateCommentBLL()
        {
            return (ICommentBLL)DependencyInjector.GetBLLObject("CommentBLL");
        }
        /// <summary>
        /// 返回业务逻辑层版块的逻辑接口
        /// </summary>
        /// <returns></returns>
        public static ICategoryBLL  CreateCategoryBLL()
        {
            return (ICategoryBLL )DependencyInjector.GetBLLObject("CategoryBLL");
        }
        /// <summary>
        /// 返回业务逻辑层的会员信息的逻辑接口
        /// </summary>
        /// <returns></returns>
        public static IUserBLL  CreateUserBLL()
        {
            return (IUserBLL )DependencyInjector.GetBLLObject("UserBLL");
        }
    }
}
