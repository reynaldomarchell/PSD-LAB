<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Session3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Login
        <div>
            <asp:TextBox ID="UsernameTxt" placeholder="Username" runat="server"></asp:TextBox>
        </div>
        
        <div>
            <asp:TextBox ID="PasswordTxt" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:CheckBox ID="RememberCB" Text="Remember Me" runat="server" />
        </div>

        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
    </form>
</body>
</html>
