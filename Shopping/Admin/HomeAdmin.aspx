<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="Shopping.Admin.HomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .square{
           border:1px solid #d3d044;
           border-radius:10px;
           width:180px;
           height:100px;
           margin-left:20px;
           margin-bottom:20px;
           display:inline-block;
           padding:5px;
           padding-top:70px;
           font-size:25px;
         
       }
       .square:hover{
           cursor:pointer;
           opacity:.4;
       }
       #container{
           text-align:center;
           padding-top:50px;
       }
        .user {
            background-image: url(../images/users.png),url(../images/templatemo_menu_bg.jpg);
        background-position:  right bottom,top;
    background-size: 80px,auto;
    background-repeat:no-repeat,repeat;
            }
        .order{
             background-image: url(../images/order.png),url(../images/templatemo_menu_bg.jpg);
        background-position:  right bottom,top;
    background-size: 80px,auto;
    background-repeat:no-repeat,repeat;
        }
        .book{
background-image: url(../images/2-books-png-image-thumb.png),url(../images/templatemo_menu_bg.jpg);
        background-position:  right bottom,top;
    background-size: 80px,auto;
    background-repeat:no-repeat,repeat;
        }
            .cat{
background-image: url(../images/Bio-formats-icon.png),url(../images/templatemo_menu_bg.jpg);
        background-position:  right bottom,top;
    background-size: 80px,auto;
    background-repeat:no-repeat,repeat;
        }
       .prom{
background-image: url(../images/promo.png),url(../images/templatemo_menu_bg.jpg);
        background-position:  right bottom,top;
    background-size: 100px,auto;
    background-repeat:no-repeat,repeat;
        }
   </style>
<script src="../JavaScript/Home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome Administrator</h1>
      <div id="container">
        <div class="square cat">Category</div>
        <div class="square book" >Product</div>
        <div class="square prom">Promotion</div>
        <div class="square user">Users</div>
        <div class="square order">Order</div>
      </div>
</asp:Content>
