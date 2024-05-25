using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Words;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Document doc1 = new Document("1.docx");
        Document doc2 = new Document("2.docx");
        doc2.FirstSection.PageSetup.SectionStart = SectionStart.Continuous;        
        doc1.AppendDocument(doc2, ImportFormatMode.UseDestinationStyles);
        doc1.Save("out.docx");
        ClientScript.RegisterStartupScript(GetType(), "Startup", "<script>alert('OK！')</script>");
    }
}