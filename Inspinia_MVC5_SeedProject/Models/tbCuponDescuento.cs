//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCuponDescuento
    {
        public int cdto_ID { get; set; }
        public short suc_Id { get; set; }
        public System.DateTime cdto_FechaEmision { get; set; }
        public System.DateTime cdto_FechaVencimiento { get; set; }
        public Nullable<decimal> cdto_PorcentajeDescuento { get; set; }
        public Nullable<decimal> cdto_MontoDescuento { get; set; }
        public decimal cdto_MaximoMontoDescuento { get; set; }
        public bool cdto_Redimido { get; set; }
        public Nullable<bool> cdto_Anulado { get; set; }
        public int cdto_UsuarioCrea { get; set; }
        public System.DateTime cdto_FechaCrea { get; set; }
        public Nullable<int> cdto_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cdto_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbSucursal tbSucursal { get; set; }
    }
}
