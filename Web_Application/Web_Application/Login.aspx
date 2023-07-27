<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Application.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Login Page</h1>
            <div style="margin-top: 4px">
                <div style="margin-top: 10px; display: flex; flex-direction: column; align-items: center; gap: 10px">
                    <div style="display: flex; flex-direction: row;">
                        <div style="width: 150px">
                            <label>Username:</label>
                        </div>
                        <div style="width: 150px">
                            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div style="display: flex; flex-direction: row;">
                        <div style="width: 150px">
                            <label>Password:</label>

                        </div>
                        <div style="width: 150px">
                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div style="margin-top: 10px; padding-left: 830px;">
                    <asp:HyperLink ID="Link" runat="server" Text="Forgot Password?" NavigateUrl="~/ForgotPassword.aspx" Font-Size="Smaller"></asp:HyperLink>
                </div>
                <div style="text-align: center; padding-top: 20px">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>

        <div>
            <div style="text-align: center; padding-top: 70px;">
                <label>Don't have an account? <b>Register now!!</b></label>
            </div>
            <div style="text-align: center; padding-top: 10px;">
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>
