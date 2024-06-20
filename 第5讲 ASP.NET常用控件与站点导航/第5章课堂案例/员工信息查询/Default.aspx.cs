using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    struct Employee
    {
        public string name; 
        public bool sex; 
        public string birthday;
        public string branch;
        public string duty;
        public string phone;
    }
    Employee[] emp =new Employee[6];
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "员工信息查询系统";
        emp[0].sex = true; emp[0].birthday = "1976.6";emp[0].branch = "市场部"; 
        emp[0].duty = "工程师"; emp[0].phone = "010-12345678";
        emp[1].sex = false; emp[1].birthday = "1978.1";emp[1].branch = "销售部";
        emp[1].duty = "经  理"; emp[1].phone = "010-23456789";
        emp[2].sex = true; emp[2].birthday = "1984.2";emp[2].branch = "市场部";
        emp[2].duty = "技术员"; emp[2].phone = "010-34567890";
        emp[3].sex = true; emp[3].birthday = "1973.8";emp[3].branch = "办公室"; 
        emp[3].duty = "副经理"; emp[3].phone = "010-45678901";
        emp[4].sex = false; emp[4].birthday = "1970.3";emp[4].branch = "办公室";
        emp[4].duty = "主  任"; emp[4].phone = "010-56789012";
        emp[5].sex = false; emp[5].birthday = "1980.5";emp[5].branch = "服务部";
        emp[5].duty = "技术员"; emp[5].phone = "010-67890123";
    }

    protected void lbtnName_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        lblName.Text =lbtn.Text;
        lblSex.Text = emp[lbtn.TabIndex].sex ? "男" : "女";
        lblBirthday.Text = emp[lbtn.TabIndex].birthday;
        lblBranch.Text = emp[lbtn.TabIndex].branch;
        lblDuty.Text = emp[lbtn.TabIndex].duty;
        lblPhone.Text = emp[lbtn.TabIndex].phone;

    }
}
