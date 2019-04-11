using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial.Modelo
{
    class Fatorial : AbsPropriedades, intMetodos
    {
        public Fatorial(int num) : base(num)
        {
            
            Executar();
        }

        public void Executar()
        {
            for (int i = Num - 1; i >= 1; i--)
            {
                this.Num = this.Num * i;
            }
        }
    }
}
