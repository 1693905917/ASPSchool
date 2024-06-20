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
        /// 是否被加入黑名单
        /// </summary>
        public string InBlack
        {
            get { return inblack; }
            set { inblack = value; }
        }
        /// <summary>
        /// 找回密码提示问题
        /// </summary>
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        /// <summary>
        /// 提示问题答案
        /// </summary>
        public string Answer
        {
            get { return answer; }
            set { answer = value; } 
        }
        /// <summary>
        /// 会员id
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        ///  会员名
        /// </summary>
        public string UserName
        {
            get { return name ; }
            set { name  = value; }
        }
        /// <summary>
        /// 会员密码
        /// </summary>
        public string UserPwd
        {
            get { return password ; }
            set { password  = value; }
        }
        /// <summary>
        /// 会员邮件
        /// </summary>
        public string UserEmail
        {
            get { return email ; }
            set { email  = value; }
        }
        /// <summary>
        /// 所辖版块
        /// </summary>
        public bool IsOwner
        {
            get { return isowner; }
            set { isowner = value; }
        }

    }
}
