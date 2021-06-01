using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Tudonastorev2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mailfrom = ConfigurationManager.AppSettings["MailFrom"];
            string mailname = ConfigurationManager.AppSettings["DisplayName"];
            string smtpserver = ConfigurationManager.AppSettings["SmtpServer"];
            

            SmtpClient client = new SmtpClient(smtpserver);
            client.Credentials = new NetworkCredential("du.felipe.br@gmail.com", "Yeshu@33");
            MailAddress from = new MailAddress(mailfrom, mailname);
            MailAddress to = new MailAddress("du.felipe.br@gmail.com");
            using (MailMessage message = new MailMessage(from, to))
            { 
                message.Body = "Esse formulario foi preenchido via website.<br><br> ";
                // Include some non-ASCII characters in body and subject.
                //string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                message.Body += Environment.NewLine +"Nome:" + name.Value;
                message.Body += Environment.NewLine + "Email:" + email.Value;
                message.Body += Environment.NewLine + "Mensagem:" + mensagem.Value;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Envio formulario Website";
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                Label1.Text = "Email enviado com sucesso";
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Label1.Text = "Um erro ocorreu ao enviar o email, por favor procure o administrador:" + ex.Message;
                }
            }

        }
    }
}