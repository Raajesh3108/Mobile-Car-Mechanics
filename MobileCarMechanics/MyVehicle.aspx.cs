using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;

public partial class MyVehicle : System.Web.UI.Page
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
            if (Request.QueryString["ID"] != null)
            {
                int VehicleID = Convert.ToInt32(Request.QueryString["ID"]);
                Vehicle obj = VehicleLogic.SelectByID(VehicleID);
                txtVehicleNumber.Text = obj.VehicleNumber;
                txtMake.Text = obj.Make;
                txtModel.Text = obj.Model;
            }
            else
            {
                btnDelete.Visible = false;
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            Customer c = (Customer)Session["Customer"];
            Vehicle obj = new Vehicle();
            obj.VehicleNumber = txtVehicleNumber.Text;
            obj.Make = txtMake.Text;
            obj.Model = txtModel.Text;
            obj.CustomerID = ((Customer)Session["Customer"]).CustomerID;



            string prefix = DateTime.Now.Ticks.ToString();
            VehiclePhoto.SaveAs(Server.MapPath("vehicleuploads\\" + prefix + VehiclePhoto.FileName));
            obj.VehiclePhoto = prefix + VehiclePhoto.FileName;

            VehicleLogic.Insert(obj);
            Session["Customer"] = c;

            Response.Redirect("MyVehicleUpdate.aspx");
        }
        else
        {
            Customer c = (Customer)Session["Customer"];            
            Vehicle obj = VehicleLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.VehicleNumber = txtVehicleNumber.Text;
            obj.Make = txtMake.Text;
            obj.Model = txtModel.Text;
            obj.CustomerID = ((Customer)Session["Customer"]).CustomerID;



            if (VehiclePhoto.HasFile)
            {
                string prefix = DateTime.Now.Ticks.ToString();
                VehiclePhoto.SaveAs(Server.MapPath("vehicleuploads\\" + prefix + VehiclePhoto.FileName));
                obj.VehiclePhoto = prefix + VehiclePhoto.FileName;
            }

            VehicleLogic.Update(obj);
            Session["Customer"] = c;

            Response.Redirect("MyVehicleUpdate.aspx");

        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        VehicleLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("MyVehicleUpdate.aspx");
    }
}