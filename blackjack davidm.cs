using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_david
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0;
            int carta2 = 0;
            string continuar = "s";
            string sacarCarta = "c";

            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total );


            Console.WriteLine("deseas sacar una carta?(c/n)");
            sacarCarta = Console.ReadLine();
            while (continuar == "s" && sacarCarta =="c" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)
                    
                {                    
                  Console.WriteLine("perdiste!...ya no puedes continuar... total="+total );
                }
                else if (total == 21)
                    {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                    }
                    else
                       {
                        Console.WriteLine("total=" + total);
                        Console.WriteLine("deseas sacar una carta?(c/n)");
                        sacarCarta = Console.ReadLine();
                       }
            }
            Console.WriteLine("Juego finalizado");
        }
    }
}