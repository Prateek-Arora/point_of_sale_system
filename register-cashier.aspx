<%@ Page Title="Cashier Signup" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="register-cashier.aspx.cs" Inherits="register_cashier" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form2" runat="server">
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pos_string %>" SelectCommand="SELECT * FROM [cashier_login]"></asp:SqlDataSource>
        <div class="main-page clearfix">
            <div class="login-form">
                <asp:Label class="login-label" ID="Label1" runat="server" Text="Name: "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="* Name is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="name" runat="server"></asp:TextBox>
                <br />

                <asp:Label class="login-label" ID="Label2" runat="server" Text="Email: "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="* Email is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="* Enter a valid email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:TextBox class="login-text" ID="email" runat="server"></asp:TextBox>

                <br />

                <asp:Label class="login-label" ID="Label3" runat="server" Text="Contact: "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="contact" ErrorMessage="* Contact is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="contact" runat="server"></asp:TextBox>

                <br />

                <asp:Label class="login-label" ID="Label4" runat="server" Text="Username: "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="username" ErrorMessage="* Username is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="username" runat="server"></asp:TextBox>

                <br />

                <asp:Label class="login-label" ID="Label5" runat="server" Text="Password: "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="password" ErrorMessage="* Password is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox class="login-text" ID="password" runat="server" TextMode="Password"></asp:TextBox>

                <br />

                <asp:Label class="login-label" ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Cpassword" ErrorMessage="* Re-enter Password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="Cpassword" ErrorMessage="* Both passwords must be same" ForeColor="#FF3300"></asp:CompareValidator>
                <asp:TextBox class="login-text" ID="Cpassword" runat="server" TextMode="Password"></asp:TextBox>

                <br />

                <asp:Button class="login-button" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />

            </div>

        </div>
        
        
    </form>
</asp:Content>
