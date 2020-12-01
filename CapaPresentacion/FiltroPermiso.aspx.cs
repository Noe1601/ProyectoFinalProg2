using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class FiltroPermiso : System.Web.UI.Page
    {

        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * from permisos", conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();

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

        void BuscarPorNombre()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SET LANGUAGE Spanish; select * from permisos WHERE empleado = '" + DropDownList1.Text + "' and Estatus='Activo'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BuscarPorNombre();
        }
    }
}