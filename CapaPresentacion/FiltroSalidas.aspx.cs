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
    public partial class FiltroSalidas : System.Web.UI.Page
    {
        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * from salidas", conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void Buscar()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SET LANGUAGE Spanish; select * from salidas WHERE DATENAME(MONTH,fechasalida) = '" + TextBoxSalida.Text + "'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Buscar();
            TextBoxSalida.Text = "";
        }
    }
}