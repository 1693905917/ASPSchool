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
        /// �����������
        /// </summary>
        /// <param name="category">��������ʵ����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Add(CategoryInfo category);
        /**/
        /// <summary>
        /// ɾ����������
        /// </summary>
        /// <param name="id">��������ʵ����id</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Del(int id);
        /**/
        /// <summary>
        /// ����������������
        /// </summary>
        /// <returns>��������</returns>
        IList<CategoryInfo > GetAll();
        /// <summary>
        /// ����ID��������������Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryInfo GetCategoryByID(int id );
        /// <summary>
        /// �޸���������
        /// </summary>
        /// <param name="oldcategory"></param>
        /// <param name="newcategory"></param>
        /// <returns></returns>
        bool ChangeCategory(string oldcategory , string newcategory );
        /// <summary>
        /// �޸������������
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        bool ChangeCategoryOwner(string category, string owner);

    }
}
