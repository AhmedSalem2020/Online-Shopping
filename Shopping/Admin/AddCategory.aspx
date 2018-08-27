<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="ShoppingOnline.Admin.AddCategory" %>
<asp:content contentplaceholderid="head" runat="server">
    <script src="../JavaScript/dialog.js"></script>
    <link href="../Style/dialog.css" rel="stylesheet" />
    <link href="../Style/gridview.css" rel="stylesheet" />
<style type="text/css">
    .auto-style13 {
        width: 127px;
        height: 58px;
    }
    .auto-style14 {
        width: 221px;
        height: 58px;
    }
</style>
</asp:content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center"> Add Category</h1>
    <table style="width: 100%;">
        <tr>
            <td style="width: 127px">&nbsp;</td>
            <td style="width: 221px">&nbsp;</td>
            <td style="width: 221px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 127px; height: 42px;">Category Name:</td>
            <td style="width: 221px; height: 42px;">
                <asp:TextBox ID="txt_categoryName" runat="server" Width="311px" CssClass="txt"></asp:TextBox>
            </td>
            <td style="width: 221px; height: 42px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_categoryName" ErrorMessage="empty field" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td style="text-align:right; " class="auto-style14">
                <asp:Button ID="btn_add" runat="server" BackColor="#666666" Font-Size="15pt" ForeColor="#C8CC5B" Text="ADD" OnClick="btn_add_Click" Width="113px"  />
            &nbsp;&nbsp;
                <asp:Label ID="lbl_error" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td style="text-align:right; " class="auto-style14">
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align:center">
                <asp:GridView ID="gv_category" CssClass="gv" runat="server" Width="450px" AutoGenerateColumns="False" OnRowCancelingEdit="gv_category_RowCancelingEdit" OnRowDeleting="gv_category_RowDeleting" OnRowEditing="gv_category_RowEditing" DataKeyNames="Category_id" OnRowUpdating="gv_category_RowUpdating" BorderStyle="None" CellPadding="5" GridLines="None" HorizontalAlign="Center"  >
                    <Columns>
                        <asp:TemplateField HeaderText="Categories">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_edit" runat="server" Text='<%# Bind("Category_name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Category_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <EditItemTemplate>
                                <asp:LinkButton ID="lbtn_update" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="lbtn_cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtn_edit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="lbtn_delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle BorderStyle="None" Font-Size="12pt" ForeColor="#FFFF66" />
                </asp:GridView>
            </td>
        </tr>
    </table>
        <div class="dialog" id="dialog">
            <div>Category Added</div>
        <div > Add Product In this Category?</div>
        <asp:Button ID="btn_addProduct" class="ui-button ui-widget ui-corner-all" runat="server" Text="Add" CausesValidation="False" OnClick="btn_addProduct_Click" />
        <asp:Button ID="btn_Cancel" class="ui-button ui-widget ui-corner-all" runat="server" Text="Later" OnClick="btn_Cancel_Click" CausesValidation="False" />
   <br />
            <br />
            </div>
</asp:Content>
