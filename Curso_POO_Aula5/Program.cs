using Curso_POO_Aula4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO_Aula4
{   
    //classe de inicialização
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(200);
            Conta conta2 = new Conta(150);
            Conta conta3 = new Conta(100);
            Console.WriteLine("Total de contas é: " + Conta.ContasCriadas);

            int total = Conta.ProximoContasCriadas(); //retornando o método estático
            Console.WriteLine("O próximo total de contas é: " + total);
            Console.ReadKey();
        }
    }
}
