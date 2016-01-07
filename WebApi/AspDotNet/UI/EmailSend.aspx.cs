using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApi.AspDotNet.UI
{
    public partial class EmailSend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tags.Focus();;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtMessageBody.Text = tags.Text;


            string sub = "Tracking Issues From Federal Freight System Ltd";

            StringBuilder sb = new StringBuilder();
            sb.Append("Dear Sir,");
            sb.Append(Environment.NewLine);
            sb.Append("Thanks for choosing us to serve you and doing business with us.");
            sb.Append(Environment.NewLine);
            sb.Append("We feel immense pleasure to have you with FFSL Family.");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append("Please login to http://ffslbd.com/index.aspx for tracking related issues.");
            sb.Append(Environment.NewLine);
            sb.Append("Login ID       : ");
            sb.Append(Environment.NewLine);
            sb.Append("Login Password : ");

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("For any queries, feel free to contact us through ffslbd@dhaka.net");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("Best Regards");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("George");
            sb.Append("FFSL/Dhaka");
            sb.Append("http://ffslbd.com");
            sb.Append(Environment.NewLine);

            Mail.SendMail("info@ffslbd.com", "", sb.ToString(), sub, "mail.ffslbd.com", " info@ffslbd.com", "");

        }
    }
}