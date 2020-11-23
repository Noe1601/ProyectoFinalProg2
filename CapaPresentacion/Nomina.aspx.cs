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
    public partial class Nomina : System.Web.UI.Page
    {
        nomina nomina = new nomina();
        datosnegocio nego = new datosnegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem fecha = new ListItem("2020", "2020");
                ListItem fecha1 = new ListItem("2021", "2021");
                ListItem fecha2 = new ListItem("2022", "2022");
                ListItem fecha3 = new ListItem("2023", "2023");
                DropDownList1.Items.Add(fecha);
                DropDownList1.Items.Add(fecha1);
                DropDownList1.Items.Add(fecha2);
                DropDownList1.Items.Add(fecha3);

                ListItem month = new ListItem("ENERO", "01");
                ListItem month1 = new ListItem("FEBRERO", "02");
                ListItem month2 = new ListItem("MARZO", "03");
                ListItem month3 = new ListItem("ABRIL", "04");
                ListItem month4 = new ListItem("MAYO", "05");
                ListItem month5 = new ListItem("JUNIO", "06");
                ListItem month6 = new ListItem("JULIO", "07");
                ListItem month7 = new ListItem("AGOSTO", "08");
                ListItem month8 = new ListItem("SEPTIEMBRE", "09");
                ListItem month9 = new ListItem("OCTUBRE", "10");
                ListItem month10 = new ListItem("NOVIEMBRE", "11");
                ListItem month11 = new ListItem("DICIEMBRE", "12");
                DropDownList2.Items.Add(month);
                DropDownList2.Items.Add(month1);
                DropDownList2.Items.Add(month2);
                DropDownList2.Items.Add(month3);
                DropDownList2.Items.Add(month4);
                DropDownList2.Items.Add(month5);
                DropDownList2.Items.Add(month6);
                DropDownList2.Items.Add(month7);
                DropDownList2.Items.Add(month8);
                DropDownList2.Items.Add(month9);
                DropDownList2.Items.Add(month10);
                DropDownList2.Items.Add(month11);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            nomina.yearr = int.Parse(DropDownList1.Text);
            nomina.mes = int.Parse(DropDownList2.Text);
            nomina.montototal = null;

            nego.Nominas(nomina);
        }

        protected void BotonAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ModuloProcesos.aspx");
        }
    }
}