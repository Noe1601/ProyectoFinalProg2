using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaPresentacion
{
    public partial class Permisos : System.Web.UI.Page
    {
       

        permisos permiso = new permisos();
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
            permiso.empleado = DropDownList1.Text;
            permiso.desde = Convert.ToDateTime(TextBoxInicio.Text);
            permiso.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            permiso.comentarios = TextBoxComen.Text;

            nego.Permisos(permiso);
            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            permiso.empleado = DropDownList1.Text;
            permiso.desde = Convert.ToDateTime(TextBoxInicio.Text);
            permiso.hasta = Convert.ToDateTime(TextBoxFinal.Text);
            permiso.comentarios = TextBoxComen.Text;
            nego.EditPermiso(permiso);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxComen.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            permiso.empleado = DropDownList1.Text;
            nego.ElimPermiso(permiso);

            TextBoxInicio.Text = "";
            TextBoxFinal.Text = "";
            TextBoxComen.Text = "";
        }
    }
}