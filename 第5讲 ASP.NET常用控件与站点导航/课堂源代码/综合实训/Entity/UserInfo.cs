using System;
using System.Collections.Generic;
using System.Text;

namespace BBS.Entity
{
    [Serializable ] 
    public class UserInfo
    {
        private int id;
        private string name;
        private string password;
        private string email;
        private string inblack;
        private string question;
        private string answer;
        private bool isowner;
        /// <summary>
        /// �Ƿ񱻼��������
        /// </summary>
        public string InBlack
        {
            get { return inblack; }
            set { inblack = value; }
        }
        /// <summary>
        /// �һ�������ʾ����
        /// </summary>
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        /// <summary>
        /// ��ʾ�����
        /// </summary>
        public string Answer
        {
            get { return answer; }
            set { answer = value; } 
        }
        /// <summary>
        /// ��Աid
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        ///  ��Ա��
        /// </summary>
        public string UserName
        {
            get { return name ; }
            set { name  = value; }
        }
        /// <summary>
        /// ��Ա����
        /// </summary>
        public string UserPwd
        {
            get { return password ; }
            set { password  = value; }
        }
        /// <summary>
        /// ��Ա�ʼ�
        /// </summary>
        public string UserEmail
        {
            get { return email ; }
            set { email  = value; }
        }
        /// <summary>
        /// ��Ͻ���
        /// </summary>
        public bool IsOwner
        {
            get { return isowner; }
            set { isowner = value; }
        }

    }
}
