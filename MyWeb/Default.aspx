<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWeb.Default" MasterPageFile="~/MS1.Master" %>
<%-- Subject: Home page (uses MS1.Master), currently a coloured test banner with two buttons | mDev --%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;height:300px;background-color:blueviolet">
        <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="Button" Width="101px" />
        
        <asp:Button ID="Button2" runat="server" Text="Button" />
        
    </div>
</asp:Content>