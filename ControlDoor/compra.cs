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
    
    public partial class compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra()
        {
            this.detallecompra = new HashSet<detallecompra>();
            this.notaccompra = new HashSet<notaccompra>();
            this.recibopagocuenta = new HashSet<recibopagocuenta>();
        }
    
        public long idCompra { get; set; }
        public string idProveedorFK { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cancelado { get; set; }
        public Nullable<long> Entregado { get; set; }
        public Nullable<System.DateTime> Vto { get; set; }
    
        public virtual proveedor proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallecompra> detallecompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notaccompra> notaccompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recibopagocuenta> recibopagocuenta { get; set; }
    }
}
