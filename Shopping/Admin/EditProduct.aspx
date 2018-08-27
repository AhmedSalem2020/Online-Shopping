<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Shopping.Admin.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/dialog.css" rel="stylesheet" />
    <script src="../JavaScript/dialog.js"></script>
    <style type="text/css">
        .auto-style13 {
            border-radius: 10px;
            font-family: "Monotype Corsiva", Verdana, Geneva, Tahoma, sans-serif;
            border: 2px solid #7d6754;
            padding: 3px;
        }
   
        .auto-style14 {
            width: 100%;
        }
        .auto-style15 {
            width: 95px;
        }
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">
        Edit Product
    </h1>
    <table style="width: 100%">
    
    <tr>
        <td style="width: 88px; height: 58px">&nbsp;Name:</td>
        <td style="height: 58px">
            <asp:TextBox ID="txt_prodName" runat="server"  CssClass="auto-style13" Width="219px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqv_prodName" runat="server" ControlToValidate="txt_prodName" ErrorMessage="Please Enter product Name" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr>
        <td style="width: 88px; height: 59px">Category:</td>
        <td style="height: 59px">
            <asp:DropDownList ID="ddl_category" runat="server"  CssClass="ddl">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rqv_category" runat="server" ControlToValidate="ddl_category" ErrorMessage="Please choose category" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 54px">Price:</td>
        <td style="height: 54px">
            <asp:TextBox ID="txt_prodPrice" runat="server"  CssClass="auto-style13" Width="218px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqv_prodPrice" runat="server" ControlToValidate="txt_prodPrice" ErrorMessage="Please Enter product Price" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 54px">Quantity:</td>
        <td style="height: 54px">
            <asp:TextBox ID="txt_prodQuantity" runat="server"  CssClass="auto-style13" Width="216px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqv_prodQuantity" runat="server" ControlToValidate="txt_prodQuantity" ErrorMessage="Please Enter product Quantity" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_prodQuantity" ErrorMessage="Quantity must be numbers" ForeColor="Red" ValidationExpression="^[0-9]+$">invalid Quantity</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 63px">&nbsp;Description:</td>
        <td style="height: 63px">
            <asp:TextBox ID="txt_prodDesc" runat="server" TextMode="MultiLine" Width="500px" Height="200px" CssClass="txt" EnableTheming="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 63px">Promotion:</td>
        <td style="height: 63px">
            <asp:TextBox ID="txt_prodProm" runat="server" TextMode="MultiLine" Width="500px" Height="54px" CssClass="txt" EnableTheming="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 53px">image:</td>
        <td style="height: 53px">
            <table class="auto-style14">
                <tr>
                    <td class="auto-style15">
                        <asp:Image ID="img_prod" runat="server" Height="84px" Width="94px" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="fu_prodimag" runat="server" Width="244px"/>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="width: 88px; height: 53px">&nbsp;</td>
        <td style="height: 53px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Editprod" runat="server" class="ui-button ui-widget ui-corner-all" cssClass="txt" Text="Edit" Width="85px" OnClick="btn_Editprod_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_doneOrError" runat="server"></asp:Label>
        </td>
    </tr>
</table>
 <%--   <div id="dialog" class="dialog" >
        <div>Product Edited...</div>
        <asp:Button ID="btn_addpromotion" class="ui-button ui-widget ui-corner-all" runat="server" Text="Add Promotion" OnClick="btn_addpromotion_Click" CausesValidation="False" />
        <asp:Button ID="btn_home" class="ui-button ui-widget ui-corner-all" runat="server" Text="Home" OnClick="btn_home" CausesValidation="False" />
    </div>--%>

</asp:Content>
