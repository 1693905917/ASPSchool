using System;
using System.Collections.Generic;
using System.Text;

namespace BBS.Entity
{
    [Serializable]
    public class MessageInfo
    {
        private int id;
        private string guestName;
        //private string guestEmail;
        private string content;
        private DateTime time;
        private string isPass;
        private string messkind;
        private string title;
        private int clicknumber;
        private int istop;
        private DateTime lasttime;

        /// <summary>
        /// 帖子的点击量
        /// </summary>
        public int ClickNumber
        {
            get { return clicknumber; }
            set { clicknumber = value; }
        }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public int IsTop
        {
            get { return istop ; }
            set { istop  = value; }
        }
        /// <summary>
        /// 最后评论时间
        /// </summary>
        public DateTime LastTime
        {
            get { return lasttime; }
            set { lasttime = value; }
        }
        /// <summary>
        /// 帖子的标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>
        /// 信息id
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 发帖者的昵称
        /// </summary>
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }
        /// <summary>
        /// 发帖者的邮箱
        /// </summary>
        //public string GuestEmail
        //{
            //get { return guestEmail; }
            //set { guestEmail = value; }
        //}
        /// <summary>
        /// 帖子内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>
        /// 发帖时间
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// 是否通过验证
        /// </summary>
        public string Ispass
        {
            get { return isPass; }
            set { isPass = value; }
        }
        /// <summary>
        /// 帖子的种类
        /// </summary>
        public string MessKind
        {
            get { return messkind; }
            set { messkind = value; }
        }
    }
}
