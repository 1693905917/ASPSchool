﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// User 的摘要说明
/// </summary>
public class UserTest
{
    private string username;
    private string password;

	public UserTest()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public string UserName
    {
        get
        {
            return username;
        }
        set
        {
            username = value;
        }
    }

    public string PassWord
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }
}
