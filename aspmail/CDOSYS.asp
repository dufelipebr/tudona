<%
Response.ContentType = "text/html"
Response.AddHeader "Content-Type", "text/html;charset=UTF-8"
Response.CodePage = 65001
Response.CharSet = "UTF-8"
   Dim emaildestino, assunto, texto
   emaildestino = Request.Form("txtdest")
   assunto = Request.Form("txtass")
   mensagem = Request.Form("txtmsg")
   If  emaildestino <> "" Then
       Set objCDOSYSMail = Server.CreateObject("CDO.Message")
       Set objCDOSYSCon = Server.CreateObject ("CDO.Configuration")
       objCDOSYSCon.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "localhost"
       objCDOSYSCon.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
       objCDOSYSCon.Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
       objCDOSYSCon.Fields("http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout") = 30
       objCDOSYSCon.Fields.update
       Set objCDOSYSMail.Configuration = objCDOSYSCon
       objCDOSYSMail.BodyPart.Charset = "utf-8"
       objCDOSYSMail.From = "consultor@carlosmartins.com.br"
       objCDOSYSMail.To = emaildestino
       objCDOSYSMail.Subject = assunto
       objCDOSYSMail.TextBody = mensagem
       objCDOSYSMail.Send
       Set objCDOSYSMail = nothing
       Set objCDOSYSCon = nothing
       response.write "Mensagem enviada com sucesso!"
%>
<% Else %>
   <html>
   <head>
<meta http-equiv=""Content-Type"" content=""text/html;charset=utf-8"">
       <title>CDOSYS</title>
       <style type="text/css">
           #Text1
           {
               width: 287px;
           }
           #Text2
           {
               width: 287px;
           }
           #Text3
           {
               width: 287px;
           }
           #Text4
           {
               width: 287px;
           }
           #btEnviar
           {
               width: 100px;
           }
           #btLimpar
           {
               width: 100px;
           }
           #TextArea1
           {
               width: 287px;
           }
       </style>
   </head>
   <body>
   <form id="form" name="form" method="POST" action="CDOSYS.asp">
       <h2 align="center" style="text-decoration: underline"> Formulário de Contato (CDOSYS)</h2>
       <table width="450px" align="center" border="1" cellpadding="5" cellspacing="5">
           <tr>
               <td align="right">
                   Email Destinatário:</td>
               <td>
                   <input id="txtdest" name="txtdest" type="text" /></td>
           </tr>
           <tr>
               <td align="right">
                   Assunto:</td>
               <td>
                   <input id="txtass" name="txtass" type="text" /></td>
           </tr>
           <tr>
               <td align="right">
                   Mensagem:</td>
               <td>
                   <textarea id="txtmsg" name="txtmsg" rows="2"></textarea></td>
           </tr>
           <tr>
               <td align="center" colspan="2">
                   <table style="width:100%;" cellspacing="10">
                       <tr>
                           <td align="right">
                               <input id="btEnviar" type="submit" value="Enviar" /></td>
                           <td>
                               <input id="btLimpar" type="reset" value="Limpar" align="left" /></td>
                       </tr>
                   </table>
               </td>
           </tr>
       </table>
       </form>
   </body>
</html>
<% End If %>