<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="RAAMEN.View.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Log In</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="UsernameTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />

            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox><br />

            <asp:CheckBox ID="RememberMeCbx" Text="Remember Me" runat="server" /><br />

            <asp:Button ID="LogInBtn" runat="server" Text="Log In" OnClick="LogInBtn_Click" />
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" /><br />
            <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
