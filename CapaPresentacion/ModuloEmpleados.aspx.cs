using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
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
            RepeaterEmp.DataSource = nego.MostrarEmpleados();
            RepeaterEmp.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            empleado.codigoempleado = TextBoxCodigoE.Text;
            empleado.nombre = TextBoxNombre.Text;
            empleado.apellido = TextBoxApellido.Text;
            empleado.telefono = TextBoxTel.Text;
            empleado.departamento = int.Parse(TextBoxDept.Text);
            empleado.cargo = int.Parse(TextBoxCargo.Text);
            empleado.fecha = Convert.ToDateTime(TextBoxFecha.Text);
            empleado.Estatus = TextBoxEstatus.Text;
            empleado.salario = int.Parse(TextBoxSalario.Text);

            nego.InsertarEmpleado(empleado);

            TextBoxCodigoE.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxTel.Text = "";
            TextBoxDept.Text = "";
            TextBoxCargo.Text = "";
            TextBoxFecha.Text = "";
            TextBoxEstatus.Text = "";
            TextBoxSalario.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Modulo1.aspx");
        }
    }
}