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
    
    public partial class tbSalida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSalida()
        {
            this.tbSalidaDetalle = new HashSet<tbSalidaDetalle>();
            this.tbEntrada = new HashSet<tbEntrada>();
        }
    
        public int sal_Id { get; set; }
        public int bod_Id { get; set; }
        public long fact_Id { get; set; }
        public System.DateTime sal_FechaElaboracion { get; set; }
        public byte estm_Id { get; set; }
        public byte tsal_Id { get; set; }
        public string sal_RazonDevolucion { get; set; }
        public int sal_UsuarioCrea { get; set; }
        public System.DateTime sal_FechaCrea { get; set; }
        public Nullable<int> sal_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> sal_FechaModifica { get; set; }
        public int sal_BodDestino { get; set; }
        public bool sal_EsAnulada { get; set; }
        public string sal_RazonAnulada { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbBodega tbBodega { get; set; }
        public virtual tbEstadoMovimiento tbEstadoMovimiento { get; set; }
        public virtual tbFactura tbFactura { get; set; }
        public virtual tbTipoSalida tbTipoSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalidaDetalle> tbSalidaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        public virtual tbBodega tbBodega1 { get; set; }
    }
}
