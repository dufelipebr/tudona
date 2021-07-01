<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="CustDetail.aspx.cs" Inherits="CustAdmin_CustDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:SiteMapPath ID="SiteMapPath1" runat="server" SiteMapProvider="Company1SiteMap" ForeColor="Yellow" ParentLevelsDisplayed="3" ToolTip="teste" PathSeparator=" &gt;">
        <PathSeparatorStyle ForeColor="Black" />
    </asp:SiteMapPath><br /><br />
    <hr />
    Create Client
    <br />
    <asp:Panel ID="Panel1" runat="server" GroupingText="Basic">
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <table>
            <tr><td>Host</td><td><asp:TextBox ID="host" runat="server"></asp:TextBox></td></tr>
            <tr><td>Contact Name</td><td><asp:TextBox ID="contactName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Contact Number</td><td><asp:TextBox ID="contactNumber" runat="server"></asp:TextBox></td></tr>
            <tr><td>Phone Number</td><td><asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox></td></tr>
            <tr><td>Region</td><td><asp:DropDownList ID="regionID" runat="server" ></asp:DropDownList></td></tr>
            <tr><td>Street Address</td><td><asp:TextBox ID="fullAddress" runat="server"></asp:TextBox></td></tr>
            <tr><td>Address Number</td><td><asp:TextBox ID="addressNum" runat="server"></asp:TextBox></td></tr>
            <tr><td>Comp Address</td><td><asp:TextBox ID="addresCom" runat="server"></asp:TextBox></td></tr>
            <tr><td>Neighborhood</td><td><asp:TextBox ID="addressNgh" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:TextBox ID="addressState" runat="server"></asp:TextBox></td></tr>
            <tr><td>Zip Code</td><td><asp:TextBox ID="zipCode" runat="server"></asp:TextBox></td></tr>
            <tr><td>Geolocation</td><td><asp:TextBox ID="geoLocation" runat="server"></asp:TextBox></td></tr>
            <tr><td>Status</td><td><asp:DropDownList ID="statusID" runat="server" ></asp:DropDownList></td></tr>
        </table>
        <hr />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnBack" runat="server" Text="Back" />
    </asp:Panel>
</asp:Content>

