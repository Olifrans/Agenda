<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Agenda.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txbSenha" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="Logar" />
            <br />
    <asp:Label ID="lMsg" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
