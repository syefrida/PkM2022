<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClickEvent.aspx.vb" Inherits="WebASP.ClickEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Click Event Button</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button id="button" runat="server" OnClick="button_Click" Text="Click Me" />
        <asp:Label id="Label1" runat="server" />
        <div>
        </div>
    </form>
</body>
</html>
