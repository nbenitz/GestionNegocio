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
    
    public partial class serviciohabitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public serviciohabitacion()
        {
            this.detalleocupacion = new HashSet<detalleocupacion>();
            this.habitacion = new HashSet<habitacion>();
        }
    
        public byte idServHab { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> Tiempo { get; set; }
        public Nullable<System.TimeSpan> HraEntrada { get; set; }
        public Nullable<System.TimeSpan> HraSalida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleocupacion> detalleocupacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habitacion> habitacion { get; set; }
    }
}