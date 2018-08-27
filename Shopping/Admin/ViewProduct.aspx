<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Shopping.Admin.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 100%;
        }
        .title{
            color:darkgoldenrod;
            font-size:20px;
            padding-bottom:15px;
            text-shadow: 2px 2px 4px black, 0 0 1em brown, 0 0 0.2em brown;
        }
       #lview td{
          padding-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Products</h1>
    <table class="auto-style13">
        <tr>
            <td style="text-align:right">Search:<asp:TextBox ID="txt_search" runat="server" AutoPostBack="True" OnTextChanged="txt_search_TextChanged" Width="184px"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td>
                <asp:ListView ID="lv_data" runat="server">
                    <ItemTemplate>
                        <div class="list" style="display:block; margin-left:10px">
                            <table id="lview">
                                <tr >
                                    <td><img style="width:90px; height:120px;" src='<%#Eval("Prod_img").ToString().Replace("~","")%>'/></td>
                                    <td><table>
                                        <tr >
                                            <td class="title" colspan="2">
                                                <%#Eval("Prod_name") %>
                                            </td>
                                           
                                        </tr>
                                          <tr>
                                            <td colspan="2">
                                                <%# CutText(DataBinder.Eval(Container.DataItem,"Prod_Desc"),200)%>....
                                            </td>
                                        </tr>
                                         <tr >
                                    <td >
                                        <asp:LinkButton ID="lbtn_Edit" runat="server" commandArgument='<%#Eval("Prod_id") %>' CommandName="lbtnEdit" Text="Edit" OnClick="Lbtn_Edit_Click" />
                                        </td>
                                        <td >
                                        <asp:LinkButton ID="lbtn_Delete" runat="server" commandArgument='<%#Eval("Prod_id") %>' CommandName="lbtnDelete" Text="Delete" OnClick="Lbtn_Delete_Click" />
                                        </td>
                                </tr>
                                        </table>
                                        
                                        </td>
                                    <td>
                                        <p>
                                        </p>
                                    </td>
                                </tr>
                               
                              
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </td>
        </tr>
    </table>

</asp:Content>
