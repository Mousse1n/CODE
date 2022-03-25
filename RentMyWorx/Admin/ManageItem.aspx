<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms .Master" AutoEventWireup="true" CodeBehind="ManageItem.aspx.cs" Inherits="RentMyWorx.Admin.ManageItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style ="margin-top:100px;">
        <div class="dataentry">
            <asp:Label runat ="server" Text="Name" AssociatedControlID="tbName" />
            <asp:TextBox runat="server" ID="tbName" />
        </div>
    </div>
</asp:Content>
