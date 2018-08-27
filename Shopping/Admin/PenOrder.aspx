<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PenOrder.aspx.cs" Inherits="Shopping.Admin.PenOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 601px;
        }
        .auto-style14 {
            font-size: xx-large;
            color: #FFCC00;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#FFCC00" Text="Pending"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gv_pendingorder" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="order_id" OnRowCommand="gv_pendingorder_RowCommand" >
            <Columns>
                <asp:BoundField DataField="Order_id" HeaderText="Order Number" />
                <asp:BoundField DataField="Cust_username" HeaderText="Username" />
                <asp:BoundField DataField="packing_date" HeaderText="Order Date" />
                <asp:ButtonField CommandName="approve" Text="Approve" />
                <asp:ButtonField CommandName="rejectOrder" Text="Reject" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Font-Size="XX-Large" ForeColor="#FFCC00" Text="Approved"></asp:Label>
        <br />
        <asp:GridView ID="gv_approvedorder" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="order_id" OnRowCommand="gv_pendingorder_RowCommand">
            <Columns>
                <asp:BoundField DataField="Order_id" HeaderText="Order Number" />
                <asp:BoundField DataField="Cust_username" HeaderText="Username" />
                <asp:BoundField DataField="packing_date" HeaderText="Order Date" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <span class="auto-style14">Blocked</span><br />
        <div class="auto-style13">
        <asp:GridView ID="gv_blocked" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="order_id" OnRowCommand="gv_pendingorder_RowCommand">
            <Columns>
                <asp:BoundField DataField="Order_id" HeaderText="Order Number" />
                <asp:BoundField DataField="Cust_username" HeaderText="Username" />
                <asp:BoundField DataField="packing_date" HeaderText="Order Date" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        </div>
</asp:Content>
