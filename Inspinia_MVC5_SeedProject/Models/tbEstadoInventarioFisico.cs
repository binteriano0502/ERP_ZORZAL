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
    
    public partial class tbEstadoInventarioFisico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEstadoInventarioFisico()
        {
            this.tbInventarioFisico = new HashSet<tbInventarioFisico>();
        }
    
        public byte estif_Id { get; set; }
        public string estif_Descripcion { get; set; }
        public int estif_UsuarioCrea { get; set; }
        public System.DateTime estif_FechaCrea { get; set; }
        public Nullable<int> estif_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> estif_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisico> tbInventarioFisico { get; set; }
    }
}
