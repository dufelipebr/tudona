<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/masterPage.master" AutoEventWireup="true" CodeFile="OurProductsAdmin.aspx.cs" Inherits="CustAdmin_CustDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Basic">
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
         <table id="forms">
            <tr><td>Product</td><td><asp:TextBox ID="boxProduct" runat="server"></asp:TextBox></td></tr>
            <tr><td>Description</td><td><asp:TextBox ID="boxDescription" runat="server"></asp:TextBox></td></tr>
            <tr><td>Thumb</td><td><asp:FileUpload runat="server" ID="boxImage"></asp:FileUpload></td></tr>
           </table>
        <table>
        <asp:Button runat="server" ID="btAddProduct" Text="Add Product" OnClick="btnSave_Click" /> 
        <asp:DataList ID="ourProducstList" runat="server" CssClass="DataTable"   >
        <HeaderTemplate>
            <td>Order</td>
            <td>Product</td>
            <td>Description</td>
            <td>Image</td>
            <td>Actions</td>
        </HeaderTemplate>
        <ItemTemplate> 
                <td><%# DataBinder.Eval(Container.DataItem, "SortOrder") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "ProductName") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Description") %></td>
                <td><img src="../file_content/OurProducts/<%# DataBinder.Eval(Container.DataItem, "FullFileName") %>?width=200&height=200&mode=crop&center=0.1,0.1" /></td>
                <td>
                    <asp:Button runat="server" ID="btRemove" Text="Remove" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "OurProductID") %>' OnCommand="btRemove_Click"  /> 
                    <asp:Button runat="server" ID="btUp" Text="Up"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "OurProductID") %>' OnCommand="btUp_Click" /> 
                    <asp:Button runat="server" ID="btDown" Text="Down" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "OurProductID") %>'  OnCommand="btDown_Click"   /> 
                </td>
        </ItemTemplate>
    </asp:DataList>
            </table>
        <hr />
    </asp:Panel>
</asp:Content>

