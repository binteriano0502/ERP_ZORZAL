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
    
    public partial class tbEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEntrada()
        {
            this.tbEntradaDetalle = new HashSet<tbEntradaDetalle>();
        }
    
        public int ent_Id { get; set; }
        public string ent_NumeroFormato { get; set; }
        public System.DateTime ent_FechaElaboracion { get; set; }
        public int bod_Id { get; set; }
        public byte estm_Id { get; set; }
        public int prov_Id { get; set; }
        public string ent_FacturaCompra { get; set; }
        public Nullable<System.DateTime> ent_FechaCompra { get; set; }
        public Nullable<int> fact_Id { get; set; }
        public string ent_RazonDevolucion { get; set; }
        public Nullable<int> ent_BodegaDestino { get; set; }
        public byte tent_Id { get; set; }
        public int ent_SalidaOrigen { get; set; }
        public int ent_UsuarioCrea { get; set; }
        public System.DateTime ent_FechaCrea { get; set; }
        public Nullable<int> ent_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> ent_FechaModifica { get; set; }
        public Nullable<bool> entd_EsAnulada { get; set; }
        public string entd_RazonAnulada { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbBodega tbBodega { get; set; }
        public virtual tbBodega tbBodega1 { get; set; }
        public virtual tbEstadoMovimiento tbEstadoMovimiento { get; set; }
        public virtual tbProveedor tbProveedor { get; set; }
        public virtual tbSalida tbSalida { get; set; }
        public virtual tbTipoEntrada tbTipoEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntradaDetalle> tbEntradaDetalle { get; set; }
    }
}
