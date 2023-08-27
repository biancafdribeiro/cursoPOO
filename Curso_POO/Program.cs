using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO
{   
    //classe de inicialização
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto da classe Conta
            Conta conta1 = new Conta();  //objeto 1
            Conta conta2 = new Conta(); //objeto 2

            //atribuindo valores aos objetos e suas propriedades
            conta1.Limite = 1000;
            conta1.Numero = 178941;
            conta1.Saldo = 12000;

            conta2.Limite = 2000;
            conta2.Numero = 184569;
            conta2.Saldo = 15000;

            Console.WriteLine("Seu limite é: " + conta1.Limite);
            Console.WriteLine("O número da sua conta é: " + conta1.Numero);
            Console.WriteLine("Seu saldo é: " + conta1.Saldo);
             
            Console.WriteLine("___________________________________________");

            Console.WriteLine("Seu limite é: " + conta2.Limite);
            Console.WriteLine("O número da sua conta é: " + conta2.Numero);
            Console.WriteLine("Seu saldo é: " + conta2.Saldo);

            Console.ReadKey();
        }
    }
}
