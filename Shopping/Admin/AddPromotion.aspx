<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddPromotion.aspx.cs" Inherits="Shopping.Admin.AddPromotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            width: 128px;
        }
    .auto-style2 {
            width: 104px;
            color:white;
        }
        .hide{
            display:none;
        }
        .auto-style15 {
            width: 440px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Promotions</h1>
    <table class="auto-style13">
        <tr>
            <td class="auto-style14">Product:</td>
            <td>
                <asp:DropDownList ID="ddl_product" runat="server" AutoPostBack="True" Height="28px" Width="186px" AppendDataBoundItems="true" OnSelectedIndexChanged="ddl_product_SelectedIndexChanged">
                    <asp:ListItem Selected="True">--Select Product--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Promotion:</td>
            <td>
                <asp:TextBox ID="txt_promotion" runat="server" Height="60px" TextMode="MultiLine" Width="314px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_promotion" ErrorMessage="Enter Promotion" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>
                <asp:Button ID="btn_add" runat="server" Text="Add" Width="81px" OnClick="btn_add_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <div>
                    

<%--        <table class="auto-style1" >
            <tr style="background-image:url('../images/templatemo_h1_bg.jpg');text-align:center;color:#e6e154">
                <td colspan="2">Product Promotion</td>
            </tr>
            <tr >
                <td class="auto-style2" >Promotion:</td>
                <td  class="auto-style15">
                    <asp:Label ID="lbl_promotion" runat="server"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Height="43px" TextMode="MultiLine" Width="436px" CssClass="hide"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" >&nbsp;</td>
                <td  class="auto-style15">&nbsp;</td>
            </tr>
            <tr >
                <td class="auto-style16" >
                    <asp:LinkButton ID="lbtn_edit" runat="server" CausesValidation="False" OnClick="lbtn_edit_Click" Text="Edit"></asp:LinkButton>
                </td>
                <td  class="auto-style17">
                    <asp:LinkButton ID="lbtn_Delete" runat="server" CausesValidation="False" Text="Delete"></asp:LinkButton>
                </td>
            </tr>
        </table>--%>


<asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
        <table >
            <tr style="background-image:url('../images/templatemo_h1_bg.jpg');text-align:center;color:#e6e154">
                <td colspan="2">Product Promotion</td>
            </tr>
            <tr>
                <td class="auto-style2">Promotion:</td>
                <td class="auto-style15">
                    <asp:Label ID="lbl_promotion" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbtn_edit" runat="server" OnClick="lbtn_edit_Click" CausesValidation="False">Edit</asp:LinkButton>
                </td>
                <td class="auto-style15">
                    <asp:LinkButton ID="lbtn_Delete" runat="server" CausesValidation="False" OnClick="lbtn_Delete_Click">Delete</asp:LinkButton>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table class="auto-style1">
            <tr style="background-image: url('../images/templatemo_h1_bg.jpg'); text-align: center;color:#e6e154">
                <td colspan="2">Product Promotion</td>
            </tr>
            <tr>
                <td class="auto-style2">Promotion:</td>
                <td>
                    <asp:TextBox ID="txt_prom" runat="server" Height="43px" TextMode="MultiLine" Width="436px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbtn_update" runat="server" CausesValidation="False" OnClick="lbtn_update_Click">Update</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="lbtn_cancel" runat="server" CausesValidation="False" OnClick="lbtn_cancel_Click">Cancel</asp:LinkButton>
                </td>
            </tr>
        </table>
    </asp:View>
</asp:MultiView>

                    </div>

            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
