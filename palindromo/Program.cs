class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra e descubra se é um palíndromo: ");
        string p = Console.ReadLine().ToLower();
        Console.WriteLine(p == new string(p.Reverse().ToArray()) ? "É um palíndromo!" : "Não é um palíndromo!");
    }
}
