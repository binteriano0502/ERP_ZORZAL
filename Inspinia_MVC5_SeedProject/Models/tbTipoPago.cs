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
    
    public partial class tbTipoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoPago()
        {
            this.tbPagosArqueo = new HashSet<tbPagosArqueo>();
            this.tbPago = new HashSet<tbPago>();
        }
    
        public short tpa_Id { get; set; }
        public string tpa_Descripcion { get; set; }
        public bool tpa_Emisor { get; set; }
        public bool tpa_Cuenta { get; set; }
        public bool tpa_FechaVencimiento { get; set; }
        public bool tpa_Titular { get; set; }
        public int tpa_UsuarioCrea { get; set; }
        public System.DateTime tpa_FechaCrea { get; set; }
        public Nullable<int> tpa_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tpa_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPagosArqueo> tbPagosArqueo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPago> tbPago { get; set; }
    }
}
