<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paging.aspx.cs" Inherits="OnlineExam.Paging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:gridview ID="grdData" runat="server" 

AutoGenerateColumns="False" CellPadding="4" PageSize="2"

            ForeColor="#333333" GridLines="None" Width="200" AllowPaging="True"

            OnPageIndexChanging="grdData_PageIndexChanging">
            <alternatingrowstyle BackColor="White" ForeColor="#284775"></alternatingrowstyle>
            <columns>
                <asp:boundfield DataField="ID" HeaderText="ID"></asp:boundfield>
                <asp:boundfield DataField="Name" HeaderText="Name"></asp:boundfield>
            </columns>
            <editrowstyle BackColor="#999999"></editrowstyle>
            <footerstyle BackColor="#5D7B9D" Font-Bold="True" 

            ForeColor="White"></footerstyle>
            <headerstyle BackColor="#5D7B9D" Font-Bold="True" 

            ForeColor="White"></headerstyle>
            <pagerstyle BackColor="#284775" ForeColor="White" 

            HorizontalAlign="Center"></pagerstyle>
            <rowstyle BackColor="#F7F6F3" ForeColor="#333333"></rowstyle>
            <selectedrowstyle BackColor="#E2DED6" Font-Bold="True" 

            ForeColor="#333333"></selectedrowstyle>
            <sortedascendingcellstyle BackColor="#E9E7E2"></sortedascendingcellstyle>
            <sortedascendingheaderstyle BackColor="#506C8C"></sortedascendingheaderstyle>
            <sorteddescendingcellstyle BackColor="#FFFDF8"></sorteddescendingcellstyle>
            <sorteddescendingheaderstyle BackColor="#6F8DAE"></sorteddescendingheaderstyle>
        </asp:gridview>
</asp:Content>
