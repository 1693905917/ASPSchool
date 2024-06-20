using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IBLL
{
    public interface ICategoryBLL 
    {
        /**/
        /// <summary>
        /// 添加帖子种类
        /// </summary>
        /// <param name="category">帖子种类实体类</param>
        /// <returns>是否成功</returns>
        bool Add(CategoryInfo category);
        /**/
        /// <summary>
        /// 删除帖子种类
        /// </summary>
        /// <param name="id">帖子种类实体类id</param>
        /// <returns>是否成功</returns>
        bool Del(int id);
        /**/
        /// <summary>
        /// 返回所有帖子种类
        /// </summary>
        /// <returns>所有帖子</returns>
        IList<CategoryInfo > GetAll();
        /// <summary>
        /// 根据ID返回帖子种类信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryInfo GetCategoryByID(int id );
        /// <summary>
        /// 修改帖子种类
        /// </summary>
        /// <param name="oldcategory"></param>
        /// <param name="newcategory"></param>
        /// <returns></returns>
        bool ChangeCategory(string oldcategory , string newcategory );
        /// <summary>
        /// 修改帖子种类版主
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        bool ChangeCategoryOwner(string category, string owner);

    }
}
