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
    
    public partial class tbTipoIdentificacion
    {
        public byte tpi_Id { get; set; }
        public string tpi_Descripcion { get; set; }
        public int tpi_UsuarioCrea { get; set; }
        public System.DateTime tpi_FechaCrea { get; set; }
        public Nullable<int> tpi_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tpi_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
