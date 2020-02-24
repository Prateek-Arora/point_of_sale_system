<%@ Page Title="Veggies" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="veggies.aspx.cs" Inherits="veggies" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div class="shop-pg clearfix">
            <ul class="fruit-line clearfix">
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/cabbage.jfif">
                        <h3>Cabbage</h3>
                        <h3>Price: 50/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox1" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click" />
                        <div class="border-bot">
                            <h3>
                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                            </h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/carrot.jfif">
                        <h3>Carrot</h3>
                        <h3>Price: 30/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox2" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Add to Cart" OnClick="Button2_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/cauliflower.jfif">
                        <h3>Cauliflower</h3>
                        <h3>Price: 50/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox3" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Add to Cart" OnClick="Button3_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/eggplant.jfif">
                        <h3>Eggplant</h3>
                        <h3>Price: 40/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox4" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="Add to Cart" OnClick="Button4_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
            </ul>

            <ul class="fruit-line clearfix">
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/green-capsicum.jfif">
                        <h3>Green Capsicum</h3>
                        <h3>Price: 30/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox5" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" Text="Add to Cart" OnClick="Button5_Click" />
                        <div class="border-bot">
                            <h3><asp:TextBox ID="TextBox17" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/onion.jfif">
                        <h3>Onion</h3>
                        <h3>Price: 50/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox6" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button6" runat="server" Text="Add to Cart" OnClick="Button6_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/potato.jfif">
                        <h3>Potato</h3>
                        <h3>Price: 35/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox7" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button7" runat="server" Text="Add to Cart" OnClick="Button7_Click" />
                        <div class="border-bot">
                            <h3><asp:TextBox ID="TextBox19" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/pumpkin.jfif">
                        <h3>Pumpkin</h3>
                        <h3>Price: 60/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox8" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button8" runat="server" Text="Add to Cart" OnClick="Button8_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
            </ul>
            <ul class="fruit-line clearfix">
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/raddish.jfif">
                        <h3>Raddish</h3>
                        <h3>Price: 20/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox9" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button9" runat="server" Text="Add to Cart" OnClick="Button9_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/red-capsicum.jfif">
                        <h3>Red Capsicum</h3>
                        <h3>Price: 45/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox10" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" Text="Add to Cart" OnClick="Button10_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/spinach.jfif">
                        <h3>Spinach</h3>
                        <h3>Price: 35/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox11" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button11" runat="server" Text="Add to Cart" OnClick="Button11_Click" />
                        <div class="border-bot">
                            <h3><asp:TextBox ID="TextBox23" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="card clearfix">
                        <img src="resources/img/veggies/tomato.jfif">
                        <h3>Tomato</h3>
                        <h3>Price: 25/Kg</h3>
                        <p>Qnty:</p>
                        <asp:TextBox class="txt-box" ID="TextBox12" runat="server" Width="60px" Height="33px" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button12" runat="server" Text="Add to Cart" OnClick="Button12_Click" />
                        <div class="border-bot">
                            <h3> <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox></h3>
                        </div>
                    </div>
                </li>
            </ul>
            <asp:Button class="sub-btn" ID="Button13" runat="server" Width="600px" Height="60px" Text="Buy Now" OnClick="Button13_Click" />

        </div>
    </form>

</asp:Content>
