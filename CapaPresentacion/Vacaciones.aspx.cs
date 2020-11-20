using CapaDatos;
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
    public partial class Vacaciones : System.Web.UI.Page
    {
        vacaciones vacacion = new vacaciones();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            vacacion.empleado = TextBoxEmpleado.Text;
            vacacion.desde = Convert.ToDateTime(TextBoxInicio.Text);
            vacacion.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            vacacion.yearr = Convert.ToDateTime(TextBoxCorre.Text);
            vacacion.comentarios = TextBoxComen.Text;

            nego.Vacaciones(vacacion);

            TextBoxEmpleado.Text = "";
            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxCorre.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}