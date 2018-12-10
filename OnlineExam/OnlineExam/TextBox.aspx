<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="OnlineExam.TextBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <asp:Panel ID="pnlTextBoxes" runat="server">
</asp:Panel>
<hr />
<asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="AddTextBox" />
<asp:Button ID="btnGet" runat="server" Text="Get Values" OnClick="GetTextBoxValues" />
</asp:Content>
