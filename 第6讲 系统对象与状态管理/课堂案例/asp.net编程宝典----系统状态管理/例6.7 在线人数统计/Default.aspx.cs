using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //锁定，不允许其他用户修改变变量
        Application.Lock();
        //更新Application集合中指定对象的值
        Application.Set("Counter", (Convert.ToInt32(Application["Counter"]) + 1).ToString());
        //访客计数增加
        Application.UnLock();//开锁，允许其他用户修改变量
        Response.Write("您是第" + Application["Counter"].ToString() + "位访客");
    }
}
