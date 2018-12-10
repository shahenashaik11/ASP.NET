<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DynamicTextBox.aspx.cs" Inherits="OnlineExam.DynamicTextBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <tr>
        <td colspan="2" style="background-color:bisque;>
            <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    </td>
                </tr>

            </table>
            </td>
        </tr>
</asp:Content>
