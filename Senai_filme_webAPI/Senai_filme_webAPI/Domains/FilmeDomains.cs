using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_filme_webAPI.Domains
{
    public class FilmeDomains
    {

        public int idFilme { get; set; }
        public int idGenero{ get; set; }
        public string tituloFilme{ get; set; }
        public GeneroDomain genero { get; set; }
    }

}
