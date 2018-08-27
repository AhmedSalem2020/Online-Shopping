<%@ Page Title="" Language="C#" MasterPageFile="~/Annonymous/Master.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Shopping.Annonymous.ContactUs" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style13 {
            width: 644px;
        }
        .auto-style14 {
            width: 622px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <table class="auto-style13">
         <tr>
             <td style="text-align:right" class="auto-style3"> <asp:LinkButton ID="lbtn_lang" runat="server" Text="عربي" OnClick="lbtn_lang_Click" meta:resourcekey="lbtn_langResource1" ></asp:LinkButton></td>
         </tr>
         <tr>
             <td style="text-align:center" class="auto-style3"> <h1 class="auto-style14">
                 <asp:Label ID="lbl_conUs" runat="server" Text="Contact Us" meta:resourcekey="lbl_conUsResource2"></asp:Label>
                 </h1></td>
         </tr>
         <tr>
            <td class="auto-style3" style="font-family: Verdana, Geneva, Tahoma, sans-serif">
                    <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" Text="NAME"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_name" runat="server" Height="23px" Width="475px" meta:resourcekey="txt_nameResource1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: Verdana, Geneva, Tahoma, sans-serif">
                    <asp:Label ID="Label2" runat="server" meta:resourcekey="Label2Resource1" Text="EMAIL"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_email" runat="server" Height="23px" Width="475px" meta:resourcekey="txt_emailResource1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: Verdana, Geneva, Tahoma, sans-serif">
                    <asp:Label ID="Label3" runat="server" meta:resourcekey="Label3Resource1" Text="SUBJECT"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_subject" runat="server" Height="23px" Width="475px" meta:resourcekey="txt_subjectResource1"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: medium; font-weight: normal; font-family: Verdana, Geneva, Tahoma, sans-serif;">
                    <asp:Label ID="Label4" runat="server" meta:resourcekey="Label4Resource1" Text="MESSAGE"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_message" runat="server" Height="211px" TextMode="MultiLine" Width="472px" meta:resourcekey="txt_messageResource1"></asp:TextBox>
                    &nbsp;<br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btn_submit" runat="server" BackColor="#996600" BorderColor="#663300" BorderWidth="0px" Font-Bold="True" Font-Size="15px" ForeColor="White" Height="37px" OnClick="btn_submit_Click" Text="Submit" Width="73px" meta:resourcekey="btn_submitResource1" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbl_contact" runat="server" meta:resourcekey="lbl_contactResource1"></asp:Label>
                </td>
            </tr>
            </table>
</asp:Content>
