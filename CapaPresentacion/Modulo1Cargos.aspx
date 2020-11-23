<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modulo1Cargos.aspx.cs" Inherits="CapaPresentacion.Modulo1Cargos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="desing.css" />
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <div id="container">
    <a href="Modulo1.aspx">Ir a pagina principal</a>
    <form id="form1" runat="server" class="form-horizontal">
        <div>
            <h1>Seccion cargos</h1>
             <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label><br />
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox><br />
            <asp:Label ID="LabelCargo" runat="server" Text="Cargo"></asp:Label><br />
            <asp:TextBox ID="TextBoxCargo" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="ButtonCargo" class="btn btn-success" runat="server" Text="Registrar cargo" OnClick="ButtonCargo_Click" /><br /><br />
               <asp:Button ID="Button1" class="btn btn-warning" runat="server" Text="Actualizar cargo" OnClick="Button1_Click"  /><br /><br />
            <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Eliminar cargo" OnClick="Button2_Click"  /><br /><br />
             <asp:Button ID="Button3" class="btn btn-success" runat="server" Text="Ver listado de cargos" OnClick="Button3_Click" />
        </div>
    </form>
        </div>
    
</body>
</html>
