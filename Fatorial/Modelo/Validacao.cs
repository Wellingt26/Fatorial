using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial.Modelo
{
    class Validacao : AbsPropriedades, intMetodos
    {
        public Validacao(string numero) : base(numero)
        {
            Executar();
        }

        public void Executar()
        {
            Estaticos.mensagem = "";
            try
            {
                this.Num = Convert.ToInt32(numero);
            }
            catch (Exception)
            {
                Estaticos.mensagem = "Número inválido";
            }

        }
    }
}
