<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="blockedUsers.aspx.cs" Inherits="Shopping.Admin.blockedUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ListView ID="lstView_data" runat="server">
            <ItemTemplate>
            <div  style="margin-top:40px; text-align:center;   color:black; background-color:goldenrod; width:400px;">
                <table id="tbl_data" style="visibility:visible;">
                    <%--<tr><td > Customer Id :  <%#Eval("Cust_id")%></td></tr>--%>
                    <tr><td>Customer Name :  <%#Eval("Cust_fname") %>&nbsp;<%#Eval("Cust_lname") %></td> </tr>
                    <tr><td><asp:Button ID="btn_unblock" runat="server" Text="Unblock" OnClick="btn_unblock_Click" CommandArgument='<%#Eval("Cust_id") %>' /></td>
                   <td><asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" CommandArgument='<%#Eval("Cust_id") %>' /></td>

                    </tr> 
                 
                    
                </table>
            </div>
                </ItemTemplate>
        </asp:ListView>
      
        <br />
        <asp:Button ID="btn_back" runat="server" Text="Back" OnClick="btn_back_Click" />

</asp:Content>
