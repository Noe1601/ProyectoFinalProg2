using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class ReporteCargos : System.Web.UI.Page
    {
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterCargo.DataSource = nego.MostrarCargo();
            RepeaterCargo.DataBind();
        }
    }
}