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
    public partial class TesteEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mailFrom = ConfigurationManager.AppSettings["MailFrom"];
            string mailName = ConfigurationManager.AppSettings["DisplayName"];
            string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            string smtpPort = ConfigurationManager.AppSettings["SmtpPort"];
            string credentialMail = ConfigurationManager.AppSettings["CredentialMail"];
            string credentialPWD = ConfigurationManager.AppSettings["CredentialPWD"];
            string mailTo = ConfigurationManager.AppSettings["MailTo"];

            

            SmtpClient client = new SmtpClient();
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.EnableSsl = true;
            //client.Credentials = new NetworkCredential(credentialMail, credentialPWD);
            //client.Port = Int32.Parse(smtpPort);
            MailAddress from = new MailAddress(mailFrom);
            MailAddress to = new MailAddress(mailTo);
            using (MailMessage message = new MailMessage(from, to))
            {
                message.Body = "Esse formulario foi preenchido via website.<br><br> ";
                // Include some non-ASCII characters in body and subject.
                //string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                message.Body += Environment.NewLine + "Nome:teste";
                message.Body += Environment.NewLine + "Email:teste@mail.com";
                message.Body += Environment.NewLine + "Mensagem:testinggggggg ggg gggg";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Envio formulario Website";
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Trace.Write(client.Host);
                    Trace.Write("mailname:" + mailName);
                    Trace.Write("client.Host:" + client.Host);
                    Trace.Write("client.Port:" + client.Port);
                    Trace.Write("client.Credentials:" + client.Credentials);
                    Trace.Write("credentialMail:" + credentialMail);
                    Trace.Write("credentialPWD:" + credentialPWD);
                    Trace.Write("mailTo:" + mailTo);
                    throw ex;
                }

                Response.Write("enviado com sucesso");
            }
        }
    }
}