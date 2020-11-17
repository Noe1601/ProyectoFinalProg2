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
    public partial class Nomina : System.Web.UI.Page
    {
        nomina nomina = new nomina();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterNom.DataSource = nego.MostrarNomina();
            RepeaterNom.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            nomina.yearr = int.Parse(textboxYear.Text);
            nomina.mes = int.Parse(textboxMonth.Text);
            nomina.montototal = null;

            nego.Nominas(nomina);
        }

        protected void BotonAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}