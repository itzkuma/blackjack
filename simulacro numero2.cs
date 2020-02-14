using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0,  total = 0, dado2 = 0, acumulado=0 , dobles= 0;
            double mayor6 = 0;
            bool PrimeraV = true, Continuar = true;

            

            while (total<100 && Continuar==true) 
            {
                acumulado++;
                dado1 = 3/*1*/ /*aleatorio.Next(1,7)*/;
                dado2 = 3/*aleatorio.Next(1, 7)*//*1*/;
                if (dado1 + dado2 > 6)
                {
                    mayor6++;
                }
                if (dado1==dado2 )
                {
                    dobles++;
                    Console.WriteLine("llevas " + dobles + "pares");
                    if (dobles == 3)
                    {
                        Console.WriteLine("GaNASTE PENDEJA.. por 3 PARESS");
                        double promedio = (mayor6 / acumulado) * 100;
                        Console.WriteLine("tu porcentaje de suma dados mayor a 6 fue de: " + promedio);
                        break;
                    }

                }
                
                if (PrimeraV==true)
                {                   
                    PrimeraV = false;                    
                    total += dado1 + dado2;
                    Console.WriteLine("Dado1 = " + dado1 +" Dado2 = " + dado2 + " En Total llevas " + total + " puntos");
                    Console.WriteLine("llevas " + acumulado + "turno(s)");
                    if (dado1 == 1 && dado2 == 1)
                    {
                       Console.WriteLine("perdiste!... ya no puedes continuar pendeja...Jugaste " + acumulado + " Turnos");
                        break;
                    }
                }
                else if (dado1 != 1 || dado2 !=1)
                {
                    total+= dado1 + dado2;
                    Console.WriteLine("tus nuevos dados son: " + "Dado1= " + dado1 + " Dado2= " + dado2 + " En Total llevas " + total + " puntos");
                    if (total>=100)
                    {
                        Console.WriteLine("GaNASTE PENDEJA");
                        double promedio = (mayor6 / acumulado) * 100;
                        Console.WriteLine("tu porcentaje de suma dados mayor a 6 fue de: " + promedio);
                        break;
                    }
                }
                else if ( dado1 ==1 && dado2==1)
                {                  
                    Console.WriteLine("Dado1= " + dado1 + "Dado2= " + dado2);
                    Console.WriteLine("perdiste!... ya no puedes continuar pendeja...Jugaste " + acumulado + " Turnos" );                    
                    break;
                }
                Console.WriteLine("Desea Continuar? (s/n)");
                if (Console.ReadLine().Equals("s"))
                {
                    Continuar = true;
                }
                else
                {
                    double promedio = (mayor6/acumulado) * 100;
                    Console.WriteLine("tu porcentaje de suma dados mayor a 6 fue de: " + promedio);
                    Continuar = false;
                    break;
                }
               




            }

        }
    }
}
