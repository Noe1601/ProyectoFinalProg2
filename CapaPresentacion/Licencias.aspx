<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Licencias.aspx.cs" Inherits="CapaPresentacion.Licencias" %>

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
    <form id="form1" runat="server">
        <div>
             <h1>Registro de licencias</h1>
            <asp:Label ID="Label1" runat="server" Text="No.Empleado"></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" class="relleno" runat="server"></asp:DropDownList><br />
           <%-- <asp:TextBox ID="TextBoxEmpleado" runat="server"></asp:TextBox><br />--%>
             <asp:Label ID="Label2" runat="server" Text="Inicio(Fecha)"></asp:Label><br />
            <asp:TextBox ID="TextBoxInicio" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label3" runat="server" Text="Final(Fecha)"></asp:Label><br />
            <asp:TextBox ID="TextBoxFinal" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label4" runat="server" Text="Motivo"></asp:Label><br />
            <asp:TextBox ID="TextBoxMotivo" runat="server"></asp:TextBox><br /><br />
             <asp:Label ID="Label5" runat="server" Text="Comentarios"></asp:Label><br />
            <asp:TextBox ID="TextBoxComen" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Registrar licencia" OnClick="Button1_Click" /><br /><br />
                            <asp:Button ID="Button3" class="btn btn-warning" runat="server" Text="Editar " OnClick="Button3_Click"    /><br /><br />
           <asp:Button ID="Button4" class="btn btn-primary" runat="server" Text="Eliminar " OnClick="Button4_Click"  /><br /><br />
             <asp:Button ID="Button2" class="btn btn-danger" runat="server" Text="Ir atras" OnClick="Button2_Click" /><br /><br />
        </div>
    </form>
        </div>

      <br />
         
</body>
</html>
