<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="pendingUsers.aspx.cs" Inherits="Shopping.Admin.pendingUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:ListView ID="lstView_data" runat="server">
            <ItemTemplate>
            <div  style="margin-top:40px;color:black; text-align:center; background-color:goldenrod; width:400px;">
                <table id="tbl_data">
                    <tr><td><img  style="width:150px; height:150px;" src='<%#Eval("Cust_ssnimg").ToString().Replace("~","") %>' /></td>
                        <td><%#Eval("Cust_fname") %>&nbsp;<%#Eval("Cust_lname") %>
                            <br />
                            <%#Eval("Cust_phone") %>
                            <br />

                            <%#Eval("Cust_address") %>
                            <br />

                            <%#Eval("Cust_mail") %>
                        </td>
                    </tr>
                    <tr><td><asp:Button ID="btn_approve" runat="server" Text="Approve" onClick="btn_approve_Click" CommandArgument='<%#Eval("Cust_id") %>' /></td>
                    <td><asp:Button ID="btn_block" runat="server" Text="Block" onClick="btn_block_Click" CommandArgument='<%#Eval("Cust_id") %>' /></td>

                    </tr> 
                 
                    
                </table>
            </div>
                </ItemTemplate>
        </asp:ListView>
    <br />
        <asp:Button ID="btn_back" runat="server" Text="Back" OnClick="btn_back_Click" />
    
</asp:Content>
