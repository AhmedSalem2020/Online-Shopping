<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="ShoppingOnline.User.ViewProducts" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/dialog.css" rel="stylesheet" />
<%--<script>
    window.addEventListener('load', function () {
        dia = document.getElementById('dialog');
    });
    function showDialog() {
        dia.style.display = "block";
    }
</script>  --%> 
    <script src="../JavaScript/jquery.js"></script>
    <script src="../JavaScript/dialog.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <style type="text/css">
    .Add {
        border: 1px solid #563d7c;
        border-radius: 5px;
        color: white;
        width:20px;
        height:20px;
    }
    .title{
       text-align:center;
       font:20px bold;
       color:goldenrod;
    }
</style>
    <div >
        <table style="width: 100%">
            <tr>
                <td style="width: 251px; height: 29px;">
    
                    Category :</td>
                <td style="width: 176px; height: 29px;">
    
                </td>
                <td style="height: 29px">
    
                    Price:</td>
            </tr>
            <tr>
                <td style="width: 251px; height: 27px;">
    
                    &nbsp;&nbsp;&nbsp; <asp:DropDownList ID="lst_cate" runat="server" AutoPostBack="True" ForeColor="#0066CC" OnSelectedIndexChanged="lst_cate_SelectedIndexChanged" AppendDataBoundItems="True">
                        <asp:ListItem>Select Category</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td style="width: 176px; height: 27px;">
    
                </td>
                <td style="height: 27px">
    
                    &nbsp;&nbsp;&nbsp; <asp:DropDownList ID="lst_price" runat="server" AutoPostBack="True" ForeColor="#0066CC" OnSelectedIndexChanged="lst_price_SelectedIndexChanged" AppendDataBoundItems="True">
                        <asp:ListItem>Select Price</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 26px;" colspan="2">
    
                    BookName:</td>
                <td style="height: 26px">
    
                    </td>
            </tr>
            <tr>
                <td style="height: 27px;" colspan="2">
    
                    &nbsp;&nbsp;&nbsp; <asp:DropDownList ID="lst_names" runat="server" AutoPostBack="True" ForeColor="#0066CC" OnSelectedIndexChanged="lst_names_SelectedIndexChanged" AppendDataBoundItems="True">
                        <asp:ListItem>Select Book</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td style="height: 27px">
    
                    </td>
            </tr>
            <tr>
                <td style="height: 29px;" colspan="2">
    
                    Search:</td>
                <td style="height: 29px">
    
                    </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 35px" >
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txt_search" runat="server" AutoPostBack="True" OnTextChanged="txt_search_TextChanged" Width="184px"></asp:TextBox>
                    <asp:Label ID="lbl_res" runat="server"></asp:Label></td>
                
            </tr>
            <tr>
                <td style="width: 251px">&nbsp;</td>
                <td style="width: 176px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr><td colspan="3">
                <asp:Label ID="Lbl_cart" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label></td>

            </tr>
            <tr>
                <td colspan="3">

        <asp:ListView ID="lstView_data" runat="server">
            <ItemTemplate>
            <div class="list" style="display:inline-block; margin-left:100px">
                <table style="width:200px;">
                    <tr style="text-align:center"><td><img style="width:140px; height:170px;" src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td>
                        <td><td><p><%#Eval("promotion") %></p></td></td>
                    </tr>
                    <tr class="title"><td><%#Eval("Prod_name") %></td></tr>
                    <tr><td><p><%# CutText(DataBinder.Eval(Container.DataItem,"Prod_Desc"), 100)%>... 
                        <%--<a href="javascript:showDialog();" id='<%#Eval("Prod_id") %>' >Read More</a>--%>
                        <asp:LinkButton ID="lbtn_read" runat="server" CommandArgument='<%#Eval("Prod_id") %>' OnClick="lbtn_read_Click">ReadMore</asp:LinkButton>
                        </p></td></tr>
                    <tr style="text-align:center"><td><asp:Button CssClass="Add ui-icon ui-icon-cart" ID="btn_Add" runat="server" commandArgument='<%#Eval("Prod_id") %>' CommandName="buttonAdd" Text="Add" OnClick="btn_Add_Click" />  <%#Eval("Prod_price") %> L.E</td></tr>
                   <tr><td></td></tr>
                </table>
            </div>
                </ItemTemplate>
        </asp:ListView> 
                    
                    </td>
                </tr>
            </table>

        </div>
    <div id="dialog" class="dialog">
        <asp:ListView ID="Lv_Read" runat="server">
            <ItemTemplate>
                <table style="text-align:center">
                    <tr style="text-align:center"><td><img style="width:140px; height:170px;" src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td>
                       
                    </tr>
                    <tr>
                        <td><%#Eval("promotion") %></td>
                    </tr>
                    <tr class="title"><td><%#Eval("Prod_name") %></td></tr>
                    <tr><td><%#Eval("Prod_Desc")%></td></tr>
                    <tr style="text-align:center"><td>  <%#Eval("Prod_price") %> L.E</td></tr>
                   <tr><td>
        <asp:Button ID="btn_Cancel" class="ui-button ui-widget ui-corner-all" runat="server" Text="Cancel" OnClick="btn_Cancel_Click" CausesValidation="False" />

                       </td></tr>
                </table>
                </ItemTemplate>
        </asp:ListView> 
    </div>

</asp:Content>
