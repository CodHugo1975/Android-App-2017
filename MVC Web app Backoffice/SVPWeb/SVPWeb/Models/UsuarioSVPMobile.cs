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
    
    public partial class UsuarioSVPMobile
    {
        public int Id { get; set; }
        public int NumeroLegajo { get; set; }
        public string Contrasenia { get; set; }
        public string Estado { get; set; }
        public string userUUID { get; set; }
        public Nullable<bool> EsUsuarioWeb { get; set; }
        public Nullable<System.DateTime> UltimaModificacion { get; set; }
        public Nullable<System.DateTime> FechaCreacionUMovil { get; set; }
    }
}
