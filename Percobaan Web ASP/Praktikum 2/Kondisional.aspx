<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Kondisional.aspx.vb" Inherits="WebASP.Kondisional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=" Username : "></asp:label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text=" Lakukan Proses" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" />
        </div>
    </form>
</body>
</html>