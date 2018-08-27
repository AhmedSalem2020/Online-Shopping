<%@ Page Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="editProfile.aspx.cs" Inherits="ShoppingOnline.User.editProfile" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="Larger" ForeColor="#996600" Text="Edit your profile"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 76px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#996600" Text="First Name"></asp:Label>
            </td>
            <td style="height: 21px; width: 185px">
                <asp:TextBox ID="txt_fname" runat="server" Width="141px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_fname" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txt_fname" Display="Dynamic" ErrorMessage="invalid name" Font-Bold="True" ForeColor="Red" ValidationExpression="[a-zA-Z\.\'\-_\s]{1,40}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 76px">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#996600" Text="Last Name"></asp:Label>
            </td>
            <td style="width: 185px">
                <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_lname" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txt_lname" Display="Dynamic" ErrorMessage="invalid name" Font-Bold="True" ForeColor="Red" ValidationExpression="[a-zA-Z\.\'\-_\s]{1,40}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 76px; height: 28px;">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#996600" Text="User Name"></asp:Label>
            </td>
            <td style="width: 185px; height: 28px;">
                <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_username" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 76px; height: 24px">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#996600" Text="Email"></asp:Label>
            </td>
            <td style="width: 185px; height: 24px">
                <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_email" Display="Dynamic" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email" Display="Dynamic" ErrorMessage="not valid email" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 76px">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#996600" Text="Phone"></asp:Label>
            </td>
            <td style="width: 185px; height: 21px">
                <asp:TextBox ID="txt_phone" runat="server" TextMode="Phone"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_phone" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_phone" Display="Dynamic" ErrorMessage="not valid phone number" Font-Bold="True" ForeColor="Red" ValidationExpression="^01[0-2]{1}[0-9]{8}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 76px">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="#996600" Text="Address"></asp:Label>
            </td>
            <td style="height: 21px; width: 185px">
                <asp:TextBox ID="txt_address" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_address" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;<asp:Button ID="btn_save" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="#996600" OnClick="btn_save_Click" Text="Save Changes" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_cancel" runat="server" BackColor="#333333" ForeColor="#996600" OnClick="btn_cancel_Click" Text="Cancel Changes" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
    </table>
</asp:Content>
