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
            //Criando um objeto de cada classe
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
        }
    }
}
