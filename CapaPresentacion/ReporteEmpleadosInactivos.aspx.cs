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
    public partial class ReporteEmpleadosInactivos : System.Web.UI.Page
    {
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterInac.DataSource = nego.MostrarSalidas();
            RepeaterInac.DataBind();
        }
    }
}