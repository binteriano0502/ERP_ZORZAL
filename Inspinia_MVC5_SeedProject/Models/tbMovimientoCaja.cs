//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMovimientoCaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbMovimientoCaja()
        {
            this.tbDenominacionArqueo = new HashSet<tbDenominacionArqueo>();
            this.tbSolicitudEfectivo = new HashSet<tbSolicitudEfectivo>();
        }
    
        public int mocja_Id { get; set; }
        public short cja_Id { get; set; }
        public System.DateTime mocja_FechaApertura { get; set; }
        public Nullable<int> mocja_UsuarioApertura { get; set; }
        public System.DateTime mocja_FechaArqueo { get; set; }
        public Nullable<int> mocja_UsuarioArquea { get; set; }
        public System.DateTime mocja_FechaAceptacion { get; set; }
        public Nullable<int> mocja_UsuarioAceptacion { get; set; }
        public Nullable<int> mocja_UsuarioCrea { get; set; }
        public System.DateTime mocja_FechaCrea { get; set; }
        public Nullable<int> mocja_UsuarioModifica { get; set; }
        public System.DateTime mocja_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCaja tbCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacionArqueo> tbDenominacionArqueo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivo> tbSolicitudEfectivo { get; set; }
        public virtual tbUsuario tbUsuario2 { get; set; }
        public virtual tbUsuario tbUsuario11 { get; set; }
        public virtual tbUsuario tbUsuario21 { get; set; }
    }
}
