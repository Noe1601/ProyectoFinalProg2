using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos
    {
        Finalprogramacion2Entities2 db = new Finalprogramacion2Entities2();
        
        //Departamento
        public void GuardarDept(departamento dept)
        {
            db.departamento.Add(dept);
            db.SaveChanges();
        }

        public void EditarDept(departamento dept)
        {
            var departamentos = db.departamento.First(x => x.id == dept.id);
             departamentos.codigodepartamento = dept.codigodepartamento;
             departamentos.nombre = dept.nombre ;
            db.SaveChanges();
        }

        public void EliminarDept(departamento dept)
        {
            var departamentos = db.departamento.First(x => x.id == dept.id);
            db.departamento.Remove(departamentos);
            db.SaveChanges();
        }

        public List<departamento> MostrarDept()
        {
            return db.departamento.ToList();
        }

        //Cargos

        public void GuardarCargo(cargos cargo)
        {
            db.cargos.Add(cargo);
            db.SaveChanges();
        }

        public void EditarCargos(cargos car)
        {
            var cargos = db.cargos.First(x => x.id == car.id);
            cargos.cargo = car.cargo;
            db.SaveChanges();
        }

        public void EliminarCargo(cargos carg)
        {
            var cargos = db.cargos.First(x => x.id == carg.id);
            db.cargos.Remove(cargos);
            db.SaveChanges();
        }

        public List<cargos> MostrarCargos()
        {
            return db.cargos.ToList();
        }

        // Empleados
        public void GuardarEmpleados(empleados empleado)
        {
            db.empleados.Add(empleado);
            db.SaveChanges();
        }

        public List<empleados> MostrarEmpleados()
        {
            return db.empleados.ToList();
        }

        public void EditarEmpleado(empleados empleado)
        {
            var emple = db.empleados.First(x => x.codigoempleado == empleado.codigoempleado);
            emple.nombre = empleado.nombre;
            emple.apellido = empleado.apellido;
            emple.telefono = empleado.telefono;
            emple.departamento = empleado.departamento;
            emple.cargo = empleado.cargo;
            emple.fecha = emple.fecha;
            emple.Estatus = empleado.Estatus;
            emple.salario = empleado.salario;
            db.SaveChanges();
        }

        public void EliminarEmpleado(empleados emplea)
        {
            var emple = db.empleados.First(x => x.codigoempleado == emplea.codigoempleado);
            db.empleados.Remove(emple);
            db.SaveChanges();
        }

        //Vacaciones

        public void RegistrarVacaciones(vacaciones vaca)
        {
            db.vacaciones.Add(vaca);
            db.SaveChanges();
        }

        public List<vacaciones> MostrarVacaciones()
        {
            return db.vacaciones.ToList();
        }

        //Permisos
        public void RegistroPermiso(permisos permiso)
        {
            db.permisos.Add(permiso);
            db.SaveChanges();
        }

        public List<permisos> MostrarPermisos()
        {
            return db.permisos.ToList();
        }

        //Licencias

        public void RegistrarLicencia(licencias licencia)
        {
            db.licencias.Add(licencia);
            db.SaveChanges();
        }

        public List<licencias> MostarLicencias()
        {
            return db.licencias.ToList();
        }

        // Salidas
        
        public void RegistrarSalida(salidas salida)
        {
            db.salidas.Add(salida);
            db.SaveChanges();
        }

        public List<salidas> MostrarSalidas()
        {
            return db.salidas.ToList();
        }

        // Nomina

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
