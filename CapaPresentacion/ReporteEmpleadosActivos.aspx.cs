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
    public partial class ReporteEmpleadosActivos : System.Web.UI.Page
    {
        empleados empleado = new empleados();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterEmp.DataSource = nego.MostrarEmpleados();
            RepeaterEmp.DataBind();
        }
    }
}