﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERP_ZORZALEntities : DbContext
    {
        public ERP_ZORZALEntities()
            : base("name=ERP_ZORZALEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbEstados> tbEstados { get; set; }
        public virtual DbSet<tbCajas> tbCajas { get; set; }
        public virtual DbSet<tbDepartamentos> tbDepartamentos { get; set; }
        public virtual DbSet<tbLineasPago> tbLineasPago { get; set; }
        public virtual DbSet<tbMonedas> tbMonedas { get; set; }
        public virtual DbSet<tbMunicipios> tbMunicipios { get; set; }
        public virtual DbSet<tbTiposDocumento> tbTiposDocumento { get; set; }
        public virtual DbSet<tbTiposPago> tbTiposPago { get; set; }
        public virtual DbSet<tbCargos> tbCargos { get; set; }
        public virtual DbSet<tbTasasCambio> tbTasasCambio { get; set; }
        public virtual DbSet<tbTiposBodega> tbTiposBodega { get; set; }
        public virtual DbSet<tbTiposEntrada> tbTiposEntrada { get; set; }
        public virtual DbSet<tbTiposInventario> tbTiposInventario { get; set; }
        public virtual DbSet<tbTiposSalida> tbTiposSalida { get; set; }
        public virtual DbSet<tbUnidadesMedida> tbUnidadesMedida { get; set; }
        public virtual DbSet<tbCategoria> tbCategoria { get; set; }
        public virtual DbSet<tbSubcategoria> tbSubcategoria { get; set; }
    }
}
