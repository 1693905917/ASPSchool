using System;
using System.Collections.Generic;
using System.Text;

namespace BBS.Entity
{
    [Serializable ] 
    public class CategoryInfo
    {
        private int id;
        private string category;
        private string owner;
        /// <summary>
        /// ��������id
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; } 
        }
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public string CategoryOwner
        {
            get { return owner ; }
            set { owner  = value; }
        } 
    }
}
