using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO_Aula2
{
    public class Conta //para conseguir chamar a classe precisa ser public
    {
        //definindo atributos/propriedades 
        private double Saldo { get; set; } //get obtém o valor de uma propriedade e o retorna
        public double  Limite { get; private set; } /*set atribui o valor a uma propriedade; colocar private significa que 
                                                     apenas a classe Conta tem a liberdade de atribuir o valor através do 
                                                     método (não é possível fazer conta.saldo = 10, por exemplo)*/
        public int Numero { get; set; }

        //criando um método
        public void Deposita(double valor) //void não tem retorno
        {
            this.Saldo += valor; //this pega todos os valores da classe e os manipula
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldo();
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponíveis");
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public double ConsultaSaldo() //nesse caso ele tem retorno porque vai mostrar o saldo
        {
            return this.Saldo + this.Limite;
        }
    }
}