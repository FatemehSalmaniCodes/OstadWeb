<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyWeb.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
</head>
<body dir="rtl">
    <div class="container">
        <form id="form1" runat="server">

            <div class="card">
                <div class="card-header"><h3>لیست محصولات</h3></div>
                <div class="card-body">

                    <div class="row">


                        <div class="col-md-3 ">
                            <div class="card">
                                <div class="card-header bg-secondary">
                                    <p>فیلتر</p>
                                </div>
                                  <div class="card-body">
                                      <asp:CheckBox ID="CheckBox1" Text="فیلتر1" CssClass="form-control mb-2" runat="server" />
                                      <asp:CheckBox ID="CheckBox2" Text="فیلتر1" CssClass="form-control mb-2" runat="server" />
                                      <asp:CheckBox ID="CheckBox3" Text="فیلتر1" CssClass="form-control mb-2" runat="server" />
                                      <asp:CheckBox ID="CheckBox4" Text="فیلتر1" CssClass="form-control mb-2" runat="server" />


                                      <asp:Button ID="Button1" CssClass="btn btn-dark w-100" runat="server" Text="اعمال فیلتر" />

                                      
                                  </div>
                            </div>
                        </div>
                           <div class="col-md-9">
                                   <div>
                <div class="row">

                    <asp:ListView ID="ListView1" runat="server">
                        <ItemTemplate>
                            <div class="col-md-3">
                                <div class="card">
                                    <div class="card-header text-center">
                                        <p><%#Eval("ItmName") %></p>

                                    </div>
                                    <div class="card-body text-center">
                                        <asp:Image ID="Image1" ImageUrl='<%#Eval("Iimg").ToString().Trim() %>' CssClass="w-100" runat="server" />
                                 
                                    
                                    <hr />
                                    ریال<p ><%#Eval("Iprice","{0:N0}").ToString() %></p>

                                    
                                    </div>
                                    <div class="card-footer">
                                        <a href="product_dtl.aspx?ID=<%#Eval("ItemID").ToString().Trim() %>" class="btn btn-primary w-100"  >مشاهده</a>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>

                </div>
            </div>
                           </div>
                    </div>

                </div>
            </div>
        
        </form>
    </div>
</body>
</html>
