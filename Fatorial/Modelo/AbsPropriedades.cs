using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial.Modelo
{
    public abstract class AbsPropriedades
    {
        private int num;
        public String numero;

        public int Num { get => num; set => num = value; }

        protected AbsPropriedades(int num)
        {
            this.Num = num;
        }

        protected AbsPropriedades(string numero)
        {
            this.numero = numero;
        }
    }
}
