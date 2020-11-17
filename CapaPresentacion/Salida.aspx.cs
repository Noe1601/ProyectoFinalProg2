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
    public partial class Salida : System.Web.UI.Page
    {
        salidas salir = new salidas();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterSal.DataSource = nego.MostrarSalidas();
            RepeaterSal.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            salir.empleado = TextBoxEmpleado.Text;
            salir.tiposalida = TextBoxTipo.Text;
            salir.motivo = TextBoxMotivo.Text;
            salir.fechasalida = Convert.ToDateTime(TextBoxFecha.Text);

            nego.Salidas(salir);

            TextBoxEmpleado.Text = "";
            TextBoxTipo.Text = "";
            TextBoxMotivo.Text = "";
            TextBoxFecha.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}