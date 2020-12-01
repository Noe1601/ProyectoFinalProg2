using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Licencias : System.Web.UI.Page
    {
        licencias licencia = new licencias();
        datosnegocio nego = new datosnegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarNombre();
            }
        }

        public void CargarNombre()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "CARGAREMPLEADOS";
                comando.Connection = conexion;
                conexion.Open();
                DropDownList1.DataSource = comando.ExecuteReader();
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "nombre";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            licencia.empleado = DropDownList1.Text;
            licencia.desde = Convert.ToDateTime(TextBoxInicio.Text);
            licencia.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            licencia.motivos = TextBoxMotivo.Text;
            licencia.comentarios = TextBoxComen.Text;

            nego.Licencia(licencia);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxMotivo.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            licencia.empleado = DropDownList1.Text;
            licencia.desde = Convert.ToDateTime(TextBoxInicio.Text);
            licencia.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            licencia.motivos = TextBoxMotivo.Text;
            licencia.comentarios = TextBoxComen.Text;
            nego.EditarLicencia(licencia);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxMotivo.Text = "";
            TextBoxComen.Text = "";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            licencia.empleado = DropDownList1.Text;
            nego.EliminarLicencia(licencia);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxMotivo.Text = "";
            TextBoxComen.Text = "";
        }
    }
}