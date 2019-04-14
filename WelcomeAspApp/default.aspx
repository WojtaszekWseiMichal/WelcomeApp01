<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WelcomeAspApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome App ASP .net</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name :&nbsp;
            <asp:TextBox ID="idName" runat="server"></asp:TextBox>
            <br />
            Surrname :&nbsp; <asp:TextBox ID="idSurrname" runat="server"></asp:TextBox>
            <br />
            Age :&nbsp;
            <asp:TextBox ID="idAge" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="idButtonSend" runat="server" Text="Send" OnClick="idButtonSend_Click" />
            <br />
            <br />
            <asp:Label ID="idFirstStatment" runat="server"></asp:Label>
            <br />
            <asp:Label ID="idSecondStatment" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
