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

public partial class bottom : System.Web.UI.Page
{
    protected ArrayList ItemList = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            DDLBind(); 
            DropDownList1.Items.Insert(0,"所有人");
        }
    }
    public void DDLBind()
    { 
           Application.Lock ();
           string users;       //已在线的用户名
           string[] user;        //用户在线数组
            if (Session["user"] != null)
            {   

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            int num = int.Parse(Application["userNum"].ToString ());
            users = Application["user"].ToString();
            user = users.Split(',');
            for (int i=(num-1); i >= 0; i--)
            {
                ItemList.Add(user[i].ToString()); 
            }
            ItemList.Remove(Session["user"]);
            DropDownList1.DataSource = ItemList;
            DropDownList1.DataBind();
           
         }
    
    
    protected void  Button1_Click(object sender, EventArgs e)
         {
             Application.Lock();
             string strTxt = TextBox2.Text.ToString();
             int intChatNum = int.Parse(Application["chatnum"].ToString ());
             if (CheckBox1.Checked)
             {
                 //处理私聊内容

                 if (intChatNum == 0 || intChatNum > 40)
                 {
                     intChatNum = 0;
                     Application["chat"] = strTxt.ToString();
                     Application["Owner"] = Session["user"];
                     Application["chattime"] = DateTime.Now;
                     Application["receive"] = DropDownList1.SelectedValue.ToString();
                 }
                 else
                 {
                     

                     Application["chat"] = Application["chat"] + "," + strTxt.ToString();
                     Application["Owner"] = Application["Owner"] + "," + Session["user"];
                     Application["chattime"] = Application["chattime"] + "," + DateTime.Now;
                     Application["receive"] = Application["receive"] + "," + DropDownList1.SelectedValue.ToString();
                        
                 }
                 intChatNum += 1;
                 object obj = intChatNum;
                 Application["chatnum"] = obj;


             }
             else
             {
                //处理公共聊天内容
                 int intcurrent = int.Parse(Application["current"].ToString());
                 if (intcurrent == 0 || intcurrent >40)
                 {
                     intcurrent = 0;
                     Application["chats"] =Session["user"].ToString() + "对" + DropDownList1.SelectedValue.ToString() + "说：" + strTxt.ToString()+"("+ DateTime.Now.ToString()+")" ;
                 }
                 else
                 {
                     Application["chats"] = Application["chats"].ToString() + "," + Session["user"].ToString() + "对" + DropDownList1.SelectedValue.ToString() + "说：" + strTxt.ToString() + "(" + DateTime.Now.ToString() + ")";
                 
                 }
                 intcurrent +=1;
                 object obj = intcurrent;
                 Application["current"] = obj;
             }
             Application.UnLock();
             //刷新聊天页面
             Response.Write("<script language=javascript>");
             Response.Write("this.parent.right.location.reload()");
             Response.Write("</script>");

         }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Application.Lock();
        int intUserNum = int.Parse(Application["userNum"].ToString());
        if (intUserNum == 0)
            Application["user"] = "";
        else
        { 
            string users;       //已在线的用户名
            string [] user;     //用户在线数组
            string OwnerName=Session["user"].ToString();
            users = Application["user"].ToString();
            Application["user"]="";
            user = users.Split(',');
            for (int i=0; i < (user.Length  - 1); i++)
              {
                  if(user[i].Trim ()!=OwnerName.Trim ())   
                  {
                      Application["user"] = Application["user"] + "," + user[i].ToString();   
                  
                  }
                  else
                     intUserNum -= 1;
              } 
        }

        
         object obj = intUserNum;
         Application["userNum"] = obj;
         Application.UnLock();
         Response.Write("<script language=javascript>");
         Response.Write("window.parent.location='Default.aspx';");
         Response.Write("</script>");
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            DDLBind();
        else
        {
            DDLBind();
            DropDownList1.Items.Insert(0, "所有人");
        }
    }
}

