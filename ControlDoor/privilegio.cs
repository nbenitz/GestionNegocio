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
    
    public partial class privilegio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public privilegio()
        {
            this.usuario = new HashSet<usuario>();
        }
    
        public long idPrivilegio { get; set; }
        public string Rol { get; set; }
        public bool ProdConsult { get; set; }
        public bool ProdReg { get; set; }
        public bool ProdActualiz { get; set; }
        public bool ProdEliminar { get; set; }
        public bool VentasConsult { get; set; }
        public bool VentasReg { get; set; }
        public bool ComprasConsult { get; set; }
        public bool ComprasReg { get; set; }
        public bool ProvConsult { get; set; }
        public bool ProvReg { get; set; }
        public bool ProvActualiz { get; set; }
        public bool ProvEliminar { get; set; }
        public bool EmpleAdmin { get; set; }
        public bool UsuAdmin { get; set; }
        public bool FinanzasAdmin { get; set; }
        public bool HabAdmin { get; set; }
        public bool CuentasAdmin { get; set; }
        public bool DevolAutoriCli { get; set; }
        public bool DevolAutoriProv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario { get; set; }
    }
}