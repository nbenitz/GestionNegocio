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
    
    public partial class ocupacionsensor
    {
        public long idOcupacion { get; set; }
        public byte NroHabitacion { get; set; }
        public System.DateTime HraEntrada { get; set; }
        public Nullable<System.DateTime> HraSalida { get; set; }
    
        public virtual habitacion2 habitacion2 { get; set; }
    }
}
