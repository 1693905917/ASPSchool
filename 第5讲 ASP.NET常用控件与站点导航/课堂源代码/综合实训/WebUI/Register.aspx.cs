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
using BBS.Entity;
using BBS.Factory;
using BBS.Utility;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        //如果用户同意用户注册条款则可以进行注册否则返回首页
        if (RadioAgree.SelectedValue =="同意")
        {
            palNext.Visible = true;
            palFirst.Visible = false;
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    /// <summary>
    /// 提交用户信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //验证验证码
        string valid = txtValid.Text;
        string sessionvalid = Session["Valid"].ToString();
        if (valid != sessionvalid)
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('验证码错误！')</script>");
            return;
        }
        if (txtUser.Text == "admin" || txtUser.Text == "尚未指派")
        { 
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('此为系统专用，请选择其他用户名！')</script>");
            return;
        }
        
        UserInfo info = new UserInfo();
        info = BLLFactory.CreateUserBLL().GetByName(txtUser.Text);
        if (info != null)
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户名已存在，请选择其他！')</script>");            
            return;
        }
        //声明一个会员对象
        UserInfo user = new UserInfo();
        user.UserName = txtUser.Text;
        user.UserPwd = Encryptor.MD5Encrypt(txtPwd.Text);
        user.UserEmail = txtEmail.Text;
        user.InBlack = "No";
        user.Question = txtQuestion.Text.Trim();
        user.Answer = Encryptor.MD5Encrypt (txtAnswer.Text);

        //通过调用业务逻辑层工厂执行添加会员操作 
        if (BLLFactory.CreateUserBLL().Add(user))
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户注册成功！')</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('用户注册失败！')</script>");
        }
    }

    /// <summary>
    /// 清空所写内容
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtPwd.Text = "";
        txtUser.Text = "";
        txtEmail.Text = "";
        txtPwd2.Text = "";
        txtValid.Text = "";
        txtAnswer.Text = "";
        txtQuestion.Text = "";
        txtUser.Focus();
    }
    protected void lbtnChangeImg_Click(object sender, EventArgs e)
    {
        palNext.Visible = true;
        imgValid.ImageUrl = "~/CreateImage.aspx";
    }
}
