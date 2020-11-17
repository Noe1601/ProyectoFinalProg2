<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CapaPresentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="3.css" />
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="container">
    <div class="row justify-content-center pt-5 wt-5 mr-1">
     <div class="col-md-4 login">
        <div class="form-group text-center">
            <h1 class="text-light">Iniciar Sesion</h1>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Ingrese su usuario aqui"></asp:Label>
            <asp:TextBox ID="TextBoxUsuario" class="form-control" Text="" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
             <asp:Label ID="Label2" runat="server" Text="Ingrese su password aqui"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" class="form-control" Text="" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="ButtonIngresar" class="btn btn-success" runat="server" Text="Ingresar" OnClick="ButtonIngresar_Click" />
        </div>
       </div>
    </div>
 </div>
        </div>
    </form>
</body>
</html>
