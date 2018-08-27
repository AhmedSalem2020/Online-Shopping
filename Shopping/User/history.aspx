<%@ Page Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="ShoppingOnline.User.history" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style13">
    <asp:GridView ID="gv_history_show" runat="server" AutoGenerateColumns="False"  Height="195px" style="margin-top: 48px" Width="585px" DataKeyNames="Order_id" OnRowDeleting="gv_history_show_RowDeleting" >
        <Columns>
            <asp:TemplateField HeaderText="State">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbl_state" runat="server" Text='<%# Bind("state") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField  DataField="Packing_Date" HeaderText="charge date" />
            <asp:BoundField DataField="Deliver_Date" HeaderText="deliver date" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lbl_delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
