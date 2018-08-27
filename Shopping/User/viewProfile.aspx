<%@ Page Title="" Language="C#" MasterPageFile="~/User/users.Master" AutoEventWireup="true" CodeBehind="viewProfile.aspx.cs" Inherits="Shopping.User.viewProfile" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width: 100%">
    <tr>
        <td colspan="3" style="text-align: center; color: #FFCCFF; font-size: 30px; font-weight: bold; font-style: italic; font-family: 'Courier New', Courier, monospace;">Welcome&nbsp;
            <asp:Label ID="lbl_username0" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="text-align: center; color: #FFCCFF; font-size: 30px; font-weight: bold; font-style: italic; font-family: 'Courier New', Courier, monospace;">&nbsp;</td>
    </tr>
    <tr>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99; height: 32px;">Full Name&nbsp;&nbsp;</td>
        <td style=" font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99; height: 32px;">
            <asp:Label ID="lbl_fname" runat="server" Text="Label"></asp:Label>
            &nbsp;<asp:Label ID="lbl_lname" runat="server" Text="Label"></asp:Label>
        </td>
        <td style="height: 32px"></td>
    </tr>
    <tr>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">User Name&nbsp;&nbsp;&nbsp;</td>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">
            <asp:Label ID="lbl_username" runat="server" Text="Label"></asp:Label>
        </td>
        <td dir="rtl" rowspan="4" style="font-family: Roman; font-size: medium; font-weight: bold; font-style: italic; color: #FFFFCC">B<br />
            O<br />
            O<br />
            K<br />
            <br />
            S<br />
            T<br />
            O<br />
            R<br />
            E</td>
    </tr>
    <tr>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">Email</td>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">
            <asp:Label ID="lbl_email" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">Address</td>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">
            <asp:Label ID="lbl_address" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">Phone No</td>
        <td style="font-family: 'Tw Cen MT Condensed Extra Bold'; font-size: 20px; font-weight: normal; font-style: italic; color: #FFFF99">
            <asp:Label ID="lbl_phone" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 123px">&nbsp;</td>
        <td style="width: 198px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 123px">&nbsp;</td>
        <td style="width: 198px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 123px">&nbsp;</td>
        <td style="width: 198px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 123px">&nbsp;</td>
        <td style="width: 198px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 123px">&nbsp;</td>
        <td style="width: 198px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3" style="font-size: 15px; font-weight: bold; font-style: italic; color: #FFCCFF; text-align: center; height: 21px;">
            <asp:LinkButton ID="lnk_edit" runat="server" ForeColor="#FFCCFF" OnClick="lnk_edit_Click">Edit profile</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnk_chngPass" runat="server" ForeColor="#FFCCFF" OnClick="lnk_chngPass_Click">Change password</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td colspan="3" style="font-size: 15px; font-weight: bold; font-style: italic; color: #FFCCFF; text-align: center;">&nbsp;</td>
    </tr>
</table>
</asp:Content>
