﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FiltroSalidas.aspx.cs" Inherits="CapaPresentacion.FiltroSalidas" %>

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
        <h1>Consulta de empleados inactivos</h1>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Ingrese un mes aqui"></asp:Label><br />
        <asp:DropDownList ID="DropDownList1" class="relleno" runat="server"></asp:DropDownList><br /><br />
        <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Buscar" OnClick="Button2_Click"  /><br /><br />
         <asp:GridView ID="GridView1" class="GridView1"  runat="server" Width="511px" ></asp:GridView>
    </form>
   </div>
</body>
</html>
