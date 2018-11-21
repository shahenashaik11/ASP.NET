<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="_21NOV.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Doctor Name:<input id="Text1" type="text" /></p>
    <p>
        Specialization:<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>cardioloigist</asp:ListItem>
            <asp:ListItem>ENT</asp:ListItem>
            <asp:ListItem>Radiologist</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
