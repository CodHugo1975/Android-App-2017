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
    
    public partial class Sesione
    {
        public int Id { get; set; }
        public int LegajoId { get; set; }
        public System.DateTime Inicio { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }
        public string Observaciones { get; set; }
    }
}
