using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using System.Net;

public partial class LostPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
            try
            {
                Mechanic m = MechanicLogic.SelectByUsername(txtUsername.Text);
                Customer c = CustomerLogic.SelectByUsername(txtUsername.Text);
 
                if (txtUsername.Text == m.MechanicUsername)
                {
                    //m.MechanicPassword = MechanicLogic.CreateRandomPassword(8);
                    // Gmail Address from where you send the mail
                    var fromAddress = "mcmproject2@gmail.com";
                    // any address where the email will be sending
                    var toAddress = m.MechanicEmail;
                    //Password of your gmail address
                    var fromPassword = "mcm12345";
                    // Passing the values and make a email formate to display
                    string subject = "Welcome to MCM";
                    string body = "Hello" + " " + m.MechanicName + "\n" + "Your username is:" + " " + m.MechanicUsername + " " + "and Password is:" + " " + m.MechanicPassword;

                    // smtp settings
                    var smtp = new System.Net.Mail.SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;

                    // Passing values to smtp object
                    smtp.Send(fromAddress, toAddress, subject, body);
                    //MechanicLogic.Update(m);
                }
                else if (txtUsername.Text == c.CustomerUsername)
                {
                    //m.MechanicPassword = MechanicLogic.CreateRandomPassword(8);
                    // Gmail Address from where you send the mail
                    var fromAddress = "mcmproject2@gmail.com";
                    // any address where the email will be sending
                    var toAddress = c.CustomerEmail;
                    //Password of your gmail address
                    var fromPassword = "mcm12345";
                    // Passing the values and make a email formate to display
                    string subject = "Welcome to MCM";
                    string body = "Hello" + " " + c.CustomerName + "\n" + "Your username is:" + " " + c.CustomerUsername + " " + "and Password is:" + " " + c.CustomerPassword;

                    // smtp settings
                    var smtp = new System.Net.Mail.SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;

                    // Passing values to smtp object
                    smtp.Send(fromAddress, toAddress, subject, body);
                    //MechanicLogic.Update(m);
                }

            }
            catch (Exception)
            {
                //lblInternetRequired.Visible = true;
            }
            Response.Redirect("CustomerLogin.aspx");
    }
}