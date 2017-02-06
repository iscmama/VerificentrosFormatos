using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificentrosFormatos.Bussiness
{
    public class VerificentrosDTO
    {
        public int idVerificentro { get; set; }
        public string numeroCentro { get; set; }
        public string razonSocial { get; set; }
        public string siglas { get; set; }
        public int total { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioAlta { get; set; }
        public virtual ICollection<LineasDTO> Lineas { get; set; }
    }
}