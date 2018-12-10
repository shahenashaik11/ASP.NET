<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExamPage.aspx.cs" Inherits="OnlineExam.ExamPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Category" DataValueField="Category">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Category] FROM [Category]"></asp:SqlDataSource>
    </p>
        <asp:GridView ID="GridView3" OnRowEditing="GridView3_RowEditing" OnRowUpdating="GridView3_RowUpdating" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField HeaderText="QuestionId">
                    <EditItemTemplate>
                        <asp:Label ID="lblQId" runat="server" Text='<%# Eval("QuestionId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblQId" runat="server" Text='<%# Eval("QuestionId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Questions">
                    <EditItemTemplate>
                        <asp:Label ID="lblQuestions" runat="server" Text='<%# Eval("Questions") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblQuestions" runat="server" Text='<%# Eval("Questions") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Options">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox5" runat="server" Text='<%# Eval("Option1") %>' />
                        <asp:CheckBox ID="CheckBox7" runat="server"  Text='<%# Eval("Option2") %>' />
                        <asp:CheckBox ID="CheckBox6" runat="server"  Text='<%# Eval("Option3") %>' />
                        <asp:CheckBox ID="CheckBox8" runat="server"  Text='<%# Eval("Option4") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text='<%# Eval("Option1") %>' />
                        <asp:CheckBox ID="CheckBox3" runat="server"  Text='<%# Eval("Option2") %>' />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text='<%# Eval("Option3") %>' />
                        <asp:CheckBox ID="CheckBox4" runat="server"  Text='<%# Eval("Option4") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    <p>
          <script type="text/javascript">  
// for check all checkbox  
        function CheckAll(Checkbox) {  
            var GridVwHeaderCheckbox = document.getElementById("<%=GridView3.ClientID %>");  
            for (i = 1; i < GridVwHeaderCheckbox.rows.length; i++) {  
                GridVwHeaderCheckbox.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = Checkbox.checked;  
            }  
        }  

    </script>  
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
