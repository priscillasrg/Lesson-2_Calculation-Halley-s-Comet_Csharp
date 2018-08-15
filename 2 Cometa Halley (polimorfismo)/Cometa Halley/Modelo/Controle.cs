using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cometa_Halley.Modelo
{
   public class Controle: absPropriedades
    {
        public Controle (String ano): base(ano)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(this.ano);

            if(validacao.mensagem.Equals(""))
            {
                absPropriedades calculos = new Calculos(validacao.numeroano);
                this.resposta = calculos.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
