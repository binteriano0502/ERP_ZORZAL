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
    
    public partial class tbEntradaDetalle
    {
        public int entd_Id { get; set; }
        public int ent_Id { get; set; }
        public string prod_Codigo { get; set; }
        public Nullable<decimal> entd_Cantidad { get; set; }
        public int entd_UsuarioCrea { get; set; }
        public System.DateTime entd_FechaCrea { get; set; }
        public Nullable<int> entd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> entd_FechaModifica { get; set; }
    
        public virtual tbEntrada tbEntrada { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
