using System.Collections.Generic;
using BBS.Entity;
using BBS.IDAL;
using System.Data.SqlClient;

namespace BBS.SQLServerDAL
{
    public class CategoryDAL : ICategoryDAL
    {
        /// <summary>
        /// ����������Ϣ����
        /// </summary>
        /// <param name="category">������Ϣ����</param>
        /// <returns></returns>
        public bool Insert(CategoryInfo category)
        {
            string sql = "insert into TMessCategory (Category,CategoryOwner) values('"+category.Category +"','"+category.CategoryOwner +"')";
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ɾ��������Ϣ����
        /// </summary>
        /// <param name="id">��������id</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            string sql = "delete from TMessCategory where CategoryID=" + id;
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ��������������Ϣ����
        /// </summary>
        /// <returns>IList<Category></returns>
        public IList<CategoryInfo> GetALL()
        {
            SqlDataReader dataReader = null;
            string sql =  "select * from TMessCategory";
            dataReader = SQLServerDALHelper.ExecuteSQLReader(sql);
            IList<CategoryInfo > categoryCollection = new List<CategoryInfo >();
            try
            {
                while (dataReader.Read())
                {
                    CategoryInfo  category = new CategoryInfo ();
                    category.ID = (int)dataReader["CategoryID"];
                    category.Category = (string)dataReader["Category"];
                    category.CategoryOwner = (string)dataReader["CategoryOwner"];
                    categoryCollection.Add(category );
                }
                return categoryCollection;
            }
            catch
            {
                return null;
            }
            finally
            {
                dataReader.Close();
            }
        }
        /// <summary>
        /// ͨ��id����������Ϣ����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryInfo GetByID(int id)
        {
            SqlDataReader dataReader = null;
            string sql = "select * from TMessCategory where CategoryID ="+id ;
            dataReader = SQLServerDALHelper.ExecuteSQLReader(sql);
            try
            {
                dataReader.Read();
                CategoryInfo category = new CategoryInfo();
                category.ID = (int)dataReader["CategoryID"];
                category.Category = (string)dataReader["Category"];
                category.CategoryOwner = (string)dataReader["CategoryOwner"];
                return category;
            }
            catch
            {
                return null;
            }
            finally
            {
                dataReader.Close();
            }
        }
        /// <summary>
        /// �޸�����������
        /// </summary>
        /// <param name="oldname"></param>
        /// <param name="newname"></param>
        /// <returns></returns>
        public bool ChangeName(string oldname, string newname)
        {
            string sql1 = "update TMessCategory set Category='"+ newname + "' where Category='"+ oldname + "'";
            string sql2 = "update TMessage set MessKind ='" + newname + "' where MessKind='" +oldname + "'";
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql1 );
                SQLServerDALHelper.ExecuteSQLNonQurey(sql2);
                return true;
            }           
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// �޸������������
        /// </summary>
        /// <param name="category"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public bool ChangeOwner(string category, string owner)
        {
            string sql = "update TMessCategory set CategoryOwner='" + owner + "'where Category ='" + category + "'";
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
