//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbParametro
    {
        public byte par_Id { get; set; }
        public string par_NombreEmpresa { get; set; }
        public string par_TelefonoEmpresa { get; set; }
        public string par_CorreoEmpresa { get; set; }
        public string par_PathLogo { get; set; }
        public short mnda_Id { get; set; }
        public int par_RolGerenteTienda { get; set; }
        public int par_RolCreditoCobranza { get; set; }
        public int par_RolSupervisorCaja { get; set; }
        public int par_RolCajero { get; set; }
        public int par_RolAuditor { get; set; }
        public short par_SucursalPrincipal { get; set; }
        public int par_UsuarioCrea { get; set; }
        public System.DateTime par_FechaCrea { get; set; }
        public Nullable<int> par_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> par_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbMoneda tbMoneda { get; set; }
    }
}
