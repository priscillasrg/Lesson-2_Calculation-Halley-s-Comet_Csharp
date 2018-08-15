using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cometa_Halley.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        protected String resposta;
        protected String ano;
        public Double numeroano;

        public absPropriedades(String ano)
        {
            this.ano = ano;
        }

        public absPropriedades(Double numeroano)
        {
            this.numeroano = numeroano;
        }

        public override string ToString()
        {
            return this.resposta;
        }

        public virtual void Executar ()
        {
        }
    }
}
