//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlDoor
{
    using System;
    using System.Collections.Generic;
    
    public partial class cajamostrador
    {
        public long idCaja { get; set; }
        public byte NroCaja { get; set; }
        public long idEmpleadoFK { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public long MontoInicial { get; set; }
        public Nullable<int> MontoFinal { get; set; }
    
        public virtual empleado empleado { get; set; }
    }
}