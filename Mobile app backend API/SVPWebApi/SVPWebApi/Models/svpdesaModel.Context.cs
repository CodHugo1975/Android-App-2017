﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVPWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class svpdesaEntities7 : DbContext
    {
        public svpdesaEntities7()
            : base("name=svpdesaEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Foto> Fotos { get; set; }
        public virtual DbSet<Incidencia> Incidencias { get; set; }
        public virtual DbSet<Legajo> Legajos { get; set; }
        public virtual DbSet<PermisosUsuario> PermisosUsuarios { get; set; }
        public virtual DbSet<Sesione> Sesiones { get; set; }
        public virtual DbSet<SVPPermiso> SVPPermisos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UsuarioSVPMobile> UsuarioSVPMobiles { get; set; }
        public virtual DbSet<UsuarioSVPWeb> UsuarioSVPWebs { get; set; }
        public virtual DbSet<UsuarioSVPWebIncidencia> UsuarioSVPWebIncidencias { get; set; }
    }
}