<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home.ascx.cs" Inherits="ShoppingOnline.Annonymous.home" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<p>
    <br />
    <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="40pt" Text="More latest products"></asp:Label>
</p>
<p>
    &nbsp;</p>

<asp:DataList ID="datalist_home" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
    <ItemTemplate>
        <table class="auto-style1">
             <tr><td><img style="width:150px; height:170px;"  src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td></tr>
                    <tr><td><h4><%#Eval("Prod_name") %></h4></td></tr>
                    <tr><td><h5><%#Eval("Prod_price") %></h5></td></tr>
                    <tr><td><p><%#Eval("Prod_Desc") %></p></td></tr>
        </table>
    </ItemTemplate>
</asp:DataList>

