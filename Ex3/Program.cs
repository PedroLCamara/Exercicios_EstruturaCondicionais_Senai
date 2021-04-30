using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite aqui seu salário para que possamos calcular o reajuste:");
            int primeiroSalario= int.Parse(Console.ReadLine());
            int segundoSalario= ((primeiroSalario/100)*30)+primeiroSalario;

            Console.WriteLine();

            if(primeiroSalario<=500){
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Após o reajuste, seu salário foi modificado para "+segundoSalario+", houve um aumento de 30%");
            } else{
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Salários superiores a 500 não são elegíveis ao reajuste");
            }
        }
    }
}
