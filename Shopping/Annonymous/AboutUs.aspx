<%@ Page Title="" Language="C#" MasterPageFile="~/Annonymous/Master.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="ShoppingOnline.Annonymous.AboutUs" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <link href="../Style/About.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    
    <br />
    <asp:LinkButton ID="lbtn_lang" runat="server" Text="عربي" OnClick="lbtn_lang_Click" ></asp:LinkButton>    
    <asp:Label ID="lbl_aboutUs" runat="server" Text="&lt;h1&gt;About Us&lt;/h1&gt;" Font-Strikeout="False" meta:resourcekey="lbl_aboutUsResource1"></asp:Label>
    <asp:Label ID="lbl_content" runat="server" CssClass="lbl" Text="The Bookspot opened on january 16, 2018 in Mansoura, Egypt. It is owned by a very unique team of a man and 4 women who share a great love of books and had always dreamed of owning a bookstore. 

            The store has grown a lot since it first opened and we currently have over 5,000 used books in stock to choose from as well as a selection of new books and we get new stuff in everyday.

            You can order our books through our website and get them delivered anywhere in Egypt!

            We import our own new books from both the UK and the US and can special order any title that is in print. Just email us to get information about availability and price.

            The Bookspot is open every day from 10am to 10pm.



    " Font-Overline="False" Font-Size="12pt" meta:resourcekey="lbl_contentResource1"></asp:Label>
</asp:Content>


