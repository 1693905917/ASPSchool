using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BBS.Factory;
using BBS.Entity;
//using System.Net.Mail;
//using System.Net;
using BBS.Utility;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 提交登录信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtValid.Text != Session["Valid"].ToString())
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('验证码错误！')</script>");
            return;
        }
        string name = txtUser.Text;
        string pwd = txtPwd.Text;
        
        if (BLLFactory.CreateUserBLL().IsInBlack(name))
        {                   
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('该用户已被管理员列入黑名单中，无法登录！')</script>");
            return;
        }            
        //如果信息符合把登录名赋给Session
        if (BLLFactory.CreateUserBLL().Login(name,pwd))
        {
            UserInfo user = new UserInfo();
            user = BLLFactory.CreateUserBLL().GetByName(name);                    
            if (!user.IsOwner)
            {
                Session["User"] = name;
            }
            else
            {
                Session["Admin"] = name;
            }
        
            Response.Redirect("Default.aspx");
         }
         else
         {
             ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户名或密码错！')</script>");
         }       
    }
    /// <summary>
    /// 清空登录信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {     
        txtPwd.Text = "";
        txtUser.Text = "";
        txtValid.Text = "";
        btnSubmit.Focus();
    }
    /// <summary>
    /// 找回密码功能
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnGetPwd_Click(object sender, EventArgs e)
    {
        string username = txtUserPwd.Text;
        UserInfo user = new UserInfo();
        user = BLLFactory.CreateUserBLL().GetByName(username);
        if (user == null)
        {           
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户不存在！')</script>");
            return;
        }
        
        lblQuestion.Text = user.Question;
    }
    protected void lbtnChangeValid_Click(object sender, EventArgs e)
    {
        imgValid.ImageUrl = "~/CreateImage.aspx";
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string username = txtUserPwd.Text;
        UserInfo user = new UserInfo();
        user = BLLFactory.CreateUserBLL().GetByName(username);
        if (user == null)
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户不存在！')</script>");
            return;
        }           
        lblQuestion.Text = user.Question;
        if (Encryptor.MD5Encrypt(txtAnswer.Text) != user.Answer)
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('安全问题答案错误！')</script>");
            return;
        }
           
        //生成随机密码
        Random rand = new Random();
        string number = "0,1,2,3,4,5,6,7,8,9";
        string[] numberarray = number.Split(',');
        string newpwd = "";
        int temp = 0; 
        for (int i = 0; i < 6; i++)
        {
            rand = new Random(i * unchecked((int)DateTime.Now.Ticks));
            temp = rand.Next(9);
            newpwd += numberarray[temp];
        }
        user.UserPwd = Encryptor.MD5Encrypt(newpwd);
        if (BLLFactory.CreateUserBLL().ChangePassword(user.UserName, user.UserPwd))
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('你的新密码是：" + newpwd + "，请及时更改！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('操作失败！')</script>");            
        }
        
    }
    protected void ButtonUpdate_Click(object sender, EventArgs e)//修改密码
    {
        if (TextName.Text == "" || TextOldPwd.Text == "" || TextNewPwd.Text == "" || TextReNewPwd.Text == "")
        {            
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('请输入完整信息！')</script>");
            return;
        }
        if (TextNewPwd.Text != TextReNewPwd.Text)
        {           
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('两次输入的密码不相同！')</script>");
            return;
        }
        string name = TextName.Text;
        string pwd = TextOldPwd.Text;
       
        if (BLLFactory.CreateUserBLL().IsInBlack(name))
        {                    
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('该用户已被管理员列入黑名单中，无法修改密码！')</script>");
            return;
        }
        
        if (BLLFactory.CreateUserBLL().Login(name, pwd))//判断会员是否存在
        {
            string md5pwd = Encryptor.MD5Encrypt(TextNewPwd.Text);
            if (BLLFactory.CreateUserBLL().ChangePassword(TextName.Text, md5pwd))
            {                        
                ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('密码修改成功！')</script>");
            }                    
        }
        else
        {                    
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户名或原密码错！')</script>");                    
        }
       
    }
}
