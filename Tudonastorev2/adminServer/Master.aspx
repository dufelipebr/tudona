<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="Master.aspx.cs" Inherits="Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" StaticDisplayLevels="2" >
        <DataBindings>
            <asp:MenuItemBinding DataMember="SiteMapNode" ImageUrlField="Description" NavigateUrlField="Url" TextField="Title" />
        </DataBindings>
    </asp:Menu>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" SiteMapProvider="Company1SiteMap" />

</asp:Content>

