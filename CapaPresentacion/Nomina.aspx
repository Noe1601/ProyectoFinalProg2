﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="CapaPresentacion.Nomina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="desing.css" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <div id="container3">
    <form id="form1" runat="server">
         <h1>Seccion departamentos</h1>
            <asp:Label ID="LabelCodigo" runat="server" Text="Ingrese el año correspondiente"></asp:Label><br />
            <asp:TextBox ID="textboxYear" runat="server"></asp:TextBox><br />
            <asp:Label ID="LabelNombre" runat="server" Text="Ingrese el mes correspondiente"></asp:Label><br />
            <asp:TextBox ID="textboxMonth" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="procesar nomina" OnClick="Button1_Click" /><br />
           <asp:Button ID="BotonAtras" class="btn btn-danger" runat="server" Text="Ir atras" OnClick="BotonAtras_Click" />
    </form>
        </div>
    <br />
     <div id="contenedor2">
    <table class="table table-bordered">
        <thead id="cabecera">
            <tr>
                 <th>ID</th>
                 <th>Año</th>
                 <th>Mes</th>
                 <th>Monto</th>
            </tr>
        </thead>
        <tbody id="cuerpo">
            <asp:Repeater ID="RepeaterNom" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%#Eval("id") %></td>
                        <td> <%#Eval("yearr") %></td>
                        <td> <%#Eval("mes") %></td>
                        <td> <%#Eval("montototal") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
  </div>
</body>
</html>