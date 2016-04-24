using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace WebApi.AspDotNet.UI
{
    public partial class BackUpDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "";
            string dbname = "asl_shadesh";
            con.ConnectionString = @"Server=(local);database=" + dbname + ";Integrated Security=true;";
            con.Open();


            try
            {
                cmd = new SqlCommand("backup database asl_shadesh to disk='" + Server.MapPath("app_data") + "\\" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".Bak'", con);
                cmd.ExecuteNonQuery();
                //Close connection
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            Label1.Text = "Database Backup is complete";
        }
    }
}