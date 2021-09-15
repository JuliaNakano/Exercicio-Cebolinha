using System;

namespace Exercicio_Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada, frasecomdislalia;
            Console.Write("Digite uma flase: ");
            frasedigitada= Console.ReadLine();

            frasecomdislalia = frasedigitada
            .Replace("l", "r")
            .Replace("r", "l")
            .Replace("R", "L")
            .Replace("L", "R");
            
            Console.WriteLine(frasecomdislalia);
        }
    }
}
