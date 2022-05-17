using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conver
{
    internal class Program
    {
        public static void unidad(int n)
        {
            switch (n)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
                default:
                    break;
            }
        }

        public static void decena(int n)
        {
            switch (n)
            {
                case 1: Console.Write("X"); break;
                case 2: Console.Write("XX"); break;
                case 3: Console.Write("XXX"); break;
                case 4: Console.Write("XL"); break;
                case 5: Console.Write("L"); break;
                case 6: Console.Write("LX"); break;
                case 7: Console.Write("LXX"); break;
                case 8: Console.Write("LXXX"); break;
                case 9: Console.Write("LC"); break;
                default:
                    break;
            }
        }

        public static void centena(int n)
        {
            switch (n)
            {
                case 1: Console.Write("C"); break;
                case 2: Console.Write("CC"); break;
                case 3: Console.Write("CCC"); break;
                case 4: Console.Write("CD"); break;
                case 5: Console.Write("D"); break;
                case 6: Console.Write("DC"); break;
                case 7: Console.Write("DCC"); break;
                case 8: Console.Write("DCCC"); break;
                case 9: Console.Write("MD"); break;
                default:
                    break;
            }
        }

        public static void unidadMIles(int n)
        {
            switch (n)
            {
                case 1: Console.Write("M"); break;
                case 2: Console.Write("MM"); break;
                case 3: Console.Write("MMM"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VLLL"); break;
                case 9: Console.Write("X"); break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            string imput, salida;
            int n, unidades, decenas, sentenas, unidadMil, decenasMil;
            int conteo = 0;
            do
            {
                do
                {
                    conteo = 0;
                    Console.Write("Bienvenido al convertidor de numeros indoarábigos a romanos.\n" +
                        "Por favor, introduzca un numero: ");
                    imput = Console.ReadLine();

                    if (!(int.TryParse(imput, out int num)))
                    {
                        Console.WriteLine("Entrada no valida!\n" +
                            "Letra(s) detectada(s)!");
                        conteo++;
                    }
                    else if (int.Parse(imput) == 0 || int.Parse(imput) > 99999)
                    {
                        Console.WriteLine("Entrada no valida!\n" +
                            "El valor no puede ser '0' o ser mayor que '99,999'.");
                        conteo++;
                    }
                    else if (int.Parse(imput) < 0)
                    {
                        Console.WriteLine("Entrada no valida!\nEl valor no puede ser negativo.");
                        conteo++;
                    }
                } while (conteo != 0);
                n = int.Parse(imput);

                unidades = n % 10;
                n = n / 10;

                decenas = n % 10;
                n = n / 10;

                sentenas = n % 10;
                n = n / 10;

                unidadMil = n % 10;
                n = n / 10;

                decenasMil = n % 10;
                n = n / 10;

                Console.WriteLine("Su valor en numeros romanos es: ");
                decena(decenasMil);
                unidadMIles(unidadMil);
                centena(sentenas);
                decena(decenas);
                unidad(unidades);
                Console.ReadKey();

                do
                {
                    Console.WriteLine("\nDesea salir? Y/N: ");
                    salida = Console.ReadLine();

                    if (salida.ToLower() == "y")
                    {
                        Console.WriteLine("Muchas gracias por usar la aplicación.\nAdios!");
                        break;
                    }
                    else if (salida.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Seleccione una opcion no valida!");
                    }
                } while (salida.ToLower() != "y");
            } while (salida.ToLower() != "y");
        }
    }
}
