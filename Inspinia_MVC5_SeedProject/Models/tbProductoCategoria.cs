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
    
    public partial class tbProductoCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProductoCategoria()
        {
            this.tbProductoSubcategoria = new HashSet<tbProductoSubcategoria>();
        }
    
        public int pcat_Id { get; set; }
        public string pcat_Nombre { get; set; }
        public int pcat_UsuarioCrea { get; set; }
        public System.DateTime pcat_FechaCrea { get; set; }
        public Nullable<int> pcat_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pcat_FechaModifica { get; set; }
        public bool pcat_Estado { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria { get; set; }
    }
}
