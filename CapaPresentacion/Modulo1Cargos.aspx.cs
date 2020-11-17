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
    public partial class Modulo1Cargos : System.Web.UI.Page
    {
        cargos cargos = new cargos();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterCargo.DataSource = nego.MostrarCargo();
            RepeaterCargo.DataBind();
        }

        protected void ButtonCargo_Click(object sender, EventArgs e)
        {
            cargos.cargo = TextBoxCargo.Text;
            nego.InsertarCargo(cargos);
            TextBoxCargo.Text = " ";
        }

        protected void BotonAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Modulo1.aspx");
        }
    }
}