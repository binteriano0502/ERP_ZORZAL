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
    
    public partial class tbEstadoMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEstadoMovimiento()
        {
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbProductoSubcategoria = new HashSet<tbProductoSubcategoria>();
            this.tbSalida = new HashSet<tbSalida>();
        }
    
        public byte estm_Id { get; set; }
        public string estm_Descripcion { get; set; }
        public int estm_UsuarioCrea { get; set; }
        public System.DateTime estm_FechaCrea { get; set; }
        public Nullable<int> estm_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> estm_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
