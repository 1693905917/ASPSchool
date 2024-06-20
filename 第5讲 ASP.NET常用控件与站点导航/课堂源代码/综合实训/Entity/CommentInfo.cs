using System;
using System.Collections.Generic;
using System.Text;

namespace BBS.Entity
{
    [Serializable]
    public class CommentInfo
    {
        private int id;
        private string content;
        private DateTime time;
        private int message;
        private string user;
        /// <summary>
        /// ������
        /// </summary>
        public string User
        {
            get { return user; }
            set { user = value; }
        } 
        /// <summary>
        /// ����id
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// �����۵���Ϣ
        /// </summary>
        public int Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
