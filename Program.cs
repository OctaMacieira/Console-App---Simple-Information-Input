using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa? ");
            int qntosQuartos = Console.ReadLine();
            Console.WriteLine("Entre o preço de um produto: ");
            double precoProduto = Console.ReadLine();
            Console.WriteLine("Entre o seu útimo nome, idade e altura (mesma linha): ");
            string infoGeral = Console.ReadLine();

       
            string p1 = nomeCompleto;
            int p2 = qntosQuartos;
            double p3 = precoProduto;
            string[] vet = infoGeral.Split(' ');
            string p4 = vet[0];
            int p5 = vet[1];
            double p6 = vet[2];

            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[0]);
        }
    }

}
