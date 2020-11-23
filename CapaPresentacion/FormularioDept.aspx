<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioDept.aspx.cs" Inherits="CapaPresentacion.FormularioDept" %>

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
    <div id="container">
        <a href="Modulo1.aspx">Ir a pagina principal</a>
    <form id="form1" runat="server" class="form-horizontal">
        <br />
            <h1>Seccion departamentos</h1>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label><br />
            <asp:TextBox ID="textboxID" runat="server"></asp:TextBox><br />
            <asp:Label ID="LabelCodigo" runat="server" Text="Codigo"></asp:Label><br />
            <asp:TextBox ID="textboxCod" runat="server"></asp:TextBox><br />
            <asp:Label ID="LabelNombre" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="textboxNom" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Guardar" OnClick="Button1_Click" /><br /><br />
            <asp:Button ID="Button2" class="btn btn-warning" runat="server" Text="Editar" OnClick="Button2_Click" /><br /><br />
            <asp:Button ID="Button3" class="btn btn-primary" runat="server" Text="Eliminar" OnClick="Button3_Click"  /><br /><br/>
           <asp:Button ID="BotonAtras" class="btn btn-success" runat="server" Text="Ver listado de departamentos" OnClick="BotonAtras_Click" /><br />
       </form>
        </div>
   
</body>
</html>

