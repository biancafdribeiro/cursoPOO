using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO_Aula2
{   
    //classe de inicialização
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto da classe Conta
            Conta conta1 = new Conta(3);  //objeto 1

            conta1.AdicionarLimite(1500);

            conta1.Deposita(1500); //depositando valores
            conta1.Deposita(200);
            conta1.Sacar(600);

            bool saca = conta1.Sacar(10000);

            if(saca) //saca é uma variável booleana que armazena o resultado do método Sacar
            {
            double saldo = conta1.ConsultaSaldo(); //vai chamar o objeto e retornar o saldo
            Console.WriteLine("Seu saldo é: " + saldo);
            Console.WriteLine("Seu limite é: " + conta1.Limite);
            }

            Console.WriteLine("O número da conta é: " + conta1.Numero);
            Console.ReadKey();
        }
    }
}
