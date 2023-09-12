using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using System.Data;

public partial class MechanicProfile : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Mechanic"] == null)
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

            DataTable dt2 = AreaLogic.SelectAll();
            ddlAreas.DataSource = dt2;
            ddlAreas.DataTextField = "AreaName";
            ddlAreas.DataValueField = "AreaID";
            ddlAreas.DataBind();


            DataTable dt3= ServiceCategoryLogic.SelectAll();
            ddlCategories.DataSource = dt3;
            ddlCategories.DataTextField = "ServiceCategoryName";
            ddlCategories.DataValueField = "ServiceCategoryID";
            ddlCategories.DataBind();


            DataTable dt4 = ServiceLogic.SelectAll();
            ddlServices.DataSource = dt4;
            ddlServices.DataTextField = "ServiceName";
            ddlServices.DataValueField = "ServiceID";
            ddlServices.DataBind();

            Mechanic m = (Mechanic)Session["Mechanic"];
            txtMechanicName.Text = m.MechanicName;
            txtMechanicAddress.Text = m.MechanicAddress;
            txtMechanicEmail.Text = m.MechanicEmail;
            txtMechanicMobileNo.Text = m.MechanicMobileNo;
            ddlCity.SelectedValue = m.CityID.ToString();


            GridView1.DataSource = MechanicAreaLogic.SelectByMechanicID(m.MechanicID);
            GridView1.DataBind();


            GridView2.DataSource = MechanicCategoryLogic.SelectByMechanicID(m.MechanicID);
            GridView2.DataBind();

            GridView3.DataSource = MechanicServiceLogic.SelectByMechanicID(m.MechanicID);
            GridView3.DataBind();






        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Mechanic m = (Mechanic)Session["Mechanic"];
        m.MechanicName = txtMechanicName.Text;
        m.MechanicAddress = txtMechanicAddress.Text;
        m.MechanicEmail = txtMechanicEmail.Text;
        m.MechanicMobileNo = txtMechanicMobileNo.Text;
        m.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);

        if (MechanicPhoto.HasFile)
        {
            string prefix = DateTime.Now.Ticks.ToString();
            MechanicPhoto.SaveAs(Server.MapPath("mechanicuploads\\" + prefix + MechanicPhoto.FileName));
            m.MechanicPhoto = prefix + MechanicPhoto.FileName;
        }
        if (MechanicPhotoProof.HasFile)
        {
            string prefix1 = DateTime.Now.Ticks.ToString();
            MechanicPhotoProof.SaveAs(Server.MapPath("mechanicuploads\\" + prefix1 + MechanicPhotoProof.FileName));
            m.MechanicPhotoProof = prefix1 + MechanicPhotoProof.FileName;
        }
        SuccessMsg.Visible = true;
        FailMsg1.Visible = false;
        SuccessMsg1.Visible = false;
        MechanicLogic.Update(m);
        Session["Mechanic"] = m;
    }
    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        Mechanic m = (Mechanic)Session["Mechanic"];
        if (txtMechanicOldPassword.Text == m.MechanicPassword)
        {
            m.MechanicPassword = txtMechanicNewPassword.Text;
            SuccessMsg1.Visible = true;
            SuccessMsg.Visible = false;
            FailMsg1.Visible = false;
            MechanicLogic.Update(m);
            Session["Mechanic"] = m;
        }
        else
        {
            SuccessMsg1.Visible = false;
            FailMsg1.Visible = true;
            SuccessMsg.Visible = false;
        }
   }
    protected void btnAddArea_Click(object sender, EventArgs e)
    {
        Mechanic m = (Mechanic)Session["Mechanic"];
        MechanicArea ma = new MechanicArea();
        ma.AreaID = Convert.ToInt32(ddlAreas.SelectedItem.Value);
        ma.MechanicID = m.MechanicID;
        MechanicAreaLogic.Insert(ma);
        Response.Redirect("MechanicProfile.aspx");
    }
    protected void btnRemoveArea_Command(object sender, CommandEventArgs e)
    {
       
        MechanicAreaLogic.Delete(Convert.ToInt32(e.CommandArgument));
        Response.Redirect("MechanicProfile.aspx");
    }
    protected void btnAddCategory_Click(object sender, EventArgs e)
    {
        Mechanic m = (Mechanic)Session["Mechanic"];
        MechanicCategory mc = new MechanicCategory();
        mc.ServiceCategoryID = Convert.ToInt32(ddlCategories.SelectedItem.Value);
        mc.MechanicID = m.MechanicID;
        MechanicCategoryLogic.Insert(mc);
        Response.Redirect("MechanicProfile.aspx");
    }
    protected void btnRemoveCategory_Command(object sender, CommandEventArgs e)
    {
        MechanicCategoryLogic.Delete(Convert.ToInt32(e.CommandArgument));
        Response.Redirect("MechanicProfile.aspx");
    }
    protected void btnAddService_Click(object sender, EventArgs e)
    {
        Mechanic m = (Mechanic)Session["Mechanic"];
        MechanicService ms = new MechanicService();
        ms.MechanicServiceID = Convert.ToInt32(ddlServices.SelectedItem.Value);
        ms.MechanicID = m.MechanicID;
        ms.ServiceID = Convert.ToInt32(ddlServices.SelectedItem.Value) ;
        ms.Price = Convert.ToSingle( txtPrice.Text);
        MechanicServiceLogic.Insert(ms);
        Response.Redirect("MechanicProfile.aspx");
    }
    protected void btnRemoveService_Command(object sender, CommandEventArgs e)
    {
        MechanicServiceLogic.Delete(Convert.ToInt32(e.CommandArgument));
        Response.Redirect("MechanicProfile.aspx");
    }
}