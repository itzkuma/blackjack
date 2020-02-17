using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, acumulado = 0, turnos = 0;

            string Continuar = "s";
            bool condicion10 = false;



            while (total < 100 && Continuar == "s")
            {
                dado1 = aleatorio.Next(10, 13);
                total += dado1;
                turnos++;
                acumulado++;
                Console.WriteLine("llevas " + turnos + " turno(s)");
                Console.WriteLine("Dado=" + dado1);
                Console.WriteLine(" En Total llevas " + total + " puntos");


                if (turnos > 3 && (dado1 == 1 || dado1 == 3 || dado1 == 5 || dado1 == 7 || dado1 == 9 || dado1 == 11))
                {
                    Continuar = "n";
                    Console.WriteLine("Perdiste.. Ya no puedes continuar");

                }

                if (dado1 == 10) condicion10 = true;
                else if (dado1 != 12 && condicion10) condicion10 = false;
                Console.WriteLine(condicion10 + " + " + dado1);
                if ((condicion10 && dado1==12))
                {
                    Console.WriteLine("Ganastee!");
                    Continuar = "n";
                }
               

                else
                {
                    Console.WriteLine("Deseas Continuar? (s/n)");
                    Continuar = Console.ReadLine();

                }

            }
        }
    }
}







