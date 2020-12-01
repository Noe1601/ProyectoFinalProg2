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

            if (!IsPostBack)
            {

                ListItem month = new ListItem("ENERO", "Enero");
                ListItem month1 = new ListItem("FEBRERO", "Febrero");
                ListItem month2 = new ListItem("MARZO", "Marzo");
                ListItem month3 = new ListItem("ABRIL", "Abril");
                ListItem month4 = new ListItem("MAYO", "Mayo");
                ListItem month5 = new ListItem("JUNIO", "Junio");
                ListItem month6 = new ListItem("JULIO", "Julio");
                ListItem month7 = new ListItem("AGOSTO", "Agosto");
                ListItem month8 = new ListItem("SEPTIEMBRE", "Septiembre");
                ListItem month9 = new ListItem("OCTUBRE", "Octubre");
                ListItem month10 = new ListItem("NOVIEMBRE", "Noviembre");
                ListItem month11 = new ListItem("DICIEMBRE", "Diciembre");
                DropDownList1.Items.Add(month);
                DropDownList1.Items.Add(month1);
                DropDownList1.Items.Add(month2);
                DropDownList1.Items.Add(month3);
                DropDownList1.Items.Add(month4);
                DropDownList1.Items.Add(month5);
                DropDownList1.Items.Add(month6);
                DropDownList1.Items.Add(month7);
                DropDownList1.Items.Add(month8);
                DropDownList1.Items.Add(month9);
                DropDownList1.Items.Add(month10);
                DropDownList1.Items.Add(month11);
            }

        }

        void BuscarPorMes()
        {
            SqlDataAdapter ap = new SqlDataAdapter("SET LANGUAGE Spanish; select * from empleados WHERE DATENAME(MONTH,fecha) = '" + DropDownList1.Text+"'", conexion);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BuscarPorMes();

        }
    }
}