using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos
    {
        Finalprogramacion2Entities2 db = new Finalprogramacion2Entities2();
        
        public void GuardarDept(departamento dept)
        {
            db.departamento.Add(dept);
            db.SaveChanges();
        }

        public List<departamento> MostrarDept()
        {
            return db.departamento.ToList();
        }

        public void GuardarCargo(cargos cargo)
        {
            db.cargos.Add(cargo);
            db.SaveChanges();
        }

        public List<cargos> MostrarCargos()
        {
            return db.cargos.ToList();
        }

        public void GuardarEmpleados(empleados empleado)
        {
            db.empleados.Add(empleado);
            db.SaveChanges();
        }

        public List<empleados> MostrarEmpleados()
        {
            return db.empleados.ToList();
        }

        public void RegistrarVacaciones(vacaciones vaca)
        {
            db.vacaciones.Add(vaca);
            db.SaveChanges();
        }

        public List<vacaciones> MostrarVacaciones()
        {
            return db.vacaciones.ToList();
        }

        public void RegistroPermiso(permisos permiso)
        {
            db.permisos.Add(permiso);
            db.SaveChanges();
        }

        public List<permisos> MostrarPermisos()
        {
            return db.permisos.ToList();
        }

        public void RegistrarLicencia(licencias licencia)
        {
            db.licencias.Add(licencia);
            db.SaveChanges();
        }

        public List<licencias> MostarLicencias()
        {
            return db.licencias.ToList();
        }
        
        public void RegistrarSalida(salidas salida)
        {
            db.salidas.Add(salida);
            db.SaveChanges();
        }

        public List<salidas> MostrarSalidas()
        {
            return db.salidas.ToList();
        }

        public void PagoNomina(nomina nom)
        {
            db.nomina.Add(nom);
            db.SaveChanges();
        }

        public List<nomina> MostrarNomina()
        {
            return db.nomina.ToList();
        }

    }
}
