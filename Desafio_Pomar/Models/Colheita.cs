using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Pomar.Models
{
    class Colheita
    {
        public long? IDColheita { get; set; }
        public string Informacao { get; set; }
        public string DataColheita { get; set; }
        public Decimal Peso { get; set; }
        public long? TipoArvore { get; set; }
    }
}
