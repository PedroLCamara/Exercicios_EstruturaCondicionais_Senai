using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade em anos?");
            int idadeAnos= int.Parse(Console.ReadLine());

            int idadeMeses= idadeAnos* 12;
            int idadeDias= idadeAnos* 365; 
            int idadeHoras= idadeDias* 24;
            int idadeMinutos= idadeHoras* 60;

            Console.WriteLine();

            Console.WriteLine("Sua idade em meses é "+idadeMeses);
            Console.WriteLine("Em dias, "+idadeDias);
            Console.WriteLine("Em horas, "+idadeHoras);
            Console.WriteLine("Em minutos, "+idadeMinutos);
        }
    }
}