using System;

namespace Manipulação_de_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um nome");
            var textoAntigo = Console.ReadLine();
            Console.WriteLine(textoAntigo.Replace(" ", ";"));
        }
    }
}
