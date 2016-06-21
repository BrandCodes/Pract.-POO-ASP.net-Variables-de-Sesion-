<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConcertarCita.aspx.cs" Inherits="Practica08_ControlesB.Demo.ConcertarCita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Concertar una TUTORIA:<br />
        <br />
        Apellidos + nombre(s) de estudiante:<br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Con el profesor(a):<br />
        <asp:DropDownList ID="ddlProfesor" runat="server">
            <asp:ListItem>Albus Dumbledore</asp:ListItem>
            <asp:ListItem>ObiWan Kenovi</asp:ListItem>
            <asp:ListItem>Bruce Lee</asp:ListItem>
            <asp:ListItem>Nicolas Maquiavelo</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Día:<br />
        <asp:DropDownList ID="ddlDia" runat="server">
            <asp:ListItem>Lunes</asp:ListItem>
            <asp:ListItem>Martes</asp:ListItem>
            <asp:ListItem>Miercoles</asp:ListItem>
            <asp:ListItem>Jueves</asp:ListItem>
            <asp:ListItem>Viernes</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Width="500px">
            Hora:<br />
            <asp:RadioButtonList ID="rblHora" runat="server">
                <asp:ListItem>10:00 am</asp:ListItem>
                <asp:ListItem>12:00 pm</asp:ListItem>
                <asp:ListItem>02:00 pm</asp:ListItem>
                <asp:ListItem>04:00 pm</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <br />
        Asunto:<br />
        <asp:TextBox ID="txtAsunto" runat="server" Height="60px" TextMode="MultiLine" Width="492px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnMostrar" runat="server" Enabled="False" OnClick="btnMostrar_Click" Text="Mostrar Datos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar Datos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRestablecer" runat="server" OnClick="btnRestablecer_Click" Text="Restablecer" />
        <br />
        <br />
        <asp:Label ID="lblEstado" runat="server" Text="____"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
