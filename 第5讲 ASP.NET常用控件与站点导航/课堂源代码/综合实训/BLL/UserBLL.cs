using System.Collections.Generic;
using BBS.Entity;
using BBS.Factory;
using BBS.IBLL;

namespace BBS.BLL
{
    public class UserBLL :IUserBLL 
    {
        /**/
        /// <summary>
        /// ��ӻ�Ա
        /// </summary>
        /// <param name="user">��Աʵ����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool Add(UserInfo user)
        {
            return DALFactory.CreateUserDAL().Insert(user);
        }
        /// <summary>
        /// ���»�Ա
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Update(UserInfo user)
        {
            return DALFactory.CreateUserDAL().Update(user);
        }
        /// <summary>
        /// �жϻ�Ա�Ƿ����������
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsInBlack(string name)
        {
            return DALFactory.CreateUserDAL().InBlack(name);
        }
        /**/
        /// <summary>
        /// ɾ����Ա
        /// </summary>
        /// <param name="id">��ɾ���Ļ�Ա��ID</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool Remove(int id)
        {
            return DALFactory.CreateUserDAL().Delete(id);
        }
        /**/
        /// <summary>
        /// �޸Ļ�Ա����
        /// </summary>
        /// <param name="id">���޸�����Ļ�Ա��ID</param>
        /// <param name="password">������</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool ChangePassword(string user, string password)
        {
            return DALFactory.CreateUserDAL().UpdatePass(user, password);
        }

        /// <summary>
        /// �޸Ļ�Ա�������
        /// </summary>
        /// <param name="user">���޸���ݵĻ�Ա��</param>
        /// <param name="isowner">�Ƿ�Ϊ����</param>
         /// <returns>�Ƿ�ɹ�</returns>
        public bool ChangeOwner(string user, bool isowner)
        {
            return DALFactory.CreateUserDAL().UpdateOwner(user, isowner);
        }
        
        
       
       
        /// <summary>
        /// ��Ա��¼
        /// </summary>
        /// <param name="name">��Ա��¼��</param>
        /// <param name="password">��Ա����</param
        /// /// <returns>�����¼�ɹ����򷵻�true ���򷵻�false</returns>
        public bool Login(string name, string password)
        {
            return DALFactory.CreateUserDAL().IsRight(name, password);
        }
        /**/
        /// <summary>
        /// ȡ��ȫ����Ա��Ϣ
        /// </summary>
        /// <returns>��Աʵ���༯��</returns>
        public IList<UserInfo> GetAll()
        {
            return DALFactory.CreateUserDAL().GetAll();
        }
        /// <summary>
        /// ͨ����Ա�����ػ�Ա��Ϣ
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserInfo GetByName(string username)
        {
            return DALFactory.CreateUserDAL().GetByName(username );
        }
    }
}
