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
    
    public partial class tbListaPrecio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbListaPrecio()
        {
            this.tbProducto = new HashSet<tbProducto>();
        }
    
        public int listp_Id { get; set; }
        public string listp_Nombre { get; set; }
        public Nullable<bool> listp_EsActivo { get; set; }
        public int listp_UsuarioCrea { get; set; }
        public System.DateTime listp_FechaCrea { get; set; }
        public Nullable<int> listp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> listp_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbListadoPrecioDetalle tbListadoPrecioDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
    }
}
