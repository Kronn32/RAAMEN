<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RAAMEN.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label" runat="server" Text="Role: "></asp:Label>
    <asp:Label ID="RoleLbl" runat="server" Text=""></asp:Label><br />
    <br />
    <asp:Label ID="CustomerLbl" runat="server" Text="Customer Data:"></asp:Label><br />
    <asp:GridView ID="CustomerGV" runat="server"></asp:GridView>
    <br />
    <asp:Label ID="StaffLbl" runat="server" Text="Staff Data:"></asp:Label><br />
    <asp:GridView ID="StaffGV" runat="server"></asp:GridView>
</asp:Content>
