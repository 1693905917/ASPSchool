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
        /// 评论者
        /// </summary>
        public string User
        {
            get { return user; }
            set { user = value; }
        } 
        /// <summary>
        /// 评论id
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// 所评论的信息
        /// </summary>
        public int Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
