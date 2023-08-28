using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO_Aula4
{
    public class CartaoDeCredito
    {
        public string Numero { get; set; }
        public string DataDeValidade { get; set; }
        public Cliente Cliente { get; set; } //chamando a classe Cliente (agregação). a classe atual possui
                                             //uma propriedade que referencia um objeto da classe Cliente. 
    }
}
