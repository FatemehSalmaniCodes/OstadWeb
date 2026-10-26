<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload_form.aspx.cs" Inherits="MyWeb.Upload_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        item name:
        <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; price:<asp:TextBox ID="price_txt" runat="server"></asp:TextBox>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="save" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="msg_lbl" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
