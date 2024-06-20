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
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "个人情况调查";
        TextName.Focus();
    }
    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (TextName.Text == "")
        {
            LabelName.Text = "<b>你必须输入姓名！</b>";
            return;
        }
        string Sex="",Like="";
        int i;
        if (RadioSex1.Checked)
        {
            Sex = "男";
        }
        else
        {
            Sex = "女";
        }
        for (i = 0; i <= ChecklLike.Items.Count - 1; i++)
        {
            if (ChecklLike.Items[i].Selected)
            {
                Like = Like + ChecklLike.Items[i].Text + "，";
            }
        }
        LabelName.Text = TextName.Text + "，" + Sex+ "，" + "你喜欢的歌手是：" + DropSinger.Text;
        LabelHome.Text = "你家住在：" + RadioHome.SelectedItem.Text;
        if (Like == "")
        {
            Like = "真可惜，你没有任何爱好！";
        }
        else
        {
            Like  = "你的爱好是：" + Like;
            Like = Like.Remove(Like.Length - 1, 1);

        }
        LabelLike.Text = Like;
    }
}
