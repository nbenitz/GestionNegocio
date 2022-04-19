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
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.altaprod = new HashSet<altaprod>();
            this.bajaprod = new HashSet<bajaprod>();
            this.detallecompra = new HashSet<detallecompra>();
            this.detalleventa = new HashSet<detalleventa>();
        }
    
        public string idProducto { get; set; }
        public string idProveedorFK { get; set; }
        public long idCategoriaFk { get; set; }
        public string Descripcion { get; set; }
        public long Costo { get; set; }
        public long Precio1 { get; set; }
        public long Precio2 { get; set; }
        public long Precio3 { get; set; }
        public Nullable<long> PrecioPack { get; set; }
        public string PorPack { get; set; }
        public byte[] Foto { get; set; }
        public byte Iva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<altaprod> altaprod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bajaprod> bajaprod { get; set; }
        public virtual categoria_prod categoria_prod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallecompra> detallecompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleventa> detalleventa { get; set; }
        public virtual proveedor proveedor { get; set; }
    }
}
