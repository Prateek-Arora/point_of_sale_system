<%@ Page Title="Admin Login / Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="admin_login.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        
        <asp:SqlDataSource ID="SqlDataSourceadmin" runat="server" ConnectionString="<%$ ConnectionStrings:pos_string %>" SelectCommand="SELECT * FROM [admin_login]"></asp:SqlDataSource>
        
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
            </div>
        </div>
        
    </form>
</asp:Content>
