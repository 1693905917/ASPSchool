using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YangHuiTriangle
{
    public partial class _Default : Page
    {
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRows.Text))
            {
                int rows = Convert.ToInt32(txtRows.Text);
                litTriangle.Text = GeneratePascalsTriangle(rows);
            }
        }

        private string GeneratePascalsTriangle(int rows)
        {
            StringBuilder triangle = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                int number = 1;

                for (int j = 0; j <= i; j++)
                {
                    triangle.Append(number + " ");
                    number = number * (i - j) / (j + 1);
                }

                triangle.Append("<br />");
            }

            return triangle.ToString();
        }
    }
}