using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-------------");
            short op = Convert.ToInt16(Console.ReadLine());

            switch(op){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            if (v1 != 0){
                double resultado = v1 / v2;
                Console.WriteLine($"O resultado da divisão é {resultado}");
            }
            else{
                Console.WriteLine("Operação invalida! Impossivel dividir por zero!");
            }
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}