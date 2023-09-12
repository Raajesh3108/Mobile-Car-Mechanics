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


public partial class Customer_Mechanic : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Customer"] == null)
        {
            Response.Redirect("Unauthorized.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = CityLogic.SelectAll();
            ddlCity.DataSource = dt;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();
            ddlCity.SelectedValue = Request.QueryString["CID"];
            ddlCity_SelectedIndexChanged(sender, e);
            ddlArea.SelectedValue = Request.QueryString["AID"];

            dt = ServiceCategoryLogic.SelectAll();
            ddlServiceCategory.DataSource = dt;
            ddlServiceCategory.DataTextField = "ServiceCategoryName";
            ddlServiceCategory.DataValueField = "ServiceCategoryID";
            ddlServiceCategory.DataBind();
            ddlServiceCategory.SelectedValue = Request.QueryString["SCID"];
            ddlService.SelectedValue = Request.QueryString["SID"];
            ddlServiceCategory_SelectedIndexChanged(sender, e);


            Customer c = (Customer)Session["Customer"];
            DataTable dt1 = VehicleLogic.SelectByCustomerID(Convert.ToInt32(c.CustomerID));
            ddlVehicle.DataSource = dt1;
            ddlVehicle.DataTextField = "VehicleNumber";
            ddlVehicle.DataValueField = "VehicleID";
            ddlVehicle.DataBind();
        }
    }

    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = AreaLogic.SelectByCityID(Convert.ToInt32(ddlCity.SelectedItem.Value));
        ddlArea.DataSource = dt;
        ddlArea.DataTextField = "AreaName";
        ddlArea.DataValueField = "AreaID";
        ddlArea.DataBind();
    }

    protected void ddlServiceCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = ServiceLogic.SelectByServiceCategoryID(Convert.ToInt32(ddlServiceCategory.SelectedItem.Value));
        ddlService.DataSource = dt;
        ddlService.DataTextField = "ServiceName";
        ddlService.DataValueField = "ServiceID";
        ddlService.DataBind();
    }
    protected void ddlService_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnSelectService_Command(object sender, CommandEventArgs e)
    {
        ServiceRequest obj = new ServiceRequest();
        obj.RequestTime = DateTime.Now;
        obj.CreateTime = DateTime.Now;
        obj.VehicleID = Convert.ToInt32(ddlVehicle.SelectedItem.Value);
        obj.MechanicServiceID = Convert.ToInt32(e.CommandArgument);
        obj.ServiceRequestDetails = txtServiceRequestDetails.Text;
        obj.Status = "Pending";
        obj.Reply = "";
        obj.Feedback = "";
        obj.Rating = 0;
        
        obj.CompletionTime = DateTime.Now;

        ServiceRequestLogic.Insert(obj);
        
        MechanicService ms = MechanicServiceLogic.SelectByID(obj.MechanicServiceID);
        Mechanic m = MechanicLogic.SelectByID(ms.MechanicID);
        Customer c = (Customer)Session["Customer"];

        // Gmail Address from where you send the mail
        var fromAddress = "mcmproject2@gmail.com";
        var fromPassword = "mcm12345";
        // any address where the email will be sending
        var toAddress = m.MechanicEmail;
        string subject = "New Service Request";
        string body = "Hello" + " " + m.MechanicName + ",\n\n" + "You have a new Request from a Customer.\nCustomer Name: " + c.CustomerName + "\nCustomer Mobile: " + c.CustomerMoblieNo + "\nCustomer Email: " + c.CustomerEmail + "\nCustomer Address: " + c.CustomerAddress + "\nService: " + ddlService.SelectedItem.Text + "\nDetails: " + txtServiceRequestDetails.Text + "\n\nThanks,\nTeam MCM";

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

        Response.Redirect("Customer_ReqDetails.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        DataTable dt = MechanicLogic.Search(Convert.ToInt32(ddlArea.SelectedItem.Value), Convert.ToInt32(ddlServiceCategory.SelectedItem.Value), Convert.ToInt32(ddlService.SelectedItem.Value));
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}