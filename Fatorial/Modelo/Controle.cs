using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial.Modelo
{
    public class Controle : AbsPropriedades, intMetodos
    {
        public Controle(string numero) : base(numero)
        {
            Executar();
        }

        public void Executar()
        {
            Validacao validacao = new Validacao(numero);
            if (Estaticos.mensagem.Equals(""))
            {
                Fatorial fatorial = new Fatorial(validacao.Num);
                this.numero = fatorial.Num.ToString();
            }
            
        }
    }
}
