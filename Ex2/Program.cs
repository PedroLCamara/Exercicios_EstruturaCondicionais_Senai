using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu ano de nascimento?");
            int anoNascimento= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o ano atual?");
            int anoAtual= int.Parse(Console.ReadLine());

            int idade= anoAtual - anoNascimento;
            int idadeSemanas= idade* 52;

            Console.WriteLine();

            Console.WriteLine("Você tem aproximadamente "+idade+" anos. Sua idade em semanas é de aproximadamente "+idadeSemanas);
        }
    }
}
