<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="ShoppingOnline.login" %>
<style type="text/css">
  .txt{
      border-radius:10px;
    border: 2px solid #7d6754;
    padding: 3px;
    font-family: 'Monotype Corsiva',Verdana, Geneva, Tahoma, sans-serif;
    Width: 60px;
    Height: 25px;
    font: 18px;
  }
  .btn{
      background-color:#0b4112;
  }
    .auto-style2 {
        width: 162px;
    }
    .auto-style3 {
        width: 189px;
    }
  
</style>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table class="auto-style5">
            <tr>
                <td class="auto-style4">Email:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_name" runat="server" CssClass="txt" Width="129px"></asp:TextBox>
                </td>
                <td class="auto-style6">Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_pass" runat="server" CssClass="txt" TextMode="Password" Width="115px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btn_log" runat="server" cssclass="txt btn" ForeColor="#e6e154" OnClick="btn_log_Click" Text="Log in" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="ch_rem" runat="server" Text="Remember Me" />
                </td>
                <td colspan="3">
                    <asp:LinkButton ID="lbtn_forget" runat="server" CausesValidation="False" OnClick="lbtn_forget_Click">forget it?</asp:LinkButton>
                    <asp:Label ID="lbl_msg" runat="server" ForeColor="Red"></asp:Label>
                    &nbsp;<asp:Label ID="lbl_mail_stutes" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table class="auto-style3">
            <tr>
                <td class="auto-style7">Welcome:</td>
                <td class="auto-style2">
                    <asp:Label ID="lbl_name" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbtn_logout" runat="server" CausesValidation="False" OnClick="lbtn_logout_Click">logout</asp:LinkButton>
                </td>
            </tr>
        </table>
    </asp:View>
</asp:MultiView>


