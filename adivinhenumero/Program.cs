using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 1001); // 1 a 1000
        int tentativas = 0;

        Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
        Console.WriteLine("Tente adivinhar um número entre 1 e 1000");

        do
        {
            Console.Write("\nDigite seu número: ");
            int palpite;
            while (!int.TryParse(Console.ReadLine(), out palpite))
            {
                Console.WriteLine("Por favor, digite um número válido!");
                Console.Write("Digite seu palpite: ");
            }

            tentativas++;

            if (palpite == numeroSecreto)
            {
                Console.WriteLine($"\nParabéns! Você acertou em {tentativas} tentativas!");
                break;
            }

        } while (true);
    }
}
