using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            ////SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Finalprogramacion2Entities2"].ToString());
            //conexion.Open();
            //string consulta = "SELECT COUNT(*) FROM departamento WHERE codigodepartamento='" + TextBoxUsuario + "' ";
            //SqlCommand comando = new SqlCommand(consulta, conexion);
            //SqlDataReader dr = comando.ExecuteReader();
            if (TextBoxUsuario.Text == "admin" && TextBoxPassword.Text == "admin" )
            {
                Response.Redirect("~/PaginaPrincipal.aspx");
            }
            else
            {
                Response.Write("Usuario o password incorrecto");
            }
        }
    }
}