using System.Runtime.CompilerServices;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Banco da Lelê do Grau!");
            
            //instanciar a classe Conta e criar um objeto dela
            Conta conta=new Conta();
            Console.WriteLine("Consultando o saldo");
            conta.consulta_saldo();

            Console.WriteLine("Depositando de R$1000.55");
            conta.depositar(1000.35);
            Console.WriteLine("Consultando o saldo");
            conta.consulta_saldo();

            //Console.WriteLine("Sacando R$500.55");
            //conta.sacar(500);
            //Console.WriteLine("Consultando o saldo");
            //conta.consulta_saldo();

            //Console.WriteLine("Sacando 1000");
            //conta.sacar(1000);

            Console.WriteLine("Definindo limite de 1000");
            conta.ajusta_limite(1000);
            conta.consulta_saldo();
            conta.sacar(2000);
            conta.consulta_saldo();
        }
    }
}