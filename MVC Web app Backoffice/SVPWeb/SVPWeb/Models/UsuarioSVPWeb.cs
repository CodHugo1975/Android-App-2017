//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVPWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioSVPWeb
    {
        public int Id { get; set; }
        public int NumeroLegajo { get; set; }
        public string NombreApellido { get; set; }
        public string Contrasenia { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> UltimaModificacion { get; set; }
        public Nullable<int> IdPermisos { get; set; }
    
        public virtual PermisosUsuario PermisosUsuario { get; set; }
    }
}
