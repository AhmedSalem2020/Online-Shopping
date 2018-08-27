<%@ Page Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="change_password.aspx.cs" Inherits="Shopping.User.change_password" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="height: 21px">
                <asp:Label ID="Label1" runat="server" BackColor="#333333" ForeColor="#996600" Text="Old Password"></asp:Label>
            </td>
            <td style="height: 21px">
                <asp:TextBox ID="txt_old_pass" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_old_pass" Display="Dynamic" ErrorMessage="Must Enter old pass" ForeColor="Red" ValidationGroup="v1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" BackColor="#333333" ForeColor="#996600" Text="New password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_new_pass" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_new_pass" Display="Dynamic" ErrorMessage="Must Enter new pass" ForeColor="Red" ValidationGroup="v1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" BackColor="#333333" ForeColor="#996600" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_confirmpass" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_confirmpass" Display="Dynamic" ErrorMessage="Must confirm pass" ForeColor="Red" ValidationGroup="v1">*</asp:RequiredFieldValidator>
                &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_new_pass" ControlToValidate="txt_confirmpass" Display="Dynamic" ErrorMessage="Pass dont match" ForeColor="Red" ValidationGroup="v1">Pass dont match</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_change" runat="server" BackColor="#333333" BorderColor="#333333" ForeColor="#996600" OnClick="btn_change_Click" Text="Change" ValidationGroup="v1" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_status" runat="server" BackColor="#333333" ForeColor="#996600"></asp:Label>
                &nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="v1" />
            </td>
        </tr>
    </table>
</asp:Content>
