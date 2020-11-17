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
    <form id="form1" runat="server" class="form-horizontal">
        <div>
            <h1>Seccion cargos</h1>
            <asp:Label ID="LabelCargo" runat="server" Text="Cargo"></asp:Label><br />
            <asp:TextBox ID="TextBoxCargo" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="ButtonCargo" class="btn btn-success" runat="server" Text="Registrar cargo" OnClick="ButtonCargo_Click" />
              <asp:Button ID="BotonAtras" class="btn btn-danger" runat="server" Text="Ir atras" OnClick="BotonAtras_Click" />
        </div>
    </form>
        </div>
     <div id="contenedor2">
    <table class="table table-bordered">
        <thead id="cabecera">
            <tr>
                 <th>ID</th>
                 <th>Cargo</th>
            </tr>
        </thead>
        <tbody id="cuerpo">
            <asp:Repeater ID="RepeaterCargo" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%#Eval("id") %></td>
                        <td> <%#Eval("cargo") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
  </div>
</body>
</html>
