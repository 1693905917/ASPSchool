using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int P_int_judge = 0;
        P_int_judge = Convert.ToInt32(Request["value"]);
        if (!IsPostBack)
        {
            if (P_int_judge == 1)
                Response.Write("<script>alert('该用户已经登录！')</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Application.Lock();
        int P_int_num;     //在线人数
        string P_str_name; //登录用户
        string P_str_names; 　//已在线的用户名
        string[] P_str_user;　//用户在线数组
        P_int_num = int.Parse(Application["userNum"].ToString());
        if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('用户名不能为空')</script>");
            TextBox1.Focus();
        }
        else
        {
            P_str_name = TextBox1.Text.Trim();
            P_str_names = Application["user"].ToString();
            P_str_user = P_str_names.Split(',');
            for (int i = 0; i <= P_int_num - 1; i++)
            {
                if (P_str_name == P_str_user[i].Trim())
                {
                    int P_int_judge = 1;
                    Response.Redirect("Login.aspx?value=" + P_int_judge);
                }
            }
            if (P_int_num == 0)
                Application["user"] = P_str_name.ToString();
            else
                Application["user"] = Application["user"] + "," + P_str_name.ToString();
            P_int_num += 1;
            Application["userNum"] = P_int_num;
            Session["userName"] = TextBox1.Text.Trim();
            Application.UnLock();
            Response.Redirect("Default.aspx");
        }
    }
}
