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


            /* //Criando um objeto de cada classe
            Cliente objetocliente = new Cliente();
            CartaoDeCredito objetocartao = new CartaoDeCredito();

            //Adicionando as informações 
            objetocliente.Nome = "Bianca Ribeiro";
            objetocartao.Numero = "123456";
            objetocartao.DataDeValidade = "12/05/2025";

            //Fazendo a agregação
            objetocartao.Cliente = objetocliente; //significa que o cartão representado por objetocartao
                                                  //está associado ao cliente representado pelo objeto
                                                  //objetocliente, que é da classe Cliente

            Console.WriteLine("O nome do cliente é: " + objetocliente.Nome);
            Console.WriteLine("O número do cartão é: " + objetocartao.Numero);
            Console.WriteLine("A data de validade é: " + objetocartao.Numero);
            Console.WriteLine("O nome do cliente do agregado é: " + objetocartao.Cliente.Nome);

            Console.ReadKey();




            criando um objeto da classe Conta
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
            Console.ReadKey();*/
        }
    }
}
