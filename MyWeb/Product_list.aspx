<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MS1.Master" CodeBehind="Product_list.aspx.cs" Inherits="MyWeb.Product_list" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" Text="send session" OnClick="Button2_Click" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="send" />
    <asp:TextBox ID="id_txt" runat="server"></asp:TextBox>

</asp:Content>