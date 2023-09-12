using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;
using System.Net.Mail;
using System.Net;


public partial class CustomerRegistration : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = AreaLogic.SelectAll();
            ddlArea.DataSource = dt;
            ddlArea.DataTextField = "AreaName";
            ddlArea.DataValueField = "AreaID";
            ddlArea.DataBind();

        }
    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        
            bool isAvailable1 = CustomerLogic.checkAvailable(txtCustomerUsername.Text);
            bool isAvailable2 = MechanicLogic.checkAvailable(txtCustomerUsername.Text);

            if (!isAvailable1 || !isAvailable2)
            {
                Response.Write("<script>alert('Username already taken. Please enter another username.')</script>");
                return;
            }

            Customer Cust = new Customer();
            Cust.CustomerAddress = txtCustomerAddress.Text;
            Cust.CustomerEmail = txtCustomerEmail.Text;
            Cust.CustomerName = txtCustomerName.Text;
            Cust.CustomerPassword = txtPassword.Text;
            Cust.AreaID = Convert.ToInt32(ddlArea.SelectedItem.Value);
            Cust.CustomerMoblieNo = txtCustomerMobileNo.Text;

            string prefix = DateTime.Now.Ticks.ToString();
            CustomerPhoto.SaveAs(Server.MapPath("customeruploads\\" + prefix + CustomerPhoto.FileName));
            Cust.CustomerPhoto = prefix + CustomerPhoto.FileName;

            Cust.CustomerUsername = txtCustomerUsername.Text;



            // Gmail Address from where you send the mail
            var fromAddress = "mcmproject2@gmail.com";
            var fromPassword = "mcm12345";
            // any address where the email will be sending
            var toAddress = Cust.CustomerEmail;
            string subject = "Welcome to MCM";
            string body = "hello" + "\n\n" + txtCustomerName.Text + ",\n\n" + " welcome to MCM" + "\n\n" + "\n\n" + "Thank you for Register";
            
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
            


            CustomerLogic.Insert(Cust);

            successMsg.Visible = true;

        
    }
}