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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="124px" />
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="LabelDoctor"></asp:Label>
    </p>
</asp:Content>
