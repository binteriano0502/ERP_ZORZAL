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
    
    public partial class SDP_Acce_GetUserRols_Result
    {
        public int rolu_Id { get; set; }
        public int rol_Id { get; set; }
        public int usu_Id { get; set; }
        public int rolu_UsuarioCrea { get; set; }
        public System.DateTime rolu_FechaCrea { get; set; }
        public Nullable<int> rolu_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rolu_FechaModifica { get; set; }
        public int acrol_Id { get; set; }
        public int obj_Id { get; set; }
        public int acrol_UsuarioCrea { get; set; }
        public System.DateTime acrol_FechaCrea { get; set; }
        public Nullable<int> acrol_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> acrol_FechaModifica { get; set; }
        public string obj_Pantalla { get; set; }
        public int obj_UsuarioCrea { get; set; }
        public System.DateTime obj_FechaCrea { get; set; }
        public Nullable<int> obj_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> obj_FechaModifica { get; set; }
        public bool obj_Estado { get; set; }
    }
}
