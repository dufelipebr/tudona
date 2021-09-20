using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using TudoNaStoreEntity;


namespace Tudonastorev2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string hostName = (ConfigurationManager.AppSettings["HostName"] == null ? Request.Url.ToString() : ConfigurationManager.AppSettings["HostName"]);
                string clientId = ConfigurationManager.AppSettings["ClientID"];
                mainVITLabService.ClientServiceInterfaceClient client = new mainVITLabService.ClientServiceInterfaceClient();
                mainVITLabService.ClientEntity c = client.GetClient(clientId, hostName);

                if (c != null)
                {
                    //Response.Write(c.HashControl);
                    dPhone.InnerText = c.ClientPhoneNumber;
                    dZap.InnerText = c.WhatsApp;
                    dEndereco.InnerText = string.Format("{0} - {1} - {2}, {3}, {4}.", c.FullAdress, c.AddressNum, c.AddressCom, c.AddressNgh, c.AddressSta);
                    dEmail.InnerText = c.Email;
                }

                // Always close the client.
                client.Close();
            }
            catch (Exception ex)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mailFrom = ConfigurationManager.AppSettings["MailFrom"];
            string mailName = ConfigurationManager.AppSettings["DisplayName"];
            string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            string smtpPort = ConfigurationManager.AppSettings["SmtpPort"];
            string credentialMail = ConfigurationManager.AppSettings["CredentialMail"];
            string credentialPWD = ConfigurationManager.AppSettings["CredentialPWD"];
            string mailTo = ConfigurationManager.AppSettings["MailTo"];


            SmtpClient client = new SmtpClient(smtpServer);
            client.Credentials = new NetworkCredential(credentialMail, credentialPWD);
            MailAddress from = new MailAddress(mailFrom, mailName);
            MailAddress to = new MailAddress(mailTo);
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