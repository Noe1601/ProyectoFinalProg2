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

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargos.id = int.Parse(TextBoxID.Text);
            cargos.cargo = TextBoxCargo.Text;
            nego.EditarCargo(cargos);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cargos.id = int.Parse(TextBoxID.Text);
            nego.EliminarCargo(cargos);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReporteCargos.aspx");
        }
    }
}