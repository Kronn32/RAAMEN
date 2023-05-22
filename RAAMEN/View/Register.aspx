<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RAAMEN.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h2>Create Your Account</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="RoleLbl" runat="server" Text="Role"></asp:Label><br />
            <asp:RadioButton ID="BuyerBtn" Text="Buyer" runat="server" GroupName="Role" /><br />
            <asp:RadioButton ID="StaffBtn" Text="Staff" runat="server" GroupName="Role" /><br />
            <asp:RadioButton ID="AdminBtn" Text="Admin" runat="server" GroupName="Role" /><br />
         
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="UsernameTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
          
            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="EmailTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
           
            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label><br />
            <asp:RadioButton ID="MaleBtn" Text="Male" runat="server" GroupName="Gender" /><br />
            <asp:RadioButton ID="FemaleBtn" Text="Female" runat="server" GroupName="Gender" /><br />       
           
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox><br />
          
            <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="Confirm Password"></asp:Label><br />
            <asp:TextBox ID="ConfirmPasswordTxt" runat="server" TextMode="Password"></asp:TextBox><br />
            <br />
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/><br />
            <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
