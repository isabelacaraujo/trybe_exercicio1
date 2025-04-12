using System;

class Program
{
    static void Main()
    {
        bool jogarNovamente;
        
        do
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 1001); // 1 a 1000
            int tentativas = 0;

            Console.WriteLine("\n=== JOGO DE ADIVINHAÇÃO ===");
            Console.WriteLine("Tente adivinhar um número entre 1 e 1000");

            do
            {
                Console.Write("\nDigite seu palpite: ");
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

                int diferenca = Math.Abs(palpite - numeroSecreto);
                string proximidade;

                if (diferenca > 100)
                {
                    proximidade = "muito distante";
                }
                else if (diferenca > 50)
                {
                    proximidade = "distante";
                }
                else
                {
                    proximidade = "perto";
                }

                Console.WriteLine(palpite < numeroSecreto 
                    ? $"O número é MAIOR - ({proximidade})" 
                    : $"O número é MENOR - ({proximidade})");

            } while (true);

            Console.WriteLine("\nDeseja jogar novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Escolha: ");
            
            jogarNovamente = (int.Parse(Console.ReadLine()) == 1);

        } while (jogarNovamente);

        Console.WriteLine("\nObrigado por jogar!");
    }
}
