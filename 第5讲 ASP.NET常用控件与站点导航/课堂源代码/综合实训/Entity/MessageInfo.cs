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
        /// ���ӵĵ����
        /// </summary>
        public int ClickNumber
        {
            get { return clicknumber; }
            set { clicknumber = value; }
        }
        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public int IsTop
        {
            get { return istop ; }
            set { istop  = value; }
        }
        /// <summary>
        /// �������ʱ��
        /// </summary>
        public DateTime LastTime
        {
            get { return lasttime; }
            set { lasttime = value; }
        }
        /// <summary>
        /// ���ӵı���
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>
        /// ��Ϣid
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// �����ߵ��ǳ�
        /// </summary>
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }
        /// <summary>
        /// �����ߵ�����
        /// </summary>
        //public string GuestEmail
        //{
            //get { return guestEmail; }
            //set { guestEmail = value; }
        //}
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
        /// �Ƿ�ͨ����֤
        /// </summary>
        public string Ispass
        {
            get { return isPass; }
            set { isPass = value; }
        }
        /// <summary>
        /// ���ӵ�����
        /// </summary>
        public string MessKind
        {
            get { return messkind; }
            set { messkind = value; }
        }
    }
}
