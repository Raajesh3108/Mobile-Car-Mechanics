using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;



public partial class CustomerLogin : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
    }

    protected void btnCustomerLogin_Click(object sender, EventArgs e)
    {
        Customer c = CustomerLogic.Validate(txtCustomerUsername.Text, txtCustomerPassword.Text);
        Mechanic M = MechanicLogic.Validate(txtCustomerUsername.Text, txtCustomerPassword.Text);

        if (txtCustomerUsername.Text == "admin" && txtCustomerPassword.Text == "admin")
        {
            Session["Admin"] = 1;
            Response.Redirect("AdminHome.aspx");
        }
        else if (c.CustomerID > 0)
        {
            //VALID CUSTOMER
            Session["Customer"] = c;
            Response.Redirect("CustomerHome.aspx");
        }
        else if (M.MechanicID > 0)
        {
            //VALID CUSTOMER
            Session["Mechanic"] = M;
            Response.Redirect("MechanicHome.aspx");
        }
        else
        {
            //INVALID CUSTOMER
            failMsg.Visible = true;
        }
    }
}