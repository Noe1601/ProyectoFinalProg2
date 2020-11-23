<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuloEmpleados.aspx.cs" Inherits="CapaPresentacion.ModuloEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="desing.css" />
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
</head>
<body>
    <div id="container3">
        <a href="Modulo1.aspx">Ir a pagina principal</a>
    <form id="form1" runat="server" class="form-horizontal">
        <h1>Seccion empleados</h1>
        <asp:Label ID="Label1" runat="server" Text="Codigo empleado"></asp:Label><br />
        <asp:TextBox ID="TextBoxCodigoE" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Nombre "></asp:Label><br />
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label><br />
        <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label><br />
        <asp:TextBox ID="TextBoxTel" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Text="Departamento"></asp:Label><br />
        <asp:TextBox ID="TextBoxDept" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Cargo"></asp:Label><br />
        <asp:TextBox ID="TextBoxCargo" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="Fecha"></asp:Label><br />
        <asp:TextBox ID="TextBoxFecha" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label8" runat="server" Text="Estatus"></asp:Label><br />
        <asp:TextBox ID="TextBoxEstatus" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label9" runat="server" Text="Salario"></asp:Label><br />
        <asp:TextBox ID="TextBoxSalario" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Registrar empleado" OnClick="Button1_Click" /><br /><br />
         <asp:Button ID="Button3" class="btn btn-warning" runat="server" Text="Actualizar empleado" OnClick="Button3_Click1"  /><br /><br />
         <asp:Button ID="Button4" class="btn btn-primary" runat="server" Text="Eliminar empleado" OnClick="Button4_Click"  /><br /><br />
         <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Ver listado de empleados" OnClick="Button2_Click"  />

    </form>
        </div>
    
</body>
</html>
