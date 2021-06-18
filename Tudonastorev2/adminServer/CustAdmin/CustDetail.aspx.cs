using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TudonaStoreBL;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using TudoNaStoreEntity;

public partial class CustAdmin_CustDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        regionID.DataSource = TudonaStoreBL.EntityGenericBL.GetRegionValues();
        regionID.DataTextField = "Name";
        regionID.DataValueField = "Key";
        regionID.DataBind();

        statusID.DataSource = TudonaStoreBL.EntityGenericBL.GetStatusValues("Client");
        statusID.DataTextField = "Name";
        statusID.DataValueField = "Key";
        statusID.DataBind();
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        ClientEntity cl = new ClientEntity();
        cl.ClientContactName = contactName.Text;
        cl.ClientContactNumber = contactNumber.Text;
        cl.FullAdress = fullAddress.Text;
        cl.Geolocation = geoLocation.Text;
        cl.Zipcode = zipCode.Text;
        cl.ClientHost = host.Text;
        cl.ClientPhoneNumber = phoneNumber.Text;
        cl.ClientRegionID = Int32.Parse(regionID.SelectedValue);
        cl.ClientStatusID = Int32.Parse(statusID.SelectedValue);
        lblMessage.Text = "";

        try
        {
            
            cl.Validate();
            ClientBL.InsertClient(cl);
            lblMessage.Text = "Successfull saving";
        }
        catch (EntityException ex)
        {
            lblMessage.Text = ex.Message;
        }
        
    }
}