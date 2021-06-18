<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="CustAdmin.aspx.cs" Inherits="CustAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server" SiteMapProvider="Company1SiteMap" ForeColor="Yellow" ParentLevelsDisplayed="3" ToolTip="teste" PathSeparator=" &gt;">
        <PathSeparatorStyle ForeColor="Black" />
    </asp:SiteMapPath><br /><br />
    <asp:ImageButton name="btnAdd" runat="server" AlternateText="Add button" ImageUrl="~/images/AddButton.jpg" OnClick="Unnamed1_Click"></asp:ImageButton> Add
    <asp:ImageButton name="btnRem" runat="server" AlternateText="Remove button" ImageUrl="~/images/RemButton.jpg"></asp:ImageButton> Remove
    <hr />
    <br />    
    <asp:DataList ID="DataList1" runat="server"></asp:DataList>
</asp:Content>

