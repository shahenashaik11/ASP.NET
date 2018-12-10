<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="FrontEnd.TextBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body style="background-color:burlywood">

        
        
    
    <p>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblQuestion" runat="server" Text="Enter Question"></asp:Label>
        :</p>
    <p>
        &nbsp;&nbsp; &nbsp;<textarea id="TextArea1" name="S1"></textarea></p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
        :<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="109px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblComponent" runat="server" Text="Component"></asp:Label>
        :
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="110px">
        </asp:DropDownList>
    </p>
    <p>
    </p>
        </body>
</asp:Content>
