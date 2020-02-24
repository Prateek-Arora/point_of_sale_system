<%@ Page Title="Shop" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="shop-page.aspx.cs" Inherits="shop_page" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shop-pg">
        <ul class="line clearfix">
            <li>
                <figure class="line-photo">
                    <a class="shop-image" href="fruits.aspx"><img src="resources/css/img/fruit-img.jfif"></a>
                    <div class="centered">Fruits</div>
                </figure>

            </li>
            <li>
                <figure class="line-photo">
                    <a class="shop-image" href="veggies.aspx"><img src="resources/css/img/vegetables-img.jpg"></a>
                    <div class="centered">Veggies</div>
                </figure>

            </li>
        </ul>

        <ul class="line clearfix">
            <li>
                <figure class="line-photo">
                    <a class="shop-image" href="breads.aspx"><img src="resources/css/img/bread-img.jpg"></a>
                    <div class="centered">Breads</div>
                </figure>

            </li>
            <li>
                <figure class="line-photo">
                    <a class="shop-image" href="pulses.aspx"><img src="resources/css/img/pulses-img.jfif"></a>
                    <div class="centered">Pulses</div>
                </figure>

            </li>
        </ul>



    </div>


</asp:Content>