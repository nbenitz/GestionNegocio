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
    
    public partial class pedidoc
    {
        public long idPedido { get; set; }
        public string idProveedor { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaRecibo { get; set; }
        public string Estado { get; set; }
    
        public virtual proveedor proveedor { get; set; }
    }
}