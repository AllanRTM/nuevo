//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kielb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KB_CuadroBasicoA
    {
        public int factura_id { get; set; }
        public short Suc_Id { get; set; }
        public short Caja_Id { get; set; }
        public Nullable<decimal> total_cuadro { get; set; }
        public int Vendedor_Id { get; set; }
        public System.DateTime factura_fecha { get; set; }
    }
}
