using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studentData
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 模拟从数据库或其他数据源中获取学生信息
                List<Student> students = GetStudentData();

                // 绑定数据到GridView控件
                GridView1.DataSource = students;
                GridView1.DataBind();
            }
        }

        // 模拟从数据源中获取学生信息的方法
        private List<Student> GetStudentData()
        {
            List<Student> students = new List<Student>();

            // 添加一些学生信息（这里模拟硬编码的方式，实际中可以从数据库或其他地方获取）
            students.Add(new Student { StudentID = 1, Name = "张三", Age = 20, Grade = "A" });
            students.Add(new Student { StudentID = 2, Name = "李四", Age = 21, Grade = "B" });
            students.Add(new Student { StudentID = 3, Name = "王五", Age = 19, Grade = "A-" });
            students.Add(new Student { StudentID = 4, Name = "赵六", Age = 22, Grade = "B+" });
            students.Add(new Student { StudentID = 4, Name = "山东哥布林", Age = 22, Grade = "C-" });
            return students;
        }

        // 定义一个学生类
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }
    }
}