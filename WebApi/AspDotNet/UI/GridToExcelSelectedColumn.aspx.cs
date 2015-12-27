using System;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApi.Models;
using AllAspFunction;

namespace WebApi.AspDotNet.UI
{
    public partial class GridToExcelSelectedColumn : Page
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
            bool isSelected = false;
            foreach (GridViewRow i in gbDetails.Rows)
            {
                CheckBox cb = (CheckBox)i.FindControl("chkSelect");
                if (cb != null && cb.Checked)
                {
                    isSelected = true;
                    break;
                }
            }

            // export here
            if (isSelected)
            {
                GridView gvExport = gbDetails;
                // this below line for not export checkbox to excel file
                gvExport.Columns[0].Visible = false;
                foreach (GridViewRow i in gbDetails.Rows)
                {
                    gvExport.Rows[i.RowIndex].Visible = false;
                    CheckBox cb = (CheckBox)i.FindControl("chkSelect");
                    if (cb != null && cb.Checked)
                    {
                        gvExport.Rows[i.RowIndex].Visible = true;
                    }
                }

                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename="+ Function.Timezone(DateTime.Now) +fileName);
                Response.Charset = "";
                Response.ContentType = contentType;
                StringWriter sw = new StringWriter();
                HtmlTextWriter htW = new HtmlTextWriter(sw);
                gvExport.RenderControl(htW);
                Response.Output.Write(sw.ToString());
                Response.End();
            }

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