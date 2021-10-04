using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class masterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Menu1.StaticDisplayLevels = 1;
        SiteMapPath1.RenderCurrentNodeAsLink = true;
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        
    }

}
