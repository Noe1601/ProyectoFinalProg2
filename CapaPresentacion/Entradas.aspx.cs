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
    public partial class Entradas : System.Web.UI.Page
    {
        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * from empleados", conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void BuscarPorMes()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SET LANGUAGE Spanish; select * from empleados WHERE DATENAME(MONTH,fecha) = '" + TextBoxMes.Text+"'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BuscarPorMes();
            TextBoxMes.Text = "";
        }
    }
}