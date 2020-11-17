using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    
    public class datosnegocio
    {
        Datos data = new Datos();
        public void Insertar(departamento depart)
        {
            data.GuardarDept(depart);
        }

        public List<departamento> MostrarDept()
        {
            return data.MostrarDept();
        }

        public void InsertarCargo(cargos cargo)
        {
            data.GuardarCargo(cargo);
        }

        public List<cargos> MostrarCargo()
        {
            return data.MostrarCargos();
        }

        public void InsertarEmpleado(empleados empleado)
        {
            data.GuardarEmpleados(empleado);
        }

        public List<empleados> MostrarEmpleados()
        {
            return data.MostrarEmpleados();
        }

        public void Vacaciones(vacaciones vaca)
        {
            data.RegistrarVacaciones(vaca);
        }

        public List<vacaciones> MostrarVacaciones()
        {
            return data.MostrarVacaciones();
        }

        public void Permisos(permisos permiso)
        {
            data.RegistroPermiso(permiso);
        }

        public List<permisos> MostrarPermiso()
        {
            return data.MostrarPermisos();
        }

        public void Licencia(licencias licencia)
        {
            data.RegistrarLicencia(licencia);
        }

        public List<licencias> MostrarLicencia()
        {
            return data.MostarLicencias();
        }

        public void Salidas(salidas salida)
        {
            data.RegistrarSalida(salida);
        }

        public List<salidas> MostrarSalidas()
        {
            return data.MostrarSalidas();
        }

        public void Nominas(nomina num)
        {
            data.PagoNomina(num);
        }

        public List<nomina> MostrarNomina()
        {
            return data.MostrarNomina();
        }
    }
}
