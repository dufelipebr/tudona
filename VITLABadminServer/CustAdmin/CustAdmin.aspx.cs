using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TudonaStoreBL;
using TudoNaStoreEntity;

public partial class CustAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Load sample data only once, when the page is first loaded.
        if (!IsPostBack)
        {
            customers.DataSource = TudonaStoreBL.ClientBL.GetClientList();
            customers.DataBind();
        }
    }

    protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("CustDetail.aspx?edit=0");
    }

    protected void CommandBtn_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect("CustDetail.aspx?edit=" + e.CommandArgument);
    }

    protected void ourProducts_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect("OurProductsAdmin.aspx?edit=" + e.CommandArgument);
    }

    protected void aboutUS_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect(".aspx?edit=" + e.CommandArgument);
    }

    protected void homeFiddler_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect(".aspx?edit=" + e.CommandArgument);
    }

    protected void btRemove_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect("CustDetail.aspx?edit=0");
    }

}