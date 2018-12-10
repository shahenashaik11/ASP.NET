<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="OnlineExam.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <html>
        <body>
       <center>     <Header style="font-size:xx-large;font-family:Algerian">Report Page</Header>
        
    <p>
        <br />
    </p>
    <p>
        <span style="color: #993333">From Date:</span>&nbsp;
        <asp:TextBox ID="txtFromDate" runat="server" BorderColor="#FF0066" ForeColor="#66CCFF" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #990033">To Date:</span>&nbsp;
        <asp:TextBox ID="txtToDate" runat="server" BorderColor="#990033" ForeColor="#66CCFF"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="GetData" BackColor="#FF0066" />
    </p>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="UserID" AutoGenerateSelectButton="True" AutoGenerateColumns="False"   Width="503px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="margin-top: 6px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1"  PageSize="5"  AllowPaging="True" >
            <Columns>
                <asp:TemplateField HeaderText="UserID  ">
                    <EditItemTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblUserID" runat="server" Text='<%# Eval("UserID") %>'></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    <p>
        <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
           <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Report" />
           </p>
    <p style="text-decoration: underline; font-family: Arial; font-size: xx-large; color: #6600FF">
        <strong>Report Details</strong></p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Height="146px" Width="510px" >
            <Columns>
                <asp:TemplateField HeaderText="QuestionName">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("QuestionName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Response">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Response") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
           </p>
    <p>
        &nbsp;</p>
    <p>
    </p></center>
            </body>
        </html>
</asp:Content>
