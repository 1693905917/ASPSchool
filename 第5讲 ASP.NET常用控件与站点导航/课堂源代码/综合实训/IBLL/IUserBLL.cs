using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IBLL
{
    public interface IUserBLL
    {
        /**/
        /// <summary>
        /// ��ӻ�Ա
        /// </summary>
        /// <param name="user">��Աʵ����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Add(UserInfo  user);
        /// <summary>
        /// ���»�Ա
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Update(UserInfo user);
        /// <summary>
        /// �жϻ�Ա�Ƿ����������
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool IsInBlack(string name);
        /**/
        /// <summary>
        /// ɾ����Ա
        /// </summary>
        /// <param name="id">��ɾ���Ļ�Ա��ID</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Remove(int id);
        /**/
        /// <summary>
        /// �޸Ļ�Ա����
        /// </summary>
        /// <param name="id">���޸�����Ļ�Ա��ID</param>
        /// <param name="password">������</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool ChangePassword(string user, string password);

        bool ChangeOwner(string user, bool isowner);
        
        /**/
        /// <summary>
        /// ��Ա��¼
        /// </summary>
        /// <param name="name">��Ա��¼��</param>
        /// <param name="password">��Ա����</param
        /// <returns>�����¼�ɹ����򷵻�true�����򷵻�false</returns>
        bool  Login(string name, string password);
        
        /**/
        /// <summary>
        /// ȡ��ȫ����Ա��Ϣ
        /// </summary>
        /// <returns>��Աʵ���༯��</returns>
        IList<UserInfo > GetAll();
       
        /// <summary>
        /// ͨ����Ա�����ػ�Ա��Ϣ
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        UserInfo GetByName(string username);

    }
}
