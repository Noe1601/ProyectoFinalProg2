//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleados
    {
        public int id { get; set; }
        public string codigoempleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public Nullable<int> departamento { get; set; }
        public Nullable<int> cargo { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string Estatus { get; set; }
        public int salario { get; set; }
    
        public virtual cargos cargos { get; set; }
        public virtual departamento departamento1 { get; set; }
    }
}
