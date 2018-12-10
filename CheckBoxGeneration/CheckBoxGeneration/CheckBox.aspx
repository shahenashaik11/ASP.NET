<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="CheckBoxGeneration.CheckBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="QuestionID">
                    <EditItemTemplate>
                        <asp:Label ID="lblQuestionID" runat="server" Text='<%# Eval("QuestionID") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblQuestionID" runat="server" Text='<%# Eval("QuestionID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Question">
                    <EditItemTemplate>
                        <asp:Label ID="lblQuestion" runat="server" Text='<%# Eval("Question") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblQuestion" runat="server" Text='<%# Eval("Question") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Options">
                    <EditItemTemplate>
                        <asp:CheckBox ID="chkOption1" runat="server" Text='<%# Eval("Option1") %>' />
                        <asp:CheckBox ID="chkOption2" runat="server" Text='<%# Eval("Option2") %>' />
                        <br />
                        <asp:CheckBox ID="chkOption3" runat="server" Text='<%# Eval("Option3") %>' />
                        <asp:CheckBox ID="chkOption4" runat="server" Text='<%# Eval("Option4") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkOption1" runat="server" Text='<%# Eval("Option1") %>' />
                        <asp:CheckBox ID="chkOption2" runat="server" Text='<%# Eval("Option2") %>' />
                        <br />
                        <asp:CheckBox ID="chkOption3" runat="server" Text='<%# Eval("Option3") %>' />
                        <asp:CheckBox ID="chkOption4" runat="server" Text='<%# Eval("Option4") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
</asp:Content>
