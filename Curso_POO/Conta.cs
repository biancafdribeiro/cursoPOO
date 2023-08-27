using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO
{
    public class Conta //para conseguir chamar a classe precisa ser public
    {
        //definindo atributos/propriedades 
        public double Saldo { get; set; } //get obtém o valor de uma propriedade e o retorna
        public double  Limite { get; set; } //set atribui o valor a uma propriedade
        public int Numero { get; set; }
    }   
}
