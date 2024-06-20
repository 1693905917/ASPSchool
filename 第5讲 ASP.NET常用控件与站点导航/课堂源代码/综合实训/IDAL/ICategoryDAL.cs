using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface ICategoryDAL
    {
        /// <summary>
        /// �����°��
        /// </summary>
        /// <param name="category">�����</param>
        /// <returns></returns>
        bool Insert(CategoryInfo category);
        
        /// <summary>
        /// ɾ�����
        /// </summary>
        /// <param name="id">���id</param>
        /// <returns></returns>
        bool Delete(int id);
        
        /// <summary>
        /// �������а����Ϣ
        /// </summary>
        /// <returns>IList<Category></returns>
        IList<CategoryInfo > GetALL();
        
        /// <summary>
        /// ͨ��id���ذ����Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryInfo GetByID(int id);
        
        /// <summary>
        /// �޸İ������
        /// </summary>
        /// <param name="oldname"></param>
        /// <param name="newname"></param>
        /// <returns></returns>
        bool ChangeName(string oldname, string newname );
        
        /// <summary>
        /// �޸İ�����
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        bool ChangeOwner(string category , string owner );
    }
}
