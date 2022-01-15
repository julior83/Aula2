using System;

namespace Exercicio_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe idade");
            var idade = Console.ReadLine();
            var numero = Convert.ToInt32(idade);

            if (numero >= 13 && numero < 19) {
            }
            Console.WriteLine("Adolescente");
            else if (numero >= 19 && numero <= 60)
            {
            Console.WriteLine("Adulto");
            } else if (idade > 60)
            {
                Console.WriteLine("Idoso");
            } else
            {
                Console.WriteLine ("Criança")
            }
            


        }
    }
}
