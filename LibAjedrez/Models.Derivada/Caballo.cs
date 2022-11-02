using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LibAjedrez.Models.Base;

namespace LibAjedrez.Models.Derivada
{
    public abstract class Caballo:PiezaAjedrez
    {
        public override string mover(string nombre)
        {
            return"moviendo Caballo..";
        }
    }
}
