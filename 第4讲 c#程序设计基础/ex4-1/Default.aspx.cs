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
        this.Title = "简单算术计算器"; //设置浏览器标题栏中显示的文字
        txtResult.ReadOnly = true;		//设置文本框为只读文本框（在代码中设置对象属性）
        txtNum1.Focus();        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        float result;//声明1个单精度变量（过程级局部变量）                              
        result = float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text);//将文本框中的字符串数据转换为单精度类型后相加  
        txtResult.Text = result.ToString();		//将运算结果转换成字符串，并写入文本框
    }

    protected void btnSub_Click(object sender, EventArgs e)
    {
        float result;                           
        result = float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text);
        txtResult.Text = result.ToString();		//将运算结果转换成字符串，并写入文本框
    }

    protected void btnMulti_Click(object sender, EventArgs e)
    {
        float result;      
        result = float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text);
        txtResult.Text = result.ToString();
    }

    protected void btnDivi_Click(object sender, EventArgs e)
    {
        float result;                             
        result = float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text);
        txtResult.Text = result.ToString();	
    }
}