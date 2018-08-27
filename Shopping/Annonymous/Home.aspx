<%@ Page Title="" Language="C#" MasterPageFile="~/Annonymous/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ShoppingOnline.Annonymous.Home" %>
<%@ Register Src="~/Annonymous/home.ascx" TagPrefix="uc2" TagName="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <p>
        <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="40pt" ForeColor="#FFCC66" Text="The Lastest Product"></asp:Label>
    </p>
    <p>
        <br />
    </p>
    <p>
        <asp:DataList ID="dlst_latest" runat="server"  RepeatColumns="1" RepeatDirection="Horizontal">
            <ItemTemplate>
                <table style="width: 100%">
                      <tr><td style="text-align:center"><img style="width:60%; height:230px;"  src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td></tr>
                    <tr><td style="text-align:center"><h1><%#Eval("Prod_name") %></h1></td></tr>
                    <tr><td style="text-align:center"><h3><%#Eval("Prod_price") %></h3></td></tr>
                    <tr><td style="text-align:center"><h4><p><%#Eval("Prod_Desc") %></p></h4></td></tr>
        </table>
                   
                
            </ItemTemplate>
        </asp:DataList>
    </p>
    <uc2:home runat="server" id="home" />
    <p>
    </p>
</asp:Content>
