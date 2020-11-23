﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuloProcesos.aspx.cs" Inherits="CapaPresentacion.ModuloProcesos" %>

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
  <a class="navbar-brand" href="#">Modulo procesos</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="Nomina.aspx">NOMINA</a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="Salida.aspx">SALIDA EMPLEADOS</a>
      </li>
         <li class="nav-item active">
        <a class="nav-link" href="Vacaciones.aspx">VACACIONES</a>
      </li>
         <li class="nav-item active">
        <a class="nav-link" href="Permisos.aspx">PERMISOS</a>
      </li>
         <li class="nav-item active">
        <a class="nav-link" href="Licencias.aspx">LICENCIAS</a>
      </li>
  
    </ul>
   
  </div>
</nav>
            <asp:Button ID="Button1" class="btn btn-danger" runat="server" Text="Ir atras" OnClick="Button1_Click" />
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

    
        </div>

        </form>
   <div class="footer">
        &copy; Noe Eduardo Medina Henriquez WEB
    </div>


</body>
</html>
