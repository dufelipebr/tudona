<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="CustDetail.aspx.cs" Inherits="CustAdmin_CustDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:SiteMapPath ID="SiteMapPath1" runat="server" SiteMapProvider="Company1SiteMap" ForeColor="Yellow" ParentLevelsDisplayed="3" ToolTip="teste" PathSeparator=" &gt;">
        <PathSeparatorStyle ForeColor="Black" />
    </asp:SiteMapPath><br /><br />
    <hr />
    Create Client
    <br /><br />
    <asp:Panel ID="Panel1" runat="server" GroupingText="Basic">
        <table>
            <tr><td>ClientID</td><td><asp:TextBox ID="clientID" runat="server"></asp:TextBox></td></tr>
            <tr><td>Host</td><td><asp:TextBox ID="host" runat="server"></asp:TextBox></td></tr>
            <tr><td>Contact Name</td><td><asp:TextBox ID="contactName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Phone Number</td><td><asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox></td></tr>
            <tr><td>Region</td><td><asp:DropDownList ID="regionID" runat="server"></asp:DropDownList></td></tr>
            <tr><td>Full Address</td><td><asp:TextBox ID="fullAddress" runat="server"></asp:TextBox></td></tr>
            <tr><td>Zip Code</td><td><asp:TextBox ID="zipCode" runat="server"></asp:TextBox></td></tr>
            <tr><td>Geolocation</td><td><asp:TextBox ID="geoLocation" runat="server"></asp:TextBox></td></tr>
            <tr><td>Status</td><td><asp:DropDownList ID="statusID" runat="server"></asp:DropDownList></td></tr>
        </table>
        <hr />
        <asp:Button ID="btnSave" runat="server" Text="Save" />
        <asp:Button ID="btnBack" runat="server" Text="Back" />
    </asp:Panel>
</asp:Content>

