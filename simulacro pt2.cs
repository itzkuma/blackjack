using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s", tirarDadoESP = "d";
            int dado = 0, dadoESP = 0, total = 0, vidas = 3, contadorESP = 2, acumulado = 0, contadorUno = 0, contador6 = 0;
            Random aleatorio = new Random();
            bool vidaExtra = false;
           

            while (total <= 100 && continuar == "s" && vidas != 0)
            {
                
                if (vidas == 0)
                {
                    Console.WriteLine("No te quedan vidas, perdiste!");
                    continuar = "n";

                }
                Console.WriteLine("Desea tirar un dado especial? solo puedes hacerlo 2 veces (D/N)");
                tirarDadoESP = Console.ReadLine();
                if (tirarDadoESP == "d" && contadorESP !=0)
                {
                    dadoESP = aleatorio.Next(1, 13);
                    dado = aleatorio.Next(0, 0);
                    total += dadoESP + dado;
                    acumulado++;
                    contadorESP--;
                    Console.WriteLine("Dado=" + dadoESP + dado);
                    Console.WriteLine(" En Total llevas " + total + " puntos");

                    if (dado == 6 || dadoESP == 6)
                    {
                        contador6++;
                        if (contador6 % 2 == 0)
                        {
                            vidaExtra = true;
                            if (vidaExtra && vidas < 3)
                                vidas++;
                        }
                    }
                    if (dado == 1 || dadoESP == 1)
                    {
                        contadorUno++;
                    }

                    if (contadorUno % 2 == 0)
                    {
                        Console.WriteLine("perdiste una vida");
                        vidas--;
                        Console.WriteLine("vidas=" + vidas);
                        Console.WriteLine("se restan 10 puntos del total, total= " + total);
                        total -= 10;
                        break;
                    }
                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                    dadoESP = aleatorio.Next(0, 0);
                    total += dadoESP + dado;
                    acumulado++;
                    Console.WriteLine("Dado=" + dadoESP + dado);
                    Console.WriteLine(" En Total llevas " + total + " puntos");
                    if (dado == 1 || dadoESP == 1)
                    {
                        contadorUno++;
                    }

                    if (dado == 6 || dadoESP == 6)
                    {
                        contador6++;
                        if (contador6 % 2 == 0)
                        {
                            vidaExtra = true;
                            if (vidaExtra && vidas < 3)
                                vidas++;
                        }

                        if (contadorUno % 2 == 0)
                        {
                            Console.WriteLine("perdiste una vida");
                            vidas--;
                            Console.WriteLine("vidas=" + vidas);
                            Console.WriteLine("se restan 10 puntos del total, total= " + total);
                            total -= 10;
                            break;
                        }
                    }





                }
            }
        }
    }
}
