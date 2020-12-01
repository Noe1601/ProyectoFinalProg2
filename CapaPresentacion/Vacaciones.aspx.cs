using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class Vacaciones : System.Web.UI.Page
    {
        vacaciones vacacion = new vacaciones();
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
            vacacion.empleado = DropDownList1.Text;
            vacacion.desde = Convert.ToDateTime(TextBoxInicio.Text);
            vacacion.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            vacacion.yearr = Convert.ToDateTime(TextBoxCorre.Text);
            vacacion.comentarios = TextBoxComen.Text;

            nego.Vacaciones(vacacion);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxCorre.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            vacacion.empleado = DropDownList1.Text;
            vacacion.desde = Convert.ToDateTime(TextBoxInicio.Text);
            vacacion.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            vacacion.yearr = Convert.ToDateTime(TextBoxCorre.Text);
            vacacion.comentarios = TextBoxComen.Text;
            nego.EditVacaciones(vacacion);


            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxCorre.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            vacacion.empleado = DropDownList1.Text;
            nego.ElimVacaciones(vacacion);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxCorre.Text = "";
            TextBoxComen.Text = "";

        }
    }
}