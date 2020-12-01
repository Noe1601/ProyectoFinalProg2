using CapaEntidad;
using CapaNegocio;
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
    public partial class ModuloEmpleados : System.Web.UI.Page
    {
        empleados empleado = new empleados();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem primero = new ListItem("Activo", "Activo");
                ListItem segundo = new ListItem("Inactivo", "Inactivo");
                DropDownList1.Items.Add(primero);
                DropDownList1.Items.Add(segundo);

                CargarDepartamento();
                CargarCargos();
            }
        }

        public void CargarDepartamento()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "CARGARDEPARTAMENTO";
                comando.Connection = conexion;
                conexion.Open();
                DropDownList2.DataSource = comando.ExecuteReader();
                DropDownList2.DataTextField = "ID";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }

        public void CargarCargos()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QJ659VTB\\SQLEXPRESS01;Initial Catalog=Finalprogramacion2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "CARGARCARGOS";
                comando.Connection = conexion;
                conexion.Open();
                DropDownList3.DataSource = comando.ExecuteReader();
                DropDownList3.DataTextField = "ID";
                DropDownList3.DataValueField = "ID";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            empleado.codigoempleado = TextBoxCodigoE.Text;
            empleado.nombre = TextBoxNombre.Text;
            empleado.apellido = TextBoxApellido.Text;
            empleado.telefono = TextBoxTel.Text;
            empleado.departamento = int.Parse(DropDownList2.Text);
            empleado.cargo = int.Parse(DropDownList3.Text);
            empleado.fecha = Convert.ToDateTime(TextBoxFecha.Text);
            empleado.Estatus = DropDownList1.Text;
            empleado.salario = int.Parse(TextBoxSalario.Text);

            nego.InsertarEmpleado(empleado);

            TextBoxCodigoE.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxTel.Text = "";
            TextBoxFecha.Text = "";
            TextBoxSalario.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            empleado.codigoempleado = TextBoxCodigoE.Text;
            nego.EliminarEmpleado(empleado);
            TextBoxCodigoE.Text = "";
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            empleado.codigoempleado = TextBoxCodigoE.Text;
            empleado.nombre = TextBoxNombre.Text;
            empleado.apellido = TextBoxApellido.Text;
            empleado.telefono = TextBoxTel.Text;
            empleado.departamento = int.Parse(DropDownList2.Text);
            empleado.cargo = int.Parse(DropDownList3.Text);
            empleado.fecha = Convert.ToDateTime(TextBoxFecha.Text);
            empleado.Estatus = DropDownList1.Text;
            empleado.salario = int.Parse(TextBoxSalario.Text);

            nego.EditarEmpleado(empleado);

            TextBoxCodigoE.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxTel.Text = "";
            TextBoxFecha.Text = "";
            TextBoxSalario.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FiltroEmpleados.aspx");
        }
    }
}