﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Faculty.aspx.cs" Inherits="WebCRUD.Faculty" %>

<asp:Content ID="fac918" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color:pink">

         <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Faculty_Id"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Faculty_Name"></asp:Label></td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Faculty_City"></asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click"/>

                </td>
            </tr>
        </table>

    </div>

    <div class="jumbotron" style="background-color:pink">

        <asp:Label ID="Label4" runat="server" Text="Faculty_Id"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Select" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>

        </div>


    <div class="jumbotron" style="background-color:pink">

        <table>
             <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Faculty_Id"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Faculty_City"></asp:Label></td>
                <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Update" OnClick="Button4_Click" />
                </td>
            </tr>

        </table>

    </div>

    <div class="jumbotron" style="background-color:pink">

        <asp:Button ID="Button2" runat="server" Text="ShowFacultyTable" OnClick="Button2_Click" />
        <br />
        <br />
      
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      
    </div>
    
</asp:Content>