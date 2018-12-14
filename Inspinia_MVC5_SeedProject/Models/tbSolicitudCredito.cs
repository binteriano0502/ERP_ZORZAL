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
    
    public partial class tbSolicitudCredito
    {
        public int cred_Id { get; set; }
        public int clte_Id { get; set; }
        public byte escre_Id { get; set; }
        public System.DateTime cred_FechaSolicitud { get; set; }
        public System.DateTime cred_FechaAprobacion { get; set; }
        public decimal cred_MontoSolicitado { get; set; }
        public decimal cred_MontoAprobado { get; set; }
        public int cred_DiasSolicitado { get; set; }
        public int cred_DiasAprobado { get; set; }
        public int cred_UsuarioCrea { get; set; }
        public System.DateTime cred_FechaCrea { get; set; }
        public Nullable<int> cred_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cred_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbEstadoSolicitudCredito tbEstadoSolicitudCredito { get; set; }
    }
}
