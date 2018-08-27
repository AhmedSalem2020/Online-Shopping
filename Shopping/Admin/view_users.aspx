<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="view_users.aspx.cs" Inherits="Shopping.Admin.view_users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:ListView ID="lstView_data" runat="server">
            <ItemTemplate>
            <div style="display:inline-block;margin-left:100px; background-color:goldenrod; color:black; width:400px; height:200px; text-align:center;">
                <table>
                    
                    <tr><td> Customer Name :</td><td>  <%#Eval("Cust_fname") %>&nbsp;<%#Eval("Cust_lname") %></td> </tr>
                    
                    <tr><td> Customer Email :</td><td>  <%#Eval("Cust_mail") %></td></tr>
                    <tr><td>  Customer Address :</td><td>  <%#Eval("Cust_address") %></td></tr>
                    <tr><td> Customer Phone : </td><td> <%#Eval("Cust_phone") %></td></tr>
                    <tr><td> Customer Status :</td><td>  <%#Eval("State") %></td></tr>

                    
                </table>
            </div>
                </ItemTemplate>
        </asp:ListView>
    <br />
        <asp:LinkButton ID="lnk_viewBlocked" runat="server" OnClick="lnk_viewBlocked_Click" >View blocked users</asp:LinkButton>
    <br />
        <asp:LinkButton ID="lnk_viewPending" runat="server" OnClick="lnk_viewPending_Click">View Pending users</asp:LinkButton>

</asp:Content>
