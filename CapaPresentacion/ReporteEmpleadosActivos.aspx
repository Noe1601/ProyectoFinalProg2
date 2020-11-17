<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteEmpleadosActivos.aspx.cs" Inherits="CapaPresentacion.ReporteEmpleadosActivos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="desing.css" />
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
   <%-- <form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
      <div id="contenedor10">
          <h1>Reporte de empleados activos</h1>
    <table class="table table-bordered">
        <thead id="cabecera">
            <tr>
                    <th>ID</th>
                    <th>Codigo</th>
                    <th>Nombre </th>
                    <th>Apellido</th>
                    <th>Telefono</th>
                    <th>Departamento</th>
                    <th>Cargo</th>
                    <th>Fecha</th>
                    <th>Estatus</th>
                    <th>Salario</th>
            </tr>
        </thead>
        <tbody id="cuerpo">
            <asp:Repeater ID="RepeaterEmp" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%#Eval("id") %></td>
                        <td> <%#Eval("codigoempleado") %></td>
                        <td> <%#Eval("nombre") %></td>
                        <td> <%#Eval("apellido") %></td>
                        <td> <%#Eval("telefono") %></td>
                        <td> <%#Eval("departamento") %></td>
                        <td> <%#Eval("cargo") %></td>
                        <td> <%#Eval("fecha") %></td>
                        <td> <%#Eval("Estatus") %></td>
                        <td> <%#Eval("salario") %></td>
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
