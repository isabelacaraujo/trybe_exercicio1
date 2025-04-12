class Program
{
    static void Main()
    {
        string palavra = "trybe";
        char[] letrasDescobertas = new string('_', palavra.Length).ToCharArray();
        
        Console.WriteLine("=== JOGO DA FORCA ===");

        while (new string(letrasDescobertas) != palavra)
        {
            Console.WriteLine("\nPalavra: " + new string(letrasDescobertas));
            Console.Write("Insira uma letra: ");
            char tentativa = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
        }
    }
}