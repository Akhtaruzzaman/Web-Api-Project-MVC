using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Web.UI;

namespace WebApi.AspDotNet.UI
{
    public partial class ReadDataFromExcelSheet : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fileUpload1.Focus();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //Coneection String by default empty  
            string conStr = "";
            //Extantion of the file upload control saving into ext because   
            //there are two types of extation .xls and .xlsx of Excel   
            var extension = Path.GetExtension(fileUpload1.FileName);
            if (extension != null)
            {
                string ext = extension.ToLower();
                //getting the path of the file   
                string path = Server.MapPath(fileUpload1.FileName);
                //saving the file inside the MyFolder of the server  
                fileUpload1.SaveAs(path);
                //checking that extantion is .xls or .xlsx  
                if (ext.Trim() == ".xls")
                {
                    //connection string for that file which extantion is .xls  
                    conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                }
                else if (ext.Trim() == ".xlsx")
                {
                    //connection string for that file which extantion is .xlsx  
                    conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                }
            }
            //making query  
            string query = "SELECT * FROM [Sheet1$]";
            //Providing connection  
            OleDbConnection conn = new OleDbConnection(conStr);
            //checking that connection state is closed or not if closed the   
            //open the connection  
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //create command object  
            OleDbCommand cmd = new OleDbCommand(query, conn);
            // create a data adapter and get the data into dataadapter  
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            //fill the Excel data to data set  
            da.Fill(ds);
            //set data source of the grid view  
            gvExcelFile.DataSource = ds.Tables[0];
            //binding the gridview  
            gvExcelFile.DataBind();
            //close the connection  
            conn.Close();


            Label1.Text = fileUpload1.FileName + "\'s Data showing into the GridView. "+gvExcelFile.Rows.Count+" rows found.";
        }
    }
}