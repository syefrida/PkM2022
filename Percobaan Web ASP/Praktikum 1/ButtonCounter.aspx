<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ButtonCounter.aspx.vb" Inherits="WebASP.ButtonCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ButtomCounter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Counter&nbsp;
            <asp:Button ID="Button1" runat="server" Text="0" />

            <br />

            Second Counter
            <asp:Button ID="Button2" runat="server" Text="0" />
        </div>
    </form>
</body>
</html>
