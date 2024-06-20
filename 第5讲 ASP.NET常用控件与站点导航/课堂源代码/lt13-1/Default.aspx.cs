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
    
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        Student stu = new Student(); //实例化一个Student类对象stu
        stu.StuName = TextName.Text;
        stu.StuClass = TextClass.Text;
        int var1 = int.Parse(TextChs.Text);
        int var2 = int.Parse(TextMath.Text);
        LabelMsg.Text = stu.StuName + "&nbsp;&nbsp;" + stu.StuClass  + " 总分：" + stu.GradeSum(var1, var2 );   
        
    }
    class Student   //创建Student类
    { 
        private string stuname;	//声明字段变量
        private string stuclass;        

        public string StuName   //定义类的属性
        {
            get { return stuname; }
            set { stuname = value; }
        }
        public string StuClass
        {
            get { return stuclass; }
            set { stuclass = value; }
        }
        

        public int GradeSum(int chs, int math)  //创建类的方法
        {            
            int sum = chs + math;
            return sum;
        }        
    }
}
