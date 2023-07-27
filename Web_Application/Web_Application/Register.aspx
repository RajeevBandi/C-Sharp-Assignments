<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web_Application.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Registration Page</h1>
            <div style="margin-top: 10px; display: flex; flex-direction: column; align-items: center; gap: 10px">
                <div style="display: flex; flex-direction: row;">
                    <div style="width: 100px">
                        <label>Username:</label>
                    </div>
                    <div style="width: 100px">
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div style="display: flex; flex-direction: row;">
                    <div style="width: 100px">
                        <label>Password:</label>

                    </div>
                    <div style="width: 100px">
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div style="display: flex; flex-direction: row;">
                    <div style="width: 100px">
                        <label>Email:</label>
                    </div>
                    <div style="width: 100px">
                        <asp:TextBox ID="txtEmail" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div style="text-align: center; padding-top: 20px">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </div>
            </div>

            <div style="text-align: center; padding-top: 70px;">
                <label>Already have an account? <b>Login now!!</b></label>
            </div>
            <div style="text-align: center; padding-top: 10px;">
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
