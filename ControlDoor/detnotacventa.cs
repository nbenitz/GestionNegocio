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
    
    public partial class detnotacventa
    {
        public long idNotaFK { get; set; }
        public long idVentaFK { get; set; }
        public string idProductoFK { get; set; }
        public Nullable<int> Unidades { get; set; }
    
        public virtual detalleventa detalleventa { get; set; }
        public virtual notacventa notacventa { get; set; }
    }
}
