using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cometa_Halley.Modelo
{
    public class Validacao: absPropriedades
    {
        public Validacao (String ano): base (ano)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.numeroano = Convert.ToDouble(this.ano);
            }
            catch(FormatException e)
            {
                this.mensagem = "Erro: informe o ano";
            }

            
           
        }
    }
}
