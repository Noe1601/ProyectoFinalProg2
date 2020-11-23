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
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OBJETO.codigodepartamento = textboxCod.Text;
            OBJETO.nombre = textboxNom.Text;

            nego.Insertar(OBJETO);
            textboxCod.Text = " ";
            textboxNom.Text = " ";

        }

        protected void BotonAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReporteDepartamentos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OBJETO.id = int.Parse(textboxID.Text);
            OBJETO.codigodepartamento = textboxCod.Text;
            OBJETO.nombre = textboxNom.Text;
            nego.Editar(OBJETO);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OBJETO.id = int.Parse(textboxID.Text);
            nego.Eliminar(OBJETO);
        }
    }
}