using System;

class Program
{
    static void Main()
    {
        string palavra = "trybe";
        char[] letrasDescobertas = new string('_', palavra.Length).ToCharArray();
        string letrasTentadas = "";
        
        Console.WriteLine("=== JOGO DA FORCA ===");

        while (new string(letrasDescobertas) != palavra)
        {
            Console.WriteLine("\nPalavra: " + new string(letrasDescobertas));
            Console.Write("Insira uma letra: ");
            char tentativa = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (letrasTentadas.Contains(tentativa))
            {
                Console.WriteLine("Você já tentou essa letra. Tente outra.");
                continue;
            }

            letrasTentadas += tentativa;

            if (palavra.Contains(tentativa))
            {
                Console.WriteLine("Essa letra tem!");
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == tentativa)
                    {
                        letrasDescobertas[i] = tentativa;
                    }
                }
            }
            else
            {
                Console.WriteLine("Essa letra não tem!");
            }
        }
    }
}