<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entradas.aspx.cs" Inherits="CapaPresentacion.Entradas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link rel="stylesheet" href="filtros.css" />
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <div id="container">
        <a href="ModuloReportes.aspx">Ir a modulo reportes</a>
    <form id="form1" runat="server">
          <h1>Consulta de empleados por mes</h1>
        <asp:Label ID="Label1" runat="server" Text="Ingrese un mes aqui"></asp:Label><br />
        <asp:TextBox ID="TextBoxMes"  runat="server"></asp:TextBox><br /> <br />
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Buscar" OnClick="Button1_Click" /><br /><br />
        <asp:GridView ID="GridView1" class="GridView1"  runat="server" Width="511px" ></asp:GridView>
        </form>
        </div>
    
</body>
</html>
