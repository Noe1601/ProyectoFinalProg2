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
    public partial class Licencias : System.Web.UI.Page
    {
        licencias licencia = new licencias();
        datosnegocio nego = new datosnegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterLic.DataSource = nego.MostrarLicencia();
            RepeaterLic.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            licencia.empleado = TextBoxEmpleado.Text;
            licencia.desde = Convert.ToDateTime(TextBoxInicio.Text);
            licencia.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            licencia.motivos = TextBoxMotivo.Text;
            licencia.comentarios = TextBoxComen.Text;

            nego.Licencia(licencia);

            TextBoxEmpleado.Text = "";
            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxMotivo.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}