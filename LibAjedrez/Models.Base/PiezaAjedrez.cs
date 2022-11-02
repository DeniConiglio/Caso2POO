using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Base
{
    public abstract class PiezaAjedrez
    {
        public string Nombre { get; set; }
        public abstract string mover(string nombre);
    }
}
