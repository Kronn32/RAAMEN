<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="RAAMEN.View.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="HistoryGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="HistoryGV_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" />
                <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" SortExpression="CustomerId" />
                <asp:BoundField DataField="StaffId" HeaderText="Staff ID" SortExpression="StaffId" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="Details" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
