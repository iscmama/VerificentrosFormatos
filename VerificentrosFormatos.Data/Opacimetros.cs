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
    
    public partial class Opacimetros
    {
        public int idOpacimetro { get; set; }
        public int idLinea { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public Nullable<System.DateTime> fechaInstalacion { get; set; }
        public string numeroFactura { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioAlta { get; set; }
    
        public virtual Lineas Lineas { get; set; }
    }
}