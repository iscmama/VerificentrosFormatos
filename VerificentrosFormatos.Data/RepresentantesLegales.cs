//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VerificentrosFormatos.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepresentantesLegales
    {
        public int idRepresentanteLegal { get; set; }
        public int idVerificentro { get; set; }
        public string nombres { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioAlta { get; set; }
    
        public virtual Verificentros Verificentros { get; set; }
    }
}
