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
    
    public partial class view_pago_membresia
    {
        public int IdPago { get; set; }
        public System.DateTime fecha_pago { get; set; }
        public string NombreCliente { get; set; }
        public string CI { get; set; }
        public string NombreMembresia { get; set; }
        public System.DateTime periodo_inicio { get; set; }
        public Nullable<System.DateTime> periodo_fin { get; set; }
        public int monto { get; set; }
        public int CostoMembresia { get; set; }
        public int Descuento { get; set; }
        public int IdContrato { get; set; }
    }
}
