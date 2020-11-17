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
    public partial class FormularioDept : System.Web.UI.Page
    {
        departamento OBJETO = new departamento();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterDept.DataSource = nego.MostrarDept();
            RepeaterDept.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OBJETO.codigodepartamento = textboxCod.Text;
            OBJETO.nombre = textboxNom.Text;

            nego.Insertar(OBJETO);
            textboxCod.Text = " ";
            textboxNom.Text = " ";
            //ScriptManager.RegisterStartupScript(this, this.GetType(),
            //    "alert",
            //    "alert(Departamento registrado); window.location = 'FormularioDept.aspx';"  , true);
        }

        protected void BotonAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Modulo1.aspx");
        }
    }
}