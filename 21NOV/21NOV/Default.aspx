<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_21NOV._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron" style="background-color:cadetblue">
        <h1>ABC HOSPITAL<asp:TextBox ID="TextBox2" runat="server" Height="35px" OnTextChanged="TextBox2_TextChanged" Width="419px"></asp:TextBox>
        </h1>
        <p class="lead">We Care About Your Health.<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="430px"></asp:TextBox>
        </p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click" Width="149px" />
        </p>
    </div>
    
    <div class="row"  style="background-color:cadetblue">
        <div class="col-md-4" style="background-color:palevioletred">
            <h2>User Details</h2>
            <p>
                Enter the User Details:
                <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>

        <div class="col-md-4" style="background-color:darksalmon">
            <h2>Hospital Departments</h2>
            <p>
             Different hospital departments are shown here:
                <asp:Label ID="Label2" runat="server" Text="LabelName"></asp:Label>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style="background-color:darkseagreen">
            <h2>Medical Services</h2>
            <p>
                Different Medical services are provided here:
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
