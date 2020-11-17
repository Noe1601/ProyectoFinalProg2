<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FiltroEmpleados.aspx.cs" Inherits="CapaPresentacion.FiltroEmpleados" %>

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
        <h1>Consulta de empleados activos</h1>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br />
        <asp:TextBox ID="TextBoxNombre"  runat="server"></asp:TextBox><br /> <br />
        <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Buscar por nombre" OnClick="Button2_Click" /><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Departamento"></asp:Label><br />
        <asp:TextBox ID="TextBoxDepartamento"  runat="server"></asp:TextBox><br /> <br />
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Buscar por departamento" OnClick="Button1_Click" /><br /><br />
        <asp:GridView ID="GridView1" class="GridView1"  runat="server" Width="511px" ></asp:GridView>
    </form>
   </div>
</body>
</html>
