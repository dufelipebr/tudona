<%@ Page Language="C#" %> 
<%@ Import Namespace="System" %> 
<!--Inclui o namespace para envio de emails --> 
<%@ Import Namespace="System.Web.Mail" %> 
<html> 
<script runat="server"> 
    public void Button1_Click(Object Sender, EventArgs e)
    {

        //Instancia o Objeto Email como MailMessage 
        MailMessage Email = new MailMessage();

        //Atribui ao método From o valor do Remetente 
        Email.From = email_from.Value;

        //Atribui ao método To o valor do Destinatário 
        Email.To = email_to.Value;


        //Atribui ao método Bcc o valor do com Cópia oculta 
        //Email.Bcc = "email3@dominio"; 

        //Atribui ao método Subject o assunto da mensagem 
        Email.Subject = subject.Value;

        //Define o formato da mensagem que pode ser Texto ou Html 
        Email.BodyFormat = MailFormat.Text;

        //Atribui ao método Body a texto da mensagem 
        Email.Body = mensagem.Value;
        
        
        //Define qual o host a ser usado para envio de mensagens. 
        SmtpMail.SmtpServer = smtp_server.Value;
        

        //Envia a mensagem baseado nos dados do objeto Email 
        try {
            SmtpMail.Send(Email);
            Label1.Text = "sucesso";
        } catch (Exception ex) {
            Label1.Text = ex.Message;
        }

    }
</script> 
    <body>

<form class="form"  runat="server" method="post">
    <asp:Label ID="Label1" runat="server" ></asp:Label><br />
    EMAIL FROM <br /><input class="email" type="email" placeholder="Email From" name="email" id="email_from" runat="server"><br />
    EMAIL TO <br /><input class="email" type="email" placeholder="Email From" name="email" id="email_to" runat="server"><br />
    SMTP SERVER <br /><input class="email" type="text" placeholder="Smtp Server" name="email" id="smtp_server" runat="server"><br />
    AUTHENTICATON USER<br /><input class="email" type="text" placeholder="Autenthication User" name="email" id="authentication_user" runat="server"> <br />
    AUTHENTICATION PWD<br /><input class="email" type="text" placeholder="Autenthication PWD" name="email" id="authentication_pwd" runat="server"><br />
    SUBJECT<br /><input class="email" type="text" placeholder="Subject" name="email" id="subject" runat="server"><br />
<div>
    Use SSL: Yes <input class="email" type="radio" placeholder="Subject" name="email" id="yes_radio" runat="server">
    No<input class="email" type="email" placeholder="Email To" name="email" id="emailto" runat="server"><br />
    MESSSAGE<br /><textarea class="message" name="mensagem" id="mensagem" cols="30" rows="10" placeholder="Message" runat="server" ></textarea><br />
    <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
</form>
</body>
</html>
