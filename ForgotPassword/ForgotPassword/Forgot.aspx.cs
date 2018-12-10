using System;  using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForgotPassword
{
    public partial class Forgot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            try
            {
                DataSet ds = new DataSet();
                using (con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT UserName,Password FROM UserInfo Where Email= '" + txtEmail.Text.Trim() + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress(txtEmail.Text);
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["UserName"] + "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["Password"] + "<br/><br/>";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("yourusername@gmail.com", "yourpassword");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    //Msg = null;
                    lbltxt.Text = "Your Password Details Sent to your mail";
                    // Clear the textbox valuess
                    txtEmail.Text = "";
                }
                else
                {
                    lbltxt.Text = "The Email you entered not exists.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
    }
}
