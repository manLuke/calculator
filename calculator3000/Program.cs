using System;

namespace calculator3000
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Zadehte dvě čísla pro součet");
            // Console.WriteLine("První číslo: ");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Druhé číslo: ");
            // int num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Součet {num1 + num2}");
            // Console.Write("Odmocnina z čísla: ");
            // int n = int.Parse(Console.ReadLine());
            // Console.WriteLine("Výsledek " + Math.Sqrt(n));
            // Console.ReadKey();
            double num1, num2, result;
            bool end = false;
            while (!end) {
                Console.Write("Zadejte znaménko operace a poté dvě čísla nebo end pro konec: ");
                string o = Console.ReadLine();
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                if (o == "+")
                {
                    result = num1 + num2;
                }
                else if (o == "-")
                {
                    result = num1 - num2;
                }
                else if (o == "*")
                {
                    result = num1 * num2;
                }
                else if (o == "/")
                {
                    result = num1 / num2;
                }
                else if (o == "end")
                {
                    end = true;
                    return;
                }
                else
                {
                    result = 0;
                    Console.WriteLine("Operace není validní");
                }
                Console.WriteLine("Výsledek: " + result);
                Console.WriteLine(" ");
            }
        }
    }
}
