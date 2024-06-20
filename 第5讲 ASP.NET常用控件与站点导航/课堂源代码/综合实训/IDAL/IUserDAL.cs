using System;
using System.Collections.Generic;
using System.Text;
using BBS.Entity;

namespace BBS.IDAL
{
    public interface IUserDAL
    {
        /// <summary>
        /// �����Ա
        /// </summary>
        /// <param name="user">��Ա����</param>
        /// <returns></returns>
        bool Insert(UserInfo  user);
        
        /// <summary>
        /// �������������
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Update(UserInfo user);
        
        /// <summary>
        /// �Ƿ��ں�������
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool InBlack(string name);
        
        /// <summary>
        /// ͨ��Idɾ����Ա
        /// </summary>
        /// <param name="id">��Աid</param>
        /// <returns></returns>
        bool Delete(int id);
       
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="user">��Ա��</param>
        /// <param name="pwd">�޸ĺ������</param>
        /// <returns></returns>
        bool UpdatePass(string user, string pwd);
        
        // <summary>
        /// �޸Ļ�Ա�İ������
        /// </summary>
        /// <param name="user">��Ա��</param>
        /// <param name="own">�Ƿ�Ϊ�������</param>
        /// <returns></returns>
        bool UpdateOwner(string user, bool own);

        /// <summary>
        /// �������л�Ա��Ϣ
        /// </summary>
        /// <returns></returns>
        IList<UserInfo > GetAll();
        
        /// <summary>
        /// ��֤��Ա���
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        bool IsRight(string name, string pwd);
        
        /// <summary>
        /// ͨ����Ա�����ػ�Ա��Ϣ
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        UserInfo GetByName(string name);
    }
}
