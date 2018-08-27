<%@ Page Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="PromotionPage.aspx.cs" Inherits="Shopping.User.PromotionPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:ListView ID="lstView_data" runat="server">
            <ItemTemplate>
            <div style="display:inline-block; margin-left:100px">
                <table>
                    <tr><td ><img style="width:100px;height:100px" src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td>
                       
                    </tr>
                   <tr><td><h4><%#Eval("prod_name") %></h4></td></tr>
                    
                    <tr><td><h4><%#Eval("promotion") %></h4></td></tr>

                    
                </table>
            </div>
                </ItemTemplate>
        </asp:ListView>
   
</asp:Content>
