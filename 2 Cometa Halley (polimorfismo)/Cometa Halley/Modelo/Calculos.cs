using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cometa_Halley.Modelo
{
    public class Calculos: absPropriedades
    {
        public Calculos (Double numeroano): base (numeroano)
        {
            Executar();
        }

        public override void Executar()
        {
         
            if (this.numeroano < 1910)
            {
                this.resposta = ("Ops... nessa época não tinha tecnologia para detecção!!\n" +
                    "\nTente novamente").ToString();                
            }
            if (this.numeroano >= 1910 && this.numeroano <= 1985)
            {
                this.resposta = "O cometa Halley passou há: \n" + 
                    (this.numeroano - 1910).ToString() + " anos \n" +
                     "\nO cometa Halley vai passar em: \n" 
                     + (1985 - this.numeroano).ToString() + " anos";   
            }
            if (this.numeroano >= 1985 && this.numeroano <= 2061)
            {
                this.resposta = "O cometa Halley passou há: \n" +
                    (this.numeroano - 1985).ToString() + " anos \n" +
                     "\nO cometa Halley vai passar em: \n"
                     + (2061 - this.numeroano).ToString() + " anos";    
                
            }
            if (this.numeroano > 2061)
            {
                this.resposta = ("Otimista !!! Será que você  \n estará vivo para saber? ").ToString();
            }
            
        }
    }
}
