using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veja sua classificação de nadador\n");
            Console.WriteLine("Qual a sua idade?");
            int idade= int.Parse(Console.ReadLine());

            Console.WriteLine();

            if(idade<=4){
                Console.WriteLine("Ainda não tem idade para ser classificado");
            } else{
                if(idade<=7){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Classificação: Infantil A");
                }else{
                    if(idade<=10){
                        Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("Classificação: Infantil B"); 
                    }else{
                        if(idade<=13){
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Classificação: Juvenil A");
                        }else{
                            if(idade<=17){
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Classificação: Juvenil B");
                            }else{
                                if(idade>=18){
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Classificação: Sênior");
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}