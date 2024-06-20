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
        /// ��Ӱ��
        /// </summary>
        /// <param name="admin">���ʵ����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool Add(CategoryInfo category)
        {
            return DALFactory.CreateCategoryDAL().Insert(category);
        }
        /**/
        /// <summary>
        /// ɾ�����
        /// </summary>
        /// <param name="admin">���ʵ����id </param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool Del(int id)
        {
            return DALFactory.CreateCategoryDAL().Delete(id);
        }
        /**/
        /// <summary>
        /// �������а��
        /// </summary>
        /// <returns>��������</returns>
        public IList<CategoryInfo> GetAll()
        {
            return DALFactory.CreateCategoryDAL().GetALL();
        }
        /// <summary>
        /// ����ID���ذ����Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryInfo GetCategoryByID(int id)
        {
            return DALFactory.CreateCategoryDAL().GetByID(id );
        }
        /// <summary>
        /// �޸İ��
        /// </summary>
        /// <param name="oldcategory"></param>
        /// <param name="newcategory"></param>
        /// <returns></returns>
        public bool ChangeCategory(string oldcategory, string newcategory)
        {
            return DALFactory.CreateCategoryDAL().ChangeName(oldcategory,newcategory );
        }
        /// <summary>
        /// �޸İ���
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
