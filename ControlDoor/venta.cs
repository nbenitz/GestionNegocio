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
    
    public partial class venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venta()
        {
            this.detalleocupacion = new HashSet<detalleocupacion>();
            this.detalleventa = new HashSet<detalleventa>();
            this.notacventa = new HashSet<notacventa>();
            this.ocupacionmanual = new HashSet<ocupacionmanual>();
            this.recibocobrocuenta = new HashSet<recibocobrocuenta>();
        }
    
        public long idVenta { get; set; }
        public long idEmpleadoFK { get; set; }
        public string idClienteFK { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cancelado { get; set; }
        public Nullable<long> Entregado { get; set; }
        public Nullable<System.DateTime> Vto { get; set; }
        public string PagoComision { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleocupacion> detalleocupacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleventa> detalleventa { get; set; }
        public virtual empleado empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notacventa> notacventa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ocupacionmanual> ocupacionmanual { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recibocobrocuenta> recibocobrocuenta { get; set; }
    }
}