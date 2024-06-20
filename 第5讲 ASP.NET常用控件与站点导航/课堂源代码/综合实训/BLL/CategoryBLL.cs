using System.Collections.Generic;
using BBS.Entity;
using BBS.Factory;
using BBS.IBLL;

namespace BBS.BLL
{
    public class CategoryBLL: ICategoryBLL 
    {
        /**/
        /// <summary>
        /// 添加版块
        /// </summary>
        /// <param name="admin">版块实体类</param>
        /// <returns>是否成功</returns>
        public bool Add(CategoryInfo category)
        {
            return DALFactory.CreateCategoryDAL().Insert(category);
        }
        /**/
        /// <summary>
        /// 删除版块
        /// </summary>
        /// <param name="admin">版块实体类id </param>
        /// <returns>是否成功</returns>
        public bool Del(int id)
        {
            return DALFactory.CreateCategoryDAL().Delete(id);
        }
        /**/
        /// <summary>
        /// 返回所有版块
        /// </summary>
        /// <returns>所有帖子</returns>
        public IList<CategoryInfo> GetAll()
        {
            return DALFactory.CreateCategoryDAL().GetALL();
        }
        /// <summary>
        /// 根据ID返回版块信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryInfo GetCategoryByID(int id)
        {
            return DALFactory.CreateCategoryDAL().GetByID(id );
        }
        /// <summary>
        /// 修改版块
        /// </summary>
        /// <param name="oldcategory"></param>
        /// <param name="newcategory"></param>
        /// <returns></returns>
        public bool ChangeCategory(string oldcategory, string newcategory)
        {
            return DALFactory.CreateCategoryDAL().ChangeName(oldcategory,newcategory );
        }
        /// <summary>
        /// 修改版主
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public bool ChangeCategoryOwner(string category, string owner)
        {
            return DALFactory.CreateCategoryDAL().ChangeOwner(category , owner );
        }
    }
}
