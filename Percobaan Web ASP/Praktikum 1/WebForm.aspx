<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm.aspx.vb" Inherits="WebASP.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebPertama</title>
    <style type="text/css">
        .auto-style1 {
            color: #ff0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 aria-atomic="True" class="auto-style1">Welcome To Webform</h1>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Clik" />
        </p>
    </form>
</body>
</html>
