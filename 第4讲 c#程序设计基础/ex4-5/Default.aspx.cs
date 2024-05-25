using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtNum.Text == "" || txtNo.Text == "")
        {
            lblResult.Text = "商品编号或数量不能为空";
            return;
        }
        int no = 0;
        int count = 0;
        try
        {
            no = int.Parse(txtNo.Text);//获取商品编号
            count = int.Parse(txtNum.Text);//获取商品数量
        }
        catch
        {
            lblResult.Text = "编号或数量格式不正确";
            return;
        }
        
        Product p = new Product();//实例化Product类，创建类对象p        
        if (!p.CheckNo(no))//检查输入的编号是否存在
        {
            lblResult.Text = "查无此编号";
            return; //后续代码不再执行
        } 

        Product.Data d = new Product.Data(); //使用类文件中创建的data结构类型声明一个结构变量用于接收返回值        
        d = p.GetData(no, count);//通过p调用Product类中定义的GetData()方法
        lblResult.Text = "编号：" + d.No + "&emsp;&emsp;商品名称：" + d.Name + "&emsp;&emsp;单价：" + d.Cost.ToString("f") + "&emsp;&emsp;数量：" + 
                         txtNum.Text + "&emsp;&emsp;合计：" + d.Total.ToString("f");//取出返回值中的数据显示到标签控件中        
    }
}