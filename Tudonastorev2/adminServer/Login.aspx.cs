using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (Login1.Password == "Shemit@h99" && Login1.UserName == "masterSh")
            e.Authenticated = true;
        else
            e.Authenticated = false;
    }
}