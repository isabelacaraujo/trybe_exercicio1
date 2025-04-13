using System;

class Program
{
    static void Main()
    {
        while (true) // Loop infinito adicionado aqui
        {
            Console.Write("\nDigite uma palavra e descubra se é um palíndromo: ");
            string palavra = Console.ReadLine();
            
            palavra = palavra.ToLower();     

            string palavraSemEspacos = "";
            foreach (char letra in palavra)
            {
                if (letra != ' ')
                {
                    palavraSemEspacos += letra;
                }
            }
            
            bool ehPalindromo = true;
            for (int i = 0; i < palavraSemEspacos.Length / 2; i++)
            {
                int indiceFinal = palavraSemEspacos.Length - 1 - i;
                if (palavraSemEspacos[i] != palavraSemEspacos[indiceFinal])
                {
                    ehPalindromo = false;
                    break;
                }
            }
            
            if (ehPalindromo)
            {
                Console.WriteLine("É um palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo.");
            }
        }
    }
}