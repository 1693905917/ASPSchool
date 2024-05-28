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

public partial class List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList ItemList = new ArrayList();
        Application.Lock();
        string P_str_names;       //已在线的用户名
        string[] P_str_user;        //用户在线数组
        int P_int_num =Convert.ToInt32(Application["userNum"]);
        P_str_names = Application["user"].ToString();
        P_str_user = P_str_names.Split(',');
        for (int i = (P_int_num - 1); i >= 0; i--)
        {
            if(P_str_user[i].ToString ()!="")
                ItemList.Add(P_str_user[i].ToString());
        }
        lbList.DataSource = ItemList;
        lbList.DataBind();
        Application.UnLock();
    }
}
