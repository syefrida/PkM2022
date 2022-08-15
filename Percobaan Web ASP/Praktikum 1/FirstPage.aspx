<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FirstPage.aspx.vb" Inherits="WebASP.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FirstPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Welcome To ASP.NET.2.0!"></asp:Label>
            <asp:Label ID="dateTimeLabel" runat="server" Text="The Current Date/Time"></asp:Label>
        </div>
    </form>
      
    <table style="width:100%;">
        <tr>
            <td style="width: 100px"></td>
            <td style="width: 100px"></td>
            <td style="width: 100px"></td>
        </tr>
       
    </table>
      
</body>
</html>
