using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Disco
    {
        public string Titulo { get; set; }

        public DateTime FechaLanzamiento { get; set; } 

        public int CantidadCanciones { get; set; }
        public string UrlimagenTapa {  get; set; }
        public Estilos Estilo { get; set; }
        public TiposEdicion Tipoedicion { get; set; }


    }
}
