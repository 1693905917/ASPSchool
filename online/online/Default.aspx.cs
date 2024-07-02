using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 检查并增加在线人数
                if (Session["OnlineUsersCount"] == null)
                {
                    Session["OnlineUsersCount"] = 1;
                }
                else
                {
                    Session["OnlineUsersCount"] = (int)Session["OnlineUsersCount"] + 1;
                }

                // 更新页面上的在线人数显示
                UpdateOnlineUsersCountLabel();
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // 减少在线人数
            if (Session["OnlineUsersCount"] != null)
            {
                Session["OnlineUsersCount"] = (int)Session["OnlineUsersCount"] - 1;
                UpdateOnlineUsersCountLabel();
            }
        }

        private void UpdateOnlineUsersCountLabel()
        {
            // 显示当前在线人数
            int onlineUsersCount = (int)Session["OnlineUsersCount"];
            lblOnlineUsersCount.Text = $"当前在线人数：{onlineUsersCount}";
        }
    }
}