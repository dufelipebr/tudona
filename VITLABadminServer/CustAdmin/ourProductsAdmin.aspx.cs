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

       // if (!IsPostBack & Request.QueryString["edit"] != null)
       // {
            List<OurProductEntity> lst = TudonaStoreBL.OurProductBL.GetOurProductList(Request.QueryString["edit"]);
            ourProducstList.DataSource = lst;
            ourProducstList.DataBind();
            //ourProducstList.DataSourceID = 
       // }

    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        //Response.Redirect("CustAdmin.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        

        OurProductEntity op = new OurProductEntity();
        op.Description = boxDescription.Text;
        op.ProductName = boxProduct.Text;
        if (boxImage.FileContent != null)
        {
            Guid newguid = Guid.NewGuid();
            op.Thumb = newguid.ToString();
            op.Extension = boxImage.FileName.Substring(boxImage.FileName.LastIndexOf('.'), boxImage.FileName.Length - boxImage.FileName.LastIndexOf('.'));
            op.FileLenght = boxImage.FileContent.Length;
            op.RelativePath = System.Web.Configuration.WebConfigurationManager.AppSettings["AttachmentFolder_OurProducts"];
        }
  

        lblMessage.Text = "";

        try
        {
            op.Validate();
            OurProductBL.SaveOurProduct(op, Request.QueryString["edit"]);
            boxImage.SaveAs(op.FullFileName);
            ImageProcessor.Imaging.CropLayer cl = new ImageProcessor.Imaging.CropLayer();
            cl.CropMode = ImageProcessor.Imaging.CropMode.Pixels;
            ImageProcessor.Imaging.
            //rs.Processor.Settings.
            //boxImage.SaveAs(string.Format("{0}/{1}{2}", attachment_rootfolder, op.Thumb, op.Extension));
            //op.Validate();
            //ClientBL.SaveClient(cl);
            lblMessage.Text = "Successfull saving";
        }
        catch (EntityException ex)
        {
            lblMessage.Text = ex.Message;
        }
        catch(Exception genericEX)
        {
            lblMessage.Text = genericEX.Message;
        }
    }
}