<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="ManuelMoreno_A9.Index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">

        <h1>Quiz Mundialista!!</h1>
        <div>
            <h3>  <asp:Label ID="Label4" runat="server" Text="Cual de estos paises tiene mas goles en los mundiales"></asp:Label></h3>
    <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" Height="82px" Width="115px">
        <asp:ListItem>Sambia</asp:ListItem>
        <asp:ListItem>San Marino</asp:ListItem>
        <asp:ListItem>Albania</asp:ListItem>
        <asp:ListItem>Sudan</asp:ListItem>
        <asp:ListItem>Panamá</asp:ListItem>
    </asp:RadioButtonList>

      
     <h3> <asp:Label ID="Label3" runat="server" Text="Seleccion que mas Mundiales de la Fifa ha ganado"></asp:Label></h3>
    <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" Height="82px" Width="115px">
        <asp:ListItem>Argentina</asp:ListItem>
        <asp:ListItem>Alemania</asp:ListItem>
        <asp:ListItem>Brazil</asp:ListItem>
        <asp:ListItem>Italia</asp:ListItem>
        <asp:ListItem>Francia</asp:ListItem>
    </asp:RadioButtonList>



     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;



     <h3>  <asp:Label ID="Label2" runat="server" Text="Jugador con mas balones de oro"></asp:Label></h3>
    <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" Height="82px" Width="115px">
        <asp:ListItem>Cristiano</asp:ListItem>
        <asp:ListItem>Messi</asp:ListItem>
        <asp:ListItem>Ronaldinho</asp:ListItem>
    </asp:RadioButtonList>


       <h3> <asp:Label ID="Label1" runat="server" Text="Mayor goleador de Selecciones"></asp:Label></h3>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="82px" Width="115px">
        <asp:ListItem>Cristiano</asp:ListItem>
        <asp:ListItem>Messi</asp:ListItem>
        <asp:ListItem>Neymar Jr</asp:ListItem>
    </asp:RadioButtonList>

           <h2> <asp:Label ID="Resultado" runat="server" Text="Label" Visible="False"></asp:Label></h2>

    <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
