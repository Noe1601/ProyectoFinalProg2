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
    public partial class FiltroEmpleados : System.Web.UI.Page
    {
        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * from empleados where Estatus = 'Activo'", conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        void BuscarPorNombre()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SELECT * FROM empleados WHERE nombre = '" + TextBoxNombre.Text + "' and Estatus = 'Activo'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BuscarPorNombre();

        }

        void BuscarPorDepartamento()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SELECT * FROM empleados WHERE departamento = '" + int.Parse(TextBoxDepartamento.Text) + "' and Estatus = 'Activo'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BuscarPorDepartamento();

        }
    }
}