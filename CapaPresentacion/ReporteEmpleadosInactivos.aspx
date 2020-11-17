<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteEmpleadosInactivos.aspx.cs" Inherits="CapaPresentacion.ReporteEmpleadosInactivos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
         <link rel="stylesheet" href="desing.css" />
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body> 
        <div id="contenedor10">
              <h1>Reporte de empleados inactivos</h1>
    <table class="table table-bordered">
        <thead id="cabecera">
            <tr>
                    <th>ID</th>
                    <th>Empleado</th>
                    <th>Tipo </th>
                    <th>Motivo</th>
                    <th>Fecha</th>
            </tr>
        </thead>
        <tbody id="cuerpo">
            <asp:Repeater ID="RepeaterInac" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%#Eval("id") %></td>
                        <td> <%#Eval("empleado") %></td>
                        <td> <%#Eval("tiposalida") %></td>
                        <td> <%#Eval("motivo") %></td>
                        <td> <%#Eval("fechasalida") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
            <form id="form1" runat="server">
        <div>
             <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Imprimir" />
        </div>
    </form>
         
  </div>
        
</body>
</html>
