<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="GridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table>
                   
                    <tr>
                        <th>
                            <asp:Label ID="Label1" runat="server"><b><u>Department Details</u></b></asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    
                    <tr>
                        <th>
                            <asp:Label ID="Label4" runat="server" Text="Department Name"></asp:Label>
                        </th>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                        </th>                       
                    </tr>
                    <tr>
                        <th><a href="../Designation.aspx">Go back</a></th>
                    </tr>
                    <tr>
                        <th>
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </th>
                    </tr>
                   
                </table>
       
            </center>
        </div>
    </form>
</body>
</html>
