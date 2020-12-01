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
    public partial class Salida : System.Web.UI.Page
    {
        salidas salir = new salidas();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarNombre();
                ListItem primero = new ListItem("Renuncia", "Renuncia");
                ListItem segundo = new ListItem("Despido", "Despido");
                ListItem tercero = new ListItem("Deshaucio", "Deshaucio");

                DropDownList1.Items.Add(primero);
                DropDownList1.Items.Add(segundo);
                DropDownList1.Items.Add(tercero);
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
                DropDownList2.DataSource = comando.ExecuteReader();
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataValueField = "nombre";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            salir.empleado = DropDownList2.Text;
            salir.tiposalida = TextBoxMotivo.Text;
            salir.motivo = DropDownList1.Text;
            salir.fechasalida = Convert.ToDateTime(TextBoxFecha.Text);

            nego.Salidas(salir);

            TextBoxMotivo.Text = "";
            TextBoxFecha.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            salir.empleado = DropDownList2.Text;
            salir.tiposalida = DropDownList1.Text;
            salir.motivo = DropDownList1.Text;
            salir.fechasalida = Convert.ToDateTime(TextBoxFecha.Text);
            nego.EditSalidas(salir);

            TextBoxMotivo.Text = "";
            TextBoxFecha.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            salir.empleado = DropDownList2.Text;
            nego.ElimSalida(salir);


            TextBoxMotivo.Text = "";
            TextBoxFecha.Text = "";
        }
    }
}