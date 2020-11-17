<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="CapaPresentacion.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="desing.css" />
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="#">Modulo mantenimiento</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="FormularioDept.aspx">DEPARTAMENTOS</a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="Modulo1Cargos.aspx">CARGOS</a>
      </li>
         <li class="nav-item active">
        <a class="nav-link" href="ModuloEmpleados.aspx">EMPLEADOS</a>
      </li>
    <%--  <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Dropdown
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="#">Action</a>
          <a class="dropdown-item" href="#">Another action</a>
          <div class="dropdown-divider"></div>
          <a class="dropdown-item" href="#">Something else here</a>
        </div>
      </li>--%>
     <%-- <li class="nav-item">
        <a class="nav-link disabled" href="#">Disabled</a>
      </li>--%>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search">
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
    </form>
  </div>
</nav>
            <div id="cards">
            <div id="card">
                <p class="icon">H</p>
                <h3 class="category">Mantenimiento</h3>
                <p class="info">
                    Este modulo se encarga de inyectar informacion 
                    a nuestra entidad
                </p>
            </div>

            <div id="card1">
                <p class="icon">S</p>
                <h3 class="category">Procesos</h3>
                <p class="info">
                    Este modulo se encarga de gestionar los diferentes procesos
                    de nuestra entidad
                </p>
            </div>

            <div id="card2">
                <p class="icon">a</p>
                <h3 class="category">Reportes</h3>
                <p class="info">
                    Este modulo se encarga de consultar los diferentes reportes
                    en nuestra entidad
                </p>
            </div>
        </div>

            <asp:Button ID="BotonAtras" class="btn btn-danger" runat="server" Text="Ir atras" OnClick="BotonAtras_Click" />
    
        </div>

        

    </form>
   <div class="footer">
        &copy; Noe Eduardo Medina Henriquez WEB
    </div>
       

   
</body>
</html>
