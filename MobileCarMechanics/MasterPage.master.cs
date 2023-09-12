using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Customer"] != null)
        {
            // current user is customer
            menuadmin.Visible = false;
            menumechanic.Visible = false;
            menuGuest.Visible = false;
            Customer c = (Customer)Session["Customer"];
            lblName.Text = c.CustomerName;
            Repeater1.Visible = false;

       
        }
        else if (Session["Mechanic"] != null)
        {
            // current user is mechanic
            menuadmin.Visible = false;
            menucustomer.Visible = false;
            menuGuest.Visible = false;
            Mechanic c = (Mechanic)Session["Mechanic"];
            lblName.Text = c.MechanicName;
            mechanicnoti.Visible = true;

            Repeater1.DataSource = ServiceRequestLogic.SelectOutstandingRequestByMechanicID(c.MechanicID);
            Repeater1.DataBind();
            ltCount.Text = Repeater1.Items.Count.ToString();
        }
        else if (Session["Admin"] != null)
        {
            // current user is admin
            menucustomer.Visible = false;
            menumechanic.Visible = false;
            menuGuest.Visible = false;
            lblName.Text = "Admin";
        }
        else
        {
            menucustomer.Visible = false;
            menumechanic.Visible = false;
            menuadmin.Visible = false;
            //ltCount.Visible = false;
            //Repeater1.Visible = false;
            //Repeater2.Visible = false;
            lblName.Text = "Guest";

            logoutmenu.Visible = false;
                
        }
    }



    protected void Click_logout(object sender, EventArgs e)
    {
        Session["Admin"] = null;
        Session["Customer"] = null;
        Session["Mechanic"] = null;

        Response.Redirect("CustomerLogin.aspx");
    }
}
