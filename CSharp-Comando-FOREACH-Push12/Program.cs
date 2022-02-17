using System;

namespace LogicaDeProgramacao_P8_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Letícia", "Célio", "Luana", "Vanda", "Vanderlei" };
            foreach (string nome in nomes)
                Console.WriteLine(nome);
        }
    }
}
