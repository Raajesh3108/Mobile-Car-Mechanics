using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using DataAccessLayer;
using System.Data;

public partial class MechanicDetail : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Admin"] == null)
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


            if (Request.QueryString["ID"] != null)
            {
                // edit mode
                Mechanic obj = MechanicLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
                txtMechanicName.Text = obj.MechanicName;
                txtMechanicAddress.Text = obj.MechanicAddress;
                txtMechanicEmail.Text = obj.MechanicEmail;
                txtMechanicUsername.Text = obj.MechanicUsername;
                txtMechanicPassword.Text = obj.MechanicPassword;
                txtMechanicMobileNo.Text = obj.MechanicMobileNo;
                ddlCity.SelectedValue = obj.CityID.ToString();
                txtMechanicUsername.Enabled = false;
            }
            else
            {
                btnDelete.Visible = false;
            }
            if (Session["Customer"] != null)
            {
                //Customer is logged in currently
                btnSave.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            // insert mode
            // check if username is available

            bool isAvailable1 = MechanicLogic.checkAvailable(txtMechanicUsername.Text);
            bool isAvailable2 = CustomerLogic.checkAvailable(txtMechanicUsername.Text);

            if (!isAvailable1 || !isAvailable2)
            {
                Response.Write("<script>alert('Username already taken. Please enter another username.')</script>");
                return;
            }

            Mechanic obj = new Mechanic();
            obj.MechanicName = txtMechanicName.Text;
            obj.MechanicAddress = txtMechanicAddress.Text;
            obj.MechanicEmail = txtMechanicEmail.Text;
            obj.MechanicUsername = txtMechanicUsername.Text;
            obj.MechanicPassword = txtMechanicPassword.Text;
            obj.MechanicMobileNo = txtMechanicMobileNo.Text;
            obj.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);

            string prefix1 = DateTime.Now.Ticks.ToString();
            MechanicPhoto.SaveAs(Server.MapPath("mechanicuploads\\" + prefix1 + MechanicPhoto.FileName));
            obj.MechanicPhoto = prefix1 + MechanicPhoto.FileName;

            string prefix2 = DateTime.Now.Ticks.ToString();
            MechanicPhotoProof.SaveAs(Server.MapPath("mechanicuploads\\" + prefix2 + MechanicPhotoProof.FileName));
            obj.MechanicPhotoProof = prefix2 + MechanicPhotoProof.FileName;

            
            MechanicLogic.Insert(obj);

            Response.Redirect("MechanicSearch.aspx");
        }
        else
        {
            Mechanic obj = MechanicLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.MechanicName = txtMechanicName.Text;
            obj.MechanicAddress = txtMechanicAddress.Text;
            obj.MechanicEmail = txtMechanicEmail.Text;
            obj.MechanicUsername = txtMechanicUsername.Text;
            obj.MechanicPassword = txtMechanicPassword.Text;
            obj.MechanicMobileNo = txtMechanicMobileNo.Text;

            string prefix1 = DateTime.Now.Ticks.ToString();
            MechanicPhoto.SaveAs(Server.MapPath("mechanicuploads\\" + prefix1 + MechanicPhoto.FileName));
            obj.MechanicPhoto = prefix1 + MechanicPhoto.FileName;

            string prefix2 = DateTime.Now.Ticks.ToString();
            MechanicPhotoProof.SaveAs(Server.MapPath("mechanicuploads\\" + prefix2 + MechanicPhotoProof.FileName));
            obj.MechanicPhotoProof = prefix2 + MechanicPhotoProof.FileName;
            obj.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);

            MechanicLogic.Update(obj);

            Response.Redirect("MechanicSearch.aspx");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        MechanicLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("MechanicSearch.aspx");
    }
}