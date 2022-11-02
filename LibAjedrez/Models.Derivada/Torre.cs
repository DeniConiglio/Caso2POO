using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Derivada
{
    public abstract class Torre : PiezaAjedrez
    {
        public override string mover(string nombre)
        {
            return "moviendo Torre..";
        }
    }
}
