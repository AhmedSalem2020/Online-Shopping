<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="pendingorders.aspx.cs" Inherits="ShoppingOnline.Admin.pendingorders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="auto-style13">

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
				   <Columns>
					   <asp:TemplateField HeaderText="image">
						   <EditItemTemplate>
							   <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("prod_img") %>'></asp:TextBox>
						   </EditItemTemplate>
						   <ItemTemplate>
							   <asp:Image ID="Image1" runat="server" Height="39px" ImageUrl='<%# Bind("prod_img") %>' Width="68px" />
						   </ItemTemplate>
					   </asp:TemplateField>
					   <asp:BoundField DataField="prod_name" HeaderText="Book Name" />
					   <asp:BoundField DataField="prod_price" HeaderText="price" />
					   <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
				   </Columns>
	   </asp:GridView>
		</div>
		<asp:Label ID="lbl_result" runat="server"></asp:Label>
				   </br>
		<br />
		<br />

	<asp:ListView ID="lstView_data" runat="server" >
			<ItemTemplate>
			<div class="list" style="display:inline-block; margin-left:10px ;">
			   <table>
					<tr><td><h1><%#Eval("CustomerName")%><h1></td></tr>
					<tr><td><h4 style="color:#e6e154">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Address:<%#Eval("address") %></h4></td></tr>
					<tr><td><h4 style="color:#e6e154">&nbsp;&nbsp;&nbsp;Phone:<%#Eval("phone") %></h4></td></tr>
						<tr><td><h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_details" runat="server" commandArgument='<%#Eval("Order_id") %>' CommandName="buttondetail" Text="Order Detail" 
												OnClick="btn_details_Click"/></h1></td></tr>

					<tr><td><h1> &nbsp;&nbsp;&nbsp;<asp:Button ID="btn_Add" runat="server" commandArgument='<%#Eval("Order_id") %>' CommandName="buttonAdd" Text="Approve Order"  OnClick="btn_Add_Click" /></h1></td></tr>

				   <%--<tr><td> 
			   <asp:GridView ID="<%#Eval("Order_id")%>" runat="server"  AutoGenerateColumns="False">
				   <Columns>
					   <asp:TemplateField HeaderText="image">
						   <EditItemTemplate>
							   <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("prod_img") %>'></asp:TextBox>
						   </EditItemTemplate>
						   <ItemTemplate>
							   <asp:Image ID="Image1" runat="server" Height="39px" ImageUrl='<%# Bind("prod_img") %>' Width="68px" />
						   </ItemTemplate>
					   </asp:TemplateField>
					   <asp:BoundField DataField="prod_name" HeaderText="Book Name" />
					   <asp:BoundField DataField="prod_price" HeaderText="price" />
					   <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
				   </Columns>
		</asp:GridView></td></tr>--%>

					
					

					<br>
					

				   </br>
					<br>
				   </br>
					<br>
				   </br>

				</table> 
			</div>
				</ItemTemplate>
		</asp:ListView>

   

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style13 {
            text-align: center;
        }
    </style>
</asp:Content>

