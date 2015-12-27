using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI;
using AllAspFunction;
using WebApi.Models;

namespace WebApi.AspDotNet.UI
{
    public partial class GridToExcel : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        public void ShowGrid()
        {
            using (InfoDbContext dc = new InfoDbContext())
            {
                gbDetails.DataSource = dc.InformationDbSet.ToList();
                gbDetails.DataBind();
            }
        }
        private void ExportGrid(string fileName, string contentType)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=" + Function.Timezone(DateTime.Now) + fileName);
            Response.Charset = "";
            Response.ContentType = contentType;

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);


            // Read Style file (css) here and add to response 
            FileInfo fi = new FileInfo(Server.MapPath("~/Content/bootstrap.css"));
            StringBuilder sb = new StringBuilder();
            StreamReader sr = fi.OpenText();
            while (sr.Peek() >= 0)
            {
                sb.Append(sr.ReadLine());
            }
            sr.Close();

            gbDetails.RenderControl(hw);
            Response.Write("<html><head><style type='text/css'>" + sb + "</style></head><body>" + sw + "</body></html>");
            Response.Flush();
            Response.Close();
            Response.End();

        }
        protected void btnExportWord_Click(object sender, EventArgs e)
        {
            // Export Gridview to Word
            ExportGrid("GridviewData.doc", "application/vnd.ms-word");
        }
        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Export Gridview to Excel
            ExportGrid("GridviewData.xls", "application/vnd.ms-excel");
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            // this is required for avoid error (control must be placed inside form tag)
        }
    }
}