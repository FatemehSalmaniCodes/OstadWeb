<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Item_mng.aspx.cs" Inherits="MyWeb.Item_mng" %>
<%-- Subject: Simple admin form to add an item (name + price, no image) | Role: Standalone page, no master page and no CSS yet. | mDev --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        item name:<asp:TextBox ID="itmname_txt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; item price:
        <asp:TextBox ID="price_txt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" Width="97px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="msg_lbl" runat="server" Text="MSG"></asp:Label>
    
    </div>
    </form>
</body>
</html>
