﻿<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="CustDetail.aspx.cs" Inherits="CustAdmin_CustDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Basic">
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <table id="forms">
            <tr><td>Name</td><td><asp:TextBox ID="boxCustFullName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Type</td><td>
                <asp:RadioButton ID="boxRdF" Text="Pessoa Fisica" runat="server" GroupName="Type" Checked="true" />
                <asp:RadioButton ID="boxRdPJ" Text="Pessoa Juridica" runat="server" GroupName="Type" />
                </td></tr>
            <tr><td>Social Number</td><td><asp:TextBox ID="boxCustSocialNumber" runat="server"></asp:TextBox></td></tr>
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
            <tr><td>Email</td><td><asp:TextBox ID="boxEmail" runat="server"></asp:TextBox></td></tr>
            <tr><td>Whatsapp</td><td><asp:TextBox ID="boxWhatsapp" runat="server"></asp:TextBox></td></tr>
            <tr><td>Facebook</td><td><asp:TextBox ID="boxFace" runat="server"></asp:TextBox></td></tr>
            <tr><td>Instagram</td><td><asp:TextBox ID="boxInsta" runat="server"></asp:TextBox></td></tr>
            <tr><td>Status</td><td><asp:DropDownList ID="statusID" runat="server" ></asp:DropDownList></td></tr>
        </table>
        <hr />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click"/>
    </asp:Panel>
</asp:Content>

