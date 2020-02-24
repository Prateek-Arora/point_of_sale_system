<%@ Page Title="Cashier Login" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="cashier_login.aspx.cs" Inherits="cashier_login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form2" runat="server">
        
        <asp:SqlDataSource ID="SqlDataSourcecashier" runat="server" ConnectionString="<%$ ConnectionStrings:pos_string %>" SelectCommand="SELECT * FROM [cashier_login]"></asp:SqlDataSource>
        
        <div class="main-page clearfix">
            <div class="login-form">
                <asp:Label class="login-label" ID="Label1" runat="server" Text="Username:"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="*Username Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="username" runat="server"></asp:TextBox>
                <br />

                <asp:Label class="login-label" ID="Label2" runat="server" Text="Password:"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="*Password Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="password" runat="server" TextMode="Password"></asp:TextBox>
                <br />

                <asp:Button class="login-button" ID="login" runat="server" Text="Login" OnClick="login_Click" Width="332px" /> 
                <br />
                <br />
                <p>Or <a href="register-cashier.aspx" >SignUp</a> now to avail the benefits</p>
            </div>
        </div>
        
    </form>
</asp:Content>
