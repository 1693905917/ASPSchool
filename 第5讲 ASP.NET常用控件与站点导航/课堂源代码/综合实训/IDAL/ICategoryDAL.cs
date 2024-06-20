using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface ICategoryDAL
    {
        /// <summary>
        /// 插入新版块
        /// </summary>
        /// <param name="category">版块名</param>
        /// <returns></returns>
        bool Insert(CategoryInfo category);
        
        /// <summary>
        /// 删除版块
        /// </summary>
        /// <param name="id">版块id</param>
        /// <returns></returns>
        bool Delete(int id);
        
        /// <summary>
        /// 返回所有版块信息
        /// </summary>
        /// <returns>IList<Category></returns>
        IList<CategoryInfo > GetALL();
        
        /// <summary>
        /// 通过id返回版块信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryInfo GetByID(int id);
        
        /// <summary>
        /// 修改版块名称
        /// </summary>
        /// <param name="oldname"></param>
        /// <param name="newname"></param>
        /// <returns></returns>
        bool ChangeName(string oldname, string newname );
        
        /// <summary>
        /// 修改版块版主
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        bool ChangeOwner(string category , string owner );
    }
}
