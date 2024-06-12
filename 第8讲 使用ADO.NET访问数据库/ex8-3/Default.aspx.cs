using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.OleDb;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "Reader对象应用示例";
        txtUserName.Focus();
        lblMsg.Text = "";
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
        {
            lblMsg.Text = "用户名和密码不能为空";
        }
        string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (OleDbConnection conn = new OleDbConnection(ConnStr))
        {
            conn.Open();
            string StrSQL = "select ulevel from Admin where uname='" + txtUserName.Text +
                         "'and upwd='" + txtPassword.Text + "'";
            OleDbCommand com = new OleDbCommand(StrSQL, conn);
            OleDbDataReader dr = com.ExecuteReader();   //调用ExecuteReader()方法得到dr对象
            dr.Read();      //调用Read()方法得到返回记录集
            string level;
            if (dr.HasRows)     //如果有返回记录存在
            {
                level = dr["ulevel"].ToString();        //获取返回记录中“uleverl”字段值
            }
            else            //如果dr中不包含任何记录，即数据库中没有符合条件的记录
            {
                lblMsg.Text = "用户名或密码错";
                return;
            }
            if (level == "0")
            {
                Session["pass"] = "admin";
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Session["pass"] = "guest";
                Response.Redirect("Guest.aspx");
            }
        }

    }
}