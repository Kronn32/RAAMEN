<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="RAAMEN.View.ManageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="RamenLbl" runat="server" Text="Ramen"></asp:Label><br />
        <asp:GridView ID="RamenGV" runat="server"></asp:GridView><br />
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
    </div>
</asp:Content>
