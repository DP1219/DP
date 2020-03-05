<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color:cyan">

        <h1 style="font-family:'Times New Roman';color:blue">Welcome to ASP.Net WEB Application</h1>
         <p style="text-align:center"><a href="Student.aspx" class="btn btn-primary btn-lg">Student &raquo;</a></p>
         <p style="text-align:center"><a href="Course.aspx" class="btn btn-primary btn-lg">Course &raquo;</a></p>
         <p style="text-align:center"><a href="Faculty.aspx" class="btn btn-primary btn-lg">Faculty &raquo;</a></p>
    </div>

    

</asp:Content>
