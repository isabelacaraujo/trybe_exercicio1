using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        var alunos = new Dictionary<string, double>()
        {
            {"Isabela", 10},
            {"Cyntia", 9.9},
            {"Daniel", 9.5},
            {"Thiago", 6.5},
            {"Rafael", 6},
            {"Alexandra", 7.8},
            {"Felipe", 4.5},
            {"Julia", 8.1},
            {"Fernanda", 6.8},
            {"Gabriel", 7.2},
            {"Lucas", 3.0},
            {"Laura", 9.8}
        };

        double totalNotas = 0;
        int quantidadeAlunos = alunos.Count;

        foreach (var aluno in alunos)
        {
            totalNotas += aluno.Value; 
        }

        double media = totalNotas / quantidadeAlunos;

  
        Console.WriteLine("Resultado");
        Console.WriteLine($"Média da turma: {media.ToString("0.00")}");
    }
}