using System;
using System.Collections.Generic;
using System.Data;
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

        // Departamentos
        public void Insertar(departamento depart)
        {
            data.GuardarDept(depart);
        }

        public List<departamento> MostrarDept()
        {
            return data.MostrarDept();
        }

        //public departamento ObtenerDepto(int id)
        //{
        //    return data.ObtenerDepto(id);
        //}

        public void Editar(departamento dept)
        {
            data.EditarDept(dept);
        }

        public void Eliminar(departamento dept)
        {
            data.EliminarDept(dept);
        }

        //Cargos
        public void InsertarCargo(cargos cargo)
        {
            data.GuardarCargo(cargo);
        }

        public List<cargos> MostrarCargo()
        {
            return data.MostrarCargos();
        }

        public void EditarCargo(cargos cargo)
        {
            data.EditarCargos(cargo);
        }

        public void EliminarCargo(cargos cargo)
        {
            data.EliminarCargo(cargo);
        }

        //Empleados
        public void InsertarEmpleado(empleados empleado)
        {
            data.GuardarEmpleados(empleado);
        }

        public List<empleados> MostrarEmpleados()
        {
            return data.MostrarEmpleados();
        }

        public void EditarEmpleado(empleados empleado)
        {
            data.EditarEmpleado(empleado);
        }

        public void EliminarEmpleado(empleados empleado)
        {
            data.EliminarEmpleado(empleado);
        }

        //Vacaciones

        public void Vacaciones(vacaciones vaca)
        {
            data.RegistrarVacaciones(vaca);
        }

        public void EditVacaciones(vacaciones vaca)
        {
            data.EditarVacaciones(vaca);
        }

        public void ElimVacaciones(vacaciones vaca)
        {
            data.EliminarVacaciones(vaca);
        }

        public List<vacaciones> MostrarVacaciones()
        {
            return data.MostrarVacaciones();
        }

        //Permisos
        public void Permisos(permisos permiso)
        {
            data.RegistroPermiso(permiso);
        }

        public void EditPermiso(permisos permiso)
        {
            data.EditarPermiso(permiso);
        }

        public void ElimPermiso(permisos permiso)
        {
            data.EliminarPermiso(permiso);
        }

        public List<permisos> MostrarPermiso()
        {
            return data.MostrarPermisos();
        }

        // Licencias
        public void Licencia(licencias licencia)
        {
            data.RegistrarLicencia(licencia);
        }

        public void EditarLicencia(licencias licencia)
        {
            data.EditarLicencia(licencia);
        }

        public void EliminarLicencia(licencias licencia)
        {
            data.EliminarLicencia(licencia);
        }

        public List<licencias> MostrarLicencia()
        {
            return data.MostarLicencias();
        }

        // Salidas
        public void Salidas(salidas salida)
        {
            data.RegistrarSalida(salida);
        }

        public void EditSalidas(salidas salida)
        {
            data.EditarSalida(salida);
        }

        public void ElimSalida(salidas salida)
        {
            data.EliminarSalida(salida);
        }

        public List<salidas> MostrarSalidas()
        {
            return data.MostrarSalidas();
        }

        // Nominas
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
