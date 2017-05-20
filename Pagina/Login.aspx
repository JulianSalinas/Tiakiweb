<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Servicio.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="Styles/Login.css" rel="stylesheet" />
    <link href="Styles/MasterPage.css" rel="stylesheet" />
</head>
<body>
    <form id="LoginForm" runat="server">

        <div class="Login">
            <img class="navBarPic" src="pics/user2.png"/>

                <asp:TextBox class="txtLogin" ID="txtUsuario" placeholder="Usuario" runat="server"></asp:TextBox>
                <asp:TextBox class="txtLogin" ID="txtPassword" placeholder="Constraseña" type="password" runat="server"></asp:TextBox>
                <asp:Button class="btnLogin" ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click"/>
           
        </div>

    </form>
</body>
</html>
