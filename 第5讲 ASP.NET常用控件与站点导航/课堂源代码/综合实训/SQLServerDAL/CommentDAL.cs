using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using BBS.IDAL ;
using BBS.Entity;

namespace BBS.SQLServerDAL
{
    public class CommentDAL :ICommentDAL 
    {

        /// <summary>
        /// 插入评论
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public bool Insert(CommentInfo comment)
        {
            string sql = "insert into TComment (CommentContent ,CommentTime , MessageID,CommentUser) values('" + comment.Content + "','" + comment.Time + "','" + comment.Message +"','"+comment.User + "')";
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            string sql = "delete from TComment where CommentID="+id ;
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 通过帖子id返回评论
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public IList<CommentInfo> GetByMessage(int messageid)
        {
            SqlDataReader dataReader = null;
            IList<CommentInfo> commentCollection = new List<CommentInfo>();
            string sql ="select * from TComment where MessageID="+ messageid;
            try
            {
                dataReader  = SQLServerDALHelper.ExecuteSQLReader(sql);
                while (dataReader.Read())
                {
                    CommentInfo  comment = new CommentInfo();
                    comment.ID = (int)dataReader["CommentID"];
                    comment.Content = (string)dataReader["CommentContent"];
                    comment.Time = (DateTime)dataReader["CommentTime"];
                    comment.Message = (int)dataReader["MessageID"];
                    comment.User = (string)dataReader["CommentUser"];
                    commentCollection.Add(comment);

                }
                return commentCollection;

            }
            catch
            {
                return null;
            }
            finally
            {
                dataReader.Close();
            }
        }
        /// <summary>
        /// 通过帖子id删除评论
        /// </summary>
        /// <param name="messageid"></param>
        /// <returns></returns>
        public bool DeleteByMessage(int messageid)
        {
            string sql = "delete from TComment where MessageID=" + messageid;
            try
            {
                SQLServerDALHelper.ExecuteSQLNonQurey(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
