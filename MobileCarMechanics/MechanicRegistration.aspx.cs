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


public partial class MechanicRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = CityLogic.SelectAll();
            ddlCity.DataSource = dt;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();

        }

    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        bool isAvailable1 = CustomerLogic.checkAvailable(txtMechanicUsername.Text);
        bool isAvailable2 = MechanicLogic.checkAvailable(txtMechanicUsername.Text);

        if (!isAvailable1 || !isAvailable2)
        {
            Response.Write("<script>alert('Username already taken. Please enter another username.')</script>");
            return;
        }

        Mechanic m = new Mechanic();
        m.MechanicName = txtMechanicName.Text;
        m.MechanicAddress = txtMechanicAddress.Text;
        m.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
        m.MechanicEmail = txtMechanicEmail.Text;
        m.MechanicUsername = txtMechanicUsername.Text;
        m.MechanicPassword = txtMechanicPassword.Text;
        m.MechanicMobileNo = txtMechanicMobileNo.Text;

        string prefix1 = DateTime.Now.Ticks.ToString();
        MechanicPhoto.SaveAs(Server.MapPath("mechanicuploads\\" + prefix1 + MechanicPhoto.FileName));
        m.MechanicPhoto = prefix1 + MechanicPhoto.FileName;

        string prefix2 = DateTime.Now.Ticks.ToString();
        MechanicPhotoProof.SaveAs(Server.MapPath("mechanicuploads\\" + prefix2 + MechanicPhotoProof.FileName));
        m.MechanicPhotoProof = prefix2 + MechanicPhotoProof.FileName;

        // Gmail Address from where you send the mail
        var fromAddress = "mcmproject2@gmail.com";
        var fromPassword = "mcm12345";
        // any address where the email will be sending
        var toAddress = m.MechanicEmail;
        string subject = "Welcome to MCM";
        string body = "hello" + "\n\n" + txtMechanicName.Text + ",\n\n" + " welcome to MCM" + "\n\n" + "\n\n" + "Thank you for Register";

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

        MechanicLogic.Insert(m);

        successMsg.Visible = true;

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }
}