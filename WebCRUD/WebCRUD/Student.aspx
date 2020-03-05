<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebCRUD.Student" %>

<asp:Content ID="id918" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color:darkkhaki">
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Stu_Id"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Stu_Name"></asp:Label></td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Stu_City"></asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />

                </td>
            </tr>
        </table>

    </div>

    <div class="jumbotron" style="background-color:darkkhaki">

        <asp:Label ID="Label4" runat="server" Text="Stu_Id"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Select" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>



    </div>

    <div class="jumbotron" style="background-color:darkkhaki">

        <table>
             <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Stu_Id"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Stu_City"></asp:Label></td>
                <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button4" runat="server" Text="Updadte" OnClick="Button4_Click" />
                </td>
            </tr>

        </table>

    </div>

    <div class="jumbotron" style="background-color:darkkhaki">

        <asp:Label ID="Label7" runat="server" Text="Stu_Id"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Delete" OnClick="Button5_Click"/>




    </div>

    <div class="jumbotron" style="background-color:darkkhaki">

        <asp:Button ID="Button2" runat="server" Text="ShowStudentTable" OnClick="Button2_Click" />
        <br />
        <br />
      
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      
       
    </div>

</asp:Content>