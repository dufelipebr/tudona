<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="email2.aspx.cs" Inherits="Tudonastorev2.email2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

<form class="form"  runat="server" method="post">
    <asp:Label ID="Label1" runat="server" ></asp:Label><br />
    EMAIL FROM <br /><input class="email" type="email" placeholder="Email From" name="email_from" id="email_from" runat="server"><br />
    EMAIL TO <br /><input class="email" type="email" placeholder="Email From" name="email_to" id="email_to" runat="server"><br />
    SMTP SERVER <br /><input class="email" type="text" placeholder="Smtp Server" name="smtp_server" id="smtp_server" runat="server"><br />
    PORT <br /><input class="email" type="text" placeholder="Port" name="port" id="port" runat="server"><br />
    AUTHENTICATON USER<br /><input class="email" type="text" placeholder="Autenthication User" name="authentication_user" id="authentication_user" runat="server"> <br />
    AUTHENTICATION PWD<br /><input class="email" type="text" placeholder="Autenthication PWD" name="authentication_pwd" id="authentication_pwd" runat="server"><br />
    SUBJECT<br /><input class="email" type="text" placeholder="Subject" name="subject" id="subject" runat="server"><br />
<div>
    Use SSL: Yes <input class="email" type="radio" placeholder="radio" name="radio" id="yes_radio" runat="server">
    No<input class="email" type="radio" placeholder="radio" name="radio" id="no_radio" runat="server" checked><br />
    MESSSAGE<br /><textarea class="message" name="mensagem" id="mensagem" cols="30" rows="10" placeholder="Message" runat="server" ></textarea><br />
    <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
</form>
</body>
</html>
