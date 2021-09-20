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
        #region load region
        regionID.DataSource = TudonaStoreBL.EntityGenericBL.GetRegionValues();
        regionID.DataTextField = "Name";
        regionID.DataValueField = "Key";
        regionID.DataBind();
        #endregion

        #region loadclient
        statusID.DataSource = TudonaStoreBL.EntityGenericBL.GetStatusValues("Client");
        statusID.DataTextField = "Name";
        statusID.DataValueField = "Key";
        statusID.DataBind();
        #endregion

        
            if (!IsPostBack & Request.QueryString["edit"] != null)
            {
                ClientEntity cl = new ClientEntity();
                string guid = Request.QueryString["edit"];
                cl = TudonaStoreBL.ClientBL.GetClient(guid);

                contactName.Text = cl.ClientContactName;
                contactNumber.Text = cl.ClientContactNumber;
                fullAddress.Text = cl.FullAdress;
                geoLocation.Text = cl.Geolocation;
                zipCode.Text = cl.Zipcode;
                host.Text = cl.ClientHost;
                phoneNumber.Text = cl.ClientPhoneNumber;
                regionID.SelectedValue = cl.ClientRegionID.ToString();
                statusID.SelectedValue = cl.ClientStatusID.ToString();
                addresCom.Text = cl.AddressCom;
                addressNgh.Text = cl.AddressNgh;
                addressNum.Text = cl.AddressNum;
                addressState.Text = cl.AddressSta;
                boxCustSocialNumber.Text = cl.SocialNumber ;
                if (cl.TypeCli == ClientType.F)
                    boxRdF.Checked = true;
                else
                    boxRdPJ.Checked = true;
                boxCustFullName.Text = cl.CustomerFullName;
                boxFace.Text = cl.FacebookID;
                boxInsta.Text = cl.InstagramID;
                boxWhatsapp.Text = cl.WhatsApp;
                boxEmail.Text = cl.Email;
            }

    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustAdmin.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        ClientEntity cl = new ClientEntity();

        int outID;

        Int32.TryParse(Request.QueryString["edit"], out outID);

        cl.ClientID = outID;
        cl.ClientContactName = contactName.Text;
        cl.ClientContactNumber = contactNumber.Text;
        cl.FullAdress = fullAddress.Text;
        cl.Geolocation = geoLocation.Text;
        cl.Zipcode = zipCode.Text;
        cl.ClientHost = host.Text;
        cl.ClientPhoneNumber = phoneNumber.Text;
        cl.ClientRegionID = Int32.Parse(regionID.SelectedValue);
        cl.ClientStatusID = Int32.Parse(statusID.SelectedValue);
        cl.AddressCom = addresCom.Text;
        cl.AddressNgh = addressNgh.Text;
        cl.AddressNum = addressNum.Text;
        cl.AddressSta = addressState.Text;
        cl.SocialNumber = boxCustSocialNumber.Text;
        cl.TypeCli = (boxRdF.Checked ? ClientType.F : ClientType.J);
        cl.CustomerFullName = boxCustFullName.Text;
        cl.FacebookID = boxFace.Text;
        cl.InstagramID = boxInsta.Text;
        cl.WhatsApp = boxWhatsapp.Text;
        cl.Email = boxEmail.Text;

        lblMessage.Text = "";

        try
        {
            
            cl.Validate();
            ClientBL.SaveClient(cl);
            lblMessage.Text = "Successfull saving";
        }
        catch (EntityException ex)
        {
            lblMessage.Text = ex.Message;
        }
        
    }
}