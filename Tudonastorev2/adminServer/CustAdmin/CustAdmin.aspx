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
    <asp:SiteMapPath ID="SiteMapPath1" runat="server" SiteMapProvider="Company1SiteMap" ForeColor="Yellow" ParentLevelsDisplayed="3" ToolTip="teste" PathSeparator=" &gt;">
        <PathSeparatorStyle ForeColor="Black" />
    </asp:SiteMapPath><br /><br />
    <asp:ImageButton name="btnAdd" runat="server" AlternateText="Add button" ImageUrl="~/images/AddButton.jpg" OnClick="Unnamed1_Click"></asp:ImageButton> Add
    <asp:ImageButton name="btnRem" runat="server" AlternateText="Remove button" ImageUrl="~/images/RemButton.jpg"></asp:ImageButton> Remove
    <hr />
    <br />    
    
    <input type="button" style="button" value="teste button" />
    <asp:DataList ID="customers" runat="server" CssClass="DataTable"   >
        <HeaderTemplate>
        
            <td>Full Name</td>
            <td>Type</td>
            <td>Social Number</td>
            <td>Host</td>
            <td>Contact Name</td>
            <td>Phone Number</td>
            <td>Action</td>
        
        </HeaderTemplate>
        <ItemTemplate> 
                <td><%# DataBinder.Eval(Container.DataItem, "CustomerFullName") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "TypeCli") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "SocialNumber") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientHost") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientContactName") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ClientPhoneNumber") %></td>
                <td>
                    <asp:Button runat="server" ID="btEdit" Text="Edit" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ClientID") %>' OnCommand="CommandBtn_Click"    /> 
                    <asp:Button runat="server" ID="btRemove" Text="Remove" />

                </td>
          
        </ItemTemplate>
    </asp:DataList>
    </table>
</asp:Content>

