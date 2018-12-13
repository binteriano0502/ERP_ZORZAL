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
    
    public partial class tbSolicitudEfectivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSolicitudEfectivo()
        {
            this.tbSolicitudEfectivoDetalle = new HashSet<tbSolicitudEfectivoDetalle>();
        }
    
        public int solef_Id { get; set; }
        public int mocja_Id { get; set; }
        public Nullable<bool> solef_EsApertura { get; set; }
        public Nullable<System.DateTime> solef_FechaEntrega { get; set; }
        public Nullable<int> solef_UsuarioEntrega { get; set; }
        public short mnda_Id { get; set; }
        public bool solef_EsAnulada { get; set; }
        public int solef_UsuarioCrea { get; set; }
        public System.DateTime solef_FechaCrea { get; set; }
        public Nullable<int> solef_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> solef_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbMoneda tbMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivoDetalle> tbSolicitudEfectivoDetalle { get; set; }
        public virtual tbUsuario tbUsuario11 { get; set; }
    }
}
