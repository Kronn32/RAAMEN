<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="RAAMEN.View.InsertRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label><br />
        <asp:TextBox ID="NameTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
        <asp:Label ID="MeatLbl" runat="server" Text="Meat"></asp:Label><br />
        <asp:DropDownList ID="MeatDDL" runat="server">
            <asp:ListItem Text="Beef" Value="1"></asp:ListItem>
            <asp:ListItem Text="Chicken" Value="2"></asp:ListItem>
            <asp:ListItem Text="Duck" Value="3"></asp:ListItem>
            <asp:ListItem Text="Pork" Value="4"></asp:ListItem>
            <asp:ListItem Text="Seafood" Value="5"></asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="BrothLbl" runat="server" Text="Broth"></asp:Label><br />
        <asp:TextBox ID="BrothTxt" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
        <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label><br />
        <asp:TextBox ID="PriceTxt" runat="server" TextMode="Number" AutoCompleteType="Disabled"></asp:TextBox><br /><br />
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" /><br />
        <asp:Button ID="BackBtn" runat="server" Text="Back to Manage Page" onclick="BackBtn_Click"/>
        <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
