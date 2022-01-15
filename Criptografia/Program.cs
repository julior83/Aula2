using System;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo aplicação de criptografia");
            Console.WriteLine("informe a senha");

            var senha = Console.ReadLine();
            var senhacriptografada = "";
            var random = new Random();
            for (int i = senha.Length; i >= 1; i--)
            {
                senhacriptografada += senha[i - 1].ToString() + random.Next(9);
            }
            Console.WriteLine(senhacriptografada);
            Console.ReadKey();
        }
    }
}
