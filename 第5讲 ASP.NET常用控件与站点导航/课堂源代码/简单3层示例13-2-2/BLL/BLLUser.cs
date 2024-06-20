using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Data;

namespace BLL
{
    public class BLLUser
    {
        public void UserInfo(string username, string userpwd, int userlevel)
        {
            userpwd = FormsAuthentication.HashPasswordForStoringInConfigFile(userpwd, "MD5");
            DAL.DALUser add = new DAL.DALUser();
            add.AddUser(username,userpwd,userlevel);
        }

        public DataTable DSource()
        {
            DAL.DALUser dsource = new DAL.DALUser();
            return dsource.ToTab();
        }

    }
}
