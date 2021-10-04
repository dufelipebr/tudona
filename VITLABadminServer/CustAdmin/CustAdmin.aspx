<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="CustAdmin.aspx.cs" Inherits="CustAdmin" %>

<script runat="server">

    protected void btEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btRemove_Click(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../css/system.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <asp:DataList ID="customers" runat="server" CssClass="DataTable"   >
        <HeaderTemplate>
            <td>ID</td>
            <td>Full Name</td>
            <td>Type</td>
            <td>Social Number</td>
            <td>Host</td>
            <td>Contact Name</td>
            <td>Phone Number</td>
            <td>Action</td>
        
        </HeaderTemplate>
        <ItemTemplate> 
                <td><%# DataBinder.Eval(Container.DataItem, "HashControl") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "CustomerFullName") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "TypeCli") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "SocialNumber") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientHost") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientContactName") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientPhoneNumber") %></td>
                <td>
                    <asp:Button runat="server" ID="btEdit" Text="Edit" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "HashControl") %>' OnCommand="CommandBtn_Click"    /> 
                    <asp:Button runat="server" ID="btOurProd" Text="Our Products" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "HashControl") %>' OnCommand="ourProducts_Click"    /> 
                    <asp:Button runat="server" ID="btAboutUs" Text="About Us" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "HashControl") %>' OnCommand="aboutUS_Click"    /> 
                    <asp:Button runat="server" ID="btFiddler" Text="Home Fiddler" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "HashControl") %>' OnCommand="homeFiddler_Click"    /> 
                </td>
          
        </ItemTemplate>
    </asp:DataList>
    </table>
</asp:Content>

