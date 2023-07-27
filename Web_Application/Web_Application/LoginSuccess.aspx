<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSuccess.aspx.cs" Inherits="Web_Application.LoginSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <label><b>Login Successful!!</b></label>
        </div>
        <div style="text-align: center; padding-top: 10px;">
            <asp:Button ID="redirectLogin" runat="server" Text="LogOut" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
