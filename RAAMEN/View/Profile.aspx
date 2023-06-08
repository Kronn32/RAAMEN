<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="RAAMEN.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Update Profile</h2>
    <div>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="UsernameTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />

            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="EmailTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
           
            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label><br />
            <asp:RadioButton ID="MaleBtn" Text="Male" runat="server" GroupName="Gender" /><br />
            <asp:RadioButton ID="FemaleBtn" Text="Female" runat="server" GroupName="Gender" /><br />       
           
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox><br />
            <br />
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" /><br />
            <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
