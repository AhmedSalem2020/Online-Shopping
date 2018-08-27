<%@ Page Title="" Language="C#" MasterPageFile="~/Annonymous/Master.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ShoppingOnline.Annonymous.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Create Account...</h1>
          <table class="auto-style2">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="firstname" runat="server" Text="First Name" Font-Bold="True" Font-Size="10pt" ForeColor="White"></asp:Label>
                </td>
                <td class="&nbsp;&lt;/td">
                    <asp:TextBox ID="txt_fname" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_fname" ErrorMessage="First Name Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txt_fname" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="[a-zA-Z\.\'\-_\s]{1,40}">invalid name</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style5" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Last Name" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_lname" ErrorMessage="Last Name Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txt_lname" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="[a-zA-Z\.\'\-_\s]{1,40}">invalid name</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Email" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_mail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mail" ErrorMessage="Not Valid" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-z]{2,6}$">*Not Valid</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="User Name" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txt_uname" ErrorMessage="User Name Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_mail" ErrorMessage="Not Valid" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-z]{2,6}$">Not Valid</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Password" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txt_pass" ErrorMessage="Password Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1" style="width: 194px"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label16" runat="server" Text="ConfirmPassword" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_confirm" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pass" ControlToValidate="txt_confirm" ErrorMessage="Not match" ForeColor="Red">Not match</asp:CompareValidator>
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label7" runat="server" Text="Address" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_address" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="txt_address" ErrorMessage="Address Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1" style="width: 194px"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="Phone" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_phone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txt_phone" ErrorMessage="Phone Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txt_phone" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^01[0-2]{1}[0-9]{8}">Unvalid number</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label11" runat="server" Text="Zip Code" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_code" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txt_code" ErrorMessage="Code Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txt_code" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^[0-9]+$">invalid zipcode</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label12" runat="server" Text="National ID" Font-Bold="True" Font-Size="10pt"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_ID" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txt_ID" ErrorMessage="National ID Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txt_ID" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^[0-9]+$">invalid SSN</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="10pt" Text="ID Image"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:FileUpload ID="fu_image" runat="server" BackColor="#996600" BorderColor="#996600" BorderStyle="None" Font-Bold="True" ForeColor="#663300" Height="30px" />
                </td>
                <td class="auto-style1" style="width: 194px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="fu_image" ErrorMessage="image Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btn_register" runat="server" BackColor="#996600" ForeColor="White" OnClick="btn_register_Click" Text="Register" Width="99px" BorderColor="#996600" BorderStyle="None" Font-Bold="True" Height="30px" />
                </td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style1" style="width: 194px">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="57px" />
                </td>
                <td class="auto-style13" style="width: 194px">
                    <asp:Label ID="lbl_result" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
