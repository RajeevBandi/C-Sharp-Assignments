<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Web_Application.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Forgot Password</h1>
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
                        <label>Email:</label>
                    </div>
                    <div style="width: 150px">
                        <asp:TextBox ID="txtEmail" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                </div>


                <div style="display: flex; flex-direction: row;">
                    <div style="width: 150px">
                        <label>New Password:</label>

                    </div>
                    <div style="width: 150px">
                        <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div style="display: flex; flex-direction: row;">
                    <div style="width: 150px">
                        <label>Confirm Password:</label>
                    </div>
                    <div style="width: 150px">
                        <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div style="text-align: center; padding-top: 20px">
                    <asp:Button ID="btnSavePassword" runat="server" Text="Save" OnClick="btnSavePassword_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
