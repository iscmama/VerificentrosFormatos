using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificentrosFormatos.Bussiness
{
    public class LineasDTO
    {
        public int idLinea { get; set; }
        public string numeroCentro { get; set; }
        public int numero { get; set; }
        public string combustible { get; set; }
        public string tipo { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idUsuarioAlta { get; set; }
    }
}