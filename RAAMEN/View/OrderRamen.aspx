<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="RAAMEN.View.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="RamenGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="RamenGV_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" />
                <asp:BoundField DataField="Meat.Name" HeaderText="Meat" SortExpression="Meat.Name" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="Order" />
            </Columns>
        </asp:GridView><br />
        <asp:GridView ID="CartGV" runat="server"></asp:GridView>
        <asp:Button ID="BuyCartBtn" runat="server" Text="Buy Cart" OnClick="BuyCartBtn_Click" />
        <asp:Button ID="ClearCartBtn" runat="server" Text="Clear Cart" OnClick="ClearCartBtn_Click" /><br />
    </div>
</asp:Content>
