﻿using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Permisos : System.Web.UI.Page
    {
        permisos permiso = new permisos();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterPer.DataSource = nego.MostrarPermiso();
            RepeaterPer.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            permiso.empleado = TextBoxEmpleado.Text;
            permiso.desde = Convert.ToDateTime(TextBoxInicio.Text);
            permiso.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            permiso.comentarios = TextBoxComen.Text;

            nego.Permisos(permiso);
            TextBoxEmpleado.Text = "";
            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}